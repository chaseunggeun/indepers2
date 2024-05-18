using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PacketLibrary
{
    public enum PacketType
    {
        주문 = 0,
        알림
    }

    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }
    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;

        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }

        public static byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        public static Object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach(byte b in bt)
            {
                ms.WriteByte(b);
            }

            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }

    [Serializable]
    public class Initiailize : Packet
    {
        public int Data = 0;
    }
    [Serializable]
    public class Login : Packet
    {
        public string m_strID;
        public Login()
        {
            this.m_strID = null;
        }
    }


    [Serializable]
    public class Beverage : Packet
    {
        private int price;
        private string name;
        private string category;
        private bool isDessert;
        private int[] option;
        public int getPrice()
        {
            return price;
        }
        public string getName()
        {
            return name;
        }
        public string getCategory()
        {
            return category;
        }
        public bool getIsDessert()
        {
            return isDessert;
        }

        public Beverage(int price, string name, string category, bool isDessert, int[] option)
        {
            this.price = price;
            this.name = name;
            this.category = category;
            this.isDessert = isDessert;
            this.option = option;
        }
    }

    [Serializable]
    public class ShoppingCart : Packet
    {
        public List<Beverage> items;

        public ShoppingCart()
        {
            items = new List<Beverage>();
        }

        public void AddItem(Beverage beverage)
        {
            items.Add(beverage);
        }

        public void RemoveItem(Beverage beverage)
        {
            items.Remove(beverage);
        }

        public int CalculateTotalPrice()
        {
            int total = 0;
            foreach(var item in items)
            {
                total += item.getPrice();
            }
            return total;
        }
    }

}
