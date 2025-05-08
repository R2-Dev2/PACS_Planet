using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FileUtils
{
    public static class MyFileUtils
    {
        public static void CreateOrEmptyDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            else
            {
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
        }

        public static void CreateAndWriteToTxt(string fileName, string text)
        {
            try
            {
                using (FileStream fs = new FileStream($"./{fileName}.txt", FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(text);
                    sw.Flush();
                }
            }
            catch (Exception)
            {

            }
        }

        public static Image GetImageFromUrl(string url)
        {
            Image img = null;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (Stream stream = webClient.OpenRead(url))
                    {
                        img = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return img;
        }
    }
}
