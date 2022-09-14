// See https://aka.ms/new-console-template for more information
using System.IO;
string[] files = Directory.GetFiles(@"C:\HTML", "*.*", SearchOption.AllDirectories);
foreach (var v in files)
{
    FileInfo f1 = new FileInfo(v);

    Console.Write($"Name: {f1.Name}");
    Console.Write($" Creation Time : {f1.CreationTime}");
    Console.Write($" Last Access Time : {f1.LastAccessTime}");
    Console.Write($" File Size : {f1.Length}");
    Console.WriteLine();
}
Console.WriteLine("Divyansh");





