TwitchChatPipe (C#)
==============

Pipes the Twitch Chat to a VirtualBox Virtual Machine

==============
Setup
==============

1) You will need to have VirtualBox installed with a Virtual Machine running.  
2) You will need to reference the VBoxC.dll in your "Program Files/Oracle/VirtualBox" folder for the c# code to compile.


==============
Usage
==============

1) Edit the IRC data, you can have multiple servers seperated by a comma (no spaces)
2) Hit "Connect", wait about 5 seconds.
3) Hit "Join Channel", your Twitch Chat Channel is your username, for instance, "#myusername"
4) Verify the Virtual Machine Name matches your VirtualBox VM name.
5) Hit "Lock", to begin sending chat commands to virtual box.

Note: You do not have to be streaming for it to work, just go to your channel and start chatting.

==============
Custom Key Config
==============

The program is setup to use SNESKeys as it's default key command configuration.  
There is also an example for Final Fantasy 7 from Steam.
You can create a new enum in ButtonMaster.cs to map your desired keys to the key inputs of the program/emulator you use in virtualbox.
After you create the enum, pass it in the Form1 Constructor that creates the ButtonMaster object.