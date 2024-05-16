namespace TestesUnitarios.Desafio.Console.Services
{
    public class AcoesCalculadora{    

        private string data;
        private List<string> listahistorico;
        
        public AcoesCalculadora(string data){

            listahistorico = new List<string>();
            this.data = data;

        }

        public int Soma(int numero1, int numero2)
        {
            var resultadoSoma = numero1 + numero2;
            listahistorico.Insert(0, "res: " + resultadoSoma + "data:" + data);
            return resultadoSoma;
        }

        public int Subtracao(int numero1, int numero2)
        {
            var resultadoSubtracao = numero1 - numero2;
            listahistorico.Insert(0, "res: " + resultadoSubtracao + "data:" + data);
            return resultadoSubtracao;
        }

        public int Divisao(int numero1, int numero2)
        {
            var resultadoDivisao = numero1 / numero2;
            listahistorico.Insert(0, "res: " + resultadoDivisao + "data:" + data);
            return resultadoDivisao;
        }

        public int Multiplicacao(int numero1, int numero2)
        {
            var resultadoMultiplicacao = numero1 * numero2;
            listahistorico.Insert(0, "res: " + resultadoMultiplicacao + "data:" + data);
            return resultadoMultiplicacao;
        }
        
        public List<string> Historico(){

            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
