namespace EscritaArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\CursoFreedC#\\TREINO ARQUIVOS";
            List<Pessoa> pessoa = new()
            {
                new Pessoa("Isaias", "Jesus", 300, "Daniela 5050 Aponiã"),
                new Pessoa("Teste", "Teste", 300, "Rua teste 535"),
                new Pessoa("Teste2", "Teste2", 300, "Rua teste2 525"),
                new Pessoa("Teste3", "Teste3", 300, "Rua teste3 555"),
           };


            GravaCSV csv = new GravaCSV();
            GravaTxt txt = new GravaTxt();

            csv.GravaArquivos(ref pessoa, path+@"\ArqCsv.csv");
            txt.GravaArquivos(ref pessoa, path + @"\ArqTxt.txt");
        }
    }
}