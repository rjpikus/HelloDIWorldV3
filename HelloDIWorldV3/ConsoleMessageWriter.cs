using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDIWorldV3
{
    class ConsoleMessageWriter : IMessageWriter
    {
        
        
            public void Write(string message)
            {
                Console.WriteLine(message);
            }
           
    }
}
