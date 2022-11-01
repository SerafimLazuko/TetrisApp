
using System.Windows.Forms;
using TetrisApp.Figures;

namespace TetrisApp.Game
{
    public class Logic
    {
        private int height;
        private int width;
        private int score;

        private Map map;
        private UserControl gameSpaceControl;
        private List<Button> currentAtomsControls;

        private bool isItPlayable = true;
        private bool isPaused = false;

        private FiguresEnum currentFigureEnum;
        private FiguresEnum nextFigureEnum = FiguresEnum.def1;

        public event EventHandler GameOverEvent;

        public Logic(UserControl gameSpaceControl, int width, int height)
        {
            this.gameSpaceControl = gameSpaceControl;
            this.height = height;
            this.width = width;

            ((GameSpace)gameSpaceControl).PauseButtonPressed += new EventHandler(this.OnPauseButtonPressed);
            ((GameSpace)gameSpaceControl).ResumeButtonPressed += new EventHandler(this.OnResumeButtonPressed);

            score = 0;
            map = new Map(height,width);
            map.MapRowFilled += new EventHandler<MapRowFilledEventArgs>(OnMapRowFilled);
            currentAtomsControls = new List<Button>();
        }

        public void Start()
        {
            ContinueGame();
        }

        public void ContinueGame()
        {
            if(currentAtomsControls.Count > 0)
            {
                MoveFigureDown();
            }

            while (isItPlayable)
            {
                BuildRandomFigure();
                MoveFigureDown();

                if(isPaused)
                    break;
            }
        }

        private void OnPauseButtonPressed(object sender, EventArgs e)
        {
            isPaused = true;
        }

        private void OnResumeButtonPressed(object sender, EventArgs e)
        {
            isPaused = false;

            if(e is CustomFigureEventArgs evenArgs)
            {
                BuildCustomFigure(evenArgs);
            }

            ContinueGame();
        }

        private void OnGameOver()
        {
            EventHandler handler = GameOverEvent;
            handler?.Invoke(this, new EventArgs());
        }

        public void BuildCustomFigure(CustomFigureEventArgs e)
        {
            var indexes = e.indexes;

            FiguresEnum def11 = (FiguresEnum)11;

            if (DefaultFiguresAtomsCoods.FiguresToAtomCoodsDictionary.ContainsKey(def11))
                DefaultFiguresAtomsCoods.FiguresToAtomCoodsDictionary.Remove(def11);

            indexes = indexes.Select(x => (x.Item1 * 20, x.Item2 * 20)).ToArray();
            
            DefaultFiguresAtomsCoods.FiguresToAtomCoodsDictionary.Add(def11, indexes);

            // here we set next figure to be our custom figure
            nextFigureEnum = def11;
        }

        private void BuildRandomFigure()
        {
            //Pick random current and next figure
            Random random = new Random();
            var figureNames = Enum.GetValues(typeof(FiguresEnum));

            currentFigureEnum = nextFigureEnum;
            nextFigureEnum = (FiguresEnum)figureNames.GetValue(random.Next(figureNames.Length));
           
            //Build current figure and next figure
            var figureAtomsCoods = DefaultFiguresAtomsCoods.FiguresToAtomCoodsDictionary[currentFigureEnum].ToList();
            var nextFigureAtomsCoods = DefaultFiguresAtomsCoods.FiguresToAtomCoodsDictionary[nextFigureEnum].ToList();

            //align centre
            figureAtomsCoods = figureAtomsCoods.Select(x => (x.Item1 += (width / 2) % 20 == 0 ? width / 2 : width / 2 + 10, x.Item2)).ToList();
            nextFigureAtomsCoods = nextFigureAtomsCoods.Select(x => (x.Item1 += (width / 2) % 20 == 0 ? width / 2 : width / 2 + 10, x.Item2)).ToList();

            //Remove old next to show
            var tempToRemove = gameSpaceControl.Controls.Find("NextTempAtom", false).ToList();
            foreach (var control in tempToRemove)
            {
                gameSpaceControl.Invoke((MethodInvoker)delegate
                {
                    gameSpaceControl.Controls.Remove(control);
                });
            }

            //Create new Next to show
            BuildNext(nextFigureAtomsCoods);

            //Create current atoms
            foreach (var atom in figureAtomsCoods)
            {
                var atomControl = new Button();
                atomControl.Size = new Size(20, 20);
                atomControl.Location = new Point(atom.Item1, atom.Item2);
                atomControl.Padding = new Padding(0, 0, 0, 0);
                atomControl.Margin = new Padding(0, 0, 0, 0);
                atomControl.Name = "atom";
                atomControl.BackColor = Color.Gray;
                atomControl.KeyUp += new KeyEventHandler(OnGameSpaceKeyUp);
                atomControl.FlatStyle = FlatStyle.Flat;
                atomControl.FlatAppearance.BorderColor = Color.IndianRed;
                atomControl.FlatAppearance.BorderSize = 1;
                atomControl.FlatAppearance.MouseOverBackColor = Color.IndianRed; 
                currentAtomsControls.Add(atomControl);

                gameSpaceControl.Invoke((MethodInvoker)delegate
                {
                    gameSpaceControl.Controls.Add(atomControl);
                });
            }
        }

        private void MoveFigureDown()
        {
            while (map.CanMoveAtomsDown(currentAtomsControls))
            {
                foreach (var atom in currentAtomsControls)
                {
                    atom.Invoke((MethodInvoker)delegate {
                        atom.Location = new Point(atom.Location.X, atom.Location.Y + 20);
                    });
                }

                Thread.Sleep(200);
                
                if (isPaused)
                    break;
            }

            if (!map.CanMoveAtomsDown(currentAtomsControls))
            {
                foreach (var atom in currentAtomsControls)
                {
                    if (atom.Location.Y == 0)
                    {
                        isItPlayable = false;
                        OnGameOver();
                        return;
                    }

                    atom.Invoke((MethodInvoker)delegate {
                        map.DrawAtomInPosition(atom);
                        atom.Enabled = false;
                    });
                    
                    score += 12;
                }

                var lbl = gameSpaceControl.Controls.Find("Score_lbl", false).FirstOrDefault();

                lbl.Invoke((MethodInvoker)delegate {
                    lbl.Text = score.ToString();
                });

                currentAtomsControls.Clear();
            }
        }

        private void MoveFigureLeft()
        {
            if(map.CanMoveAtomsLeft(currentAtomsControls) && !isPaused)
            {
                foreach (var atom in currentAtomsControls)
                {
                    atom.Location = new Point(atom.Location.X - 20, atom.Location.Y);
                }
            }
        }

        private void MoveFigureRight()
        {
            if(map.CanMoveAtomsRight(currentAtomsControls) && !isPaused)
            {
                foreach (var atom in currentAtomsControls)
                {
                    atom.Location = new Point(atom.Location.X + 20, atom.Location.Y);
                }
            }
        }

        private void BuildNext(List<(int, int)> coods)
        {
            foreach (var atom in coods)
            {
                var nextAtomControl = new Button();
                nextAtomControl.Size = new Size(20, 20);
                nextAtomControl.FlatStyle = FlatStyle.Flat;
                nextAtomControl.Name = "NextTempAtom";
                nextAtomControl.Location = new Point(atom.Item1, atom.Item2);
                nextAtomControl.Padding = new Padding(0, 0, 0, 0);
                nextAtomControl.Margin = new Padding(0, 0, 0, 0);
                nextAtomControl.BackColor = Color.IndianRed;
                nextAtomControl.FlatAppearance.BorderColor = Color.Gray;
                nextAtomControl.FlatAppearance.BorderSize = 3;
                nextAtomControl.Enabled = false;
                
                gameSpaceControl.Invoke((MethodInvoker)delegate
                {
                    gameSpaceControl.Controls.Add(nextAtomControl);
                });
            }
        }

        private void OnMapRowFilled(object sender, MapRowFilledEventArgs e)
        {
            score += 7777;

            foreach (Control control in gameSpaceControl.Controls.OfType<Button>().ToList())
            {
                if (e.atomNamesToRemove.Contains(control.Name))
                {
                    gameSpaceControl.Invoke((MethodInvoker)delegate
                    {
                        gameSpaceControl.Controls.Remove(control);
                        control.Dispose();
                    });
                }
            }

            gameSpaceControl.Invoke((MethodInvoker)delegate
            {
                var controlsToMoveDown = gameSpaceControl.Controls.OfType<Button>().Where(b => e.atomNamesToMoveDown.Contains(b.Name)).ToList<Button>();
                MapRowFilledControlsDown(controlsToMoveDown);
            });

        }

        private void OnGameSpaceKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveFigureRight();
                    break;
                case Keys.Left:
                    MoveFigureLeft();
                    break;
            }
        }

        private void MapRowFilledControlsDown(List<Button> controlsList)
        {
            foreach (var control in controlsList)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + 20);
                control.Name = $"x{control.Location.X / 20}y{control.Location.Y  / 20}";
            }
        }
    }
}