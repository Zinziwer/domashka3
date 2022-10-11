//Задача 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

void Zadacha21()
{
    Console.WriteLine("enter point A coordinate x");

    int xa = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter point A coordinate y");

    int ya = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter point A coordinate z");

    int za = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter point B coordinate x");

    int xb = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter point B coordinate y");

    int yb = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter point B coordinate z");

    int zb = Convert.ToInt32(Console.ReadLine());

    double LengthAB = Math.Sqrt(Math.Pow((xa-xb), 2) + Math.Pow((ya-yb), 2) + Math.Pow((za-zb), 2));

    Console.WriteLine($"The Length AB = {Math.Round(LengthAB, 2)}" );


}
//Zadacha21();

//Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha23()
{
    Console.WriteLine("enter a number");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number>0)
    {
        for (int i=1; i<number + 1; i++)
        {
            Console.Write(Math.Pow(i, 3) +" ");    
        }
    }
    else
    {                                                       //если отрицательное N
        for (int i=1; i>number - 1; i--)
        {
            Console.Write(Math.Pow(i, 3) +" ");    
        }
    }

}
//Zadacha23();

//Задача 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
void Zadacha19()
{
    Console.WriteLine("Enter a five-digit number");            // пишу по английски не потому, что выпендриваюсь)
    int number = Convert.ToInt32(Console.ReadLine());          // у меня в консоли что-то не так с русской кодировкой
                                                               // потом все поправлю, а пока учу язык заодно)     
    
    Console.WriteLine("-------------------------");
    if (Math.Abs(number)>99999 || Math.Abs(number)<10000)
    {
        Console.WriteLine("You entered a wrong number");
    }
    else
    {
        if (number/10000%10 == number%10 && number/1000%10 == number/10%10)
        {
            Console.WriteLine($"The {number} is a palindrome");
        }
        else
        {
            Console.WriteLine($"The {number} is not a palindrome");
        }
    }
    Console.WriteLine("-------------------------");

}
Zadacha19();