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
    /// 
    /// Summary description for Web Services Hosted by Connect/Disconnect(CD)
    /// </summary>
    /// 
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class CD_Server : System.Web.Services.WebService
	{
		public CD_Server()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

        public MultiSpeakMsgHeader MultiSpeakMsgHeader;

	#region Generic for each function	

       [WebMethod(Description="Requester Pings URL of CD to see if it is alive.   Returns errorObject(s) as necessary to communicate application status.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
       public errorObject[] PingURL() {
           return null;
       }

       [WebMethod(Description="Requester requests list of methods supported by CD.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
       public string[] GetMethods() {
           return null;
       }

       [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.  It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema. ")]
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

	#region Methods to Get Data

        [WebMethod(Description = "Returns all meters that have Connect/Disconnect Capability. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public meters GetCDSupportedMeters(string lastReceived) {
            return null;
        }

        [WebMethod(Description = "Returns all meters that have Connect/Disconnect Capability and that have been modified since the last identified session.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public meters GetModifiedCDMeters(string previousSessionID, string lastReceived) 
		{
			return null;
		}

        [WebMethod(Description="Returns current state of a connect/disconnect device for a given meterID.  The default condition is Closed.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public CDState GetCDMeterState(meterID meterID)
        {
            return null; // Closed is the default condition.

        }

    #endregion

    #region Methods to Initiate Actions On the CD System

        [WebMethod(Description = "CB initiates a connect or disconnect action by issuing one or more connectDisconnectEvent objects to the CD.  CD returns information about failed transactions by returning an array of errorObjects.  The connect/disconnect function returns infromation about this action using the CDStateChangedNotification to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateConnectDisconnect(connectDisconnectEvent[] cdEvents, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "CB initiates a switch status check directly from one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD switch state check function returns information asynchronously about this switch state using either the CDStateNotification (for only one device) or the CDStatesNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateCDStateRequest(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "CB initiates arming of one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD function returns information asynchronously about this switch action using either the CDStateChangedNotification (for only one device) or the CDStatesChangedNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response. ***THIS METHOD HAS BEEN DEPRECATED IN VERSION 4.1 AND WILL BE REMOVED IN VERSION 4.2.  IT IS SUGGESTED THAT IMPLEMENTERS USE InitiateConnectDisconnect USING THE loadActionCode OF ‘Arm’ INSTEAD OF THIS METHOD. ***")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateArmCDDevice(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }


        [WebMethod(Description = "CB initiates enabling of one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD function returns information asynchronously about this switch action using either the CDStateChangedNotification (for only one device) or the CDStatesChangedNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.  The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateEnableCDDevice(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "CB initiates disabling of one or more Connect/Disconnect devices. CD returns information about failed transactions by returning an array of errorObjects.  The CD function returns information asynchronously about this switch action using either the CDStateChangedNotification (for only one device) or the CDStatesChangedNotification (for one or more devices) to the URL specified in the responseURL calling parameter and references the transactionID specified to link the transaction to this Initiate request.The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateDisableCDDevice(CDState[] states, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

	#endregion

	#region Methods for Publishers to publish Event Notifications to CD(The subscriber)

        [WebMethod(Description = "Publisher Notifies CD of a change in the Customer object by sending the changed customer object(s).  CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
       public errorObject[] CustomerChangedNotification(customer[] changedCustomers) 
	   {
			return null;    
       }

        [WebMethod(Description = "Publisher Notifies CD of a change in customer account(s) by sending the changed account object(s).  CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
       public errorObject[] AccountChangedNotification(account[] changedAccounts)
       {
           return null;
       }

       [WebMethod(Description = "Publisher notifies subscriber of a change in the service location by sending the changed serviceLocation object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
       public errorObject[] ServiceLocationChangedNotification(serviceLocation[] changedServiceLocations) 
	   {
			return null;    
       }

        [WebMethod(Description = "Publisher Notifies CD of a change in the Meter object by sending the changed meter object(s).  CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
       public errorObject[] MeterChangedNotification(meters changedMeters) 
	   {
			return null;    
       }
        [WebMethod(Description = "Publisher notifies CD to add the associated connect/disconnect device(s). CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
       public errorObject[] CDDeviceAddNotification(CDDevice[] addedCDDs)
       {
           return null;
       }
        [WebMethod(Description = "Publisher notifies CD of a change in connect/disconnect device(s).  CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
       public errorObject[] CDDeviceChangedNotification(CDDevice[] changedCDDs)
       {
           return null;
       }
        [WebMethod(Description = "Publisher notifies CD that connect/disconnect device(s) have been deployed or exchanged.  CD returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
       public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
       {
           return null;
       }
        [WebMethod(Description = "Publisher notifies CD to remove the associated connect/disconnect device(s).  CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
       public errorObject[] CDDeviceRemoveNotification(CDDevice[] removedCDDs)
       {
           return null;
       }

        [WebMethod(Description = "Publisher notifies CD that the associated connect/disconnect devices(s)have been retired from the system.  CD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
       [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
       public errorObject[] CDDeviceRetireNotification(CDDevice[] retiredCDDs)
       {
           return null;
       }
       #endregion

       #region Methods New in Version 4.1.5
        /// 
        /// Begin Methods New in Version 4.1.5
        /// 

        [WebMethod(Description = "This method permits the Requester to request of the connect/disconnect system whether or not the service is equipped with remote connection/disconnection capability.  If no RCD switch exists at a service then remote disconnection/reconnection of the service will not be possible until the RCD switch is installed. In this sense, 'Supported' means both that the meter is capable of being disconnected (whether that capability is inherent in the meter or is provided in a separate disconnect collar) and that the disconnection/reconnection capability is enabled.  If BOTH of these conditions are true then the CD SHALL return 'True'.  If EITHER of these conditions is not true then the CD_Server SHALL return 'False'. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public bool IsCDSupported(ppmLocation location)
        {
            return false;
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

