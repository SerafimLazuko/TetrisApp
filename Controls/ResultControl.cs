
namespace TetrisApp.Controls
{
    public partial class ResultControl : UserControl
    {
        private string score;
        private Control gameSpace;

        public ResultControl(Control gameSpace, string score)
        {
            this.gameSpace = gameSpace;
            this.score = score;
            InitializeComponent();
        }

        private void NewGame_btn_Click(object sender, EventArgs e)
        {
            var controls = gameSpace.Controls.OfType<Control>().ToList();

            foreach(var control in controls)
                gameSpace.Controls.Remove(control);

            GameSpace newGameSpace = new GameSpace(((GameSpace)gameSpace).parent, ((GameSpace)gameSpace).newGameSpaceWidth, ((GameSpace)gameSpace).newGameSpaceHeight);
            ((GameSpace)gameSpace).parent.Controls.Add(newGameSpace);

            ((GameSpace)gameSpace).parent.Controls.Remove(this);
            gameSpace.Dispose();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
