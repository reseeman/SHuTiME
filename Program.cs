using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shutime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(54, 25);

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.Write("▓╪╔════════════════════════════════════════════════╗"); Console.ResetColor(); Console.WriteLine("╪▓");
            Console.Write("▓╪║                                                ║"); Console.ResetColor(); Console.WriteLine("╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"    (        )                     *            "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"    )\ )  ( /(         *   )     (  `           "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(@"   (()/(  )\())   (  ` )  /( (   )\))(   (      "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(@"    /(_))((_)\   ))\  ( )(_)))\ ((_)()\  )\     "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"   (_))   _((_) /((_)(_(_())((_)(_()((_)((_)    "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"   / __| | || |(_))( |_   _| (_)|  \/  || __|   "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(@"   \__ \ | __ || || |  | |   | || |\/| || _|    "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(@"   |___/ |_||_| \_,_|  |_|   |_||_|  |_||___|   "); Console.ResetColor(); Console.WriteLine("║╪▓");
            Console.Write("▓╪║                             (c) dao1a          ║"); Console.ResetColor(); Console.WriteLine("╪▓");
            Console.WriteLine("  ╚════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.WriteLine("Choose option: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.Write("┬1┬─ timer         "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("+"); Console.ResetColor(); Console.WriteLine(" ┐");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.Write("┤2├─ cancel        "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("@"); Console.ResetColor(); Console.WriteLine(" ┤");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.Write("┴3┴─ "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("exit"); Console.ResetColor(); Console.Write("          "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("x"); Console.ResetColor(); Console.WriteLine(" ┘");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor();
            Console.Write("Your choose: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.WriteLine("┬─┬─ (1 hour = 3600 seconds etc.)");
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.Write("┤0├─ Time in seconds: ");
                    string timeString = Console.ReadLine();
                    if (timeString == "") { timeString = "0"; };
                    if (timeString.Contains(",") || timeString.Contains("."))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("#### Value must be integer!"); Console.ResetColor();
                        timeString = "0";
                        for (int a = 5; a >= 0; a--)
                        {
                            Console.SetCursorPosition(36, 22);
                            Console.Write("Main menu in {0}...", a);  // Override complete previous contents
                            System.Threading.Thread.Sleep(1000);
                        }
                    };
                    int time = Convert.ToInt32(timeString);
                    if (time == 0)
                    {
                        return true;
                    }
                    else
                    {
                        System.Diagnostics.Process.Start("cmd", $"/c shutdown -s -f -t {time}");
                        return true;
                    }
                case "2":
                    System.Diagnostics.Process.Start("shutdown", "/a");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(">>>> "); Console.ResetColor(); Console.Write("Cancelled!");
                    for (int a = 3; a >= 0; a--)
                    {
                        Console.SetCursorPosition(36, 20);
                        Console.Write("Main menu in {0}...", a);  // Override complete previous contents
                        System.Threading.Thread.Sleep(1000);
                    }
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }



    
}