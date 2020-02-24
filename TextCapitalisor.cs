using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Decorator
{
    class TextCapitalisor : TextGeneratorDecorator
    {
        public TextCapitalisor(ITextGenerator textGenerator)
        {
            base.TextGenerator = textGenerator;
        }

        public override string GenerateText()
        {
            string txt = base.GenerateText();
            txt = txt.ToUpper();
            return txt;
        }
    }
}
