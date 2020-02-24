using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Decorator
{
    abstract class TextGeneratorDecorator : ITextGenerator
    {
        public ITextGenerator TextGenerator { get; set; }

        public virtual string GenerateText()
        {
            return TextGenerator.GenerateText();
        }
    }
}
