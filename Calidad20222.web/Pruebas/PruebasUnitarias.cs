using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calidad20222.web.Pruebas
{
    public class PruebasUnitarias
    {
        public void Test1()
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
