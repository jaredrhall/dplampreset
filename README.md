DP Lamp Reset Utility
================

This utility is designed to reset the lamp hours on a Digital Projection projectors via RS-232.

# System Requirements
In order to use this software package, you will need:

1. A Microsoft&reg; Windows&trade; PC
2. An onboard serial port OR a USB serial adapter
2. The name of the serial port to which the projector is attached (e.g. "COM1, COM2, COM3...")
3. Microsoft&reg; .NET framework v3.5 or greater. You can obtain the latest .NET installer directly from Microsoft&reg; [here](http://www.microsoft.com/net/downloads).

#Using the Program
Once you are sure that you have met all of the system requirements, you will need to connect your computer to the projector with a serial cable.

Once you are connected to the projector, launch p360_dplampreset.exe.

##Selecting Options
Once you launch the program, you will need to select some options.

First, select a serial port from the drop down menu. This will be the COM port to which the projector is connected.

Next, select the lamp coounter(s) you wish to reset. You may select one or both lamp counters.

##Executing the Reset Operation
When you select "Reset," you will be asked to confirm your selections.
- Select "OK" to continue and attempt to reset the counters.
- Select "CANCEL" to abort the reset. This will allow you to make changes to your selections, or close the program.

The status bar at the bottom of the program window will indicate current progress. If there is an error, a message box will appear describing the error. If the program is able to send the commands successfully, you will see a completion message in the status bar.

**NOTE:** This program does not directly communicate with the projector to confirm that the reset was completed. You will need to access the projector menu with your remote or other software to verify the reset operation completed successfully.

#Programming Notes

1. The commands for the reset operations were pulled from the Digital Projection E-Vision 8000 Series Remote Communications Guide, Rev A April 2012. These commands do not appear in the most recent Rev D May 2013.
