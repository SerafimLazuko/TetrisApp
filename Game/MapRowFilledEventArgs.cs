
namespace TetrisApp.Game
{
    public class MapRowFilledEventArgs : EventArgs
    {
        public List<string> atomNamesToRemove;
        public List<string> atomNamesToMoveDown;

        public MapRowFilledEventArgs(List<string> namesToRemove, List<string> namesToMoveDown)
        {
            atomNamesToRemove = new List<string>();
            atomNamesToMoveDown = new List<string>();

            foreach (string atomName in namesToRemove)
            {
                atomNamesToRemove.Add(atomName);
            }

            foreach (string atomName in namesToMoveDown)
            {
                atomNamesToMoveDown.Add(atomName);
            }
        }
    }
}
