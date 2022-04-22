using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marker
{
    internal class Print
    {
        private double fill = 0;
        public double Fill
        {
            get { return fill; }
            set
            {
                if (value > 0 && value <= 100)
                    fill = value;
                else
                    Console.WriteLine("Маркер переполнен - утечка краски!");
            }
        }
        public string text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.  Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.";
        private int color = 0;
        public int Color
        {
            get { return color; }
            set
            {
                if (value > 0 && value <= 3)
                    color = value;
                else
                    Console.WriteLine("Неизвестный цвет");
            }
        }
        public void SetColor(int n)
        {
            if (n == 1)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (n == 2)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (n == 3)
                Console.ForegroundColor = ConsoleColor.Blue;
        }
        public void Write()
        {
            if (fill != 0 && color != 0)
            {
                SetColor(color);
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    if (text[i] != ' ')
                        fill = fill - 0.5;
                    if (fill <= 0)
                        break;

                }
                Console.ResetColor();
                Console.WriteLine("\nВ маркере закончилась краска\n");
            }
        }
    }
}
