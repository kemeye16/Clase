using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolverEcuacionCuadratica;

namespace ResolverEcuacionCuadratica.Test
{
    /*
    declare variables para los parametros reales
declare variables para los resultados reales
Declare variables para los resultados esperados
construya la logica que realiza la prueba
asegurese de que los valores reales son iguales a los esperados
    */
    [TestClass]
    public class PruebaUnitariaEcuacionCuadratica
    {
        [TestMethod]
        public void ProbarResolverCorrectoMuyMuyCercano()
        {
            double primeroNumero = -1;
            double segundoNumero = 2;
            double tercerNumero = 3;
            double primeraRaizReal = 0;
            double segundaRaizReal = 0;
            double primeraRaizEsperada = 3;
            double segundaRaizEsperada = -1;

            ResolverEcuacionCuadratica ecuacionCuadratica = new ResolverEcuacionCuadratica();
            //invoque el metodo correspondiente
            ecuacionCuadratica.ResolverLaEcuacionCuadratica(primeroNumero, segundoNumero, tercerNumero, ref primeraRaizReal, ref segundaRaizReal);

            Assert.IsTrue((primeraRaizEsperada == primeraRaizReal)||
                          (primeraRaizEsperada == segundaRaizReal));
            Assert.IsTrue((segundaRaizEsperada == primeraRaizReal) ||
                          (segundaRaizEsperada == segundaRaizReal)); ;

        }
    }
    /*
    tarea Moral:
    cree pruebas unitarias para los siguientes casos:
    -Pruebas correctas para resultados reales con muchos decimales,
    de modo que la coincidencia NO sea exacta y se apruebe
    cuando hay coincidan al menos en el sexto decimal
    -pruebas correctas para cuando el discriminante 
    */
}