
using TetrisApp.Game;

namespace TetrisApp.Controls
{
    public partial class PauseMenu : UserControl
    {
        private CustomFigureEventArgs resumeButtonEventArgs;

        public event EventHandler<CustomFigureEventArgs> CustomFigureConfirmedEvent;
        public event EventHandler ResumeButtonClicked;
        public event EventHandler EndGameButtonClicked;

        public PauseMenu()
        {
            InitializeComponent();
        }

        private void CustomFigureConfirmed(object sender, CustomFigureEventArgs e)
        {
            resumeButtonEventArgs = e;
        }

        private void Resume_btn_Click(object sender, EventArgs e)
        {
            if(resumeButtonEventArgs != null)
            {
                e = resumeButtonEventArgs;
            }

            EventHandler handler = ResumeButtonClicked;
            handler?.Invoke(this, e);
        }

        private void EndGame_btn_Click(object sender, EventArgs e)
        {
            EventHandler handler = EndGameButtonClicked;
            handler?.Invoke(this, e);
        }
    }
}
