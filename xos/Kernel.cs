using Cosmos.System;
using Cosmos.Core.Memory;
using Sys = Cosmos.System;
using xos.Commands;
using System;
using Console = System.Console;

namespace xos
{
    public class Kernel : Sys.Kernel
    {

        public static uint ScreenWidth = 800;
        public static uint ScreenHeight = 600;

        public CommandManager commandManager;


        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("XOS developpe par Xavito.\nVersion 1.0");
            Console.WriteLine(" __  __           _ _\n\\ \\/ /__ ___   _(_) |_ ___\n \\  // _` \\ \\ / / | __/ _ \n /  \\ (_| |\\ V /| | || (_) |\n/_/\\_\\__,_| \\_/ |_|\\__\\___/");
            commandManager = new CommandManager();
           
        }

        protected override void Run()
        {
            String commandresponse;
            string input = Console.ReadLine();
            commandresponse = commandManager.processInput(input);
            Console.WriteLine(commandresponse);
        }
    }
}
