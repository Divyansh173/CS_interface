using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using CS_FIleStreamApp.Logic;
using CS_FIleStreamApp.Models;

namespace CS_FIleStreamApp.Search
{
    public class search : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public search()
        {
            filePath = @"C:\Files\data.txt";
        }
        public void searchbycat()
        {
            //string str = string.Empty;
            string input = Console.ReadLine().ToLower();
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    var a = JsonSerializer.Deserialize<Staff>(line);
                    if (a.staff_category == input)
                    {
                        Console.Write(a.StaffName);
                        Console.WriteLine();
                    }
                    
                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void searchbyId()
        {   
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = string.Empty;
                int input = Convert.ToInt32(Console.ReadLine());
                while ((line = sr.ReadLine()) != null)
                {
                    var data = JsonSerializer.Deserialize<Staff>(line);
                    if (data.StaffId == input)
                    {
                        Console.Write($"{data.StaffName}  {data.Email}");
                        Console.WriteLine();
                    }

                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete()
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("Enter id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            string line = string.Empty;

            List<String> li = new List<String>();
            while ((line = sr.ReadLine()) != null)
            {
                var data = JsonSerializer.Deserialize<Staff>(line);
                if (data.StaffId != id)
                {
                    li.Add(line);
                }
            }
            sr.Close();
            sr.Dispose();
            File.Delete(filePath);
            fs.Dispose();
            fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach (var v in li)
            {
                //var data = JsonSerializer.Serialize(v);
                sw.WriteLine(v);
            }
            sw.Close();
            sw.Dispose();
        }

        public void getdetailsbycount() 
        {
        }

        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
