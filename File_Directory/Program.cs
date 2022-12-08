// See https://aka.ms/new-console-template for more information
using System.IO;
                                        //Read All Files

//ReadAllFiles();

static void ReadAllFiles()
{
    string[] files = Directory.GetFiles(@"C:\HTML", "*.*", SearchOption.AllDirectories);
            Console.WriteLine("Name             CreationTime            LastAccessTime            Length");
    foreach (var v in files)
    {
        FileInfo f1 = new FileInfo(v);
        Console.WriteLine($"{f1.Name}       {f1.CreationTime}       {f1.LastAccessTime}     {f1.Length}");
        Console.WriteLine();
    }
}




                                            // Copy All Files
//CopyFiles(@"C:\HTML", @"C:\HTML1");
static void CopyFiles(string source, string destination) 
{
    string[] directories = Directory.GetDirectories(source,"*",SearchOption.AllDirectories);
    foreach (string directory in directories) 
    {
        Directory.CreateDirectory(directory.Replace(source,destination));
    }
    string[] files = Directory.GetFiles(source,"*.*",SearchOption.AllDirectories);
    foreach (string file in files) 
    {
        File.Copy(file, file.Replace(source, destination), true);    
    }

}







