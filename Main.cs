
using TetrisApp.Controls;
using TetrisApp.Figures;

namespace TetrisApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void NewGameButton_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls.OfType<Control>().ToList())
                control.Hide();

            Size = new Size(400, 400);

            var settings = new NewGameSettings(this);

            this.Controls.Add(settings);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}