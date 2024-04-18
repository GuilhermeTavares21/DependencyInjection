using DependencyInjection;
using static DependencyInjection.GameManager;

GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gm.PlayRound();
    if (result == RoundResult.Vitoria)
    {
        Console.WriteLine("Parabéns, Jogador 1 venceu! ");
    }
    if (result == RoundResult.Derrota)
    {
        Console.WriteLine("Derrota, Jogador 2 venceu! ");
    }
    if (result == RoundResult.Empate)
    {
        Console.WriteLine("Empatou! ");
    }
    Console.WriteLine("Você gostaria de continuar jogando? (S/N)");

} while (Console.ReadLine().ToUpper() == "S");