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
    /// Summary description for Web Services Hosted by Asset Management(AM). 
    /// </summary> 
    ///  
    [WebService(Namespace = "http://www.multispeak.org/Version_4.1_Release")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]

    public class AM_Server : System.Web.Services.WebService
    {

        public MultiSpeakMsgHeader MultiSpeakMsgHeader;


        public AM_Server()
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
			
			[WebMethod(Description = "Requester deletes a previously established in-home display group on the server, specified by sending the inHomeDisplayGroupID.  The server returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] DeleteIHDGroup(string IHDGroupID)
			{
				return null;
			}
			
	        [WebMethod(Description = "Requester establishes a new in-home display group on the server.  The server returns information about failed transactions using an array of errorObjects. ")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public errorObject[] EstablishIHDGroup(inHomeDisplayGroup IHDGroup)
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

        #region Methods for Getting Data from the AM system

            [WebMethod(Description = "Returns the meter test information for a specific electric meter chosen by the meterID of the electric meter.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public testedElectricMeter[] GetMeterTestByMeterID(meterID meterID)
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
			
			[WebMethod(Description = "Returns the meter history events for a specific meter, chosen by meterID.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public meterHistoryEvent[]  GetMeterHistoryByMeterID(meterID meter)
            {
                return null;
            }
			
			[WebMethod(Description = "Returns the asset reference (identifier) from the Asset Management System for a specific asset chosen by the objectRef for that asset.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public assetRef GetAssetRefByObjectRef(objectRef objectRef)
			{
				return null;
			} 

			[WebMethod(Description = "Returns the asset from the Asset Management System for a specific asset chosen by the assetRef for that asset. The assets container can carry any type of asset being tracked by the AMS.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public assets GetAssetByAssetRef(assetRef assetRef)
			{
				return null;
			} 
			
			[WebMethod(Description = "Returns the assets from the Asset Management System that correspond to a specific field value in the data model for the specific type of asset desired. For instance, it would be possible to query for all poles manufactured by the pole manufacturer by the name of Acme, by sending the assetField = “pole.manufacturer” and the fieldValue equal to “Acme”. Note in this example, that the fieldValue is refers to the manufacturer element on the pole object. The requester shall use the dotted path to the data field of interest. For instance, if the requester is interested in obtaining all electricMeters with the meterStatus of “Installed”, then the assetField would be “electricMeter.meterStatusList.meterStatus” and the fieldValue would be “Installed”.")]
			[SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
			public assets GetAssetsByAssetField(string assetField, string fieldValue)
			{
				return null;
			} 

			
        #endregion

        #region Methods for Modification of AM data by external system



        #endregion


        #region Methods for  Publisher to publish Event Notification to AM(The subscriber)
            [WebMethod(Description = "Publisher notifies subscriber of a change in OutageDetectionDevice by sending an array of changed OutageDetectionDevice objects.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ODDeviceChangedNotification(outageDetectionDevice[] ODDevices)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of new power monitor output by sending the new PMChangedNotification.The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] PMChangedNotification(powerMonitor[] monitors)
            {
                return null;
            }

            [WebMethod(Description = "Publisher Notifies subscriber of a change in the Meter object by sending the changed meter object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterChangedNotification(meters changedMeters)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber to remove the associated meter(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY MeterUninstalledNotification IN V4.2.")]
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

            [WebMethod(Description = "Publisher notifies subscriber to Add the associated meter(s).Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterAddNotification(meters addedMeters)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber that meter(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.  THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterExchangeNotification(meterExchanges meterChangeout)
            {
                return null;
            }
			
            [WebMethod(Description = "Publisher notifies subscriber of meter event(s) by sending a meterEventList object.  Subscriber returns information about failed transactions in an array of errorObjects.  The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterEventNotification(meterEventList events, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber that meter(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterInstalledNotification(meters addedMeters, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber that load mangement device(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceExchangeNotification(LMDeviceExchange[] LMDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber that load management device(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceInstalledNotification(loadManagementDevice[] installedLMDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a change in a pole by sending the changed pole object. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] PoleChangedNotification(pole[] changedPoles)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a change in a transformerBank by sending the changed transformerBank object.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] TransformerBankChangedNotification(transformerBank[] changedXfmrBanks)
            {
                return null;
            }
            [WebMethod(Description = "Publisher Notifies subscriber of a received end device (meter) shipment by sending the changed endDeviceShipment object.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] EndDeviceShipmentNotification(endDeviceShipment shipment)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber that in-home display(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InHomeDisplayInstalledNotification(inHomeDisplay[] addedIHDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a change in the in-home display(s)by sending the changed inHomeDisplay object.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InHomeDisplayChangedNotification(inHomeDisplay[] changedIHDs)
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
            [WebMethod(Description = "Publisher notifies subscriber that in-home displays(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InHomeDisplayExchangeNotification(inHomeDisplayExchange[] IHDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber that connect/disconnect device(s) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceExchangeNotification(CDDeviceExchange[] CDDChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber that connect/disconnect device(s) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceInstalledNotification(CDDevice[] installedCDDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber to add the associated connect/disconnect device(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceAddNotification(CDDevice[] addedCDDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a change in connect/disconnect device(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceChangedNotification(CDDevice[] changedCDDs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber to remove the associated connect/disconnect device(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceRemoveNotification(CDDevice[] removedCDDs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber that the associated connect/disconnect devices(s)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] CDDeviceRetireNotification(CDDevice[] retiredCDDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber to add the associated load mangement device(s). ubscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
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

            [WebMethod(Description = "Publisher notifies subscriber that the associated load mangement devices(s)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] LMDeviceRetireNotification(loadManagementDevice[] retiredLMDs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a change in streetLight object(s) by sending the changed street light object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] StreetLightChangedNotification(streetLight[] changedStreetLights)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in securityLight object(s) by sending the changed security light object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] SecurityLightChangedNotification(securityLight[] changedSecurityLights)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies GIS of a change in trafficLight object(s) by sending the changed traffic light object(s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] TrafficLightChangedNotification(trafficLight[] changedTrafficLights)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber to add the associated in-home display(s). Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InHomeDisplayAddNotification(inHomeDisplay[] addedIHDs, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "Requests that subscriber process a set of meter exchnages. Subscriber returns information about failed transactions in the form of an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.THE USE OF THIS MESSAGE HAS BEEN DEPRECATED AS OF V4.1.5, IT WILL BE REPLACED BY InitiateMeterExchange IN V4.2.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] PPMMeterExchangeNotification(meterExchanges changeouts)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a change in work orders by sending the changed workOrder objects.  Subscriber returns information on failed transactions by returrning an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] WorkOrderChangedNotificationToGIS(workOrder[] changedWOs)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber that meter base(es) have been installed. Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseInstalledNotification(meterBase[] addedMBs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber of a change in the meterBase object by sending the changed meterBase object.  Subsriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseChangedNotification(meterBase[] changedMBs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber to remove the associated meterBase(4s).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseRemoveNotification(meterBase[] removedMBs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber that the associated meterBase(es)have been retired from the system.  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseRetireNotification(meterBase[] retiredMBs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber to add the associated meterBase(es).  Subscriber returns information about failed transactions using an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseAddNotification(meterBase[] addedMBs)
            {
                return null;
            }

            [WebMethod(Description = "Publisher notifies subscriber that meterBase(es) have been deployed or exchanged.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterBaseExchangeNotification(meterBaseExchange[] MBChangeout)
            {
                return null;
            }
            [WebMethod(Description = "Publisher notifies subscriber of a completion of tests on electric meters by sending an array of testedElectricMeters.  Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] MeterTestNotification(testedElectricMeter[] tests, string transactionID)
            {
                return null;
            }

            [WebMethod(Description = "The Inspection server publishes new or changed inspections to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The transactionID calling parameter links this published data method call with the InitiateInspectionRequest that resulted in this collected inspection data. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] InspectionNotification(inspection[] inspections, string transactionID)
            {
                return null;
            }
            [WebMethod(Description = "The CB server publishes changed service orders to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ServiceOrderChangedNotification(serviceOrder[] changedSOs)
            {
                return null;
            }
            [WebMethod(Description = "The CB server publishes new service orders to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ServiceOrderOpenedNotification(serviceOrder[] changedSOs)
            {
                return null;
            }
            [WebMethod(Description = "The CB server publishes closed service orders to the subscriber. Subscriber returns information about failed transactions in an array of errorObjects. The message header attribute 'registrationID' should be added to all publish messages to indicate to the subscriber under which registrationID they received this notification data.")]
            [SoapHeader("MultiSpeakMsgHeader", Direction = SoapHeaderDirection.InOut)]
            public errorObject[] ServiceOrderClosedNotification(serviceOrder[] changedSOs)
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

            #region Methods added as  part of Version 4.1.5
            ///
            /// New methods in Version 4.1.5
            ///

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

            ///
            /// End of New Methods in Version 4.1.5
            ///

           


			
        #endregion
    }
}

