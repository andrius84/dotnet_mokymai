using Paskaita_8_Uzduotis.Entities;

namespace Paskaita_8_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
           // PathScanner.ScanFolder(@"C:\temp\");

            PathScanner.ScanAllFolders(@"C:\temp\");


        }
    }
}
