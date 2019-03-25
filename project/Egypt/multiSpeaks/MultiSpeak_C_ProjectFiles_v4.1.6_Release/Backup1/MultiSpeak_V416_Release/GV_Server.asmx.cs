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
	/// Web services hosted by GIS Viewer (GV).
	/// </summary>
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class GV_Server : System.Web.Services.WebService
	{
		public GV_Server()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

		public MultiSpeakMsgHeader MultiSpeakMsgHeader;

		#region Generic for each interface

			[WebMethod(Description="Requester Pings URL of GV to see if it is alive.  Returns errorObject(s) as necessary to communicate application status.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] PingURL() 
			{
				return null;
			}

			[WebMethod(Description="Requester requests list of methods supported by GV.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetMethods() 
			{
				return null;
			}

            [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetDomainNames() 
			{
				return null;
			}
			[WebMethod(Description="The client requests from the server the members of a specific domain of information, identified by the domainName parameter, which are supported by the server.  This method is used, along with the GetDomainNames method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.)")]
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

		#region Methods for Publisher to publish Event Notification to GV(The subscriber)

            [WebMethod(Description = "Publisher notifies GV of a change in customers by sending changed customer objects.  GV returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CustomerChangedNotification(customer[] changedCustomers)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GV of a change in customer account(s) by sending changed account object(s).  GV returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] AccountChangedNotification(account[] changedAccounts)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GV of a change in customer usages by sending changed usage objects.  GV returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] UsageChangedNotification(usage[] changedUsages)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GV of a change in GIS features by sending a changed MultiSpeak object.  GV returns failed transactions in an array of errorObjects.The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] GISFeatureChangedNotification(MultiSpeak changedFeatures)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GV of a change in sets of spatially connected features by sending changed spatialFeatureGroup objects.GV returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SpatialFeatureGroupChangedNotification(spatialFeatureGroup[] changedSpatialFeatureGroups)
            {
                return null;
            }


            [WebMethod(Description = "Publisher notifies subscriber of a change in the service location by sending the changed serviceLocation object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ServiceLocationChangedNotification(serviceLocation[] changedServiceLocations)
            {
                return null;
            }

            [WebMethod(Description = "Publisher Notifies GV of changes in analog values by sending an array of changed scadaAnalog objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[] SCADAAnalogChangedNotification(scadaAnalog[] scadaAnalogs) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in point status by sending an array of changed scadaStatus objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[] SCADAStatusChangedNotification(scadaStatus[] scadaStatuses) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in SCADA point definitions by sending an array of changed scadaPoint objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[] SCADAPointChangedNotification(scadaPoint[] scadaPoints) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in SCADA point definitions, limited to Analog points, by sending an array of changed scadaPoint objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[] SCADAPointChangedNotificationForAnalog(scadaPoint[] scadaPoints) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in SCADA point definitions, limited to Status points, by sending an array of changed scadaPoint objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[]  SCADAPointChangedNotificationForStatus(scadaPoint[] scadaPoints) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in a specific analog value, chosen by scadaPointID, by sending a changed scadaAnalog object.  If this transaction fails, GV returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public errorObject[] SCADAAnalogChangedNotificationByPointID(scadaAnalog scadaAnalog) 
		    {
                return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in a specific analog value, limited to power analogs, by sending an arrray of changed scadaAnalog objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[] SCADAAnalogChangedNotificationForPower(scadaAnalog[] scadaAnalogs) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changed analog values, limited to voltage analogs, by sending an array of changed scadaAnalog objects.  GV returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
		    public errorObject[] SCADAAnalogChangedNotificationForVoltage(scadaAnalog[] scadaAnalogs) 
		    {
			    return null;
		    }

            [WebMethod(Description = "Publisher Notifies GV of changes in the status of a specific point, chosen by PointID, by sending a changed scadaStatus object.  If this transaction fails, GV returns information about the failure in a SOAPFault. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
		    [SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public errorObject[] SCADAStatusChangedNotificationByPointID(scadaStatus scadaStatus) 
		    {
                return null;
		    }

            [WebMethod(Description = "Publisher notifies GV of a change in OutageDetctionEvent(s) by sending the changed OutageDetectionEvent object(s).  GV returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ODEventNotification(outageDetectionEvent[] ODEvents, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GV of a change in OutageDetctionDevice by sending an array of changed OutageDetectionDevice objects.  GV returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ODDeviceChangedNotification(outageDetectionDevice[] ODDevices)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of a change in OutageEvent by sending an array of changed OutageEvent objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] OutageEventChangedNotification(outageEvent[] oEvents)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GV of new AVL events by sending an AVLMessage object.  GV returns information on failed transactions by returrning an array of errorObjects. The transactionID calling parameter links this published data method call with the original Initate request (if any). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] AVLChangedNotification(AVLMessage events, string transactionID, string errorString)
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





