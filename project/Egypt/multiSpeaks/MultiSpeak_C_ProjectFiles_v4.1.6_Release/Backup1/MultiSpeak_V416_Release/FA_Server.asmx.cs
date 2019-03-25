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
	/// Web Services Hosted by the Finance & Accounting (FA) function. 
	/// </summary> 
	///  


    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class FA_Server : System.Web.Services.WebService 
	{


		public MultiSpeakMsgHeader MultiSpeakMsgHeader;


		public FA_Server() 
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

		#region Generic for each function

			[WebMethod(Description="Requester pings URL of FA to see if it is alive.  Returns errorObject(s) as necessary to communicate application status.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] PingURL() 
			{
				return null;
			}

			[WebMethod(Description="Requester requests list of methods supported by FA.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetMethods() 
			{
				return null;
			}

            [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.  It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema.")]
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

		#region Methods for Getting Data from the FA system

            [WebMethod(Description = "Returns all required data for all material management assemblies, including material components and labor components.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public materialManagementAssembly[] GetAllMaterialManagementAssemblies(string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all required data for all material items.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public materialItem[] GetAllMaterialItems(string lastReceived) 
			{
				return null;
			}

            [WebMethod(Description = "Returns all required data for all material management assemblies that have been modified since the specified sessionID, including material components and labor components.   The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public materialManagementAssembly[] GetModifiedMaterialManagementAssemblies(string previousSessionID, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all required data for all material items that have been modified since the specified sessionID.   The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public materialItem[] GetModifiedMaterialItems(string previousSessionID, string lastReceived) 
			{
				return null;
			}

            [WebMethod(Description = "Returns all labor categories.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public laborCategory[] GetAllLaborCategories(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns modified labor categories.   The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public laborCategory[] GetModifiedLaborCategories(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "The DGN requests from the FA to reserve a work order number. The FA returns a reserved work order in the form of a requestedNumber.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public requestedNumber GetNextNumber(extensionsList extensions, string numberType)
            {
                return null;
            }

            [WebMethod(Description = "Returns a list of work orders in the FA system.The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public workOrderSelection[] GetWorkOrderSelectionList(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns a list of work orders in the FA system, selected by work order status. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public workOrderSelection[] GetWorkOrderSelectionByStatus(string woStatusCode, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns a list of work orders in the FA system, selected by work order number. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public workOrder[] GetWorkOrdersByWorkOrderNumber(string woNumber)
            {
                return null;
            }

            [WebMethod(Description = "Returns an array of work orders in the FA system, selected by work order status. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public workOrder[] GetWorkOrdersByStatus(string woStatusCode, string lastReceived)
            {
                return null;
            }
        
            [WebMethod(Description = "Returns a specific project that has been established by FA. The project is referred to by using an objectRef; the name is the human-readable objectName for the project instance, the noun (if used) is 'project', the objectID is the objectID for this project instance.  If the system of record can resolve the name then the noun and objectID are not required, but the default condition is that the noun and objectID are required in order to uniquely resolve the project. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public project GetProject(objectRef projectID)
            {
                return null;
            }

        #endregion

		#region Methods for Publisher to publish Event Notification to FA(The subscriber)

            [WebMethod(Description = "Publisher notifies FA of a change in designed work orders by sending the changed workOrder object, including assemblies, CPRs and pick list. FA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] DesignedWorkOrderNotification(workOrder[] designedWorkOrders) 
			{
	           return null;
			}

            [WebMethod(Description = "Publisher notifies FA of a change in material management assemblies by sending the changed materialManagementAssembly object.  FA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] MaterialManagementAssemblyNotification(materialManagementAssembly[] changedMMAssemblies) 
			{
	           return null;
			}

            [WebMethod(Description = "Publisher notifies FA of a change in labor categories by sending the changed laborCategory objects.  Design returns information about failed transactions using an aray of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LaborCategoryNotification(laborCategory[] changedLaborCategories)
            {
                return null;
            }
        
            [WebMethod(Description = "Publisher notifies FA of a change in work orders by sending the changed elements of the work order. FA returns failed transactions using an array of errorObjects.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] UpdateWO(extensionsItem[] woUpdates)
            {
                return null;
            }
            
            [WebMethod(Description = "Publisher notifies FA that a previously reserved work order number is being returned. FA returns failed transactions using an errorObject.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ReturnGeneratedNumber(requestedNumber requestedNum)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies FA of new or changed work request(s). FA asynchronously returns work order numbers as necessary using a NumberCreatedNotification method call.   FA returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InitiateWorkRequest(workRequest[] requests, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies FA of new or changed project(s). FA returns information about failed transactions using an array of errorObjects. The transactionID calling parameter links this Update request with the published data method call ProjectChangedNotification.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] UpdateProjects(project[] projects, string transactionID)
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

