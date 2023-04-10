/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int Read()
{
    int N;
    System.Console.Write("Введите число N: ");
    while (!int.TryParse(System.Console.ReadLine(), out N))
    {
        System.Console.Write("Введите число N: ");
    }
    return N;
}

int N = Read();

void CubeTable()
{
    for (int i = 1; i <= N; i++)
    {
        int a = i*i*i;
        System.Console.WriteLine($"{i}*{i}*{i} = {a}");
    }
    
}
CubeTable();