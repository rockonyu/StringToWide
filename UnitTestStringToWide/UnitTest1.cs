using System;
using StringToWide;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestStringToWide {
    [TestClass]
    public class UnitTest1 {
        Transform trans = new Transform();
        string input = "翻滾吧! 阿信";
        [TestMethod]
        public void TestMethod1() {
            Assert.AreEqual("翻滾吧! 阿信", trans.TextTransform(input, false, false));
        }

        [TestMethod]
        public void TestMethod2() {
            Assert.AreEqual("翻滚吧! 阿信", trans.TextTransform(input, false, true));
        }

        [TestMethod]
        public void TestMethod3() {
            Assert.AreEqual("翻滾吧！　阿信", trans.TextTransform(input, true, false));
        }

        [TestMethod]
        public void TestMethod4() {
            Assert.AreEqual("翻滚吧！　阿信", trans.TextTransform(input, true, true));
        }
    }
}
