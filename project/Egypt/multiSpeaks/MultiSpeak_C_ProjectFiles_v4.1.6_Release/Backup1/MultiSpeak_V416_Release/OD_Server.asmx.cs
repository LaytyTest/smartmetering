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
	/// Web services hosted by outage detection (OD) acting as server and outage 
	/// analysis (OA) acting as client.
	/// </summary>
	/// 
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class OD_Server : System.Web.Services.WebService
	{
		public OD_Server()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

      public MultiSpeakMsgHeader MultiSpeakMsgHeader;

	#region Generic for each interface

		[WebMethod(Description="Requester pings URL of OD to see if it is alive. Returns errorObject(s) as necessary to communicate application status.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public errorObject[] PingURL() 
		{
			return null;
		}

		[WebMethod(Description="Requester requests list of methods supported by OD.")]
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

        [WebMethod(Description = "Returns all outage detection devices. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetAllOutageDetectionDevices(string lastReceived)
		{
			return null;
		}

		[WebMethod(Description="Returns outage detection devices associated with the given meter.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public outageDetectionDevice[] GetOutageDetectionDevicesByMeterID(meterID meterID)
		{
			return null;
		}
																																																																																																																																							
		[WebMethod(Description="Returns all outage detection devices with a given OutageDetectionDeviceStatus. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutageDetectionDevicesByStatus(outageDetectDeviceStatus oDDStatus, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description="Returns all outage detection devices of a given OutageDetectionDeviceType. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutageDetectionDevicesByType(outageDetectDeviceType oDDType, string lastReceived)
		{
			return null;
		}

		[WebMethod(Description="Returns the outageDetectionDevices that are currently experiencing outage conditions.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public outageDetectionDevice[] GetOutagedODDevices() 
		{
			return null;
		}

	#endregion

	#region Methods to initiate actions on the OD.

        [WebMethod(Description = "Client requests server to update the status of an outageDetectionDevice.  OD responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA-OD) to the URL specified in the responseURL parameter.  OD returns information about failed transactions using an array of errorObjects. The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateOutageDetectionEventRequest(meterID[] meterIDs, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "Client requests server to return only outage detection events that are known to be of type Outage or Inferred on service locations downline from a circuit element supplied using the calling parameters objectName and nounType and containing the phasing supplied in the calling parameter phaseCode. OD responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA-OD)to the URL specified in the responseURL parameter.  OD returns information about failed transactions using an array of errorObjects.The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateODEventRequestByObject(string objectName, string nounType, phaseCode PhaseCode, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

        [WebMethod(Description = "Client requests server to return outage detection events that are known to be of type Outage or Inferred on an array of service locations. Server responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA_Server)to the URL specified in the responseURL parameter.  Server returns information about failed transactions using an array of errorObjects.  The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateODEventRequestByServiceLocation(string[] serviceLocationID, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }
        [WebMethod(Description = "Client requests server to return only outage detection events that are known to be of type Outage or Inferred on service locations downline from a circuit element supplied using the calling parameters objectName and nounType. OD creates a monitoring event for the specified circuit element.  Monitoring shall be performed at the time interval given in the periodicity parameter (expressed in minutes).  OD responds by publishing a revised outageDetectionEvent (using the ODEventNotification method on OA-OD)to the URL specified in the responseURL parameter.  OD returns information about failed transactions using an array of errorObjects.The transactionID calling parameter is included to link a returned ODEventNotification with this request. The expiration time parameter indicates the amount of time for which the publisher should try to obtain and publish the data; if the publisher has been unsuccessful in publishing the data after the expiration time, then the publisher will discard the request and the requestor should not expect a response.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] InitiateODMonitoringRequestByObject(string objectName, string nounType, phaseCode PhaseCode, int periodicity, System.DateTime requestDate, string responseURL, string transactionID, expirationTime expTime)
        {
            return null;
        }

		[WebMethod(Description="Requester requests server to return a list of circuit elements (in the form of objectRefs) that are currently being monitored.  OD returns an array of objectRefs.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public objectRef[] DisplayODMonitoringRequests() 
		{
			return null;   
		}

		[WebMethod(Description="Requester requests server to cancel outage detection monitoring on the list of supplied circuit elements (called out by objectRef).  OD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		public errorObject[] CancelODMonitoringRequestByObject(objectRef[] ObjectRef, System.DateTime requestDate) 
		{
			return null;   
		}

    #endregion

    #region Methods for Event Notification to OD(The subscriber)

        [WebMethod(Description = "Publisher notifies subscriber of a change in OutageEvent by sending an array of changed OutageEvent objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] OutageEventChangedNotification(outageEvent[] oEvents)
        {
            return null;
        }
        [WebMethod(Description = "Client notifies server of a change in the Customer object by sending one or more changed customer object(s).  OD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

        [WebMethod(Description = "Client notifies server of a change in the Meter object by sending one or more changed meter object(s).  OD returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] MeterChangedNotification(meters changedMeters)
        {
            return null;
        }

    #endregion

	#region Methods to Modify OD(The Server) Data

		[WebMethod(Description="Allow requester to modify server data for a specific outage detection device object.  If this transaction failes,OD returns information about the failure using a SAOPFault.")]
		[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
        public errorObject[] ModifyODDataForOutageDetectionDevice(outageDetectionDevice oDDevice) 
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

