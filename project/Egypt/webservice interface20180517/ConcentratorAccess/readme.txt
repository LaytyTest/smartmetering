We can set and get parameters on DCU by these interface.
Function of each interface are descripted by the file name.

Parameters can be configed by HES are listed below:        
                             |        HES set               |     HES get                     | keyboard    |  webserver     
1.  time                     |  req_settime.xml             | req_gettime.xml                 |  same       |    same      
2.  password                 |  req_SetPassword.xml         |     not                         |  same       |    same          
3.  terminal ID              |  req_SetId.xml               | req_GetId.xml                   |  same       |    same       
4.  event attribute          |  req_SetEventAttr.xml        | req_get_Event_Attr.xml          |  not        |    not       
5.  downlink route           |  req_SetDownlinkRoute.xml    | req_GetDownlinkRoute.xml        |  same       |    same        
6.  reboot DCU               |  req_rebootDCU.xml           |     not                         |  same       |    same       
7.  G3 route map             |       not                    | req_GetRouteMap.xml             |  not        |    not       
8.  event detail             |       not                    | req_GetEventDetail.xml          |  not        |    not       
9.  DCU version              |       not                    | req_ShowVersion.xml             |  same       |    same       
10. schedule task fail rate  |       not                    | req_get_schedule_task_info.xml  |  not        |    not       
11. uplink comm param        |  req_SetUplinkCommParam.xml  | req_GetUplinkCommParam.xml      |  same       |    same        
12. meter phase              |       not                    | req_get_meter_phase.xml         |  not        |    not
13. COM port status          |  req_SetComStatus.xml        | req_GetComStatus.xml            |  not        |    same      
14. menu function status     |req_SetMenuFunctionEnable.xml | req_GetMenuFunctionEnable.xml   |  not        |    same   
15. PSK GMK enable status    |  req_SetPskGmkEnable.xml     | req_GetPskGmkEnable.xml         |  not        |    not
16. push new meter enable    |req_SetPushNewMeterEnable.xml | req_GetPushNewMeterEnable.xml   |  not        |    not
17. usb enable status        |  req_SetUsbEnable.xml        | req_GetUsbEnable.xml            |  not        |    same   
18. crypt to key             |  not                         | req_TerminalSetCryptoKey.xml    |  not        |    not
19. GMK key                  |  not                         | req_SetGmkKey.xml               |  not        |    not
