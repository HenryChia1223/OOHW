using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_HW
{
    class Program
    {

        public static int num_Circle;
        public static int num_Triangle;
        public static int num_Square;

        public static string input = "0";

        static void Main(string[] args)
        {

            List<DataBase.Shape> list = new List<DataBase.Shape>();
           
          
            while (!input.Equals("4")) {
                Console.WriteLine("請輸入數字(1.Circle  2.Triangle  3.Square  4.輸入完畢): ");
                input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        list.Add(new DataBase.Circle());
                        break;

                    case 2:
                        list.Add(new DataBase.Triangle());
                        break;

                    case 3:
                        list.Add(new DataBase.Square());
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("輸入錯誤!");
                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (DataBase.Shape i in list)
            {
                int c = i.get_code();
                if (c == 1)
                {
                    num_Circle++;
                }
                else if(c == 2)
                {
                    num_Triangle++;
                }
                else
                {
                    num_Square++;
                }
            }

            Console.WriteLine("Circle:"+num_Circle+"個，"+ "Triangle:" + num_Triangle + "個，"+ "Square:" + num_Square + "個");
            Console.WriteLine();

            Console.WriteLine("排序前:");
            foreach (DataBase.Shape i in list)
            {
                i.display();
            }

            Console.WriteLine();

            List<DataBase.Shape> list_copy = list.ToList();
            List<DataBase.Shape> list_sorted = new List<DataBase.Shape>();

            int min = Int32.MaxValue;
            int num = 0;
            int add = 0;
            foreach (DataBase.Shape i in list)
            {
                
                foreach (DataBase.Shape j in list_copy)
                {
                    int s = j.get_edge();
                    if (s < min)
                    {
                        min = s;
                        add = num;
                    }
                    num++;
                }
                list_sorted.Add(list_copy[add]);
                list_copy.RemoveAt(add);
                min = Int32.MaxValue;
                num = 0;
                add = 0;
                
            }

            

            Console.WriteLine("根據edge數量由小到大排序後:");
            foreach (DataBase.Shape i in list_sorted)
            {
                i.display();
            }

            Console.ReadLine();
        }
    }


   
}
