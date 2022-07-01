using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week15_1
{
    class Program
    {

        class Student
        {
            public string ID, Name;
            public int Chi, Eng, Math;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR_week15_1");

            Student 段昱如_1_1;
            段昱如_1_1 = new Student();
            段昱如_1_1.ID = "B0226497_1";
            段昱如_1_1.Name = "段昱如_1_1";
            段昱如_1_1.Chi = 78;
            段昱如_1_1.Eng = 67;
            段昱如_1_1.Math = 89;
            Student 段昱如_1_2;
            段昱如_1_2 = new Student();
            段昱如_1_2.ID = "B0226497_2";
            段昱如_1_2.Name = "段昱如_1_2";
            段昱如_1_2.Chi = 80;
            段昱如_1_2.Eng = 56;
            段昱如_1_2.Math = 79;
            Student 段昱如_1_3;
            段昱如_1_3 = new Student();
            段昱如_1_3.ID = "B0226497_3";
            段昱如_1_3.Name = "段昱如_1_3";
            段昱如_1_3.Chi = 99;
            段昱如_1_3.Eng = 98;
            段昱如_1_3.Math = 89;
            Console.WriteLine("同學1:");
            Console.WriteLine($"學號:{段昱如_1_1.ID},姓名:{段昱如_1_1.Name}," +
                $"國文:{段昱如_1_1.Chi},數學:{段昱如_1_1.Math},英文:{段昱如_1_1.Eng}");
            Console.WriteLine("同學2:");
            Console.WriteLine($"學號:{段昱如_1_2.ID},姓名:{段昱如_1_2.Name}," +
                $"國文:{段昱如_1_2.Chi},數學:{段昱如_1_2.Math},英文:{段昱如_1_2.Eng}");
            Console.WriteLine("同學3:");
            Console.WriteLine($"學號:{段昱如_1_3.ID},姓名:{段昱如_1_3.Name}," +
                $"國文:{段昱如_1_3.Chi},數學:{段昱如_1_3.Math},英文:{段昱如_1_3.Eng}");

            Console.ReadLine();

        }
    }
}
