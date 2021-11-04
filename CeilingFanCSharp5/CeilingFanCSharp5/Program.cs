using CeilingFanCSharp5.Models;
using System;

namespace CeilingFanCSharp5
{
    class Program
    {
        private static CeilingFan fan;

        static void Main(string[] args)
        {
            fan = new CeilingFan();

            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("============WELCOME TO FAN============");
            Console.WriteLine("\r\nFAN STATUS");
            FanStatus();

            Console.WriteLine("\r\nChoose an option:");
            Console.WriteLine("1) Pull Direction Cord");
            Console.WriteLine("2) Pull Speed Cord");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ChangeDirection();
                    return true;
                case "2":
                    IncrementSpeed();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void ChangeDirection() => fan.PullDirectionCord();

        private static void FanStatus()
        {
            Console.WriteLine($"Direction: {fan.Direction}");
            Console.WriteLine($"Speed: {fan.Speed}");
        }

        private static void IncrementSpeed() => fan.PullSpeedCord();

    }
}
