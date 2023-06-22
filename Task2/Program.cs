/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {limit} равна {GetSumNumb(limit)}");

int GetSumNumb(int A){

    int sn = 0;
    while(A != 0){
            sn += A % 10;
            A /= 10;
    }
    return sn;
};

