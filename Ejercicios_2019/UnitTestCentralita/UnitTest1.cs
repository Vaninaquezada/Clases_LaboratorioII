 using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_4_Entidades;

namespace UnitTestCentralita
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void ValidaListaVacias()
    {
      Centralita c = new Centralita();

      Assert.IsNotNull(c.Llamadas);
    }

    [TestMethod]
    public void ValidarLlamadaLocalExistente()
    {
      Centralita central = new Centralita();
      Local llmadaLocal = new Local("Lanús", 45, "San Rafael", 1.99f);
      central += llmadaLocal;

      Assert.ThrowsException<CentralitaException>(() => central += llmadaLocal);
    }

    [TestMethod]
    public void ValidarLlamadaProvincialExistente()
    {
      Centralita central = new Centralita();
      Provincial llamadaProvincial = new Provincial("Morón", Provincial.Franja.Frnaja_1, "Bernal", 21);
      central += llamadaProvincial;

      Assert.ThrowsException<CentralitaException>(() => central += llamadaProvincial);
    }
  }
}
