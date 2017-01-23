using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    using XmlMarkupBuilder;

    class Program
    {
        static void Main(string[] args)
        {
            XmlBuilder markupBuilder = new XmlBuilder();
            Console.WriteLine(markupBuilder.openTag("body").addAttr("type", "background-color:blue").addText("Hello HTML!").closeTag().finish().getResult());
        }
    }
}
