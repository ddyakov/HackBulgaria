using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XmlBuilderTests
{
    using XmlMarkupBuilder;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenTagTest()
        {
            var newOpenTag = new XmlBuilder();
            newOpenTag.openTag("goshko");
            Assert.AreEqual(newOpenTag.getResult(), "<goshko>");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void AddAttrTest()
        {
            var newAttr = new XmlBuilder();
            newAttr.addAttr("type", "background-color:blue");
        }

        [TestMethod]
        public void AddTextTest()
        {
            var newText = new XmlBuilder();
            newText.openTag("a").addText("sds");
            Assert.AreEqual(newText.getResult(), "<a>sds");
        }

        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void CloseTagTest()
        {
            var newCloseTag = new XmlBuilder();
            newCloseTag.closeTag();
        }

        [TestMethod]
        public void FinishTest()
        {
            var newFinish = new XmlBuilder();
            newFinish.openTag("a");
            Assert.AreEqual(newFinish.finish().getResult(), "<a></a>");
        }

        [TestMethod]
        public void GetResultTest()
        {
            var newResult = new XmlBuilder();
            newResult.openTag("a").addText("text").closeTag();
            Assert.AreEqual(newResult.getResult(), "<a>text</a>");
        }
    }
}
