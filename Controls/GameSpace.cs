using TetrisApp.Controls;
using TetrisApp.Game;

namespace TetrisApp
{
    public partial class GameSpace : UserControl
    {
        public int newGameSpaceHeight;
        public int newGameSpaceWidth;
        public Control parent;

        private Logic logic;
        private Thread game;
        private PauseMenu pauseMenuControl;

        public event EventHandler<CustomFigureEventArgs> CustomFigureConfirmed;
        public event EventHandler PauseButtonPressed;
        public event EventHandler ResumeButtonPressed;

        public GameSpace(Control parent, int width, int height)
        {
            this.parent = parent;
            this.newGameSpaceWidth = width;
            this.newGameSpaceHeight = height;
            this.parent.Size = new Size(width, height);

            logic = new Logic(this, newGameSpaceWidth, newGameSpaceHeight);
            logic.GameOverEvent += new EventHandler(this.GameOver);

            InitializeComponent();
        }

        private void GameSpace_Load(object sender, EventArgs e)
        {
            game = new Thread(() => logic.Start());
            game.Start();
        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {
            ((GameSpace)this).Pause_btn.Enabled = false;

            EventHandler handler = PauseButtonPressed;
            handler?.Invoke(this, e);

            pauseMenuControl = new PauseMenu();

            pauseMenuControl.ResumeButtonClicked += new EventHandler(Resume_btn_Click);
            pauseMenuControl.EndGameButtonClicked += new EventHandler(PauseMenu_ExitBtn_Click);

            parent.Controls.Add(pauseMenuControl);
            parent.Size = new Size(newGameSpaceWidth + 106, newGameSpaceHeight);

            pauseMenuControl.Location = new Point(newGameSpaceWidth, 0);
        }

        private void Resume_btn_Click(object sender, EventArgs e)
        {
            pauseMenuControl.ResumeButtonClicked -= new EventHandler(Resume_btn_Click);

            parent.Controls.Remove(pauseMenuControl);
            
            parent.Size = new Size(newGameSpaceWidth, newGameSpaceHeight);

            if (e is CustomFigureEventArgs eventArgs)
            {
                logic.BuildCustomFigure(eventArgs);
            }

            ((GameSpace)this).Pause_btn.Enabled = true;

            EventHandler handler = ResumeButtonPressed;
            game = new Thread(() => handler?.Invoke(this, e));
            game.Start();
        }

        private void PauseMenu_ExitBtn_Click(object sender, EventArgs e)
        {
            parent.Controls.Remove(this);
            parent.Controls.Remove(pauseMenuControl);
            parent.Size = new Size(400, 400);

            foreach (var control in parent.Controls.OfType<Control>().ToList())
                control.Show();
        }

        private void GameOver(object sender, EventArgs e)
        {
            Control resultControl = new ResultControl(this, this.Score_lbl.Text);
            resultControl.Location = new Point(newGameSpaceWidth / 2 - 100, newGameSpaceHeight / 2 - 150);

            parent.Invoke((MethodInvoker)delegate {
                parent.Controls.Add(resultControl);
                resultControl.BringToFront();
            });
        }
    }
}
