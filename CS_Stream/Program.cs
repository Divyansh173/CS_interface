﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CS_Stream;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("USing Stream");
FileStreamOperation operation = new FileStreamOperation();
try
{

    // operation.CreateFile();

    // operation.WriteFile("I am from Stream");
    string str = operation.ReadFile();

    Console.WriteLine(str);

   operation.ReadFile1();

    operation.read_specific();

    //Console.WriteLine(str1);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    operation.Dispose();
}
Console.ReadLine();
