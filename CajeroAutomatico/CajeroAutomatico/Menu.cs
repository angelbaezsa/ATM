using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class MenuPrincipal
    {

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opcion: \n 1- Retiro\n 2- Modo de retiro\n 3- Salir");


            try
            {
                
                int opcion = Convert.ToInt32(Console.ReadLine());
                

                switch (opcion)
                {
                    case (int) opcionMenu.RETIRO:
                        Retiro menu = new Retiro();
                        menu.RetirarRapido();
                        break;
                    case (int)opcionMenu.MODORETIRO:
                        Modo_Retiro menuModoRetiro = new Modo_Retiro();
                        menuModoRetiro.MenuModoRetiros();
                        break;
                    case (int)opcionMenu.SALIR:
                        Console.WriteLine("Gracias por usar nuestros servicios");
                        Console.ReadKey();
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion validad");
                        Console.ReadKey();
                        MainMenu();
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Selecciona una opcion valida");
                Console.ReadKey();
                MainMenu();
                throw;
            }
        }

        enum opcionMenu
        {
            RETIRO = 1, MODORETIRO, SALIR
        }
            
     
    }


}



    


