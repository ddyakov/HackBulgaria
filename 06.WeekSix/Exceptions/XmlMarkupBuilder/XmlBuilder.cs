using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilder
{
    public class XmlBuilder
    {
        private StringBuilder xml = new StringBuilder();
        private readonly Stack<string> Tag = new Stack<string>();
        private string currTag;

        public XmlBuilder openTag(string name)
        {
            if (name == null)
            {
                throw new ArgumentException("Enter tag name!");
            }

            xml.Append(string.Format("<{0}>",name));
            this.currTag = string.Format("{0}",name);
            this.Tag.Push(currTag);
            return this;
        }

        public XmlBuilder addAttr(string attrName, string attrValue)
        {
            if (Tag.Count == 0)
            {
                throw new ArgumentException("You can not add attribute!");
            }

            xml.Insert(currTag.Length+1,string.Format(" {0}=\"{1}\"", attrName,attrValue));
            return this;
        }

        public XmlBuilder addText(string text)
        {
            if (Tag.Count == 0)
            {
                throw new ArgumentException("You have to open a tag first!");
            }

            xml.Append(string.Format("{0}", text));
            return this;
        }

        public XmlBuilder closeTag()
        {
            if (Tag.Count == 0)
            {
                throw new ArgumentException("You don't have an open tag!");
            }

            xml.Append(string.Format("</{0}>", Tag.Pop()));
            return this;
        }

        public XmlBuilder finish()
        {
            while (Tag.Count > 0)
            {
                closeTag();
            }

            return this;
        }

        public string getResult()
        {
            return this.xml.ToString();
        }
    }
}
