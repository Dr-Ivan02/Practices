// Práctica para aprender a usar y crear funciones propias. Estas prácticas y enseñanzas han sido realizadas utilizando a la IA como instructor de programación.

// Función tipo estática que recibe dos parámetros enteros y retorna su suma.
static int Summation(int a, int b) // El static me indica que la función pertenece a la clase y no a una instancia de la clase (es estática), y que va a trabajar con 2 parámetros enteros.
{
    return a + b; // La función retorna la suma de los dos parámetros.
}

int result = Summation(5, 10); // Llamada a la función con los valores 5 y 10.
Console.WriteLine(result);

// Funciones que NO devuelven nada: void
static void MostrarMensaje(string texto) // La función recibe un parámetro de tipo string y no devuelve nada (void), solo muestra un mensaje como le es indicado.
{
    Console.WriteLine(texto);
}

MostrarMensaje("Hola, este es un mensaje desde una función void."); // Llamada a la función con un mensaje. Hace exactamente lo indicado, el Console.WriteLine.

//Ejercicios guiados por la IA para practicar la creación y uso de funciones propias.
Console.WriteLine("Probando funciones\n");

static double AverageCalculation(double n1, double n2, double n3) // Función que calcula el promedio de tres números.
{
    double average = (n1 + n2 + n3) / 3;
    return average;
}

double avgResult = AverageCalculation(7.5, 8.0, 9.0); // Llamada a la función con tres números.
Console.WriteLine($"El promedio es: {avgResult}");

// Función para pedir datos
static int ReadIntBetween(string message, int min, int max) // Función que lee un entero entre un rango específico.
{
    int value;
    bool ok;

    do
    {
        Console.Write(message);
        ok = int.TryParse(Console.ReadLine(), out value);

        if (!ok || value < min || value > max)
        {
            Console.WriteLine($"Error: Por favor ingrese un número entero entre {min} y {max}.");
            ok = false;
        }
        while (!ok || value < min || value > max);
    }
}