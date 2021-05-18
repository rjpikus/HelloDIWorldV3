using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDIWorldV3
{
    class TextByText
    {

        private readonly IMessageWriter writer;
        private readonly IMessageReader reader;
        public TextByText(IMessageWriter writer, IMessageReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        public void Run()
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            IMessageReader reader = new ConsoleMessageReader();
            string command;
            writer.Write("===v^v===\ntext by text online\nEnter Input\n1");
            int i;
            for (i = 2; i < 100; i++)
            {
                command = reader.Read();
                var worddefs = new WordDefs(command);
                writer.Write(i.ToString());
            }

        }

    }
}
