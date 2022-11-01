using TetrisApp.Game;

namespace TetrisApp.Controls
{
    public partial class CustomFigure : UserControl
    {
        private bool[,] checkedIn;

        public event EventHandler<CustomFigureEventArgs> FigureConfirmed;
        
        public CustomFigure()
        {
            checkedIn = new bool[4,4];

            InitializeComponent();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            var isValid = false;
            var counter = 0;

            for (int i = 0; i < checkedIn.GetLength(0); i++)
            {
                for (int j = 0; j < checkedIn.GetLength(1); j++)
                {
                    if (checkedIn[i, j] == true)
                    {
                        isValid = VerifyAtom(i, j);

                        counter++;
                    }
                }
            }

            if (isValid == false || counter > 8)
            {
                this.Confirm_btn.Enabled = false;
                return;
            }

            var checkedInAtoms = new List<(int, int)>();

            for (int i = 0; i < checkedIn.GetLength(0); i++)
            {
                for (int j = 0; j < checkedIn.GetLength(1); j++)
                {
                    if (checkedIn[i, j] == true)
                    {
                        checkedInAtoms.Add((i, j));
                    }
                }
            }

            var eventArgs = new CustomFigureEventArgs(checkedInAtoms.ToArray());
            OnCustomFigureConfirmed(this, eventArgs);
        }

        private void OnCustomFigureConfirmed(object sender, CustomFigureEventArgs e)
        {
            EventHandler<CustomFigureEventArgs> handler = FigureConfirmed;
            handler?.Invoke(this, e);
        }

        private void Drop_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedIn.GetLength(0); i++)
            {
                for(int j = 0; j < checkedIn.GetLength(1); j++)
                {
                    checkedIn[i,j] = false;
                }
            }

            foreach(var button in this.table.Controls.OfType<Button>().ToList())
            {
                button.FlatStyle = FlatStyle.Standard;
                button.BackColor = Color.Transparent;
            }

            this.Confirm_btn.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            button.BackColor = Color.SlateGray; 
            button.FlatStyle = FlatStyle.Popup;

            int row = table.GetRow(button);
            int column = table.GetColumn(button);

            checkedIn[row, column] = true;
        }

        private bool VerifyAtom(int i, int j)
        {
            var result = false;

            if ((i == 1 || i == 2) && (j == 1 || j == 2))
            {
                if (checkedIn[i - 1, j] == true || checkedIn[i + 1, j] == true || checkedIn[i, j - 1] == true || checkedIn[i, j + 1] == true)
                {
                    result = true;
                }
            }

            if ((i == 1 || i == 2) && j == 0)
            {
                if (checkedIn[i+1,j] == true || checkedIn[i - 1, j] == true || checkedIn[i, j+1] == true)
                {
                    result = true;
                }
            }

            if((i == 1 || i == 2) && j == 3)
            {
                if (checkedIn[i + 1, j] == true || checkedIn[i - 1, j] == true || checkedIn[i, j - 1] == true)
                {
                    result = true;
                }
            }

            if (i == 0 && (j == 1 || j == 2))
            {
                if (checkedIn[i,j+1] == true || checkedIn[i, j - 1] == true || checkedIn[i + 1, j] == true)
                {
                    result = true;
                }
            }

            if (i == 3 && (j == 1 || j == 2))
            {
                if (checkedIn[i, j + 1] == true || checkedIn[i, j - 1] == true || checkedIn[i - 1, j] == true)
                {
                    result = true;
                }
            }

            if (i == 0 && j == 0)
                result = checkedIn[i + 1, j] || checkedIn[i , j + 1];

            if (i == 3 && j == 0)
                result = checkedIn[i - 1, j] || checkedIn[i , j + 1];

            if (i == 3 && j == 3)
                result = checkedIn[i - 1, j] || checkedIn[i, j - 1];

            if (i == 0 && j == 3)
                result = checkedIn[i + 1, j] || checkedIn[i, j - 1];

            return result;
        }
    }
}
