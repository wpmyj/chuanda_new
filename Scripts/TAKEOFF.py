﻿launch_altitude = 100

cruise_altitude = 200

takeoff_azimuth = 270

turn_direction = 0 #1 = right, 0 = left

#DONT MESS WITH ANYTHING BELOW THIS LINE

import sys
import math
import clr
import time
import System
from System import Byte

clr.AddReference("ByAeroBeHero")
import ByAeroBeHero
clr.AddReference("ByAeroBeHero.Utilities") # includes the Utilities class
from ByAeroBeHero.Utilities import Locationwp
clr.AddReference("MAVLink") # includes the Utilities class
import MAVLink

idmavcmd = MAVLink.MAV_CMD.WAYPOINT
id = int(idmavcmd)

pitch = 10
climb_ratio = 1.0/15.0 #1 meter descent for every 15 meters traveled
turn_dist = 200

lathome = MAV.getWP(0).lat;
lnghome = MAV.getWP(0).lng;

climb_delta = cruise_altitude - launch_altitude
takeoff_dist = (2.0/3.0)*(climb_delta/climb_ratio)
alt_mid = launch_altitude+(2.0/3.0)*(cruise_altitude-launch_altitude)

satellites = cs.satcount
hdop = cs.gpshdop

if satellites < 6:
	print'GPS FAILED.  NO MISSION CREATED. WAIT FOR BETTER GPS'
	print ''
elif hdop > 4:
	print'GPS FAILED.  NO MISSION CREATED. WAIT FOR BETTER GPS.'
	print ''
else:
	print'GPS PASSED.'
	print ''

	if launch_altitude < 50:

		print 'LAUNCH ALTITUDE LESS THAN 50 METERS'
		print 'NO MISSION CREATED'

	elif launch_altitude >100:
		
		print 'LAUNCH ALTITUDE GREATER THAN 100 METERS'
		print 'NO MISSION CREATED'

	elif cruise_altitude < launch_altitude:
	
		print 'CRUISE ALTITUDE LESS THAN LAUNCH ALTITUDE'
		print 'NO MISSION CREATED'	

	else:

		lathome = cs.lat
		lnghome = cs.lng

		rad_earth = 6378100
		circ_earth = rad_earth*2*math.pi
		deglatpermeter = 360/circ_earth
	
		rad_lat = math.cos(lathome*2*math.pi/360)*rad_earth
		circ_lat = rad_lat*2*math.pi
		deglngpermeter = 360/circ_lat

		lat_delta1 = math.cos(takeoff_azimuth*2*math.pi/360)*takeoff_dist*deglatpermeter
		lng_delta1 = math.sin(takeoff_azimuth*2*math.pi/360)*takeoff_dist*deglngpermeter		

		lat1 = lathome + lat_delta1
		lng1 = lnghome + lng_delta1

		if turn_direction == 1:
			turn1_azimuth = takeoff_azimuth + 135
			turn2_azimuth = turn1_azimuth + 90
		else:
			turn1_azimuth = takeoff_azimuth - 135
			turn2_azimuth = turn1_azimuth - 90			

		lat_delta2 = math.cos(turn1_azimuth*2*math.pi/360)*turn_dist*deglatpermeter
		lng_delta2 = math.sin(turn1_azimuth*2*math.pi/360)*turn_dist*deglngpermeter		

		lat2 = lat1 + lat_delta2
		lng2 = lng1 + lng_delta2

		lat_delta3 = math.cos(turn2_azimuth*2*math.pi/360)*turn_dist*deglatpermeter
		lng_delta3 = math.sin(turn2_azimuth*2*math.pi/360)*turn_dist*deglngpermeter		

		lat3 = lat2 + lat_delta3
		lng3 = lng2 + lng_delta3

		takeoff = Locationwp()
		Locationwp.id.SetValue(takeoff, int(MAVLink.MAV_CMD.TAKEOFF))
		Locationwp.p1.SetValue(takeoff, pitch)
		Locationwp.alt.SetValue(takeoff, launch_altitude)
		wp1 = Locationwp().Set(lat1,lng1,alt_mid, id)
		wp2 = Locationwp().Set(lat2,lng2,alt_mid, id)
		wp3 = Locationwp().Set(lat3,lng3,alt_mid, id)
		wp4 = Locationwp().Set(lathome,lnghome,cruise_altitude, id)
		MAV.setWPTotal(6) #set wp total
		MAV.setWP(MAV.getWP(0),0,MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT); #upload home - reset on arm
		MAV.setWP(takeoff,1,MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT); #upload takeoff
		MAV.setWP(wp1,2,MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT); #upload wp1
		MAV.setWP(wp2,3,MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT); #upload wp2
		MAV.setWP(wp3,4,MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT); #upload wp3
		MAV.setWP(wp4,5,MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT); #upload wp4
		MAV.setWPCurrent(1); #restart mission to waypoint 0
		MAV.setWPACK(); #final ack
		print 'AUTOGENERATED TAKEOFF MISSION'