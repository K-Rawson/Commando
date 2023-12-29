# Commando

Commando is a software that lets you use commands to hack, infiltrate, or sabotage systems.

## Project description

Commando is a cyberdefense software that uses 3D graphics and commands to perform various tasks. It is built with Unity 2023.2.3f1 and the Command Terminal unity asset, which allows you to create new static functions mapped to commands in the console. The software starts in windowed mode, and resizable. The console is fullscreen, with nothing else rendered on the screen in 2D or 3D in the scene. After it is done loading, it executes windows_start.bat located in the ..\bin directory.

## Development

To develop Commando, you need to have Unity 2023.2.3f1 or later installed on your computer. You also need to download the Command Terminal unity asset from the Unity Asset Store. Then, follow these steps:

- Clone this repository to your local machine.
- Open the project folder in Unity Hub.
- Open the Build folder and run the Commando.exe file.

## Usage

To use Commando, you need to enter commands in the console to interact with the software. You can use the following commands:

- help: Shows a list of available commands and their descriptions.
- boot: Starts the system software.
- shutdown: Terminates the system software.
- restart: Reboots the system software

For example, to startup the operating system for use, you can enter:

```
> boot
```

Or to shutdown the system

```
> exit
```
