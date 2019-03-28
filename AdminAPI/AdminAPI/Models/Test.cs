/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "Header", Namespace = "http://www.pcamobile.com/marlin")]
    public class Header
    {
        [XmlElement(ElementName = "Version", Namespace = "http://www.pcamobile.com/marlin")]
        public string Version { get; set; }
        [XmlElement(ElementName = "CompanyID", Namespace = "http://www.pcamobile.com/marlin")]
        public string CompanyID { get; set; }
        [XmlElement(ElementName = "MessageID", Namespace = "http://www.pcamobile.com/marlin")]
        public string MessageID { get; set; }
        [XmlElement(ElementName = "MessageType", Namespace = "http://www.pcamobile.com/marlin")]
        public string MessageType { get; set; }
        [XmlElement(ElementName = "TestMessage", Namespace = "http://www.pcamobile.com/marlin")]
        public string TestMessage { get; set; }
    }

    [XmlRoot(ElementName = "User", Namespace = "http://www.pcamobile.com/marlin")]
    public class User
    {
        [XmlElement(ElementName = "LoginName", Namespace = "http://www.pcamobile.com/marlin")]
        public string LoginName { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://www.pcamobile.com/marlin")]
        public string Name { get; set; }
        [XmlElement(ElementName = "IsEndUser", Namespace = "http://www.pcamobile.com/marlin")]
        public string IsEndUser { get; set; }
        [XmlElement(ElementName = "IsMobileUser", Namespace = "http://www.pcamobile.com/marlin")]
        public string IsMobileUser { get; set; }
        [XmlElement(ElementName = "IsOutboundUser", Namespace = "http://www.pcamobile.com/marlin")]
        public string IsOutboundUser { get; set; }
    }

    [XmlRoot(ElementName = "Created", Namespace = "http://www.pcamobile.com/marlin")]
    public class Created
    {
        [XmlElement(ElementName = "DateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string DateTime { get; set; }
        [XmlElement(ElementName = "User", Namespace = "http://www.pcamobile.com/marlin")]
        public User User { get; set; }
    }

    [XmlRoot(ElementName = "Modified", Namespace = "http://www.pcamobile.com/marlin")]
    public class Modified
    {
        [XmlElement(ElementName = "DateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string DateTime { get; set; }
        [XmlElement(ElementName = "User", Namespace = "http://www.pcamobile.com/marlin")]
        public User User { get; set; }
    }

    [XmlRoot(ElementName = "Tracing", Namespace = "http://www.pcamobile.com/marlin")]
    public class Tracing
    {
        [XmlElement(ElementName = "Created", Namespace = "http://www.pcamobile.com/marlin")]
        public Created Created { get; set; }
        [XmlElement(ElementName = "Modified", Namespace = "http://www.pcamobile.com/marlin")]
        public Modified Modified { get; set; }
    }

    [XmlRoot(ElementName = "Call", Namespace = "http://www.pcamobile.com/marlin")]
    public class Call
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.pcamobile.com/marlin")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Contact", Namespace = "http://www.pcamobile.com/marlin")]
        public string Contact { get; set; }
        [XmlElement(ElementName = "DateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string DateTime { get; set; }
        [XmlElement(ElementName = "Intaker", Namespace = "http://www.pcamobile.com/marlin")]
        public string Intaker { get; set; }
    }

    [XmlRoot(ElementName = "Time", Namespace = "http://www.pcamobile.com/marlin")]
    public class Time
    {
        [XmlElement(ElementName = "Duration", Namespace = "http://www.pcamobile.com/marlin")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "SplitOnShiftEnd", Namespace = "http://www.pcamobile.com/marlin")]
        public string SplitOnShiftEnd { get; set; }
        [XmlElement(ElementName = "SplitAllowed", Namespace = "http://www.pcamobile.com/marlin")]
        public string SplitAllowed { get; set; }
    }

    [XmlRoot(ElementName = "Resource", Namespace = "http://www.pcamobile.com/marlin")]
    public class Resource
    {
        [XmlElement(ElementName = "NumberOfRequiredResources", Namespace = "http://www.pcamobile.com/marlin")]
        public string NumberOfRequiredResources { get; set; }
        [XmlElement(ElementName = "ExternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExternalCode { get; set; }
        [XmlElement(ElementName = "ResourceClass", Namespace = "http://www.pcamobile.com/marlin")]
        public string ResourceClass { get; set; }
        [XmlElement(ElementName = "LoginName", Namespace = "http://www.pcamobile.com/marlin")]
        public string LoginName { get; set; }
    }

    [XmlRoot(ElementName = "Constraints", Namespace = "http://www.pcamobile.com/marlin")]
    public class Constraints
    {
        [XmlElement(ElementName = "Time", Namespace = "http://www.pcamobile.com/marlin")]
        public Time Time { get; set; }
        [XmlElement(ElementName = "Resource", Namespace = "http://www.pcamobile.com/marlin")]
        public Resource Resource { get; set; }
    }

    [XmlRoot(ElementName = "State", Namespace = "http://www.pcamobile.com/marlin")]
    public class State
    {
        [XmlElement(ElementName = "InternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string InternalCode { get; set; }
        [XmlElement(ElementName = "MdsInternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string MdsInternalCode { get; set; }
        [XmlElement(ElementName = "ExternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExternalCode { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://www.pcamobile.com/marlin")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StartDateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string StartDateTime { get; set; }
        [XmlElement(ElementName = "State", Namespace = "http://www.pcamobile.com/marlin")]
        public State States { get; set; }
        [XmlElement(ElementName = "StateInfo", Namespace = "http://www.pcamobile.com/marlin")]
        public string StateInfo { get; set; }
        [XmlElement(ElementName = "ReAllocate", Namespace = "http://www.pcamobile.com/marlin")]
        public string ReAllocate { get; set; }
        [XmlElement(ElementName = "KeepCurrentResource", Namespace = "http://www.pcamobile.com/marlin")]
        public string KeepCurrentResource { get; set; }
        [XmlElement(ElementName = "AnybodyButCurrentResource", Namespace = "http://www.pcamobile.com/marlin")]
        public string AnybodyButCurrentResource { get; set; }
    }

    [XmlRoot(ElementName = "States", Namespace = "http://www.pcamobile.com/marlin")]
    public class States
    {
        [XmlElement(ElementName = "State", Namespace = "http://www.pcamobile.com/marlin")]
        public List<State> State { get; set; }
    }

    [XmlRoot(ElementName = "Visit", Namespace = "http://www.pcamobile.com/marlin")]
    public class Visit
    {
        [XmlElement(ElementName = "InternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string InternalCode { get; set; }
        [XmlElement(ElementName = "StartDateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string StartDateTime { get; set; }
        [XmlElement(ElementName = "FinishDateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string FinishDateTime { get; set; }
        [XmlElement(ElementName = "ResourceCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ResourceCode { get; set; }
    }

    [XmlRoot(ElementName = "Visits", Namespace = "http://www.pcamobile.com/marlin")]
    public class Visits
    {
        [XmlElement(ElementName = "Visit", Namespace = "http://www.pcamobile.com/marlin")]
        public Visit Visit { get; set; }
    }

    [XmlRoot(ElementName = "Allocation", Namespace = "http://www.pcamobile.com/marlin")]
    public class Allocation
    {
        [XmlElement(ElementName = "InternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string InternalCode { get; set; }
        [XmlElement(ElementName = "Tracing", Namespace = "http://www.pcamobile.com/marlin")]
        public Tracing Tracing { get; set; }
        [XmlElement(ElementName = "Modified", Namespace = "http://www.pcamobile.com/marlin")]
        public string Modified { get; set; }
        [XmlElement(ElementName = "Obsolete", Namespace = "http://www.pcamobile.com/marlin")]
        public string Obsolete { get; set; }
        [XmlElement(ElementName = "StartDateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string StartDateTime { get; set; }
        [XmlElement(ElementName = "FinishDateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string FinishDateTime { get; set; }
        [XmlElement(ElementName = "Duration", Namespace = "http://www.pcamobile.com/marlin")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "Resource", Namespace = "http://www.pcamobile.com/marlin")]
        public Resource Resource { get; set; }
        [XmlElement(ElementName = "States", Namespace = "http://www.pcamobile.com/marlin")]
        public States States { get; set; }
        [XmlElement(ElementName = "Visits", Namespace = "http://www.pcamobile.com/marlin")]
        public Visits Visits { get; set; }
        [XmlElement(ElementName = "CreationDateTime", Namespace = "http://www.pcamobile.com/marlin")]
        public string CreationDateTime { get; set; }
        [XmlElement(ElementName = "SchedulePending", Namespace = "http://www.pcamobile.com/marlin")]
        public string SchedulePending { get; set; }
        [XmlElement(ElementName = "ThroughChainIntegration", Namespace = "http://www.pcamobile.com/marlin")]
        public string ThroughChainIntegration { get; set; }
    }

    [XmlRoot(ElementName = "Allocations", Namespace = "http://www.pcamobile.com/marlin")]
    public class Allocations
    {
        [XmlElement(ElementName = "Allocation", Namespace = "http://www.pcamobile.com/marlin")]
        public List<Allocation> Allocation { get; set; }
    }

    [XmlRoot(ElementName = "Distribution", Namespace = "http://www.pcamobile.com/marlin")]
    public class Distribution
    {
        [XmlElement(ElementName = "InternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string InternalCode { get; set; }
        [XmlElement(ElementName = "Tracing", Namespace = "http://www.pcamobile.com/marlin")]
        public Tracing Tracing { get; set; }
        [XmlElement(ElementName = "Allocations", Namespace = "http://www.pcamobile.com/marlin")]
        public Allocations Allocations { get; set; }
        [XmlElement(ElementName = "Modified", Namespace = "http://www.pcamobile.com/marlin")]
        public string Modified { get; set; }
        [XmlElement(ElementName = "Obsolete", Namespace = "http://www.pcamobile.com/marlin")]
        public string Obsolete { get; set; }
    }

    [XmlRoot(ElementName = "Distributions", Namespace = "http://www.pcamobile.com/marlin")]
    public class Distributions
    {
        [XmlElement(ElementName = "Distribution", Namespace = "http://www.pcamobile.com/marlin")]
        public List<Distribution> Distribution { get; set; }
    }

    [XmlRoot(ElementName = "Relation", Namespace = "http://www.pcamobile.com/marlin")]
    public class Relation
    {
        [XmlElement(ElementName = "FirstName", Namespace = "http://www.pcamobile.com/marlin")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName", Namespace = "http://www.pcamobile.com/marlin")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "Phone", Namespace = "http://www.pcamobile.com/marlin")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "Mobile", Namespace = "http://www.pcamobile.com/marlin")]
        public string Mobile { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "http://www.pcamobile.com/marlin")]
        public string Email { get; set; }
    }

    [XmlRoot(ElementName = "Location", Namespace = "http://www.pcamobile.com/marlin")]
    public class Location
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.pcamobile.com/marlin")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Street", Namespace = "http://www.pcamobile.com/marlin")]
        public string Street { get; set; }
        [XmlElement(ElementName = "Nr", Namespace = "http://www.pcamobile.com/marlin")]
        public string Nr { get; set; }
        [XmlElement(ElementName = "ZipCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ZipCode { get; set; }
        [XmlElement(ElementName = "City", Namespace = "http://www.pcamobile.com/marlin")]
        public string City { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "http://www.pcamobile.com/marlin")]
        public string Country { get; set; }
        [XmlElement(ElementName = "Latitude", Namespace = "http://www.pcamobile.com/marlin")]
        public string Latitude { get; set; }
        [XmlElement(ElementName = "Longitude", Namespace = "http://www.pcamobile.com/marlin")]
        public string Longitude { get; set; }
    }

    [XmlRoot(ElementName = "ContactPerson", Namespace = "http://www.pcamobile.com/marlin")]
    public class ContactPerson
    {
        [XmlElement(ElementName = "FirstName", Namespace = "http://www.pcamobile.com/marlin")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName", Namespace = "http://www.pcamobile.com/marlin")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "Phone", Namespace = "http://www.pcamobile.com/marlin")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "Mobile", Namespace = "http://www.pcamobile.com/marlin")]
        public string Mobile { get; set; }
    }

    [XmlRoot(ElementName = "VisitAddress", Namespace = "http://www.pcamobile.com/marlin")]
    public class VisitAddress
    {
        [XmlElement(ElementName = "Relation", Namespace = "http://www.pcamobile.com/marlin")]
        public Relation Relation { get; set; }
        [XmlElement(ElementName = "Location", Namespace = "http://www.pcamobile.com/marlin")]
        public Location Location { get; set; }
        [XmlElement(ElementName = "ContactPerson", Namespace = "http://www.pcamobile.com/marlin")]
        public ContactPerson ContactPerson { get; set; }
    }

    [XmlRoot(ElementName = "ExtraFields", Namespace = "http://www.pcamobile.com/marlin")]
    public class ExtraFields
    {
        [XmlElement(ElementName = "ExtraText1", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExtraText1 { get; set; }
        [XmlElement(ElementName = "ExtraText3", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExtraText3 { get; set; }
    }

    [XmlRoot(ElementName = "Info", Namespace = "http://www.pcamobile.com/marlin")]
    public class Info
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.pcamobile.com/marlin")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "http://www.pcamobile.com/marlin")]
        public string Value { get; set; }
        [XmlElement(ElementName = "DataType", Namespace = "http://www.pcamobile.com/marlin")]
        public string DataType { get; set; }
        [XmlElement(ElementName = "OrderID", Namespace = "http://www.pcamobile.com/marlin")]
        public string OrderID { get; set; }
    }

    [XmlRoot(ElementName = "ExtraInfo", Namespace = "http://www.pcamobile.com/marlin")]
    public class ExtraInfo
    {
        [XmlElement(ElementName = "Info", Namespace = "http://www.pcamobile.com/marlin")]
        public List<Info> Info { get; set; }
        [XmlElement(ElementName = "InstallationProperties", Namespace = "http://www.pcamobile.com/marlin")]
        public InstallationProperties InstallationProperties { get; set; }
    }

    [XmlRoot(ElementName = "Installation", Namespace = "http://www.pcamobile.com/marlin")]
    public class Installation
    {
        [XmlElement(ElementName = "ExternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExternalCode { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "http://www.pcamobile.com/marlin")]
        public string Description { get; set; }
        [XmlElement(ElementName = "FreeContent", Namespace = "http://www.pcamobile.com/marlin")]
        public FreeContent FreeContent { get; set; }
    }

    [XmlRoot(ElementName = "Installations", Namespace = "http://www.pcamobile.com/marlin")]
    public class Installations
    {
        [XmlElement(ElementName = "Installation", Namespace = "http://www.pcamobile.com/marlin")]
        public Installation Installation { get; set; }
    }

    [XmlRoot(ElementName = "Document", Namespace = "http://www.pcamobile.com/marlin")]
    public class Document
    {
        [XmlElement(ElementName = "Installations", Namespace = "http://www.pcamobile.com/marlin")]
        public Installations Installations { get; set; }
        [XmlElement(ElementName = "Installation", Namespace = "http://www.pcamobile.com/marlin")]
        public Installation Installation { get; set; }
        [XmlElement(ElementName = "ExternalSourceID", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExternalSourceID { get; set; }
        [XmlAttribute(AttributeName = "marlin", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Marlin { get; set; }
    }

    [XmlRoot(ElementName = "FreeContent", Namespace = "http://www.pcamobile.com/marlin")]
    public class FreeContent
    {
        [XmlElement(ElementName = "Document", Namespace = "http://www.pcamobile.com/marlin")]
        public Document Document { get; set; }
    }

    [XmlRoot(ElementName = "Task", Namespace = "http://www.pcamobile.com/marlin")]
    public class Task
    {
        [XmlElement(ElementName = "InternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string InternalCode { get; set; }
        [XmlElement(ElementName = "ExternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExternalCode { get; set; }
        [XmlElement(ElementName = "Tracing", Namespace = "http://www.pcamobile.com/marlin")]
        public Tracing Tracing { get; set; }
        [XmlElement(ElementName = "Reference", Namespace = "http://www.pcamobile.com/marlin")]
        public string Reference { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "http://www.pcamobile.com/marlin")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Info", Namespace = "http://www.pcamobile.com/marlin")]
        public string Info { get; set; }
        [XmlElement(ElementName = "Class", Namespace = "http://www.pcamobile.com/marlin")]
        public string Class { get; set; }
        [XmlElement(ElementName = "FreeTask", Namespace = "http://www.pcamobile.com/marlin")]
        public string FreeTask { get; set; }
        [XmlElement(ElementName = "Call", Namespace = "http://www.pcamobile.com/marlin")]
        public Call Call { get; set; }
        [XmlElement(ElementName = "Constraints", Namespace = "http://www.pcamobile.com/marlin")]
        public Constraints Constraints { get; set; }
        [XmlElement(ElementName = "Distributions", Namespace = "http://www.pcamobile.com/marlin")]
        public Distributions Distributions { get; set; }
        [XmlElement(ElementName = "PendingSchedules", Namespace = "http://www.pcamobile.com/marlin")]
        public string PendingSchedules { get; set; }
        [XmlElement(ElementName = "Customer", Namespace = "http://www.pcamobile.com/marlin")]
        public string Customer { get; set; }
        [XmlElement(ElementName = "VisitAddress", Namespace = "http://www.pcamobile.com/marlin")]
        public VisitAddress VisitAddress { get; set; }
        [XmlElement(ElementName = "ExtraFields", Namespace = "http://www.pcamobile.com/marlin")]
        public ExtraFields ExtraFields { get; set; }
        [XmlElement(ElementName = "ExtraInfo", Namespace = "http://www.pcamobile.com/marlin")]
        public ExtraInfo ExtraInfo { get; set; }
        [XmlElement(ElementName = "FreeContent", Namespace = "http://www.pcamobile.com/marlin")]
        public FreeContent FreeContent { get; set; }
        [XmlElement(ElementName = "PlannedMaterials", Namespace = "http://www.pcamobile.com/marlin")]
        public PlannedMaterials PlannedMaterials { get; set; }
    }

    [XmlRoot(ElementName = "Article", Namespace = "http://www.pcamobile.com/marlin")]
    public class Article
    {
        [XmlElement(ElementName = "ExternalCode", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExternalCode { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "http://www.pcamobile.com/marlin")]
        public string Description { get; set; }
    }

    [XmlRoot(ElementName = "Material", Namespace = "http://www.pcamobile.com/marlin")]
    public class Material
    {
        [XmlElement(ElementName = "Article", Namespace = "http://www.pcamobile.com/marlin")]
        public Article Article { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://www.pcamobile.com/marlin")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "MustUse", Namespace = "http://www.pcamobile.com/marlin")]
        public string MustUse { get; set; }
    }

    [XmlRoot(ElementName = "PlannedMaterials", Namespace = "http://www.pcamobile.com/marlin")]
    public class PlannedMaterials
    {
        [XmlElement(ElementName = "Material", Namespace = "http://www.pcamobile.com/marlin")]
        public List<Material> Material { get; set; }
    }

    [XmlRoot(ElementName = "InstallationProperties", Namespace = "http://www.pcamobile.com/marlin")]
    public class InstallationProperties
    {
        [XmlElement(ElementName = "Order", Namespace = "http://www.pcamobile.com/marlin")]
        public string Order { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://www.pcamobile.com/marlin")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "http://www.pcamobile.com/marlin")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "Tasks", Namespace = "http://www.pcamobile.com/marlin")]
    public class Tasks
    {
        [XmlElement(ElementName = "Task", Namespace = "http://www.pcamobile.com/marlin")]
        public List<Task> Task { get; set; }
    }

    [XmlRoot(ElementName = "RpViewTasks", Namespace = "http://www.pcamobile.com/marlin")]
    public class RpViewTasks
    {
        [XmlElement(ElementName = "ExecutionStatus", Namespace = "http://www.pcamobile.com/marlin")]
        public string ExecutionStatus { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.pcamobile.com/marlin")]
        public string Total { get; set; }
        [XmlElement(ElementName = "Tasks", Namespace = "http://www.pcamobile.com/marlin")]
        public Tasks Tasks { get; set; }
    }

    [XmlRoot(ElementName = "RqOutboundMessage", Namespace = "http://www.pcamobile.com/marlin")]
    public class RqOutboundMessage
    {
        [XmlElement(ElementName = "Header", Namespace = "http://www.pcamobile.com/marlin")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "RpViewTasks", Namespace = "http://www.pcamobile.com/marlin")]
        public RpViewTasks RpViewTasks { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "RqOutboundMessage", Namespace = "http://www.pcamobile.com/marlin")]
        public RqOutboundMessage RqOutboundMessage { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }

}
