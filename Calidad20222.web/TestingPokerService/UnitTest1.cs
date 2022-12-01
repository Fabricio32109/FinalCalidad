using Calidad20222.web.Models;
using Calidad20222.web.Services;
using System.Reflection;
using Models = Calidad20222.web.Models;

namespace TestingPokerService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 10;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta.Numero = 11;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta.Numero = 13;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta.Numero = 12;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA REAL", result);
        }
    }
}