using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthWind_Assignment.Models;
namespace NorthWind_Assignment.DataAccess
{
    public class DataAccess
    {
        NorthwindContext northwindContext;

        public DataAccess[] dataAccesses; 

        public DataAccess()
        {
            northwindContext = new NorthwindContext();
        }
        public void getData() 
        {
            var data = from cust in northwindContext.Customers
                       join order in northwindContext.Orders on cust.CustomerId equals order.CustomerId
                       group cust by cust.CustomerId into newTable
                       select new
                       {
                           id = newTable.Key,
                           value = newTable.Count()
                       };

            foreach (var v in data)
            {

                Console.WriteLine($"{v.id} {v.value}");
            }
        }

        public void details() 
        {
            var data = from cust in northwindContext.Customers
                       join order in northwindContext.Orders on cust.CustomerId equals order.CustomerId
                       join orderdetails in northwindContext.OrderDetails on order.OrderId equals orderdetails.OrderId
                       select new
                       {
                           id = cust.CustomerId,
                           name = cust.ContactName,
                           order = order.OrderId,
                           OrderPrice = orderdetails.UnitPrice,
                           OrderDate = order.OrderDate
                       };

            foreach (var v in data)
            {
                Console.WriteLine($"{v.id}  {v.name}  {v.order}  {v.OrderPrice}  {v.OrderDate}");
            }
        }

        public void bill() 
        {
            var data = from cust in northwindContext.Customers
                       join order in northwindContext.Orders on cust.CustomerId equals order.CustomerId
                       join orderdetails in northwindContext.OrderDetails on order.OrderId equals orderdetails.OrderId
                       group orderdetails by new { cust.CustomerId, order.OrderId } into newTable
                       select new
                       {
                           id = newTable.Key.CustomerId,
                           price = newTable.Sum(x => x.UnitPrice)
                       };
            foreach (var v in data) 
            {
                Console.WriteLine($"{v.id}  {v.price}");
            }
        }

    }
}
