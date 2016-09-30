popsloader for 5.00 M33-2 and up (until Sony screws it again)

Requeiments:

- 5.00 M33-2, it won't work in 5.00 M33-1

New:
- Works on 5.00.
- Added 3.80, 3.90 and 4.01.



- Upgrade from older version of popsloader:

* Copy seplugins to memstick root folder replacing files. 
* Dump 4.01 (choose decrypt all option in psardumper) and copy the file impose.prx in /seplugins/popsloader/ with that name (impose.prx, without numbers)

- Install from scratch:

* Copy seplugins to memstick root folder replacing files.
* Dump the desired firmware to extract the files needed. (choose decrypt all option in psardumper)

Thse are the files needed for each firmware:

3.02-3.03: /kd/pops.prx, /kd/popsman.prx, /kd/meaudio.prx, /vsh/module/pafmini.prx
3.10-3.30: /kd/pops.prx, /kd/popsman.prx, /vsh/module/pafmini.prx
3.40-4.01: /kd/pops.prx, /kd/popsman.prx, /vsh/module/pafmini.prx, /vsh/module/libpspvmc.prx

* Copy the files to /seplugins/popsloader with firmware version as suffix (e.g. popsman.prx -> popsman380.prx)
* Additionally, no matter which pops you want to run, you have to get impose.prx from 4.01 and
copy it to /seplugins/popsloader/ with the name impose.prx (no suffix).
