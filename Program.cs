using System;

public class Program
{
    static void Main(string[] args) 
    {

/*Documentation of how to use the VoiceToTextProtocolClass method:
1. Create a variable to hold the instance of the VoiceToTextProtocol class.
2. Use the constructor method VoiceToTextProtocolCreator with the path to the desired model of use as a string parameter to initialize the model.
3. Use the <variable name>.ReadPlayerInput() in order to activate the voice recognition element of the program
4. Store the returned string value from the ReadPlayerInput() method into a variable to take decisions in game
*/

        //Create a new instance of the VoiceToTextProtocol class in order to use it for interactability

        var voice = new VoiceToTextProtocol(); //<-- Created an instance of a VoiceToTextProtocol class

        voice.VoiceToTextProtocolCreator("C:\\Users\\mateo\\OneDrive\\Documents\\VFS\\T1\\Coding\\Assignment1\\ASK THE TEACH\\vosk-model-small-en-us-0.15\\VoskLite\\");//<-- Initialized the model with the path to it


        Console.WriteLine("Hello player, what is your name?");
        string playerName = voice.ReadPlayersInput(); //<-- Used the ReadPlayersInput method to get the player's name via voice input

        Console.WriteLine($"Welcome, {playerName}!");



    }

}
