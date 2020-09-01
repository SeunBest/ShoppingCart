using System;
using ShoppingCart.Helpers;

namespace ConsoleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Connection cond = new Connection();
            cond.OpenConection();
            /*            DateTime dates = DateTime.Now;
                        cond.InsertPro("Tomato", 400);
                        cond.InsertPro("NoteBook", 120);
                        cond.InsertPro("Meat", 1000);
                        cond.InsertPro("Cream", 130);
                        cond.InsertPro("Fish", 140);
                        cond.InsertPro("Ruler", 600);
                        cond.InsertPro("Sweet", 10);
                        cond.InsertPro("Phone", 7000);
                        cond.InsertPro("Table", 100);
                        cond.InsertPro("Ginger", 230);
                        cond.InsertPro("Crayon", 640);
                        cond.InsertPro("Eggs", 340);
                        cond.InsertPro("Bubble Gum", 10);
                        cond.InsertPro("Biro", 50);
                        cond.InsertPro("Chivita", 750);*/
           // cond.InsertPro("Eraser", 30);
            cond.CloseConnection();

        }
    }
}
