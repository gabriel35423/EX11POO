using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex11
{
    internal class Triangulos
    {
        private double x; //lado 1
        private double y; //lado 2 
        private double z; //base
        public Triangulos()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }


        public void setx(double a)
        {
            x = a;
        }

        public void sety(double a)
        {
            y = a;
        }
        public void setz(double a)
        {
            z = a;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public double getZ()
        {
            return z;
        }
        public void calcular()

        {
            //Verificando triangulo 
            if ((x < y + z) && (y < x + z) && (z < x + y))
            {
                
                Console.Write("Formam triângulo :");

                if ((x == y) && (y == z))
                {
                    
                    Console.Write("Equilátero");

                }
                else if ((x == y) || (y == z) || (x == z))
                {
                   
                    Console.Write("Isósceles");
                }
                else
                {
                   
                    Console.Write("Escaleno");
                }

            }
            else
            {
                Console.WriteLine(" ");
                Console.Write("Os valores não formam um triângulo!");
            }
            System.Console.ReadKey();
        }

        
    }
}

