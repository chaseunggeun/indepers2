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
        초기화 = 0,
        로그인,
        주문
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
        public string Name { get; set; }
        public double Price { get; set; }

        public Beverage(string name, double price)
        {
            Name = name;
            Price = price;
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

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
            return total;
        }

    }
}
