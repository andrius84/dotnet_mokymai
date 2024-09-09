using Paskaita_8_Uzduotis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8_Uzduotis
{
    public static class PathScanner
    {
        public static void ScanFolder(string path)
        {
            var directoryPath = path;

            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }

            var files = Directory.GetFiles(directoryPath);

            using (var context = new AppDbContext())
            {
                foreach (var filePath in files)
                {
                    var fileInfo = new FileInfo(filePath);

                    var fileModel = new FileModel
                    {
                        Name = fileInfo.Name,
                        Size = fileInfo.Length,
                        FullPath = fileInfo.FullName
                    };

                    context.Files.Add(fileModel);
                }

                context.SaveChanges();

                Console.WriteLine("File information has been saved to the database.");
            }
        }

        public static void ScanAllFolders(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }
            using (var context = new AppDbContext())
            {
                ProcessDirectory(context, path);
                context.SaveChanges();
                Console.WriteLine("File and folder information has been saved to the database.");
            }
        }

        private static void ProcessDirectory(AppDbContext context, string directoryPath)
        {
            var directoryInfo = new DirectoryInfo(directoryPath);

            var folderModel = new FolderModel
            {
                Name = directoryInfo.Name
            };
            context.Folders.Add(folderModel);
            context.SaveChanges();

            var files = Directory.GetFiles(directoryPath);
            foreach (var filePath in files)
            {
                var fileInfo = new FileInfo(filePath);
                var fileModel = new FileModel
                {
                    Name = fileInfo.Name,
                    Size = fileInfo.Length,
                    FullPath = fileInfo.FullName,
                    FolderId = folderModel.Id
                };
                context.Files.Add(fileModel);
            }

            var subdirectories = Directory.GetDirectories(directoryPath);
            foreach (var subdirectory in subdirectories)
            {
                ProcessDirectory(context, subdirectory);
            }
        }
    }
}
