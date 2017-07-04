# Better AppleWirelessKeyboard for Wired Keyboards

This is a modification of a modification (yup, really) of AppleWirelessKeyboard utility by [uxsoft](http://uxsoft.cz/projects/applewirelesskeyboard/).

The original utility is great, the modification by gered is even more awesome.

BUT. There is always some BUT.

The app:
  - is poking around in tray
  - is awkwardly sitting in "Apps" in the Task Manager, instead of "Background processes"
  - has really UGLY OSD GUI, bleh
  - wtf why does it use CoreAudio API instead of just emulating native multimedia keys presses?

So my modification:
  - **uses native multimedia controls, so you get 👇 THIS NATIVE OSD instead of their fucking ugly custom GUI bleeh**
    ![OSD](http://i.imgur.com/w2S3bJ6.png)
  - adds ability to run it without tray icon and without hooking the bullshit F3 and F4 keys, because they are as useful as third nipple
    ![run](http://i.imgur.com/ATtx5tc.png)
  - makes it not fucking poke around in task manager
  - adds one settings to reverse the behaviour of Fn emulation
    ![run](http://i.imgur.com/u2K6Q7A.png)


## Usage and stuff

Better go see the [gered/AppleWirelessKeyboard](https://github.com/gered/AppleWirelessKeyboard) repo for the most accurate and latest information about it.
