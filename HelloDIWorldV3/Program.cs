using System;

namespace HelloDIWorldV3
{
    class Program
    {
        static void Main(string[] args)
        {

            IMessageWriter writer = new ConsoleMessageWriter();
            IMessageReader reader = new ConsoleMessageReader();
            var textbytext = new TextByText(writer, reader);
            string commandP;
            writer.Write("program online\nEnter Input\n1");
            int p;
            for (p = 2; p < 100; p++)
            {
                commandP = reader.Read();
                switch (commandP)
                {
                    case "text by text": textbytext.Run(); break;
                    case "dito": Console.WriteLine(commandP); break;

                    default: Console.WriteLine("err: type 'text by text', or 'dito' "); break;

                }

            }
        }
    }
}


      
    
