using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConsoleController : MonoBehaviour
{
    // Reference to the TextMeshPro - Text element that displays the output
    public TMP_Text outputText;

    // Reference to the TextMeshPro - Input Field element that receives the input
    public TMP_InputField inputField;

    // A list of commands that the console can execute
    private List<string> commands;

    // A list of messages that the console has printed
    private List<string> messages;

    // A string that represents the prompt symbol of the console
    private string prompt = "> ";

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the commands list with some example commands
        commands = new List<string>();
        commands.Add("help");
        commands.Add("clear");
        commands.Add("echo");
        commands.Add("quit");

        // Initialize the messages list with an empty string
        messages = new List<string>();
        messages.Add("");

        // Print a welcome message and the prompt symbol
        Print("Welcome to Commando, a console program made in Unity 2023.");
        Print(prompt);
    }

    // A method that prints a message to the output text
    void Print(string message)
    {
        // Add the message to the messages list
        messages.Add(message);

        // Update the output text with the messages list
        outputText.text = string.Join("\n", messages.ToArray());
    }

    // A method that executes a command
    public void Execute(string command)
    {
        // Print the command to the output text
        Print(prompt + command);

        // Check if the command is valid
        if (commands.Contains(command))
        {
            // Switch on the command and perform the corresponding action
            switch (command)
            {
                case "help":
                    // Print a list of available commands
                    Print("Available commands:");
                    foreach (string cmd in commands)
                    {
                        Print("- " + cmd);
                    }
                    break;
                case "clear":
                    // Clear the messages list and the output text
                    messages.Clear();
                    outputText.text = "";
                    break;
                case "echo":
                    // Print a message that echoes the command
                    Print("Echo, echo, echo...");
                    break;
                case "quit":
                    // Print a farewell message and quit the application
                    Print("Thank you for using Commando. Goodbye!");
                    Application.Quit();
                    break;
            }
        }
        else
        {
            // Print an error message
            Print("Invalid command. Type 'help' for a list of available commands.");
        }

        // Print the prompt symbol
        Print(prompt);

        // Clear the input field
        inputField.text = "";

        // Refocus the input field
        inputField.ActivateInputField();
    }

}
