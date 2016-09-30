 ******** UMDrip V4 - Art 2006 - 2008! *******

  The PSP program with the narrow readme file

 *********************************************

Hi Guys,

This program is intended for making backups of
legitimately owned UMDs to an ISO file on your
Memory Stick, in case the UMD should become
damaged, lost, or you wish to preserve it.
The result ISO file can be played with a game
loader, or launched directly with a homebrew
firmware hybrid by Dark_AleX.

The main advantages of UMDrip over similar
programs is that the ISO file is correctly
named, and placed in the appropriate directory
ready to play without the need to have a PC
available to rename the target file, and the
various checks that are carried out prior to,
and during the copy operation.

UMDrip does not place extra zero bytes on the
end of the ISO file as Fastloader 2005 does.
It seems that Fastloader always empties it's
complete copy buffer into the ISO file, even
if the UMD size was exceeded part way through,
relulting in an ISO file of a few kilobytes
larger than it should be.
The result file is also given the proper
extension so that it can be used right away.

Both of the real UMD sound effects used for
UMDrip, as well as the icon background ripping
paper sound were recorded with a PSP and the
Socom microphone headset with Audio Mechanica.
Sound was processed with Creative Wave Studio
for low noise playback through PSP speakers.
Audio Mechanica is another of my PSP programs.
Search for it on Google.

Usage of UMDrip is basic. The only supported
buttons are 'X', Square, and and 'HOME'.
Once you press'X', UMDrip will prompt for a UMD
to be inserted if the drive is vacant. Next,
the UMD game ID and disc size are requested by
the program, and displayed on the screen.

Now that the size of the disc is established, 
it is compared to the amount of free space left
on your Memory Stick to make sure there is
enough free space to write the entire ISO.

If there is not enough free space available,
UMDrip will display an error message, terminate
the operation, and return to the splash screen.

If there is enough space on your Memory Stick,
UMDrip will then check for the existence of a
folder by the name of "ISO" in your Memory
Stick's root directory. If it is not there, it
will be created, and then UMDrip will commence
writing the ISO file into that directory.

Backup progress is shown during the operation,
and the user is also informed when the disc rip
is complete. You can exit UMDrip with the HOME
button, but it is not wise try exiting during a
copy operation, as data corruption may result.

The Square button can be held down during a copy
operation to toggle a text progress display.

The UMD ID is used as the name of the target ISO
file. For game UMDs, this will be the code shown
on the UMD case spine. Here are some examples:

Archer Mclean's Mercury (European version):
ULES-00011
Gottlieb Pinball Hall Of Fame (US version):
ULUS-10052

In the case of UMD movies, this is often an
abbreviation of the movie title, for example:

Fun With Dick And Jane (Jim Carrey):
FUN_W_DICK
The Terminator (Arnold Swarzenegger):
TERMINATOR

Verification of result file is a possible for a 
future version of this program, since other UMD
ripping programs do not do it.
Another feature that might be nice to implement
is a button to abort the copy operation.

License to use this software is completely free
on the condition that it is used only to produce
backups of your own legitimately aquired UMDs.

************************************************

*Donations*

I have use for low capacity Memory Sticks to aid
in my PSP programming.
Please consider donating the 32Mb Memory Stick
that came with your PSP once you have upgraded.
You could have your name appear in the intro of
one of my applications to express gratitude.

************************************************

UMDrip is unofficial, and not endorsed by Sony.

This is not a public release.
Please do not spread this program on forums.
I will be released to the public at the end of
the PSP's commercial lifespan.
Please allow me to decide when I think that is.

Cheers, Art.

bmar8190@bigpond.net.au

http://forums.ps2dev.org/viewforum.php?f=14
http://forums.qj.net/f-qjnet-sony-psp-forums-48.html/
http://www.dcemu.co.uk/vbulletin/index.php
http://www.psp-programming.com/forums/
http://www.psphacking101.com/forum/index.php?c=1
http://www.austech.info/
http://www.freewebs.com/defxev/

************************************************

Version History:

UMDrip V4 (09/02/08):
Program is now user mode, and should now run on
many more PSP firmware variants.
Fixed problem of sometimes hanging at exit screen.
Program will try to close the Memory Stick file if
you exit during copy operation.

UMDrip V3 (12/12/06):
Implemented a custom sample player using the PSP
audio library to play CD quality sound samples.
Sound was resampled for the new player.
Mikmod audio library is no longer present.
UMDrip is now a stand alone eboot with no external
files.

UMDrip V2e (11/12/06):
Graphic data files are now packed into the eboot.
The Square button can be held down during a copy
operation to toggle a text progress display.

UMDrip V2d (25/11/06):
Tripled the resolution of the progress bar for
better indication, and visual appeal.
Partialy written ISO file is auto deleted if the
UMD door is opened while ripping a UMD.

UMDrip V2c (24/11/06):
Improved insert and remove UMD prompt screens
with flashing arrows. Added graphic ripping
screen with flashing arrow, and progress bar.
Added graphic dialogue captions.
Program checks UMD door is closed while ripping.
Added icon background title graphic.

UMDrip V2b (21/11/06):
Added graphic prompt, and animation for removal
of UMD.

UMDrip V2 (20/11/06):
Program aquires the UMD ID from the disc, and
uses it as the name of the result ISO file.
Re-recorded the "UMD out" sound.

UMDrip V1 (19/11/06):
First working version for private release.
Graphics and sound are only part way completed.
There is visible debug information that may later
be replaced by graphic and audio representations.

************************************************
