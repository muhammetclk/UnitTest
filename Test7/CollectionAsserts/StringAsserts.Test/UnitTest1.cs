using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringAsserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            //icinde gecen  ifade varsa testten gecer. (orn=yas)
            StringAssert.Contains("Test dünyasindan merhaba","yas");
        }
        [TestMethod]
        public void StringMatchesTest()
        {
            //burda harflerden olusyorsa test gecerli
            StringAssert.Matches("Test dünyasindan merhaba",new Regex(@"[a-zA-z]"));
            //burda sayilardan olusmuyorsa test gecerli anlamina geliyor.
            StringAssert.DoesNotMatch("Test dünyasindan merhaba", new Regex(@"[0-9]"));
        }
        [TestMethod]
        public void StartsWithTest()
        {
            //ifade Test ile basliyorsa test gecerli
            StringAssert.StartsWith("Test dünyasindan merhaba", "Test");
        }
        [TestMethod]
        public void EndWithTest()
        {
            //ifade merhaba ile bitiyorsa test gecerli.
            //buyuk kucuk harf duyarlidir.
            StringAssert.EndsWith("Test dünyasindan merhaba", "merhaba");
        }
    }
}
