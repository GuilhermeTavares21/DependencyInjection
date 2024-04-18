using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DependencyInjection.GameManager;

namespace DependencyInjection
{
    public class HumanPlayer : IPlayer
    {
        public GameManager.Choice GetChoice()
        {
            Choice p1;
            do
            {
                Console.WriteLine("Escolha (1)Pedra, (2)Papel ou (3)Tesoura: ");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    p1 = Choice.Pedra;
                    break;
                }
                else if (input == "2")
                {
                    p1 = Choice.Papel;
                    break;
                }
                else if (input == "3")
                {
                    p1 = Choice.Tesoura;
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha Incorreta!");
                }
            } while (true);

            return p1;
        }
    }
}
