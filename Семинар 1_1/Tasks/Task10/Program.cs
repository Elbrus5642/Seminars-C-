/* Задача 30: Напишите программу, 
которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int[] GetMassiv ()
{
    int[] massiv = new int[8];
    Random rnd = new Random(); 
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(0,2);

    }

    return massiv;
}
int[] array = GetMassiv();

for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write($"{array[i]} ");
    }
