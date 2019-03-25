using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MultiSpeak4
{
	/// <summary>
    /// MultiSpeak Version 4.1.6 Web Services Definitions AM.
    /// Dated August 31, 2012
	/// Summary description for Web Services Hosted by Meter Reading(MR).
	/// </summary>
 
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class MR_Server : System.Web.Services.WebService
    {


        public MultiSpeakMsgHeader MultiSpeakMsgHeader;


        public MR_Server()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
        }


	#region Generic for each interface

        [WebMethod(Description="Requester pings URL of MR to see if it is alive.   Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] PingURL() {
            return null;
        }

        [WebMethod(Description="Requester requests a list of methods supported by MR.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public string[] GetMethods() {
            return null;
        }

        [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server. It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public string[] GetDomainNames() 
		{
			return null;
		}
		[WebMethod(Description="The client requests from the server the members of a specific domain of information, identified by the domainName parameter, which are supported by the server.  This method is used, along with the GetDomainNames method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public domainMember[] GetDomainMembers(string domainName) 
		{
			return null;
		}

        [WebMethod(Description = "This service requests of the publisher a unique registration ID that would subsequently be used to refer unambiguously to that specific subscription.  The return parameter is the registrationID, which is a string-type value.  It is recommended that the server not implement registration in such a manner that one client can guess the registrationID of another.  For instance the use of sequential numbers for registrationIDs is discouraged.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string RequestRegistrationID()
        {
            return null;
        }

        [WebMethod(Description = "This method establishs a subscription using a previously requested registrationID. The calling parameter registrationInfo is a complex type that includes the following information: registrationID - the previously requested registrationID obtained from the publisher by calling RequestRegistrationID, responseURL – the URL to which information should subsequently be published on this subscription, msFunction – the abbreviated string name of the MultiSpeak method making the subscription request (for instance, if an application that exposes the Meter Reading function has made the request, then the msFunction variable should include “MR”), methodsList – An array of strings that contain the string names of the MultiSpeak methods to which the subscriber would like to subscribe.  Subsequent calls to RegisterForService on an existing subscription replace prior subscription details in their entirety - they do NOT add to an existing subscription.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RegisterForService(registrationInfo registrationDetails)
        {
            return null;
        }

        [WebMethod(Description = "This method deletes a previously established subscription (registration for service) that carries the registration identifer listed in the input parameter registrationID.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UnregisterForService(string registrationID)
        {
            return null;
        }

        [WebMethod(Description = "This method requests the return of existing registration information (that is to say the details of what is subscribed on this subscription) for a specific registrationID.  The server should return a SOAPFault if the registrationID is not valid.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public registrationInfo GetRegistrationInfoByID(string registrationID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests list of methods to which this server can publish information.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetPublishMethods()
        {
            return null;
        }
        [WebMethod(Description = "This method permits a client to have changed information on domain members published to it using a previously arranged subscription, set up using the RegisterForServiceMethod. The client should first obtain a registrationID and then register for service, including the DomainMembersChangedNotification as one of the methods in the list of methods to which the client has subscribed.  The server shall include the registrationID for the subscription in the message header so that the client can determine the source of the  domainMember information. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DomainMembersChangedNotification(domainMember[] changedDomainMembers)
        {
            return null;
        }
        [WebMethod(Description = "This method permits a client to have changed information on domain names published to it using a previously arranged subscription, set up using the RegisterForServiceMethod. The client should first obtain a registrationID and then register for service, including the DomainNamesChangedNotification as one of the methods in the list of methods to which the client has subscribed.  The server shall include the registrationID for the subscription in the message header so that the client can determine the source of the  domainName information. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DomainNamesChangedNotification(domainNameChange[] changedDomainNames)
        {
            return null;
        }

	#endregion

	#region Methods to Get Data from the MR

        [WebMethod(Description = "Returns all meters that have AMR.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meters GetAMRSupportedMeters(string lastReceived) {
            return null;
        }

        [WebMethod(Description = "Returns all meters that support AMR and that have been modified since the specified sessionID.   The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public meters GetModifiedAMRMeters(string previousSessionID, string lastReceived) 
		{
			return null;
		}

        [WebMethod(Description="Return true if given meterID has AMR. Otherwise return false.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public bool IsAMRMeter(meterID meterID)
        {
            return false;
        }

        [WebMethod(Description = "Returns reading data for all meters given a date range. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meterReading[] GetReadingsByDate(System.DateTime startDate, System.DateTime endDate, string lastReceived) {      
            return null;             
        }

		[WebMethod(Description = "Returns meter reading data for a given MeterID and date range.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterReading[] GetReadingsByMeterID(meterID meterID, System.DateTime startDate, System.DateTime endDate)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns readings for a list of meters, identified by meterIDs, for a specific date range and reading types desired. Reading types may be specified using the fieldName parameter. Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public intervalData[] GetReadingsByMeterIDListAndFieldNameIntervalData(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate, string lastReceived, string[] fieldName)
		{
			return null;
		}

        [WebMethod(Description="Returns the most recent meter reading data for a given MeterID.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meterReading GetLatestReadingByMeterID(meterID meterID)
        {                         
            return null;                   
        }

        [WebMethod(Description = "Returns all required reading data for a given billingCycle and date range in the form of an array of formattedBlocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameters include: (i) billingCycle - the CB billing cycle for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (v) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) (vi) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public formattedBlock[] GetReadingsByBillingCycle(string billingCycle, System.DateTime billingDate, int kWhLookBack, int kWLookBack, int kWLookForward, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
        {
            return null;
        }
		
        [WebMethod(Description = "Returns reading data for a given meter and billing date.  Reading(s)are returned in the form of an array of formattedBlocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameters include: (i) meterID - the meter identifier for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (v) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) (vi) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetReadingByMeterIDFormattedBlock(meterID meterID, System.DateTime billingDate, int kWhLookBack, int kWLookBack, int kWLookForward, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
        {
            return null;
        }

        [WebMethod(Description = "Returns reading data for all billing cycles given a billing date.  Reading(s) are returned in the form of an array of formattedBlocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameters include: (i) billing date - the end date of the billing cycle, (ii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iii) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) and (v) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetReadingsByDateFormattedBlock(System.DateTime billingDate, int kWhLookBack, int kWLookBack, int kWLookForward, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
        {
            return null;
        }
        [WebMethod(Description="Returns history log data for a given meterID and date range.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public historyLog[] GetHistoryLogByMeterID(meterID meterID, System.DateTime startDate, System.DateTime endDate)
        {
            return null;
        }

        [WebMethod(Description = "Returns history log data for a all meters given a date range.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public historyLog[] GetHistoryLogsByDate(System.DateTime startDate, System.DateTime endDate, string lastReceived) {
            return null;
        }

        [WebMethod(Description="Returns history log data for a given meterID, eventCode and date range.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public historyLog[] GetHistoryLogsByMeterIDAndEventCode(meterID meterID, meterEvent eventCode, System.DateTime startDate, System.DateTime endDate)
        {
            return null;
        }

        [WebMethod(Description = "Returns history log data for a all meters given the eventCode and a date range.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public historyLog[] GetHistoryLogsByDateAndEventCode(meterEvent eventCode,System.DateTime startDate, System.DateTime endDate, string lastReceived) {
            return null;
        }

        [WebMethod(Description = "Returns most recent meter reading data for all meters in a given meterGroup, requested by meter group name.  Meter readings are returned in the form of a formattedBlock.Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock GetLatestMeterReadingsByMeterGroup(string meterGroupID, serviceType serviceType, string formattedBlockTemplateName, string[] fieldName, string lastReceived)
        {
            return null;
        }

		[WebMethod(Description = "Returns the most recent reading data for a given meterID and reading type. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public formattedBlock GetLatestReadingByMeterIDAndFieldName(meterID meterID, string formattedBlockTemplateName, string[] fieldName, string lastReceived)
		{
			return null;
		}

        [WebMethod(Description = "Returns the most recent reading data for a given reading type. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetLatestReadingByFieldName(string formattedBlockTemplateName, string[] fieldName, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns readings all meters given the date range and reading type desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetReadingsByDateAndFieldName(System.DateTime startDate, System.DateTime endDate, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
        {
            return null;
        }

        [WebMethod(Description = "Returns all reading types supported by the AMR system.  Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetSupportedFieldNames()
        {
            return null;
        }

		[WebMethod(Description = "Returns readings for a given meter for a specific date range and reading type desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public formattedBlock[] GetReadingsByMeterIDAndFieldName(meterID meterID, System.DateTime startDate, System.DateTime endDate, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
		{
			return null;
		}

        [WebMethod(Description = "Returns the most recent meter reading data for all AMR capable meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public meterReading[] GetLatestReadings(string lastReceived)
        {
            return null;
        }
		
		[WebMethod(Description = "Returns the latest readings for a list of meters for a specific date range and reading type desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public formattedBlock[] GetLatestReadingsByMeterIDList(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
		{
			return null;
		}

        [WebMethod(Description = "Returns the requested reading data for all meters given unit of measure(UOM) and date range. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public meterReading[] GetReadingsByUOMAndDate(uom uomData, System.DateTime startDate, System.DateTime endDate, string lastReceived)
        {
            return null;
        }

			
		[WebMethod(Description = "Returns load profile data, chosen by meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public profileObject[] GetLPDataByMeterID(meterID meterID)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns Load Profile reading data for a given meter and date range.  Reading(s)are returned in the form of an array of formattedBlocks.  The calling parameters include: (i) meterID - the meter identifier for which readings are to be returned, (ii)profile starting date, (iii) profile ending date (iv) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public formattedBlock[] GetLPReadingsByMeterIDFormattedBlock(meterID meterID, System.DateTime profileStartDate, System.DateTime profileEndDate, string lastReceived)
		{
			return null;
		}

        [WebMethod(Description = "Returns Load Profile reading data for all billing cycles given a billing date.  Reading(s) are returned in the form of an array of formattedBlocks.  The calling parameters include: (i) profile date and (ii) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetLPReadingsByDateFormattedBlock(System.DateTime profileDate, string lastReceived)
        {
            return null;
        }
        [WebMethod(Description = "Returns all required Load Profile reading data for a given BillingCycle and Date in the form of an array of formattedBlocks.  The calling parameters include: (i) billingCycle - the CB billing cycle for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetLPReadingsByBillingCycle(string billingCycle, System.DateTime profileDate, string lastReceived)
        {
            return null;
        }
        
        

        [WebMethod(Description = "Returns all schedules that have been established on the server. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public schedule[] GetSchedules(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns a schedule that previously has been established on the server, selected by the scheduleID. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public schedule GetScheduleByID(string scheduleID)
        {
            return null;
        }

        [WebMethod(Description = "Returns all readingSchedules that have been established on the server. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public readingSchedule[] GetReadingSchedules(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns a readingSchedule that previously has been established on the server, selected by the scheduleID. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public readingSchedule GetReadingScheduleByID(string readingScheduleID)
        {
            return null;
        }

        [WebMethod(Description = "The Requester requests from the server a list of names of meter configuration groups.  The server returns an array of strings including the names of the supported configurationGroups.  The Requester can then request the members of a specific group using the GetConfigurationGroupMembers method. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetConfigurationGroupNames()
        {
            return null;
        }

        [WebMethod(Description = "The Requester requests from the server a list of names of meter configuration groups for a specific meter.  The server returns an array of strings including the names of the supported configurationGroups.  The Requester can then request the members of a specific group using the GetConfigurationGroupMembers method. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetConfigurationGroupNamesByMeterID(meterID meterID)
        {
            return null;
        }

		[WebMethod(Description = "The Requester requests from the server the members of a specific meter cofiguration group, identified by the meterGroupName parameter. This method is used, along with the GetConfigurationGroupNames method to enable the Requester to get information about which meters are included in a specific meter configuration group. The server returns a meterGroups object in response to this method call. This object can carry meterGroups that only include meters of one service type or a mixed meterGroup that contains meters of mixed service type. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public configurationGroup GetConfigurationGroupMembers(string meterGroupName)
        {
            return null;
        }

        [WebMethod(Description = "Returns the templates for formattedBlocks that the server supports.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlockTemplate[] GetFormattedBlockTemplates(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns the latest readings for a list of meters for a specific date range and specific types of meter data, specified by fieldName.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public formattedBlock[] GetLatestReadingsByMeterListFormattedBlock(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate, string formattedBlockTemplateName, string[] fieldName, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns the list of readingDataStatusCodes that are supported by the server.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public readingStatusCodeList GetSupportedReadingStatusCodes()
        {
            return null;
        }
        /// *************************************************
        ///
        /// Request methods that return intervalData blocks.
        ///
        /// **********************************************

        [WebMethod(Description = "Returns load Profile reading data for a given meter and date range.  Reading(s)are returned in the form of an array of intervalData blocks.  The calling parameters include: (i) meterID - the meter identifier for which readings are to be returned, (ii)profile starting date, (iii) profile ending date (iv) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetLPReadingsByMeterIDIntervalData(meterID meterID, System.DateTime profileStartDate, System.DateTime profileEndDate, string lastReceived)
        {
            return null;
        }
        [WebMethod(Description = "Returns load Profile reading data for all billing cycles given a billing date.  Reading(s) are returned in the form of an array of intervalData blocks.  The calling parameters include: (i) profile date and (ii) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetLPReadingsByDateIntervalData(System.DateTime profileDate, string lastReceived)
        {
            return null;
        }
        [WebMethod(Description = "Returns load Profile reading data for a given BillingCycle and Date in the form of an array of intervalData blocks.  The calling parameters include: (i) billingCycle - the CB billing cycle for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetLPReadingsByBillingCycleIntervalData(string billingCycle, System.DateTime profileDate, string lastReceived)
        {
            return null;
        }
        [WebMethod(Description = "Returns all required reading data for a given billingCycle and date range in the form of an array of intervalData blocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameters include: (i) billingCycle - the CB billing cycle for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (v) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) (vi) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetReadingsByBillingCycleIntervalData(string billingCycle, System.DateTime billingDate, int kWhLookBack, int kWLookBack, int kWLookForward, string lastReceived, string[] fieldName)
        {
            return null;
        }
		
        [WebMethod(Description = "Returns reading data for a given meter and billing date.  Reading(s)are returned in the form of an array of intervalData blocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameters include: (i) meterID - the meter identifier for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (v) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) (vi) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetReadingByMeterIDIntervalData(meterID meterID, System.DateTime billingDate, int kWhLookBack, int kWLookBack, int kWLookForward, string lastReceived, string[] fieldName)
        {
            return null;
        }

        [WebMethod(Description = "Returns reading data for all billing cycles given a billing date.  Reading(s) are returned in the form of an array of intervalData blocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameters include: (i) billing date - the end date of the billing cycle, (ii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iii) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) and (v) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetReadingsByDateIntervalData(System.DateTime billingDate, int kWhLookBack, int kWLookBack, int kWLookForward, string lastReceived, string[] fieldName)
        {
            return null;
        }
        [WebMethod(Description = "Returns most recent meter reading data for all meters in a given meterGroup, requested by meter group name.  Meter readings are returned in the form of an intervalData block. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative.  ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData GetLatestMeterReadingsByMeterGroupIntervalData(string meterGroupID, serviceType serviceType, string[] fieldName, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns the most recent reading data for a given meterID and an array of reading types. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData GetLatestReadingByMeterIDAndFieldNameIntervalData(meterID meterID, string[] fieldName, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns the most recent reading data for given reading types. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetLatestReadingByFieldNameIntervalData(string[] fieldName, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns readings all meters given the date range and reading types desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetReadingsByDateAndFieldNameIntervalData(System.DateTime startDate, System.DateTime endDate, string lastReceived, string[] fieldName)
        {
            return null;
        }

        [WebMethod(Description = "Returns readings for a given meter for a specific date range and reading types desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetReadingsByMeterIDAndFieldNameIntervalData(meterID meterID, System.DateTime startDate, System.DateTime endDate, string lastReceived, string[] fieldName)
        {
            return null;
        }


        [WebMethod(Description = "Returns the latest readings for a list of meters for a specific date range and reading types desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetLatestReadingsByMeterIDListIntervalData(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate, string lastReceived, string[] fieldName)
        {
            return null;
        }

        [WebMethod(Description = "Returns the latest readings for a list of meters of a specific serviceType for a specific date range and specific types of meter data, specified by fieldName.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public intervalData[] GetLatestReadingsByMeterListIntervalData(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate, string[] fieldName, string lastReceived)
        {
            return null;
        }

        /// End of IntervalData methods.

	#endregion


	#region Methods to Initiate Actions On the MR System

        [WebMethod(Description="Notify MR of planned outage meters given a List of meterIDs and start and end dates of the outage. MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] InitiatePlannedOutage(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate) 
		{
			return null;    
        }

        [WebMethod(Description="Notify MR of cancellation of planned outage given a list of meterIDs.  MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] CancelPlannedOutage(meterID[] meterIDs) 
		{
			return null;    
        }

		[WebMethod(Description="The Requester notifies the MR of meters where zero usage is expected (i.e. move outs). The MR should return notifications of usage in excess of the pre-determined allowable amount to the Requester using the UsageMonitoringNotification method on the sending system. The responseURL parameter is included in this InitiateUsageMonitoring call so that the MR knows where it should publish UsageMonitoringNotifications. The MR returns information about failed transactions, if any, to the Requester using an array of errorObjects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public errorObject[] InitiateUsageMonitoring(meterID[] meterIDs, string responseURL, string transactionID)  
		{
			return null;
		}


        [WebMethod(Description="Notify MR of cancellation Of zero usage monitoring.(ie move Ins).  MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] CancelUsageMonitoring(meterID[] meterIDs) 
		{
			return null;    
        }

        [WebMethod(Description="Publisher notifies MR of meters that have been disconnected and no AMR reading is expected.  MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] InitiateDisconnectedStatus(meterID[] meterIDs) 
		{
			return null;   
        }

        [WebMethod(Description="Publisher notifies MR of meters that should be removed from disconnected status.(i.e. made active).  MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] CancelDisconnectedStatus(meterID[] meterIDs) 
		{
			return null;   
        }

        [WebMethod(Description = "CB requests a new meter reading from MR, on meters selected by meterID.  MR returns information about failed transactions using an array of errorObjects. The meter reading is returned to the CB in the form of a meterReading, anintervalData block, or a formattedBlock, sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the published data method call.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterReadingsByMeterID(meterID[] meterIDs, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }
        
        [WebMethod(Description = "Publisher requests MR to establish a new group of meters to address as a meter group.  MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EstablishMeterGroup(meterGroup meterGroup, serviceType serviceType)
        {
            return null;
        }

        [WebMethod(Description = "Publisher requests MR to eliminate a previously defined group of meters to address as a meter group.  MR returns information about failed transactions using an errorObject.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DeleteMeterGroup(string meterGroupID, serviceType serviceType)
        {
            return null;
        }

        [WebMethod(Description = "Publisher requests MR to add meter(s) to an existing group of meters to address as a meter group.  MR returns information about failed transaction using an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InsertMeterInMeterGroup(meterID[] meterIDs, string meterGroupID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher requests MR to remove meter(s) from an existing group of meters to address as a meter group.  MR returns information about failed transaction using an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RemoveMetersFromMeterGroup(meterID[] meterIDs, string meterGroupID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher requests subscriber to add meter(s) to an existing configuration group.  Subscriber returns information about failed transaction using an array of errorObjects. The transactionID parameter is included so that this method can be linked with a subsequent MeterConfigurationNotification method call sent to the URL specified in the responseURL.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InsertMeterInConfigurationGroup(meterID[] meterIDs, string meterGroupID, string transactionID, string responseURL)
        {
            return null;
        }

        [WebMethod(Description = "Publisher requests MR to remove meter(s) from an existing configuration group.  MR returns information about failed transaction using an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RemoveMetersFromConfigurationGroup(meterID[] meterIDs, string meterGroupID)
        {
            return null;
        }

        [WebMethod(Description = "CB requests MR to schedule a meter reading on a group of meters, referred to by meter reading group name.  MR returns an array of errorObjects to signal failed transaction(s). Meter readings are subsequently published to the CB using either the IntervalDatNotification or the FormattedBlockNotification methods and sent to the URL specified in the responseURL parameter.The transactionID calling parameter links this Initiate request with the published data method call.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateGroupMeterReading(string meterGroupName, string responseURL, string transactionID, serviceType serviceType, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "CB requests MR to schedule meter readings for a group of meters.  MR returns information about failed transactions using an array of errorObjects.  MR returns meter readings when they have been collected using either the IntervalDataNotification or the FormattedBlockNotification methods sent to the URL specified in the responseURL parameter.The transactionID calling parameter links this Initiate request with the published data method call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ScheduleGroupMeterReading(string meterGroupName, System.DateTime timeToRead, string responseURL, string transactionID, serviceType serviceType)
        {
            return null;
        }

        [WebMethod(Description = "Request server to perform a meter reading for specific meterIDs and reading type. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative.  Server returns information about failed transactions using an array of errorObjects.  The Server subsequently returns the data collected by publishing formattedBlocks or intervalData blocks to the requestor at the URL specified in the responseURL parameter.The transactionID parameter is supplied to link the returned formattedBlock(s) with this Initiate request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateMeterReadingByMeterIDAndFieldName(meterID meterID, string responseURL, string fieldName, string transactionID, expirationTime expTime)
		{
			return null;
		}
		
        [WebMethod(Description = "EA requests MR to to perform a meter reading for all meters down line of the circuit element supplied using the calling parameters objectName and nounType and containing the phasing supplied in the calling parameter phaseCode. The MR subsequently returns the data collected by publishing either intervalData or formattedBlocks to the EA at the URL specified in the responseURL parameter.  The transactionID parameter is supplied to link the returned formattedBlock(s) with this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterReadingByObject(string objectName, string nounType, phaseCode PhaseCode, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "CB requests MR to to update the in-home display associated with a specific service location.  MR returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UpdateServiceLocationDisplays(string serviceLocationID, serviceType serviceType)
        {
            return null;
        }

        [WebMethod(Description = "CB requests a new load profile meter reading from MR, on meters selected by meter identifier.  MR returns information about failed transactions using an array of errorObjects. The meter load profile read is returned to the CB in the form of either an intervalData block or a formattedBlock, sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the published data method call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateLPMeterReadingsByMeterID(meterID [] meterIDs, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a completion of tests on electric meters by sending an array of testedElectricMeters.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterTestNotification(testedElectricMeter[] tests, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Requester initiates a demand reset on one or more meters specified by meter identifer.  MR returns information about failed transactions using an array of errorObjects. The MR server confirms the action has been taken by publishing a MeterEventNotification to the Requester sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the MeterEventNotification method call. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateDemandReset(meterID[] meterIDs, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "Requester establishes a new schedule on the server.  The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EstablishSchedules(schedule[] schedules)
        {
            return null;
        }

        [WebMethod(Description = "Requester deletes a previously established schedule on the server, specified by sending the scheduleID.  The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DeleteSchedule(string scheduleID)
        {
            return null;
        }

        [WebMethod(Description = "Requester establishes a new readingSchedule on the server.  The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EstablishReadingSchedules(readingSchedule[] readingSchedules)
        {
            return null;
        }

        [WebMethod(Description = "Requester enables a previously established readingSchedule on the server, specified by sending the readingScheduleID.  This action instructs the server to begin taking readings based on this readingSchedule.  The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EnableReadingSchedules(string[] readingScheduleID)
        {
            return null;
        }

        [WebMethod(Description = "Requester disables a previously established readingSchedule on the server, specified by sending the readingScheduleID. This action instructs the server to stop taking readings based on this readingSchedule. The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DisableReadingSchedule(string readingScheduleID)
        {
            return null;
        }

        [WebMethod(Description = "Requester deletes a previously established readingSchedule on the server, specified by sending the readingSscheduleID.  The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DeleteReadingSchedule(string readingScheduleID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests MR to schedule a meter reading on a group of meters, to obtain specific types of meter data, specified by fieldName.  Valid values for fieldName are those that are specified in the most current FormattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative.  The expiration time parameter indicates the amount of time for which the MR should try to obtain and publish the data; if the MR has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.  Meter readings are subsequently published to the requestor using one of the following asynchronous response types: (i) FormattedBlockNotification, (ii) IntervalDataNotification, or (iii)ReadingChangedNotification methods and sent to the URL specified in the responseURL parameter.  The transactionID calling parameter links this Initiate request with the published data method call.  The requestor may specify a preferred format for a returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format. Error handling may be of six types for this method: 1)The publisher cannot read any of the reading types requested  Expected response: The publisher should return an errorObject in the synchronous response to the Initiate message (a synchronous error response). 2) The publisher can read only some of the values being requested  Expected Response: The publisher should send what it can, without flagging an error condition. 3) The meter for which data is being requested does not exist in the publishers system  Expected Response: A synchronous error (see definition in point 1 above) should be returned. 4) The publisher is too busy to respond or too much information is being requested - Expected Response: A synchronous error (see definition in point 1 above) should be returned. 5) The request is delayed beyond the specified expiration time  Expected Response: The publisher closes the request and does not make an error response. 6) The publisher tried and failed to successfully make the readings  Expected Response: The publisher should send an asynchronous return message (a ReadingChangedNotification, IntervalDataNotification, or FormattedBlockNotification) with the errorString attribute of the meterReading set. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterReadingsByFieldName(meterID[] meterIDs, string [] fieldNames, string responseURL, string transactionID, expirationTime expTime, string formattedBlockTemplateName)
        {
            return null;
        }


    #endregion

	#region Methods to publish Event Notification to MR(The subscriber)

        [WebMethod(Description="Publisher notifies MR of a change in the customer object by sending the changed customer object.MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] CustomerChangedNotification(customer[] changedCustomers) 
		{
			return null;   
        }

        [WebMethod(Description = "Publisher notifies MR of a change in customer account(s) by sending the changed account object(s).MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AccountChangedNotification(account[] changedAccounts)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in the service location by sending the changed serviceLocation object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ServiceLocationChangedNotification(serviceLocation[] changedServiceLocations)
        {
            return null;
        }

        [WebMethod(Description="Publisher notifies MR of a change in the meter object by sending the changed meter object.  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] MeterChangedNotification(meters changedMeters) 
		{
			return null;   
        }

        [WebMethod(Description = "Publisher notifies MR to remove the associated meter(s).  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterUninstalledNotification IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] MeterRemoveNotification(meters removedMeters) 
		{
			return null;   
        }

        [WebMethod(Description = "Publisher notifies MR that the associated meter(s)have been retired from the system.  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterRemovedNotification IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterRetireNotification(meters retiredMeters)
        {
            return null;
        }

		[WebMethod(Description="Publisher notifies MR to Add the associated meter(s).MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public errorObject[] MeterAddNotification(meters addedMeters) 
		{          
			return null;
		}

        [WebMethod(Description = "Publisher notifies MR that meter(s) have been deployed or exchanged.  MR returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterExchangeNotification(meterExchanges meterChangeout)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies MR of new outages by sending the new lists of CustomersAffectedByOutage.  MR returns status of failed tranactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CustomersAffectedByOutageNotification(customersAffectedByOutage[] newOutages)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of the modified connectivity of meters after a switching event used to restore load during outage situations.  Subscriber returns status of failed tranactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterConnectivityNotification(meterConnectivity[] newConnectivity)
        {
            return null;
        }
        [WebMethod(Description = "EDTR Notifies MR of a received end device (meter) shipment by sending the changed endDeviceShipment object.  MR returns information about failed transactions in an array of errorObjects.The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EndDeviceShipmentNotification(endDeviceShipment shipment)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies MR to add the associated in-home display(s).MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayAddNotification(inHomeDisplay[] addedIHDs, string transactionID)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies MR of a change in the in-home display(s)by sending the changed inHomeDisplay object.  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayChangedNotification(inHomeDisplay[] changedIHDs)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies MR that in-home displays(s) have been deployed or exchanged.  MR returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayExchangeNotification(inHomeDisplayExchange[] IHDChangeout)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies MR to remove the associated in-home displays(s).  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayRemoveNotification(inHomeDisplay[] removedIHDs, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies MR that the associated in-home display(s)have been retired from the system.  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayRetireNotification(inHomeDisplay[] retiredIHDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in the meterBase object by sending the changed meterBase object.  Subsriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterBaseChangedNotification(meterBase[] changedMBs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to remove the associated meterBase(4s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterBaseRemoveNotification(meterBase[] removedMBs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that the associated meterBase(es)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterBaseRetireNotification(meterBase[] retiredMBs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to add the associated meterBase(es).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterBaseAddNotification(meterBase[] addedMBs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that meterBase(es) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterBaseExchangeNotification(meterBaseExchange[] MBChangeout)
        {
            return null;
        }
        [WebMethod(Description = "The CB server publishes changed service orders to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ServiceOrderChangedNotification(serviceOrder[] changedSOs)
        {
            return null;
        }
        [WebMethod(Description = "The CB server publishes new service orders to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ServiceOrderOpenedNotification(serviceOrder[] changedSOs)
        {
            return null;
        }
        [WebMethod(Description = "The CB server publishes closed service orders to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ServiceOrderClosedNotification(serviceOrder[] changedSOs)
        {
            return null;
        }
        
    #endregion

    #region Methods New in Version 4.1.5

        ///
        /// New methods in Version 4.1.5
        ///

        [WebMethod(Description = "Requester requests MR to begin monitoring a list of meters for specific meter events.  Meter event notifications are subsequently published to the requester using MeterEventNotification method calls that are sent to the URL specified in the responseURL parameter.  The transactionID calling parameter links this Initiate request with the published data method call and with subsequent CancelMeterEventMonitoring method calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterEventMonitoring(eventMonitoringList monitoringList, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests MR to cancel event monitoring on a previously sent eventMonitoringItem – a group of meters and a specific set of meter events.  The eventMonitoringItem to be cancelled shall be identified by its objectID.  The transactionID calling parameter links this Cancel request with the the previously sent InitiateMeterEventMonitoring method call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelMeterEventMonitoring(string monitoringItemObjectID, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Requester initiates threshold monitoring on one or more meters by issuing a thresholdMonitoringList object to the MR.  MR returns information about failed transactions by returning an array of errorObjects.  When the established thresholds are attained, the MR function returns information about this action using the ThresholdEventNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateThresholdMonitoring(thresholdMonitoringList monitoringList, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Requester adjusts a threshold monitoring request that had previously been initiated using an InitiateThresholdMonitoring call on one or more meters. MR returns information about failed transactions by returning an array of errorObjects.  This call references the transactionID specified to link this transaction to the previous Initiate request.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AdjustThresholdMonitoring(thresholdMonitoringList monitoringList, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Requester cancels a threshold monitoring request that had previously been initiated using an InitiateThresholdMonitoring call on one or more meters.  The Requester send the objectID of the thresholdMonitoringItem that is to be cancelled. MR returns information about failed transactions by returning an array of errorObjects.  This call references the transactionID specified to link this transaction to the previous Initiate request.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelThresholdMonitoring(string monitoringItemObjectID, string transactionID)
        {
            return null;
        }


        [WebMethod(Description = "The Publisher notifies the subscriber that meter(s) have been exchanged. Subscriber returns information about failed transactions in an array of errorObjects. The subscriber subsequently may return information to the publisher about the status of its handling of the meterExchanges by sending a MeterExchangedNotification to the URL specified in the responseURL parameter.  The linked MeterExchangedNotification SHALL carry the same transactionID as the one that the subscriber received in this Initiate method.   The payload includes a meterExchanges object that can carry arrays of all possible types of meters (electricMeter, gas,Meter, waterMeter, propaneMeter and otherMeter), thus this one method can be used to handle different meter types.  It should be noted that in Version 3.0, the function of this call was performed by a method called MeterExchangeNotification and that there was no MeterExchangedNotification.  The MeterExchangeNotification has been deprecated in V4.1.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterExchange(meterExchanges exchanges, string responseURL, string transactionID)
        {
            return null;
        }


        [WebMethod(Description = "The Publisher notifies the subscriber of changes in the details of a rate tariff.  This method is intended to send updates to a previously established rate (e.g., 'change the cost of energy from $0.065/kWh to be $0.08/kWh'). It SHALL NOT be used to change the rate code in effect at a service location (e.g., 'change the effective tariff from rate code 10 to rate code 11'); that shall be done using a ServiceLocationChangedNotification.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RateChangedNotification(rate rateInfo, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that meters have been deployed (installed) and are ready for the AMI system to make the initial meter reading.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. The service location in the payload SHALL include the customerID and account number as well as the necessary electric service, gas service, water service, etc so that the meters can be linked to the service location.  The service shall also include the meterID for the appropriate service type, and if the service is electric a meterBaseID link. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterInstallation(serviceLocation[] installLocations, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "The Requester requests that the MR attempt again to collect meter readings for specific meters and a specific date.  The MR shall return the requested readings, if it is possible to obtain them, using any of the publish type methods included in use case MSP.MR:10.50 (i.e., ReadingChangedNotification, FormattedBlockNotification or IntervalDataNotification). The responseURL parameter is included in this InitiateHistoricalMeterReadingsByMeterIDAndDate call so that the MR knows where it should publish the meter readings. The MR returns information about failed transactions, if any, to the Requester using an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHistoricalMeterReadingsByMeterIDAndDate(meterID[] meterIDs, System.DateTime date, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Subscriber requests a listing of the meter event types supported by the server. Meter events should be consistent with the EndDeviceEvents identified in IEC 61968-9, first edition.   At a minimum, it is REQUIRED that the returned  meterEvent SHALL include the concatenated numeric meter event code and the meterEvent.codeString so that the Subscriber can link the numeric meter event code with its string representation.  For instance the numeric meter event code '7.20.7.27' should be matched with 'Meter change out' as identified in IEC 61968-9, First Edition.  ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public meterEvent[] GetSupportedMeterEventCodes()
        {
            return null;
        }



        ///
        /// End of New Methods in Version 4.1.5
        ///

    #endregion

        #region Component Designer generated code
		
        //Required by the Web Services Designer 
        private IContainer components = null;
				
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if(disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);		
        }
		
        #endregion

 
    }
}


