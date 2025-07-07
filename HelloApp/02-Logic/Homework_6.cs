partial class Program
{
    // 🏆 Ejercicio:
    // Implementar un programa que recorra los números del 1 al 100.
    // Consideraciones:
    // Aplicar la lógica de FizzBuzz:
    // - Si un número es divisible por 3, imprimir "Fizz".
    // - Si un número es divisible por 5, imprimir "Buzz".
    // - Si un número es divisible por 3 y 5, imprimir "FizzBuzz".
    // - En cualquier otro caso, imprimir el número.
    // 💡 Pista:
    // - El orden de las condiciones es clave.
    // Piensa en cómo asegurarte de que "FizzBuzz" se imprima antes que "Fizz" o "Buzz".

    public static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0) WriteLine("FizzBuzz");
            else if (i % 3 == 0) WriteLine("Fizz");
            else if (i % 5 == 0) WriteLine("Buzz");
            else WriteLine(i);
        }
    }
}