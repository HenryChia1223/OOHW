using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_HW
{
    class DataBase
    {
        public abstract class Shape
        {
            public abstract void display();
            public abstract int get_code();
            public abstract int get_edge();
        }



        public class Circle : Shape
        {
            private int code = 1;
            private int edge = 0;
           

            public override void display()
            {
                Console.WriteLine("Circle");
            }

            public override int get_code()
            {
                return code;
            }

            public override int get_edge()
            {
                return edge;
            }
        }

        public class Triangle : Shape
        {
            private int code = 2;
            private int edge = 3;
            

            public override void display()
            {
                Console.WriteLine("Triangle");
            }

            public override int get_code()
            {
                return code;
            }

            public override int get_edge()
            {
                return edge;
            }
        }

        public class Square : Shape
        {
            private int code = 3;
            private int edge = 4;
           

            public override void display()
            {
                Console.WriteLine("Square");
            }

            public override int get_code()
            {
                return code;
            }

            public override int get_edge()
            {
                return edge;
            }
        }
    }
}
