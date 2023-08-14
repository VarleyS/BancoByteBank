using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoByteBank
{
    public class TituloDaOpcaoSelecionada
    {
        public void ExibindoTituloOpcao(string titulo)
        {
            int quant = titulo.Length;
            string ast = string.Empty.PadLeft(quant, '*');
            Console.WriteLine(ast);
            Console.WriteLine(titulo);
            Console.WriteLine(ast + "\n");
        }
    }
}
