{
    {
        int cantidad, posicion;

        Console.WriteLine("INGRESE LA CANTIDAD DE ELEMENTOS DE UN ARREGLO:");
        cantidad = int.Parse(Console.ReadLine());
        int[] numeros = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"INGRESE EL VALOR DE LA POSICIÓN {i}:");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nARREGLO ORIGINAL:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
        Console.WriteLine("\nINGRESE LA POSICION QUE DESEA ELIMINAR");
        posicion = int.Parse(Console.ReadLine());
        if (posicion >= 0 && posicion < numeros.Length)
        {
            for (int i = posicion; i < numeros.Length - 1; i++)
            {
                numeros[i] = numeros[i + 1];
            }
            Array.Resize(ref numeros, numeros.Length - 1);

            Console.WriteLine("\nARREGLO DESPUES DE LA ELIMINACIÓN");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        else
        {
            Console.WriteLine($"\nLA POSICIÓN {posicion} NO ES VALIDA EN EL ARREGLO");
        }
        Console.ReadKey();
    }
}
