using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    class Matematica
    {

        public double AQuad(double lado) {

            double area = lado*lado;
            return area;

            // return lado*lado
        }

        public double ARet(double bas, double alt) {

            double area = bas * alt;
            return area;

        }

        public double ATriangulo(double bas, double alt)
        {
            double area = (bas * alt)/2;
            return area;
        }

        public double VCilindro (double raio, double alt) {

            return Math.PI * Math.Pow(raio, 2) * alt;

        }

        public double ACasa(double br, double ar, double bt, double at)
        {
            //return br * ar + bt * at / 2;
            return ARet(br, ar) + ATriangulo(bt, at);
        }

        public int Fatorial(int num)
        {

            int fat = 1;

            for (int i = 1; i <= num; i++)
            {

                fat = fat * i;

            }
            return fat;
        }

    }
}
