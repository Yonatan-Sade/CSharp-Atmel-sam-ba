## Project Description
This project contains a C# .Net implementation for the Atmel sam-ba protocol.
It contains simple GUI that you can use to (for example) replace your flash code into another.
If you will play a little with this application you will understand how it works since all the code is visible...

## Some background
Atmel microcontrollers (at least some of them) features small FW embedded in the ROM that make it possible to connect with and then run some important operations.
For Example, you can use the sam-ba to replace the code embedded in the flash to another one.
In that way you can update your code without the need for any Jtag.

## Goals
The goals of this projects are:
1. Use this tool for your own and update firmware.
2. Use this tool as a platform for creating another application to your needs.

## Enviroment
This project implemented and tested with this enviroment:
- Visual studio 2017 (14.1) in community edition
- SAM4SD32C (Xplained pro eval. board)
- using COM port (not the USB connection)

## Building
- Open the project using visual studio.
- Hit F5 or build and run the exe (I used the debug configuration).
- that's it...


## Steps:
for running the aplication folow these steps:
1. power up the microcontroller
2. Assert high the ERASE pin (this is in sam4s...) by connecting it to Vcc. This make the microcontroller to boot from sam-ba rather than user flash.
3. Power down the microcontroller.
4. Power up again.
5. De-assert the ERASE pin (important)
6. Connect some USB-to-UART converter to your PC and to the appropriate TD/RD pins on your microcontroller (refer to sam-ba datasheet to choose the correct UART)
7. Launch the program
8. Make sure all the parameters in the lower section are correct (mailbox address, chip ID etc.) - needless to say it is must...
9. Choose the comport from the combobox.
10. click on "open port"
11. click on "Change to binary"
12. click on "read chip ID"
13. click on "browse" to select bin file for the lowlevel init. you can take it from the installation folder of sam-ba 2.16/Tcl_lib/your-micro. e.g. "applet-lowlevelinit-sam4sd32.bin"
14. click on "send applet file"
15. click on "run applet"
16. Again: "broswe", "send applet" file and then "init applet" for flash applet file. For example "applet-flash-sam4sd32.bin" 
17. click "browse" to select the image file (your code...) and then click on "Send image" (then wait...)
18. click on "read" and then on "compare" to make sure files match.
19. Click on "Set" to make the applet writing the GPNVM bit (1) to 1 (depend on the microcontroller, refer to the datasheet)
20. power down the microcontroller and then power up - and your new image is inside!!!

# Notes:
- some constans can be changed, for example, the delay after "GO" command. play with it...
- Using serial port monitor to watch the UART transaction will make your life happier...

## modifications:
You can feel free to change and modify any part of this project...
Also, Feel free to ask me any question...

