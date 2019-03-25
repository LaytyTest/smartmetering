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
	/// Summary description for Web Services Hosted by GIS. 
	/// </summary> 
	///  


    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class GIS_Server : System.Web.Services.WebService 
	{


		public MultiSpeakMsgHeader MultiSpeakMsgHeader;


		public GIS_Server() 
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

		#region Generic for each interface

			[WebMethod(Description="Requester pings URL of GIS to see if it is alive.  Returns errorObject(s) as necessary to communicate application status.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] PingURL() 
			{
				return null;
			}

			[WebMethod(Description="Requester requests list of methods supported by GIS.")]
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

		#region Methods for Getting Data from the GIS system


			[WebMethod(Description="Returns all type names of supported GIS features.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public string[] GetFeatureTypes()
			{
				return null;
			}

            [WebMethod(Description = "Returns GIS features that have been modified since the time of a specifed sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public MultiSpeak GetModifiedFeatures(string previousSessionID, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all features within a rectangular bounding box.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public MultiSpeak GetFeaturesByBounds(float xMin, float xMax, float yMin, float yMax, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all features of a specific type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public MultiSpeak GetFeaturesByType(string featureType, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all features of a specific type within a rectangular bounding box.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public MultiSpeak GetFeaturesByTypeAndBounds(string featureType, float xMin, float xMax, float yMin, float yMax, string lastReceived)
			{
				return null;
			}

			[WebMethod(Description="Returns a specific feature by type and objectID.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public MultiSpeak GetFeatureByTypeAndObjectID(string featureType, string objectID)
			{
				return null;
			}

            [WebMethod(Description = "Returns all background graphics. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public backgroundGraphics[] GetAllBackgroundGraphics(string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all background graphics that have been modified since the previous session identified. The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public backgroundGraphics[] GetModifiedBackgroundGraphics(string previousSessionID, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all spatial features groups.  Spatial feature groups are groups of spatially related features, such as all of the features attached to a pole.  This is an alternative means to send GIS data, rather than sending individual features by type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public spatialFeatureGroup[] GetAllSpatialFeatureGroups(string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns all spatial features groups that have been modified since the session identified by the sessionID parameter.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received. Spatial feature groups are groups of spatially related features, such as all of the features attached to a pole.  This is an alternative means to send GIS data, rather than sending individual features by type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public spatialFeatureGroup[] GetModifiedSpatialFeatureGroups(string previousSessionID, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns background graphics within a rectangular bounding box.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public backgroundGraphics[] GetBackgroundGraphicsByBounds(float xMin, float xMax, float yMin, float yMax, string lastReceived)
			{
				return null;
			}

            [WebMethod(Description = "Returns spatial feature groups within a rectangular bounding box.  Spatial feature groups are groups of spatially related features, such as all of the features attached to a pole.  This is an alternative means to send GIS data, rather than sending individual features by type.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public spatialFeatureGroup[] GetSpatialFeatureGroupsByBounds(float xMin, float xMax, float yMin, float yMax, string lastReceived)
			{
				return null;
			}

			
			[WebMethod(Description="Returns a specific spatial feature group by objectID.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public spatialFeatureGroup GetSpatialFeatureGroupByObjectID(string objectID)
			{
				return null;
			}

            [WebMethod(Description = "Returns all substation names.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public string[] GetSubstationNames()
            {
                return null;
            }

            [WebMethod(Description = "Returns the list of all electrical equipment names in the application's equipment database for a specific type of engingeering catalog entry.  The calling parameter, equipmentType, is an enumerated string that holds the type of equipment for which the client is interested in receiving the allowable names.  Acceptable values for equipmentType include: Conductor, Concentric neutral cable, Tape shield cable, Line construction, Service drop, Material attributes, Line environmental attributes, Material, Transformer, Regulator, Breaker, Fuse, Recloser, Sectionalizer, Switch, Load mix, and Zsm impedance.  Pairs of vendors may add to this list of equipment types by agreement.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public catalogEntries GetElectricalEquipment(equipmentType equipmentType)
            {
                return null;
            }

            [WebMethod(Description = "Returns all information for circuit elements fed by a given line section or node.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public MultiSpeak GetDownlineConnectivity(string eaLoc, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all information for circuit elements in the shortest route to source from the given line section or node (eaLoc).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public MultiSpeak GetUplineConnectivity(string eaLoc)
            {
                return null;
            }

            [WebMethod(Description = "Returns all information for circuit elements immediately fed by the given line section or node (eaLoc).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public MultiSpeak GetChildConnectivity(string eaLoc)
            {
                return null;
            }

            [WebMethod(Description = "Returns all information for circuit elements immediately upstream of the given line section or node (eaLoc).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public MultiSpeak GetParentConnectivity(string eaLoc)
            {
                return null;
            }

            [WebMethod(Description = "Returns all information for all elements in the connectivity model. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public MultiSpeak GetAllConnectivity(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns circuit elements that have been modified since the time of a specifed sessionID. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the index number provided by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public MultiSpeak GetModifiedConnectivity(string previousSessionID, string lastReceived)
            {
                return null;
            }
            [WebMethod(Description = "Returns all circuit elements fed by a given line section or node (eaLoc).   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public circuitElement[] GetDownlineCircuitElements(string eaLoc, string lastReceived)
            {
                return null;
            }

			[WebMethod(Description="Returns circuit elements in the shortest route to source from the given line section or node (eaLoc). The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public circuitElement[] GetUplineCircuitElements(string eaLoc, string lastReceived) 
			{
				return null;
			}

			[WebMethod(Description="Returns circuit elements immediately fed by the given line section or node (eaLoc). The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public circuitElement[] GetChildCircuitElements(string eaLoc, string lastReceived) 
			{
				return null;
			}
			
			[WebMethod(Description="Returns circuit elements immediately upstream of the given line section or node (eaLoc). The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks. lastReceived should carry an empty string the first time in a session that this method is invoked. When multiple calls to this method are required to obtain all of the data, the lastReceived should carry the objectID of the last data instance received in subsequent calls.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public circuitElement[] GetParentCircuitElements(string eaLoc, string lastReceived) 
			{
				return null;
			}

            [WebMethod(Description = "Returns all circuit elements. The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public circuitElement[] GetAllCircuitElements(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all circuit elements that have been modified since the previous session identified. The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public circuitElement[] GetModifiedCircuitElements(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns the meter connectivity for all meters downline from a given meterID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterConnectivity[] GetDownlineMeterConnectivity(meterID meterID)
            {
                return null;
            }
            [WebMethod(Description = "Finds the first upline distribution transformer from a given meterID and returns the meter connectivity for all meters cnnected to it.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterConnectivity[] GetUplineMeterConnectivity(meterID meterID)
            {
                return null;
            }
            [WebMethod(Description = "Returns the meter connectivity for all meters on the same transformer as the given meterID, including the meter being requested.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterConnectivity[] GetSiblingMeterConnectivity(meterID meterID)
            {
                return null;
            }
            [WebMethod(Description = "This method returns the minimum set of connectivity data necessary for AMR systems to group meters on portions of the power system.  This method will not return a complete set of connectivity data; it returns only circuit elements downline of a specific substation, overcurrentDeviceBank, transformer, or serviceLoaction.  Device tree connectivity will not include objects unnecessary to group meters, such as line sections.  The MR requests devices downline of a specific object by passing the name and noun type for that object.  For instance, if the MR wishes to receive the minimal device tree downline of a specific substation, named the West substation, it would send name = West and noun = substation.  EA would return the minimal device tree downline of the West substation in the form of an array of circuit elements.  The MR can find the instances of the objects of interest using the GetDomainMembers method passing one of the parameters: substation, overcurrentDeviceBank, transformerBank, or serviceLocation.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public circuitElement[] GetDeviceTreeConnectivity(string name, string noun)
            {
                return null;
            }
            [WebMethod(Description = "Returns the meter connectivity for all meters served from a given substation.  The client requests the data by passing a substation name, which it previously received using the GetSubstationNames method.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterConnectivity[] GetMeterConnectivityBySubstation(string substationName)
            {
                return null;
            }


            [WebMethod(Description = "Returns all required pole data for all poles.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public pole[] GetAllPoles(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all required pole data for all poles that have changed since the sessionID identified.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.   The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public pole[] GetModifiedPoles(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns the requested pole, by pole number.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public pole GetPoleByPoleNumber(string poleNumber)
            {
                return null;
            }

            [WebMethod(Description = "Returns service location/network data for all service locations.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceLocation[] GetAllServiceLocationNetwork(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns service location/network data for all service locations that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceLocation[] GetModifiedServiceLocationNetwork(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns the service location/network data for a specific service location, chosen by the objectID for the serviceLocation.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationNetworkByServiceLocationID(string serviceLocationID, serviceType serviceType)
            {
                return null;
            }

            [WebMethod(Description = "Returns the service location/network data for service location(s) given the account number.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public serviceLocation[] GetServiceLocationNetworkByAccountNumber(string accountNumber)
            {
                return null;
            }

            [WebMethod(Description = "Returns all required transformer bank data for all transformerBank objects.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent. If the sessionID parameter is set in the message header, then the server shall respond as if it were being asked for a GetModifiedXXX since that sessionID; if the sessionID is not included in the method call, then all instances of the object shall be returned in response to the call.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank[] GetAllTransformerBanks(string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns all required transformer bank data for all transformerBank objects that have been modified since the specified sessionID.  The calling parameter previousSessionID should carry the session identifier for the last session of data that the client has successfully received.  The calling parameter lastReceived is included so that large sets of data can be returned in manageable blocks.  lastReceived should carry an empty string the first time in a session that this method is invoked.  When multiple calls to this method are required to obtain all of the data, the lastReceived should carry in subsequent calls the objectID of the data instance noted by the server as being the lastSent.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank[] GetModifiedTransformerBanks(string previousSessionID, string lastReceived)
            {
                return null;
            }

            [WebMethod(Description = "Returns the transformer bank data for a given transformerBank, chosen by bankID (objectID of the bank).")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank GetTransformerBankByBankID(string bankID)
            {
                return null;
            }

            [WebMethod(Description = "Returns the transformer bank data for a given transfomer bank, by chosing the objectID of one of its contitutent transformer units.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public transformerBank GetTransformerBankByUnitID(string unitId)
            {
                return null;
            }

            [WebMethod(Description = "Returns an attachment associated with a specific workOrder, design, or station, given its objectID. A work order may be referred to using: (i) the workOrderID (objectID of a workOrder), (ii) the combiination of work order number and job number, or (iii) an object reference.  A design or station is referred to using an object reference.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public attachment GetAttachment(string attachmentID, string woNumber, string jobNumber, string workOrderID, objectRef reference)
            {
                return null;
            }

            [WebMethod(Description = "Returns an array of all attachments associated with a specific workOrder, design, or station.  The attachment.content should not be returnd in response to this method.  The requester can then request the attachment with the content using the GetAttachment method.  A work order may be referred to using: (i) the workOrderID (objectID of a workOrder), (ii) the combiination of work order number and job number, or (iii) an object reference.  A design or station is referred to using an object reference.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public attachment[] GetAttachmentList(string woNumber, string jobNumber, string workOrderID, objectRef reference)
            {
                return null;
            }

		#endregion

		#region Methods for Modification of GIS data by external system 

			[WebMethod(Description="Allow requester to modify GIS data for any GIS feature. GIS returns information on failed transactions by returrning an array of errorObjects.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] ModifyGISFeatureData(MultiSpeak changedFeatures) 
			{
				return null;
			}

            [WebMethod(Description = "Allow requester to modify GIS data for the transformerBank object.  GIS returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyGISDataForTransformerBank(transformerBank[] xfmrBankData)
            {
                return null;
            }

            [WebMethod(Description = "Allow requester to modify GIS data for the Service Location/Network object.  GIS returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyGISDataForServiceLocation(serviceLocation[] serviceLocationData)
            {
                return null;
            }

            [WebMethod(Description = "Allow requester to modify GIS data for a pole.  GIS returns information about failed transactions using an array of errorObjects. ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ModifyGISDataForPole(pole[] poleData)
            {
                return null;
            }

			[WebMethod(Description = "Returns the meter connectivity for a specific meter.  The client requests the data by passing a meterID.  ")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterConnectivity GetMeterConnectivityByMeterID(meterID meterID)
            {
                return null;
            }
      
	 	#endregion

		#region Methods for Publisher to publish Event Notification to GIS(The subscriber)

        [WebMethod(Description = "Publisher notifies GIS of a change in work orders by sending the changed workOrder objects.  GIS returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] WorkOrderChangedNotificationToGIS(workOrder[] changedWOs) 
			{
		        return null;   
			}

            [WebMethod(Description = "Publisher notifies GIS of a change in material management assemblies by sending the changed materialManagementAssembly objects.  GIS returns information on failed transactions by returrning an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction=SoapHeaderDirection.InOut)]
			public errorObject[] MaterialManagementAssemblyNotification(materialManagementAssembly[] changedMMAssemblies) 
			{
			    return null;       
			}

            [WebMethod(Description = "Publisher notifies GIS of a change in Customer object(s) by sending the changed customer object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CustomerChangedNotification(customer[] changedCustomers)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in customer account(s) by sending the changed account object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

            [WebMethod(Description = "Publisher notifies GIS of a change in Meter object(s) by sending the changed meter object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterChangedNotification(meters changedMeters)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in transformerBank object(s) by sending the changed transformerBank object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] TransformerBankChangedNotification(transformerBank[] changedXfmrBanks)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in a pole object(s) by sending the changed pole object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] PoleChangedNotification(pole[] changedPoles)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in usage object(s) by sending the changed usage object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] UsageChangedNotification(usage[] changedUsages)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies EA of a change in circuit elements by sending a changed MultiSpeak object.  EA returns failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CircuitElementChangedNotification(MultiSpeak circuitElements)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GV of new AVL events by sending an AVLMessage object.  GV returns information on failed transactions by returrning an array of errorObjects. The transactionID calling parameter links this published data method call with the original Initate request (if any). The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] AVLChangedNotification(AVLMessage events, string transactionID, string errorString)
            {
                return null;
            } 
            [WebMethod(Description = "Publisher notifies GIS to add the associated connect/disconnect device(s). GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceAddNotification(CDDevice[] addedCDDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS of a change in connect/disconnect device(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceChangedNotification(CDDevice[] changedCDDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS that connect/disconnect device(s) have been deployed or exchanged.  GIS returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS to remove the associated connect/disconnect device(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceRemoveNotification(CDDevice[] removedCDDs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS that the associated connect/disconnect devices(s)have been retired from the system.  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceRetireNotification(CDDevice[] retiredCDDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS to add the associated load mangement device(s). GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceAddNotification(loadManagementDevice[] addedLMDs, string transactionID)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS of a change in load mangement device(s)by sending the changed loadManagementDevice object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceChangedNotification(loadManagementDevice[] changedLMDs, string transactionID)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS that load mangement device(s) have been deployed or exchanged.  GIS returns information about failed transactions in an array of errorObjects.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceExchangeNotification(LMDeviceExchange[] LMDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies GIS to remove the associated load mangement device(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceRemoveNotification(loadManagementDevice[] removedLMDs, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS that the associated load mangement devices(s)have been retired from the system.  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceRetireNotification(loadManagementDevice[] retiredLMDs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in streetLight object(s) by sending the changed street light object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] StreetLightChangedNotification(streetLight[] changedStreetLights)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in securityLight object(s) by sending the changed security light object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SecurityLightChangedNotification(securityLight[] changedSecurityLights)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in trafficLight object(s) by sending the changed traffic light object(s).  GIS returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] TrafficLightChangedNotification(trafficLight[] changedTrafficLights)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of new or modified surge arrestors by sending an array of surgeArrestor objects. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SurgeArrestorChangedNotification(surgeArrestor[] surgeArrestors)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of new or changed switching order(s) by sending switchingOrder object(s).  Subscriber returns information about failed transactions in an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SwitchingOrderChangedNotification(switchingOrder[] switchingOrders)
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

