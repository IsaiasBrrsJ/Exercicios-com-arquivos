namespace SegundoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Faça um programa que receba do usuário um arquivo texto e mostre na tela quantas vezes cada
              letra do alfabeto aparece dentro do arquivo.
            */

            string caminhoUser = @"D:\C#\TREINO ARQUIVOS\SegundoExercicio\Alfabeto.txt";
            string[] alfabeto = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            StreamReader sr = new StreamReader(caminhoUser);

            string linha = sr.ReadLine();
            int contarLetras = 0;

            while (linha != null)
            {
                int countLetra = 0; // vai zerar a variavel, para contar a proxima frase;
              
                while (true)
                {
                    try
                    {
                        string letraPorLetra = linha[countLetra].ToString(); // quebro a string e pego letra por letra

                        if (alfabeto.Contains(letraPorLetra.ToUpper())) // verifica se existe a letra no vetor;
                        {
                            contarLetras++; // se exitir conta mais um;
                        }
                    }
                    catch
                    {
                        break; // caso o countLetra seja maior que o indice frasePorFrase, vai cair aqui e ir pro loop principal;
                    }
                    countLetra++; // vai incrementar mais um pra sempre pegar a proxima letra
                }

                linha = sr.ReadLine();  // vai pegar a proxima linha do arquivo;
            }

            sr.Close();
            sr.Dispose();

            Console.WriteLine("Quantidade de vezes que aparecem as letras do alfabeto no arquivo: " + contarLetras);
            Console.ReadKey();
        }
    }
}