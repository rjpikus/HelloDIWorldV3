using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDIWorldV3
{
    class WordDefs
    {
        public WordDefs(string command1)
        {
            
                
            switch (command1)
            {
                //language
                case "hello": Console.WriteLine("world!"); break;
                case "let": Console.WriteLine("it be"); break;
                case "relax": Console.WriteLine("and float downstream"); break;
                case "amazon": Console.WriteLine("Built book selling website. Perfected the art of keeping the heavy traffic of the website. Sold this knowledge to other companies. AWS. Through the 90's the web team was devoted to making the website run fast and not go down. They became so good they sold the system. Target wanted to get into e-commerce. So they built them a store."); break;
                case "encourage": Console.WriteLine("don't be afraid to show off, more than enough to pull this off"); break;
                //language


                //DEFAULT 
                default: Console.WriteLine("err: type 'hello', 'let', or 'relax' "); break;
            }

   
            
        }                                                                                      
    }
}
//this matches the word to def, but it also prints it, we should take away the printing task and put it on the main program
