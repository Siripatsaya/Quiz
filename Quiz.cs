using System;
using System.Collections.Generic;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputWarrior;
            int mode;

            Console.Write("Input Total Warrior: ");
            inputWarrior = int.Parse(Console.ReadLine());
            Console.WriteLine("1 = Fighter ");
            Console.WriteLine("2 = Wizard ");
            Console.WriteLine("3 = Hunter ");
            Console.WriteLine("4 = Bow Master ");         
            Console.Write("Input your occupation: ");
            int.TryParse(Console.ReadLine(),out mode);

            if (mode == 1)
            {
                List<Warrior> listWarriors;
            }
            else if (mode == 2)
            {
                List<Warrior> listWarriors;
            }
            else if (mode == 3)
            {
                List<Warrior> listWarriors;
            }
            else if (mode == 4)
            {
                List<Warrior> listWarriors;
            }
            else
            { }              
        }

        class Warrior
        {
            public int Level;
            public string Warriorname;
            public string ATK;
            public string DEF;
            public string SP_ATK;
            public string SP_DEF;
            public string SPEED;

            public Warrior(int valueLevel, string valueWarriorname, string valueATK, string valueDEF, string valueSP_ATK, string valueSP_DE, string valueSPEED)
            {
                Level = valueLevel;
                Warriorname = valueWarriorname;
                ATK = valueATK;
                DEF = valueDEF;
                SP_ATK = valueSP_ATK;
                SP_DEF = valueSP_DE;
                SPEED = valueSPEED;
            }
        }

        class information
        {
            List<Warrior> listWarriors;
        }

    }
}

