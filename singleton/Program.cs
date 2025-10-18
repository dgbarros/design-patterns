using System;

namespace Factory
{
    class Program
    {
        static void Main (string [] args)
        {
            var spooler1 = GerenciadorDeImpressoras.Instancia;
            var spooler2 = GerenciadorDeImpressoras.Instancia;

            spooler1.Imprimir("Documento.pdf");
            spooler2.Imprimir("Documento.docx");

            Console.WriteLine(spooler1 == spooler2); 
            
        }
    }
}