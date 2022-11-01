using System.Text.RegularExpressions;

namespace TetrisApp.Controls
{
    public partial class NewGameSettings : UserControl
    {
        private Control parent;

        private int newGameSpaceHeight;
        private int newGameSpaceWidth;

        public NewGameSettings(Control parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            parent.Controls.Remove(this);
            parent.Size = new Size(400, 400);

            foreach (var control in parent.Controls.OfType<Control>().ToList())
                control.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.UseDefault_checkBox.Checked)
            {
                this.Height_textBox.Enabled = false;
                this.Width_textBox.Enabled = false;
                this.ticket_lbl.Visible = false;
            }
            else
            {
                this.Height_textBox.Enabled = true;
                this.Width_textBox.Enabled = true;
            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if (this.UseDefault_checkBox.Checked)
            {
                newGameSpaceHeight = 400;
                newGameSpaceWidth = 300;
            }
            else
            {
                if (!ValidateMapSize())
                {
                    this.ticket_lbl.Visible = true;
                    return;
                }

                newGameSpaceHeight = int.Parse(this.Height_textBox.Text) * 20;
                newGameSpaceWidth = int.Parse(this.Width_textBox.Text) * 20;
            }

            var gameSpace = new GameSpace(parent, newGameSpaceWidth, newGameSpaceHeight);

            parent.Controls.Add(gameSpace);

            parent.Controls.Remove(this);
        }

        private bool ValidateMapSize()
        {
            var height = this.Height_textBox.Text;
            var width = this.Width_textBox.Text;

            Regex regex = new Regex("^\\d+$");

            return regex.IsMatch(height) && regex.IsMatch(width);
        }
    }
}
