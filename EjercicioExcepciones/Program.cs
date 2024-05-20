using EjercicioExcepciones;


try
{
    //Creando objeto
    Operacion operaciones = new Operacion();
    bool continuar = true;

    //Obteniendo opción del menú
    while (continuar)
    {
        MostrarMenu();
        int opcion = ObtenerOpcion();

        if (opcion == 5)
        {
            continuar = false;
            Console.WriteLine("Ha salido exitosamente...");
            continue;
        }

        double n1 = ObtenerNumero("Ingrese el primer número: ");
        double n2 = ObtenerNumero("Ingrese el segundo número: ");

        try
        {
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = operaciones.Suma(n1, n2);
                    Console.WriteLine($"Resultado: {n1} + {n2} = {resultado}");
                    break;
                case 2:
                    resultado = operaciones.Resta(n1, n2);
                    Console.WriteLine($"Resultado: {n1} - {n2} = {resultado}");
                    break;
                case 3:
                    resultado = operaciones.Multiplica(n1, n2);
                    Console.WriteLine($"Resultado: {n1} * {n2} = {resultado}");
                    break;
                case 4:
                    resultado = operaciones.Divide(n1, n2);
                    Console.WriteLine($"Resultado: {n1} / {n2} = {resultado}");
                    break;
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }


    //Mostrando las opciones del Menú
    static void MostrarMenu()
    {
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    }

    // Solicitando Opcion 
    static int ObtenerOpcion()
    {
        while (true)
        {
            Console.WriteLine("Ingrese el número de la opción deseada: ");
            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 1 && opcion <= 5)
            {
                return opcion;
            }
            Console.WriteLine("Opción no válida, por favor intente de nuevo.");
        }
    }

    static double ObtenerNumero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                return numero;
            }
            Console.WriteLine("Entrada no válida, por favor ingrese un número.");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}



