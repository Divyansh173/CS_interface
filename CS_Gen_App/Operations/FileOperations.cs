using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CS_Gen_App.Operations
{
    
    public class FileOperations
    {
        public void CreateFile(string directory, string filename)
        {
            string lastThree = filename.Substring(filename.Length - 3);
            try
            {
                // string root = $"{directory}{filename}";
                if (!Directory.Exists(directory))
                {
                    throw new Exception("Directory does not exists");
                }
                if (lastThree != "txt")
                {
                    throw new Exception("File must be .txt file");
                }
                if (directory == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                FileStream fs = File.Create($"{directory}/{filename}");
                // Close the file so that the handle can be released
                // and the file is accessible fr other operations
                fs.Close();
                fs.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void WriteFile(string directory, string fileName, string[] contents)
        {
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                File.WriteAllLines($"{directory}/{fileName}", contents);
                //Console.WriteLine("Contents are written to the File");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
