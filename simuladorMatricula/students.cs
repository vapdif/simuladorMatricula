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

        public int VCred { get => vCred; set => vCred = value; }
        public int Stratrum { get => stratrum; set => stratrum = value; }
        public int NCred { get => nCred; set => nCred = value; }
        public int VTotal { get => vTotal; set => vTotal = value; }
        public int VDiscount { get => vDiscount; set => vDiscount = value; }
        public int VNet { get => vNet; set => vNet = value; }
        public string FName { get => fName; set => fName = value; }


        //method
        public void Entry()
        {
            try
            {
                vCred = 112000;

                //Home Screem
                Console.WriteLine("____________________________________|");
                Console.Title = "      Bienvenido a Matriculas          |";
                Console.BackgroundColor = ConsoleColor.Yellow;                    // color fondo
                Console.ForegroundColor = ConsoleColor.Blue;                   // color fuente
                Console.Clear();                                                // limpia consola y permite que todo quede azul
                Console.WriteLine("         Matriculas online          |");
                Console.WriteLine("               UNAD                 |");
                Console.WriteLine("____________________________________|");

                Console.Write("Ingrese su nombre completo: ");
                FName = (Console.ReadLine());
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
