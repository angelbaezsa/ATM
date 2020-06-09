using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CajeroAutomatico
{
    public class Retiro
    {
        public static List<int> Billetes = new List<int>();
        MenuPrincipal MainMenu = new MenuPrincipal();


        public void RetirarRapido()
        {
            Billetes.Add(1000);
            Billetes.Add(500);
            Billetes.Add(200);
            Billetes.Add(100);


            Console.WriteLine("Ingrese el Monto a retirar");
            int cantidad = Convert.ToInt32(Console.ReadLine());




            if (cantidad % 100 == 0)
            {

                int mil = cantidad / Billetes[0];
                cantidad %= 1000;
                int quinientos = cantidad / Billetes[1];
                cantidad %= 500;
                int doscientos = cantidad / Billetes[2];
                cantidad %= 200;
                int cien = cantidad / Billetes[3];
                cantidad %= 100;
                Console.WriteLine($"Billetes de 1000  {mil}\nBilletes de 500  {quinientos}\nBilletes de 200  {doscientos}\nBilletes de 100  {cien}");
                Console.ReadKey();
                MainMenu.MainMenu();
            }
            else if (cantidad % 100 > 0)
            {
                Console.WriteLine("Solo billetes con las siguientes Denominaciones 1000, 500, 200 y 100");
                Console.ReadKey();
                MainMenu.MainMenu();


            }



        }

        public void RetirarModo1()
        {
            Billetes.Add(1000);
            Billetes.Add(500);
            Billetes.Add(200);
            Billetes.Add(100);
            Console.WriteLine("Ingrese el Monto a retirar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad % 100 == 0)
            {

                int quinientos = cantidad / Billetes[1];
                cantidad %= 500;

                int cien = cantidad / Billetes[3];
                cantidad %= 100;
                Console.WriteLine($"Billetes de 500  {quinientos}\nBilletes de 100  {cien}");
                Console.ReadKey();
                MainMenu.MainMenu();
            }
            else if (cantidad % 100 > 0)
            {
                Console.WriteLine("Solo billetes con las siguientes Denominaciones 500 y 100");
                Console.ReadKey();
                MainMenu.MainMenu();


            }

        }

        public void RetirarModo2()
        {
            Billetes.Add(1000);
            Billetes.Add(500);
            Billetes.Add(200);
            Billetes.Add(100);

            Console.WriteLine("Ingrese el Monto a retirar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad % 200 == 0)
            {



                int mil = cantidad / Billetes[0];
                cantidad %= 1000;

                int doscientos = cantidad / Billetes[2];
                cantidad %= 200;

                Console.WriteLine($"Billetes de 1000  {mil}\nBilletes de 200  {doscientos}");
                Console.ReadKey();
                MainMenu.MainMenu();
            }
            else if (cantidad % 200 > 0)
            {
                Console.WriteLine("Solo billetes con las siguientes Denominaciones 1000 y 200");
                Console.ReadKey();
                MainMenu.MainMenu();

            }

        }
    }
}