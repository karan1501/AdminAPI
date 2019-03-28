using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{
    public class ResponseDetail
    {
        public string Message { get; set; }

        public bool Success { get; set; }

        public object Access_token { get; set; }

        public object Refresh_token { get; set; }

        public object Data { get; set; }
    }
}
