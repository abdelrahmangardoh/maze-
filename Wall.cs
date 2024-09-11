using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    internal class Wall : ImazeObject
    {
        public char icon { get => '#'; }
        public bool isolidated { get => true; }
    }
}
