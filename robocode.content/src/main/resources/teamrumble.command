#!/bin/sh
pwd=`pwd`
cd "${0%/*}"
java -Xdock:icon=roborumble.ico -Xdock:name=TeamRumble -Xmx512M -cp libs/robocode.jar:libs/roborumble.jar:libs/codesize-1.1.jar roborumble.RoboRumbleAtHome ./roborumble/teamrumble.txt
cd "${pwd}"
