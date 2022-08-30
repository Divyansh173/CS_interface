using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
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
            string str = string.Empty;
            //string input = Console.ReadLine().ToLower();
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //str = sr.ReadToEnd();
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    var a = JsonConvert.DeserializeObject<Staff>(line);
                    if (a.staff_category == "doctor")
                    {
                        Console.Write(a.StaffName);
                        //Console.WriteLine();
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
            string str = string.Empty;
            string input = Console.ReadLine().ToLower();
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //str = sr.ReadToEnd();
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains($"Id: {input} "))
                    {
                        Console.Write(line);
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
