using System;
using System.IO;

namespace Votacion
{
    class MaquinaDeVotos
    {
        static void Main(string[] args)
        {
            Votante votante = new Votante(2123123, new char[] { 'a', 'b' }, "apellido");

            string sMenu = "Bienvenido al sistema de encuestas 1.0\n" +
                            "Opciones:\n" +
                            "1.Crear encuesta.\n" + 
                            "2. Responer encuesta\n" + 
                            "3. Salir\n" ;

            TextReader textReader = Console.In;
            try
            {
                
                Console.WriteLine(sMenu);
                string input = textReader.ReadLine();
                Console.WriteLine(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            



        }
    }
}
