using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritaArquivo
{
    class GravaTxt : GravaArquivo
    {
        public override void GravaArquivos(ref List<Pessoa> listPessoa, string caminhoArquivo)
        {
            StreamWriter write = new StreamWriter(caminhoArquivo, false, Encoding.UTF8);

            foreach (var list in listPessoa)
            {
                write.WriteLine(
                        $"{RetornaTexto(list.nome)};" +
                        $"{RetornaTexto(list.sobrenome)};" +
                        $"{RetornaTexto(list.idade.ToString())};" +
                        $"{RetornaTexto(list.logradouro)};"

                    );
            }
            write.Close();
            write.Dispose();
        }
        private string RetornaTexto(string texto)
        {
            int espaço = 40;

            for (int i = texto.Length; i < espaço; i++)
            {
                texto += " ";
            }

            return texto;
        }
    }
    
}
