using System;
using System.Xml.Schema;
using Paskaita_8_ManyToMany.Entities;
using Microsoft.EntityFrameworkCore;

namespace Paskaita_8_ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using var context = new BookContext();

        }
    }
}
