using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe2
{
    class Tempo
    {

        private int hora, minuto, segundo;

        public Tempo()
        {
             hora = 0;
             minuto = 0;
             segundo = 0;
        }

        public Tempo(int xhora, int xminuto, int xsegundo)
        {
            hora = xhora;
            minuto = ValidaMinuto(xminuto);
            segundo = ValidaSegundo(xsegundo);
        }

        public Tempo(int xhora)
        {
            hora = xhora;
            minuto = 0;
            segundo = 0;
        }

        public string ImprimirTempo()
        {
            return hora + ":" + minuto + ":" + segundo;
        }

        private int ValidaMinuto(int zminuto)
        {
            int resto = 0;
            int resul = 0;

            resul = zminuto / 60;
            resto = zminuto % 60;

           hora = hora + resul; 

            return resto;
        }
        

        private int  ValidaSegundo(int xsegundo)
        {
            int resto = 0, resul = 0;

            resul = xsegundo / 60;
            resto = xsegundo % 60;

            minuto = ValidaMinuto(minuto + resul); 

            return resto;
        }

        public int Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }
    }
}
