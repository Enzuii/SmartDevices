//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using AdapterExample;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Plug plug1 = new Plug("1");
            ISmartDevice bulb1 = new Bulb("1");
            ISmartDevice washingMachine1 = new WashingMachine("1");
            ISmartDevice adapter1 = new Adapter(plug1);          
            Console.WriteLine($"Plug status: {adapter1.GetStatus()}");
            Console.WriteLine($"Prendiendo el plug");
            adapter1.On();
            Console.WriteLine($"Plug status: {adapter1.GetStatus()}");
            Console.WriteLine($"Bulb status: {bulb1.GetStatus()}");
            Console.WriteLine($"Prendiendo la bulb");
            bulb1.On();
            Console.WriteLine($"Bulb status: {bulb1.GetStatus()}");
            Console.WriteLine($"Washing machine status: {washingMachine1.GetStatus()}");
            Console.WriteLine($"Prendiendo la washing machine");
            washingMachine1.On();
            Console.WriteLine($"Washing machine status: {washingMachine1.GetStatus()}");
            Console.WriteLine($"Apagando el plug");
            adapter1.Off();
            Console.WriteLine($"Plug status: {adapter1.GetStatus()}");
        }
    }
}