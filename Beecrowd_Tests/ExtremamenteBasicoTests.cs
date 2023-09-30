using NUnit.Framework;
using System;
using System.IO;
using Beecrowd;

namespace Beecrowd_Tests
{
    public class ExtremamenteBasicoTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _1001_ExtremamenteBasico_10_9()
        {
            
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            StringReader input1 = new("10\n 9\n");
            
            Console.SetIn(input1);
            
            _ = new Extremamente_Basico();

            string outPut = stringWriter.ToString();
            
            Console.SetOut(Console.Out);
            
            Assert.AreEqual("X = 19" + Environment.NewLine , outPut);
        }
        [Test]
        public void _1001_ExtremamenteBasico_Menos10_4()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string input1 = "-10\n 4\n";
            
            Console.SetIn(new StringReader(input1));
            
            _ = new Extremamente_Basico();


            string outPut = stringWriter.ToString();

            Console.SetOut(Console.Out);

            Assert.AreEqual("X = -6" + Environment.NewLine, outPut);
        }
        [Test]
        public void _1001_ExtremamenteBasico_15_Menos7()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string input = "15\n -7\n";

            Console.SetIn(new StringReader(input));

            _ = new Extremamente_Basico();


            string outPut = stringWriter.ToString();

            Console.SetOut(Console.Out);

            Assert.AreEqual("X = 8" + Environment.NewLine, outPut);
        }

    }

}