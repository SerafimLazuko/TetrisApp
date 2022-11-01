using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.Figures
{
    public static class DefaultFiguresAtomsCoods
    {
        public static Dictionary<FiguresEnum, (int, int)[]> FiguresToAtomCoodsDictionary = new Dictionary<FiguresEnum, (int, int)[]>
        {
            {FiguresEnum.def1, new (int, int)[]{ (0, 0), (0, 20), (0, 40), (20, 40) } },
            {FiguresEnum.def2, new (int, int)[]{ (20, 0), (0, 20), (20, 20), (40, 20) } },
            {FiguresEnum.def3, new (int, int)[]{ (20, 0), (20, 20), (40, 20), (20, 40) } },
            {FiguresEnum.def4, new (int, int)[]{ (0, 20), (20, 20), (40, 20), (20, 40) } },
            {FiguresEnum.def5, new (int, int)[]{ (20, 0), (0, 20), (20, 20), (20, 40) } },
            {FiguresEnum.def6, new (int, int)[]{ (20, 0), (20, 20), (20, 40), (0, 40) } },
            {FiguresEnum.def7, new (int, int)[]{ (0, 0), (20, 0), (0, 20), (0, 40) } },
            {FiguresEnum.def8, new (int, int)[]{ (0, 0), (20, 0), (20, 20), (20, 40) } },
            {FiguresEnum.def9, new (int, int)[]{ (0, 0), (0, 20), (0, 40), (0, 60) } },
            {FiguresEnum.def10, new (int, int)[]{ (0, 0), (20, 0), (40, 0), (60, 0) } },
        };
    }
}
