using System;

namespace simuladorMatricula
{
    class Program
    {
        static void Main(string[] args)
        {
            students newStudent = new students("", 0, 0, 0, 0, 0, 0, 0, 0);

            newStudent.HomeScreem();
            newStudent.Initial();            
            newStudent.EnterPass();
            Console.ReadKey();
        }
    }
}
