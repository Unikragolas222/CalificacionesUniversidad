using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

{
    static void Main()
    {
        // Define las rutas de los archivos
        string inputFilePath = "Notas.csv";
        string outputFilePath = "suma_notas.csv";

        // Listas para almacenar las notas
        List<int> NotasMate = new List<int>();
        List<int> NotasProg = new List<int>();
        List<int> NotasDiseñoUI = new List<int>();

        // Leer el archivo CSV
        using (var reader = new StreamReader(inputFilePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                // Añadir las notas a las listas
                NotasMate.Add(int.Parse(values[0]));
                NotasProg.Add(int.Parse(values[1]));
                NotasDiseñoUI.Add(int.Parse(values[2]));
            }
        }

        // Lista para almacenar las sumas
        List<int> sumaNotas = new List<int>();

        // Sumar las notas correspondientes
        for (int i = 0; i < NotasMate.Count; i++)
        {
            int suma = NotasMate[i] + NotasProg[i] + NotasDiseñoUI[i];
            sumaNotas.Add(suma);
        }

        // Mostrar suma por pantalla
        {
            foreach (var suma in sumaNotas)
            {
                Console.WriteLine(suma);
            }
        }

        Console.WriteLine("Las notas han sido sumadas y el resultado se ha guardado en 'suma_notas.csv'.");
    }
}