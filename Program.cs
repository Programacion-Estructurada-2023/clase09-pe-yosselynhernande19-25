using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //PROGRAMA PARA INGRESAR NOTAS
            Console.WriteLine("\n----PROGRAMA QUE DETERMINE CALIFICACION------\n");
            Console.WriteLine("\nIngresa una nota: ");
            double nota=Convert.ToDouble(Console.ReadLine());

            if(nota >=9.5)
            {
                Console.WriteLine("La calificacion obtenida es: "+nota+" Excelente");
            }
            else if (nota >=8.5)
            {
                Console.WriteLine("La calificacion obtenida es: "+nota+" es muy buena");
            }
            else if(nota >=7.0)
            {
                Console.WriteLine("La calificacion obtenida es: "+nota+" es buena");
            }
            else
            {
                Console.WriteLine("La calificacion obtenida es Deficiente");
            }
          
            Console.ReadKey(); 

           }
        }
    }
          

