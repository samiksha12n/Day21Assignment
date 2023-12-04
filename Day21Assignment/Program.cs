// See https://aka.ms/new-console-template for more information
using System;
using Day21Assignment;
using Microsoft.VisualBasic;
using System.Text.Json;
Console.WriteLine("Welcome to Json Serialization in .net core");
Employee emp = new Employee()
{
    Id = 12,
    FirstName = "Sanjiv" ,
    LastName= "Kumar",
    Salary = 98000.90,
};
string jsonString = JsonSerializer.Serialize(emp);
string fileName = @"EmployeeData.json";
File.WriteAllText(fileName, jsonString);
using FileStream fs = File.Create(fileName);
await JsonSerializer.SerializeAsync(fs, emp);
await fs.DisposeAsync();
Console.WriteLine("File Stream Created Stored & Diplayed here");
Console.WriteLine(File.ReadAllText(fileName));
Console.WriteLine(jsonString);
Console.ReadKey();