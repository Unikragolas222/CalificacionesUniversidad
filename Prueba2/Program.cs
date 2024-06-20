//Crear lista Nombres

using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> listNames = new List<string>{
"Luis",
"Ana",
"Pedro",
"Julia",
"Maite",
"Jorge",
};
// Crear listas para asignaturas

List<int> NotasMate = new List<int>();
List<int> NotasPorg = new List<int>();
List<int> NotasDiseñoUI = new List<int>();
while 
    // Pedir al usuario escribir las notas de cada asignatura
    Console.WriteLine("Introduzca la nota de Matematicas:");
    int NotaMate = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca la nota de programacion:");
    int NotaProg = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca la nota de Diseño UI:");
    int NotaDiseñoUI = int.Parse(Console.ReadLine());



//Dar opciones para ordenar las listas
//Mostrar por consola la lista ordenadna de alumnos
//Nombre y nota