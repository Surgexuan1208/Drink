using System;
using System.Collections.Generic;
namespace drink
{
    internal class Program
    {
        private static void Main()
        {
            List<Drink> drinks = new List<Drink>();
            drinks.Add(new Drink() { name = "紅茶", size = "大杯", price = 50 });
            drinks.Add(new Drink() { name = "紅茶", size = "小杯", price = 30 });
            drinks.Add(new Drink() { name = "綠茶", size = "大杯", price = 50 });
            drinks.Add(new Drink() { name = "綠茶", size = "小杯", price = 30 });
            drinks.Add(new Drink() { name = "咖啡", size = "大杯", price = 60 });
            drinks.Add(new Drink() { name = "咖啡", size = "小杯", price = 40 });
        }
    }
}