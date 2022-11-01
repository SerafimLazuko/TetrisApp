using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.Game
{
    public class CustomFigureEventArgs : EventArgs
    {
        public (int, int)[] indexes;

        public CustomFigureEventArgs((int, int)[] values)
        {
            indexes = values;
        }
    }
}
