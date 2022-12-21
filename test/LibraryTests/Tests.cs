//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using AdapterExample;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Prueba de las clases <see cref="Adapter"/> <see cref="Bulb"/> <see cref="WashingMachine"/>.
    /// </summary>
    [TestFixture]
    public class TrainTests
    {
        
        private Plug plug1;

        private ISmartDevice bulb1;

        private ISmartDevice washingMachine1; 
        private ISmartDevice adapter1;

        [Test]
        public void turnOnPlug()
        {
            plug1 = new Plug("1");
            ISmartDevice adapter1 = new Adapter(plug1);
            adapter1.On();
            Assert.AreEqual("on", adapter1.GetStatus());
        }
        [Test]
        public void turnOffPlug()
        {
            plug1 = new Plug("1");
            ISmartDevice adapter1 = new Adapter(plug1);
            adapter1.On();
            adapter1.Off();
            Assert.AreEqual("off", adapter1.GetStatus());
        }

        [Test]
        public void turnOnBulb()
        {
            bulb1 = new Bulb("1");
            bulb1.On();
            Assert.AreEqual("on", bulb1.GetStatus());
        }
        [Test]
        public void turnOnWashingMachine()
        {
            washingMachine1 = new WashingMachine("1");
            washingMachine1.On();
            Assert.AreEqual("on", washingMachine1.GetStatus());
        }      
    }
}