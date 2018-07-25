using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace p0lybot_
{
    class Program
    {
        static void Main(string[] args)
        {
            printPolybot();
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);

            licensed();
        }
        
        static void printPolybot()
        {
            Console.WriteLine("        ___  _       _           _\r\n _ __  / _ \\| |_   _| |__   ___ | |_\r\n| '_ \\| | | | | | | | '_ \\ / _ \\| __|\r\n| |_) | |_| | | |_| | |_) | (_) | |_\r\n| .__/ \\___/|_|\\__, |_.__/ \\___/ \\__|\r\n|_|            |___/   Cracked by @forseeablemc\n\r\n");

        }

        static void licensed()
        {
            Process[] p;
            p = Process.GetProcessesByName("CheatBreaker");
            if (p.Length > 0)
            {
                displayProcess(p[0], "CheatBreaker");
            }
            else
            {
                p = Process.GetProcessesByName("Badlion Client");
                if (p.Length > 0)
                {
                    displayProcess(p[0], "Badlion Client");
                }
                else
                {
                    p = Process.GetProcessesByName("badlion");
                    if (p.Length > 0)
                    {
                        displayProcess(p[0], "Badlion Client");
                    }
                    else
                    {
                        p = Process.GetProcessesByName("javaw");
                        if (p.Length > 0)
                        {
                            displayProcess(p[0], "Minecraft");
                        }
                        else
                        {
                            Console.WriteLine("Unable to locate client process...");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
        static int sleepTime = 200;

        static void injectClient()
        {
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Enabling patchguard hook " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Enabling patchguard hook " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Clearing user data " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Clearing user data " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Fetching remote server " + amountOfDots(i));
            }
            for (int i = 0; i <= 100; i = i + 7)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Downloading module " + progressBar(i));
            }
            for (int i = 0; i <= 100; i = i + 7)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Downloading driver " + progressBar(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Loading driver " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Mapping virtual memory " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Hooking JNI function table " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Pattern scanning loaded classes " + amountOfDots(i));
            }
            for (int i = 0; i <= 3; i = i + 1)
            {
                Thread.Sleep(sleepTime);
                showInjectMessage("Instrumenting netty methods " + amountOfDots(i));
            }
            showInjectMessage("Initializing module 1/3 [Misplace (Stable)]");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            showInjectMessage("\n      Initializing module 2/3 [Misplace (Experimental)]");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            showInjectMessage("\n\n      Initializing module 3/3 [Velocity]");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);


            showInjectMessage("        p0lybot successfully loaded\r\n            ,---.\r\n            ,.'-.   \\\r\n           ( ( ,'\"\"\"\"\"-.\r\n           `,X          `.\r\n           /` `           `._\r\n          (            ,   ,_\\\r\n          |          ,---.,'o `.\r\n          |         / o   \\     )\r\n           \\ ,.    (      .____,\r\n            \\| \\    \\____,'     \\\r\n          '`'\\  \\        _,____,'\r\n          \\  ,--      ,-'     \\\r\n            ( C     ,'         \\\r\n             `--'  .'           |\r\n               |   |         .O |\r\n             __|    \\        ,-'_\r\n            / `L     `._  _,'  ' `.\r\n           /    `--.._  `',.   _\\  `\r\n           `-.       /\\  | `. ( ,\\  \\\r\n          _/  `-._  /  \\ |--'  (     \\");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Console.Clear();
            printPolybot();
            Console.WriteLine("Type \"help\" for a list of commands");

            bool misplace = true;
            bool running = true;
            while (running)
            {
                string command = Console.ReadLine();
                if (command == "help")
                {
                    Console.WriteLine("1. help | prints commands\r\n2. self destruct | self destructs client\r\n3. misplace | toggles misplace mode");
                }
                else
                {
                    if (command == "self destruct")
                    {
                        running = false;
                        for (int i = 0; i <= 100; i = i + 7)
                        {
                            Thread.Sleep(sleepTime);
                            showInjectMessage("Unloading driver " + progressBar(i));
                        }
                        for (int i = 0; i <= 3; i = i + 1)
                        {
                            Thread.Sleep(sleepTime);
                            showInjectMessage("Self destructing " + amountOfDots(i));
                        }
                    }
                    else
                    {
                        if (command == "misplace")
                        {
                            misplace = !misplace;
                            if (misplace)
                            {
                                Console.WriteLine("Misplace mode: Stable");
                            }
                            else
                            {
                                Console.WriteLine("Misplace mode: Experimental");
                            }
                        }
                        else
                        {
                            Console.WriteLine("unknown command \"" + command + "\"");
                        }
                    }
                }
            }
        }

        static string amountOfDots(int amount)  
        {
            string dots = "";
            for(int i = 1; i <= amount; i = i + 1)
            {
                dots = dots + ".";
            }
            return dots;
        }

        static string progressBar(int percent)
        {
            string bar = "[";
            for (int i = 0; i <= percent / 4; i++)
            {
                bar = bar + "=";
            }
            for (int i = 0; i <= (100 - percent) / 4; i++)
            {
                bar = bar + " ";
            }

            bar = bar + "]";

            return percent + "% " + bar;
        }

        static void showInjectMessage(string s)
        {
            Console.Clear();
            printPolybot();
            Console.WriteLine("      "+ s);
        }

        static void displayProcess(Process p, string type)
        {
            Console.WriteLine("Found " + type + " process (" + p.ProcessName + ".exe, PID: " + p.Id + ")  ___________.._______\r\n| .__________))______|\r\n| | / /      ||\r\n| |/ /       ||\r\n| | /        ||.-''.\r\n| |/         |/  _  \\\r\n| |          ||  `/,|\r\n| |          (\\\\`_.'\r\n| |         .-`--'.\r\n| |        /Y . . Y\\\r\n| |       // |   | \\\\\r\n| |      //  | . |  \\\\\r\n| |     ')   |   |   (`\r\n| |          ||'||\r\n| |          || ||\r\n| |          || ||\r\n| |          || ||\r\n| |         / | | \\\r\n\"\"\"\"\"\"\"\"\"\"|_`-' `-' |\"\"\"|\r\n|\"|\"\"\"\"\"\"\"\\ \\       '\"|\"|\r\n| |        \\ \\        | |\r\n: :         \\ \\       : :\r\n. .          `'       . .");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);

            injectClient();
        }

        static void unlicensed()
        {
            Console.WriteLine("                                  ,;;;;;;,\r\n                                ,;;;'\"\"`;;\\\r\n                              ,;;;/  .'`',;\\\r\n                            ,;;;;/   |    \\|_\r\n                           /;;;;;    \\    / .\\\r\n                         ,;;;;;;|     '.  \\/_/\r\n                        /;;;;;;;|       \\\r\n             _,.---._  /;;;;;;;;|        ;   _.---.,_\r\n           .;;/      `.;;;;;;;;;|         ;'      \\;;,\r\n         .;;;/         `;;;;;;;;;.._    .'         \\;;;.\r\n        /;;;;|          _;-\"`       `\"-;_          |;;;;\\\r\n       |;;;;;|.---.   .'  __.-\"```\"-.__  '.   .---.|;;;;;|\r\n       |;;;;;|     `\\/  .'/__\\     /__\\'.  \\/`     |;;;;;|\r\n       |;;;;;|       |_/ //  \\\\   //  \\\\ \\_|       |;;;;;|\r\n       |;;;;;|       |/ |/    || ||    \\| \\|       |;;;;;|\r\n        \\;;;;|    __ || _  .-.\\| |/.-.  _ || __    |;;;;/\r\n         \\jgs|   / _\\|/ = /_o_\\   /_o_\\ = \\|/_ \\   |;;;/\r\n          \\;;/   |`.-     `   `   `   `     -.`|   \\;;/\r\n         _|;'    \\ |    _     _   _     _    | /    ';|_\r\n        / .\\      \\\\_  ( '--'(     )'--' )  _//      /. \\\r\n        \\/_/       \\_/|  /_   |   |   _\\  |\\_/       \\_\\/\r\n                      | /|\\\\  \\   /  //|\\ |\r\n                      |  | \\'._'-'_.'/ |  |\r\n                      |  ;  '-.```.-'  ;  |\r\n                      |   \\    ```    /   |\r\n    __                ;    '.-\"\"\"\"\"-.'    ;                __\r\n   /\\ \\_         __..--\\     `-----'     /--..__         _/ /\\\r\n   \\_'/\\`''---''`..;;;;.'.__,       ,__.',;;;;..`''---''`/\\'_/\r\n        '-.__'';;;;;;;;;;;,,'._   _.',,;;;;;;;;;;;''__.-'\r\n             ``''--; ;;;;;;;;..`\"`..;;;;;;;; ;--''``\r\n\r\n                        Authentication failed\r\n   If you believe this is an error contact @p0lybotCC on Twitter");
            Console.ReadLine();
        }
    }
}
