KeyCleaner v1.4 by Chilly Willy
===============================

To install, just copy the KeyCleaner folder in the archive to your memstick.
If you run this with HEN or on the Slim PSP, copy to the GAME folder. If you
use a custom firmware, copy to the GAME150 folder.

To use, run like normal homebrew. The first screen tells you the motherboard
and region to which the IdStorage is set. You then have three choices: exit
by pressing the CIRCLE button, analyze the IdStorage keys by pressing the
CROSS button, or dump the IdStorage keys by pressing the SQUARE button.

The first time you dump the keys, it creates a folder called 'keys', then dumps
the keys into it. If you choose to dump the keys again, the 'keys' folder will
be renamed, and a new 'keys' folder created. You can keep dumping the keys until
you have dumped them 10,000 times, or you run out of memory on the memstick.

If you press the CROSS button, you will be taken to the Analyze Keys screen.
You can choose to analyze the keys as if the motherboard were a TA-079/81,
as if it were a TA-082/86, or as if it were a TA-085. I made this selectable
in case the IdStorage keys identify the motherboard incorrectly. It will tell
you which motherboard it thinks it is in the top line. If you aren't sure,
press the SQUARE button to view a picture that shows how to tell which you
have. It is a picture of the back of a PSP (mine) with the UMD door open. The
red rectangle is the area of concern. If you have 'IC1003' printed upside down
on the motherboard in that area, you have a TA-082/86. If not, you have a
TA-079/81. Please note that all current Slim PSPs are TA-085. Press any key to
return to the Analyze Keys screen. You can choose 'Analyze TA-079/81' on a
TA-082/86, just don't choose to fix any keys it says are bad because it will
fix them as if the PSP were a 79/81. If you DO fix them as a 79/81, you can
select to analyze the keys as a TA-082/86 to fix them. The reverse is true
if you have a TA-079/81. Please don't mess with the keys on a Slim at this
time as only a few of the keys can be fixed with this version. Specifically,
keys 4, 5, 6, 0x42, 0x46, and 0x47. If you mess up any other keys, you won't
be able to fix them in KeyCleaner at this time.

If you choose 'Analyze TA-082/86' (then main reason you probably got this),
it will print a status of the keys associated with downgrading and tell you
if it thinks there is a problem. If you see 'Congratulations! Your keys
appear to be fine.', then your keys are fine. Note that 'fine' means key
5 has been patched using my method. If key 5 is patched a different way,
it'll tell you key 5 is bad and give you the option of fixing it. It isn't
REALLY bad, I'm just encouraging people to use my method of patching.

If the IdStorage isn't okay, with key 5 patched my way, it will check for
common corruption from downgraders. It currently recognizes the original
hard-down method, the original (2.71) soft-down method, and the NOOBZ (2.80
and 3.03) soft-down method. If the IdStorage matches one of those downgrade
methods, it then goes to the Fix Keys screen. You will be asked if you
REALLY wish to attempt fixing the keys. If you tell it to do so, it then
fixes all corrupted keys. This version of KeyCleaner can fix ALL the keys
without any files, so you don't need any other files as in previous versions.
If one of the common downgrader methods is not recognized, KeyCleaner then
checks certain individual keys that are commonly bad for one reason or
another. This version of KeyCleaner can fix keys 4, 5, 6, 0x42, 0x43, 0x46,
and 0x47. If key 0x46 or 0x47 don't exist, it will create it, then fix it.
Old TA-079 PSPs often are missing 0x46 and 0x47. That is fine - it is the
way those PSPs were. Don't feel you have to fix those two keys.

If the analysis shows all the keys to be fine, and key 5 patched with my
method, it will ask if you wish to unpatch key 5. Do NOT do that unless
you have the custom IPL or are running your TA-082/86 on official Sony
firmware with HEN (homebrew enabler) or you WILL brick the PSP! Given
Pandora has made changing the firmware easy, and bricks recoverable,
KeyCleaner has changed to reflect this. It can unpatch key 5 as part of
the visible main key handling so that people with the custom IPL or people
wishing to run 3.30 or newer Sony firmware have an easy way to clean up
their keys and unpatch key 5. If you aren't sure if your PSP will run
with an unpatched key 5, DO NOT UNPATCH IT!!

This version of KeyCleaner will load the background and text colors from
the file "textcolors.bin". If the file is missing, it will default to the
old color scheme - white text on a black background. The new colors in the
textcolors.bin supplied are white text on a warm blue background. The way
to change the colors is to load textcolors.bin into a hex editor and change
it as follows:

Byte 0: 00
Byte 1: red intensity for background (00 to FF)
Byte 2: green intensity for background (00 to FF)
Byte 3: blue intensity for background (00 to FF)
Byte 4: 00
Byte 5: red intensity for text (00 to FF)
Byte 6: green intensity for text (00 to FF)
Byte 7: blue intensity for text (00 to FF)

For example, the contents of the default textcolors.bin is:
00 20 60 A0 00 FF FF FF

Acknowledgements
================
This program was made possible by the efforts of many people. I'd like to
thank idstoragefix, codes02, Stapol, Mathieulh, harleyg, Jas0nuk, and Dark_AleX. If anyone
else thinks they deserve some credit, let me know. :)

Chilly Willy's email: ChillyWillyGuru@gmail.com
Chilly Willy's Ice Flow: http://groups.google.com/group/chilly-willys-ice-flow/?hl=en
