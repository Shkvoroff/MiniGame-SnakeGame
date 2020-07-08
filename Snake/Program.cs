using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media; //SoundPlayer


namespace Snake
{
	public class Program
	{
        public static void Main(string[] args)
        {
            Program main = new Program();
            Text.Nickname();
            Sound.SoundStart();
            Console.Clear();
            main.StartGame();
        }

        public void StartGame()
		{
            Text score = new Text(); //Score int
            Console.SetWindowSize( 80, 30 );

			Walls walls = new Walls( 80, 25 );
			walls.Draw();

			Point p = new Point( 4, 5, '*' );
			Snake snake = new Snake( p, 4, Direction.RIGHT );
			snake.Draw();

            Text.WriteRules();

            List<Char> foods = new List<char>() { '#', '%', '@', '&', '*' };
            FoodCreator foodCreator = new FoodCreator( 80, 25, foods);
            Point food = foodCreator.CreateFood();
            food.Draw();          

			while (true)
			{
				if ( walls.IsHit(snake) || snake.IsHitTail() )
				{
					break;
				}
				if(snake.Eat( food ) )
				{
                    food = foodCreator.CreateFood();
                    food.Draw();

                    //Kazhdqoe 5 o4ko zmeika s edoi prevrawajetsja v krasnuju do 25 o4kov
                    if (Text.score != 5 && Text.score != 10 && Text.score != 15 && Text.score != 20 && Text.score != 25)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (Text.score != 1 && Text.score != 2 && Text.score != 3 && Text.score != 4 && Text.score != 6 && Text.score != 7 && Text.score != 8 && Text.score != 9 && Text.score != 11 && Text.score != 12 && Text.score != 13 && Text.score != 14 && Text.score != 16 && Text.score != 17 && Text.score != 18 && Text.score != 19 && Text.score != 21 && Text.score != 22 && Text.score != 23 && Text.score != 24)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
				else
				{
					snake.Move();
				}

				Thread.Sleep( 100 );
				if ( Console.KeyAvailable )
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
			}
            
            if (Text.score > Text.maxScore) //Max Score?
                Text.maxScore = Text.score;

            Console.Clear();
            Text.WriteGameOver();
            
            //Restart or Exit?(R or Escape)
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        Text.score = 0;;
                        StartGame();
                    }
                    else if (key.Key == ConsoleKey.Escape)
                        Environment.Exit(0);
                    else
                        Console.Write("");
                }
            }        
            //Console.ReadLine();
        }
	}
}
