using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritaArquivo
{
    abstract class GravaArquivo
    {
        public abstract void GravaArquivos(ref List<Pessoa> listPessoa, string caminhoArquivo);
    }
}
