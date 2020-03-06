using System;

namespace somekinda
{
    class Program
    {
        static void Main(string[] args)
        {

            Random ran = new Random();
            var x = new Random();
            string[] color = { "Red", "Black" };
            string choice;
            int NumberOfAttempts = 0;
            int bet;
            int money = 500;
            while (money != 0)
            {

                Console.WriteLine("+++++++++++++++++++++");
                Console.WriteLine(" LETS PLAY ROULETTE!");
                Console.WriteLine("+++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Money:$" + money + "                  NumberOfAttempts: " + NumberOfAttempts);
                Console.WriteLine("-------------------");
                Console.WriteLine("A.    Even");
                Console.WriteLine("-------------------");
                Console.WriteLine("B.    Odd");
                Console.WriteLine("-------------------");
                Console.WriteLine("C.    1 to 18");
                Console.WriteLine("-------------------");
                Console.WriteLine("D.    19 to 36");
                Console.WriteLine("-------------------");
                Console.WriteLine("E.    Red");
                Console.WriteLine("-------------------");
                Console.WriteLine("F.    Black");
                Console.WriteLine("-------------------");
                Console.WriteLine("G.    1st 12");
                Console.WriteLine("-------------------");
                Console.WriteLine("H.    2nd 12");
                Console.WriteLine("-------------------");
                Console.WriteLine("I.    3rd 12");
                Console.WriteLine("-------------------");
                choice = (Console.ReadLine());
                

                choice.ToLower();
                bool check = choice == "a" || choice == "b" || choice == "c" || choice == "d" || choice == "e" || choice == "f" || choice == "g" || choice == "h" || choice == "i";

                
                if (check == false)
                {
                    Console.WriteLine("You did not enter the correct input value(even/odd)");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    bet:
                    Console.WriteLine("Enter an amount to bet");
                    bet = Convert.ToInt32(Console.ReadLine());
                   
                    if (bet > money)
                    {
                        Console.WriteLine("You dont have enough money!");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadKey();
                        goto bet;
                    }
                    else
                    {
                        money -= bet;
                        int roll = ran.Next(0, 37);
                        string ranColor = color[x.Next(color.Length)];
                        bool even = roll % 2 == 0;

                        if ((((choice == "a") && (even == true))) ||
                             (((choice == "b") && (even == false))) ||
                             ((choice == "e") && (ranColor == "Red") ||
                             (choice == "f") && (ranColor == "Black")))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            NumberOfAttempts += 1;
                            Console.ReadKey();
                        }
                        else if ((choice == "c") && ((roll > 0) && (roll < 19)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            NumberOfAttempts += 1;
                            Console.ReadKey();
                        }
                        else if ((choice == "d") && ((roll > 18) && (roll < 37)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            NumberOfAttempts += 1;
                            Console.ReadKey();
                        }
                        else if ((choice == "g") && (roll > 0 && roll < 13) || (choice == "h") && (roll > 12 && roll < 25) || (choice == "i") && (roll > 24 && roll < 37))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 3;
                            NumberOfAttempts += 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You lost! -$" + bet + "!");
                            Console.WriteLine("<Press enter to continue>");
                            NumberOfAttempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("You are out of money.");
                                Console.WriteLine("<Press enter to continue>");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                Console.Clear();
            }
        }
    }
}
