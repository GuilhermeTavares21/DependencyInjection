using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection;

public class GameManager
{
    private IPlayer _player1;
    private IPlayer _player2;

    public GameManager(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public RoundResult PlayRound()
    {
        Choice p1 = _player1.GetChoice();
        Choice p2 = _player2.GetChoice();

        Console.WriteLine($"Jogador 1 escolheu {p1.ToString()} e o jogador 2 escolheu {p2.ToString()}");

        if (p1 == p2)
        {
            return RoundResult.Empate;
        }
        if (p1 == Choice.Pedra && p2 == Choice.Tesoura ||
           p1 == Choice.Papel && p2 == Choice.Pedra ||
            p1 == Choice.Tesoura && p2 == Choice.Papel)
        {
            return RoundResult.Vitoria;
        }
        return RoundResult.Derrota;
    }

    public enum Choice
    {
        Pedra,
        Papel,
        Tesoura
    }

    public enum RoundResult
    {
        Vitoria,
        Derrota,
        Empate
    }

}
