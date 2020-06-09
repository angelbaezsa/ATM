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


            try
                {

                    

                    switch (opcionMenuRetiro)
                    {
                        case (int)opcionesMenuRetiro.OPCION1:
                        Retiro retirar1 = new Retiro();
                        retirar1.RetirarModo1();

                        break;
                        case (int)opcionesMenuRetiro.OPCION2:
                        Retiro retirar2 = new Retiro();
                        retirar2.RetirarModo2();

                        break;
                        case (int)opcionesMenuRetiro.OPCION3:
                        Retiro retirar = new Retiro();
                        retirar.RetirarRapido();
                        
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
