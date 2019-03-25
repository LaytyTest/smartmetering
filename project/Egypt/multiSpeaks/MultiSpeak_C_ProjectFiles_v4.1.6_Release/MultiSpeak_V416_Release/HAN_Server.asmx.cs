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
    /// Summary description for Web Services Hosted by Han Communications(HAN). 
    /// </summary> 
    ///  
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]

    public class HAN_Server : System.Web.Services.WebService
    {

        public MultiSpeakMsgHeader MultiSpeakMsgHeader;


        public HAN_Server()
        {

        }

        #region Generic for each interface

        [WebMethod(Description = "Requester pings URL of server to see if it is alive. Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PingURL()
        {
            return null;
        }

        [WebMethod(Description = "Requester requests list of methods supported by server.")]
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

        #region Methods for Getting Data from the HAN system

        [WebMethod(Description = "Returns all in home display objects. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public inHomeDisplay[] GetAllInHomeDisplays(string lastReceived)
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

		
		[WebMethod(Description = "Requester asks HAN server to initiate and manage the request for the registration statuses of one or more HAN devices. The HAN function publishes the registration status of the devices asynchronously using a HANRegistrationNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHANRegistrationStatusRequest(registrationStatus[] registrationStatuses, string responseURL, string transactionID)
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

        #endregion

        #region Methods for Modification of HAN data by external system



        #endregion


        #region Methods for  Publisher to publish Event Notification to HAN(The subscriber)

        [WebMethod(Description = "Publisher notifies subscriber to add the associated in-home display(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayAddNotification(inHomeDisplay[] addedIHDs, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in the in-home display(s)by sending the changed inHomeDisplay object.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayChangedNotification(inHomeDisplay[] changedIHDs)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies subscriber that in-home displays(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayExchangeNotification(inHomeDisplayExchange[] IHDChangeout)
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


        [WebMethod(Description = "Requester establishes a new in-home display group on the server.  The server returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] EstablishIHDGroup(inHomeDisplayGroup IHDGroup)
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
		

		[WebMethod(Description = "The Requester requests from the server the members of a specific in home display group, identified by the IHDGroupName parameter.  This method is used, along with the GetIHDGroupNames method to enable the requester to get information about which meters are included in a specific in home display group.  The server returns an inHomeDisplayGroup in response to this method call.  ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public inHomeDisplayGroup GetIHDGroupMembers(string IHDGroupName)
		{
			return null;
		}
		
		[WebMethod(Description = "The Requester requests from the server a list of names of in home display groups for a specific inHomeDisplay.  The server returns an array of strings including the names of the supported inHomeDisplayGroups.  The Requester can then request the members of a specific group using the GetIHDGroupMembers method. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
		public string[] GetIHDGroupNamesByInHomeDisplayID(string inHomeDisplayID)
		{
			return null;
		}

        [WebMethod(Description = "This command permits the commissioning of a new HAN in preparation of registering HANDevices. The result of the command is returned to the URL specified in the responseURL parameter using the asynchronous HANCommissionNotification, which is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateHANCommissioning(HANInterfaceID interfaceID, string type, duration timeout, string transactionID, string responseURL)
        {
            return null;
        }


        [WebMethod(Description = "Publisher requests subscriber to add in home display(s) to an existing group of in home displays to address as a group.  Subscriber returns information about failed transaction using an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InsertInHomeDisplayInIHDGroup(string[] inHomeDisplayIDs, string IHDGroupID)
        {
            return null;
        }
		
		[WebMethod(Description = "Publisher notifies DR to add the associated load mangement device(s). DR returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

        [WebMethod(Description = "Publisher requests subscriber to remove in home display(s) from an existing group of in home displays to address as a group.  Subscriber returns information about failed transaction using an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RemoveInHomeDisplayFromIHDGroup(string[] inHomeDisplays, string IHDGroupID)
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

        
		
        #endregion

        #region Methods added as  part of Version 4.1.5

        ///
        /// New methods in Version 4.1.5
        ///

        [WebMethod(Description = "Publisher notifies subscriber of a change in the service location by sending the changed serviceLocation object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ServiceLocationChangedNotification(serviceLocation[] changedServiceLocations)
        {
            return null;
        }

        [WebMethod(Description = "The Publisher notifies the subscriber of changes in the details of a rate tariff.  This method is intended to send updates to a previously established rate (e.g., 'change the cost of energy from $0.065/kWh to be $0.08/kWh'). It SHALL NOT be used to change the rate code in effect at a service location (e.g., 'change the effective tariff from rate code 10 to rate code 11'); that shall be done using a ServiceLocationChangedNotification.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] RateChangedNotification(rate rateInfo, string transactionID)
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


        ///
        /// End of New Methods in Version 4.1.5
        ///
        #endregion

    }
}

