﻿using System;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Alum = new Alumno();

            Console.WriteLine("El alumno " + Alum.nombre);
            Alum.ApellidoPaterno;
            Alum.ApellidoMaterno;
        }
    }
}