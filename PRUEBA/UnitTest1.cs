using Microsoft.VisualStudio.TestTools.UnitTesting;
using DOMINIO;
namespace PRUEBA
{
    [TestClass]
    public class UnitTest1
    {
        static PERSONA P=new PERSONA
            {
                Nombre="hhh",
                Password=1234,
                Saldo=1000,
            };
        [TestMethod]
        public void TestMethod1()
        {
            /*var P=new PERSONA
            {
                Nombre="hhh",
                Password=1234,
                Saldo=1000,
            };*/
            bool r=CONSOLA.Program.Metodo1(1234,P.Password);
            Assert.AreEqual(false,r);
        }
         [TestMethod]
        public void TestMethod2()
        {
            
            bool r=CONSOLA.Program.Metodo1(1234,P.Password);
            Assert.AreEqual(true,r);
        }
    }
}
