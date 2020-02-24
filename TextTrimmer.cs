using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Decorator
{
    class TextTrimmer : TextGeneratorDecorator
    {
        public TextTrimmer(ITextGenerator textGenerator)
        {
            base.TextGenerator = textGenerator;
        }

        public override string GenerateText()
        {
            string txt = base.GenerateText();
            txt = txt.Trim();
            return txt;
        }
    }
}
