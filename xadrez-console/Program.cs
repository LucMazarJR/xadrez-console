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

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentoPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

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