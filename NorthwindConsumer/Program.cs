// See https://aka.ms/new-console-template for more information
using NorthWindConsunmer;
using System.Net.Http.Json;

Console.WriteLine("Press Enter When the API Starts");

Console.ReadLine();

HttpClient client = new HttpClient();

var customer = await client.GetFromJsonAsync<List<Customer>>("https://localhost:7288/api/Customer");

var order = await client.GetFromJsonAsync<List<Order>>("https://localhost:7288/api/Order");

var result = from cust in customer
             join ord in order on cust.CustomerId equals ord.OrderId
             join 
