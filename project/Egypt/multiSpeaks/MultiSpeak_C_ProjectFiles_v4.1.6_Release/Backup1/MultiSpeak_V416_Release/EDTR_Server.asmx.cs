using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MultiSpeak4
{
    /// <summary>
    /// MultiSpeak Version 4.1.6 Web Services Definitions AM.
    /// Dated August 31, 2012
    /// Summary description for Web Services Hosted by End Device Testing and Receiving (EDTR). 
    /// </summary> 
    ///  


    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class EDTR_Server : System.Web.Services.WebService
    {


        public MultiSpeakMsgHeader MultiSpeakMsgHeader;


        public EDTR_Server()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
        }

        #region Generic for each interface

        [WebMethod(Description = "Requester pings URL of EDTR to see if it is alive. Returns errorObject(s) as necessary to communicate application status.")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public errorObject[] PingURL()
        {
            return null;
        }

        [WebMethod(Description = "Requester requests list of methods supported by CB.")]
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

        #region Methods for Getting Data from the EDTR system

        [WebMethod(Description = "Returns the endDeviceShipment object given the shipmentID. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public endDeviceShipment GetEndDeviceShipmentByShipmentID(string shipmentID)
        {
            return null;
        }

        [WebMethod(Description = "Returns the endDeviceShipments given a date range. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public endDeviceShipment[] GetEndDeviceShipmentsByDateRange(System.DateTime startDate, System.DateTime endDate)
        {
            return null;
        }
        [WebMethod(Description = "Returns the endDeviceShipment object given the identifier for a meter that was included in that shipment. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public endDeviceShipment GetEndDeviceShipmentByMeterID(meterID meterID)
        {
            return null;
        }
        [WebMethod(Description = "Returns the endDeviceShipment object given the transponderID for a meter that was included in that shipment. ")]
        [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
        public endDeviceShipment GetEndDeviceShipmentByTransponderID(string transponderID)
        {
            return null;
        }

        #endregion

        #region Methods for Modification of EDTR data by external system



        #endregion


        #region Methods for Publisher to publish Event Notification to EDTR(The subscriber)



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

