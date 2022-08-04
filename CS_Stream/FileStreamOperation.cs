using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_Stream
{
    public class FileStreamOperation : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public FileStreamOperation()
        {
            filePath = @"C:\Files\jamesbond.txt";
        }

        //public void CreateFile()
        //{
        //    try
        //    {
        //        fs = new FileStream(filePath, FileMode.CreateNew);
        //        fs.Close();
        //        // fs.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void WriteFile(string contents)
        //{
        //    try
        //    {
        //        fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
        //        StreamWriter sw = new StreamWriter(fs);
        //        sw.Write(contents);
        //        sw.Close();
        //        sw.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public string ReadFile()
        {
            string str = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                str = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }

        public void ReadFile1() 
        {
            string ln = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while ((ln = sr.ReadLine()) != null)  
                {
                    Console.WriteLine(ln);
                };
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return str;
        }

        public void read_specific() 
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32((Console.ReadLine()));
            string str = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                str = sr.ReadToEnd();
                if (end > str.Length) {
                    throw new Exception("Size is greater than current dile size");
                }
                for (int i = start; i <= end; i++) 
                {
                    Console.Write(str[i]);
                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}