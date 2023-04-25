namespace Semana2
{
    public class M2S03E1
    {
        /* Crie um método que receba por parâmetro dois números inteiros e retorne a soma deles.*/

        //         Crie duas sobrecargas do método Soma de números, criado no exercício 1.
        //         A primeira recebendo dois valores do tipo Double e retornando a soma deles.
        //         E a segunda recebendo 3 Parâmetros do Tipo double e retornando a soma deles
        public int soma(int numero, int numero2)
        {
            return numero + numero2;
        }

        public double soma(double numero, double numero2)
        {
            return numero + numero2;
        }

        public double soma(double numero, double numero2, double numero3)
        {
            return numero + numero2+ numero3;
        }
    }
}
