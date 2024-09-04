using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Paskaita_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Category
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int CategoryId { get; set; }

            [Required]
            public string Name { get; set; }

            // Navigacijos savybė, kuri nurodo ryšį su Product klase
            public ICollection<Product> Products { get; set; } 
        }

        public class Product
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ProductId { get; set; }

            [Required]
            public string Name { get; set; }

            // Svetimas raktas į Category lentelę
            public int CategoryId { get; set; }

            // Navigacijos savybė, kuri nurodo ryšį su Category klase
            public Category Category { get; set; }
        }

    }
}
