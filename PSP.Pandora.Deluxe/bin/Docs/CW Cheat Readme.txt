cw cheat 0.2.2 REV.D by weltall (c) 2008 www.consoleworld.org weltall@consoleworld.org
----------------------------------------------------
ENGLISH
----------------------------------------------------
This is a prx which works under devhook and can cheat
every devhook-compatible game under firmware emulation
This works trought raw-relative cheat codes like
action replay, codebreaker, gameshark, xploder, etc.
Other than this, it has support to other function
which are usefull for cheat finder and normal users
(like battery, cpu/bus clock, devhook version, 
 ms free/total space information)

The latest updates are always available on
http://www.consoleworld.org and http://weltall.consoleworld.org
The latest database version is available from
http://cwcheat.consoleworld.org/ (main site)
If you make a cheat we would like to add it on the main database :)
if it's a long cheat or if you have a lot of cheats just contact me :)

if you found any bug just report it on mantis:
http://cwcheat.consoleworld.org/mantis/

This project originally started in march with some
simple tests of prx functionality (like loading 1.50
vsh) then with the help of sincro (which developed
a loader and a cheat searcher) it evolved in a cheat
device.
But later in April this was discontinued because I couldn't
anymore contact sincro and problems with runumd.
Then... devhook with firmware emulation came... and
also some prxs appeared... so i decided to take again
that project and i ported successfully it to devhook
as a builtin prx without any loader (so the old loader
was removed from the project) and now it works as a
in-game menu and cheat device.

-------------------------------------------------------------
INSTALLATION/MANUAL/EASY
-------------------------------------------------------------

1-copy the folders inside INSTALL (INSTALL_371 for 3.7x) in your memory stick main folder (eg: C:\ D:\ for those using windows)
2-power up your psp while pressing R
3-Select plugins
4-Press X over cwcheatpops.prx [POPS] it will say ENABLED
5-Press X over cwcheat.prx [GAME] it will say ENABLED
6-Press X over cwcheat.prx [GAME150] it will say ENABLED
7-exit recovery
8-when in game press select for x3 seconds to access the menu(default options which can be changed). 

-------------------------------------------------------------
INSTALLATION/MANUAL/IF YOU HAVE MORE MODULES ALREADY INSTALLED
-------------------------------------------------------------

1-copy the cwcheat folder in the seplugins folder from INSTALL or INSTALL_371 folder depending on your firmware (INSTALL_371 is for 3.71 only)
2-open pops.txt with a text editor and add this line: ms0:/seplugins/cwhceat/cwcheatpops.prx
3-open game.txt with a text editor and add this line: ms0:/seplugins/cwcheat/cwcheat.prx
4-open game150.txt with a text editor and add this line: ms0:/seplugins/cwcheat/cwcheat.prx
  (ms0:/seplugins/cwcheat/cwcheat150.prx for 3.71)
5-power up your psp while pressing R
6-Select plugins
7-Press X over cwcheatpops.prx [POPS] it will say ENABLED
8-Press X over cwcheat.prx [GAME] it will say ENABLED
9-Press X over cwcheat.prx (or cwcheat150.prx for 3.71) [GAME150] it will say ENABLED
10-exit recovery
11-when in game press select for x3 seconds to access the menu(default options which can be changed). 

-------------------------------------------------------------
DEVHOOK INSTALLATION/MANUAL [FIRMWARE IS THE FIRMWARE VERSION LIKE 310 303 ...]
-------------------------------------------------------------

1-copy the folders under INSTALL in your memory stick main folder (eg: C:\ D:\ for those using windows)
2-(optional) erase cwcheatpops.prx and cwcheat.prx from the seplugins/cwcheat folder
3-copy cwcheatdh.prx in /dh/(FIRMWARE)/F0/kd/
4-open the file /dh/(FIRMWARE)/CFG/pspbtcnf_game_dh.txt with a text editor
5-add $/kd/cwcheatdh.prx after $/kd/isofs.prx 
6-start devhook and enjoy
7-if there are problems move $/kd/cwcheatdh.prx after $/kd/amctrl.prx 
8-when in game press select for x3 seconds to access the menu(default options which can be changed). 

------------------------------------------------------
IMPORTANT NOTES:
- Users of 3.71 firmwares must update to at least 3.71m33-3 to be able to load cwcheat because of a missing functionality in the first two revision 
  of the cfw. HX firmwares from reports seems to be based on older revisions so they aren't supported.
- You can get a better experience with cwcheat, and not only with it, in 3.80/3.90 by using the msfatmod patch released by dark_alex.
  If you don't want to do it remember that if the led is blinking when you enter cwcheat menu don't do any file operation with cwcheat and
  ms size/space available is disabled.
- If the plugin doesn't load the problem lies in the your memory stick or your cfw configuration. As for the last one enable cwcheat from the recovery
  As for the first one get a better memory stick like sandisk ones (lexar are an example of widespread memory stick with bad problems in this area)
  or update to 3.90m33-2 where dark alex fixed the problems with these slow memory sticks
- If you have a problem or you don't know how to use cwcheat don't use mantis, the bug tracker, to ask questions. That's a bug tracker not a ticket
  system or whathever. Use the forum which is linked in the main page or the threads i do in the main scene sites. I normally check only development
  forums of them

------------------------------------

CHANGELOG:

0.2.2 REV.D RELEASE
=====================

- [ALL] Now > 4.x firmwares are checked for the sony msfatmod thread suspend bug and the check of the memory stick space is disabled to avoid a freeze
        situation.
- [ALL] Optimizations in the firmware checking
- [ALL] Added support in the gui for setting a button combination to open the text reader directly
- [ALL] Added the possibility to have cwcheat look after a certain adress and show changes happening to it (you can access it from the cheat search menu)
- [ALL] Updated the pointer searcher to allow use from the command line. These are the arguments it takes in order to use it this way:
        -cli <dump1> <dump2> <adress dump1> <adress dump2>
- [ALL] updated the toolchain to the latest version
- [ALL] Various optimizations which allowed to reduce the size of the binary

0.2.2 REV.C RELEASE
=====================

- [ALL] Fixed a timing bug which could lead to the dump function stop working after enabling the usb mass device because the memory stick device
        wasn't mounted when the dump was taking place: making the function fail.
- [ALL] Removed some optimizations which made some regressions (rev b')
- [ALL] Changed slightly the behaviour of pointers codes. now the q part is effectively usefull by itself (this change is be needed for upcoming cheats)
- [ALL] Now if connected to an hotspot like connection (so a connection requiring the browser to login in the network), the db downloader will
        automatically open the browser to let you login upon connection. Making so possible to download the database trough this type of hot spots
	(available only on 3.x build)


0.2.2 REV.B RELEASE
=====================

- [ALL] fixed a bug in RemaPSP about buffernegative functions which returned invalid values being returned.
- [POPS] Now REMAPSP works perfectly in POPS
- [ALL] Various optimizations in the remaPSP initialization code which reduced the size of more than 200 bytes
- [ALL] Some optimizations in the memory edit/disasm functions which reduced the size of more than 32 bytes
- [ALL] Added a check aganist tries to open a non existant text file with the text reader
- [ALL] Various size optimizations in the cheat search functions which reduced the size of more than 232bytes
- [ALL] Now it's possible to define a key combination to access directly the text reader from in-game. You can define the buttons by adding them
        to the "TEXTREAD BTN = " entry in the configuration file.
- [ALL] Optimized the functions checking for key combinations. This reduced the size of more than 818bytes

0.2.2 REV.A RELEASE
=====================

- [ALL] fixed a bug in the difference search which could lead to an evaluation error making the difference function unusable 
        in the case that the game allocates more than entire user ram -  50kbs
- [ALL] Removed allocation of user ram for the difference search. This should increase compatibility with never games and reduced the plugin size of about
        200bytes. 
- [ALL] Various optimizations in the controller management in the menus, additionally some menus now auto repeat just like most. This alloved to reduce
        the size of the plugin of 632bytes
- [GAME] Added multilevel pointer codes. This will allow you to track a point in ram by going trough a series of pointer like those seen in god of war.
        this is the code type:
	0x6aaaaaaa 0xvvvvvvvv
	0xqqqxnnnn 0xiiiiiiii
	0×Swwwwwww 0×Swwwwwww
	[...]
	0×Swwwwwww 0×Swwwwwww
	a = the starting pointer
	v = the value to store at the found point at the end
	q = the offset to add to a each loop(x4) most probably you want this to be zero in this case
	x = pointer type (check the normal pointers)
	i = offset to add/subtract (depending to x) from the last pointed area in the pointed chains to find were to put v
	n = number of times to point (you must start counting from one, so if the level of pointer you want to do is 2 you put here 2 if it's 3 you put
            3, the first pointer is considered first level, so if you put two offsets in the third line the value you need is 3)
	S = offset type to find next pointer (2 for normal offset(+w), 3 for inverse offset(-w))
	w = offset from the last pointed area to find the next pointer
- [GAME] some performance optimizations to avoid unnecessary repeated loops and assignments in the pointer codes
- [ALL] reworked, yes again, the db downloader now the 3.x version is libhttp based so it should work better. Plus various enhacements were added and some
        additional checks and functions. No changes for the 1.x version.
- [ALL] removed some repeated code this reduced the size of the plugin of 916bytes
- [ALL] now last text file opened is reopened when you go to the text reader


0.2.2 RELEASE
=====================

- [ALL] Now cwcheat checks if you are using the ms driver patch by dark alex which uses the 3.7x prx on 3.8x/3.9x and disables protections enabled
        in the main menu to avoid the bugs of the original 3.8x/3.9x driver. I suggest installing the 3.7x driver if possible.
- [ALL] really added the polish translation by Bolec. (there was a wrong one in the release before this)
- [ALL] renamed 360- folder to ALL as it contains builds for all firmwares except 3.7x
- [PACKAGE] Renamed cwcheat-IRSHELL.prx to cwcheat-LOADER.prx as it's usefull also with other loaders
- [PACKAGE] Added a full cwcheat-LOADER.prx (ex cwcheat-IRSHELL.prx) build. The build available before is in the lite folder, it's called  
            cwcheatlite-LOADER.prx and should be used with irshell.
- [POPS] Added a pops prx for loaders (pratically irshell for now as far as i know). It will start in homebrew mode but you can make it 
         load the pops game id by pressing the same combination as the one used in the psp game prx for loaders in the cwcheat main menu: L TRIGGER + SELECT
         This new build is called cwcheatpopslite-LOADER.prx and it's in the lite folder.
- [ALL] Now the db downloader resolves by itself the ip adress of the server so if the ip changes some times in the future it will always be able to
        resolve the new ip without an update
- [ALL] various cleanups to the db downloader thanks to insertwittyname for some missing things in the sdk
- [ALL] Added some checks for null in the db downloader
- [ALL] db downloader was ported to 3.x kernel. The 3.x version features also a skippable netconf dialog to choose the wanted access point
        (if you don't need it or have problems with it just cancel it and the old behaviour, connect to first ap configuration, will be applyed)
- [ALL] Added a check in the db download for errors returned by the server and used msgdialogs (3.x build) to show some possible errors
- [ALL] (3.x build) Added a check for a bigger database in the memory stick than in the online database. If this happens the user is asked if he wants
        to overwrite it or not.
- [ALL] fixed some bugs in the db save function
- [ALL] now it's possible to relocate the cpu load/fps in game display to the top left position: put a CPUFPS POS   = in the config file and set it as 1
        to enable it
- [ALL] fixed a little bug in the memory dump function which could lead to the first dump being always overwritten when the memory stick was full
- [ALL] now when dumping the ram to the memory stick, even if cwcheat was just started up again, it won't overwrite the dumps starting from 0 but
        will start from the first empty dump slot (note this doesn't affect the dump done by the difference search functions).
        This will be usefull for searching pointers (or more commonly called DMA codes...)
- [ALL] Added an SDK for cwcheat which allows to access some functions which were exported by the plugin for more than one year. It consists of a
        library and an header providing informations on the exported functions.
- [PACKAGE] changed the file structure. now the old MS_ROOT* folders are called INSTALL* to avoid confusion in new users. Plus the plugin prx were moved
            to the cwcheat subfolder of seplugin to increase order and reduce difficulty of manual install. According to these changes the installation
            instructions were changed and now are easier. If you use an old guide keep this changes in mind when following them.
- [ALL] Added a new pc based application pointer searcher built for both linux (tried on ubuntu 7.10) and windows (tried on vista/2003) in gtk+2.0.
        This application will allow estremely easy pointer search: starting with two or more dumps you will be able to do various searches based
        on old results till you iron out the adresses you need. At that point the application can create easily pointer cheat codes for cwcheat:
        8/16/32bit and normal/inverse offset codes can be generated. It can be found in the PC folder of the package in the linux and windows sub folders.
       

0.2.1 REV. A RELEASE
=====================

- [ALL] Added a polish translation thanks to Bolec
- [ALL] Fixed a memory leak in the text reader
- [ALL] reworked partially cpu clock functions. now they will be able to work as expected also 3.80 without setting first 333/166 
        before changing values.
- [ALL] various optimizations in the cpu clock functions
- [GAME] Added four new code types. They are all test codes, but they check two adresses for ==, !=, >, <.
	 This is their format:
	 0xDaaaaaaa 0xXbbbbbbb
	 0xnnnnnnnn 0x0000000Y
	 a = adress to the left operand of the test operation
	 b = adress to the right operand of the test operation
	 X = test operation to be executed: 4 for equal, 5 for not equal, 6 for less than, 7 for greather than
	 n = number of lines to skip if the test fails
	 Y = bits of the operation: 0 = 8bit, 1 = 16bit, 2 = 32bit
- [GAME] Added support to homebrew identification: an hash is done out of the launched eboot and an id is assigned from there in this format
         HBxxxxxxxx. This will allow you to keep your homebrew codes separated in the database.
- [ALL] fixed a bug in the cheat deletion function in the select cheats menu which didn't copy correctly the various codelines of the cheat under
        the deleted one, leaving codelines of the deleted cheat in place of the cheat under it.
- [ALL] the informations on the main menu about the memory stick total/available space was disabled for the 3.80+ firmwares
        because of a bug in the firmware which could lead to freeze. This was done as a temporary solution till a workaround to this problem is found.
        If, after opening the in game menu, the ms led stays blinking, don't do any file operation: reload/save db, save setting, search operations,
        selecting a remapsp. If you need those go out from the menu and reopen it in a time while the ms led isn't blinking. This doesn't affect older
        firmwares
- [GAME] some little fixes



0.2.1 RELEASE
=====================

- [ALL] Added a cpu load counter it can be shown with or in place of the fps counter on the top right. You can enable it from the settings menu.
- [ALL] Added a dynamic clocker. It will change dynamically the cpu clock depending on cpu load. It's extremely flexible thanks to the 8 variables
        managing it which can be choosen by editing the cwcheat.ini (the default plan should be quite conservative on higher cpu frequencies but you
        can make a more agressive one by choosing correctly the values there). This will be very usefull to increase battery life while keeping the psp
	softwares/games/vsh from stuttering. You can enable this by setting the cpu clock as -1 in the main menu.
        There are various variables here's the explanation of them and in the ( ) the default value of them:
	( 56)INCREASE MHZ  - this is how much the frequence will be increased each time
	( 33)DECREASE MHZ  - this is how much the frequence will be decreased each time
	( 80)INCREASE LOAD - when the cpu has a load greather than this the dynamic clocker will be triggered
	( 40)DECREASE LOAD - when the cpu has a load less than this the dynamic clocker will be triggered
	(  0)INCREASE WAIT - This is the time in seconds (0 = immediate) which the dynamic clocker will wait with the load greather than "INCREASE LOAD"
                             before changing the clock
	(  5)DECREASE WAIT - This is the time in seconds (0 = immediate) which the dynamic clocker will wait with the less load than "DECREASE LOAD"
                             before changing the clock
	( 36)MIN MHZ       - This is the minimum mhz the dynamic clocker will be allowed to set, it won't go down more
	(333)MAX MHZ       - This is the maximum mhz the dynamic clocker will be allowed to set, it won't go up more
- [ALL] If the fps counter is enabled the changes in frequence will be shown if the dynamic clocker is enabled
- [ALL] Various optimizations in the menu in the cpu clock options
- [ALL] Reduced a bit main thread priority
- [ALL] Now it's possible to read data about space available/total correctly on > 4gb memory sticks
- [POPS] Fixed memory manager english strings so they aren't shown anymore as plain black
- [POPS] added proper support in pops in the memory editor. Before it was going out of psx ram area
- [POPS] added proper support in pops in the disassembler. Before it was going out of psx ram area
- [POPS] Added support in the memory editor to generate codes compatibles with the pops cheat engine
- [POPS] Added support in the disassembler to generate codes compatibles with the pops cheat engine
- [ALL] fixed a missing translation in the disassembler
- [ALL] fixed a problem with > 4gb card which may prevent the dump function from working on these sticks
- [ALL] Added swedish translation thanks to tostoo
- [ALL] Fixed a problem in an italian string
- [ALL] Some fixes for 3.80m33
- [GAME] now the nnnn part of pointer codes will be taken in consideration so it must be 1 for normal codes and > 1 for codes with an extra pointer line
- [GAME] Improved pointer codes and added a new codeline to them if nnnn > 1
	 There are three types of additional codeline.
	-The first is the null one, this type is just 0x00000000 0x00000000 and it's used if you want to just use the new qqq part of the pointer codes.
	 it will add each loop declared by n  the q*4 offset to the adress to load the base starting with a. This is usefull if the game
         stores pointer near each other.
	-The second is the multi adress pointer write. It let you do what was done before with multiadress write codes but with pointers
	 0x6aaaaaaa 0xvvvvvvvv
	 0xqqqxnnnn 0xiiiiiiii
	 0x9sssssss 0xwwwwwwww [works only on n >= 2]
	 a = adress to load 32bit base from
         v = value to store in the calculated position
	 i = 32-bit offset to add/subtract to base
	 x = pointer type 0 8bit, 1 16bit, 2 32bit, 3 8bit inverse, 4 16bit inverse, 5 32bit inverse
	 n = number of times to point (n starts with 1 when the code should do only one loop and so should not have an extra pointer code line),
	     before this was ignored so there are some invalid codes with 0 here, they won't execute in this case, if in the db, please report 
	     to me else notify who made then. To fix them you just need to place an 1 as last digit eg: 0x00040001
	 q = offset to add(*4) to a (adress) to load the base from at each loop (n > 1). 
	 s = offset to add(pointer type 0,1,2)/subtract(pointer type 3,4,5) to base each loop (it's valuated like this: base+/-offset*loopnum*bytes(1,2,4))
	     where loopnum is zero for first loop
	 w = value to add to v each loop (it's valuated like this: v+loopnum*w) where loopnum is zero for first loop
	-The third is the pointer copy byte. This type will change slightly the functionality of the pointer code:
	 0x6aaaaaaa 0xvvvvvvvv
	 0xqqqxnnnn 0xiiiiiiii
	 0x1sssssss 0x00000000
	 a = adress to load 32bit base from (source)
	 x = 0 (this is no more pointer type)
	 v = number of bytes to copy (0 won't copy any byte)
	 i = 32-bit offset to add to base (source)
         q = offset to add to aaaaaaa to load the base(*4) (destination)
         n = 2 (this is fixed)
         s = 32-bit offset to add to base (destination)

NOTE: texts were updated again so you must update your language file, if you use any.
NOTE2: for 3.80 i suggest updating to at least 3.80m33-2 and using the prx inside 360- / MS_ROOT folder, if you don't want to update use the
       371 / MS_ROOT_371 folder
NOTE3: if you want to make the dynamic overclocker work correctly with all the cpu frequences (up to 333mhz) it's suggested to set the bus frequence
       to 166 else you will be limited to a maximum in cpu clock(it's just a simple rule don't take this as a perfect comparation) of bus * 2
         

0.2.0 RELEASE
=====================

- [ALL] now it's possible to change clock > 222/166 on 3.71+ firmwares. thanks to dark alex.
- [ALL] now 3.71+ builds requires 3.71m33-3 or never because of required patches available only from that version
- [ALL] changed drive checking method: now it should be almost immediate in the initialization (no more waiting) and even in a more safe way
- [ALL] The new drive checking method made possible removing various checks introduced before because they became useless reducing so the prx size
- [IRSHELL] Now (in irshell builds) the drive (or emulated one) is checked everytime you open the menu so when you start the game in irshell 
            (or other loaders which works in a similar way) the next time the menu is opened the game db is automatically loaded accordly. 
- [ALL] fixed an optimization glitch which blocked the usb function from being disabled
- [ALL] some code about usb was removed from builds with usb disabled
- [ALL] fixed a little glitch which made the cpu frequence option go from 333 to 266 without going trough 300, optimized also a bit the code managing it
- [ALL] now when you add a new cheat in the cheat selection menu a number is put after the "NEW CHEAT" name, like if you searched for it
- [ALL] Fixed some texts to be more proper and have a better case
- [ALL] now never texts are translatable using the classic cwcheat.lng in the cwcheat folder.
- [ALL] Added norwegian translation thanks to blackrave
- [ALL] Updated italian translation.

N.B. Older language files are now uncompatible, if you have done one before which isn't in the package please tell me so i can add your language
     file to the database for quick generation in case of change of positions of things in the file. Users should grab the new for language file
     from the package and replace the one they were using before.


0.1.9 REV.I RELEASE
=====================

- [GAME] fixed a bug in the 8bit equal test code which could prevent it from working
- [GAME] fixed a bug in the less than/multi skip codes which could make greather than/multi skip codes being recognised also as less than/multi skip
- [ALL] now it's possible to invert the colors used on screen (so black foreground on white background) trough the "COLOR INVERT = " entry on the
        configuration file
- [GAME] Added 8bit multiple skip test codes:
         8-bit Equal : Multiple Skip	        0xE1nndddd 0x0aaaaaaa
         8-bit Not Equal : Multiple Skip        0xE1nndddd 0x1aaaaaaa
         8-bit Less Than : Multiple Skip        0xE1nndddd 0x2aaaaaaa
         8-bit Greater Than : Multiple Skip 	0xE1nndddd 0x3aaaaaaa
- [ALL] Changed some buffer sizes in the db loading functions, it should improve the stability when loaded with other plugins
- [ALL] Some minor optimizations in the main in-game menu
- [GAME] rectified multiple skip test codes to be more strict about the status of > or < of the numbers being checked. now equal is no more considered
- [GAME] rectified single skip test codes to be more strict about the status of > or < of the numbers being checked. now equal is no more considered
- [GAME] Fixed a conflict of the inverse jocker code with the 8bit test codes. Now the inverse jocker code is 0xD00000dd 0x3nnnnnnn, while before it was
         0xD00000dd 0x2nnnnnnn.
- [GAME] Removed useless checks in the single skip test codes and jocker codes
- [ALL] now the text reader let the user use the analog stick to scrool text

NB: if you find cheats with single/multiple skip codes which aren't working anymore you may try adjusting the value of +/- 1 and contact me to fix the code
    in the database, thanks. As for the inverse jocker codes contact me again if you find some in the databse :).

0.1.9 REV.H RELEASE
=====================

- [ALL] increased priority from 0x64 to 0x32 to resolve the problems with "crash of the titans" which let cwcheat run it's thread only sometimes, making
        extremely difficult to call the cwcheat menu or other features.
- [POPS] fixed a check in the search for a difference in the cheat searcher to be proper in the pops build. Previously it blocked this function from
         working.
- [ALL] now the in game menu is cleared before going out from it.
- [ALL] Added a check to avoid entering the cheat mod menu if there are no cheats in the list
- [ALL] Major speed improvement in the fixed value search. A search for zero which took before 55 minutes now it takes just 10 minutes (550% faster)
- [ALL] Major speed improvement in the diff value search. A search for equal just after a first dump took before 1 hour and 50 minutes now it takes just
        15 minutes (733% faster)
- [ALL] applyed speed improvement changes also to the text search function but the improvement wasn't tested
- [ALL] Reduced prx size by about 500bytes from improvements in the search functions
- [ALL] Added a check for the user to release the SQUARE button while selecting found adresses, in this way it won't go directly to the disasm screen
        but let also check the memory editor (without using the cancel button)


0.1.9 REV.G RELEASE
=====================

- [GAME] Added a new code type: inverse jocker code. It works just like the jocker code but it skips specified lines if the specified buttons are
         pressed. 0xDnnnnnnn 0x2vvvvvvv n = number of lines skipped (n= 0 => 1) v = keymask
- [GAME] Corrected a little glitch in the 32 bit increment/decrement codes which could lead to them not being recognised by the engine. 
- [GAME] various optimizations on bitwise operators codes
- [ALL] now the text reader allocates it's buffer on the kernel ram if the screenshoot compatibility mode is enabled (default).
        For now this reduces the file size loadable when screenshoot compatibility mode is enabled.
        This is the first steep for the text reader file reading management rewrite to let a teorically indefinite file size while keeping the buffers
        as little as possible.
- [IRSHELL] in irshell builds Game name is cleaned when going in game mode, so if the game is missing in the db it won't be shown as "HOMEBREW"
- [ALL] Added a preliminar undo function in the cheat searcher. Press L while pressing X to enter the continue search to enable this.
- [PACKAGE] Separated the readme file in two files: one exclusively in english and one exclusively in italian
        

0.1.9 REV.F RELEASE
=====================

- [ALL] Added support for 3.71m33 firmware
- [ALL] added prxes for the 3.71m33 kernel lite and full for pops and game. Also an irshell one, altough irshell is not available right now.
        For 1.50 homebrews use the prx for 3.52m33 and minor even if on 3.71 kernel.
- [GAME] fixed a little glitch in the function checking the code type if pointer codes were used. Now the pointer codes will work also if not alone
         in the db
- [ALL] Removed a delay in the manual cheat apply which resulted in the application waiting 30 seconds before letting the user gaining back control
- [ALL] Reworked operations being made just before psp reboot (eg: home menu exit). This avoided crashes during this procedure as seen in the betas for 3.71
- [PACKAGE] Added an MS_ROOT_371 for easy installation on 3.71+ firmware
- [PACKAGE] now the prx for the various firmwares are on the 3.60- and 3.71+ folders


0.1.9 REV.E RELEASE
=====================

- [ALL] optimizations in the usb loading runtimes to avoid useless operations
- [ALL] added a ioctl call to update the fat with the current state of the ms when disabling usb support.
        This will avoid corruption and avoid loading files like if they weren't updated. thanks to Ahman for pointing
        it on ps2dev forums
- [ALL] optimizations in some key handling functions which gained 1456 bytes of space
- [ALL] fixed some checks for button release which weren't checking the button accordly to the swap button option
- [ALL] improved the jocker command (0xD00000dd 0x1nnnnnnn) in the standard cwcheat cheat engine it will allow to skip dd+1 lines 
        (so it keeps compatibility with old jocker codes) 
        [more information here: http://cwcheat.consoleworld.org/wiki/doku.php?id=english:code:psp_types#miscellaneous_commands]
- [ALL] Corrected some glitches when getting brightness values
- [ALL] Corrected chosen brightness levels to work better on a lite psp (100 on the lite was doing strange things, while 99 is the correct maximum)
        [thanks to moca for the testing]
- [ALL] Corrected a bug in the inverse offset codes which were pointing to a wrong adress before the start of user ram [thanks to black_wolf_92 for
        pointing the problem]
- [ALL] reworked a bit the pointer codes in the cheat engine: now if the feeded adress from the pointer is NULL (which may happen sometimes in games)
        the code will be skipped, plus the engine is now more optimized gaining 152bytes of space

0.1.9 REV.D RELEASE
=====================

- [PACKAGE] removed lite and normal homebrew prx as now it's useless
- [ALL] Now it's possible to go to the beginning of the opened text file by pressing START
- [PACKAGE] fixed some errors in the readme
- [ALL] removed all remaining things about the homebrew build in the source
- [ALL] various optimizations in the builtin strings
- [ALL] various optimizations in the text reader
- [GAME] Fixed USB MASS support in 3.5x game mode. Now you can access again the memory stick while playing you favourite game
- [SITE] now it's available a donation link for those who requested it http://cwcheat.consoleworld.org/donations.php
         differently from ads which are used just for paying the hosting, this will be a way to show the appreciation for my
         work and to make me able to buy new hardware for development

0.1.9 REV.C RELEASE
=====================

- [ALL] now the text reader supports up to 128 text files per id:
        Press L/R to go to the previous/next text file.
        The name is similar to how the cheat.db name works: 
        The first file is named with just the id.txt (just like
        now), all the others are the id + the number + .txt
	eg: with SLUS_12345 as id. The first file is SLUS_12345.txt
        the next SLUS_123451.txt,SLUS_123452.txt~SLUS_12345127.txt
- [GAME] Improved disc id detection runtimes and by putting a  
         new check for the mount status of isofs. 
         This improved cwcheat startup speed (were applyable) and 
         compatibility.
         This should also reduce the risk of the cheat list being
         corrupted.
- [ALL] Added detection of vsh mode. So now vsh has it's own id
        different from the one for homebrews.
        Cheats for vsh/vsh homebrews which were previously under
        the "HOMEBREW" id were moved in the new "VSH" id
- [ALL] Removed rendundant code from the function which cleared
        the screen upon entering the cwcheat menu (if enabled)
        This fixed also the brave story crash problem as before,
        most probably, some data stored in the vram was being
        overwritten.
      
      

0.1.9 REV.B RELEASE
=====================

- [DB DOWNLOADER] Updated the db download to work with the new server
- [GAME] added another check in the thread suspension runtimes to increase compatability with games in some cases
         (should fix ghoul and globin and brave story for those with that problem, altough it always worked fine for me)
- [IRSHELL] reduced the space alloched to db loading function to half (64KB). This will slow down db loading but should
            improve compatibility with irshell.
- [GAME] The game prx can be now used either in 1.5x 3.x homebrews, games and 3.x vsh without problems. it will
         automatically select if it has to start in homebrew or game mode. You can still force homebrew mode by using
         R during bootup or disable completely cwcheat by using L during bootup.
         The only difference in the homebrew prx now is the different config file. If no one really needs it i'm going
         to remove the homebrew build with the different config file in the next release.
- [ALL] fixed a little glitch in the goto function about the y position in the memory editor.
- [ALL] built with gcc 4.1.0


0.1.9 REV.A RELEASE
=====================

- [ALL] fixed a little glitch about brightness changing at boot up even with brightness control disabled if the
        default brightness level on the config was != 0
- [ALL] made various optimizations which made the prx go down of 1370 bytes
- [IRSHELL] added a special prx crafted for IRSHELL. It will load in homebrew mode and you are able to switch to
            game mode by pressing L TRIGGER + SELECT on the main menu. This will load the gameid and the database.
            When you go out from the game irshell will reset so even prx will be realoded, making cwcheat restarting
            in homebrew mode.
- [LITE] added a lite version of the build for IRSHELL
- [LITE] lite prxs were moved to a LITE subfolder in the package to avoid having a lot of prx on the archive root directory
- [ALL] now the cursor is positioned according to 
the inputted adress in the goto dialog even if not alligned with
        the shown bytes per line
- [ALL] the goto adress shown when you open it takes in consideration were you put the cursor 


0.1.9 RELEASE
=====================

- [ALL] now the text reader loads txt files from ms0:/seplugins/cwcheat/text/gameid.txt where game id is the id shown on
        cwcheat, it works just like memory cards or _S db entries. In this way you can store a txt file for every game.
- [ALL] now the text reader saves the old position upon exiting, in this way everytime you return to the text reader it
        will be were you left it, even if you reload the game. It will be saved as gameid.pos in the same dir of the txt.
- [LITE] added an homebrew only lite prx: it's called cwcheathblite.prx
- [ALL] moved config loading from the volatile partition to the kernel partition of the ram this should allow better
        compatibility with games/homebrews/vsh. GTA: LCS is working fine now even in m33 no umd modes (np9660/m33)
- [ALL] moved clock changing functions to the end of the cwcheat bootup process this increased compatibility with the vsh
        (now it's possible to use the homebrew prx or use R during bootup to load cwcheat even without umd and without
        freeze) and maybe also with homebrews and games
- [ALL] added a generic function to manage all numbers insertions in cwcheat (this is mainly backend)
- [ALL] implemented a goto function accessible with select in the memory editor: for now it's the only function using the
        generic number insertion function. (NB: it will search for the adress before the entered one alligned to the bytes 
        you can see in a line)        
- [ALL] fixed a bug in the disassembler which could lead to it going before the user mapped area when opening it making
        it crash.
- [ALL] now the cwcheat for homebrews can be installed easily as it's put in the MS_ROOT folder
- [POPS] now when entering the memory editor from the cheat mod menu the adress is managed correctly
- [ALL] now the memory editor and disassembler cleans the screen right when changing screens not only when exiting
- [LITE] added an POPS lite prx: it's called cwcheatpopslite.prx
- [ALL] the screen is cleared more in the disasm and memory editor to avoid parts of the memory editor, cheat modifier or
        disassembler remaining on screen
- [ALL] fixed a bug which could make the disassembler crash when making a new cheat if entered from the memory editor while
        selecting a not 4byte alligned adress



0.1.8 REV. C RELEASE
=====================

- [POPS] removed some useless debug information in the memory card manager in case of operation successfull
- [POPS] added a clear/format option in the memorycard manager. It will make your memory card empty just like if it was new.
         (if you use this by mistake remove your memory stick and power off the psp directly to avoid accidental
          save of the new memory card status)
- [GAME] added reverse offset pointer codes. They work just like normal pointer codes but the offset is subtracted and
         not summed like the normal ones. 
	 The format is the same except a little difference in the second adress line:
         8bit pointer inverse code 0x6aaaaaaa 0x000000vv 0x0003nnnn 0xiiiiiiii
	 16bit pointer inverse code 0x6aaaaaaa 0x000000vv 0x0004nnnn 0xiiiiiiii
	 32bit pointer inverse code 0x6aaaaaaa 0x000000vv 0x0005nnnn 0xiiiiiiii
- [ALL] added shortcut rappresentation to the disassembler. You can enable it by putting DISASM SHRCUT= 1 in the config file
- [GAME/150] altough homebrew mode was available since one year ago (by pressing R while booting up with a game prx)
             now with m33 supporting a separate game150 mode for plugins i've made a prx which automatically goes in
             homebrew mode and uses a different config file to keep configurations separated easily.
- [ALL] fixed a bug in the difference search which made it unusable
- [ALL] now it's possible to access the disassembler from the memory editor by pressing SQUARE. The nearest (backward way)
        4byte alligned adress will be selected as the first adress in the disassembler
- [ALL] changed the button to make new cheats from the memory editor: now it's TRIANGLE
- [ALL] now it's possible to edit values directly in the memory editor. This will allow you to edit values without
        having to make cheats. To enable value editing press your confirm button (which is CROSS or CIRCLE if you swapped
        buttons in cwcheat) this will allow you to edit the selected value with UP/DOWN. 
        Then confirm with CROSS (or circle if you swapped buttons) and abort with CIRCLE (or cross if you swapped button)
- [ALL] now you can change the value in the memory editor of +/- 0x10 with RIGHT/LEFT

0.1.8 REV. B RELEASE
=====================

- [ALL] now the selected row and column are marked to allow easier use of the memory editor
- [ALL] added a check aganist a case were a firmware function could return a NULL pointer making cwcheat crash the psp
        with the FPS counter enabled in some games when showing videos
- 0000023: [ALL] fixed the position of data entry lines when float was selected with the diff and fixed value searches
- 0000015: [ALL] added some checks in the diff search about unopenable/incomplete file to prevent crash during search when 
                 the ms is full
- [ALL] now when you leave the memory editor if you return to it from the cheat search menu it will go were you left it
        the last time
- [ALL] now it's possible to remove spaces in the memory editor by using MEMEDIT SPACE= # where # is 0 if you want to remove
        spaces and see the dump continuous (this will allow to have up to 23 bytes shown/line if ascii is disabled and up
        up to 17 bytes shown/line if ascii is enabled) and 1 if you want to have a space beetween the bytes
- [ALL] Added a disassembler
- [ALL] The disassembler can create 32bit codes starting from the currently selected adress with CROSS
- [ALL] The disassembler will allow to scrool of +1/-1 istructions (+4/-4bytes) with DOWN/UP and
        +1000/-1000 bytes with R/L
- [ALL] The disassembler can show either relative and not relative adresses in the adress column you can change this option
        by DISASM AABSL = 0/1 if 0 it will show the relative adresses just like the other modes else it will show the
        absolute ones. In any case internally the adresses will still be managed as relative so cheat making won't be
        affected by this option and will work regularly
- [ALL] The disassembler can show values(normally offsets or adresses) also in hex if DISASM HEXVAL= is set to 1 in the
        configuration file
- [ALL] When you leave the disassembler if you return to it from the cheat search menu it will go were you left it
        the last time
- [GAME] Removed improvement to support 3.40OE as they made 3.51 completely incompatible and restored older startup systems
         (cwcheat will startup later for now)

0.1.8 REV. A RELEASE
=====================
- [ALL] now there is an header with the index (addr, +byte, ASCII) in the memory editor
- [ALL] now it's possible to choose if ASCII should be shown on screen in the memory editor with ASCII ENABLE = 0/1 in the 
        CWCHEAT.INI/CWCHEATPOPS.INI
- [ALL] now it's possible to choose the number of bytes shown on screen in the memory editor (0-13 with ASCII enabled, 0-17 
        with ASCII disabled)with MEMEDIT BYTES= # where # is the number of bytes
- [ALL] added checks in the memory editor for the starting adress to avoid going out of range
- [ALL] added effectively L/R scrooling support in the memory editor. they will scroll of -/+ 0x10000
- 0000017 [ALL] added a simple text insertion method which you can navigate with LEFT/RIGHT and change text with UP/DOWN. 
        Middle dots are considered end of line, everything modifyied after then will be discarded.
- 0000017 [ALL] Now it's possible to edit cheat names. To do so press R TRIGGER + CROSS while selecting the cheat name you
        want to change. To discard changes press O (or X if you swapped buttons) and to confirm changes press X
        (or O if you swapped buttons)
- [ALL] now the cheat search menu will allow the user to press UP when selecting the first option to get to the latest one
        and viceversa (just like most of the other menus)
- [ALL] new options in the cheat search menu: start text search and continue cheat search. They are meant to start and
        continue a search for a text
- 0000017 [ALL] Added a text search system. It supports up to 30 chars, and can search ASCII/UNICODE/ASCII+UNICODE 
                encoding and can be case sensitive/unsensitive
- [ALL] The text search system can autosense if it has to make unicode or ascii codes (unicode codes skips the second byte).
	A codeline is made for each char and the current char is copied as value.
- [ALL] changed the space used by the db reading functions to <= 128kb (this space is alloched during bootup and freed after
        that)

0.1.8 RELEASE
=====================
- [ALL] fixed a bug which could lead to codes from other games/databases being put in the cheat list when loading
        a different database: this lead also to codes remaining in list, the game name not changing when reloading
        a db which contained the same game with a different name and other bad things made by data remaining and possible
	crashes
- [ALL] fixed various buffer overflows in the db reading functions regarding game and cheat name. This seemed to lead to
        strange behaviours with the screenshoot function for some users.
- [POPS] fixed a bug which could load ids of pops game launched before than the one being loaded if there isn't a cold
         boot beetween them or a psp game being loaded
- [ALL] added a memory editor which can show the ram in HEX/ASCII 
- [ALL] added to support to make cheats from a selected ram position in the memory editor (with x)
- [ALL] added support in the result screen of the cheat searcher to show the memory editor in the position of the found
        result (press [] to show it when selecting a found adress)
- [ALL] added support to show the memory editor from the edit cheat menu for fixed value write codes (0x0 0x1 0x2). (press
        /_\ to show the memory editor when selecting a codeline)
- [PACKAGE/GAME] Added a LITE version of cwcheat with all cheat search and memory editor functions removed. 
                 It's called cwcheatlite.prx.


0.1.7 REV. D RELEASE
=====================
- 0000009: [ALL] fixed automaking of a code for found trough float search which used 3 in place to 2
- [ALL] various optimizations to reduce file size in order to increase compatability with other prx
- [ALL] switched from -O2 to -Os which reduced size of ~15kb and didn't seem to do a noticeable change in speed
- [GAME] rewritten the initialization code which reads the id from the disk. Now it waits for the disk to be mounted
         without using time hacks. This increased compatability with slow umd drives/damaged umds in 3.40 OE systems
- [DB DOWNLOADER] updated to reflect the new server
- [DB] The db was cleaned removing some bogus codes which had zeroes on them or blank spaces: so now the db included
       in cwcheat is being updated again with the one on the site in each release
- [SITE] the site was moved on a faster host, the download section was fixed and now it's working again
- [SITE] Added a wiki documentation which will be expanded in the future and user can add things to it (translations
         are also welcome)
- [SITE] Added a bug tracked based on mantis. If you find a bug or something wrong with cwcheat or the site please
         file a bug report there. But report things correctly saying all the steps to reproduce it else they will
         be discarded


0.1.7 REV. C RELEASE

- [ALL] now it's possible to do pg up/down in the text reader (left/right)
- [ALL] optimizations and removal of various part of the code to reduce prx size
- [ALL] added an entry for the memory editor (disabled for now)
- 0000005: [POPS] now it's possible to use again the memory card manager functions with older pops loaded trough popsloader 
                 or with an old OE CF
- 0000001: [ALL] Fixed a buffer overflow in the remaps selection screen which could make cwcheat crash and show some 
                 graphic glitch when selecting a file with a long name. plus a better check for the file opening process 
                 was added 
- 0000002: [ALL] added float support in the fixed/diff search
- 0000003: [ALL] fixed the macro support which didn't work and crashed cwcheat while loading the macro. this was caused by 
                 an old reference to older folders which is now fixed. plus a check for the presence of the file was added 
                 to prevent crash with wrongly referenced macros
- added support to save (only 3.40)/read (all Firmwares) *.VME memory cards
- various fixes
- [SITE] added more checks in the cheat add functions
- [SITE] now it's possible to add cheats by pasting the db snippet of the game+cheats you want to add
- [SITE] fixed various glitches in the db, if you find something like "_L 0" "_L " "_L 0 0" or other wrongly
         formatted entries please report them
- [SITE] Added a lot of missing images
- [SITE] removed various "cloned"/with bad id/with missing game name or id games

0.1.7 REV. B RELEASE - POPS FIX

- [POPS] added support for memory cards manager in 3.40OE

0.1.7 REV. B RELEASE
-fixed the mc manager function. now it works even on 3.30[POPS]
-fixed the db reloading, now it reloads the database
-added a cheatpops database by tandao2002
-fixed some texts around

0.1.7 REV. A RELEASE
-added again devhook support
-now the waiting time for opening the menu is always respected
-corrected the description of the settings menu
-adresses were the ram dump is allocated aren't checked by the diff search
-added support for 3.30OE
-fixed the functions used by the remapsp macro function
-fixed a little glitch which let the user select upper options in the diff search function
 after the search

0.1.7 RELEASE
-it's now possible to show the frame per second which are being rendered on screen by the game
 this can be enabled/disabled from the configuration menu (thanks to coldbird because he found
 the function which was hooked to make this possible) [ALL]
-the db reader was rewritten from scratch this should fix the problems which involved the db
 loading and let you load db without file size limit (tested with a 3,2MB db)[ALL]
-corrected a bug while adding a new codeline (some lines were zeroed) [ALL]
-corrected a bug with the db saving[ALL]
-various other fixes
-added a spanish translation by SiTWulf

0.1.6 REV. I for 3.10OE/ALL
-rewritten from scratch half of the mc management internal code
 so now mc should be found in all cases (all emulators/plugins) and
 most probably also in emulators still not out[POPS]
-now it's possible to remove codelines with SELECT in the cheat modification menu[ALL]
-now it's possible to add codelines with START in the cheat modification menu[ALL]
-other fixes and little modifications[ALL]

0.1.6 REV. H for 3.10OE/ALL
-added support for memory cards in the 3.10 pops emulator [POPS]
-fixed the MS_ROOT folder it had old plugins in the last release[ALL]

0.1.6 REV. H for 3.03OE/ALL
-added support for memory cards in the pops emulator if the new converter is used (with the homebrew DATA.PSP and
 no KEYS.BIN) either for the 303 and 302 EMU [POPS]
-now it's possible to remove a code from the select cheats menu: press R + TRIANGLE [ALL]
-now it's possible to add a new code from the select cheats menu: press R + SQUARE [ALL]
-added PSXMC2PSP [PACKAGE]
-other things and bugfixes[ALL]

0.1.6 REV. G for 3.03OE/ALL
-fixed the code type D1 there was a little bug [POPS]
-brightness reworked a bit now it should be more responsive [ALL]
-brightness is now saved and loaded from file 0 = disabled 1 = 25% 2 = 50% 3 = 75% 4 = 100% [ALL]
-fixed a little glitch in the id reading function which made cwcheat show om or rom when the executable
 was named PSX.EXE. Now PSXEXE is showed [POPS]
-added xploder code types 90, 70 and 00 [POPS]
-now it's possible to read gme memorycard (no save support ATM) press R to exchange gme<->mcr [POPS]
-added a build which loads codes from the kernel partition you can use that as a temporary fix for games
 which have problems with the volatile partition (like socom and nfs)[GAME]
-added back support for 302OE emulator memory cards now it's automatically detected if it's the 303OE emulator
 or the 302OE one
-prx for psp games is updated to latest functions [GAME]
-added 32bit search support for builds with GS/AR support: the output code will be a two line code [POPS]
-All was moved to ms0:/seplugins/cwcheat/ so the dh folder isn't needed anymore [ALL]
-battery temperature is now showed [ALL]
-other things [ALL]


0.1.6 REV. F for 3.03OE/POPS
-reworked the id loading function now it *should* work in any case
-now if selected 0 as cpu/bus mhz the clock isn't set and it's left to the sony emulator (SUGGESTED!)
-fixed memory card functions to work on 3.03 Emulator
-NOW USB SUPPORT IS AVAILABLE IN CWCHEAT (READ THE USB SUPPORT README)
-added a little faq in english
-fixed the db save functions
-now the mc loader/saver shows more information and shows if the operation went fine
-other things here and there

0.1.6 REV. E for 3.02OE/POPS
-fixed a little thing which for some game could make cwcheat not loading the id correctly
-fixed the directory were the db is saved from the cwcheat interface now it's saved in the correct folder
-new folder "mc" under /seplugins/cwcheat/
-fixed some reported things here and there

and now the most important thing:

-> BUILTIN SUPPORT to loading/saving epsxe (mcr) memory card to/from the psp emulator!!!
-> in this way you can load your own game saves from pc or psx/ps2 on the psp and viceversa! :)
-> but also go over problematic points in games.


0.1.6 REV. D for 3.02OE/POPS
-included two versions one with caetla/AR/GS codes 2.41+ (Suggested for users) and one with cwcheat codes
-a new caetla/AR/GS 2.41+ cheat engine was written from scratch. This permits you to use CAETLA/AR/GS codes
 without modifying them at all
-the db was moved to /seplugins/cwcheat/cwcheatpops.db, the config was moved to /seplugins/cwcheat/cwcheatpops.ini
-now the game is recognised by cwcheat and proper cheats are loaded from it. the id of the game is something
 like SLES_12345
-the 0x aren't required to input AR/CAETLA/GS codes so just put the code directly eg: _L 80015648 FFFF
-now the photo folder is created if not present this avoid crashes if it's missing while doing the screenshots
-fixed a bug with the brightness function
-code types supported 80, 30, 10, 11, 20, 21, 50, D0, D1, D2, D3, E0, E1, E2, E3, C0, C1, C2
-the cheat searcher function search in the psx ram only and outputs psx code types
-the dump function dumps only the psx ram
-reorganised various part of the code
0.1.6 REV. C for 3.02OE/POPS
-this is a special build only for pops (PSX EMULATOR)
-removed usb support as usb prxs aren't loaded in pops mode, maybe they can be loaded but to avoid flashing requirement
 i preferred this way
-removed all umd imports ( same as above)
-remapsp altough is still there (and sems to do something) is reported as not working it disables game input
-ID is forced to POPS
0.1.6 REV. B for 3.02OE
-removed devhook connections again (lol)
-removed the installer which is not necessary
-repacked to be adeguated to install on 3.02OE
0.1.6 REV. B for devhook 0.51+ w/3.x FINAL
-included a new installer for windows (.net) which installs automatically cwcheat and if required the database
-readded the menu opening delay
-rehooked clock functions to devhook
-added cpu clock 300mhz, bus clock 150mhz
-now devhook version is showed again
0.1.6 REV. B for devhook 0.51+ w/3.x BETA
-changed disc0:/ to isofs:/ because accessing disc0: provoched an instant crash when booting up the game
 ($ony protection?)
0.1.6 REV. B for devhook 0.50 w/2.8x
-removed the function which wait for the second set by the user before opening the menu
 because it isn't available anymore in kernel mode
0.1.6 REV. B for 2.71SE
-now it's possible to use both the screenshoot version (the high speed/less compatible,
 and the high compatible/slower version) just by changing the options in the config submenu
 NOTE: the high compatible version is default
-now it's possible to change the brightness by using the screen button (what's used normally
 to change brightness) and put the screen at 0% -> 25% -> 50% -> 75% -> 100% brightness
 NOTE: this is disabled as default so if you want it you must enable it under the config menu
0.1.6 REV. A for 2.71SE
-now the screenshoot function can work in two ways (the faster custum mode,
 and the more compatible mode from the screenshoot prx from nekokabu)
-for this version the screenshoot function is locked to the compatibility mode
 it will be setupable in a next version
-the clock is now changed when exiting cwcheat menu (it should fix games like burnout
 locking up cwcheat when changing clock sometimes)
-changed the installer with the coldbird one
0.1.6 for 2.71SE
-First port release, removed devhook dependencies, added builtin clock changing

[CORE PRX]
-No more screen flickering and real time update of data in the main menu
-fixed that graphic glitch appearing when putting out and in the ms
-cleaned up the menus of useless clear screen and print calls
-added support for 8bit and 16bit multiadress write
 it's the same as 32bit multi write but with a 0x8 in the place of 0x4
 and a 0x1 for 16bit and 0x0 for 8bit in front of the value entry (d)
 32bit
 0x4aaaaaaa 0xxxxxyyyy
 0xdddddddd 0x00000000
 16bit
 0x8aaaaaaa 0xxxxxyyyy
 0x1000dddd 0x00000000
 8bit
 0x8aaaaaaa 0xxxxxyyyy
 0x000000dd 0x00000000
-string optimizations
-support to select search intervals in the fixed value and diff search
-now swap buttons option is saved and loaded
-fixed a string were X was still showed even if the buttons were swapped
-fixed a bug which could lock up remaPSP if you tried loading macros (thanks to BAC for reporting this)
-now the screen is cleared before exiting the menu (usefull when cheating some tiff apps like tetris which keeped
 cwcheat menu in background and was a bit annoying, plus it can help avoiding games which shows cwcheat menu till
 they refresh the screen)
-added greather/less by than before in the diff search with R you can navigate the entry for the value
-now the db is loaded in the volatile partition (thanks to tyranid for unlocking it) so it can be up to 4mb (in teory)
-added screenshoot support: this is a custum implementation based on nekokabu sources which locks the game only
 for much less than a second. It proved to work fine everywere except in the browser with the menu opened.
 plus you can costumize the button for it (also this uses the volatile ram area)
-now when using the clear background function the screen is cleared also in those games which didn't permit to do it
 (eg: burnout)
-fixed a bug which could prevent you to go left while entering hex values in the fixed value search and cheat modify menu
-optimized a bit the code of the value insert dialogs
-the screenshoot button can be changed and saved to config file (NOTE: if you don't set any button it's disabled)
-cheat modification dialog has been redesigned (thanks to Haruyuki for the idea on how to change it), now all
 the codelines are showed contemporanely and with their adress, value in hex and value in decimal
 R changes COLUMS (address, hex value, dec value) L changes ROWS (codelines), X saves the modifications, O aborts them
 and DPAD just like before moves in the number and changes it
-fixed a buffer overflow which made remapsp auto enabling if the game name in the db was bigger than 30 chars
-now the game name can be up to 36 chars
-reworked the text reader: it can open files up to 1mb and scrool them up and down. it still requires some functions
 and the up botton requires some checks, but it works fine :)
-fixes here and there and optimizations


[INSTALLER]
-added support to DLX
-updated version

[DB DOWNLOADER]
-updated version

[PACKAGE]
-added german translation by Martek, spanish by Lezek and portogues by Coimbra.
-added translation utilities by Martek



0.1.5 RELEASE
[CORE PRX]
-done a lot of optimizations here and there gaining 7kb
-now you can traslate CWCHEAT (note cwcheat uses the classic printf font so you wont have chars like èò ect)
NOTE: you must put the file with your translation here: ms0:/dh/cwcheat.lng

-now you can access the cheat selection menu directly from the game without opening the main menu
-button swap support added: now it's possible to confirm with O and abort with X if enabled, or have the same
 configuration taken from your firmware register files (emulated firmware)
-returned to gcc 4.0.2 : gcc 4.1.0 proved being higly instable (and made prx with 2 more kb)
-now the diff search screen is cleared when searching
-fixed some games in which the button pressed while exiting from in game menu was passed to the game
-now the current value of a found adress by searching is copied to the new cheat for all search type
-now you can change the adress of a cheat by pressing L in the cheat modification menu
-main menu reorganized and a new config submenu
-not 4byte alligned 32bit costant write codes now works (usefull for condensing, performance are affected like
 with not 4byte alligned 32bit multi adress write)
-now you can abort search by pressing O for some times
-other little things

[PACKAGE]
-included french (thanks to stark), english and italian language files


0.1.4B RELEASE
[CORE PRX]
-fixed a bug which didn't permit the user to modify the value of an already present cheat
 or a new cheat found trought search
-fixed some quick help errors
-now the current value is copied to the new cheat when adding a cheat found by searching

0.1.4 RELEASE
[CORE PRX]
-now it's possible to scrool cheat by +/- 10 with RIGHT/LEFT
-now cheat scrolling is fixed and faster
-FIXED RAM PROBLEMS now cheats are alloched dinamically (altough the allocation is fixed for this version)
-now it supports 550cheats * 30 codes without glitches :)
-db loading moved to kernel ram (this wasn't a problem but better safe than sorry)
-diff search now uses available ram dinamically: it search for the most big chunch of ram and allocates it
-now you can load different dbs by selecting a number with LEFT/RIGHT when reload cheat database is selected
 and pressing then x (this is valid only for loading: writing and other functions still saves to the default db)
 db 0 (default) = cheat.db
 db 1 2 3 ... = cheat1.db cheat2.db cheat3.db
-now diff search works also if the games allocates too much ram
-now cheat value modification, cheat entry trought search and fixed search value entry use a better input method
 where you choose the number to modify with left/right and press UP/DOWN to add a 1 to it. if you want you can edit
 the number in hex mode by pressing R
-8bit conditional codes implemented they work like the original but with a 2 in the value:
 *8-bit greater than - TEST CODE - 0xDaaaaaaa 0x203000dd
 *8-bit less than - TEST CODE - 0xDaaaaaaa 0x202000dd
 *8-bit not equal - TEST CODE - 0xDaaaaaaa 0x201000dd
 *8-bit equal - TEST CODE -   	0xDaaaaaaa 0x200000dd
-cheat.db updated
-changes in the diff search gui text
-other optimizations
-thanks to tyranid for a function from psplink which helped me iron out those ram problems
-now it's possible to remove with a button press all the search data


0.1.3B RELEASE

[CORE PRX]
-correct a bug which overflodded the kernel ram if a game had more than 399 cheats and could lead to a crash
 (eg: monster hunter freedom eu)
-now 420 cheats are supported per game (now all mhf cheats can be loaded)
-now the remaps folder of remaPSP is moved to ms0:/dh/ before it was in ms0:/

[INSTALLER]
-removed the 0x0 from the GUI

[PACKAGE]
-added a french manual by stark from cfccar.com

0.1.3 RELEASE

[PACKAGE]
-added an application which permits to automatically download from the psp 
 the latest database (cwcheat db downloader)

[CORE PRX]

-now square function is written in the select cheats menu
-Now pressing L during the loading process (when you are on the please wait
screen, when you are on the PSP white loading screen... (depending where you
load cwcheat)) it's possible to terminate cwcheat and it won't be enabled till
vsh/game reload
-now pressing R enables HOMEBREW MODE. this mode skips the umd reading runtime
and search in the database for the signature HOMEBREW. in this modality you
can cheat usermode homebrew loaded trought devhook
-now the a jocker code type is supported
 this is the syntax 0xD0000000 0x1vvvvvvv where v is a value obtained by the
 sum of up to three controller command: check the MANUAL or pspcrtl.h in the
 sdk, PSP_CTRL_HOME, PSP_CTRL_MS, PSP_CTRL_DISC aren't handled
-optimization in the change buttons functions
-now it's possible to change the value to be searched by +/- 1000 by using R/L
 Buttons
-now it's possible to change the value to be modified by +/- 100 by using
 left/right button
-now it's possible to change the value to be modified by +/- 1000 by using L/R
 buttons
-Now to change codeline in the cheat modification menu you have to use TRIANGLE/SQUARE
-support for database saving for either games and homebrew. it saves modified
 values, added codes and if a code is enabled/disabled
-now supporting octals in the database up to 37777777777 before was 777777777
 remember to put a zero before octal numbers eg: 037777777777
-corrected a bug which prevented cheat apply abilitation/deabilitation
 controller combination to work with combinations of less than three buttons
-now when you enable the cheats with the combination it will be showed the
 status of the cheats (enabled / disabled) till the combination buttons are
 released and controller check delay has passed
-removed some old text in the controller change submenu 
-now scrolling in the cheat selection menu is faster
-fixed a small bug which could make 16bit greather than not working in some cases
-fixed a small bug which could make 16bit less than not working in some cases
-fixed a small bug which could make 16bit equal not working in some cases
-fixed a small bug which could make 16bit not equal not working in some cases
-fixed a small bug which could make copy bytes not working in some cases
-fixed a bug which copied in copy byte required bytes + 1
-ADDED REMAPSP BY DANZEL with all function of the standalone remapsp
-Remapsp can be enabled disabled from the ingame menu or trought a selectable combination
 disabling it will remove all hooks, enabling it will reload the remap txt file of the game
-the remapsp configuration menu is accessible from the ingame menu this won't affect screenshoot prxes anymore
-when you enable/disable remapsp you will see a text on the bottom of screen telling you if it's enabled or disabled
-remapsp can be automatically enabled at boot time if enabled in the configuration
-NOTE: it won't affect cwcheat controls and jocker code just like the psp vsh or psp home menu because it's an hook of
       usermode functions
-selected controller map can be saved as default and autoloaded if game specific map not found
-it's possible to dump to usbhostfs0:/ for more information check the MANUAL file
-now battery volt shows decimals
-now fw version is showed in the in game menu
-code clean ups
-various optimizations

[DB DOWNLOADER]
-Downloads automatically to the correct folder the cheat.db from the server
-the cheat.db is updated with the main sql database every 15 minutes
-thanks to bzip2 for the server side implementation
-it connects automatically with the first connection so make sure before launching this 
 that the wlan switch is up


0.1.2 RELEASE

[CORE PRX]
-now cheats are applied every 1/10000 sec (before was second*cheat delay)
-cheat delay is now control delay which mean how much seconds to wait
 before checking the keys combinations
-now priority is 0x64, before was 0x1 (this means less priority)
-now when entering the cheat selection it waits for the X buttons to be
 released (this caused the always Y first cheat when entering the menu)
-now the buttons which are keep pressed will be repeated also in the
 main menu
-now usb autostart is correctly handled and usb is enabled when the prx 
 is loaded
-corrected some graphic glitchs on the bottom of the screen of the main menu
-cheat DB format update: now the db can store also the enabled/disabled
 status of every cheat so it will automatically enable the cheats you
 choose.
 Now the old database format is deprecated: it still works but the support
 for it will be dropped on the next version
 The new format changes only the _C (Cheat) entry now it's _C# where #
 is a 1 (enabled) or a 0 (disabled). If another number is found the cheat
 will be disabled, if a space is found (only this version) the cheat will
 be read as an old format cheat. To update your DB just replace the _C
 with _C0 (or _C1)
-now it's possible to edit on the go directly from the cwcheat menu
 the value field of a code. 
-now the 32bit multi write code works correctly also if the adress isn't
 a power of 4. So condensed codes which didn't work before will work fine
-Now it's available a cheat search function from the game
-The cheat search function supports 8/16/32bit fixed value search
-Found adresses in the cheat search function are written to progressive
 file (pass0.txt, pass1.txt, etc.)
-You can return to game and then continue your search for codes.
-The resume fixed value search function shows the first 10 adresses
 found in the precedent search with the value of these adresses in
 hexadecimal and decimal format (usefull to avoid another search when
 you have only a little number of adresses)
-some optimizations here and there

[INSTALLER]
-changed the restore icon to a restore/update icon to avoid mistakes

0.1.1 RELEASE

[CORE PRX]
-now you can exit the main menu with O
-in the main menu if you press X on return to game (or O)
 the prx will  wait for you to release the x button. 
 In this way you will avoid not wanted keypresses when exiting
-in the submenus it will wait you to release O button when exiting
-now when you press up when you are on the first entry it will go
 to the last entry. If you press down when you are on the last entry
 it will go to the first entry
-in the cheat selection submenu you can keep a button pressed and it
 will automatically repeat so you can scrool large code list in less
 time
-Now dump are endless they will be made in different files till you
 finish the free space on memory stick then it will start again with
 the first dump
-added 33 mhz for cpu and 16mhz for bus
-added an enable usb function. it will load in game the usb mass function
 so you can access your ms while playing to make cheat quicker and without
 a card reader.
 NOTE1: it will be disabled while dump to be re-enabled after
 NOTE2: sometimes when writing to ms from pc the psp doesn't
        flush the cache so if you change the database it could
        still be not updated. if this happen a workaround is
        ejecting the memory stick and putting it in again.
 NOTE3: you need to disable usbhostfs to make usb mass work
-added "enable usb" options
-fixed some buffer overflow in the cheat.db parsing function
-now you can give to the game names up to 30 chars (before was 20)
-now you can give to the cheat names up to 30 chars (before was 20)
-now you can store up to 500 cheats for game (before was 400)
-other little things and optimizations

[INSTALLER EBOOT]
-updated included database
-updated included prx
-added option usb enable
-now you can configure cwcheat from the installer also without the cwcheat.ini

[CHEAT FINDER]
-now you can force 8/16/32bit search or keep to AUTO like before
-now 16/32bit search have the right endianess (little endian)
 so if you had problem with these searches before try again
-NOW IT'S IN ENGLISH AND ITALIAN!

0.1 RELEASE

[CORE PRX]
-support for some devhook function and configuration change
 (cpu/bus mhz, devhook version)
-in game menu with pausing of all the threads
-shows free space/size of the memory stick
-shows effective cpu/bus frequence
-shows advanced informations about the battery
 (charge %, time left, charging status, volt)
-reloading of the cheat database while in-game
 (usefull to find new cheats)
-support to change buttons for the principal function
 (menu opening, ram dumping, abilitation/deabilitation cheats,
  one-time cheat application)
-mini text reader (it can read text which can stay on the psp screen,
 the rest of the files will be truncated)
-one-time chat apply from menu
-cheat selection menu with abilitation/deabilitation of 
 single/all cheats and with cheat description, usable also ingame
-you can set a delay of the cheat application and check of pressed
 buttons (1-10 sec)
-You can set the cpu clock (0, 111, 222, 333) 
 e bus clock(0, 37, 54, 111, 133, 166) with immediate application.
-the menu mantains the game screen of the not overwritten areas:
 it's possible to disable this function
-you can enable/disable dump function
-you can enable/disable cheat application from the menu
-online gaming protection: if the wlan switch is on
 the cheats won't be applied
-shows game name (if present on the DB) and game ID
-supported codes(some couldn't be tested if they don't work for you
 tell me what goes wrong and a sample code to exploit the problem)
 *16-bit Greater Than : Multiple Skip 	Ennndddd 3aaaaaaa
 *16-bit Less Than : Multiple Skip 0xEnnndddd 0x2aaaaaaa
 *16-bit Not Equal : Multiple Skip 0xEnnndddd 0x1aaaaaaa
 *16-bit Equal : Multiple Skip	0xEnnndddd 0x0aaaaaaa
 *16-bit greater than - TEST CODE - 0xDaaaaaaa 0x0030dddd
 *16-bit less than - TEST CODE - 0xDaaaaaaa 0x0020dddd
 *16-bit not equal - TEST CODE - 0xDaaaaaaa 0x0010dddd
 *16-bit equal - TEST CODE -   	0xDaaaaaaa 0x0000dddd
 *code stopper  0xCaaaaaaa 0xvvvvvvvv
 *Time Command  0xB0000000 0xnnnnnnnn (based on cheat delay)
 *16-bit XOR - 0x7aaaaaaa 0x0005vvvv
 *8-bit XOR -  0x7aaaaaaa 0x000400vv
 *16-bit AND -	0x7aaaaaaa 0x0003vvvv
 *8-bit AND - 	 0x7aaaaaaa 0x000200vv
 *16-bit OR -	 0x7aaaaaaa 0x0001vvvv
 *8-bit OR - 	 0x7aaaaaaa 0x000000vv
 *[pointer command] 32-bit write	0x6aaaaaaa 0xvvvvvvvv 0x0002nnnn 0xiiiiiiii
 *[pointer command] 16-bit write	0x6aaaaaaa 0x0000vvvv 0x0001nnnn 0xiiiiiiii
 *[pointer command] 8-bit write	0x6aaaaaaa 0x000000vv 0x0000nnnn 0xiiiiiiii
 *copy byte	0x5aaaaaaa 0xnnnnnnnn 0xbbbbbbbb 0x00000000
 *[tp]32-bit Multi-Address Write 	0x4aaaaaaa 0xxxxxyyyy 0xdddddddd 0x00000000
 *32-bit decrement 0x30500000 0xaaaaaaaa 0xnnnnnnnn 0x00000000
 *32-bit increment 0x30400000 0xaaaaaaaa 0xnnnnnnnn 0x00000000
 *16-bit decrement 0x3030nnnn 0xaaaaaaaa
 *16-bit increment 0x3020nnnn 0xaaaaaaaa
 *8-bit decrement 0x301000nn 0xaaaaaaaa
 *8-bit increment 0x300000nn 0xaaaaaaaa
 *[t]32-bit Constant write 0x2aaaaaaa 0xdddddddd
 *[t]16-bit Constant write 0x1aaaaaaa 0x0000dddd
 *[t]8-bit Constant Write 0x0aaaaaaa 0x000000dd

 [t] tested and surely working
 [tp] tested but not with real codes
 For further information i advise this site:
 http://www.codemasters-project.net/portal-english/apportal/cmp_plugins/content/content.php?content.23
 (yeah it's the right section :P)
 
 NB: the codes are in the relative format from the start of the user ram area.
     So the absolute adress is relative adress +0x08800000
     To convert some cheat from the absolute format you need to
     subtract 0x08800000  from the adress of the code

-you can save the configuration which will be loaded every time 
 the prx is loaded (it's manually modificable and it's saved in
 /dh/CWCHEAT.INI)
-it works under all firmware which works under devhook

[INSTALLER EBOOT]
-works with 1.50 (1.00 isn't tested)
-contains all the necessary data in the eboot
-Copies automatically the prx, the included db on the correct folders
 (prx => /dh/kd/cwcheat.prx, db => /dh/cheat.db)
-adds automatically in the pspbtcnf.txt (vsh loading)
 and/or pspbtcnf_game.txt (in game loading) files the necessary data
-restore function which controls the prx file integrity and permits
 the restoration of the prx, of the db and of the calls to the prx
 inside the pspbtcnf.txt/pspbtcnf_game.txt files; it permits also
 to modify the installation and to load prx in different firmware
-configuration function for the prx (it's better the built in prx function)
-uninstallation function which erases the db, the prx and every call
 in the pspbtcnf.txt/pspbtcnf_game.txt in every firmware
-graphic by ale275

[CHEAT FINDER]
-Made by sincro
-search 8/16/32bit value with auto selection
-search in various pass with save of the result from every pass
 and creation of the db entry
-it can search differences beetwen dumps (major less values)

----------------------------------------------------
TODO:

-check if all the cheats type works
-adding games to the db
-code optimizations
-completing the text reader
-evolving the db format
-add name editing from psp
-others (I'm accepting ideas :P)

---------------------------------------------------------------------------
Credits:
Made by weltall
REMAPSP by danzel
original database implementation and pc cheat searcher by sincro
gfx by ale275
database website by zio`ale (http://cwcheat.zioale.it/)
croncheat (application server side to make the required files for the cwcheat db downloader) by bzip2 
pops database by tandao2002

thanks goes out to the betatesters:
-ale275
-WSagitt
-C10uD
-sincro
-Gigasonic
-ps2lover

thanks to the dbmantainer/betatesters:
-zio`ale
-jungleteck
-vincent_10_27
-Henry
-CanisLupus
-other i've missed (tell me :P)

thanks for some cheats goes to:
-radical dreamer (also for pointing some problems)
-stark
-nekokabu
-731
-sincro
-WSagitt
-UCF-Sal X
-bdragonomega
-cyx
-albert_jr2
-Haruyuki
-Xedecimal
-BlackDeath
-Sketch
-Tot31
-kenobi (also for pointing some problems)
-all the others (if you want yourself added put a comment with your nick on the online db
                 for a considerable amount of games and point it to me)

thanks to all the ps2dev community, to Tyranid, dot_blank, imk, danzel, insertwittyname.
thanks to BOOSTER for his devhook
thanks to you
thanks goes out to coldbird, Dan4o2, Adrahil, harleyg, Dark Alex,  zio'ale, sincro, gigasonic,
xkiller, LilKitty, alcahest, aldos.
and to the people who reported in the correct way problems in the forums

no thanks to those who copy this readme. you should learn to do things by yourself you just copied it and even didn't
try to rewrite or change it a bit just COPY & PASTED. you didn't even see that one part of the procedure
isn't needed anymore since 3.02 OE - A but you still reported it because you just copy & pasted and i left it to
see if you were copying and this has confirmed this.
Please learn to try things by yourself and don't copy from what you bash.

-----------------------------------------------------------------------------
Disclaimer

The cwcheat Program is free to use, but I retain ownership of it.

LICENSE GRANT

The author grants a non-exclusive license to use the program, free of charge, if the user:
Does not use the program for illegal purposes or aganist other licenses (like sony online gaming);
Does not try to cheat online;
Does not try to modify it;
Does not try to modify any part of the archive, of the text files and the applications itself;
Does not try to remove copyrights or change them.

People that for any reason do not fit the conditions above, are expressly forbidden to use the program.

In addition the software (cwcheat) is released AS IS this means that i won't take any responsability
about damages or data lost directly or indirectly by the use of this application or it's documentation
so use at your own risk and do backup as always when installing/uninstalling something.
Parts are under these conditions:
Copyright (c) 2005/2006  James F
Copyright (c) 2005/2006  Julian T
Copyright (c) 2006  Rasmus B
Copyright (c) 2005  John Kelley
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions
are met:
1. Redistributions of source code must retain the above copyright
   notice, this list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright
   notice, this list of conditions and the following disclaimer in the
   documentation and/or other materials provided with the distribution.
3. The names of the authors may not be used to endorse or promote products
   derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE AUTHORS ``AS IS'' AND ANY EXPRESS OR
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY DIRECT, INDIRECT,
INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

