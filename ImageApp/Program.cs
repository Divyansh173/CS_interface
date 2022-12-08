//// See https://aka.ms/new-console-template for more information
using System.Drawing;
                                    //Read an Image File

static void ReadImageFile()
{
    string path = @"C:\Image\screenshot.abcd";
    FileInfo fileInfo = new FileInfo(path);
    Console.WriteLine(fileInfo.Extension);
    Console.WriteLine(fileInfo.Name);
    Console.WriteLine(fileInfo.Extension);
}


                                    //Image TO Byte Array

Image image = Image.FromFile(@"C:\Image\Screenshot.jpg");
byte[] Byte = ImageToByteArray(image);
foreach (var v in Byte)
{
    Console.WriteLine(v);
}

static byte[] ImageToByteArray(Image imageIn)
{
   // System.Drawing.Image imageIn = System.Drawing.Image.FromFile();
    using (var ms = new MemoryStream())
    {
        imageIn.Save(ms, imageIn.RawFormat);
        return ms.ToArray();
    }
}


                                        // Byte To Image Array

string path1 = @"C:\Image1\Screenshot.png";
//Image image2 = byteArrayToImage(Byte);
//image2.Save(path1);
//Console.WriteLine(image2);

static Image byteArrayToImage(byte[] byteArray)
{
    MemoryStream ms = new MemoryStream(byteArray);
    Image returnImage = Image.FromStream(ms);
    return returnImage;
}



                                            //JPG To PNG

string path = @"C:\Image\picture.jpg";
string destination = @"C:\Image1";
//jpgTopng(path,destination);
static void jpgTopng(string source, string destination)
{
    FileInfo fileInfo1 = new FileInfo(source);
    //Path.ChangeExtension(source, ".png");
    string destination1 = $@"{destination}\{fileInfo1.Name}";
    fileInfo1.CopyTo(Path.ChangeExtension(destination1, ".png"));
}


