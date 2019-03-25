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
	/// Web services hosted by the outage analysis (OA) function. 
	/// </summary>
	/// 
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class OA_Server : System.Web.Services.WebService
	{
		public OA_Server()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}
      public MultiSpeakMsgHeader MultiSpeakMsgHeader;


	#region Generic for each interface

		[WebMethod(Description="Requester pings URL of OA to see if it is alive.  Returns errorObject(s) as necessary to communicate application status.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public errorObject[] PingURL() {
			return null;
		}

		[WebMethod(Description="Requester requests list of methods supported by OA.")]
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

	#region Methods to Get OA Ouptut

		[WebMethod(Description = "Returns an array of circuitElements that lie within the distance tolerance of the location expressed in latitude and longitude. If many circuitElements are found within the distance tolerance, then the server shall return the maximum number of circuitElements expressed as numCEs. If it is necessary to drop some circuitElements, the server should drop those furthest from the latitude/longitude location specified in the calling parameter list. THIS METHOD HAS BEEN DEPRECATED IN V4.1.4 AND WILL BE REMOVED IN V4.2. IT IS SUGGESTED THAT IMPLEMENTORS USE GetFeaturesNearLatLong RATHER THAN THIS METHOD.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public circuitElementAndDistance[] GetCircuitElementNearLatLong(double latitude, double longitude, lengthUnitValue tolerance, int numCEs)
        {
            return null;
        }

        [WebMethod(Description = "Returns the current status of an outage event, given the outage event ID.  The outageEventID is the objectID of an outageEvent obtained earlier by calling GetActiveOutages.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public outageEventStatus GetOutageEventStatus(string outageEventID) 
		{
			return null;
		}

		[WebMethod(Description="Returns the outageEventIDs for all active outage events.  The outageEventID is the objectID of an outageEvent.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public string[] GetActiveOutages() 
		{
			return null;
		}

		[WebMethod(Description="Returns the current status of an outage event, given the outage location.  The outageLocation object includes the telephone number, service locationID, account number and/or meter identifier at the location of the outage.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public outageEventStatus GetOutageEventStatusByOutageLocation(outageLocation location) 
		{
			return null;
		}

        [WebMethod(Description = "Returns the current outage message prompt list.  The requester system can store these messages and play them back to callers on demand, based on the OutageEventID.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public message[] GetOutageMessagePromptList()
        {
            return null;
        }

        [WebMethod(Description = "Returns the current outage status of a customer location, given the outageLocation.  The outageLocation object includes the telephone number, service locationID, account number and/or meter identifier at the location of the outage.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public locationStatus GetOutageStatusByLocation(outageLocation location)
        {
            return null;
        }

        [WebMethod(Description = "Returns the outageDetectionDevices that are currently experiencing outage conditions.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDetectionDevice[] GetOutagedODDevices()
        {
            return null;
        }

        [WebMethod(Description = "Returns all active crews that are available for dispatching if the parameter activeOnly is set to be true, otherwise all crews are returned.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public crew[] GetAllCrews(bool activeOnly, string lastReceived)
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

        [WebMethod(Description = "Returns outage events within a range of times. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageEvent [] GetOutageEventsByDate(System.DateTime startTime, System.DateTime endTime, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns all customers that are affected by a specfic outage of interest, given the outageEventID. The outageEventID is the objectID for the outageEvent object.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public customersAffectedByOutage GetCustomersAffectedByOutage(string outageEventID)
        {
            return null;
        }

        [WebMethod(Description = "Returns all active calls that have been processed by the outage management system in the form of an outageDetectionLogList.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDetectionLogList GetAllActiveCalls(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns all active calls that are not outage related in the form of an array of customerCall. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public customerCall[] GetAllActiveNonOutageCalls(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Gets the assessmentLocation objects, given the objectIDs of the assessmentLocations desired. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public assessmentLocation[] GetAssessmentLocations(string[] locationIDs)
        {
            return null;
        }

        [WebMethod(Description = "Returns the assessmentLocationIDs for all of the active locations for workers to assess storm damage.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetActiveAssessmentLocations(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns all calls that have been processed by the outage management system in the form of an outageDetectionLogList.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. ")] 
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDetectionLogList GetCallsReceivedOnOutage(string outageEventID, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns all outage duration events that have been processed by the outage management system for a given customer account and service location in the form of an outageDurationEventList.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDurationEventList GetCustomerOutageHistory(string accountNumber, string serviceLocationID)
        {
            return null;
        }
        
        [WebMethod(Description = "Returns all calls that have been processed by the outage management system for a given customer account and service location in the form of an outageDetectionLogList.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDetectionLogList GetCustomerCallHistory(string accountNumber, string serviceLocationID)
        {
            return null;
        }

        [WebMethod(Description = "Returns all outage duration events that have been processed by the outage management system for a given outage identified by outageEventID, returned in the form of an outageDurationEventList.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDurationEventList GetOutageDurationEvents(string outageEventID)
        {
            return null;
        }

        [WebMethod(Description = "Returns all outage duration events that have been processed by the outage management system for a given service location in the form of an outageDurationEventList.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDurationEventList GetOutageHistoryOnServiceLocation(string serviceLocationID)
        {
            return null;
        }

        [WebMethod(Description = "Returns all calls that have been processed by the outage management system for a given service location in the form of an outageDetectionLogList.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageDetectionLogList GetCustomerCallsOnServiceLocation(string serviceLocationID)
        {
            return null;
        }
        
        
        [WebMethod(Description = "Gets the outage,if any, at the circuitElement. At a minimum, the elementName must be populated in the circuitElement object sent. If there is no current outage for the circuitElement, then return null.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageEvent GetOutageByCircuitElement(circuitElement element)
        {
            return null;
        }

        [WebMethod(Description = "Returns the outage event, if any, associated with a circuitElement given the objectRef of the circuitElement.  The outageEventID is the objectID of an outageEvent obtained earlier by calling GetActiveOutages.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public circuitElementStatus GetCircuitElementStatus(objectRef cktElementRef)
        {
            return null;
        }

        [WebMethod(Description = "Returns information about features that lie within the distance tolerance of the location expressed in latitude and longitude.  If many features are found within the distance tolerance, then the server shall return the maximum number of features expressed as numFeatures.  If it is necessary to drop some features, the server should drop those furthest from the latitude/longitude location specified in the calling parameter list.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public bufferedObjectCollection GetFeaturesNearLatLong(double latitude, double longitude, lengthUnitValue tolerance, int numFeatures, string errorString)
        {
            return null;
        }

        [WebMethod(Description = "Returns the list of outage reason codes used by the OMS implementation.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public outageReasonContainer GetOutageReasonCodes()
        {
            return null;
        }


      	  
	#endregion  

	#region Methods to publish Event Notification to OA(The subscriber)

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
        
        [WebMethod(Description = "Publisher notifies subscriber of a change in the History Log by sending the changed historyLog object.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] HistoryLogChangedNotification(historyLog[] changedHistoryLogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of a change in OutageDetectionEvents by sending an array of changed OutageDetectionEvent objects.  OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] ODEventNotification(outageDetectionEvent[] ODEvents, string transactionID) 
		{
			return null;   
        }
		[WebMethod(Description="Publisher notifies OA of a change in OutageDetectionDevice by sending an array of changed OutageDetectionDevice objects.  OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public errorObject[] ODDeviceChangedNotification(outageDetectionDevice[] ODDevices) 
		{
           return null;
		}

        [WebMethod(Description = "Publisher notifies subscriber that assessmentLocations have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AssessmentLocationChangedNotification(assessmentLocation[] locations)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of new power monitor output by sending the new PMChangedNotification. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PMChangedNotification(powerMonitor[] monitors)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of non-outage events by sending the a customerCall object. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CHEventNotification(customerCall[] chEvent)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of a list of customer calls to close out.  OA returns status of failed transactions in an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CloseCalls(customerCall[] oldCalls)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in analog values by sending an array of changed scadaAnalog objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotification(scadaAnalog[] scadaAnalogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in point status by sending an array of changed scadaStatus objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAStatusChangedNotification(scadaStatus[] scadaStatuses)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in SCADA point definitions by sending an array of changed scadaPoint objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAPointChangedNotification(scadaPoint[] scadaPoints)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in SCADA point definitions, limited to Analog points, by sending an array of changed scadaPoint objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAPointChangedNotificationForAnalog(scadaPoint[] scadaPoints)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in SCADA point definitions, limited to Status points, by sending an array of changed scadaPoint objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAPointChangedNotificationForStatus(scadaPoint[] scadaPoints)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in a specific analog value, chosen by scadaPointID, by sending a changed scadaAnalog object.  If this transaction fails, OA returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotificationByPointID(scadaAnalog scadaAnalog)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in a specific analog value, limited to power analogs, by sending an arrray of changed scadaAnalog objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotificationForPower(scadaAnalog[] scadaAnalogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changed analog values, limited to voltage analogs, by sending an array of changed scadaAnalog objects.  OA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotificationForVoltage(scadaAnalog[] scadaAnalogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in the status of a specific point, chosen by PointID, by sending a changed scadaStatus object.  If this transaction fails, OA returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAStatusChangedNotificationByPointID(scadaStatus scadaStatus)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of changes in connect disconnect event object(s) by sending the changed connectDisconnectEvent object(s).  OA returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ConnectDisconnectChangedNotification(connectDisconnectEvent[] changedCDEvents)
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

		
        [WebMethod(Description = "CD notifies CB of state of a connect/disconnect device.  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, CB returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStateNotification(CDState state, string transactionID)
        {
            return null;
        }
        [WebMethod(Description = "CD notifies CB of state of connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, CB returns information about the failure in an array of errorObject(s). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStatesNotification(CDState[] states, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of an outage that should be denoted as being restored, given an outage event ID.  OA returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RestoreOutage(string outageEventID, System.DateTime eventTime, bool callBackCustomersThatCalled, outageReasonContainer outageCause, string dispatcherResponsible)
        {
            return null;
        }

        [WebMethod(Description = "Assigns crews to an outage given the outage event ID.  OA returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AssignCrewsToOutage(string outageEventID, crewsDispatched crewsAssigned, System.DateTime eventTime)
        {
            return null;
        }

        [WebMethod(Description = "Assigns crews to an assessment given the assessmentID (objectID of the assessment object). OA returns information on failed transactions by returning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AssignCrewsToAssessment(string assessmentID, crewsDispatched crewsAssigned, System.DateTime eventTime)
        {
            return null;
        }

        [WebMethod(Description = "Unassigns crew(s) from an assessment given the the assessmentID (objectID of the assessment object). Server returns information on failed transactions by returrning an array of errorObjects")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UnassignCrewsFromAssessment(string assessmentID, System.DateTime eventTime, string reason, crewsDispatched crewsUnassigned, string comment)
        {
            return null;
        }

        [WebMethod(Description = "Unassigns crew(s) from an outage given the outage event ID. Server returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UnassignCrewsFromOutage(string outageEventID, System.DateTime eventTime,string reason, crewsDispatched crewsUnassigned, string comment)
        {
            return null;
        }

        [WebMethod(Description = "Unassigns outages(s) from a crew given the crew ID. Server returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UnassignOutagesFromCrew(string crewID, System.DateTime eventTime, string reason, string[] outageEventIDs, string comment)
        {
            return null;
        }
      
        [WebMethod(Description = "Allows a system operator to add a remark to an outage event.  OA returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AddRemarkToOutage(string outageEventID, string remarks, System.DateTime eventTime)
        {
            return null;
        }
        [WebMethod(Description = "This method allows a dispatcher or operator to verify or restore any circuit element by phase.  This controls how the outage analysis behaves if the outage is assumed.  It also allows for connectivity changes or backfeeds by performing switching operations.It is recommended that the dispatcher verify current status using GetCircuitElementStatus prior to calling this method to change the outage element status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SetOutageElementStatus(string troubledElement, outageElementStatus statusPhaseA, outageElementStatus statusPhaseB, outageElementStatus statusPhaseC, System.DateTime eventTime, string dispatcherResponsible)
        {
            return null;
        }
        [WebMethod(Description = "Publisher Notifies OA of a change in the Customer object by sending the changed customer object(s).  DA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CustomerChangedNotification(customer[] changedCustomers)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies OA of a change in customer account(s)by sending the changed account object(s).  OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

        [WebMethod(Description = "Publisher Notifies OA of a change in the Meter object by sending the changed meter object(s).  DA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterChangedNotification(meters changedMeters)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies OA to remove the associated meter(s).  DA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterUninstalledNotification IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterRemoveNotification(meters removedMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA that the associated meter(s)have been retired from the system. OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterRemovedNotification IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterRetireNotification(meters retiredMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA to Add the associated meter(s).OA returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterAddNotification(meters addedMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA that meter(s) have been deployed or exchanged.  OA returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterExchangeNotification(meterExchanges meterChangeout)
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

        
        [WebMethod(Description = "Publisher notifies OA of the change in status of a previously established outage event. OA returns failed transactions using an errorObject.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UpdateOutageStatus(outageEventStatus outageStatus)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA that the estimated time to restoration (ETOR) should be modified. OA returns status of failed transactions in an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UpdateOutageETOR(string outageEventID, System.DateTime revisedETOR)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of power line cut that should be initiated.  OA returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateCut(switchingDeviceBank newCut, System.DateTime eventTime)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies OA of a cut that should be restored.  OA returns information on failed transactions by returrning an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RestoreCut(switchingDeviceBank restoreCut, System.DateTime eventTime)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber that an unresolved caller is now resolved by the dispatcher.  Subscriber returns status of failed transactions in an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ResolvedCaller(customerCall[] resolvedCallers)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber that a call message was listened.  Subscriber returns status of failed transactions in an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UpdateMessageStatus(message[] updatedMessages)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new or changed switching order(s) by sending switchingOrder object(s).  Subscriber returns information about failed transactions in an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SwitchingOrderChangedNotification(switchingOrder[] switchingOrders)
        {
            return null;
        }
        

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
		
		[WebMethod(Description = "Publisher notifies OA of an outage that should be discarded, given an outage event ID. Typically, an outage is discarded when it was created mistakenly or was created during training and should not be considered as an actual outage. The string dispatcherResponsible should contain the name or identifier for the dispatcher that issued this command and is included for logging purposes. OA returns information on failed transactions by returning an array of errorObjects.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] DiscardOutage(string outageEventID, System.DateTime eventTime, string dispatcherResponsible)
        {
            return null;
        }

    #endregion

    #region Methods New in Version 4.1.5

        ///
        /// New methods in Version 4.1.5
        ///

        [WebMethod(Description = "The Publisher notifies the subscriber that meter(s) have been exchanged. Subscriber returns information about failed transactions in an array of errorObjects. The subscriber subsequently may return information to the publisher about the status of its handling of the meterExchanges by sending a MeterExchangedNotification to the URL specified in the responseURL parameter.  The linked MeterExchangedNotification SHALL carry the same transactionID as the one that the subscriber received in this Initiate method.   The payload includes a meterExchanges object that can carry arrays of all possible types of meters (electricMeter, gas,Meter, waterMeter, propaneMeter and otherMeter), thus this one method can be used to handle different meter types.  It should be noted that in Version 3.0, the function of this call was performed by a method called MeterExchangeNotification and that there was no MeterExchangedNotification.  The MeterExchangeNotification has been deprecated in V4.1.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateMeterExchange(meterExchanges exchanges, string responseURL, string transactionID)
        {
            return null;
        }

        ///
        /// End of New Methods in Version 4.1.5
        ///

	#endregion

	#region Methods to Get Connectivity and/or Trace Data

		[WebMethod(Description="Returns all substation names.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public string[] GetSubstationNames() 
		{
			return null;
		}

		[WebMethod(Description="Returns all circuit elements fed by a given line section or node (eaLoc).   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
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

		[WebMethod(Description="Returns all circuit elements. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public circuitElement[] GetAllCircuitElements(string lastReceived) 
		{
			return null;
		}

		[WebMethod(Description="Returns all circuit elements that have been modified since the previous session identified. The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public circuitElement[] GetModifiedCircuitElements(string previousSessionID, string lastReceived) 
		{
			return null;
		}

		[WebMethod(Description="Returns the meter connectivity for all meters downline from a given meterID.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meterConnectivity[] GetDownlineMeterConnectivity(meterID meterID) 
		{
			return null;
		}
		[WebMethod(Description="Finds the first upline distribution transformer from a given meterID and returns the meter connectivity for all meters cnnected to it.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meterConnectivity[] GetUplineMeterConnectivity(meterID meterID) 
		{
			return null;
		}
		[WebMethod(Description="Returns the meter connectivity for all meters on the same transformer as the given meterID, including the meter being requested. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meterConnectivity[] GetSiblingMeterConnectivity(meterID meterID) 
		{
			return null;
		}

        [WebMethod(Description = "Returns all information for circuit elements fed by a given line section or node.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public MultiSpeak GetDownlineConnectivity(string eaLoc, string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns all information for circuit elements in the shortest route to source from the given line section or node (eaLoc).")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public MultiSpeak GetUplineConnectivity(string eaLoc)
        {
            return null;
        }

        [WebMethod(Description = "Returns all information for circuit elements immediately fed by the given line section or node (eaLoc).")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public MultiSpeak GetChildConnectivity(string eaLoc)
        {
            return null;
        }

        [WebMethod(Description = "Returns all information for circuit elements immediately upstream of the given line section or node (eaLoc).")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public MultiSpeak GetParentConnectivity(string eaLoc)
        {
            return null;
        }

        [WebMethod(Description = "Returns all information for all elements in the connectivity model. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public MultiSpeak GetAllConnectivity(string lastReceived)
        {
            return null;
        }

        [WebMethod(Description = "Returns circuit elements that have been modified since the time of a specifed sessionID. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public MultiSpeak GetModifiedConnectivity(string previousSessionID, string lastReceived)
        {
            return null;
        }


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

