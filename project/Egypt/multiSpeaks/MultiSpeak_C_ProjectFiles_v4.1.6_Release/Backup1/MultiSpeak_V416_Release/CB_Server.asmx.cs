using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MultiSpeak4 {

    /// <summary>
    /// MultiSpeak Version 4.1.6 Web Services Definitions AM.
    /// Dated August 31, 2012
    /// Summary description for Web Services Hosted by Customer Billing(CB). 
    /// </summary> 
    ///  

    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class CB_Server : System.Web.Services.WebService {


        public MultiSpeakMsgHeader MultiSpeakMsgHeader;


        public CB_Server() {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent();
        }

        #region Generic for each interface

			[WebMethod(Description="Requester pings URL of CB to see if it is alive. Returns errorObject(s) as necessary to communicate application status.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] PingURL() {
				return null;
			}

			[WebMethod(Description="Requester requests list of methods supported by CB.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetMethods() {
				return null;
			}

            [WebMethod(Description = "The client requests from the server a list of names of domains supported by the server.  This method is used, along with the GetDomainMembers method to enable systems to exchange information about application-specific or installation-specific lists of information, such as the lists of counties for this installation or the list of serviceStatusCodes used by the server.It is recommended that domain names be returned in the form of the name of a named object (noun) in the MultiSpeak schema dotted with the field name of interest.  For instance, if the system of record is returning workflow status codes that would be used on work orders, it is suggested that the domain name be called workOrder.workflowStatus, using the same spelling and capitalization used in the MultiSpeak schema. ")]
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

        #region Methods for Getting Data from the CB system

            
            [WebMethod(Description = "Returns all required customer data for all customers.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public customer[] GetAllCustomers(string lastReceived)
			{
				return null;
			}
            
            [WebMethod(Description = "Returns account data for all customer accounts.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public account[] GetAllAccounts(string lastReceived)
            {
                return null;
            }
        
            [WebMethod(Description = "Returns all required customer data for all customers that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public customer[] GetModifiedCustomers(string previousSessionID, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all required Service Location data for all Service Locations that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public serviceLocation[] GetModifiedServiceLocations(string previousSessionID, string lastReceived, serviceType serviceType) 
			{
				return null;
			}

			[WebMethod(Description="Returns the requested Customer if it exists.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public customer GetCustomerByCustomerID(string customerId){
				return null;
			}

			[WebMethod(Description="Returns the requested Customer data given a meter identifier.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public customer GetCustomerByMeterID(meterID meterID)
            { 
				return null;
			}

            [WebMethod(Description = "Returns the requested accounts if any exists, given the customer identifier.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public account[] GetAccountsByCustomerID(string customerID)
            {
                return null;
            }

			[WebMethod(Description = "Returns the requested customer account data given a meterID, which includes a service type.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public account GetAccountByMeterID(meterID meterID)
			{
				return null;
			}
            
            [WebMethod(Description = "Returns the requested customer account data given a service location identifier and service type.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public account GetAccountByServiceLocationIDAndServiceType(string serviceLocationID, serviceType serviceType)
            {
                return null;
            }

			[WebMethod(Description="Returns the requested Customer(s) data given First and Last name.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public customer[] GetCustomerByName(string firstName, string lastName)
			{
				return null;
			}

			[WebMethod(Description="Returns the requested Customer given the Doing Business As (DBA) name.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public customer GetCustomerByDBAName(string dBAName){
				return null;
			}

            [WebMethod(Description = "Returns all required Service Location data for all Service Locations. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetAllServiceLocations(string lastReceived) 
			{
				return null;
			}

            [WebMethod(Description = " Requests a list of DR program enrollments for a particular value of DRProgramEnrollmentStatus. The permissible values of DRProgramEnrollmentStatus are: 'Active', 'Inactive', 'Pending', 'Other' and 'Unknown'. Active status means that the DRProgramEnrollment has a participation start date in the past and a participation end date in the future, even if control is not currently active. A status of Inactive implies that the DRProgramEnrollment has a participation start date in the future or a participation end date in the past. A status of Pending means that the DRProgramEnrollDate is in the past, but that the DRProgramEnrollment has a participation start date in the future. The Other and Unknown statuses are included for extensibility, but their use is discouraged. If the DRProgramEnrollmentStatus is set to be Other, the DR Program Enrollment Agent should populate the OtherDRProgramEnrollmentStatus element with the non-standard status value. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public DRProgramEnrollment[] GetDRProgramEnrollmentsByStatus(string DRProgramEnrollmentStatus)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested Service Location(s) data given the Service Status. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationByServiceStatus(string servStatus, string lastReceived, serviceType serviceType) 
			{
				return null;
			}

			[WebMethod(Description="Returns the requested Service Location data given Service Location ID.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationByServiceLocationID(string serviceLocationId, serviceType serviceType) 
			{
				return null;
			}
			[WebMethod(Description="Returns the requested Service Location data given Customer ID.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public serviceLocation[] GetServiceLocationByCustomerID(string customerId) {
				return null;
			}

			[WebMethod(Description="Returns the requested Service Location data given the meterID of a meter served at that location.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationByMeterID(meterID meterID) 
			{
			return null;
			}

			[WebMethod(Description="Returns the requested Service Location data given Account Number.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationByAccountNumber(string accountNumber, serviceType serviceType)
            {
				return null;
			}

			[WebMethod(Description="Returns the requested Service Location(s) data given the Grid Location.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationByGridLocation(string gridLocation, serviceType serviceType)
            {
				return null;
			}

            [WebMethod(Description = "Returns the requested Service Location(s) data given the Phase. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public serviceLocation[] GetServiceLocationByPhaseCode(phaseCode phaseCode, string lastReceived) {
				return null;
			}

            [WebMethod(Description = "Returns the requested Service Location(s) data given the Load Group.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public serviceLocation[] GetServiceLocationByLoadGroup(string loadGroup, string lastReceived) {
				return null;
			}

            [WebMethod(Description = "Returns the requested service location(s) data for services that have services of the given service type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public serviceLocation[] GetServiceLocationByServiceType(serviceType serviceType, string lastReceived) {
				return null;
			}
	     
			[WebMethod(Description="Returns the requested Service Location(s) data given the Service ShutOff Date.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationByShutOffDate(System.DateTime shutOffDate, serviceType serviceType)
            {
				return null;
			}

            [WebMethod(Description = "Returns all required Meter data for all Meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public meters GetAllMeters(string lastReceived)
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

			
            [WebMethod(Description = "Returns all required Meter data for all Meters that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public meters GetModifiedMeters(string previousSessionID, string lastReceived, serviceType serviceType) 
			{
				return null;
			}

			[WebMethod(Description="Returns the requested Meter data given meterID.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public meters GetMeterByMeterID(meterID meterID)
            {
				return null;
			}

			[WebMethod(Description="Returns the requested Meter(s) data given Service Location.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public meters GetMeterByServiceLocationID(string serviceLocationID, serviceType serviceType)
            {
				return null;
			}

			[WebMethod(Description="Returns the requested Meter(s) data given Account Number, for all serviceTypes.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public meters GetAllMetersByAccountNumber(string accountNumber, string lastReceived)
            {
				return null;
			}

			[WebMethod(Description="Returns the requested Meter(s) data given Customer ID.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public meters GetMeterByCustomerID(string customerID) {
				return null;
			}

            [WebMethod(Description = "Returns the requested Meter(s) data given AMR vendor and device type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public meters GetMetersByAMRType(string AMRVendor, string AMRDeviceType, string lastReceived) {
				return null;
			}

            [WebMethod(Description = "The Requester requests from the CB a list of names of meter reading groups.  The CB returns an array of strings including the names of the supported meterGroups.  The MR can then request the members of a specific group using the GetMeterGroupMembers method. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetMeterGroupNames()
            {
                return null;
            }

            [WebMethod(Description = "The Requester requests from the CB a list of names of meter reading groups for a specific meter.  The CB returns an array of strings including the names of the supported meterGroups.  The MR can then request the members of a specific group using the GetMeterGroupMembers method. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetMeterGroupNamesByMeterID(meterID meterID)
            {
                return null;
            }

            [WebMethod(Description = "The Requester requests from the CB the members of a specific meter reading group, identified by the meterGroupName parameter.  This method is used, along with the GetMeterGroupNames method to enable the MR to get information about which meters are included in a specific meter reading group.  The CB returns a meterGroups object in response to this method call.  This object can carry meterGroups that only include meters of one service type or a mixed meterGroup that contains meters of mixed service type. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterGroups GetMeterGroupMembers(string meterGroupName)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested PPMLocation given a customer's accountNumber.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public ppmLocation GetPPMCustomer(string accountNumber)
            {
                return null;
            }

            [WebMethod(Description = "Returns the chargeable devices associated with an account number given a customer's accountNumber.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public chargeableDevice[] GetChargeableDevicesByAccountNumber(string accountNumber)
            {
                return null;
            }
            [WebMethod(Description = "Returns the payment transactions accepted by the CB between the stated start and stop times.  This is an alternative method for obtaining payments and could replace or be in addition to the publish method CommitPaymentTransaction.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public paymentTransactionList[] GetPPMPayments(System.DateTime startTime, System.DateTime stopTime)
            {
                return null;
            }

            [WebMethod(Description = "Returns the balance adjustments to be made on the Requester's system by the CB between the stated start and stop times.  This is an alternative method for obtaining balance adjustments and could replace or be in addition to the publish method AdjustPPMBalance.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public ppmBalanceAdjustment[] GetPPMBalanceAdjustments(System.DateTime startTime, System.DateTime stopTime)
            {
                return null;
            }

            [WebMethod(Description = "Returns billing data for all accounts that were billed between the startBillDate and endBillDate.  This method is used by the PPM to reconcile its records with those in the CB.The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public billingData[] GetBillingData(System.DateTime startBillDate, System.DateTime endBillDate, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns detailed billing data for a specific account.  This method is used by the PPM to reconcile its records with those in the CB.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public billingDetail[] GetBillingDetail(string accountNumber, System.DateTime cisBillDate)
            {
                return null;
            }

            [WebMethod(Description = "Returns details of the billed usage for a specific account.  This method is used by the Requester to reconcile its records with those in the CB.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public billedUsage GetBilledUsage(string accountNumber, System.DateTime cisBillDate)
            {
                return null;
            }

            [WebMethod(Description = "The Requester requests from the CB a list of payableitems for a specific account.  The CB returns a payableItemList object.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public payableItemList GetPayableItemsList(string accountNumber)
            {
                return null;
            }
            [WebMethod(Description = "The Requester requests from the CB a list of convenience fees for a set of transactions sent in the form of a paymentTransactionsList.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public convenienceFeeList GetConvenienceFees(paymentTransactionList transactions)
            {
                return null;
            }
            [WebMethod(Description = "Returns the billing account load data for all line sections/nodes (eaLocs) for a specific month.  The month should be described by an integer (January=1, February=2, etc.) and the year by an integer in four digit format.   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public billingAccountLoad[] GetBillingAccountLoadDataByMonth(int month, int year, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns the objectIDs for service locations for a given customer, by home phone number.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetServiceLocationIDByHomePhone(telephoneNumber phone, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested service location ID given the meterID at the service location.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string GetServiceLocationIDByMeter(meterID meterID)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested service location ID given the account number at the service location.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetServiceLocationIDByAccountNumber(string accountNumber, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested Customer by home phone number.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public customer GetCustomerByHomePhone(telephoneNumber phone)
            {
                return null;
            }

            [WebMethod(Description = "Returns all pole data from the CB that have changed since the specified sessionID. The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public pole[] GetModifiedPolesFromCB(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all pole data from the CB. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public pole[] GetAllPolesFromCB(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns pole data from the CB, chosen by pole number.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public pole GetPoleByPoleNumberFromCB(string poleNumber)
            {
                return null;
            }

            [WebMethod(Description = "Returns all transfromer bank data from the CB.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank[] GetAllTransformerBanksFromCB(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all transfromer bank data from the CB that has been modified since the specified sessionID. The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank[] GetModifiedTransformerBanksFromCB(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns transformer bank data from the CB, chosen by bankID (objectID of transformerBank).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank GetTransformerBankByBankIDFromCB(string bankID)
            {
                return null;
            }
            [WebMethod(Description = "Returns transformer bank data from the CB, chosen by unitID (objectID of constituent unit of transformerBank).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank GetTransformerBankByUnitIDFromCB(string unitID)
            {
                return null;
            }

            [WebMethod(Description = "Returns customer usage data from the CB, chosen by calendar month number (January =1, February=2, etc.)The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public usage[] GetUsageByMonth(int monthNumber, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns customer usage data from the CB, chosen by the objectID of serviceLocation.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public usage[] GetUsageByServiceLocationID(string serviceLocationID, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns customer usage data from the CB, chosen by account number.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public usage[] GetUsageByAccountNumber(string accountNumber, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns customer usage data from the CB, chosen by meterID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public usage GetUsageByMeterID(meterID meterID)
            {
                return null;
            }
            [WebMethod(Description = "The MR requests from the CB all meters of a given serviceType (electric, gas, water, or propane). The CB returns a meters object, which contains an array of meters by serviceType in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetAllMetersByServiceType(serviceType serviceType, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Requests from the CB all serviceLocations that have services of a given serviceType (electric, gas, water, or propane). The CB returns a serviceLocations object, which contains an array of serviceLocations by serviceType in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceLocation[] GetAllServiceLocationsByServiceType(serviceType serviceType, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "The MR requests from the CB a specific meter object, given the account number and serviceType (electric, gas, water, or propane). The CB returns a meters object, which can contain an array of meters by serviceType in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersByAccountNumberAndServiceType(string accountNumber, serviceType serviceType, string lastReceived)
            {
                return null;
            }
			
            [WebMethod(Description = "Returns all electric meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public electricMeter[] GetAllElectricMeters(string lastReceived)
            {
                return null;
            }
            
			[WebMethod(Description = "Returns all gas meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public gasMeter[] GetAllGasMeters(string lastReceived)
            {
                return null;
            }
            
			[WebMethod(Description = "Returns all water meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public waterMeter[] GetAllWaterMeters(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all other meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public otherMeter[] GetAllOtherMeters(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all propane meters.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public propaneMeter[] GetAllPropaneMeters(string lastReceived)
            {
                return null;
            }
            
            [WebMethod(Description = "The MR requests from the CB electric meter objects, given the account number. The CB returns a meters object, which can contain an array of electric meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public electricMeters GetElectricMetersByAccountNumber(string accountNumber, string lastReceived)
            {
                return null;
            }
            [WebMethod(Description = "The MR requests from the CB gas meter objects, given the account number. The CB returns a meters object, which can contain an array of gas meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public gasMeters GetGasMetersByAccountNumber(string accountNumber, string lastReceived)
            {
                return null;
            }
            [WebMethod(Description = "The MR requests from the CB water meter objects, given the account number. The CB returns a meters object, which can contain an array of water meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public waterMeters GetWaterMetersByAccountNumber(string accountNumber, string lastReceived)
            {
                return null;
            }
            [WebMethod(Description = "The MR requests from the CB propane meter objects, given the account number. The CB returns a meters object, which can contain an array of propane meters in response to this method call. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public propaneMeters GetPropaneMetersByAccountNumber(string accountNumber, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "The MR requests from the CB all customers of a given serviceType (electric, gas, water, or propane). The CB returns an array of customer objects. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public customer[] GetAllCustomersByServiceType(serviceType serviceType, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "The DGN requests from the CB to reserve a service order number. The CB returns a reserved service order in the form of a requestedNumber.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public requestedNumber GetNextNumber(extensionsList extensions, string numberType)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested meters corresponding to a given location in the engineering connectivity model, as specified by the eaLoc.name.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersByEALocation(string eaLoc)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested meters corresponding to a given customer's serviceLocation, given the serviceLocation.facilityID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersByFacilityID(string facilityID, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested meters corresponding to a given customer's serviceLocation, given the serviceLocation.siteID")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersBySiteID(string siteID, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns all meters corresponding to a given customer name.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersByCustomerName(string firstName, string lastName)
            {
                return null;
            }

            [WebMethod(Description = "Returns all meters corresponding to a given customer's home phone number.  HomeAC is the area code and homePhone is the 7-digit local phone number for the customer of interest.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersByHomePhone(telephoneNumber phone)
            {
                return null;
            }

            [WebMethod(Description = "Returns all meters corresponding to a given search string.  This method can return any meters associated with customer, serviceLocation, meter,accountNumber, or meterBase containing or starting with the seach string.  For instance, a  search string of 123 could return meters for accountNumber = 12345678, customer = as123666, etc.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMetersBySearchString(string searchString)
            {
                return null;
            }

            [WebMethod(Description = "Returns a specific project that has been established by CB. The project is referred to by using an objectRef; the name is the human-readable objectName for the project instance, the noun (if used) is 'project', the objectID is the objectID for this project instance.  If the system of record can resolve the name then the noun and objectID are not required, but the default condition is that the noun and objectID are required in order to uniquely resolve the project. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public project GetProject(objectRef projectID)
            {
                return null;
            }

            [WebMethod(Description = "Returns all street light data.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public streetLight[] GetAllStreetLights(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all security light data.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public securityLight[] GetAllSecurityLights(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "The Requester requests from the server a list of names of in home display groups.  The server returns an array of strings including the names of the supported inHomeDisplayGroups.  The requester can then request the members of a specific group using the GetIHDGroupMembers method. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetIHDGroupNames()
            {
                return null;
            }

            [WebMethod(Description = "The Requester requests from the server a list of names of in home display groups for a specific inHomeDisplay.  The server returns an array of strings including the names of the supported inHomeDisplayGroups.  The Requester can then request the members of a specific group using the GetIHDGroupMembers method. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetIHDGroupNamesByInHomeDisplayID(string inHomeDisplayID)
            {
                return null;
            }

            [WebMethod(Description = "The Requester requests from the server the members of a specific in home display group, identified by the IHDGroupName parameter.  This method is used, along with the GetIHDGroupNames method to enable the requester to get information about which meters are included in a specific in home display group.  The server returns an inHomeDisplayGroup in response to this method call.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public inHomeDisplayGroup GetIHDGroupMembers(string IHDGroupName)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested meter base data given the objectID of the meterBase.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterBase GetMeterBaseByObjectID(string meterBaseID)
            {
                return null;
            }

            [WebMethod(Description = "Returns all connectDisconnectEvents in the specified date range for the specified reasonCode.  See the connectDisconnectCode.reasonCode enumeration for acceptable values.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public connectDisconnectEvent[] GetAllConnectDisconnectEventsByReasonCode(string reasonCode, System.DateTime startDate, System.DateTime endDate)
            {
                return null;
            }

            [WebMethod(Description = "Returns the meter history events for a specific meter, chosen by meterID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterHistoryEvent[]  GetMeterHistoryByMeterID(meterID meter)
            {
                return null;
            }

            [WebMethod(Description = "Returns the service orders that have a specified serviceOrder Status code. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceOrder[] GetServiceOrdersByStatus(soStatusCode status, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns the service orders that are associated with a specific service location, specified by its serviceLocationID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceOrder[] GetServiceOrdersByServiceLocation(string serviceLocationID)
            {
                return null;
            }
            [WebMethod(Description = "Returns a service order, specified by its serviceOrderID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceOrder GetServiceOrderByServiceOrderID(string serviceOrderID)
            {
                return null;
            }
			
        #endregion

		#region Methods for Modification of CB data by external system 

            [WebMethod(Description = "Allow client to modify CB data for customer objects. CB returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForCustomer(customer[] customerData)
            {
                return null;
			}

            [WebMethod(Description = "Allow client to modify CB data for the Service Location object. CB returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForServiceLocations(serviceLocation[] serviceLocationData)
            {
                return null;
			}

            [WebMethod(Description = "Allow client to modify CB data for the Meter object. CB returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForMeters(meters meterData)
            {
                return null;
			}

            [WebMethod(Description = "Allow Requester to modify CB data for the pole object. CB returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForPole(pole[] poleData)
            {
                return null;
            }

            [WebMethod(Description = "Allow requester to Modify CB data for a transformer bank object.  CB returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForTransformerBank(transformerBank[] xfmrBankData)
            {
                return null;
            }

            [WebMethod(Description = "Allow requester to Modify CB data for the customer usage object.  CB returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForUsage(usage[] usageData)
            {
                return null;
            }

            [WebMethod(Description = "Allow Requester to modify CB data for the streetLight object.  CB returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForStreetLight(streetLight[] streetLightData)
            {
                return null;
            }

            [WebMethod(Description = "Allow Requester to modify CB data for the securityLight object.  CB returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyCBDataForSecurityLight(securityLight[] securityLightData)
            {
                return null;
            }

        #endregion


        #region Methods for  Publisher to publish Event Notification to CB(The subscriber)

		
			[WebMethod(Description = "Publisher notifies subscriber of the result of a critical peak price event on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateCriticalPeakPriceEvent. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] CriticalPeakPriceEventNotification(criticalPeakPriceEventStatus[] eventHistory, string transactionID)
			{
				return null;
			}

            [WebMethod(Description = "Publisher notifies Subscriber of a change in meter readings by sending the changed meterReading objects.  Subscriber returns information about failed transactions in an array of errorObjects.The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ReadingChangedNotification(meterReading[] changedMeterReads, string transactionID)
            {
                return null;
            }


            [WebMethod(Description = "Publisher notifies subscriber of a change in the History Log by sending the changed historyLog object.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
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
			
			[WebMethod(Description = "The HAN Communications server notifies subscriber of the status of a HAN registration request that the subscriber previously issued to the HAN Communications server. The HAN Communications server sends an array of HANRegistration objects. The subscriber returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this published data method call with the InitiateHANRegistration that was issued to request the HAN registration.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] HANRegistrationNotification(HANRegistration[] registrations, string transactionID)
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

            [WebMethod(Description = "Publisher notifies CB that meter(s) have been installed. CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterInstalledNotification(meters addedMeters, string transactionID)
            {
                return null;
            }
            [WebMethod(Description = "MR notifies CB that meter(s) have been deployed or exchanged.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterExchangeNotification(meterExchanges meterChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies CB that load mangement device(s) have been deployed or exchanged.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceExchangeNotification(LMDeviceExchange[] LMDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies CB that load management device(s) have been installed. CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceInstalledNotification(loadManagementDevice[] installedLMDs)
            {
                return null;
            }

            [WebMethod(Description = "CD notifies CB of state change for a connect/disconnect device By meterID and loadActionCode.  The transactionID calling parameter can be used to link this action with an InitiateConectDisconnect call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDStateChangedNotification(CDStateChange stateChange, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of state change(s) for connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateConnectDisconnect call.  If this transaction fails, subscriber returns information about the failure in an array of errorObject(s). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDStatesChangedNotification(CDStateChange[] stateChanges, string transactionID)
            {
                return null;
            }


			[WebMethod(Description = "Publisher notifies subscriber of the result of DR event setup on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateDemandResponseSetup. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] DemandResponseSetupNotification(demandResponseParameters drParameters, HANDeviceID deviceID, string transactionID, HANInterfaceID interfaceID)
			{
				return null;
			}
			
			[WebMethod(Description = "Publisher notifies subscriber of the result of DR event on a HAN. Subscriber returns information about failed transactions using an array of errorObjects. The transactionID parameter is used to link this notification with the initiating message, InitiateDemandResponseEvent. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] DemandResponseEventNotification(demandResponseEventStatus[] eventHistory, string transactionID)
			{
				return null;
			}
			
            [WebMethod(Description = "Publisher requests that CB authorize and process a set of transactions that have been sent as part of a paymentTransactionsList.  CB returns information about the transaction to the Publisher.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public paymentTransactionList ProcessPaymentTransaction(paymentTransactionList transactions)
            {
                return null;
            }

            [WebMethod(Description = "Publisher requests that CB process a set of transactions that the PP has previously authorized and that have been sent as part of a paymentTransactionsList.  CB returns information about the transactions to the Publisher.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public paymentTransactionList CommitPaymentTransaction(paymentTransactionList transactions)
            {
                return null;
            }

            [WebMethod(Description = "Publisher requests that CB extend payment terms for a specific account by sending a paymentExtensionList object.  CB sends extension information to the PP based on payment extension rules configured on the CB.  PP must subsequently commit the extension using an ExtendPayment method call if the payment extension terms were accepted by the payee.  The CB shall return the processed paymentExtensionList with the responseCode and the extendedTo date filled in with the new extended date.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public paymentExtensionList RequestPaymentExtension(paymentExtensionList extensionList)
            {
                return null;
            }

            [WebMethod(Description = "Publisher has processed payment extension(s) in accordance with the rules established by the CB and previously communicated with the Publisher using the RequestPaymentExtension method, and is sending the extension information to the CB.  CB returns information on failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ExtendPayment(paymentExtensionList extensionList)
            {
                return null;
            }

            [WebMethod(Description = "Publisher Notifies CB of a change in the LoadProfile object(s) by sending the changed profileObject(s).  CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LoadProfileChangedNotification(profileObject[] changedLoadProfiles)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies CB of a change in a pole by sending the changed pole object. CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] PoleChangedNotification(pole[] changedPoles)
            {
                return null;
            }

			[WebMethod(Description = "Publisher notifies subscriber of the status of pricing structure changes on an HAN. This method call is the asynchronous reply to InitiateHANPricing method that was sent earlier. The InitiateHANPricing method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] PricingTiersChangedNotification (HANInterfaceID hanInterfaceID, string transactionID)
			{
				return null;
			}

						
			[WebMethod(Description = "Publisher notifies requester of the current rate structure associated with a HAN. This method call is the asynchronous reply to InitiateHANPricingRequest method that was sent earlier. The InitiateHANPricingRequest method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] HANPricingNotification (priceTierStructure priceTierStructure, HANInterfaceID interfaceID, string transactionID)
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
			
            [WebMethod(Description = "Publisher notifies CB of a change in the service location/network data by sending the changed serviceLocation object.  CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ServiceLocationNetworkChangedNotification(serviceLocation[] changedServiceLocations)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of new or modified surge arrestors by sending an array of surgeArrestor objects. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SurgeArrestorChangedNotification(surgeArrestor[] surgeArrestors)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies CB of a change in a transformerBank by sending the changed transformerBank object.  CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] TransformerBankChangedNotification(transformerBank[] changedXfmrBanks)
            {
                return null;
            }
            [WebMethod(Description = "EDTR Notifies CB of a received end device (meter) shipment by sending the changed endDeviceShipment object.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] EndDeviceShipmentNotification(endDeviceShipment shipment)
            {
                return null;
            }
			
			[WebMethod(Description = "Publisher notifies requester of result of the request to send a manufacturer-specific command to a HAN device. This method call is the asynchronous reply to the InitiateManufacturerSpecificCommand method that was sent earlier. The calling method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] ManufacturerSpecificCommandNotification (HANDeviceID deviceID, string transactionID, tunnelCommandContent command, HANInterfaceID interfaceID)
			{
				return null;
			}

            [WebMethod(Description = "Publisher notifies subscriber of a completion of tests on electric meters by sending an array of testedElectricMeters.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterTestNotification(testedElectricMeter[] tests, string transactionID)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies CB that in-home display(s) have been installed. CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InHomeDisplayInstalledNotification(inHomeDisplay[] addedIHDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies CB that in-home displays(s) have been deployed or exchanged.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InHomeDisplayExchangeNotification(inHomeDisplayExchange[] IHDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies CB that connect/disconnect device(s) have been deployed or exchanged.  CB returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies CB that connect/disconnect device(s) have been installed. CB returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceInstalledNotification(CDDevice[] installedCDDs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies CB that a previously reserved service order number is being returned. CB returns failed transactions using an errorObject.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ReturnGeneratedNumber(requestedNumber requestedNum)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies CB of new or changed assignment(s) by sending the changed assignment object(s).  CB returns information about failed transactions using an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] AssignmentNotification(assignment[] assignments, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies CB of new or changed work requests(s). CB asynchronously returns service order or maintenace order numbers as necessary using a NumberCreatedNotification method call.   CB returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InitiateWorkRequest(workRequest[] requests, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "CD notifies CB of state of a connect/disconnect device.  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDStateNotification(CDState state, string transactionID)
            {
                return null;
            }
            [WebMethod(Description = "CD notifies CB of state of connect/disconnect device(s).  The transactionID calling parameter can be used to link this action with an InitiateCDStateRequest call.  If this transaction fails, CB returns information about the failure in an array of errorObject(s).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDStatesNotification(CDState[] states, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "MR Notifies CB of the success or failure of meter reading schedule requests by sending readingScheduleResult objects.  CB returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this Initiate request with the published data method call. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ReadingScheduleResultNotification(readingScheduleResult[] scheduleResult, string transactionID, string errorString)
            {
                return null;
            }

			[WebMethod(Description = "Publisher notifies requester of the current schedule associated with a thermostat. This method call can be either the solicited asynchronous reply to InitiateThermostatScheduleRequest or can be an unsolicited asynchronous reply to an InitiateThermostatSchedule method that was sent earlier. The calling method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] ThermostatScheduleNotification (thermostatSchedule schedule, HANDeviceID thermostatID, string transactionID, HANInterfaceID interfaceID)
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
			
            [WebMethod(Description = "Publisher notifies CB that history comment(s) should be written to a customer account. CB returns failed transactions using an errorObject.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] WriteAccountHistoryComments(historyComment[] comments)
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

            [WebMethod(Description = "Publisher notifies subscriber that meterBase(es) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseExchangeNotification(meterBaseExchange[] MBChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber that meter base(es) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseInstalledNotification(meterBase[] addedMBs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of the modified connectivity of meters after a switching event used to restore load during outage situations.  Subscriber returns status of failed tranactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterConnectivityNotification(meterConnectivity[] newConnectivity)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies the subscriber of work tasks to be scheduled.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] TaskListNotification(workTask[] tasks, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies the server that significant usage has been detected on meters that were previously placed into usage monitoring mode using a call to the InitiateUsageMonitoring method on the Publisher.  The array of meterID can be used to pass the list of meters for which excessive usage has been detected.  The array of meterReading can be used to pass the meter readings on those meters at the time that the excessive usage was detected.  The meterReading.meterID element MUST be populated on the meterReading object for this use case so that the readings can be linked to the meter identifiers (meterIDs) if more than one meterID has been included in this notification.  The transactionID is included to link this notification to the previous InitiateUsageMonitoring method call.  Server returns information about failed transactions using an array of errorObjects.  In Version 4.2, this method shall be modified to include a usageMonitoringInstance object that will inherently link the meterID and the associated meter reading, but such a change cannot be made at this time since it would be a breaking change in Version 4.1.x.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] UsageMonitoringNotification(meterID[] meters, meterReading[] readings, string transactionID)
            {
                return null;
            }


			[WebMethod(Description = "Publisher notifies subscriber of the status of messages on the associated IHD. This method call is the asynchronous reply to InitiateInHomeDisplayMessage or CancelInHomeDisplayMessage methods that were sent earlier. These methods are linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] IHDMessageStatusNotification (IHDMessageStatus messageStatus, string messageID, HANDeviceID hanDeviceID, string transactionID, HANInterfaceID interfaceID, IHDMessageType messageType)
			{
				return null;
			}

			[WebMethod(Description = "Publisher notifies subscriber of the fact that the customer/resident has confirmed receipt of messages on the associated IHD. This method call is the asynchronous reply to InitiateInHomeDisplayMessage method that was sent earlier. The InitiaiteInHomeDisplayMessage method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] IHDMessageConfirmedNotification (string inHomeDisplayMessageID, HANDeviceID hanDeviceID, string transactionID, HANInterfaceID interfaceID, System.DateTime messageConfirmedTime, string errorString)
			{
				return null;
			}


			[WebMethod(Description = "Publisher notifies subscriber of changes in the established capability settings for the associated IHD. This method call is the asynchronous reply to InitiateIHDCapabilitySettings method that was sent earlier. The InitiateIHDCapabilitySettings method is linked to this method call using the transactionID. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] IHDCapabilitySettingsNotification(HANDeviceID inHomeDisplayID, string transactionID, HANInterfaceID interfaceID)
			{
				return null;
			}

        #endregion

            #region Methods New in Version 4.1.5
            /// 
			/// Begin Methods New in Version 4.1.5
			/// 
             
            [WebMethod(Description = "The Requester requests from the server all meters that have the specified meterConnectionStatus. Allowable values of meterConnectionStatus are [Other / Connected / Disconnected / DisconnectedNonPay / Unknown]. The server returns an array of meters. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call." )]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]           
            public meters GetMetersByMeterConnectionStatus(meterConnectionStatus status, string lastReceived)
                {
                    return null;
                }

            [WebMethod(Description = "Returns the meter that contains the communications module that has the objectID identified as being the transponderID in the request. The meters structure can carry an array of meters of any service type (thus electricMeter, gasMeter, waterMeter, etc.).  Although it is anticipated that only one meter will be returned since the transponderID calling parameter should be unique, the meters structure permits the use of this single method to get information about meters of all service types.  The transponderID SHALL correspond to the objectID of the communications module included in the returned meter as part of the XXXMeter.moduleList.module (for instance for an electric meter, the transponderID SHALL be the electricMeter.moduleList.module.objectID). ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meters GetMeterByTransponderID(string transponderID)
                    {
                         return null;
                    }

            [WebMethod(Description = "Requests that Receiver process a set of balance adjustment transactions. Receiver returns information about failed transactions in the form of an array of errorObjects.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] AdjustPPMBalance(ppmBalanceAdjustment[] adjustments)
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
        private void InitializeComponent() {
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if(disposing && components != null) {
                components.Dispose();
            }
            base.Dispose(disposing);		
        }
		
        #endregion

 
    }

}

