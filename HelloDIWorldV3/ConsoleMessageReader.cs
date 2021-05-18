using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDIWorldV3
{
    class ConsoleMessageReader : IMessageReader
    {
        public string Read()
        {
            string text;
            text = Console.ReadLine();
            return text;
        }
    }
}


