using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static DependencyInjection.GameManager;

namespace DependencyInjection
{
    public class ComputerPlayer : IPlayer
    {
        Random random = new Random();
        public GameManager.Choice GetChoice()
        {

            Choice p2 = (Choice)random.Next(0, 3);


            return p2;
        }

        
    }
}
