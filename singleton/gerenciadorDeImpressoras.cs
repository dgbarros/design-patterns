class GerenciadorDeImpressoras
{
    private static GerenciadorDeImpressoras instancia;
    private static readonly object bloqueio = new object();

    public static GerenciadorDeImpressoras Instancia
    {
        get
        {
            if (instancia == null)
            {
                lock (bloqueio)
                {
                    if (instancia == null)
                    {
                        instancia = new GerenciadorDeImpressoras();
                    }
                }
            }

            return instancia;
        }
    }

    public void Imprimir (string documento)
    {
        Console.WriteLine($"Imprimindo: {documento}");
    }
}