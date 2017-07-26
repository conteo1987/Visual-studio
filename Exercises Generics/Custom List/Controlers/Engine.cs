using System;

namespace Custom_List.Controlers
{
    public class Engine
    {
        private CommandInterpreter commandInterprete;

        public Engine()
        {
            this.commandInterprete = new CommandInterpreter();
        }

        public void Run()
        {
            var cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "END")
            {
                this.commandInterprete.InterpretCommand(cmdArgs);
                cmdArgs = Console.ReadLine().Split();
            }
        }
    }
}
