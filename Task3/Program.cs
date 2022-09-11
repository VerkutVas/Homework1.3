// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int n = Prompt("Введите число");
for (int count = 1; count <=n; count++)
{
    int result = count*count*count;
    System.Console.WriteLine(result);  
}
