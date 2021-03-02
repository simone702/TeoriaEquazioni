using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDeterminedTest()
        {
            double a = 6;
            bool valoreaspettato = true;
            bool valoreritorno = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreaspettato, valoreritorno);
        }
        [TestMethod]
        public void IsInconsistedTest()
        {
            double a = 8;
            double b = 4;
            bool valoreaspettato = false;
            bool valoreritorno = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valoreaspettato, valoreritorno);
        }
        [TestMethod]
        public void IsDegree2Test()
        {
            double x = 2;
            bool valoreaspettato = true;
            bool valoreritorno = Equazioni.IsDegree2(x);
            Assert.AreEqual(valoreaspettato, valoreritorno);
        }
        [TestMethod]
        public void DeltaTest()//1*1-24=-23
        {
            double a = 3;
            double b = 1;
            double c = 2;
            double valoreaspettato = -23;
            double valoreritorno = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreaspettato, valoreritorno);
        }
        [TestMethod]
        public void SoluzioniTest()
        {
            double a = 3;
            double b = 1;
            double c = 2;
            string valoreaspettato = "impossibile";
            string valoreritorno = Equazioni.Soluzioni(a, b, c);
            Assert.AreEqual(valoreaspettato, valoreritorno);
        }
        [TestMethod]
        public void EquationDegree1Test()
        {
            double a = 2;
            double b = 4;
            string valoreaspettato = "x = 2";
            string valoreritorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreaspettato, valoreritorno);
        }
    }


}
