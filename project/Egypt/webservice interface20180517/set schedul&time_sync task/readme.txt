1. We can set schedule reading task config by req_SetGatherTask.xml, the new set will cover old schedule reading task config, and restart the schedule reading.
2. We can set synchonize time on meters' task info by req_set_adjust_meter_time_task.xml
3. We can set enable flag of synchonize time on meters'  by req_set_adjust_meter_time_authority.xml


Now we set when to read meters' time by 2, when the return time is out of the 5 minutes range, DCU send alarm to HES with meter address information.
If in the 5 minutes range, set meters' time depend on the enable flag of synchonize time on meters' which is set by 3.

If we accomplish the broadcast synchonize function. I think the interface 2&3 should be modified. we can discuss it later.