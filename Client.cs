using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Decorator
{
    class Client
    {
        ITextGenerator textGenerator;

        public Client()
        {
            textGenerator = new TextCapitalisor(new TextTrimmer(new TextGenerator()));
        }

        public void DoIt()
        {
            Console.WriteLine(textGenerator.GenerateText());
        }
    }
}
