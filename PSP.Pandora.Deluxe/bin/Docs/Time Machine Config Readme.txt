This document explains how to use the file config.txt.
This file (config_read.txt) is not necssary, you can delete it if you want.

Limits:
- The file has a limit of 1024 bytes. If the file is bigger, only first 1024 bytes will be read.
- Lines shouldn't be more than 126 characters.
- Strings inside "" shouldn't be more than 64 characters.

Each line consists of two parts separated by the symbol "="

The left part indicates a button or a set of buttons separated by "+".
In the case a set of buttons is indicated you shouldn't put spaces between each button separated by "+".

Examples

L -> fine
L+START -> fine
L + START -> not fine

The buttons that can be used are followings:

UP -> Digital UP
DOWN -> Digital DOWN
LEFT -> Digital LEFT
RIGHT -> Digital RIGHT
TRIANGLE 
CIRCLE
SQUARE
CROSS
SELECT
START
LTRIGGER
RTRIGGER
L -> alias for LTRIGGER
R -> alias for RTRIGGER
HOME
WLAN -> indicates that the wlan switch is in "on" position. (usually you will want to use it in latest positions).
VOLDOWN -> volume down
VOLUP -> volume up
NOTE
LCD -> the brightness button
HPREMOTE -> The hpremote is plugged
NOTHING -> Indicates no keys. This doesn't mean that "no keys are pressed", but instead that the value is ignored.
           This value is useful for when you want the default action not to be the nand boot.
           This value should be used as the last one in the file, as it would make the condition to always be true
           and further lines would not be parsed.

All names can be upper case or lower case.

If an incorrect key name is detected, only the part read before is valid. For example:
TRIANGLE+WTF+CIRCLE -> is equivalent to TRIANGLE.



The right part contains the path of the ipl. The path must be enclosed with "". Do not use drive names
like "ms0:", there are no drives at ipl time!

You can use the path "NAND" to indicate NAND boot. (this can be useful used together with the key "NOTHING").

The format of ipl accepted by the iplloader is the following:
The first 0x3000 (12288) bytes are loaded to address 0x040e0000.
The rest of the file is loaded to address 0x040f00000

This format is not compatible with the pandora ipl and the DC1-DC4 ipl (which is same as pandora).
To convert that ipl, use the apropiated option in the Time Machine installer.
Future DC ipl's will be already in "Time Machine format".

The following characters can be used for comments: # and ;
Everything after those characters will be ignored (except if they are inside "")

Considerations:

The iplloader parser reads line by line until a match with the current key state is found.
If no match found, the nand ipl will be booted. Because of this, be careful with the following kind
of lines:

L+R = "/TM/150/ipl.bin";
L+R+START = "/TM/340OE/ipl.bin";

If the user presses L+R+START, when the parser reads the first line, it will check that the current
key state is OK, as L+R are pressed, and the 1.50 ipl will be loaded, instead of the 3.40 OE one, 
which was probably the desired action.

To resolve this kind of conflicts, put always the more restrictive things at beginning.
The following lines would behave as expected:

L+R+START = "/TM/340OE/ipl.bin";
L+R = "/TM/150/ipl.bin";

If a ipl file is not found, the process will continue reading next file.
If config.txt is not found, nand ipl will be booted.

Examples of files:

CROSS = "/TM/150/ipl.bin";
CIRCLE = "/TM/150_340/ipl.bin";
TRIANGLE = "/TM/340OE/ipl.bin";
SQUARE = "/TM/360M33/ipl.bin";
UP = "/TM/pandora.bin";


This file will load 1.50 ipl when cross is pressed, the 1.50with3.40hw modules ipl when circle is pressed,
the 3.40 OE ipl when triangle is pressed, the 3.60 M33 ipl when square is pressed, the pandora ipl when digital UP
is pressed, and the NAND ipl in any other case.


CROSS = "/TM/150/ipl.bin";
CIRCLE = "/TM/150_340/ipl.bin";
TRIANGLE = "/TM/340OE/ipl.bin";
UP = "/TM/pandora.bin";
DOWN = "NAND";
NOTHING = "/TM/360M33/ipl.bin"; Notice the NOTHING was put at the end!

This file will load 1.50 ipl if cross is pressed, the 1.50with3.40hw modules ipl when circle is pressed,
the 3.40 OE ipl when triangle is pressed, the pandora ipl when digital UP is pressed, the NAND ipl
when digital DOWN is pressed, and the 3.60 M33 ipl in any other case. 


