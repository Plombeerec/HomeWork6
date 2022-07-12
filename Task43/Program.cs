// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double y = 0;
double x = 0;

void FindDot(double b1, double b2, double k1, double k2)
{
    x= (b2-b1)/(k1-k2);
    y = k1 * x + b1;
    
    return;
}
Console.WriteLine("Укажите знаечение параметра b1");
int pb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите знаечение параметра k1");
int pk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите знаечение параметра b2");
int pb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите знаечение параметра k2");
int pk2 = Convert.ToInt32(Console.ReadLine());

FindDot(pb1, pb2, pk1, pk2);
Console.WriteLine($"Пересечение прямых произойдет в точке : x = {x}, y = {y}");