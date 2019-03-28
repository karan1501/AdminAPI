using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AdminAPI.Models;
using AdminAPI.Repository;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Xml2CSharp;

namespace AdminAPI.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly UserManager<AdminUser> _userManager;
        private readonly IDataRepository<Employee> _dataRepository;
        public IConfiguration Configuration { get; }

        public EmployeeController(IDataRepository<Employee> dataRepository, IConfiguration configuration, UserManager<AdminUser> userManager)
        {
            _userManager = userManager;
            _dataRepository = dataRepository;
            Configuration = configuration;
        }

        // GET: api/Employee
        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Route("GetAllEmployees")]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }

        // GET: api/Employee/5
        [HttpGet]
        [Route("GetEmployeeById")]
        public IActionResult Get(long id)
        {
            Employee employee = _dataRepository.Get(id);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        [Route("CreateEmployee")]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            _dataRepository.Add(employee);
            return CreatedAtRoute(
                  "Get",
                  new { Id = employee.EmployeeId },
                  employee);
        }

        [HttpPost]
        [Route("CreateUser")]
        public async Task<object> CreateUserAsync([FromBody]AdminUser employee)
        {
            ResponseDetail response = new ResponseDetail();
            try
            {
                if (employee == null)
                {
                    return BadRequest("Employee is null.");
                }
                var chkUser = await _userManager.CreateAsync(employee, employee.Password);
                if (chkUser.Succeeded)
                {
                    response.Success = true;
                    response.Message = "Registered Successfully !";
                }
                return response;
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;

                return response;
            }
        }


        [HttpPost]
        [Route("Login")]
        public async Task<object> LoginAsync([FromBody] LoginModel loginModel)
        {
            ResponseDetail response = new ResponseDetail();
            try
            {
                if (loginModel == null)
                {
                    return BadRequest("Employee is null.");
                }
                var user = await _userManager.FindByNameAsync(loginModel.UserName);
                if (user == null)
                {
                    response.Success = false;
                    response.Message = "Invalid UserName or Password !";
                }
                else
                {
                    if (await _userManager.CheckPasswordAsync(user, loginModel.Password))
                    {
                        response.Success = true;
                        response.Message = "Login Successfully !";
                        response.Access_token = GenerateJWT();
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "Invalid UserName or Password !";
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;

                return response;
            }
        }


        // PUT: api/Employee/5
        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            Employee employeeToUpdate = _dataRepository.Get(id);
            if (employeeToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Update(employeeToUpdate, employee);
            return NoContent();
        }

        // DELETE: api/Employee/5
        [HttpDelete]
        [Route("DeleteEmployee")]
        public IActionResult Delete(long id)
        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Delete(employee);
            return NoContent();
        }
        
        private string GenerateJWT()
        {
            var issuer = Configuration.GetSection("TokenAuthentication:Issuer").Value;
            var audience = Configuration.GetSection("TokenAuthentication:Audience").Value;
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("TokenAuthentication:SecretKey").Value));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: issuer, audience: audience, expires: DateTime.Now.AddMinutes(120), signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }

        //private bool ValidateUser(User loginDetails)
        //{
        //    if (loginDetails.UserName == "User1" && loginDetails.Password == "pass$word")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}