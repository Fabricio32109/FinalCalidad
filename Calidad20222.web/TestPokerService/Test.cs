using Calidad20222.web.Models;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models = Calidad20222.web.Models;

namespace TestPokerService
{
    public class Test
    {
        [Test]
        public void TestEscaleraReal()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 10;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 13;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 11;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA REAL", result);
        }
        [Test]
        public void TestEscaleraDeColor()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 4;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 8;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA DE COLOR", result);
        }
        [Test]
        public void TestPoker()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("POKER", result);
        }
        [Test]
        public void TestFull()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("FULL", result);
        }
        [Test]
        public void TestColor()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 11;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 8;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("COLOR", result);
        }
        [Test]
        public void TestEscalera()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 10;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 9;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 8;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA", result);
        }
        [Test]
        public void TestTrio()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("TRIO", result);
        }
        [Test]
        public void TestDoblePareja()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 11;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 11;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 9;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 9;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("DOBLE PAREJA", result);
        }
        [Test]
        public void TestPareja()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 9;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("DOBLE", result);
        }
        [Test]
        public void TestCartaAlta()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 10;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("CARTA MAYOR", result);
        }
        [Test]
        public void TestEscaleraReal2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 13;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 12;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 11;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 10;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA REAL", result);
        }
        [Test]
        public void TestEscaleraDeColor2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 4;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA DE COLOR", result);
        }
        [Test]
        public void TestPoker2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("POKER", result);
        }
        [Test]
        public void TestFull2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("FULL", result);
        }
        [Test]
        public void TestColor3()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 9;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 2;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("COLOR", result);
        }
        [Test]
        public void TestEscalera2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 4;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 6;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("ESCALERA", result);
        }
        [Test]
        public void TestTrio2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 4;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("TRIO", result);
        }
        [Test]
        public void TestDoblePareja2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 4;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("DOBLE PAREJA", result);
        }
        [Test]
        public void TestPareja2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 1;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 4;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 7;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("DOBLE", result);
        }
        [Test]
        public void TestCartaAlta2()
        {
            List<Carta> cartas = new List<Carta>();
            Carta carta = new Carta();
            carta.Numero = 3;
            carta.Palo = Models.Palo.CORAZON;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 5;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 9;
            carta.Palo = Models.Palo.ESPADA;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 10;
            carta.Palo = Models.Palo.COCO;
            cartas.Add(carta);
            carta = new Carta();
            carta.Numero = 11;
            carta.Palo = Models.Palo.TREBOL;
            cartas.Add(carta);
            PokerService pokerService = new PokerService();
            string result = pokerService.GetJugada(cartas);
            Assert.AreEqual("CARTA MAYOR", result);
        }
    }
}
