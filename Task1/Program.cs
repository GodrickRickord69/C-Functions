/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число A: ");
int Basis = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int Power = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {Basis} возведённое в натуральную степень {GetSt(Basis, Power)}");


int GetSt(int A, int B)
        {
            int st = 1;
            for(int i = 1; i<=B; i++){
                st = st * A;
            }
            return st;
        }
