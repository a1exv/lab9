using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        //private string brand;
        //private string serialNo;
        //private bool isOn;
        //private int hdd;
        public string brand
        {
            get;
            set;
        }
        public string serialNo
        {
            get;
            set
           ;
        }
        public bool isOn
        {
            get
            ;
            set
            ;
        }
        public int hdd
        {
            get
          ;
            set
           ;
        }
        public PC(string brand, string serialNo, int hdd)
        {
            this.hdd = hdd;
            this.serialNo = serialNo;
            this.brand = brand;
            isOn = false;
        }
        public PC()
        {
            hdd = 1000;
            serialNo = "123456789";
            brand = "default";
            isOn = false;
        }
        public void turnOn()
        {
            if (isOn == false)
            {
                isOn = true;
            }
            else Console.WriteLine("already on");
        }
        public void turnOf()
        {
            if (isOn == true)
            {
                isOn = false;
            }
            else Console.WriteLine("already off");
        }
        public void reset()
        {
            if (isOn == true)
            {
                Console.WriteLine("succesfully reset");
            }
            else Console.WriteLine("need to turn on");
        }
    }
}
