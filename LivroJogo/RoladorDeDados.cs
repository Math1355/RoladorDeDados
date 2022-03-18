using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroJogo
{
    class RoladorDeDados
    {
        //Codigo para rolar 1d6
        public Random rnd = new Random();
        public int TipoDeDado { get; private set; }
        public int Modificador { get; private set; }
        public int SomaDados { get; private set; }
        public int QuantidadeDados { get; private set; }

        public bool RolarDados(int tipoDedado, int quantidade, int modificador)
        {
            this.TipoDeDado = tipoDedado;
            this.Modificador = modificador;
            this.QuantidadeDados = quantidade;

            if (quantidade > 0)
            {
                for (int i = 1; i <= quantidade; i++)
                {
                    int dado = rnd.Next(1, this.TipoDeDado + 1);
                    this.SomaDados += dado + modificador;
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
