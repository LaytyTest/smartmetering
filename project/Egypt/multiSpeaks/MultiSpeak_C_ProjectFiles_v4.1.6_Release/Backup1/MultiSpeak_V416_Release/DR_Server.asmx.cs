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
	/// Summary description for Web Services Hosted by Demand Response(DR).  
	/// 
    /// Dated October 15, 2011
    /// 
	/// xxChangedNotification Services implement Publish/Subscribe functionality by hosting a service 
	/// on the subscriber to be called by the publisher.
	/// 
	/// </summary>
	/// 
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class DR_Server : System.Web.Services.WebService
	{
		public DR_Server()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

        public MultiSpeakMsgHeader MultiSpeakMsgHeader;

		#region Generic for each interface

			[WebMethod(Description="Requester pings URL of DR to see if it is alive.  Returns errorObject(s) as necessary to communicate application status.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] PingURL() 
			{
				return null;
			}

			[WebMethod(Description="Requester requests list of methods supported by DR.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetMethods() 
			{
				return null;
			}

            [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server. It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetDomainNames() 
			{
				return null;
			}

            [WebMethod(Description = "Requester requests the status of capacitor bank switches specified by switchIDs.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public capacitorBankSwitches GetCapBankSwitchStatusesBySwitchIDs(string [] switchIDs)
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

		#region Methods for Getting Data from the DR system

            [WebMethod(Description = "Returns all required data for all loadManagementDevices.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public loadManagementDevice[] GetAllLoadManagementDevices(string lastReceived)
			{
				return null;
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

            [WebMethod(Description = "Returns all of the substation load control statuses")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public substationLoadControlStatus[] GetAllSubstationLoadControlStatuses()
            {
                return null;
            }

            #endregion

            #region Methods for Intiating Action on Demand Response (DR)
	
	    	[WebMethod(Description = "Requester requests that subscriber cancel a critical peak price event on a HAN. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] CancelCriticalPeakPriceEvent (criticalPeakPriceEvent criticalPeakPriceEvent, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID, string responseURL)
			{
				return null;
			}
			

			[WebMethod(Description = "Requester requests that subscriber cancel a critical peak price event on a HAN group. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] CancelCriticalPeakPriceEventToGroup(criticalPeakPriceEvent criticalPeakPriceEvent, HANGroupID groupID, string transactionID, string responseURL)
			{
				return null;
			}
				
			[WebMethod(Description = "Requester requests that subscriber cancel a DR event on a HAN.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] CancelDemandResponseEvent (demandResponseEvent demandResponseEvent, HANInterfaceID interfaceID, string transactionID, string responseURL)
			{
				return null;
			}
			
			[WebMethod(Description = "Requester requests that subscriber cancel a DR event on a HANGroup, where the eventID is the identifier for a previously sent demandResponseEvent. The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] CancelDemandResponseEventToGroup (string eventID, HANGroupID groupID, string transactionID, string responseURL)
			{
				return null;
			}
			
			[WebMethod(Description = "Requester requests that subscriber intiate a critical peak price event on a HAN. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] InitiateCriticalPeakPriceEvent (criticalPeakPriceEvent criticalPeakPriceEvent, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID, string responseURL)
			{
				return null;
			}

			[WebMethod(Description = "Requester requests that subscriber intiate a critical peak price event on a HAN group. The asynchronous return is a CriticalPeakPriceEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] InitiateCriticalPeakPriceEventToGroup (criticalPeakPriceEvent criticalPeakPriceEvent, HANGroupID groupID, string transactionID, string responseURL)
			{
				return null;
			}
		
			[WebMethod(Description = "Requester requests that subscriber return the status of a specific DR event from a HANGroup. Each device in the HAN should send the event status in at a random time within the specified dither interval. If the dither interval is not specified then the DR server should use a suitable default.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] InitiateDemandResponseEventStatusRequestToGroup (string eventID, HANGroupID groupID, duration dither, string transactionID, string responseURL)
			{
				return null;
			}

				
			[WebMethod(Description = "Requester requests that subscriber intiate a DR event on a HAN.The asynchronous return is a DemandResponseEventNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] InitiateDemandResponseEvent (demandResponseEvent demandResponseEvent, HANInterfaceID interfaceID, string transactionID, string responseURL)
			{
				return null;
			}
	
			[WebMethod(Description = "Requester requests that subscriber prepare a HAN device to respond to subsequent DR events. The asynchronous return is a DemandResponseSetupNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] InitiateDemandResponseSetup (demandResponseParameters drParameters, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID, string responseURL)
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

            #endregion

		#region Methods for Event Notification to DR (The subscriber)

            [WebMethod(Description = "Publisher notifies DR of a change in the Customer object(s) by sending the changed customer object(s).  DR returns information about failed transactions by returning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] CustomerChangedNotification(customer[] changedCustomers) 
			{
	           return null;
			}

            [WebMethod(Description = "Publisher notifies subscriber of a change in the service location by sending the changed serviceLocation object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ServiceLocationChangedNotification(serviceLocation[] changedServiceLocations)
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

            [WebMethod(Description = "Publisher notifies MR of a change in the meter object by sending the changed meter object.  MR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterChangedNotification(meters changedMeters)
            {
                return null;
            }

            
            [WebMethod(Description = "Publisher notifies DR of changes in analog values by sending an array of changed scadaAnalog objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAAnalogChangedNotification(scadaAnalog[] scadaAnalogs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in point status by sending an array of changed scadaStatus objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAStatusChangedNotification(scadaStatus[] scadaStatuses)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in SCADA point definitions by sending an array of changed scadaPoint objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAPointChangedNotification(scadaPoint[] scadaPoints)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in SCADA point definitions, limited to Analog points, by sending an array of changed scadaPoint objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAPointChangedNotificationForAnalog(scadaPoint[] scadaPoints)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in SCADA point definitions, limited to Status points, by sending an array of changed scadaPoint objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAPointChangedNotificationForStatus(scadaPoint[] scadaPoints)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in a specific analog value, chosen by scadaPointID, by sending a changed scadaAnalog object.  If this transaction fails, DR returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAAnalogChangedNotificationByPointID(scadaAnalog scadaAnalog)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in a specific analog value, limited to power analogs, by sending an arrray of changed scadaAnalog objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAAnalogChangedNotificationForPower(scadaAnalog[] scadaAnalogs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changed analog values, limited to voltage analogs, by sending an array of changed scadaAnalog objects.  DR returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SCADAAnalogChangedNotificationForVoltage(scadaAnalog[] scadaAnalogs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies DR of changes in the status of a specific point, chosen by PointID, by sending a changed scadaStatus object.  If this transaction fails, DR returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

			[WebMethod(Description = "Requester deletes an existing HAN device group on the server. The server returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] DeleteHANDeviceGroup(HANGroupID groupID)
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

		    [WebMethod(Description = "The Requester requests from the server a list of names of in home display groups.  The server returns an array of strings including the names of the supported inHomeDisplayGroups.  The requester can then request the members of a specific group using the GetIHDGroupMembers method. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetIHDGroupNames()
            {
                return null;
            }
            [WebMethod(Description = "The Requester requests from the server the members of a specific in home display group, identified by the IHDGroupName parameter.  This method is used, along with the GetIHDGroupNames method to enable the requester to get information about which meters are included in a specific in home display group.  The server returns an inHomeDisplayGroup in response to this method call.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public inHomeDisplayGroup GetIHDGroupMembers(string IHDGroupName)
            {
                return null;
            }


        #endregion
        
        #region Methods New in Version 4.1.5

            /// 
            /// Begin Methods New in Version 4.1.5
            /// 

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
            /// End Methods New to Version 4.1.5
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

