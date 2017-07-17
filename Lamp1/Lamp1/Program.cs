using Lamp1.Classes;
using Lamp1.Enum;
using Lamp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp l = new Lamp(false, );
            


    //        IDictionary<string, Lamp> LDictionary = new Dictionary<string, Lamp>();
    //        LDictionary.Add("Lamp1", new Lamp(false, Level.Medium);
    //        LDictionary.Add("Lamp2", new Lamp(false, Level.Medium));

    //        while (true)
    //        {
    //            Console.Clear();
    //            foreach (var ill in LDictionary)
    //            {
    //                Console.WriteLine("Название: " + L.Key + ", " + L.Value.ToString());
    //            }
    //            Console.WriteLine();
    //            Console.Write("Введите команду: ");

    //            string[] commands = Console.ReadLine().Split(' ');
    //            if (commands[0].ToLower() == "exit" & commands.Length == 1)
    //            {
    //                return;
    //            }
    //            if (commands.Length != 2)
    //            {
    //                Help();
    //                continue;
    //            }
    //            if (commands[0].ToLower() == "add" && !LDictionary.ContainsKey(commands[1]))
    //            {
    //                LDictionary.Add(commands[1], new Lamp(false, BrightnessLevel.Medium));
    //                continue;
    //            }
    //            if (commands[0].ToLower() == "add" && LDictionary.ContainsKey(commands[1]))
    //            {
    //                Console.WriteLine("Устройство с таким именем уже существует");
    //                Console.WriteLine("Нажмите любую клавишу для продолжения");
    //                Console.ReadLine();
    //                continue;
    //            }
    //            if (!LDictionary.ContainsKey(commands[1]))
    //            {
    //                Help();
    //                continue;
    //            }
    //            switch (commands[0].ToLower())
    //            {
    //                case "del":
    //                    LDictionary.Remove(commands[1]);
    //                    break;
    //                case "on":
    //                    LDictionary[commands[1]].On();
    //                    break;
    //                case "off":
    //                    LDictionary[commands[1]].Off();
    //                    break;
    //                case "brightlow":
    //                    LDictionary[commands[1]].LowBrightness();
    //                    break;
    //                case "brightmedium":
    //                    LDictionary[commands[1]].MediumBrightness();
    //                    break;
    //                case "brighthigh":
    //                    LDictionary[commands[1]].HighBrightness();
    //                    break;
    //                default:
    //                    Help();
    //                    break;
    //            }
    //        }
    //    }

    //    private static void Help()
    //    {
    //        Console.WriteLine("Доступные команды:");
    //        Console.WriteLine("\tadd nameLamp");
    //        Console.WriteLine("\tdel nameLamp");
    //        Console.WriteLine("\ton nameLamp");
    //        Console.WriteLine("\toff nameLamp");
    //        Console.WriteLine("\tbrightlow nameLamp");
    //        Console.WriteLine("\tbrightmedium nameLamp");
    //        Console.WriteLine("\tbrighthigh nameLamp");
    //        Console.WriteLine("\texit");
    //        Console.WriteLine("Нажмите любую клавишу для продолжения");
    //        Console.ReadLine();
    //    }
    
    //}
}
