using System;
using System.IO;

namespace FileOrganizerTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the File Organizer Tool!");

            
            Console.Write("Please enter the directory path you want to organize: ");
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                try
                {
                    OrganizeFiles(directoryPath);
                    Console.WriteLine("Files have been successfully organized!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("The specified directory does not exist!");
            }

            Console.ReadLine();
        }

        static void OrganizeFiles(string directoryPath)
        {
            
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                
                string fileExtension = Path.GetExtension(file).ToLower();

                
                string folderName = GetFolderName(fileExtension);

                
                string folderPath = Path.Combine(directoryPath, folderName);

                
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                
                string fileName = Path.GetFileName(file);
                string newFilePath = Path.Combine(folderPath, fileName);
                File.Move(file, newFilePath);

                Console.WriteLine($"{fileName} has been moved to the {folderName} folder.");
            }
        }

        static string GetFolderName(string fileExtension)
        {
            
            switch (fileExtension)
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                    return "Images";
                case ".pdf":
                case ".doc":
                case ".docx":
                case ".xls":
                case ".xlsx":
                    return "Documents";
                case ".mp3":
                case ".wav":
                    return "Music";
                case ".mp4":
                case ".avi":
                case ".mkv":
                    return "Videos";
                case ".zip":
                case ".rar":
                case ".7z":
                    return "Archives";
                default:
                    return "Other";
            }
        }
    }
}