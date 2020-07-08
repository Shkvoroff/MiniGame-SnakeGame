using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Snake
{

   public class Text //+Score
    {
        public static int score = 0;
        public static int maxScore;

        public static void Nickname()
        {
            int xOffset = 0;
            int yOffset = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please, Enter your Nickname:", xOffset, yOffset++);
            WriteText("----------------------------", xOffset, yOffset++);
            string pname;
            Console.SetCursorPosition(xOffset, yOffset++);
            pname = Console.ReadLine();
            WriteText("----------------------------", xOffset, yOffset++);
            Console.Write("GOOD LUCK & HAVE FUN: "+pname+"!", xOffset, yOffset++);

        }

        public static void WriteRules()
        {
            int xOffset = 0;
            int yOffset = 25;
            Console.ForegroundColor = ConsoleColor.White;
            WriteText("SNAKE", xOffset +35, yOffset++);
            WriteText("===============================================================================", xOffset, yOffset++);
            WriteText("USE ArrowKeys to MOVE", xOffset, yOffset++);
            WriteText("USE Space to PAUSE & USE Enter to UNPAUSE", xOffset, yOffset++);
        }

        public static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("    G A M E    O V E R", xOffset + 1, yOffset++);
            WriteText("----------------------------", xOffset, yOffset++);
            //WriteText(" ", xOffset, yOffset++);
            //WriteText(pname, xOffset, yOffset++);
            WriteText("YOUR SCORE IS: " +score, xOffset, yOffset++);
            WriteText("YOUR MAX SCORE WAS: " + score, xOffset, yOffset++);
            //WriteText("YOUR SPEED WAS: ", xOffset, yOffset++);
            WriteText("----------------------------", xOffset, yOffset++);
            //WriteText(" ", xOffset, yOffset++);
            WriteText("      TRY AGAIN,LOOSER! ", xOffset, yOffset++);
            WriteText("", xOffset, yOffset++);
            WriteText("R-RESTART           ESC-EXIT", xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }


        public Text()
        {
            //Score
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
