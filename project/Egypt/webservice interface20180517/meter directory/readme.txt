1. We can use req_SetMeterDirectory.xml to config the meter directory on DCU
   3 actions are supported:
     1. Add: add some new meters to DCU.
     2. Cover: clear meter directory on DCU, and set the meter directory in request on DCU.
     3. Delete: delete meters which are in delete request list from DCU .

2. We can use req_SetMeterDirectory.xml to get all the meter address list on DCU. without detail information,only address.

3. If we need datail information of some meters, we can use req_GetMeterDirectory_selective.xml.