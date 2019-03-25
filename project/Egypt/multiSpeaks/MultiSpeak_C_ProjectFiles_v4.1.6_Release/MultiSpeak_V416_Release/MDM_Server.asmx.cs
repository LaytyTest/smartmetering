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
    /// Summary description for Web Services Hosted by Meter DataManagement(MDM).
    /// </summary>

    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class MDM_Server : System.Web.Services.WebService
    {

        public MultiSpeakMsgHeader MultiSpeakMsgHeader;

        public MDM_Server()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
        }


        #region Generic for each interface

        [WebMethod(Description = "Requester pings URL of MDM to see if it is alive.   Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PingURL()
        {
            return null;
        }

        [WebMethod(Description = "Requester requests a list of methods supported by MDM.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetMethods()
        {
            return null;
        }

        [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server. It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetDomainNames()
        {
            return null;
        }
        [WebMethod(Description = "The client requests from the server the members of a specific domain of information, identified by the domainName parameter, which are supported by the server.  This method is used, along with the GetDomainNames method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
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

        #region Methods to Get Data from the MDM

        [WebMethod(Description = "Returns all required Meter data for all Meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetAllMeters(string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "Returns all meters that have AMR.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetAMRSupportedMeters(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all meters that support AMR and that have been modified since the specified sessionID.   The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetModifiedAMRMeters(string previousSessionID, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Return true if given meterID has AMR. Otherwise return false.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public bool IsAMRMeter(meterID meterID)
		{
			return false;
		}

		[WebMethod(Description = "Returns reading data for all meters given a date range. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterReading[] GetReadingsByDate(System.DateTime startDate, System.DateTime endDate, string lastReceived)
		{
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
		
		[WebMethod(Description = "Returns the most recent meter reading data for a given MeterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterReading GetLatestReadingByMeterID(meterID meterID)
		{
			return null;
		}

		[WebMethod(Description = "Returns all required reading data for a given billingCycle and date range in the form of an array of formattedBlocks. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameters include: (i) billingCycle - the CB billing cycle for which readings are to be returned, (ii)billing date - the end date of the billing cycle, (iii) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (iv) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), (v) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date) (vi) lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received (that is to say the lastSent data instance) in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
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
		[WebMethod(Description = "Returns history log data for a given meterID and date range.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public historyLog[] GetHistoryLogByMeterID(meterID meterID, System.DateTime startDate, System.DateTime endDate)
		{
			return null;
		}

		[WebMethod(Description = "Returns history log data for a all meters given a date range.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public historyLog[] GetHistoryLogsByDate(System.DateTime startDate, System.DateTime endDate, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns history log data for a given meterID, eventCode and date range.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public historyLog[] GetHistoryLogsByMeterIDAndEventCode(meterID meterID, meterEvent eventCode, System.DateTime startDate, System.DateTime endDate)
		{
			return null;
		}

		[WebMethod(Description = "Returns history log data for a all meters given the eventCode and a date range.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public historyLog[] GetHistoryLogsByDateAndEventCode(meterEvent eventCode, System.DateTime startDate, System.DateTime endDate, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns most recent meter reading data for all meters in a given meterGroup, requested by meter group name.  Meter readings are returned in the form of a formattedBlock. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format. ")]
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
        [WebMethod(Description = "Returns all in home display objects. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public inHomeDisplay[] GetAllInHomeDisplays(string lastReceived)
        {
            return null;
        }

		[WebMethod(Description = "Returns the requested reading data for all meters given unit of measure(UOM) and date range. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterReading[] GetReadingsByUOMAndDate(uom uomData, System.DateTime startDate, System.DateTime endDate, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "Returns all outage detection devices. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetAllOutageDetectionDevices(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns outage detection devices associated with the given meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutageDetectionDevicesByMeterID(meterID meterID)
		{
			return null;
		}

		[WebMethod(Description = "Returns all outage detection devices with a given OutageDetectionDeviceStatus. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutageDetectionDevicesByStatus(outageDetectDeviceStatus oDDStatus, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all outage detection devices of a given OutageDetectionDeviceType. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutageDetectionDevicesByType(outageDetectDeviceType oDDType, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns the outageDetectionDevices that are currently experiencing outage conditions.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutagedODDevices()
		{
			return null;
		}
		[WebMethod(Description = "Returns all meters that have Connect/Disconnect Capability. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetCDSupportedMeters(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all meters that have Connect/Disconnect Capability and that have been modified since the last identified session.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetModifiedCDMeters(string previousSessionID, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns Current State of a Connect/Disconnect Device for a given the meterID.  The default condition is Closed.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public CDState GetCDMeterState(meterID meterID)
		{
            return  null; // Closed is the default condition. 

		}
		[WebMethod(Description = "Returns the current status of an outage event, given the outage event ID.  The outageEventID is the objectID of an outageEvent obtained earlier by calling GetActiveOutages.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageEventStatus GetOutageEventStatus(string outageEventID)
		{
			return null;
		}

		[WebMethod(Description = "Returns the outageEventIDs for all active outage events.  The outageEventID is the objectID of an outageEvent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetActiveOutages()
		{
			return null;
		}

		[WebMethod(Description = "Returns the current status of an outage event, given the outage location.  The outageLocation object includes the telephone number, service locationID, account number and/or meter identifier at the location of the outage.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageEventStatus GetOutageEventStatusByOutageLocation(outageLocation location)
		{
			return null;
		}

		[WebMethod(Description = "Returns all electric meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public electricMeter[] GetAllElectricMeters(string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "Returns all gas meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public gasMeter[] GetAllGasMeters(string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "Returns all water meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public waterMeter[] GetAllWaterMeters(string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "Returns all propane meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public propaneMeter[] GetAllPropaneMeters(string lastReceived)
		{
			return null;
		}
					[WebMethod(Description = "The MR requests from the CB electric meter objects, given the account number. The CB returns a meters object, which can contain an array of electric meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public electricMeters GetElectricMetersByAccountNumber(string accountNumber, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "The MR requests from the CB gas meter objects, given the account number. The CB returns a meters object, which can contain an array of gas meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public gasMeters GetGasMetersByAccountNumber(string accountNumber, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "The MR requests from the CB water meter objects, given the account number. The CB returns a meters object, which can contain an array of water meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public waterMeters GetWaterMetersByAccountNumber(string accountNumber, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "The MR requests from the CB propane meter objects, given the account number. The CB returns a meters object, which can contain an array of propane meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public propaneMeters GetPropaneMetersByAccountNumber(string accountNumber, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "The MR requests from the CB all customers of a given serviceType (electric, gas, water, or propane). The CB returns an array of customer objects. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer[] GetAllCustomersByServiceType(serviceType serviceType, string lastReceived)
		{
			return null;
		}
		
		[WebMethod(Description = "The MR requests from the CB all meters of a given serviceType (electric, gas, water, or propane). The CB returns a meters object, which contains an array of meters by serviceType in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetAllMetersByServiceType(serviceType serviceType, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Requests from the CB all serviceLocations that have services of a given serviceType (electric, gas, water, or propane). The CB returns a serviceLocations object, which contains an array of serviceLocations by serviceType in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetAllServiceLocationsByServiceType(serviceType serviceType, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "The MR requests from the CB a specific meter object, given the account number and serviceType (electric, gas, water, or propane). The CB returns a meters object, which can contain an array of meters by serviceType in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersByAccountNumberAndServiceType(string accountNumber, serviceType serviceType, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "Returns all required customer data for all customers.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer[] GetAllCustomers(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all required customer data for all customers that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer[] GetModifiedCustomers(string previousSessionID, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all required Service Location data for all Service Locations that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetModifiedServiceLocations(string previousSessionID, string lastReceived, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Customer if it exists.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer GetCustomerByCustomerID(string customerId)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Customer data given a meter identifer.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer GetCustomerByMeterID(meterID meterID)
		{
			
			return null;
		}

		[WebMethod(Description = "Returns the requested Customer(s) data given First and Last name.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer[] GetCustomerByName(string firstName, string lastName)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Customer given the Doing Business As (DBA) name.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public customer GetCustomerByDBAName(string dBAName)
		{
			return null;
		}
		[WebMethod(Description = "This method returns the minimum set of connectivity data necessary for AMR systems to group meters on portions of the power system.  This method will not return a complete set of connectivity data; it returns only circuit elements downline of a specific substation, overcurrentDeviceBank, transformer, or serviceLoaction.  Device tree connectivity will not include objects unnecessary to group meters, such as line sections.  The MR requests devices downline of a specific object by passing the name and noun type for that object.  For instance, if the MR wishes to receive the minimal device tree downline of a specific substation, named the West substation, it would send name = West and noun = substation.  EA would return the minimal device tree downline of the West substation in the form of an array of circuit elements.  The MR can find the instances of the objects of interest using the GetDomainMembers method passing one of the parameters: substation, overcurrentDeviceBank, transformerBank, or serviceLocation.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public circuitElement[] GetDeviceTreeConnectivity(string name, string noun)
		{
			return null;
		}
		[WebMethod(Description = "Returns the meter connectivity for all meters served from a given substation.  The client requests the data by passing a substation name, which it previously received using the GetSubstationNames method.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterConnectivity[] GetMeterConnectivityBySubstation(string substationName)
		{
			return null;
		}
		[WebMethod(Description = "Returns the endDeviceShipment object given the shipmentID. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public endDeviceShipment GetEndDeviceShipmentByShipmentID(string shipmentID)
		{
			return null;
		}

		[WebMethod(Description = "Returns the endDeviceShipments given a date range. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public endDeviceShipment[] GetEndDeviceShipmentsByDateRange(System.DateTime startDate, System.DateTime endDate)
		{
			return null;
		}
		[WebMethod(Description = "Returns the endDeviceShipment object given the identifier for a meter that was included in that shipment. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public endDeviceShipment GetEndDeviceShipmentByMeterID(meterID meterID)
		{
			return null;
		}
		[WebMethod(Description = "Returns the endDeviceShipment object given the transponderID for a meter that was included in that shipment. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public endDeviceShipment GetEndDeviceShipmentByTransponderID(string transponderID)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns load profile data, chosen by meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public profileObject[] GetLPDataByMeterID(meterID meterID)
		{
			return null;
		}
		
		[WebMethod(Description="Returns the requested Meter data given meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public meters GetMeterByMeterID(meterID meterID)
		{
			return null;
		}

		[WebMethod(Description="Returns the requested Meter(s) data given Service Location.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public meters GetMeterByServiceLocationID(string serviceLocationID, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description="Returns the requested Meter(s) data given Account Number.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public meters GetAllMetersByAccountNumber(string accountNumber, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description="Returns the requested Meter(s) data given Customer ID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public meters GetMeterByCustomerID(string customerID) {
			return null;
		}

		[WebMethod(Description = "Returns the requested Meter(s) data given AMR vendor and device type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersByAMRType(string AMRVendor, string AMRDeviceType, string lastReceived)
		{
			return null;
		}
		[WebMethod(Description = "The Requester requests from the CB a list of names of meter reading groups.  The CB returns an array of strings including the names of the supported meterGroups.  The MR can then request the members of a specific group using the GetMeterGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetMeterGroupNames()
		{
			return null;
		}

		[WebMethod(Description = "The Requester requests from the CB a list of names of meter reading groups for a specific meter.  The CB returns an array of strings including the names of the supported meterGroups.  The MR can then request the members of a specific group using the GetMeterGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetMeterGroupNamesByMeterID(meterID meterID)
		{
			return null;
		}

		[WebMethod(Description = "The Requester requests from the CB the members of a specific meter reading group, identified by the meterGroupName parameter.  This method is used, along with the GetMeterGroupNames method to enable the MR to get information about which meters are included in a specific meter reading group.  The CB returns a meterGroups object in response to this method call.  This object can carry meterGroups that only include meters of one service type or a mixed meterGroup that contains meters of mixed service type. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterGroups GetMeterGroupMembers(string meterGroupName)
		{
			return null;
		}
		[WebMethod(Description = "Returns all required Meter data for all Meters that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetModifiedMeters(string previousSessionID, string lastReceived, serviceType serviceType)
		{
			return null;
		}
		[WebMethod(Description = "Returns the requested Service Location(s) data given the Service Status. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByServiceStatus(string servStatus, string lastReceived, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location data given Service Location ID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByServiceLocationID(string serviceLocationId, serviceType serviceType)
		{
			return null;
		}
		[WebMethod(Description = "Returns the requested Service Location data given Customer ID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByCustomerID(string customerId)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location data given the meterID of a meter served at that location.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByMeterID(meterID meterID)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location data given Account Number.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByAccountNumber(string accountNumber, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location(s) data given the Grid Location.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByGridLocation(string gridLocation, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location(s) data given the Phase. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByPhaseCode(phaseCode phaseCode, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location(s) data given the Load Group.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByLoadGroup(string loadGroup, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location(s) data given the Service Type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByServiceType(serviceType serviceType, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested Service Location(s) data given the Service ShutOff Date.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceLocation[] GetServiceLocationByShutOffDate(System.DateTime shutOffDate, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested meters corresponding to a given location in the engineering connectivity model, as specified by the eaLoc.name.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersByEALocation(string eaLoc)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested meters corresponding to a given customer's serviceLocation, given the serviceLocation.facilityID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersByFacilityID(string facilityID, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested meters corresponding to a given customer's serviceLocation, given the serviceLocation.siteID")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersBySiteID(string siteID, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Returns all meters corresponding to a given customer name.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersByCustomerName(string firstName, string lastName)
		{
			return null;
		}

		[WebMethod(Description = "Returns all meters corresponding to a given customer's home phone number.  HomeAC is the area code and homePhone is the 7-digit local phone number for the customer of interest.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersByHomePhone(telephoneNumber phone)
		{
			return null;
		}

		[WebMethod(Description = "Returns all meters corresponding to a given search string.  This method can return any meters associated with customer, serviceLocation, meter,accountNumber, or meterBase containing or starting with the seach string.  For instance, a  search string of 123 could return meters for accountNumber = 12345678, customer = as123666, etc.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meters GetMetersBySearchString(string searchString)
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
		[WebMethod(Description = "Returns account data for all customer accounts.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public account[] GetAllAccounts(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested account if it exists, given the customer identifier.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public account[] GetAccountsByCustomerID(string customerID)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested customer account data given a meterID, which includes a service type.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public account GetAccountByMeterID(meterID meterID)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested customer account data given a service location identifier and service type.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public account GetAccountByServiceLocationIDAndServiceType(string serviceLocationID, serviceType serviceType)
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

		[WebMethod(Description = "Returns the latest readings for a list of meters for a specific date range and reading type desired. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current formattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public formattedBlock[] GetLatestReadingsByMeterIDList(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate, string lastReceived, string formattedBlockTemplateName, string[] fieldName)
		{
			return null;
		}

		[WebMethod(Description = "Returns the requested meter base data given the objectID of the meterBase.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterBase GetMeterBaseByObjectID(string meterBaseID)
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

		[WebMethod(Description = "Returns all connectDisconnectEvents in the specified date range for the specified reasonCode.  See the connectDisconnectCode.reasonCode enumeration for acceptable values.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public connectDisconnectEvent[] GetAllConnectDisconnectEventsByReasonCode(string reasonCode, System.DateTime startDate, System.DateTime endDate)
		{
			return null;
		}

		[WebMethod(Description = "Returns the list of readingStatusCodes that are supported by the server.")]
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


        #region Methods to Initiate Actions On the MDM System

		
        [WebMethod(Description = "Publisher notifies Subscriber of the causes and other information related to an outage event. The outage cause specified in the outageReasonCodeList takes precedence over any other information, such as the isCustomerResponsibile parameter.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] OutageReasonChangedNotification(string outageEventID, outageReasonCodeList reasonCodes, string transactionID)
        {
            return null;
        }
		
        [WebMethod(Description = "Publisher notifies Subscriber of changes in the cause codes that may be used to describe outage events at this installation. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] OutageReasonContainerChangedNotification(outageReasonContainer reasons, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in OutageEvent by sending an array of changed OutageEvent objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] OutageEventChangedNotification(outageEvent[] oEvents)
        {
            return null;
        }

		[WebMethod(Description = "Publisher requests subscriber to add in home display(s) to an existing group of in home displays to address as a group.  Subscriber returns information about failed transaction using an array of errorObjects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InsertInHomeDisplayInIHDGroup(string[] inHomeDisplayIDs, string IHDGroupID)
		{
			return null;
		}

		[WebMethod(Description = "Publisher requests subscriber to remove in home display(s) from an existing group of in home displays to address as a group.  Subscriber returns information about failed transaction using an array of errorObjects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] RemoveInHomeDisplayFromIHDGroup(string[] inHomeDisplays, string IHDGroupID)
		{
			return null;
		}

        [WebMethod(Description = "Requester requests that subscriber cancel a critical peak price event on a HAN. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelCriticalPeakPriceEvent(criticalPeakPriceEvent criticalPeakPriceEvent, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID, string responseURL)
        {
            return null;
        }
		
		[WebMethod(Description = "Requester requests that subscriber cancel a critical peak price event on a HAN group. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelCriticalPeakPriceEventToGroup(criticalPeakPriceEvent criticalPeakPriceEvent, HANGroupID groupID, string transactionID, string responseURL)
        {
            return null;
        }
		
		
		[WebMethod(Description = "Publisher notifies subscriber of the result of a critical peak price event on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateCriticalPeakPriceEvent. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CriticalPeakPriceEventNotification(criticalPeakPriceEventStatus[] eventHistory, string transactionID)
		{
			return null;
		}

        [WebMethod(Description = "Requester requests that subscriber intiate a critical peak price event on a HAN. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateCriticalPeakPriceEvent(criticalPeakPriceEvent criticalPeakPriceEvent, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID, string responseURL)
        {
            return null;
        }
		
		[WebMethod(Description = "Requester requests that subscriber intiate a critical peak price event on a HAN group. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateCriticalPeakPriceEventToGroup (criticalPeakPriceEvent criticalPeakPriceEvent, HANGroupID groupID, string transactionID, string responseURL)
        {
            return null;
        }

		[WebMethod(Description = "Publisher calls this DR service to initiate a load management event via the loadManagementEvent object.  If substation and feeder information is included in the loadManagementEvent, then the LM should attempt to control the requested amount of load in that substation/feeder area.  Otherwise, the controlled load should be spread over the entire system. If this transaction should fail, DR returns information about the failure using a SOAPFault.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateLoadManagementEvent(loadManagementEvent theLMEvent, string transactionID, string responseURL)
		{
			return null;
		}

		[WebMethod(Description = "Publisher calls this DR service to initiate an array of load management events via multiple loadManagementEvent objects.  If substation and feeder information is included in the loadManagementEvent, then the LM should attempt to control the requested amount of load in that substation/feeder area.  Otherwise, the controlled load should be spread over the entire system. If this transaction should fail, DR returns information about the failure using a SOAPFault.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateLoadManagementEvents(loadManagementEvent[] theLMEvents, string transactionID, string responseURL)
		{
			return null;
		}

        [WebMethod(Description = "Publisher calls this DR service to initiate a power factor management event via the powerFactorManagementEvent object.  If this transaction should fail, DR returns information about the failure using a SOAPFault.  The DR function returns information about this action using the PowerFactorManagementEventNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link that transaction to this Initiate request.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiatePowerFactorManagementEvent(powerFactorManagementEvent thePFMEvent, string transactionID, string responseURL)
		{
			return null;
		}

		[WebMethod(Description = "Notify MDM of planned outage meters given a List of meterIDs and start and end dates of the outage. MR returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiatePlannedOutage(meterID[] meterIDs, System.DateTime startDate, System.DateTime endDate)
		{
			return null;
		}

		[WebMethod(Description = "Notify MDM of cancellation of planned outage given a list of meterIDs.  MR returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
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


		[WebMethod(Description = "Notify MDM of cancellation Of zero usage monitoring.(ie move Ins).  MDM returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelUsageMonitoring(meterID[] meterIDs)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies MDM of meters that have been disconnected and no AMR reading is expected.  MDM returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDisconnectedStatus(meterID[] meterIDs)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies MDM of meters that should be removed from disconnected status.(i.e. made active).  MDM returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelDisconnectedStatus(meterID[] meterIDs)
		{
			return null;
		}

		[WebMethod(Description = "Client requests a new meter reading from MDM, on meters selected by meterID.  MDM returns information about failed transactions using an array of errorObjects. The meter reading is returned to the CB in the form of a meterReading, intervalData or formattedBlock, sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the published data method call. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateMeterReadingsByMeterID(meterID[] meterIDs, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "Publisher requests MDM to establish a new group of meters to address as a meter group.  MDM returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] EstablishMeterGroup(meterGroup meterGroup, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Requester establishes a new HAN device group on the server. The group may be empty when first established. The server returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] EstablishHANDeviceGroup(HANGroupID groupID, HANDeviceID[] groupMembers)
		{
			return null;
		}
		
		[WebMethod(Description = "Requester inserts HANDevices into an existing HAN device group on the server. The server returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InsertIntoHANDeviceGroup(HANGroupID groupID, HANDeviceID[] groupMembers)
		{
			return null;
		}
		
		[WebMethod(Description = "Requester removes HANDevices from an existing HAN device group on the server. The server returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] RemoveFromHANDeviceGroup(HANGroupID groupID, HANDeviceID[] groupMembers)
		{
			return null;
		}
		
		[WebMethod(Description = "The Requester requests from the system of record a list of names of HAN device groups. The system of record returns an array of strings including the names of the supported HANDeviceGroups. The Requester can then request the members of a specific group using the GetHANDeviceGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetHANDeviceGroupNames()
		{
			return null;
		}
		
		[WebMethod(Description = "The Requester requests from the system of record the members of a specific HAN device group, identified by the HANDeviceGroupName parameter. This method is used, along with the GetHANDeviceGroupNames method to enable the requester to get information about which HANDevices are included in a specific HANDevice group. The system of record returns a HANDeviceGroup object in response to this method call. HANDeviceGroups can be those devices on a single HAN (a group with mixed type of members), a group of HANDevices of a single type (say all IHDs, all PCTs, or all ESIs) or some other combination of HANDevice groupings. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public HANDeviceGroup GetHANDeviceGroupMembers(string HANDeviceGroupName)
		{
			return null;
		}
		
		[WebMethod(Description = "The Requester requests from the system of record a list of names of Han device groups for a specific HAN device. The system of record returns an array of strings including the names of the supported HANDeviceGroups. The requester can then request the members of a specific group using the GetHANDeviceGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetHANDeviceGroupNamesByHANDeviceID(HANDeviceID deviceID)
		{
			return null;
		}


		[WebMethod(Description = "Publisher requests MDM to eliminate a previously defined group of meters to address as a meter group.  MDM returns information about failed transactions using an errorObject.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] DeleteMeterGroup(string meterGroupID, serviceType serviceType)
		{
			return null;
		}

		[WebMethod(Description = "Publisher requests MDM to add meter(s) to an existing group of meters to address as a meter group.  MDM returns information about failed transaction using an array of errorObjects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InsertMeterInMeterGroup(meterID[] meterIDs, string meterGroupID)
		{
			return null;
		}

		[WebMethod(Description = "Publisher requests MDM to remove meter(s) from an existing group of meters to address as a meter group.  MDM returns information about failed transaction using an array of errorObjects.")]
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

		[WebMethod(Description = "Publisher requests MDM to remove meter(s) from an existing configuration group.  MDM returns information about failed transaction using an array of errorObjects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] RemoveMetersFromConfigurationGroup(meterID[] meterIDs, string meterGroupID)
		{
			return null;
		}

		[WebMethod(Description = "CB requests MDM to schedule a meter reading on a group of meters, referred to by meter reading group name.  MDM returns an array of errorObjects to signal failed transaction(s). Meter readings are subsequently published to the CB using either the IntervalDataNotification or the FormattedBlockNotification methods and sent to the URL specified in the responseURL parameter.The transactionID calling parameter links this Initiate request with the published data method call. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateGroupMeterReading(string meterGroupName, string responseURL, string transactionID, serviceType serviceType, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "CB requests MDM to schedule meter readings for a group of meters.  MR returns information about failed transactions using an array of errorObjects.  MDM returns meter readings when they have been collected using either the IntervalDataNotification or the FormattedBlockNotification method sent to the URL specified in the responseURL parameter.The transactionID calling parameter links this Initiate request with the published data method call.")]
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
		
		[WebMethod(Description = "EA requests MDM to to perform a meter reading for all meters down line of the circuit element supplied using the calling parameters objectName and nounType and containing the phasing supplied in the calling parameter phaseCode. The MR subsequently returns the data collected by publishing either intervalData blocks or formattedBlocks to the EA at the URL specified in the responseURL parameter.  The transactionID parameter is supplied to link the returned formattedBlock(s) with this Initiate request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateMeterReadingByObject(string objectName, string nounType, phaseCode PhaseCode, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}
		
		[WebMethod(Description = "OA requests OD to update the status of an outageDetectionDevice.  OD responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA-OD) to the URL specified in the responseURL parameter.  OD returns information about failed transactions using an array of errorObjects. The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateOutageDetectionEventRequest(meterID[] meterIDs, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "OA requests OD to return only outage detection events that are known to be of type Outage or Inferred on service locations downline from a circuit element supplied using the calling parameters objectName and nounType and containing the phasing supplied in the calling parameter phaseCode. OD responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA-OD)to the URL specified in the responseURL parameter.  OD returns information about failed transactions using an array of errorObjects.The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateODEventRequestByObject(string objectName, string nounType, phaseCode PhaseCode, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "OA requests OD to return only outage detection events that are known to be of type Outage or Inferred on service locations downline from a circuit element supplied using the calling parameters objectName and nounType. OD creates a monitoring event for the specified circuit element.  Monitoring shall be performed at the time interval given in the periodicity parameter (expressed in minutes).  OD responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA-OD)to the URL specified in the responseURL parameter.  OD returns information about failed transactions using an array of errorObjects.The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateODMonitoringRequestByObject(string objectName, string nounType, phaseCode PhaseCode, int periodicity, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "Requester requests OD to return a list of circuit elements (in the form of objectRefs) that are currently being monitored.  OD returns an array of objectRefs.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public objectRef[] DisplayODMonitoringRequests()
		{
			return null;
		}

		[WebMethod(Description = "Requester requests OD to cancel outage detection monitoring on the list of supplied circuit elements (called out by objectRef).  OD returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelODMonitoringRequestByObject(objectRef[] ObjectRef, System.DateTime requestDate)
		{
			return null;
		}
		
		[WebMethod(Description = "CB initiates a connect or disconnect action by issuing one or more connectDisconnectEvent objects to the CD.  CD returns information about failed transactions by returning an array of errorObjects.  The connect/disconnect function returns infromation about this action using the CDStateChangedNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateConnectDisconnect(connectDisconnectEvent[] cdEvents, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}
            
		[WebMethod(Description = "CD notifies CB of state change for a connect/disconnect device By meterID and loadActionCode.  The transactionID calling parameter can be used to link this action with an InitiateConectDisconnect call.  If this transaction fails, CB returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDStateChangedNotification(CDStateChange stateChange, string transactionID)
		{
			return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of state change(s) for connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateConnectDisconnect call.  If this transaction fails, subscriber returns information about the failure in an array of errorObject(s). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStatesChangedNotification(CDStateChange[] stateChanges, string transactionID)
        {
            return null;
        }

		
		[WebMethod(Description = "CB requests MR to to update the in-home display associated with a specific service location.  MR returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] UpdateServiceLocationDisplays(string serviceLocationID, serviceType serviceType)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher sends new interval meter readings to the subscriber by sending an intervalData  object.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] IntervalDataNotification(intervalData intervalReads, string transactionID, string errorString)
		{
			return null;
		}

		[WebMethod(Description = "CB requests a new load profile meter reading from MR, on meters selected by meter identifier.  MR returns information about failed transactions using an array of errorObjects. The meter load profile read is returned to the CB in the form of either an intervalData block or a formattedBlock, sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the published data method call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateLPMeterReadingsByMeterID(meterID[] meterIDs, string responseURL, string transactionID)
		{
			return null;
		}

		[WebMethod(Description = "CB initiates a switch status check directly from one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD switch state check function returns information asynchronously about this switch state using either the CDStateNotification (for only one device) or the CDStatesNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateCDStateRequest(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "CD notifies CB of state of a connect/disconnect device.  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, CB returns information about the failure in a SOAPFault.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDStateNotification(CDState state, string transactionID)
		{
			return null;
		}
		
		[WebMethod(Description = "CD notifies CB of state of connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, CB returns information about the failure in an array of errorObject(s).")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDStatesNotification(CDState[] states, string transactionID)
		{
			return null;
		}
		
					
		[WebMethod(Description = "Requester requests that subscriber cancel a DR event on a HAN.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelDemandResponseEvent (demandResponseEvent demandResponseEvent, HANInterfaceID interfaceID, string transactionID, string responseURL)
		{
			return null;
		}
		
		[WebMethod(Description = "Requester requests that subscriber cancel a DR event on a HAN, where the eventID is the identifier for a previously sent demandResponseEvent. The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelDemandResponseEventToGroup (string eventID, HANGroupID groupID, string transactionID, string responseURL)
		{
			return null;
		}
								
		[WebMethod(Description = "Publisher notifies subscriber of the result of DR event on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateDemandResponseEvent. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] DemandResponseEventNotification(demandResponseEventStatus[] eventHistory, string transactionID)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber of the result of DR event setup on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateDemandResponseSetup. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DemandResponseSetupNotification(demandResponseParameters drParameters, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID)
        {
            return null;
        }

		[WebMethod(Description = "Requester requests that subscriber intiate a DR event on a HAN.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDemandResponseEvent (demandResponseEvent demandResponseEvent, HANInterfaceID interfaceID, string transactionID, string responseURL)
		{
			return null;
		}

		
		[WebMethod(Description = "Requester requests that subscriber return the status of a specific DR event from a HAN. Each device in the HAN should send the event status in at a random time within the specified dither interval. If the dither interval is not specified then the DR server should use a suitable default.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDemandResponseEventStatusRequest (string eventID, HANInterfaceID interfaceID, duration dither, string transactionID, string responseURL)
		{
			return null;
		}
		
		[WebMethod(Description = "Requester requests that subscriber intiate a DR event on a HANGroup.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDemandResponseEventToGroup (demandResponseEvent demandResponseEvent, HANGroupID groupID, string transactionID, string responseURL)
		{
			return null;
		}
		
		
		[WebMethod(Description = "Requester requests that subscriber return the status of a specific DR event from a HANGroup. Each device in the HAN should send the event status in at a random time within the specified dither interval. If the dither interval is not specified then the DR server should use a suitable default.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDemandResponseEventStatusRequestToGroup (string eventID, HANGroupID groupID, duration dither, string transactionID, string responseURL)
		{
			return null;
		}


        [WebMethod(Description = "Requester requests that subscriber prepare a HAN device to respond to subsequent DR events. The asynchronous return is a DemandResponseSetupNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateDemandResponseSetup(demandResponseParameters drParameters, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID, string responseURL)
        {
            return null;
        }

		[WebMethod(Description = "Requester initiates a demand reset on one or more meters specified by meter identifer.  MR returns information about failed transactions using an array of errorObjects. The MR server confirms the action has been taken by publishing a MeterEventNotification to the Requester sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the MeterEventNotification method call. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDemandReset(meterID[] meterIDs, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

        [WebMethod(Description = "CB initiates arming of one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD function returns information asynchronously about this switch action using either the CDStateChangedNotification (for only one device) or the CDStatesChangedNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. ***THIS METHOD HAS BEEN DEPRECATED IN VERSION 4.1 AND WILL BE REMOVED IN VERSION 4.2.  IT IS SUGGESTED THAT IMPLEMENTERS USE InitiateConnectDisconnect USING THE loadActionCode OF ‘Arm’ INSTEAD OF THIS METHOD. ***")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateArmCDDevice(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }


		[WebMethod(Description = "CB initiates enabling of one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD function returns information asynchronously about this switch action using either the CDStateChangedNotification (for only one device) or the CDStatesChangedNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateEnableCDDevice(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}

		[WebMethod(Description = "CB initiates disabling of one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD function returns information asynchronously about this switch action using either the CDStateChangedNotification (for only one device) or the CDStatesChangedNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateDisableCDDevice(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
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

		[WebMethod(Description = "Client requests server to return outage detection events that are known to be of type Outage or Inferred on an array of service locations. Server responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA_Server)to the URL specified in the responseURL parameter.  Server returns information about failed transactions using an array of errorObjects.  The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateODEventRequestByServiceLocation(string[] serviceLocationID, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
		{
			return null;
		}
	

		[WebMethod(Description = "Returns all of the outageEvent(s) for all active outages.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageEvent[] GetAllActiveOutageEvents(string lastReceived)
		{
			return null;
		}
	
		[WebMethod(Description = "Returns the outageEvent for the given outageEventID.  This can be either an active or a historical outage event.  The outageEventID is the objectID for the outageEvent object.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public outageEvent GetOutageEvent(string outageEventID)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns the circuit element for a specific object (eaLoc).")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public circuitElement GetCircuitElementByObject(string eaLoc)
		{
			return null;
		}
	
		[WebMethod(Description = "Returns all required data for all loadManagementDevices.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public loadManagementDevice[] GetAllLoadManagementDevices(string lastReceived)
		{
			return null;
		}

		
		[WebMethod(Description = "Returns the theoretical total amount of load that can be controlled, expressed in kW.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public float GetAmountOfControllableLoad()
		{
			return 0f;
		}

		[WebMethod(Description = "Returns the amount of load that is currently under control, expressed in kW.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public float GetAmountOfControlledLoad()
		{
			return 0f;
		}

		
		[WebMethod(Description="Returns the requested loadManagementDevice(s), chosen by meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public loadManagementDevice[] GetLoadManagementDeviceByMeterID(meterID meterID)
		{
			return null;
		}
		
		[WebMethod(Description="Returns the requested loadManagementDevice(s), chosen by the objectID of the service location.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public loadManagementDevice[] GetLoadManagementDeviceByServiceLocationID(string serviceLocationID, serviceType serviceType)
		{
			return null;
		}
		
		
		[WebMethod(Description="Returns true if load management is in effect for a given serviceLocation chosen by objectID of serviceLocation, otherwise false.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public bool IsLoadManagementActive(string serviceLocationID, serviceType serviceType) 
		{
			return false;
		}

					
		[WebMethod(Description = "Returns all of the substation load control statuses")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public substationLoadControlStatus [] GetAllSubstationLoadControlStatuses()
		{
			return null;
		}

#endregion
       

		#region Methods to Modify MDM(The Server) Data

		[WebMethod(Description = "Allow requester to modify OD data for a specific outage detection device object.  If this transaction failes,OD returns information about the failure using a SAOPFault.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ModifyODDataForOutageDetectionDevice(outageDetectionDevice oDDevice)
		{
			return null;
		}

		
	#endregion

	#region Methods to publish Event Notification to MR(The subscriber)

		[WebMethod(Description = "Publisher notifies subscriber that blink alarms have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] BlinkAlarmNotification(blinkAlarm[] alarms)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies subscriber that voltage alarms have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] VoltageAlarmNotification(voltageAlarm[] alarms)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies MDM of a change in the customer object by sending the changed customer object.MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CustomerChangedNotification(customer[] changedCustomers)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies MDM of a change in  customer account(s) by sending the changed account object(s).MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

		[WebMethod(Description = "Publisher notifies MDM of a change in the meter object by sending the changed meter object.  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterChangedNotification(meters changedMeters)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies MDM to remove the associated meter(s).  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterUninstalledNotification IN V4.2.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterRemoveNotification(meters removedMeters)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies MDM that the associated meter(s)have been retired from the system.  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterRemovedNotification IN V4.2.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterRetireNotification(meters retiredMeters)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies MDM to Add the associated meter(s).MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterAddNotification(meters addedMeters)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies MDM that meter(s) have been deployed or exchanged.  MDM returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterExchangeNotification(meterExchanges meterChangeout)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies MDM of new outages by sending the new lists of CustomersAffectedByOutage.  MDM returns status of failed tranactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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
		[WebMethod(Description = "EDTR Notifies MDM of a received end device (meter) shipment by sending the changed endDeviceShipment object.  MDM returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] EndDeviceShipmentNotification(endDeviceShipment shipment)
		{
			return null;
		}
		[WebMethod(Description = "MR publishes new meter readings to the CB by sending a formattedBlock object.  CB returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] FormattedBlockNotification(formattedBlock changedMeterReads, string transactionID, string errorString)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies OA of a change in OutageDetectionEvents by sending an array of changed OutageDetectionEvent objects.  OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ODEventNotification(outageDetectionEvent[] ODEvents, string transactionID)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies OA of a change in OutageDetectionDevice by sending an array of changed OutageDetectionDevice objects.  OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ODDeviceChangedNotification(outageDetectionDevice[] ODDevices)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM to add the associated connect/disconnect device(s). MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDDeviceAddNotification(CDDevice[] addedCDDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM of a change in connect/disconnect device(s).  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDDeviceChangedNotification(CDDevice[] changedCDDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM that connect/disconnect device(s) have been deployed or exchanged.  MDM returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
		{
			return null;
		}
	
		[WebMethod(Description = "Publisher notifies MDM to remove the associated connect/disconnect device(s).  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDDeviceRemoveNotification(CDDevice[] removedCDDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM that connect/disconnect device(s) have been installed. MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDDeviceInstalledNotification(CDDevice[] installedCDDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM that the associated connect/disconnect devices(s)have been retired from the system.  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CDDeviceRetireNotification(CDDevice[] retiredCDDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM of a change in the History Log by sending the changed historyLog object.  MDM returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HistoryLogChangedNotification(historyLog[] changedHistoryLogs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher Notifies MDM of a change in the LoadProfile object(s) by sending the changed profileObject(s).  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] LoadProfileChangedNotification(profileObject[] changedLoadProfiles)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber of a completion of tests on electric meters by sending an array of testedElectricMeters.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterTestNotification(testedElectricMeter[] tests, string transactionID)
        {
            return null;
        }
	   
		[WebMethod(Description = "Publisher notifies MDM that meter(s) have been installed. MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterInstalledNotification(meters addedMeters, string transactionID)
		{
			return null;
		}

        [WebMethod(Description = "Requests that PPM process a set of meter exchnages. PPM returns information about failed transactions in the form of an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] PPMMeterExchangeNotification(meterExchanges changeouts)
		{
			return null;
		}


		[WebMethod(Description = "Notifies the PPM that changes have occurred in chargeable devices. PPM returns information about failed transactions in the form of an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ChargeableDeviceChangedNotification(chargeableDeviceList[] deviceList)
		{
			return null;
		}


        [WebMethod(Description = "Allow client to Modify CB data for a specific customer object.  CB returns information about failed transactions using an array of errorObjects.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ModifyCBDataForCustomer(customer[] customerData)
		{
			return null;
		}

        [WebMethod(Description = "Allow client to Modify CB data for the Service Location object.  CB returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ModifyCBDataForServiceLocations(serviceLocation[] serviceLocationData)
		{
			return null;
		}

        [WebMethod(Description = "Allow client to Modify CB data for the Meter object.  CB returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ModifyCBDataForMeters(meters meterData)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies Subscriber of a change in meter readings by sending the changed meterReading objects.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ReadingChangedNotification(meterReading[] changedMeterReads, string transactionID)
        {
            return null;
        }


        [WebMethod(Description = "Publisher notifies subscriber of the status of messages on the associated IHD. This method call is the asynchronous reply to InitiateInHomeDisplayMessage or CancelInHomeDisplayMessage methods that were sent earlier. These methods are linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] IHDMessageStatusNotification(IHDMessageStatus messageStatus, string messageID, HANDeviceID hanDeviceID, string transactionID, HANInterfaceID interfaceID, IHDMessageType messageType)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of the fact that the customer/resident has confirmed receipt of messages on the associated IHD. This method call is the asynchronous reply to InitiateInHomeDisplayMessage method that was sent earlier. The InitiaiteInHomeDisplayMessage method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] IHDMessageConfirmedNotification(string inHomeDisplayMessageID, HANDeviceID hanDeviceID, string transactionID, HANInterfaceID interfaceID, System.DateTime messageConfirmedTime, string errorString)
        {
            return null;
        }
		
		[WebMethod(Description = "Publisher notifies MDM to add the associated in-home display(s). MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayAddNotification(inHomeDisplay[] addedIHDs, string transactionID)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM of a change in in-home display(s) by sending the changed inHomeDisplay object.  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayChangedNotification(inHomeDisplay[] changedIHDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM that in-home displays(s) have been deployed or exchanged.  MDM returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayExchangeNotification(inHomeDisplayExchange[] IHDChangeout)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM that in home display(s) have been installed. MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayInstalledNotification(inHomeDisplay[] addedIHDs)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies MDM to remove the associated in-home displays(s).  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayRemoveNotification(inHomeDisplay[] removedIHDs, string transactionID)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher notifies MDM that the associated in-home display(s)have been retired from the system.  MDM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayRetireNotification(inHomeDisplay[] retiredIHDs)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber to set the price structure on a HAN. The price tiers are set for the HAN and to all devices to which price applies. The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous PricingTiersChangedNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHANPricing(priceTierStructure priceTierStructure, temperatureTierStructure temperatureTierStructure, loadCycleTierStructure loadCycleTierStructure, HANInterfaceID hanInterfaceID, string transactionID, string responseURL)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests the current price structure on a HAN. The price structure is returned to the URL specified in the responseURL parameter using the asynchronous HANPricingNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHANPricingRequest(HANInterfaceID hanInterfaceID, string transactionID, string responseURL)
        {
            return null;
        }

		
		[WebMethod(Description = "Publisher notifies requester of the current rate structure associated with a HAN. This method call is the asynchronous reply to InitiateHANPricingRequest method that was sent earlier. The InitiateHANPricingRequest method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HANPricingNotification (priceTierStructure priceTierStructure, HANInterfaceID interfaceID, string transactionID)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber of capabilities of the associated IHD. The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDCapabilitySettingsNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateIHDCapabilitySettings(inHomeDisplayCapabilitySetting[] inHomeDisplayCapabilitySettings, HANDeviceID deviceID, string transactionID, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of capabilities of the associated IHDs on a HAN group. The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDCapabilitySettingsNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateIHDCapabilitySettingsToGroup(inHomeDisplayCapabilitySetting[] inHomeDisplayCapabilitySettings, HANGroupID groupID, string transactionID, string responseURL)
        {
            return null;
        }


        [WebMethod(Description = "This command permits the creation of a tunnel through the AMI network to a HAN device for the purpose of delivering a manufacturer-specific capability. The result of the command is returned to the URL specified in the responseURL parameter using the asynchronous ManufacturerSpecificCommandNotification, which is linked to this method call using the transactionID. It is anticipated that this capability will only be used for extensions where no equivalent capability exists in the specification. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateManufacturerSpecificCommand(HANDeviceID deviceID, string transactionID, tunnelCommandContent command, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }




        [WebMethod(Description = "This command permits the creation of a tunnel through the AMI network to a HAN devices on a HAN group for the purpose of delivering a manufacturer-specific capability. The result of the command is returned to the URL specified in the responseURL parameter using the asynchronous ManufacturerSpecificCommandNotification, which is linked to this method call using the transactionID. It is anticipated that this capability will only be used for extensions where no equivalent capability exists in the specification. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateManufacturerSpecificCommandToGroup(HANGroupID groupID, string transactionID, tunnelCommandContent command, string responseURL)
        {
            return null;
        }



        [WebMethod(Description = "Publisher notifies requester of result of the request to send a manufacturer-specific command to a HAN device. This method call is the asynchronous reply to the InitiateManufacturerSpecificCommand method that was sent earlier. The calling method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ManufacturerSpecificCommandNotification(HANDeviceID deviceID, string transactionID, tunnelCommandContent command, HANInterfaceID interfaceID)
        {
            return null;
        }

			
		[WebMethod(Description = "Publisher notifies subscriber to add the associated thermostats(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThermostatAddNotification(thermostat[] addedThermostats, string transactionID)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher notifies subscriber to remove the associated thermostats(s). For this method, it is only required to populate the identifying fields on the thermostats (objectID, objectName, and utility). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThermostatRemoveNotification(thermostat[] addedThermostats, string transactionID)
		{
			return null;
		}


        [WebMethod(Description = "Publisher notifies requester of the current schedule associated with a thermostat. This method call can be either the solicited asynchronous reply to InitiateThermostatScheduleRequest or can be an unsolicited asynchronous reply to an InitiateThermostatSchedule method that was sent earlier. The calling method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThermostatScheduleNotification(thermostatSchedule schedule, HANDeviceID thermostatID, string transactionID, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies requester of the result of the change to the schedule associated with a thermostat. This method call may be an asynchronous reply to InitiateThermostatSchedule method that was sent earlier and after the customer/resident confirms the new thermostat schedule. The calling method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThermostatScheduleConfirmedNotification(HANDeviceID thermostatID, string transactionID, bool isConfirmed, HANInterfaceID interfaceID)
        {
            return null;
        }


        [WebMethod(Description = "Publisher notifies requester of the current configuration associated with a thermostat. This method call can be either the solicited asynchronous reply to InitiateThermostatConfigurationRequest or can be an unsolicited asynchronous reply to an InitiateThermostatConfiguration method that was sent earlier. The calling method is linked to this method call using the transactionID. The HANDeviceID identifies the thermostat in question. If this call is in response to an InitiateThermostConfigurationRequest, the current configuration of the thermostat shall be returned, if this call is in response to an InitiateThermostatConfiguration, the currentConfiguration may be omitted. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThermostatConfigurationNotification(HANDeviceID thermostatID, string transactionID, thermostatCurrentConfiguration currentConfiguration, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests that subscriber establish a heating and/or cooling schedule for a thermostat. The asynchronous return is a ThermostatScheduleNotification, which is linked to this method call using the transactionID and should be returned to the URL specified in the responseURL. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateThermostatSchedule(thermostatSchedule schedule, HANDeviceID thermostatID, string transactionID, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests the current heating and/or cooling schedule on a thermostat. The thermostat schedule is returned using the asynchronous ThermostatScheduleNotification, which is linked to this method call using the transactionID and should be returned to the URL specified in the responseURL. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateThermostatScheduleRequest(HANDeviceID thermostatID, string transactionID, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests the HAN Communications server manage the configuration of a programmable controlling thermostat. The result of this request is returned using the asynchronous ThermostatConfigurationNotification, which is linked to this method call using the transactionID and should be returned to the URL specified in the responseURL. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateThermostatConfiguration(thermostatConfiguration configuration, HANDeviceID thermostatID, string transactionID, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests the current configuration on a thermostat. The configuration is returned using the asynchronous ThermostatConfigurationNotification, which is linked to this method call using the transactionID and should be returned to the URL specified in the responseURL. The thermostat configuration is carried in the thermostatCurrentConfiguration object. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateThermostatConfigurationRequest(HANDeviceID thermostatID, string transactionID, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }


        [WebMethod(Description = "Publisher notifies subscriber of changes in the established capability settings for the associated IHD. This method call is the asynchronous reply to InitiateIHDCapabilitySettings method that was sent earlier. The InitiateIHDCapabilitySettings method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] IHDCapabilitySettingsNotification(HANDeviceID inHomeDisplayID, string transactionID, HANInterfaceID interfaceID)
        {
            return null;
        }

		
		[WebMethod(Description = "The Requester requests from the server a list of names of in home display groups for a specific inHomeDisplay.  The server returns an array of strings including the names of the supported inHomeDisplayGroups.  The Requester can then request the members of a specific group using the GetIHDGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetIHDGroupNamesByInHomeDisplayID(string inHomeDisplayID)
		{
			return null;
		}
		
		
		[WebMethod(Description = "Requester establishes a new in-home display group on the server.  The server returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] EstablishIHDGroup(inHomeDisplayGroup IHDGroup)
		{
			return null;
		}

		[WebMethod(Description = "Requester deletes a previously established in-home display group on the server, specified by sending the inHomeDisplayGroupID.  The server returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] DeleteIHDGroup(string IHDGroupID)
		{
			return null;
		}
		
		[WebMethod(Description = "Requester deletes an existing HAN device group on the server. The server returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] DeleteHANDeviceGroup(HANGroupID groupID)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher notifies subscriber that messages should be shown on the associated in-home display. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. THE USE OF THIS METHOD HAS BEEN DEPRECATED AS OF V4.1.4; ITS USE WILL BE REPLACED WITH THE InitiateInHomeDisplayMessage AS OF V4.2.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InHomeDisplayMessageNotification(inHomeDisplayMessage message)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber that messages should be shown on the in-home displays associated with an IHDGroup . The results of this method shall be returned to the URL specified in the responseURL parameter using one or more of the asynchronous IHDMessageStatusNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateInHomeDisplayMessageToGroup(inHomeDisplayMessage[] messages, HANGroupID hanGroupID, string transactionID, string responseURL)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that messages should be shown on the associated IHD. The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDMessageStatusNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateInHomeDisplayMessage(inHomeDisplayMessage message, HANDeviceID deviceID, string transactionID, string responseURL, HANInterfaceID interfaceID)
        {
            return null;
        }



        [WebMethod(Description = "This command permits the commissioning of a new HAN in preparation of registering HANDevices. The result of the command is returned to the URL specified in the responseURL parameter using the asynchronous HANCommissionNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHANCommissioning(HANInterfaceID interfaceID, string type, duration timeout, string transactionID, string responseURL)
        {
            return null;
        }

		
		[WebMethod(Description = "Publisher notifies subscriber of the result of HAN commissioning for one or more home area networks. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateHANCommissiong. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HANCommissioningNotification(HANCommission[] commissions, string transactionID)
		{
			return null;
		}


        [WebMethod(Description = "Publisher notifies subscriber that messages that previously have been sent should be canceled on an in-home display associated with a specific HAN interface (ESI). The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDMessageStatusNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelInHomeDisplayMessage(string inHomeDisplayMessageID, HANDeviceID deviceID, HANInterfaceID interfaceID, string transactionID, string responseURL)
        {
            return null;
        }



        [WebMethod(Description = "Publisher notifies subscriber that messages that previously have been sent should be canceled on the in-home displays associated with an IHDGroup. The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDMessageStatusNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelInHomeDisplayMessageToGroup(string inHomeDisplayMessageID, HANGroupID HANGroupID, string transactionID, string responseURL)
        {
            return null;
        }


        [WebMethod(Description = "Publisher notifies subscriber that billing messages should be shown on the associated in-home display.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.  THIS MESSAGE HAS BEEN DEPRECATED IN VERSION 4.1.5, IT WILL BE REPLACED IN VERSION 4.2 WITH THE InitiateInHomeDisplayBillingMessage METHOD, WHICH WAS ADED IN VERSION 4.1.5. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayBillingMessageNotification(inHomeDisplayBillingMessage message)
        {
            return null;
        }


		[WebMethod(Description = "MR Notifies CB of the success or failure of meter reading schedule requests by sending readingScheduleResult objects.  CB returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ReadingScheduleResultNotification(readingScheduleResult[] scheduleResult, string transactionID, string errorString)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber of meter event(s) by sending a meterEventList object.  Subscriber returns information about failed transactions in an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterEventNotification(meterEventList events, string transactionID)
        {
            return null;
        }

		[WebMethod(Description = "Publisher notifies subscriber that meterBase(es) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterBaseExchangeNotification(meterBaseExchange[] MBChangeout)
		{
			return null;
		}
		[WebMethod(Description = "Publisher notifies subscriber that meter base(es) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] MeterBaseInstalledNotification(meterBase[] addedMBs)
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
		[WebMethod(Description = "Publisher notifies subscriber of a change in the connect disconnect event object(s) by sending the changed connectDisconnectEvent object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] ConnectDisconnectChangedNotification(connectDisconnectEvent[] changedCDEvents)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher notifies subscriber of the status of pricing structure changes on an HAN. This method call is the asynchronous reply to InitiateHANPricing method that was sent earlier. The InitiateHANPricing method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] PricingTiersChangedNotification (HANInterfaceID hanInterfaceID, string transactionID)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber of the status of temperature settings associated with pricing tiers. The receipt of this method call should not be interpreted to mean that the currently applied temperature offset has changed. This method call is the asynchronous reply to InitiateHANPricing method that was sent earlier and for which temperature tiers were set. The InitiateHANPricing method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] TemperatureTiersChangedNotification(HANDeviceID thermostatID, string transactionID, HANInterfaceID interfaceID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of the status of load control settings associated with pricing tiers. The receipt of this message does not imply that the currently applied load cycling has stopped. This method call is the asynchronous reply to InitiateHANPricing method that was sent earlier and for which load cycle tiers were set. The InitiateHANPricing method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LoadCycleTiersChangedNotification(HANDeviceID loadControlDeviceID, string transactionID, HANInterfaceID interfaceID)
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

        [WebMethod(Description = "Publisher notifies the server that significant usage has been detected on meters that were previously placed into usage monitoring mode using a call to the InitiateUsageMonitoring method on the Publisher.  The array of meterID can be used to pass the list of meters for which excessive usage has been detected.  The array of meterReading can be used to pass the meter readings on those meters at the time that the excessive usage was detected.  The meterReading.meterID element MUST be populated on the meterReading object for this use case so that the readings can be linked to the meter identifiers (meterIDs) if more than one meterID has been included in this notification.  The transactionID is included to link this notification to the previous InitiateUsageMonitoring method call.  Server returns information about failed transactions using an array of errorObjects.  In Version 4.2, this method shall be modified to include a usageMonitoringInstance object that will inherently link the meterID and the associated meter reading, but such a change cannot be made at this time since it would be a breaking change in Version 4.1.x.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UsageMonitoringNotification(meterID[] meters, meterReading[] readings, string transactionID)
        {
            return null;
        }


		[WebMethod(Description = "Publisher notifies DR to add the associated load mangement device(s). DR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] LMDeviceAddNotification(loadManagementDevice[] addedLMDs, string transactionID)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher notifies DR of a change in load mangement device(s)by sending the changed loadManagementDevice object(s).  DR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] LMDeviceChangedNotification(loadManagementDevice[] changedLMDs, string transactionID)
		{
			return null;
		}
		
		[WebMethod(Description = "Publisher notifies DR that load mangement device(s) have been deployed or exchanged.  DR returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] LMDeviceExchangeNotification(LMDeviceExchange[] LMDChangeout)
		{
			return null;
		}

        [WebMethod(Description = "Publisher notifies DR to remove the associated load mangement device(s).  DR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceRemoveNotification(loadManagementDevice[] removedLMDs, string transactionID)
        {
            return null;
        }

		[WebMethod(Description = "Publisher notifies DR that the associated load mangement devices(s)have been retired from the system.  DR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] LMDeviceRetireNotification(loadManagementDevice[] retiredLMDs)
		{
			return null;
		}

		
		[WebMethod(Description = "Client notifies DA of changes in analog values by sending an array of changed scadaAnalog objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAAnalogChangedNotification(scadaAnalog[] scadaAnalogs)
		{
			return null;
		}
		
		[WebMethod(Description = "SCADA Notifies DA of changes in a specific analog value, chosen by scadaPointID, by sending a changed scadaAnalog object.  If this transaction fails, DA returns information about the failure in a SOAPFault.   ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAAnalogChangedNotificationByPointID(scadaAnalog scadaAnalog)
		{
			return null;
		}
		
		[WebMethod(Description = "SCADA Notifies DA of changes in a specific analog value, limited to power analogs, by sending an arrray of changed scadaAnalog objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAAnalogChangedNotificationForPower(scadaAnalog[] scadaAnalogs)
		{
			return null;
		}

		[WebMethod(Description = "SCADA Notifies DA of changed analog values, limited to voltage analogs, by sending an array of changed scadaAnalog objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAAnalogChangedNotificationForVoltage(scadaAnalog[] scadaAnalogs)
		{
			return null;
		}

		[WebMethod(Description = "SCADA Notifies DA of changes in SCADA point definitions by sending an array of changed scadaPoint objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAPointChangedNotification(scadaPoint[] scadaPoints)
		{
			return null;
		}

		[WebMethod(Description = "SCADA Notifies DA of changes in SCADA point definitions, limited to Analog points, by sending an array of changed scadaPoint objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAPointChangedNotificationForAnalog(scadaPoint[] scadaPoints)
		{
			return null;
		}

		[WebMethod(Description = "SCADA Notifies DA of changes in SCADA point definitions, limited to Status points, by sending an array of changed scadaPoint objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAPointChangedNotificationForStatus(scadaPoint[] scadaPoints)
		{
			return null;
		}

		[WebMethod(Description = "SCADA Notifies DA of changes in point status by sending an array of changed scadaStatus objects.  DA returns failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAStatusChangedNotification(scadaStatus[] scadaStatuses)
		{
			return null;
		}

		[WebMethod(Description = "SCADA Notifies DA of changes in the status of a specific point, chosen by PointID, by sending a changed scadaStatus object.  If this transaction fails, DA returns information about the failure in a SOAPFault. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] SCADAStatusChangedNotificationByPointID(scadaStatus scadaStatus)
		{
			return null;
		}
		
						
		[WebMethod(Description = "Publisher notifies subscriber of changes in point status by sending an array of changed scadaStatus objects. Subscriber returns failed transactions using an array of errorObjects. The transactionID calling parameter links this published data response with the previously received InitiateStatusReadByPointID method call. If no points are identified, the server shall return statuses for all status points. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] StatusChangedNotificationByPointID(scadaStatus[] scadaStatuses, string transactionID)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies subscriber of changes in analog values by sending an array of changed scadaAnalog objects. subscriber returns failed transactions using an array of errorObjects. The transactionID calling parameter links this published data response with the previously received InitiateAnalogReadByPointID method call. If no points are identified, the server shall return analogs for all analog points. ")] 
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] AnalogChangedNotificationByPointID(scadaAnalog[] scadaAnalogs, string transactionID)
		{
			return null;
		}

	
	#endregion
	#region Methods to Get Connectivity and/or Trace Data

		[WebMethod(Description = "Returns all substation names.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetSubstationNames()
		{
			return null;
		}

		[WebMethod(Description = "Returns all circuit elements fed by a given line section or node (eaLoc).   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public circuitElement[] GetDownlineCircuitElements(string eaLoc, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description="Returns circuit elements in the shortest route to source from the given line section or node (eaLoc). The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public circuitElement[] GetUplineCircuitElements(string eaLoc, string lastReceived) 
        {
            return null;
        }

		[WebMethod(Description="Returns circuit elements immediately fed by the given line section or node (eaLoc). The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public circuitElement[] GetChildCircuitElements(string eaLoc, string lastReceived) 
		{
            return null;
        }
		
		[WebMethod(Description="Returns circuit elements immediately upstream of the given line section or node (eaLoc). The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public circuitElement[] GetParentCircuitElements(string eaLoc, string lastReceived) 
        {
            return null;
        }

		[WebMethod(Description = "Returns all circuit elements. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public circuitElement[] GetAllCircuitElements(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all circuit elements that have been modified since the previous session identified. The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public circuitElement[] GetModifiedCircuitElements(string previousSessionID, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns the meter connectivity for all meters downline from a given meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterConnectivity[] GetDownlineMeterConnectivity(meterID meterID)
		{
			return null;
		}
		[WebMethod(Description = "Finds the first upline distribution transformer from a given meterID and returns the meter connectivity for all meters cnnected to it.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterConnectivity[] GetUplineMeterConnectivity(meterID meterID)
		{
			return null;
		}
		[WebMethod(Description = "Returns the meter connectivity for all meters on the same transformer as the given meterID, including the meter being requested. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterConnectivity[] GetSiblingMeterConnectivity(meterID meterID)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns all other meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public otherMeter[] GetAllOtherMeters(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description = "Returns all required Service Location data for all Service Locations. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public serviceLocation[] GetAllServiceLocations(string lastReceived) 
		{
			return null;
		}

		[WebMethod(Description = "Returns details of the billed usage for a specific account.  This method is used by the Requester to reconcile its records with those in the CB.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public billedUsage GetBilledUsage(string accountNumber, System.DateTime cisBillDate)
		{
			return null;
		}

        [WebMethod(Description = "Returns billing data for all accounts that were billed between the startBillDate and endBillDate.  This method is used by the PPM to reconcile its records with those in the CB.The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public billingData[] GetBillingData(System.DateTime startBillDate, System.DateTime endBillDate, string lastReceived)
        {
            return null;
        }

		[WebMethod(Description = "Returns detailed billing data for a specific account.  This method is used by the PPM to reconcile its records with those in the CB.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public billingDetail[] GetBillingDetail(string accountNumber, System.DateTime cisBillDate)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns the chargeable devices associated with an account number given a customer's accountNumber.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public chargeableDevice[] GetChargeableDevicesByAccountNumber(string accountNumber)
		{
			return null;
		}
		
		[WebMethod(Description = "The Requester requests from the server the members of a specific in home display group, identified by the IHDGroupName parameter.  This method is used, along with the GetIHDGroupNames method to enable the requester to get information about which meters are included in a specific in home display group.  The server returns an inHomeDisplayGroup in response to this method call.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public inHomeDisplayGroup GetIHDGroupMembers(string IHDGroupName)
		{
			return null;
		}
		
		
		[WebMethod(Description = "The Requester requests from the server a list of names of in home display groups.  The server returns an array of strings including the names of the supported inHomeDisplayGroups.  The requester can then request the members of a specific group using the GetIHDGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetIHDGroupNames()
		{
			return null;
		}
		

		
		[WebMethod(Description = "Requester asks HAN server to initiate and manage the registration of a new HAN device. After this communication, the HANDevice should be able to join the HAN if it has the appropriate security credentials. Server returns information about failed transactions using an array of errorObjects. The HAN function publishes the results of the device registration asynchronously using a HANRegistrationNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] InitiateHANRegistration(HANInterfaceID HANInterfaceID,HANDeviceID deviceID, HANSecurityToken securityToken, duration timeOut, string responseURL, string transactionID)
		{
			return null;
		}
		
		[WebMethod(Description = "Requester asks the HAN Communications server to initiate and manage the eviction of an existing HAN device from a HAN. HAN Communications server returns information about failed transactions using an array of errorObjects. The HAN function publishes the results of the device registration asynchronously using a HANRegistrationNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Cancel request.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CancelHANRegistration(HANInterfaceID HANInterfaceID,HANDeviceID deviceID, string responseURL, string transactionID)
		{
			return null;
		}

		[WebMethod(Description = "Requester asks HAN server to initiate and manage the request for the registration statuses of one or more HAN devices. The HAN function publishes the registration status of the devices asynchronously using a HANRegistrationNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHANRegistrationStatusRequest(registrationStatus[] registrationStatuses, string responseURL, string transactionID)
		{
			return null;
		}


		[WebMethod(Description = "The HAN Communications server notifies subscriber of the status of a HAN registration request that the subscriber previously issued to the HAN Communications server. The HAN Communications server sends an array of HANRegistration objects. The subscriber returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this published data method call with the InitiateHANRegistration that was issued to request the HAN registration.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HANRegistrationNotification(HANRegistration[] registrations, string transactionID)
		{
			return null;
		} 
		
		
		[WebMethod(Description = "Returns the meter history events for a specific meter, chosen by meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterHistoryEvent[]  GetMeterHistoryByMeterID(meterID meter)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns the balance adjustments to be made on the Requester's system by the CB between the stated start and stop times.  This is an alternative method for obtaining balance adjustments and could replace or be in addition to the publish method AdjustPPMBalance.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public ppmBalanceAdjustment[] GetPPMBalanceAdjustments(System.DateTime startTime, System.DateTime stopTime)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns the requested PPMLocation given a customer's accountNumber.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public ppmLocation GetPPMCustomer(string accountNumber)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns the payment transactions accepted by the CB between the stated start and stop times.  This is an alternative method for obtaining payments and could replace or be in addition to the publish method CommitPaymentTransaction.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public paymentTransactionList[] GetPPMPayments(System.DateTime startTime, System.DateTime stopTime)
		{
			return null;
		}

        [WebMethod(Description = "Returns a service order, specified by its serviceOrderID.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public serviceOrder GetServiceOrderByServiceOrderID(string serviceOrderID)
        {
            return null;
        }
		
		[WebMethod(Description = "Returns the service orders that are associated with a specific service location, specified by its serviceLocationID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceOrder[] GetServiceOrdersByServiceLocation(string serviceLocationID)
		{
			return null;
		}
		
		[WebMethod(Description = "Returns the service orders that have a specified serviceOrder Status code. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public serviceOrder[] GetServiceOrdersByStatus(soStatusCode status, string lastReceived)
		{
			return null;
		}

        [WebMethod(Description = "Requests that Receiver process a set of balance adjustment transactions. Receiver returns information about failed transactions in the form of an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AdjustPPMBalance(ppmBalanceAdjustment[] adjustments)
        {
            return null;
        }


		[WebMethod(Description = "Requests that PPM process a set of payment transactions accepted on the CB.  PPM returns information about the net payment to the CB to be used in accordance with its business rules.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public paymentTransactionList CommitPaymentTransaction(paymentTransactionList transactions)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies PPM to enroll customers in pre-paid metering. PPM returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] EnrollPPMCustomer(ppmLocation[] newPPMCustomers)
		{
			return null;
		}

		[WebMethod(Description = "Publisher notifies PPM to unenroll customers in pre-paid metering. PPM returns information about failed transactions using an array of errorObjects. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] UnenrollPPMCustomer(ppmLocation[] newPPMCustomers)
		{
			return null;
		}

		[WebMethod(Description = "Requests that PPM return status information about a set of PPMLocations. PPM returns information in the form of an array of ppmStatus objects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public ppmStatus[] GetPrePayStatus(string[] ppmLocations)
		{
			return null;
		}


		[WebMethod(Description = "Returns the meter connectivity for a specific meter.  The client requests the data by passing a meterID.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public meterConnectivity GetMeterConnectivityByMeterID(meterID meterID)
		{
			return null;
		}
	
		
	#endregion 
     
        #region New methods in Version 4.1.5
        ///
        /// New methods in Version 4.1.5
        ///

        [WebMethod(Description = "Requester requests MDM to begin monitoring a list of meters for specific meter events.  Meter event notifications are subsequently published to the requester using MeterEventNotification method calls that are sent to the URL specified in the responseURL parameter.  The transactionID calling parameter links this Initiate request with the published data method call and with subsequent CancelMeterEventMonitoring method calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterEventMonitoring(eventMonitoringList monitoringList, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Requester requests MDM to cancel event monitoring on a previously sent eventMonitoringItem – a group of meters and a specific set of meter events.  The eventMonitoringItem to be cancelled shall be identified by its objectID.  The transactionID calling parameter links this Cancel request with the the previously sent InitiateMeterEventMonitoring method call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelMeterEventMonitoring(string monitoringItemObjectID, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "The Requester requests from the server all meters that have the specified meterConnectionStatus. Allowable values of meterConnectionStatus are [Other / Connected / Disconnected / DisconnectedNonPay / Unknown]. The server returns an array of meters. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public meters GetMetersByMeterConnectionStatus(meterConnectionStatus status, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns the meter that contains the communications module that has the objectID identified as being the transponderID in the request. The meters structure can carry an array of meters of any service type (thus electricMeter, gasMeter, waterMeter, etc.).  Although it is anticipated that only one meter will be returned since the transponderID calling parameter should be unique, the meters structure permits the use of this single method to get information about meters of all service types.  The transponderID SHALL correspond to the objectID of the communications module included in the returned meter as part of the XXXMeter.moduleList.module (for instance for an electric meter, the transponderID SHALL be the electricMeter.moduleList.module.objectID). ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public meters GetMeterByTransponderID(string transponderID)
        {
            return null;
        }

        [WebMethod(Description = "This method permits the Requester to request of the connect/disconnect system whether or not the service is equipped with remote connection/disconnection capability.  If no RCD switch exists at a service then remote disconnection/reconnection of the service will not be possible until the RCD switch is installed. In this sense, 'Supported' means both that the meter is capable of being disconnected (whether that capability is inherent in the meter or is provided in a separate disconnect collar) and that the disconnection/reconnection capability is enabled.  If BOTH of these conditions are true then the CD SHALL return 'True'.  If EITHER of these conditions is not true then the CD_Server SHALL return 'False'. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public bool IsCDSupported(ppmLocation location)
        {
            return false;
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

        [WebMethod(Description = "Publisher notifies Subscriber of metering thresholds that have been reached.  The ThresholdEventNotification is sent in response to a previously sent InitiateThresholdMonitoing call.  The transactionID in this message should match the transactionID from that Initiate call. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThresholdEventNotification(thresholdMonitoringList thresholds, string transactionID)
        {
            return null;
        }


        [WebMethod(Description = "The Publisher notifies the subscriber that meter(s) have been exchanged. Subscriber returns information about failed transactions in an array of errorObjects. The subscriber subsequently may return information to the publisher about the status of its handling of the meterExchanges by sending a MeterExchangedNotification to the URL specified in the responseURL parameter.  The linked MeterExchangedNotification SHALL carry the same transactionID as the one that the subscriber received in this Initiate method.   The payload includes a meterExchanges object that can carry arrays of all possible types of meters (electricMeter, gas,Meter, waterMeter, propaneMeter and otherMeter), thus this one method can be used to handle different meter types.  It should be noted that in Version 3.0, the function of this call was performed by a method called MeterExchangeNotification and that there was no MeterExchangedNotification.  The MeterExchangeNotification has been deprecated in V4.1.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterExchange(meterExchanges exchanges, string responseURL, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "The Publisher notifies the subscriber that the MR system has prepared to begin reading meters that previously had been exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. This method SHALL be linked with the previously received InitiateMeterExchange method using the same transactionID that was sent in the prior InitiateMeterExchange method. The payload includes a meterExchanges object that can carry arrays of all possible types of meters (electricMeter, gas,Meter, waterMeter, propaneMeter and otherMeter), thus this one method can be used to handle different meter types.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterExchangedNotification(meterExchanges exchanges, string transactionID)
        {
            return null;
        }


        [WebMethod(Description = "Returns all customers that are affected by a specfic outage of interest, given the outageEventID. The outageEventID is the objectID for the outageEvent object.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public customersAffectedByOutage GetCustomersAffectedByOutage(string outageEventID)
        {
            return null;
        }

        [WebMethod(Description = "The Publisher notifies the subscriber that the MR system has configured meters subsequent to receipt of a InsertMetersInConfigurationGroup message.  Subscriber returns information about failed transactions in an array of errorObjects. This method SHALL be linked with the previously received InsertMetersInConfigurationGroup method using the same transactionID that was sent in the prior InsertMetersInConfigurationGroup method and should be sent to the URL specified using the responseURL in that InsertMetersInConfigurationGroup message.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterConfigurationNotification(meterConfigurationStatus configStatus, string transactionID)
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

        [WebMethod(Description = "Publisher notifies subscriber that billing messages should be shown on the associated IHD. The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDMessageStatusNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateInHomeDisplayBillingMessage(inHomeDisplayBillingMessageList messages, HANDeviceID deviceID, HANInterfaceID interfaceID, string transactionID, string responseURL)
        {
            return null;
        }



        [WebMethod(Description = "Publisher notifies subscriber that billing messages that previously have been sent should be canceled on an in-home display associated with a specific HAN interface (ESI). The results of this method shall be returned to the URL specified in the responseURL parameter using the asynchronous IHDMessageStatusNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CancelInHomeDisplayBillingMessage(string inHomeDisplayMessageID, HANDeviceID deviceID, HANInterfaceID interfaceID, string transactionID, string responseURL)
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

        [WebMethod(Description = "The Requester asks the MDM system, acting through its MDM endpoint, to prepare billing determinants for a selected set of services, specified by serviceID, and a specified time period. Note that the billing determinants must be prepared for a service, not a meter, since the meter associated with a service might have changed mid-cycle.  In addition, the billing determinants cannot be specified by a serviceLocation, since there might be several services of a single utility service type associated with a serviceLocation; hence it is not possible to determine which service is being requested using a serviceLocation alone.   The MDM returns information about failed transactions using an array of errorObjects. The billing determinants are returned subsequently to the requester in the form of a formattedBlock sent to the URL specified in the responseURL. The FormattedBlockNotification sent in response to this Initiate request SHALL be linked to this message using the same transactionID. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. Reading types may be specified using the fieldName parameter.  Valid values for fieldName are those that are specified in the most current FormattedBlock Implementation Guidelines Document, as issued by the MultiSpeak Initiative. The requestor may specify a preferred format for the returned formattedBlock using the formattedBlockTemplateName parameter.  If the publisher supports this template, the data should be returned in that format; if not the publisher should still return the data, but in its preferred formattedBlockTemplate format.  Other calling parameters include: (i) billingCycle – the CIS billing cycle for which readings are to be returned, (ii) billingStartDate - the starting date of the billing cycle, (iii) billingEndDate - the end date of the billing cycle, (iv) isOffCycle - a boolean that identifies whether this is an off-cycle billing.  If this is a normal on-cycle billing the value shall be 'False', if it is an off-cycle billing, the value shall be True', (v) kWhLookBack - the number of days before the billing date for which the CB will accept valid kWh readings (if zero then the reading is only acceptable on the billing date), (vi) kWLookBack- the number of days before the billing date for which the CB will accept valid kW readings (if zero then the reading is only acceptable on the billing date), and (vii) kWLookForward - the number of days to accept demand readings beyond the billing date to be used in this billing period (if zero then must use demand occurring only through the billing date).  ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateBillingDeterminants(serviceID[] serviceIDs, string billingCycle, System.DateTime billingStartDate, System.DateTime billingEndDate, Boolean isOffCycle, int kWhLookBack, int kWLookBack, int kWLookForward, string formattedBlockTemplateName, string[] fieldname, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that load management device(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceInstalledNotification(loadManagementDevice[] installedLMDs)
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
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #endregion


    }
}


