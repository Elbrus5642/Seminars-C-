/* Задача 24: Напишите программу,
 которая принимает на вход число (А)
  и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 
*/

// Метод, который паодлучает число с консоли
int GetNumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

                if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число");
        }
    }

    return result;

}

int number = GetNumber("Введите число N:"); 
// Метод, который считает сумму от 1 до числа N

 int GetSum(int num)
{
    int sum = 0; 
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
  
}
int sumNumber = GetSum(number);
Console.WriteLine($"{sumNumber}");