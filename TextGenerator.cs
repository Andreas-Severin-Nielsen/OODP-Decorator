using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Decorator
{
    public class TextGenerator : ITextGenerator
    {
        public string GenerateText()
        {
            return "   this is text generated and such  ";
        }
    }
}
