using System;

namespace simuladorMatricula
{
    class Program
    {
        static void Main(string[] args)
        {
            students newStudent = new students("", 0, 0, 0, 0, 0, 0, 0);
         
            //Home Screem
            Console.WriteLine("______________________________________________|");
            Console.Title = "      Bienvenido a Matriculas                   |";
            Console.BackgroundColor = ConsoleColor.DarkYellow;                    // color fondo
            Console.ForegroundColor = ConsoleColor.DarkBlue;                   // color fuente
            Console.Clear();                                                // limpia consola y permite que todo quede azul
            Console.WriteLine("         Matriculas online                    |");
            Console.WriteLine("              vapdif                          |");
            Console.WriteLine("______________________________________________|");
          
            
            newStudent.Initial();
            
            newStudent.EnterPass();
            Console.ReadKey();
        }
    }
}
