# Commando

Commando is an AI Manager software that enables you to use commands to manage and deploy AI systems locally or remotely.

## Project description

Commando is a software that uses 3D graphics and commands to perform various tasks related to AI systems. It is built with Unity 2023.2.3f1 and our own custom console, which allows you to create and execute commands in C#. The software starts in windowed mode, and resizable. The console is fullscreen, with nothing else rendered on the screen in 2D or 3D in the scene. After it is done loading, it executes windows_start.bat located in the ..\bin directory.

Commando allows you to visualize and interact with much more data in many more dimensions, using the 3D graphics mode. This will enable you to create, train, and coordinate your collection of intelligent agents, such as text generation, image generation, music generation, code generation, video generation, chatbots, stable diffusion, and more. You can also monitor and control the performance and behavior of your AI systems, using the commands in the console.

## Development

To develop Commando, you need to have Unity 2023.2.3f1 or later installed on your computer.

### Requirements
- Windows 10/11
- Unity 2023.2.3f1

 Then, follow these steps:

- Clone this repository to your local machine.
- Open the project folder in Unity Hub.
- Build the project into the Build folder inside the project root directory (make the folder if it does no exist) 
- Open the Build folder and run the Commando.exe file.
- Make sure you have a stable internet connection and a powerful graphics card, as Commando requires high performance and online access.

## Usage

To use Commando, you need to enter commands in the console to interact with the software. You can use the following commands:

- help: Shows a list of available commands and their descriptions.
- list: Lists all the local and remote AI systems that you can manage or install.
- connect: Connects to a remote AI system, given its IP address or domain name.
- install: Installs a local or remote AI system, given its name and location.
- update: Updates a local or remote AI system, given its name and version.
- remove: Removes a local or remote AI system, given its name.
- quit: Stops an AI system, and disconnects
- exit: Terminates the Commando AI Manager.

For example, to list all the local and remote AI system names, you can enter:

```
> list
```

Or to install a remote AI system, you can enter:
```
> install <system_name>
```

To switch to the 3D graphics mode, you can press F1. To return to the console, you can press F2.

