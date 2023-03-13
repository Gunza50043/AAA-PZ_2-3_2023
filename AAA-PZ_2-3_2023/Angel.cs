using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_PZ_2_3_2023
{
    
        internal class Angel
        {
            private int gradus = 365;
            private int minut = 90;

            //перевод из градусов в радианы
            public void Perevod()
            {
                Console.WriteLine("Из градусов в радианы = " + Math.Round(((3.14 * gradus) / 180) + (minut / 3437.75)), 3);

            }
            //Приведение к 0-360
            public void Prividenie()
            {

                double gradus2 = gradus + (minut / 60);
                gradus2 = Math.Round(gradus2, 0);
                gradus2 = gradus2 % 360;
                if (gradus2 < 0)
                {
                    gradus2 = gradus2 + 360;
                }
                Console.WriteLine("Градусы 0-360 = " + gradus2);
            }
            //увеличение угла
            public void yvel()
            {
                Console.WriteLine("Увеличение(1)\nУменьшение(2)");
                int i = Convert.ToInt32(Console.ReadLine());
                int yvelich;
                int ymensh;
                if (i == 1)
                {
                    Console.WriteLine("Увеличение на ");
                    yvelich = Convert.ToInt32(Console.ReadLine());
                    gradus = gradus + yvelich;
                    Console.WriteLine("=" + gradus);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Уменьшение на ");
                    ymensh = Convert.ToInt32(Console.ReadLine());
                    gradus = gradus - ymensh;
                    Console.WriteLine("=" + gradus);
                }

            }
            //Получение синуса
            public void sinys()
            {
                Console.WriteLine("Синус= " + Math.Sin(gradus));
            }
            //Сравнение
            public void sravnen()
            {

            }

            //ввод данных 
            public void Read()
            {
                Console.WriteLine("Введите градусы= ");
                gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты= ");
                minut = Convert.ToInt32(Console.ReadLine());

            }
            //ввывод
            public void Display()
            {
                Perevod();
                Prividenie();
                yvel();
                sinys();


            }
        }
    
}
