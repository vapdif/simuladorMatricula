using System;
using System.Collections.Generic;
using System.Text;

namespace simuladorMatricula
{
    class students
    {
        private string fName;
        private int pass, inpass, vCred, stratrum, nCred, vTotal, vDiscount, vNet;

        //constructor
        public students(string fName, int pass, int inpass, int vCred, int stratrum, int nCred, int vTotal, int vDiscount, int vNet)
        {
            
            this.fName = fName;
            this.pass = pass;
            this.inpass = inpass;
            this.vCred = vCred;
            this.stratrum = stratrum;
            this.nCred = nCred;
            this.vTotal = vTotal;
            this.vDiscount = vDiscount;
            this.vNet = vNet;
        }
        
        //encapsulamos 
        public string FName { get => fName; set => fName = value; }
        public int Pass { get => pass; set => pass = value; }
        public int Inpass { get => inpass; set => inpass = value; }
        public int VCred { get => vCred; set => vCred = value; }
        public int Stratrum { get => stratrum; set => stratrum = value; }
        public int NCred { get => nCred; set => nCred = value; }
        public int VTotal { get => vTotal; set => vTotal = value; }
        public int VDiscount { get => vDiscount; set => vDiscount = value; }
        public int VNet { get => vNet; set => vNet = value; }



        //method

        public void HomeScreem()
        {
            //Home Screem
            Console.WriteLine("______________________________________________|");
            Console.Title = "      Bienvenido a Matriculas                   |";
            Console.BackgroundColor = ConsoleColor.DarkYellow;                    // color fondo
            Console.ForegroundColor = ConsoleColor.DarkBlue;                   // color fuente
            Console.Clear();                                                // limpia consola y permite que todo quede azul
            Console.WriteLine("               Matriculas online              |");
            Console.WriteLine("                  dfvasquezp                  |");
            Console.WriteLine("______________________________________________|");
        }

        public void Initial()
        {
            try
            {
                Console.WriteLine(" Estudiante: ");
                Console.WriteLine("\t Diego Fernando Vasquez Plaza \n");
                Console.WriteLine(" Nombre Aplicación: ");
                Console.WriteLine("\t Matricula Estudiantil \n");
                Console.WriteLine(" Curso:");
                Console.WriteLine("\t Estructuras de Datos \n");
                Console.WriteLine("______________________________________________|");
                Console.WriteLine(" Presione Enter para continuar \n");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("__________________________________________________________|");
                Console.WriteLine("Error, por favor verifique los datos ingresados. ");
                Console.WriteLine("__________________________________________________________|");
                throw;
            }
        
            
            
        }

        public void EnterPass()
        {
            try
            {
                Pass = 123;
                Console.WriteLine("    Ingrese la contraseña:          |");
                Console.Write("    Recuerde que son 3 numeros.     |");
                Inpass = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("__________________________________________________________|");
                Console.WriteLine("Error, por favor verifique los datos ingresados. ");
                Console.WriteLine("__________________________________________________________|");
                //throw;
            }         
            
            

            if (Pass == Inpass)
            {
                try
                {
                    Console.Clear();
                    VCred = 112000;


                    Console.WriteLine("               Matriculas online              |");
                    Console.WriteLine("                  dfvasquezp                  |");
                    Console.WriteLine("______________________________________________|");
                    Console.WriteLine("\n Ingrese su nombre completo: ");
                    Console.Write("\t ");
                    FName = (Console.ReadLine());

                    Console.Write(" \n Ingrese estrato a que pertenece: ");
                    Stratrum = int.Parse(Console.ReadLine());

                    Console.Write("\n Ingrese número de créditos a matricular: ");
                    NCred = int.Parse(Console.ReadLine());

                    if (Stratrum == 1)
                    {
                        VTotal = VCred * NCred;
                        VNet = VTotal * 50 / 100;
                        VDiscount = VTotal - VNet;
                    }
                    else
                    {
                        VTotal = VCred * NCred;
                        VNet = VTotal;
                    }

                    Console.WriteLine("\n Bienvenida, Bienvenido \n \t" + FName);
                    Console.WriteLine("\n Se ha matriculado con éxito");
                    Console.WriteLine("______________________________________________|");
                    Console.WriteLine("\n El número de créditos matriculados son: " + NCred);
                    Console.Write("\n Estrato registrado es: " + Stratrum);
                    Console.Write("\n El valor del descuento: " + VDiscount);
                    Console.ForegroundColor = ConsoleColor.DarkRed;                   // color fuente valor a pagar
                    Console.WriteLine("\n_____________________________________________");                    
                    Console.Write("\n El valor a pagar es: " + VNet);
                    Console.WriteLine("\n_____________________________________________");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;                   // color fuente
                    Console.WriteLine("\n_____________________________________________");                    
                    Console.WriteLine("\n muchas gracias por su matricula");
                    Console.WriteLine("______________________________________________|");
                }
                catch (Exception)
                {
                    Console.WriteLine("__________________________________________________________|");
                    Console.WriteLine("Error, por favor verifique los datos ingresados. ");
                    Console.WriteLine("__________________________________________________________|");
                    //throw;
                }
            }
            else { Console.WriteLine("Error, por favor verifique los datos ingresados. "); }
        }
    }
}
