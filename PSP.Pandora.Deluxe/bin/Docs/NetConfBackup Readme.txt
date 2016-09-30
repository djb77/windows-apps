NetConfigBackup
===============

Released by Noobz!

Official Website: http://www.noobz.eu
Official IRC:     #noobz on irc.toc2rta.com

This program is used to backup network configurations so that if the registry gets corrupt you can then restore the network configuration without needing to type in long WEP keys. Also this can be used to copy network settings from one PSP to another.

IMPORTANT NOTE: Backing up from 2.00+ and restoring on 1.50 may not work if WPA is used on the 2.00+ PSP


Installing
----------
In order to install please do the following for the appropriate firmware:

Firmware 1.00 and 2.00+
 - Copy 100/* <PSP Drive>:/PSP/GAME/

Firmware 1.50
 - Copy 150/* <PSP Drive>:/PSP/GAME/


Usage
-----
When the program is run you will have the option to either backup or restore, backup will produce a text file on the root of the memory stick called netconf.bak, this contains a text description of all the network connections that are present on the PSP. When restore is used it uses this file to generate new access points.

