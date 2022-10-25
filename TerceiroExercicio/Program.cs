namespace TerceiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que receba dois arquivos do usuário,
             e crie um terceiro arquivo com o conteúdo dos dois primeiros juntos
             (o conteúdo do primeiro seguido do conteúdo do segundo).
            */


            string caminhoUm = @"D:\C#\TREINO ARQUIVOS\TerceiroExercicio\PrimeiroArquivo.txt";
            string caminhoDois = @"D:\C#\TREINO ARQUIVOS\TerceiroExercicio\SegundoArquivo.txt";
            string caminhoTres = @"D:\C#\TREINO ARQUIVOS\TerceiroExercicio\TerceiroArquivo.txt";

            List<string> arquivos = new List<string>();

            StreamReader reader1 = new StreamReader(caminhoUm);
            StreamWriter writer1 = new StreamWriter(caminhoTres);
            
            while (!reader1.EndOfStream)
            {
               arquivos.Add(reader1.ReadLine()); // vai salvar em uma lista o conteudo do primeiro arquivo;
            }
            reader1.Close(); 

            StreamReader reader2 = new StreamReader(caminhoDois);

            foreach (var item in arquivos)
            {
                writer1.WriteLine(item);// vais salvar no terceiro arquivo o conteudo do primeiro arquivo
            }

            while (!reader2.EndOfStream) // enquanto não chegar no final do arquivo vai ficar escrevendo no terceiro arquivo
            {
                writer1.WriteLine(reader2.ReadLine()); // vai salvar no terceiro arquivo o conteudo do segundo arquivo junto ao primeiro arquivo
            }

            writer1.Close();
            reader2.Close();






        }
    }
}