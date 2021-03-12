# MigraineAway
A simple timer app to help prevent migraines caused by eye strain from looking at a computer screen for too long. It is also a useful timer for general purpose use.
## Features
- Separate, configurable work and break timers
- Instantly minimises when starting a work timer
- Pops up in front of all running applications so that you don't forget to take a break
## Latest Release
The precompiled executable can be found [here](https://github.com/Sharealikelicence/MigraineAway/releases/tag/v1.0.0.0).
## Configuration
The default work and break times can be configured within the `.config` file in the following format:
``` XML
<appSettings>
    <add key="WorkTime" value="hh:mm:ss"/>
    <add key="BreakTime" value="hh:mm:ss"/>
</appSettings>
```
For example:
``` XML
<appSettings>
    <add key="WorkTime" value="00:30:00"/>
    <add key="BreakTime" value="00:02:00"/>
</appSettings>
```
Will default to a 30 minute work time and a 2 minute break time.
