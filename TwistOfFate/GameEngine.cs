using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static TwistOfFate.Utility;

/*TO DO:
 * Add new classes for each room (ask Janelle about best way)
 * Figure out puzzles 
 * 
 * 
 */

namespace TwistOfFate
{
    public class GameEngine
    {
        public Player Player1;
        public Room CurrentRoom;
        public void SetupGame()
        {
            CurrentRoom = new Room();
            CurrentRoom.RoomName = "The Beginning";
            CurrentRoom.RoomLocationX = 0;
            CurrentRoom.RoomLocationY = 1;
            CurrentRoom.RoomDescription = "Every story has a beginning, and this is yours. " +
                "To your left a door. To your right, another.";
            Player1 = new Player();

            RunGame();
        }
        public void RunGame()
        {
            Print(CurrentRoom.RoomName);
            PrintSpace();
            Print("Before you stands a figure. They reach out a hand, and ask for your name.");
            //string input = GetUserInput("What is your name?");
            Print("What is your name?");

            string newName = ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                Player1.Name = newName;
            }
            PrintSpace();
            Print($"You introduce yourself as {Player1.Name}. The figure smiles.");
            PrintSpace();
            Print("\"Welcome to the Corrdiors of Fate.\" They say mischievously.");
            Print("\"You have a chance to change the fate bestowed on you, should you pass the corrider's challenges.\"");
            PrintSpace();
            Print("The figure puts one of their hands in yours, and you feel something hit your palm.");
            PrintSpace();
            Print("\"Best of luck to you, if you believe in such a thing.\"");
            PrintSpace();
            Print("You blink and the figure vanishes. You look down to your outstretched hand");
            Print("In it, a weathered card and a piece of parchment.");
        }


    }

}
