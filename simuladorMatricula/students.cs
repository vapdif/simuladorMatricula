using System;
using System.Collections.Generic;
using System.Text;

namespace simuladorMatricula
{
    class students
    {
        private string fName;
        private int vCred, stratrum, nCred, vTotal, vDiscount, vNet;

        public students(string fName, int vCred, int stratrum, int nCred, int vTotal, int vDiscount, int vNet)
        {
            this.fName = fName;
            this.vCred = vCred;
            this.stratrum = stratrum;
            this.nCred = nCred;
            this.vTotal = vTotal;
            this.vDiscount = vDiscount;
            this.vNet = vNet;
        }

        public string FName { get => fName; set => fName = value; }
        public int VCred { get => vCred; set => vCred = value; }
        public int Stratrum { get => stratrum; set => stratrum = value; }
        public int NCred { get => nCred; set => nCred = value; }
        public int VTotal { get => vTotal; set => vTotal = value; }
        public int VDiscount { get => vDiscount; set => vDiscount = value; }
        public int VNet { get => vNet; set => vNet = value; }
        


        //method
        public void Entry()
        {
            try
            {
                VCred = 112000;

                //Home Screem
                Console.WriteLine("______________________________________________|");
                Console.Title = "      Bienvenido a Matriculas                   |";
                Console.BackgroundColor = ConsoleColor.DarkYellow;                    // color fondo
                Console.ForegroundColor = ConsoleColor.DarkBlue;                   // color fuente
                Console.Clear();                                                // limpia consola y permite que todo quede azul
                Console.WriteLine("         Matriculas online                    |");
                Console.WriteLine("               UNAD                           |");
                Console.WriteLine("______________________________________________|");

                Console.WriteLine("\n Ingrese su nombre completo: ");
                Console.Write("\t ");
                FName = (Console.ReadLine());

                Console.Write(" \n Ingrese estrato a que pertenece: ");
                Stratrum = int.Parse(Console.ReadLine());

                Console.Write("\n Ingrese número de créditos a matricular: ");
                NCred = int.Parse(Console.ReadLine());

                if (Stratrum==1)
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
                Console.Write("\n El valor a pagar es: " + VNet);
                Console.WriteLine("\n_____________________________________________");
                Console.WriteLine("\n muchas gracias por su matricula");
                Console.WriteLine("______________________________________________|");
            }
            catch(Exception)
            {
                Console.WriteLine("__________________________________________________________|");
                Console.WriteLine("Error, por favor verifique los datos ingresados. ");
                Console.WriteLine("__________________________________________________________|");
            }
        }

    }
}
