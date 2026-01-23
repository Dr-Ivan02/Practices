//Programa que evalúe la condición del estudiante según su promedio, pero que también verifique los datos ingresados.

int average = 0;
bool averageVerification;
do
{
    // Solicitud de promedio
    Console.Write("Ingresar promedio (solo acepta números de 0 a 100): ");

    //Verificación del dato ingresado, una vez validado, se guarda en average.
    averageVerification = int.TryParse(Console.ReadLine(), out average);

    //Dato ingresado incorrecto: Limpiar pantalla.
    if (averageVerification == false || average > 100 || average < 0)
    {
        Console.Clear();
    }

} while (averageVerification == false || average > 100 || average < 0);

//Condición del estudiante según el promedio.
if (average > 90 && average < 101)
{
    Console.WriteLine("Excelente");
}
else if (average >= 70 && average < 90)
{
Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Reprobado");
}
