﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DependencyInjection.GameManager;

namespace DependencyInjection
{

    public interface IPlayer
    {
        Choice GetChoice();

        
    }
}
