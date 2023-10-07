using Beecrowd;
using NUnit.Framework;
using System;
using System.IO;

namespace Beecrowd_Tests
{
    class SomaSimplesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _1003_Soma_Simples10_30()
        {
            //Input de dados no console
            StringReader input = new StringReader("30\n10\n");
            Console.SetIn(input);
            
            //OutPut de dados do Console
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Resultado esperado no console
            string exepected = "SOMA = 40";
            
            //Instanciação do objeto
            _ = new Soma_Simples();

            string outPut = stringWriter.ToString();
            
            Console.SetOut(Console.Out);

            Assert.AreEqual(exepected + Environment.NewLine, outPut);
        }

        [Test]
        public void _1003_Soma_SimplesMenos30_10()
        {
            //Input de dados no console
            StringReader input = new StringReader("-30\n10\n");
            Console.SetIn(input);

            //OutPut de dados do Console
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Resultado esperado no console
            string exepected = "SOMA = -20";

            //Instanciação do objeto
            _ = new Soma_Simples();

            string outPut = stringWriter.ToString();

            Console.SetOut(Console.Out);

            Assert.AreEqual(exepected + Environment.NewLine, outPut);
        }
        [Test]
        public void _1003_Soma_Simples0_0()
        {
            //Input de dados no console
            StringReader input = new StringReader("0\n0\n");
            Console.SetIn(input);

            //OutPut de dados do Console
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Resultado esperado no console
            string exepected = "SOMA = 0";

            //Instanciação do objeto
            _ = new Soma_Simples();

            string outPut = stringWriter.ToString();

            Console.SetOut(Console.Out);

            Assert.AreEqual(exepected + Environment.NewLine, outPut);
        }
    }
}
