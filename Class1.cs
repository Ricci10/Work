using System;


namespace Library
{
    public class Class1
    {

        // main метод
        public static void Main_1()
        {
            while (true)
            {
                Console.WriteLine("Площадь какой фигуры Вы хотите вычислить?(с - круг, t - треугольник,q - произвольный четырехугольник)");
                string figure = Console.ReadLine();
                if (figure == "c")
                    CercArea();
                else if (figure == "t")
                    TArea();
                else if (figure == "q")
                    Quadrangle();
                
            }
        }

        //Площадь круга
        static void CercArea()
        {
            const double Pi = 3.1415;     
           
            try
            {
                Console.WriteLine("Введите радиус круга:");
                double r = Convert.ToDouble((Console.ReadLine()));
                if (r<=0)
                {
                    Console.WriteLine("Введите корректное значение радиуса");
                    return;
                }
                double s = Pi * Math.Pow(r, 2);
                Console.WriteLine($"Площадь круга: {s}");
            }
            catch 
            {
                Console.WriteLine("Введите корректное значение радиуса. Вещественное число стоит разделять точкой.");
            }
            
                        
            
        }
        

        //Площадь треугольника
        static void TArea()
        {
            double a, b, c,s,p;

            try
            {
                Console.Write("a(катет)=");
                a=Convert.ToDouble( Console.ReadLine());
                Console.Write("b(катет)=");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c(гипотенуза)=");
                c = Convert.ToDouble(Console.ReadLine());
                if (a >= b + c || b >= a + c || c >= a + b)
                {
                    Console.WriteLine("Такого треугольника не существует");
                    return;
                }
                else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                {

                    s = a * b / 2;
                    Console.WriteLine($"Треугольник прямоугольный. Площадь: {s}");
                }
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > b * b + a * a)
                {
                    p = (a + b + c) / 2;
                    s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"Треугольник тупоугольный. Площадь: {s}");
                }
                else
                {
                    p = (a + b + c) / 2;
                    s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"Треугольник остроугольный. Площадь: {s}");
                }
            }
            catch 
            {
                Console.WriteLine("Введите корректное значение");
            }
        }

        //Площадь произвольного четырехугольника
        static void Quadrangle()
        {
            double d1, d2, alfa,s;
            try
            {
                Console.WriteLine("Первая диагональ:");
                d1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Вторая диагональ:");
                d2 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Угол между ними:");
                alfa = Convert.ToDouble((Console.ReadLine()))* 0.0174533;
                if (d1 <= 0.0||d2<=0.0||alfa<=0.0||alfa>=180.0)
                {
                    Console.WriteLine("Введите корректные значения");
                    return;
                }
                s = 0.5 * d1 * d2 * Math.Sin(alfa);
                Console.WriteLine($"Площадь четырехугольника:{s}");
            }
            catch
            {
                Console.WriteLine("Введите корректное значение радиуса. Вещественное число стоит разделять точкой.");
            }
        }
    }
}
