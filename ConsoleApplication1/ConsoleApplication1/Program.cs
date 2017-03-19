using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace ConsoleApplication1
{
    class Program
    {
        static void serial(List<PC> list){
            BinaryFormatter bf = new BinaryFormatter();
            string path = "D:/volodkevich/c#/serialPC";
            for (var i = 0; i < list.Count; i++)
            {
                FileStream fs = new FileStream(String.Format(path + "/" + (i + 1) + ".txt"), FileMode.Create, FileAccess.ReadWrite);
                bf.Serialize(fs, list[i]);
                fs.Close();
                fs.Dispose();
            }
        }
        static void Main(string[] args)
        {
            List<PC> pcLIST = new List<PC>();
            for (var i = 0; i < 5; i++)
            {
                pcLIST.Add(new PC());
            }
         
            if (File.Exists("D:/volodkevich/c#/listSerial.txt"))
            {
                Console.WriteLine("File listSerial exists, will be deleted");
            }
            string path = "D:/volodkevich/c#/listSerial.txt";
            pcLIST[2].isOn = true;
            BinaryFormatter bw = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            for (var i = 0; i < 5; i++)
            {
                bw.Serialize(fs, pcLIST[i]);
            }
            fs.Close();
            serial(pcLIST);
           
        }
    }
}
