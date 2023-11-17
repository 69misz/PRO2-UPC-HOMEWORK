using System;

class Program
{
    public static void MostrarMaxMinArrayEnteros(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("El array está vacío o es nulo");
            return;
        }

        int max = array[0];
        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }

        Console.WriteLine("El valor máximo del array es: " + max);
        Console.WriteLine("El valor mínimo del array es: " + min);
    }

    static void Main(string[] args)
    {
        int[] array = { 5, 3, 9, -2, 10, 7 };
        MostrarMaxMinArrayEnteros(array);
    }
}
