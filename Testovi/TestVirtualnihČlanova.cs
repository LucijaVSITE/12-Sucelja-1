using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestVirtualnihČlanova
    {
        [TestMethod]
        public void VirtualniČlanovi_BaznaVirtualnaMetodaVraćaTekst()
        {
            VirtualniČlanovi.ISučelje s = (VirtualniČlanovi.ISučelje)(new VirtualniČlanovi.Bazna());
            Assert.AreEqual("Bazna.VirtualnaMetoda", s.VirtualnaMetoda());
        }

        [TestMethod]
        public void VirtualniČlanovi_BaznaNevirtualnaMetodaVraćaTekst()
        {
            VirtualniČlanovi.ISučelje s = (VirtualniČlanovi.ISučelje)(new VirtualniČlanovi.Bazna());
            Assert.AreEqual("Bazna.NevirtualnaMetoda", s.NevirtualnaMetoda());
        }

        [TestMethod]
        public void VirtualniČlanovi_IzvedenaVirtualnaMetodaVraćaTekst()
        {
            VirtualniČlanovi.ISučelje s = (VirtualniČlanovi.ISučelje)(new VirtualniČlanovi.Izvedena());
            Assert.AreEqual("Izvedena.VirtualnaMetoda", s.VirtualnaMetoda());
        }

        [TestMethod]
        public void VirtualniČlanovi_IzvedenaNevirtualnaMetodaVraćaTekst()
        {
            VirtualniČlanovi.ISučelje s = (VirtualniČlanovi.ISučelje)(new VirtualniČlanovi.Izvedena());
            Assert.AreEqual("Izvedena.NevirtualnaMetoda", s.NevirtualnaMetoda());
        }
    }
}
