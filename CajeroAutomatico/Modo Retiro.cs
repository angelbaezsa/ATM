using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CajeroAutomatico
{
    public class Modo_Retiro
    {


        enum opcionesMenuRetiro { OPCION1 = 1, OPCION2, OPCION3 }




        public void MenuModoRetiros()
          {

                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("Modo de cambio: ");
                Console.WriteLine("1- 100-500\n2- 200-1000\n3- Retirar");
                int opcionMenuRetiro = Convert.ToInt32(Console.ReadLine());
                VariableRetiro.MetodoRetiro.OpcionRetiro = opcionMenuRetiro;


            try
                {

                    

                    switch (opcionMenuRetiro)
                    {
                        case (int)opcionesMenuRetiro.OPCION1:
                        MenuPrincipal retirar1 = new MenuPrincipal();
                        retirar1.MainMenu();
                        VariableRetiro.MetodoRetiro.OpcionRetiro = 1;
                        

                        break;
                        case (int)opcionesMenuRetiro.OPCION2:
                        MenuPrincipal retirar2 = new MenuPrincipal();
                        retirar2.MainMenu();
                        VariableRetiro.MetodoRetiro.OpcionRetiro = 2;

                        break;
                        case (int)opcionesMenuRetiro.OPCION3:
                        MenuPrincipal retirar3 = new MenuPrincipal();
                        retirar3.MainMenu();
                        VariableRetiro.MetodoRetiro.OpcionRetiro = 3;

                        break;
                        default:
                            Console.WriteLine("seleccione una opcion correcta");
                            Console.ReadKey();
                            MenuModoRetiros();
                            break;

                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine("Seleccione una opcion valida");
                    Console.ReadKey();
                    MenuModoRetiros();
                }


                
            


          }
       


    }
}
