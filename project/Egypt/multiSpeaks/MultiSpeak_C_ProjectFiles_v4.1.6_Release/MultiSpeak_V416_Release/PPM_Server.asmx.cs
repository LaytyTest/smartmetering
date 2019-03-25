using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;


namespace MultiSpeak4
{

    /// <summary>
    /// MultiSpeak Version 4.1.6 Web Services Definitions AM.
    /// Dated August 31, 2012
    /// Summary description for Web Services Hosted by PrePaid Metering(PPM). 
    /// </summary> 
    ///  
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class PPM_Server : System.Web.Services.WebService
    {

        public PPM_Server()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }
        public MultiSpeakMsgHeader MultiSpeakMsgHeader;

      #region Generic for each interface

        [WebMethod(Description = "Requester pings URL of PPM to see if it is alive. Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PingURL()
        {
            return null;
        }

        [WebMethod(Description = "Requests list of methods supported by PPM.")]
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

        #region Methods to Get information from the PPM

        [WebMethod(Description = "Returns all in home display objects. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public inHomeDisplay[] GetAllInHomeDisplays(string lastReceived)
        {
            return null;
        }


        #endregion

        #region Methods to publish Event Notification to PPM(The subscriber)

        [WebMethod(Description = "Publisher notifies PPM of a change in the Customer object by sending the changed customer object. PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
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

        [WebMethod(Description = "Publisher notifies PPM of a change in the Meter object by sending the changed meter object.  PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterChangedNotification(meters changedMeters)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies PPM to remove the associated Meter(s).PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterUninstalledNotification IN V4.2.")]
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
		
        [WebMethod(Description = "Publisher notifies PPM to add the associated meter(s).PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

        [WebMethod(Description = "Requests that PPM process a set of payment transactions accepted on the CB.  PPM returns information about the net payment to the CB to be used in accordance with its business rules.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public paymentTransactionList CommitPaymentTransaction(paymentTransactionList transactions)
        {
            return null;
        }

        [WebMethod(Description = "Requests that Receiver process a set of balance adjustment transactions. Receiver returns information about failed transactions in the form of an array of errorObjects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] AdjustPPMBalance(ppmBalanceAdjustment[] adjustments)
        {
            return null;
        }


        [WebMethod(Description = "Requests that PPM return status information about a set of PPMLocations. PPM returns information in the form of an array of ppmStatus objects.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public ppmStatus[] GetPrePayStatus(string[] ppmLocations)
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
        [WebMethod(Description = "Publisher notifies PPM to add the associated connect/disconnect device(s). PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceAddNotification(CDDevice[] addedCDDs)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies PPM of a change in connect/disconnect device(s).  PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceChangedNotification(CDDevice[] changedCDDs)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies PPM that connect/disconnect device(s) have been deployed or exchanged.  PPM returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
        {
            return null;
        }
        [WebMethod(Description = "Publisher notifies PPM to remove the associated connect/disconnect device(s).  PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceRemoveNotification(CDDevice[] removedCDDs)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies PPM that the associated connect/disconnect devices(s)have been retired from the system.  PPM returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDDeviceRetireNotification(CDDevice[] retiredCDDs)
        {
            return null;
        }

		[WebMethod(Description = "Publisher notifies subscriber that messages should be shown on the associated in-home display. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data. THE USE OF THIS METHOD HAS BEEN DEPRECATED AS OF V4.1.4; ITS USE WILL BE REPLACED WITH THE InitiateInHomeDisplayMessage AS OF V4.2.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayMessageNotification(inHomeDisplayMessage message)
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



        [WebMethod(Description = "Publisher notifies subscriber that billing messages should be shown on the associated in-home display.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.  THIS MESSAGE HAS BEEN DEPRECATED IN VERSION 4.1.5, IT WILL BE REPLACED IN VERSION 4.2 WITH THE InitiateInHomeDisplayBillingMessage METHOD, WHICH WAS ADED IN VERSION 4.1.5. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InHomeDisplayBillingMessageNotification(inHomeDisplayBillingMessage message)
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

    #endregion

    #region Methods New In Version 4.1.5


        ///
        /// New methods in Version 4.1.5
        ///

        [WebMethod(Description = "Publisher notifies Subscriber of metering thresholds that have been reached.  The ThresholdEventNotification is sent in response to a previously sent InitiateThresholdMonitoing call.  The transactionID in this message should match the transactionID from that Initiate call. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ThresholdEventNotification(thresholdMonitoringList thresholds, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies Subscriber of a change in meter readings by sending the changed meterReading objects.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] ReadingChangedNotification(meterReading[] changedMeterReads, string transactionID)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of a change in OutageEvent by sending an array of changed OutageEvent objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] OutageEventChangedNotification(outageEvent[] oEvents)
        {
            return null;
        }

        [WebMethod(Description = "Publisher notifies subscriber of state change(s) for connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateConnectDisconnect call.  If this transaction fails, subscriber returns information about the failure in an array of errorObject(s). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] CDStatesChangedNotification(CDStateChange[] stateChanges, string transactionID)
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

        [WebMethod(Description = "The Publisher notifies the subscriber that the MR system has prepared to begin reading meters that previously had been exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. This method SHALL be linked with the previously received InitiateMeterExchange method using the same transactionID that was sent in the prior InitiateMeterExchange method. The payload includes a meterExchanges object that can carry arrays of all possible types of meters (electricMeter, gas,Meter, waterMeter, propaneMeter and otherMeter), thus this one method can be used to handle different meter types.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterExchangedNotification(meterExchanges exchanges, string transactionID)
        {
            return null;
        }

        ///
        /// End of New Methods in Version 4.1.5
        ///


#endregion
    }
}


