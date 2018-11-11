using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_masterclass_
{
    class Program
    {
        //create the playfield
        static char[,] playField = {
            { '1', '2', '3' },
            { '4', '5', '6'},
            { '7', '8', '9'}
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            #region 
            ////second step; make sure user can put input to the game
            //int player = 2; //player 1 start
            //int input = 0;
            //bool checkInput = true;

            ////calls the field of the game
            //SetField();

            ////third step, make do while loop that runs as long as the program runs
            //do
            //{
            //    //bases who's turn it is.
            //    //the first run; the input is 0, because the user didn't give input yet
            //    //the player is player 2, and before starting, the player is set to player 1.
            //    if (player == 2)
            //    {
            //        player = 1;
            //        EnteredInput(player, input);
            //    }
            //    else if (player == 1)
            //    {
            //        player = 2;
            //        EnteredInput(player, input);
            //    }

            //    //called every time the loop starts
            //    SetField();

            //    //checks winning condition
            //    char[] playerChars = { 'X', 'O' };
            //    foreach (char playerChar in playerChars)
            //    {
            //        if(((playField[0,0] == playerChar) && (playField[0,1] == playerChar) && (playField[0,2] == playerChar))
            //            || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
            //            || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
            //            || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
            //            || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
            //            || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
            //            || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
            //            || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
            //            )
            //        {
            //            if (playerChar == 'X')
            //            {
            //                Console.WriteLine("Player 2 has won!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Player 1 has won!");
            //            }

            //            Console.WriteLine("Please press any key to reset the game!");
            //            Console.ReadKey();

            //            ResetField();

            //            break;
            //        }
            //        //if there is a draw
            //        else if (turns == 11)
            //        {
            //            Console.WriteLine("draw");
            //            Console.WriteLine("Please press any key to reset the game!");
            //            Console.ReadKey();
            //            ResetField();
            //            break;
            //        }
            //    }

            //    do
            //    {
            //        Console.Write("\nPlayer {0}: choose your field! ", player);
            //        try
            //        {
            //            input = Convert.ToInt32(Console.ReadLine());
            //        }
            //        //handles if there is an letter input
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Please enter a number!");
            //        }

            //        //checks if the input is already used and asks for another input for that player
            //        if ((input == 1) && (playField[0, 0] == '1'))
            //            checkInput = true;
            //        else if ((input == 2) && (playField[0, 1] == '2'))
            //            checkInput = true;
            //        else if ((input == 3) && (playField[0, 2] == '3'))
            //            checkInput = true;
            //        else if ((input == 4) && (playField[1, 0] == '4'))
            //            checkInput = true;
            //        else if ((input == 5) && (playField[1, 1] == '5'))
            //            checkInput = true;
            //        else if ((input == 6) && (playField[1, 2] == '6'))
            //            checkInput = true;
            //        else if ((input == 7) && (playField[2, 0] == '7'))
            //            checkInput = true;
            //        else if ((input == 8) && (playField[2, 1] == '8'))
            //            checkInput = true;
            //        else if ((input == 9) && (playField[2, 2] == '9'))
            //            checkInput = true;
            //        else
            //        {
            //            Console.WriteLine("Incorrect input. Please set another field!");
            //            checkInput = false;
            //        }
            //    } while (!checkInput);

            //} while (true);
            #endregion
        }

        //resetting method
        public static void ResetField()
        {
            char[,] playFieldReset = {
            { '1', '2', '3' },
            { '4', '5', '6'},
            { '7', '8', '9'}
            };

            playField = playFieldReset;
            SetField();
            turns = 0;
        }

        //first step is to make the field 
        public static void SetField()
        {
            //updates the console every time the method is called.
            //set here, it clears the console every time the first do while loop starts
            Console.Clear();

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0],playField[0,1],playField[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");

            turns++;
        }

        public static void EnteredInput(int player, int input)
        {
            char playerSign = ' ';

            //assigns the sign to the player
            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }

            //checks the input of the player and assigns the playerSign to that input in the array
            switch (input)
            {
                case 1: playField[0, 0] = playerSign ; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
                default: break;
            }
        }
    }
}
