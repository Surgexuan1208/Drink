using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace drink
{
    internal class Program
    {
        private static void Main()
        {
            List<Drink> drinks = new List<Drink>();
            List<OrderItem> orders = new List<OrderItem>();
            add_drinks(drinks);
            show_drinks(drinks);
            orderdrink(drinks, orders);
        }

        private static void orderdrink(List<Drink> drinks, List<OrderItem> orders)
        {
            Console.WriteLine("\n請開始訂購，按下X鍵結束");
            string s;
            int index, quantity, subtotal;
            while (true)
            {
                Console.WriteLine("請輸入編號:");
                s = Console.ReadLine();
                if (s == "x")
                {
                    Console.WriteLine("謝謝惠顧，歡迎下次再來。");
                    break;
                }
                else
                {
                    index=int.Parse(s);
                }

            }

        }
        private static void show_drinks(List<Drink> drinks)
        {
            /*for(int i= 0; i < drinks.Count; i++)
            {
                Console.WriteLine($"飲料名稱:{drinks[i].name} 尺寸:{drinks[i].size} 價格:{drinks[i].price}");
            }*/
            Console.WriteLine("飲料清單:\n");
            //Console.WriteLine($"{"品名",-5}{"大小杯",3}{"價格",6}");
            Console.WriteLine(string.Format("{0,-5}{1,-5}{2,-3}{3,6}", "編號","品名","大小杯","價格"));
            int i = 0;
            foreach (Drink drink in drinks)
            {
                Console.WriteLine($"{i,-6} {drink.name,-5} {drink.size,-3} {drink.price,5:C1}");
                i++;
            }
        }

        private static void add_drinks(List<Drink> drinks)
        {
            drinks.Add(new Drink() { name = "紅茶", size = "大杯", price = 50 });
            drinks.Add(new Drink() { name = "紅茶", size = "小杯", price = 30 });
            drinks.Add(new Drink() { name = "綠茶", size = "大杯", price = 50 });
            drinks.Add(new Drink() { name = "綠茶", size = "小杯", price = 30 });
            drinks.Add(new Drink() { name = "咖啡", size = "大杯", price = 60 });
            drinks.Add(new Drink() { name = "咖啡", size = "小杯", price = 40 });
        }
    }
}