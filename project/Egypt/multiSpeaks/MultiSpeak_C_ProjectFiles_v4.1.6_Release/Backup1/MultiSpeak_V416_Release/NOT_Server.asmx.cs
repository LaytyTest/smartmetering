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
    /// Publish type web services hosted on the notification (NOT) function. 
    /// </summary>
    /// 
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]

    public class NOT_Server : System.Web.Services.WebService
    {
        public MultiSpeakMsgHeader MultiSpeakMsgHeader;

        public NOT_Server()
        {
           
        }



        #region Generic for each interface

        [WebMethod(Description = "Requester pings URL of server to see if it is alive.  Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PingURL()
        {
            return null;
        }

        [WebMethod(Description = "Requester requests list of request-type methods supported by server.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public string[] GetMethods()
        {
            return null;
        }

        [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server. It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called “workOrder.workflowStatus”, using the same spelling and capitalization used in the MultiSpeak schema.")]
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

        #region Methods to publish Event Notification to the NOT Server(The subscriber)

        [WebMethod(Description = "Publisher notifies subscriber of a change in OutageDetectionEvents by sending an array of changed OutageDetectionEvent objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ODEventNotification(outageDetectionEvent[] ODEvents, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in accumulator values by sending an array of changed accumulatedValue objects.  Publisher returns failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AccumulatedValueChangedNotification(accumulatedValue[] accumulators)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in OutageDetectionDevice by sending an array of changed OutageDetectionDevice objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ODDeviceChangedNotification(outageDetectionDevice[] ODDevices)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new or modified surge arrestors by sending an array of surgeArrestor objects. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SurgeArrestorChangedNotification(surgeArrestor[] surgeArrestors)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new power monitor output by sending the new PMChangedNotification.The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PMChangedNotification(powerMonitor[] monitors)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of non-outage events by sending the a customerCall object. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CHEventNotification(customerCall[] chEvent)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in analog values by sending an array of changed scadaAnalog objects.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotification(scadaAnalog[] scadaAnalogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in point status by sending an array of changed scadaStatus objects.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAStatusChangedNotification(scadaStatus[] scadaStatuses)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in SCADA point definitions by sending an array of changed scadaPoint objects.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAPointChangedNotification(scadaPoint[] scadaPoints)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in SCADA point definitions, limited to Analog points, by sending an array of changed scadaPoint objects.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAPointChangedNotificationForAnalog(scadaPoint[] scadaPoints)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in SCADA point definitions, limited to Status points, by sending an array of changed scadaPoint objects.  Subscriber returns failed transactions using an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAPointChangedNotificationForStatus(scadaPoint[] scadaPoints)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in a specific analog value, chosen by scadaPointID, by sending a changed scadaAnalog object.  If this transaction fails, subscriber returns information about the failure in a SOAPFault.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotificationByPointID(scadaAnalog scadaAnalog)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in a specific analog value, limited to power analogs, by sending an arrray of changed scadaAnalog objects.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotificationForPower(scadaAnalog[] scadaAnalogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changed analog values, limited to voltage analogs, by sending an array of changed scadaAnalog objects.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAAnalogChangedNotificationForVoltage(scadaAnalog[] scadaAnalogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of changes in the status of a specific point, chosen by PointID, by sending a changed scadaStatus object.  If this transaction fails, subscriber returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SCADAStatusChangedNotificationByPointID(scadaStatus scadaStatus)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies scriber of changes in connect disconnect event object(s) by sending the changed connectDisconnectEvent object(s).  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

        [WebMethod(Description = "Publisher Notifies subscriber of a change in the Customer object by sending the changed customer object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CustomerChangedNotification(customer[] changedCustomers)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber of a change in customer account(s)by sending the changed account object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

        [WebMethod(Description = "Publisher Notifies subscriber of a change in the Meter object by sending the changed meter object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterChangedNotification(meters changedMeters)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber to remove the associated meter(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterUninstalledNotification IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterRemoveNotification(meters removedMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that the associated meter(s)have been retired from the system. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterRemovedNotification IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterRetireNotification(meters retiredMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to Add the associated meter(s).Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterAddNotification(meters addedMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that meter(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterExchangeNotification(meterExchanges meterChangeout)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new or changed switching order(s) by sending switchingOrder object(s).  Subscriber returns information about failed transactions in an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SwitchingOrderChangedNotification(switchingOrder[] switchingOrders)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of meter event(s) by sending a meterEventList object.  Subscriber returns information about failed transactions in an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterEventNotification(meterEventList events, string transactionID)
        {
            return null;
        }
		
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

        [WebMethod(Description = "Publisher notifies Subscriber of a change in meter readings by sending the changed meterReading objects.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ReadingChangedNotification(meterReading[] changedMeterReads, string transactionID)
        {
            return null;
        }


		[WebMethod(Description = "The HAN Communications server notifies subscriber of the status of a HAN registration request that the subscriber previously issued to the HAN Communications server. The HAN Communications server sends an array of HANRegistration objects. The subscriber returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this published data method call with the InitiateHANRegistration that was issued to request the HAN registration.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HANRegistrationNotification(HANRegistration[] registrations, string transactionID)
		{
			return null;
		} 
		
        [WebMethod(Description = "Publisher notifies subscriber of a change in the History Log by sending the changed historyLog object.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] HistoryLogChangedNotification(historyLog[] changedHistoryLogs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher sends new meter readings to the subscriber by sending a formattedBlock object.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] FormattedBlockNotification(formattedBlock changedMeterReads, string transactionID, string errorString)
        {
            return null;
        }
		
				
		[WebMethod(Description = "Publisher notifies subscriber of the result of a critical peak price event on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateCriticalPeakPriceEvent. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] CriticalPeakPriceEventNotification(criticalPeakPriceEventStatus[] eventHistory, string transactionID)
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
		
				
		[WebMethod(Description = "Publisher notifies subscriber of the result of HAN commissioning for one or more home area networks. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateHANCommissiong. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HANCommissioningNotification(HANCommission[] commissions, string transactionID)
		{
			return null;
		}

        [WebMethod(Description = "Publisher sends new interval meter readings to the subscriber by sending an intervalData  object.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] IntervalDataNotification(intervalData intervalReads, string transactionID, string errorString)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that meter(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterInstalledNotification(meters addedMeters, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that load mangement device(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceExchangeNotification(LMDeviceExchange[] LMDChangeout)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber that load management device(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceInstalledNotification(loadManagementDevice[] installedLMDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of state change(s) for connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateConnectDisconnect call.  If this transaction fails, subscriber returns information about the failure in an array of errorObject(s). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStatesChangedNotification(CDStateChange[] stateChanges, string transactionID)
        {
            return null;
        }


        [WebMethod(Description = "Publisher Notifies subscriber of a change in the LoadProfile object(s) by sending the changed profileObject(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LoadProfileChangedNotification(profileObject[] changedLoadProfiles)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in a pole by sending the changed pole object. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PoleChangedNotification(pole[] changedPoles)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in the service location/network data by sending the changed serviceLocation object.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ServiceLocationNetworkChangedNotification(serviceLocation[] changedServiceLocations)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in a transformerBank by sending the changed transformerBank object.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] TransformerBankChangedNotification(transformerBank[] changedXfmrBanks)
        {
            return null;
        }
        [WebMethod(Description = "Publisher Notifies subscriber of a received end device (meter) shipment by sending the changed endDeviceShipment object.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EndDeviceShipmentNotification(endDeviceShipment shipment)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that in-home display(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayInstalledNotification(inHomeDisplay[] addedIHDs)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber that in-home displays(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayExchangeNotification(inHomeDisplayExchange[] IHDChangeout)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber that connect/disconnect device(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber that connect/disconnect device(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceInstalledNotification(CDDevice[] installedCDDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new or changed assignment(s) by sending the changed assignment object(s).  Subscriber returns information about failed transactions using an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AssignmentNotification(assignment[] assignments, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber of the success or failure of meter reading schedule requests by sending readingScheduleResult objects.  Subscriber returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ReadingScheduleResultNotification(readingScheduleResult[] scheduleResult, string transactionID, string errorString)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to add the associated connect/disconnect device(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceAddNotification(CDDevice[] addedCDDs)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber of a change in connect/disconnect device(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceChangedNotification(CDDevice[] changedCDDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to remove the associated connect/disconnect device(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceRemoveNotification(CDDevice[] removedCDDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that the associated connect/disconnect devices(s)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceRetireNotification(CDDevice[] retiredCDDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber of new call back list(s) by sending the new call back lists.  Subscriber returns status of failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CallBackListNotification(callBackList[] newCallBackLists)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber of new outages by sending the new lists of CustomersAffectedByOutage.  Subscriber returns status of failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CustomersAffectedByOutageNotification(customersAffectedByOutage[] newOutages)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber of the list of power monitor events that have been acknowledged.  Publisher sends an array of powerMonitor objects, subscriber returns failed transactions in an array of errorObjects.The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PMAcknowledgement(powerMonitor[] newPMAcks)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in a work order by sending the changed workOrder object, including assemblies, CPRs and pick list.  Subscriber returns information about failed transactions using an aray of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] WorkOrderChangedNotification(workOrder[] changedWorkOrders)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in material management assemblies by sending the changed materialManagementAssembly object.  Subscriber returns information about failed transactions using an aray of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MaterialManagementAssemblyNotification(materialManagementAssembly[] changedMMAssemblies)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in material items by sending the changed materialItem object.  Subscriber returns information about failed transactions using an aray of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MaterialItemChangedNotification(materialItem[] changedMaterialItems)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to add the associated load mangement device(s). ubscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceAddNotification(loadManagementDevice[] addedLMDs, string transactionID)
        {
            return null;
        }
		
        [WebMethod(Description = "Publisher notifies subscriber of a change in load mangement device(s)by sending the changed loadManagementDevice object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceChangedNotification(loadManagementDevice[] changedLMDs, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to remove the associated load mangement device(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceRemoveNotification(loadManagementDevice[] removedLMDs, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that the associated load mangement devices(s)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LMDeviceRetireNotification(loadManagementDevice[] retiredLMDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in circuit elements by sending a changed MultiSpeak object.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CircuitElementChangedNotification(MultiSpeak circuitElements)
        {
            return null;
        }

        [WebMethod(Description = "Publisher Notifies subscriber of a change in connectivity by sending a changed MultiSpeak object.  Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ConnectivityChangedNotification(MultiSpeak connectivity)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in designed work orders by sending the changed workOrder object, including assemblies, CPRs and pick list. Subscriber returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DesignedWorkOrderNotification(workOrder[] designedWorkOrders)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in labor categories by sending the changed laborCategory objects.  Subscriber returns information about failed transactions using an aray of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] LaborCategoryNotification(laborCategory[] changedLaborCategories)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in usage object(s) by sending the changed usage object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UsageChangedNotification(usage[] changedUsages)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new AVL events by sending an AVLMessage object.  Subscriber returns information on failed transactions by returrning an array of errorObjects. The transactionID calling parameter links this published data method call with the original Initate request (if any). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AVLChangedNotification(AVLMessage events, string transactionID, string errorString)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in streetLight object(s) by sending the changed street light object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] StreetLightChangedNotification(streetLight[] changedStreetLights)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies GIS of a change in securityLight object(s) by sending the changed security light object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SecurityLightChangedNotification(securityLight[] changedSecurityLights)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies GIS of a change in trafficLight object(s) by sending the changed traffic light object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] TrafficLightChangedNotification(trafficLight[] changedTrafficLights)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in GIS features by sending a changed MultiSpeak object.  Subscriber returns failed transactions in an array of errorObjects.The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] GISFeatureChangedNotification(MultiSpeak changedFeatures)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies Subscriber of a change in sets of spatially connected features by sending changed spatialFeatureGroup objects. Subscriber returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] SpatialFeatureGroupChangedNotification(spatialFeatureGroup[] changedSpatialFeatureGroups)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in OutageEvent by sending an array of changed OutageEvent objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] OutageEventChangedNotification(outageEvent[] oEvents)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in the in-home display(s)by sending the changed inHomeDisplay object.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayChangedNotification(inHomeDisplay[] changedIHDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to remove the associated in-home displays(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayRemoveNotification(inHomeDisplay[] removedIHDs, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that the associated in-home display(s)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayRetireNotification(inHomeDisplay[] retiredIHDs)
        {
            return null;
        }

		[WebMethod(Description = "Publisher notifies subscriber that messages should be shown on the associated in-home display. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. THE USE OF THIS METHOD HAS BEEN DEPRECATED AS OF V4.1.4; ITS USE WILL BE REPLACED WITH THE InitiateInHomeDisplayMessage AS OF V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayMessageNotification(inHomeDisplayMessage message)
        {
            return null;
        }

							
		[WebMethod(Description = "Publisher notifies requester of the current rate structure associated with a HAN. This method call is the asynchronous reply to InitiateHANPricingRequest method that was sent earlier. The InitiateHANPricingRequest method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public errorObject[] HANPricingNotification (priceTierStructure priceTierStructure, HANInterfaceID interfaceID, string transactionID)
		{
			return null;
		}


        [WebMethod(Description = "Publisher notifies subscriber of changes in the established capability settings for the associated IHD. This method call is the asynchronous reply to InitiateIHDCapabilitySettings method that was sent earlier. The InitiateIHDCapabilitySettings method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] IHDCapabilitySettingsNotification(HANDeviceID inHomeDisplayID, string transactionID, HANInterfaceID interfaceID)
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


        [WebMethod(Description = "Publisher notifies subscriber that billing messages should be shown on the associated in-home display.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.  THIS MESSAGE HAS BEEN DEPRECATED IN VERSION 4.1.5, IT WILL BE REPLACED IN VERSION 4.2 WITH THE InitiateInHomeDisplayBillingMessage METHOD, WHICH WAS ADED IN VERSION 4.1.5. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayBillingMessageNotification(inHomeDisplayBillingMessage message)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that assessments have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AssessmentChangedNotification(assessment[] assessments)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that assessmentLocations have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AssessmentLocationChangedNotification(assessmentLocation[] locations)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of the modified connectivity of meters after a switching event used to restore load during outage situations.  Subscriber returns status of failed tranactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterConnectivityNotification(meterConnectivity[] newConnectivity)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber to add the associated in-home display(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayAddNotification(inHomeDisplay[] addedIHDs, string transactionID)
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


        [WebMethod(Description = "Requests that subscriber process a set of meter exchnages. Subscriber returns information about failed transactions in the form of an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PPMMeterExchangeNotification(meterExchanges changeouts)
        {
            return null;
        }

        [WebMethod(Description = "Notifies the subscriber that changes have occurred in chargeable devices. Subscriber returns information about failed transactions in the form of an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ChargeableDeviceChangedNotification(chargeableDeviceList[] deviceList)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies the subscriber of work tasks to be scheduled.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] TaskListNotification(workTask[] tasks, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber that a work or service order number has been generated in response to a previous InitiateWorkRequest on the part of the WTO. Subscriber returns failed transactions using an errorObject. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] NumberCreatedNotification(requestedNumber requestedNum, string transactionID, string errorString)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of new or changed group assignment(s) by sending the changed groupAssignment object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] GroupAssignmentNotification(groupAssignment[] assignments, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of revocation of assignment(s) by sending the unassignment object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UnassignmentNotification(unassignment[] unassignments, string transactionID)
        {
            return null;
        }

        
        [WebMethod(Description = "Publisher notifies subscriber of new or changed project(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. The transactionID calling parameter links this Notification request with the UpdateProject method call that requested the change.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ProjectChangedNotification(project[] projects, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in work orders by sending the changed workOrder objects.  Subscriber returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] WorkOrderChangedNotificationToGIS(workOrder[] changedWOs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of state of a connect/disconnect device.  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, subscriber returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStateNotification(CDState state, string transactionID)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber of state of connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, subscriber returns information about the failure in an array of errorObject(s). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStatesNotification(CDState[] states, string transactionID)
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

        [WebMethod(Description = "Publisher notifies subscriber that meterBase(es) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterBaseExchangeNotification(meterBaseExchange[] MBChangeout)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a completion of tests on electric meters by sending an array of testedElectricMeters.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterTestNotification(testedElectricMeter[] tests, string transactionID)
        {
            return null;
        }
		
        [WebMethod(Description = "The Inspection server publishes new or changed inspections to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this published data method call with the InitiateInspectionRequest that resulted in this collected inspection data. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InspectionNotification(inspection[] inspections, string transactionID)
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

        [WebMethod(Description = "Publisher notifies subscriber that blink alarms have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] BlinkAlarmNotification(blinkAlarm[] alarms)
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

		
        [WebMethod(Description = "Publisher notifies subscriber that voltage alarms have been published or updated.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] VoltageAlarmNotification(voltageAlarm[] alarms)
        {
            return null;
        }
		
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

        [WebMethod(Description = "This method will be published to notify subscribers that the status of a capacitor switch has changed, either in response to an InitiatePowerFactorEvent, or as a result of a capacitor switch failure. Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Notification with the corresponding InitiatePowerFactorManagementEvent, if any. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PowerFactorManagementEventNotification(string switchID, capacitorSwitchStatus capacitorSwitchStatus, meterEvent[] endDeviceEvents, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies the server that significant usage has been detected on meters that were previously placed into usage monitoring mode using a call to the InitiateUsageMonitoring method on the Publisher.  The array of meterID can be used to pass the list of meters for which excessive usage has been detected.  The array of meterReading can be used to pass the meter readings on those meters at the time that the excessive usage was detected.  The meterReading.meterID element MUST be populated on the meterReading object for this use case so that the readings can be linked to the meter identifiers (meterIDs) if more than one meterID has been included in this notification.  The transactionID is included to link this notification to the previous InitiateUsageMonitoring method call.  Server returns information about failed transactions using an array of errorObjects.  In Version 4.2, this method shall be modified to include a usageMonitoringInstance object that will inherently link the meterID and the associated meter reading, but such a change cannot be made at this time since it would be a breaking change in Version 4.1.x.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] UsageMonitoringNotification(meterID[] meters, meterReading[] readings, string transactionID)
        {
            return null;
        }

		
        [WebMethod(Description = "Publisher notifies subscriber that attachments should be added to an existing workOrder, design, or station. A work order may be referred to using: (i) the workOrderID (objectID of a workOrder), (ii) the combiination of work order number and job number, or (iii) an object reference.  A design or station is referred to using an object reference. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AddAttachmentToWorkOrder(attachment[] attachments, string woNumber, string jobNumber, string workOrderID, objectRef reference)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber that attachments (specified by attachmentID)should be deleted from an existing workOrder, design or station. A work order may be referred to using: (i) the workOrderID (objectID of a workOrder), (ii) the combiination of work order number and job number, or (iii) an object reference.  A design or station is referred to using an object reference. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DeleteAttachmentFromWorkOrder(string[] attachmentIDs, string woNumber, string jobNumber, string workOrderID, objectRef reference)
        {
            return null;
        }

        #endregion

        #region Methods added as  part of Version 4.1.5
        ///
        /// New methods in Version 4.1.5
        ///

        [WebMethod(Description = "Publisher notifies Subscriber of metering thresholds that have been reached.  The ThresholdEventNotification is sent in response to a previously sent InitiateThresholdMonitoing call.  The transactionID in this message should match the transactionID from that Initiate call. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThresholdEventNotification(thresholdMonitoringList thresholds, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "The Publisher notifies the subscriber that the MR system has prepared to begin reading meters that previously had been exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. This method SHALL be linked with the previously received InitiateMeterExchange method using the same transactionID that was sent in the prior InitiateMeterExchange method. The payload includes a meterExchanges object that can carry arrays of all possible types of meters (electricMeter, gas,Meter, waterMeter, propaneMeter and otherMeter), thus this one method can be used to handle different meter types.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterExchangedNotification(meterExchanges exchanges, string transactionID)
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

        [WebMethod(Description = "The publisher notifies the subscriber of the addition of a new DR Program.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DRProgramAddNotification(DRProgram[] programs)
        {
            return null;
        }

        [WebMethod(Description = "The publisher notifies the subscriber of changes in the characteristics of an existing DR Program.  Such changes could include the change in the ending effective date of the program. Also, an acceptable use of this message would be to change the status of an existing DR program.  Possible statuses include “Active”, “Suspended”, “Rescinded”, “Other”, and “Unknown”.  It is assumed that a customer could still enroll in a DR program in “Suspended” status, but that no load control/pricing signals will be issued until the program is placed into “Active” status.  This message SHALL NOT be used to change the status of a DR program to be “Rescinded”; that shall be done using the DRProgramRescindedNotification.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DRProgramChangedNotification(DRProgram[] programs)
        {
            return null;
        }


        [WebMethod(Description = "The publisher notifies the subscriber that an existing DR Program has been rescinded.  No new customers can be enrolled in a DR Program that has been rescinded, however, customers that are currently enrolled in the program will be permitted to continue until the ending effective date of the program.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DRProgramRescindedNotification(DRProgram[] programs)
        {
            return null;
        }

        [WebMethod(Description = "The DR program enrollment agent (publisher) notifies subscribers of customers who have subscribed to an existing DR Program.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DRProgramEnrollmentNotification(DRProgramEnrollment[] enrollments)
        {
            return null;
        }

        [WebMethod(Description = "The DR program enrollment agent (publisher) notifies subscribers of customers who have ended their enrollment in an existing DR Program. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] DRProgramUnenrollmentNotification(DRProgramEnrollment[] enrollments)
        {
            return null;
        }



        ///
        /// End of New Methods in Version 4.1.5
        ///

        #endregion

    }
}

	
