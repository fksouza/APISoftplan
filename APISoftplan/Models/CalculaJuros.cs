using System;

namespace APISoftplan.Models
{
    public class CalculaJuros
    {
        public double ValorInicial { get; set; }
        public int Meses { get; set; }
        
        public CalculaJuros()
        {

        }

        public CalculaJuros(double valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;           
        }

        public string CalcularjurosCompostos(CalculaJuros calculaJuros)
        {
            var juros = 0.01;

            var result = calculaJuros.ValorInicial * Math.Pow((1 + juros), calculaJuros.Meses);

            return result.ToString("F");
        }
    }
}

