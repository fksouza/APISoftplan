using APISoftplan.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace APISoftplan.Models
{
    public class CalculaJuros : ICalculaJuros
    {
       
        public double ValorInicial { get; set; }
       
        public int Meses { get; set; }

        double juros = 0.01;

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
            var result = calculaJuros.ValorInicial * Math.Pow((1 + juros), calculaJuros.Meses);

            return result.ToString("F");
        }
    }
}

