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
    /// Summary description for Web Services Hosted by Distribution Automation (DA). 
    /// </summary> 
    ///  

    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class DA_Server : System.Web.Services.WebService
    {

        public MultiSpeakMsgHeader MultiSpeakMsgHeader;

        public DA_Server()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
        }

        #region Generic for each function

        [WebMethod(Description = "Requester Pings URL of DA to see if it is alive.   Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PingURL()
        {
            return null;
        }

        [WebMethod(Description = "Requester requests list of methods supported by CD.")]
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

        #region Methods to Get Data
        [WebMethod(Description = "Returns all DA Analogs.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaAnalog[] GetAllSCADAAnalogs(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns a specific DA Analog by SCADAPointID. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaAnalog GetSCADAAnalogBySCADAPointID(string scadaPointID)
            {
                return null;
            }


            [WebMethod(Description = "Returns all DA Status data. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaStatus[] GetAllSCADAStatus(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns a specific DA Status by SCADAPointID. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaStatus GetSCADAStatusBySCADAPointID(string scadaPointID)
            {
                return null;
            }


            [WebMethod(Description = "Returns a list of DA Point definitions. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaPoint[] GetAllSCADAPoints(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns a list of DA Point definitions that has changed since the session identified by the sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaPoint[] GetModifiedSCADAPoints(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns history records for a specific SCADA Analog by SCADAPointID within a range of times.  If the server cannot provide the data at the requested sample rate, it should provide what it has.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaAnalog[] GetSCADAAnalogsByDateRangeAndPointID(string scadaPointID, System.DateTime startTime, System.DateTime endTime, sampleRate sRate, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns history records for a specific SCADA Status by SCADAPointID within a range of times.  If the server cannot provide the data at the requested sample rate, it should provide what it has.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaStatus[] GetSCADAStatusesByDateRangeAndPointID(string scadaPointID, System.DateTime startTime, System.DateTime endTime, sampleRate sRate, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns history records for a all SCADA Status points within a range of times.  If the server cannot provide the data at the requested sample rate, it should provide what it has.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public scadaStatus[] GetSCADAStatusesByDateRange(System.DateTime startTime, System.DateTime endTime, sampleRate sRate, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns history records for a specific SCADA Analog by SCADAPointID within a range of times.  The data are returned in one or more formattedBlocks.  If the server cannot provide the data at the requested sample rate, it should provide what it has.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public formattedBlock[] GetSCADAAnalogsByDateRangeAndPointIDFormattedBlock(string scadaPointID, System.DateTime startTime, System.DateTime endTime, sampleRate sRate, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns history records for a specific SCADA Status by SCADAPointID within a range of times.  The data are returned in one or more formattedBlocks. If the server cannot provide the data at the requested sample rate, it should provide what it has.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public formattedBlock[] GetSCADAStatusesByDateRangeAndPointIDFormattedBlock(string scadaPointID, System.DateTime startTime, System.DateTime endTime, sampleRate sRate, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns history records for a all SCADA Status points within a range of times.  The data are returned in one or more formattedBlocks. If the server cannot provide the data at the requested sample rate, it should provide what it has.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public formattedBlock[] GetSCADAStatusesByDateRangeFormattedBlock(System.DateTime startTime, System.DateTime endTime, sampleRate sRate, string lastReceived)
            {
                return null;
            }

        #endregion

        #region Methods to Initiate Actions On the DA System

            [WebMethod(Description = "Client requests that DA publish the status of DA points, as selected by the array of DA pointIDs.  DA returns information about failed transactions using an array of errorObjects.  Possible errorStrings could include 'Initiate already in progress for this pointID' and 'Remote device unreachable'. The DA status is returned to the client in the form of scadaStatus objects returned in a StatusChangedNotificationByPointID, sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the published data method call. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InitiateStatusReadByPointID(string[] pointIDs, string responseURL, string transactionID, expirationTime expTime)
            {
                return null;
            }
            [WebMethod(Description = "Client requests that DA publish the value of DA analog points, as selected by the array of DA pointIDs.  DA returns information about failed transactions using an array of errorObjects.  Possible errorStrings could include 'Initiate already in progress for this pointID' and 'Remote device unreachable'. The DA analog information is returned to the client in the form of scadaAnalog objects returned in a AnalogChangedNotificationByPointID, sent to the URL specified in the responseURL.  The transactionID calling parameter links this Initiate request with the published data method call. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InitiateAnalogReadByPointID(string[] pointIDs, string responseURL, string transactionID, expirationTime expTime)
            {
                return null;
            }
            [WebMethod(Description = "THIS METHOD IS INCLUDED FOR DISCUSSION ONLY; IT SHOULD NOT BE IMPLEMENTED UNTIL THE TECHNICAL COMMITTEE ACCEPTS THE FORM OF THE METHOD. SCADA requests that DA take a control action on a DA point, as selected by the scadaControl object.  DA returns information about a failed transaction in an errorobject.  Once the action is processed, the DA publishes the fact to the SCADA using a ControlActionCompleted method call.  The transactionID parameter is used to link the InitiateControl and ControlActionCompleted method calls.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InitiateControl(scadaControl controlAction, string responseURL, string transactionID)
            {
                return null;
            }

        #endregion

        #region Methods for Publishers to publish Event Notifications to DA(The subscriber)
        
            [WebMethod(Description = "Client notifies SCADA of a new list of points to which it would like to subscribe. This list replaces any prior lists. The client SHALL provide the RegistrationID under which this subscription is being requested, unless the SCADA server does not support automated registration for services. If automated subscription is supported, the subscriber SHALL include the RegistrationID in the message header for this method. SCADA returns failed transactions by returning an array of errorObjects. Subscriber specifies the URL to which information is to be published by sending the responseURL. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] PointSubscriptionListNotification(pointSubscriptionList pointList, string responseURL, string errorString)
            {
                return null;
            }

			[WebMethod(Description = "Publisher notifies subscriber of changes in analog values by sending an array of changed scadaAnalog objects. subscriber returns failed transactions using an array of errorObjects. The transactionID calling parameter links this published data response with the previously received InitiateAnalogReadByPointID method call. If no points are identified, the server shall return analogs for all analog points. ")] 
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] AnalogChangedNotificationByPointID(scadaAnalog[] scadaAnalogs, string transactionID)
            {
                return null;
            }


			[WebMethod(Description = "Publisher notifies subscriber of changes in point status by sending an array of changed scadaStatus objects. Subscriber returns failed transactions using an array of errorObjects. The transactionID calling parameter links this published data response with the previously received InitiateStatusReadByPointID method call. If no points are identified, the server shall return statuses for all status points. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] StatusChangedNotificationByPointID(scadaStatus[] scadaStatuses, string transactionID)
            {
                return null;
            }


            [WebMethod(Description = "Client notifies DA of changes in analog values by sending an array of changed scadaAnalog objects.  DA returns failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAAnalogChangedNotification(scadaAnalog[] scadaAnalogs)
            {
                return null;
            }

            [WebMethod(Description = "SCADA Notifies DA of changes in point status by sending an array of changed scadaStatus objects.  DA returns failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAStatusChangedNotification(scadaStatus[] scadaStatuses)
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

            [WebMethod(Description = "SCADA Notifies DA of changes in the status of a specific point, chosen by PointID, by sending a changed scadaStatus object.  If this transaction fails, DA returns information about the failure in a SOAPFault. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAStatusChangedNotificationByPointID(scadaStatus scadaStatus)
            {
                return null;
            }

            [WebMethod(Description = "THIS METHOD IS INCLUDED FOR DISCUSSION ONLY; IT SHOULD NOT BE IMPLEMENTED UNTIL THE TECHNICAL COMMITTEE ACCEPTS THE FORM OF THE METHOD. SCADA notifies DA that a previously requested scada control action request has been completed.  DA returns the status of the control action in a modified scadaControl object, containing an updated controlStatus element. The transactionID parameter is used to link the InitiateControl and ControlActionCompleted method calls.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ControlActionCompleted(scadaControl[] controlActions, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of changes in accumulator values by sending an array of changed accumulatedValue objects.  Publisher returns failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] AccumulatedValueChangedNotification(accumulatedValue[] accumulators)
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


