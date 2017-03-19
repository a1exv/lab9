using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DeserializeConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> list = new List<PC>();
            BinaryFormatter bf = new BinaryFormatter();
            string path = "D:/volodkevich/c#/listSerial.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            do
            {
                {
                    list.Add((PC)bf.Deserialize(fs));
                }
            } while (fs.Position!=fs.Length);
            fs.Close();
            Console.WriteLine(list[2].isOn);
        }
    }
}
