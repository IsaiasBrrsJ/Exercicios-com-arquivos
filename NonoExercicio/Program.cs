using System.Text;

namespace NonoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\C#\TREINO ARQUIVOS\NonoExercicio\primeiroArquivo.txt";
            string pathII = @"D:\C#\TREINO ARQUIVOS\NonoExercicio\segundoArquivo.txt";

            if (!File.Exists(path)) { File.Create(path).Close(); }
            if (!File.Exists(pathII)) { File.Create(pathII).Close(); }
            /*
              Dado um arquivo contendo um conjunto de nome (40 caracteres) e data de nascimento
              (DDMMAAAA, isto é,3 inteiros em sequência), faça um programa que leia o nome do arquivo e a
              data de hoje e construa outro arquivo contendo o nome e a idade de cada pessoa do primeiro arquivo.
            */

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            if (nome.Length < 40) { nome = PreencheComQuarentaCaracteres(nome); }

            string[] dataNascimento = null;
            
              Console.WriteLine("Digite sua data de nascimento (DD/MM/AAAA): ");
               dataNascimento = Console.ReadLine().Split("/");
           
            int dia = int.Parse(dataNascimento[0]);
            int mes = int.Parse(dataNascimento[1]);
            int ano = int.Parse(dataNascimento[2]);

            DateTime dtNasc = new DateTime(ano, mes, dia);

       
            Console.WriteLine("Digite o nome do arquivo: ");
            string nomeArquivo = Console.ReadLine();
            string nomeArq = nomeArquivo.Substring(0, nomeArquivo.IndexOf('.'));

            if (File.Exists($@"D:\CursoFreedC#\TREINO ARQUIVOS\NonoExercicio\{nomeArq}.txt")){
                StreamWriter writet = new StreamWriter(pathII, true, encoding: Encoding.UTF8);

                writet.WriteLine($"{nome};{(DateTime.Now.Year - dtNasc.Year)}");
                writet.Close();
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado");
            }
            

        }

       static string PreencheComQuarentaCaracteres(string nome)
       {
            for (int i = nome.Length; i < 40; i++)
            {
                nome += " ";
            }

            return nome;
       }
    }
}