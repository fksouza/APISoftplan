namespace APISoftplan.Models
{
    public class CalculaJuros
    {
        public decimal ValorInicial { get; set; }
        public int Meses { get; set; }
        public double Juros { get; set; }
        

        public CalculaJuros()
        {

        }

        public CalculaJuros(decimal valorInicial, int meses, double juros, decimal valorFinal)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            Juros = 0.01;            
        }

        public decimal CalcularjurosCompostos()
        {
            //Valor Final = Valor Inicial * (1 + juros) ^ Tempo
            // /calculajuros?valorinicial=100&meses=5 
            //Resultado esperado: 105,10

            //var result = Math.Pow(ValorInicial * (1 + Juros), Meses);

            return 0;
        }
    }
}
