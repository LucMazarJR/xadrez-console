using tabuleiro;
using xadrez;
using xadrez_console;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab);

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                partida.ExecutaMovimento(origem, destino);
            }
        }
        catch(TabuleiroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}