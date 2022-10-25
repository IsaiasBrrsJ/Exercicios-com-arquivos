using System.ComponentModel;
using System.Text;

namespace QuartoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que receba o nome de um arquivo de entrada e outro de saída. O arquivo de entrada contém em cada linha o nome de uma cidade
             (ocupando 40 caracteres) e o seu número de habitantes (ocupando 7 posições).
            O programa deverá ler o arquivo de entrada e gerar um arquivo de saída onde aparece o nome da cidade mais populosa seguida pelo seu número de habitantes.

            */

            string caminhoRaiz = @"D:\C#\TREINO ARQUIVOS\QuartoExercicio";
            string nomeArquivo = "";
            string nomeFinalArquivo ="";

            Console.Write("Digite o nome do arquivo inicial: ");
            nomeArquivo = Console.ReadLine().Replace(".", " ").Replace(",", "");
            nomeArquivo = nomeArquivo.Substring(0, nomeArquivo.IndexOf(" "));

            Console.Write("Digite o nome final do arquivo: ");
            nomeFinalArquivo = Console.ReadLine().Replace(".", " ").Replace(",", "");
            nomeFinalArquivo = nomeFinalArquivo.Substring(0, nomeFinalArquivo.IndexOf(" "));

            if (!File.Exists(caminhoRaiz + @$"\{nomeArquivo}.txt")) // verificar se ja existe um arquivo
            {
                File.Create(caminhoRaiz + @$"\{nomeArquivo}.txt").Close(); //caso nao exista ele entra aqui e cria 
                Console.WriteLine(caminhoRaiz + @$"\{nomeArquivo}.txt");
                Console.ReadKey();
            }

            if (!File.Exists(caminhoRaiz + @$"\{nomeFinalArquivo}.txt")) // verificar se ja existe um arquivo
            {
                File.Create(caminhoRaiz + @$"\{nomeFinalArquivo}.txt").Close(); //caso nao exista ele entra aqui e cria 
                Console.WriteLine(caminhoRaiz + @$"\{nomeFinalArquivo}.txt");
                Console.ReadKey();
            }

            StreamWriter writeInicial = new StreamWriter(caminhoRaiz+@$"\{nomeArquivo}.txt");
            StreamWriter writeFinal = new StreamWriter(caminhoRaiz+@$"\{nomeFinalArquivo}.txt");

            int count = 0;
            string[] cidade = new string[3];
            int[] habitante = new int[3];

            while (count < 3)
            {
                Console.Clear();
                Console.Write("Digite o nome da cidade: ");
                string nomeCidade = Console.ReadLine();

                int numHabitante;
                do
                {
                    Console.Write("Digite o número de habitante de {0}: ", nomeCidade);
                } while (int.TryParse(Console.ReadLine(), out numHabitante) == false);


                cidade[count] = nomeCidade;
                habitante[count] = numHabitante;

               writeInicial.WriteLine(PreencheNomeCidade(nomeCidade) + PreencheNumeroHabitante(numHabitante.ToString()));

                count++;
            }

            writeInicial.Close();
            writeInicial.Dispose();

            for (int i = 0; i < habitante.Length; i++)
            {
                for (int j = i+1; j < habitante.Length; j++)
                {
                    if (habitante[j] > habitante[i])
                    {
                        int auxNum = habitante[i];
                        string auxNomeCidade = cidade[i];

                        habitante[i] = habitante[j];
                        cidade[i] = cidade[j];

                        habitante[j] = auxNum;
                        cidade[j] = auxNomeCidade;
                        
                    }
                }
            }

            for (int i = 0; i < habitante.Length; i++)
            {
                writeFinal.WriteLine(PreencheNomeCidade(cidade[i]) + PreencheNumeroHabitante(habitante[i].ToString()));
            }
            writeFinal.Close();
            writeFinal.Dispose();


            Console.ReadKey();
        }

        

        static string PreencheNomeCidade(string nomeCidade)
        {
            int preenchimento = 40;

            for (int i = nomeCidade.Length; i < preenchimento; i++)
            {
                nomeCidade += " ";
            }

            return nomeCidade;
        }
       static string PreencheNumeroHabitante(string numHabitantes)
        {
            int preenchimento = 7;
            for (int i = numHabitantes.Length ; i < preenchimento; i++)
            {
                numHabitantes += " ";
            }

            return numHabitantes;
        }
    }
}