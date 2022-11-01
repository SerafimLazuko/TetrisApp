using TetrisApp.Game;

namespace TetrisApp.Controls
{
    partial class PauseMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resume_btn = new System.Windows.Forms.Button();
            this.customFigure1 = new TetrisApp.Controls.CustomFigure();
            this.Tip_lbl = new System.Windows.Forms.Label();
            this.EndGame_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resume_btn
            // 
            this.Resume_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resume_btn.Location = new System.Drawing.Point(5, 17);
            this.Resume_btn.Name = "Resume_btn";
            this.Resume_btn.Size = new System.Drawing.Size(95, 40);
            this.Resume_btn.TabIndex = 0;
            this.Resume_btn.Text = "Resume";
            this.Resume_btn.UseVisualStyleBackColor = true;
            this.Resume_btn.Click += new System.EventHandler(this.Resume_btn_Click);
            // 
            // customFigure1
            // 
            this.customFigure1.Location = new System.Drawing.Point(8, 158);
            this.customFigure1.Name = "customFigure1";
            this.customFigure1.Size = new System.Drawing.Size(91, 198);
            this.customFigure1.TabIndex = 1;
            this.customFigure1.FigureConfirmed += new System.EventHandler<TetrisApp.Game.CustomFigureEventArgs>(this.CustomFigureConfirmed);
            // 
            // Tip_lbl
            // 
            this.Tip_lbl.AutoSize = true;
            this.Tip_lbl.Location = new System.Drawing.Point(7, 65);
            this.Tip_lbl.Name = "Tip_lbl";
            this.Tip_lbl.Size = new System.Drawing.Size(96, 80);
            this.Tip_lbl.TabIndex = 2;
            this.Tip_lbl.Text = "Set your \r\ncustom \r\nfigure (up to \r\n8 blocks) ";
            // 
            // EndGame_btn
            // 
            this.EndGame_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndGame_btn.Location = new System.Drawing.Point(5, 340);
            this.EndGame_btn.Name = "EndGame_btn";
            this.EndGame_btn.Size = new System.Drawing.Size(95, 60);
            this.EndGame_btn.TabIndex = 3;
            this.EndGame_btn.Text = "End game";
            this.EndGame_btn.UseVisualStyleBackColor = true;
            this.EndGame_btn.Click += new System.EventHandler(this.EndGame_btn_Click);
            // 
            // PauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndGame_btn);
            this.Controls.Add(this.Tip_lbl);
            this.Controls.Add(this.customFigure1);
            this.Controls.Add(this.Resume_btn);
            this.Name = "PauseMenu";
            this.Size = new System.Drawing.Size(106, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Resume_btn;
        private CustomFigure customFigure1;
        private Label Tip_lbl;
        private Button EndGame_btn;
    }
}
