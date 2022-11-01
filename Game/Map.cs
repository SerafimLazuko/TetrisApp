
namespace TetrisApp.Game
{
    public class Map
    {
        private int mapHeight;
        private int mapWidth;

        private ValueTuple<Point, Control>[ , ] atomsMap;

        public event EventHandler<MapRowFilledEventArgs> MapRowFilled;
        
        public Map(int height, int width)
        {
            mapHeight = height;
            mapWidth = width;

            atomsMap = new (Point, Control)[(height / 20), (width / 20)];
            DigitizeMap();
        }

        public void DrawAtomInPosition(Control atom)
        {
            var x = atom.Location.X / 20;
            var y = atom.Location.Y / 20;

            var atomControl = new Button();
            atomControl.Location = new Point(atom.Location.X, atom.Location.Y);
            
            //uniq name to link map atoms and view controls
            atom.Name = $"x{x}y{y}";
            atomControl.Name = atom.Name;

            atomsMap[y, x].Item2 = atomControl;

            if (IsMapRowFilled(y))
            {
                var atomNamesToRemove = new List<string>();
                var atomNamesToMoveDown = new List<string>();

                for(int i = 0; i < mapWidth / 20; i++)
                {
                    atomNamesToRemove.Add(atomsMap[y, i].Item2.Name);
                    atomsMap[y, i].Item2 = null;
                }

                for(int i = y - 1; i >= 0; i--)
                {
                    for (int j = 0; j < mapWidth / 20; j++)
                    {
                        if (atomsMap[i,j].Item2 != null)
                        {
                            atomNamesToMoveDown.Add(atomsMap[i,j].Item2.Name);
                            
                            if (atomsMap[i - 1, j].Item2 == null)
                            {
                                atomsMap[i, j].Item2 = null;
                            }
                        }
                    }
                }

                var args = new MapRowFilledEventArgs(atomNamesToRemove, atomNamesToMoveDown);
                MapRow_Filled(args);
            }
        }

        public bool CanMoveAtomsDown(List<Button> atoms)
        {
            bool canDrawFigureOnMap = false;

            foreach (var atom in atoms)
            {
                canDrawFigureOnMap = IsPositionUnderEmpty(atom) ? true : false;

                if (!canDrawFigureOnMap)
                    break;
            }

            return canDrawFigureOnMap;
        }

        public bool CanMoveAtomsLeft(List<Button> atoms)
        {
            bool canDrawFigureOnMap = false;

            foreach (var atom in atoms)
            {
                canDrawFigureOnMap = IsPositionLeftEmpty(atom) ? true : false;

                if (!canDrawFigureOnMap)
                    break;
            }

            return canDrawFigureOnMap;
        }

        public bool CanMoveAtomsRight(List<Button> atoms)
        {
            bool canDrawFigureOnMap = false;

            foreach (var atom in atoms)
            {
                canDrawFigureOnMap = IsPositionRightEmpty(atom) ? true : false;

                if (!canDrawFigureOnMap)
                    break;
            }

            return canDrawFigureOnMap;
        }

        private void MapRow_Filled(MapRowFilledEventArgs e)
        {
            EventHandler<MapRowFilledEventArgs> handler = MapRowFilled;
            handler?.Invoke(this, e);
        }

        private bool IsPositionUnderEmpty(Control atom)
        {
            var x = atom.Location.X / 20;
            var y = atom.Location.Y / 20 + 1;

            if(y == mapHeight / 20 || x == mapWidth / 20)
            {
                return false; // out of map
            }

            return atomsMap[y, x].Item2 == null ? true : false;
        }

        private bool IsPositionLeftEmpty(Control atom)
        {
            var x = atom.Location.X / 20 - 1;
            var y = atom.Location.Y / 20;

            if (x < 0)
            {
                return false; // out of map
            }

            return atomsMap[y, x].Item2 == null ? true : false;
        }

        private bool IsPositionRightEmpty(Control atom)
        {
            var x = atom.Location.X / 20 + 1;
            var y = atom.Location.Y / 20;

            if (x == mapWidth / 20)
            {
                return false; // out of map
            }

            return atomsMap[y, x].Item2 == null ? true : false;
        }

        private bool IsMapRowFilled(int rowIndex)
        {
            var rowFilled = true;

            for(int i = 0; i < mapWidth/ 20; i++)
            {
                if (atomsMap[rowIndex, i].Item2 == null)
                {
                    rowFilled = false;
                    break;
                }
            }

            return rowFilled;
        }

        private void DigitizeMap()
        {
            var currentHeight = 0;

            for (int i = 0; i < mapHeight / 20; i++)
            {
                var currentWidth = 0;

                for (int j = 0; j < mapWidth / 20; j++)
                {
                    var point = new Point(currentWidth, currentHeight);
                    atomsMap[i, j].Item1 = point;
                    currentWidth += 20;
                }

                currentHeight += 20;
            }
        }
    }
}
