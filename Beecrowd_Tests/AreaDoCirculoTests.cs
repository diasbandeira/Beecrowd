using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beecrowd;

namespace Beecrowd_Tests
{
    public class AreaDoCirculoTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AreaDoCirculo2()
        {
            StringReader input = new StringReader("2.00 \n");
            string expected = "A=12.5664";
            StringWriter stringWriter = new StringWriter();

            Console.SetIn(input);

            Console.SetOut(stringWriter);
            _ = new AreaDoCirculo();
            string outPut = stringWriter.ToString();
            Console.SetOut(Console.Out);

            //Assert.AreEqual("Hello World!" + Environment.NewLine, outPut);
            Assert.AreEqual(expected + Environment.NewLine, outPut);
        }
    }
}
