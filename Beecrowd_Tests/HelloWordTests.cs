using Beecrowd;
using NUnit.Framework;
using System;
using System.IO;

namespace Beecrowd_Tests
{
    public class Hello_Word_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _1000_Hello_Word()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            _ = new Hello_Word();
            
            string outPut = stringWriter.ToString();
            Console.SetOut(Console.Out);
            
            Assert.AreEqual("Hello World!" + Environment.NewLine , outPut);
        }
    }

}