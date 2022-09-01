using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Funcao
    {
        public int DadoD2()
        {
            Random num = new Random();
            int resultd2 = num.Next(1, 3);

            return resultd2;
        }

        public int DadoD5()
        {
            Random num = new Random();
            int resultd5 = num.Next(1, 6);

            return resultd5;
        }

        public int DadoD12()
        {
            Random num = new Random();
            int resultd12 = num.Next(1, 13);

            return resultd12;
        }

        public int DadoD4()
        {
            Random num = new Random();
            int resultd4 = num.Next(1, 5);

            return resultd4;
            return 0;
        }

        public int DadoD8()
        {
            Random num = new Random();
            int resultd8 = num.Next(1, 9);

            return resultd8;
        }

        public int DadoD20()
        {
            Random num = new Random();
            int resultd20 = num.Next(1, 21);

            return resultd20;
        }

        public int DadoD10()
        {
            Random num = new Random();
            int resultd10 = num.Next(1, 11);

            return resultd10;
        }

        public int DadoD100()
        {
            Random num = new Random();
            int resultd100 = num.Next(1, 11);
            resultd100 = resultd100 * 10;

            return resultd100;
        }

        public Status DadoDefinicaoDeStts()
        {
            Status status = new Status ();
            Random num = new Random();
            status.forca = num.Next(10 , 16);
            status.destreza = num.Next(10, 16);
            status.constituicao = num.Next(10, 16);
            status.inteligencia = num.Next(10, 16);
            status.sabedoria = num.Next(10, 16);
            status.carisma = num.Next(10, 16);


            
            return status;
        }
    }
}
