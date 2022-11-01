namespace TetrisApp
{
    partial class GameSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSpace));
            this.Pause_btn = new System.Windows.Forms.Button();
            this.Score_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pause_btn
            // 
            this.Pause_btn.BackColor = System.Drawing.Color.IndianRed;
            this.Pause_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pause_btn.BackgroundImage")));
            this.Pause_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause_btn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.Pause_btn.FlatAppearance.BorderSize = 0;
            this.Pause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Pause_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_btn.Location = new System.Drawing.Point(newGameSpaceWidth - 45, 0);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(45, 45);
            this.Pause_btn.TabIndex = 0;
            this.Pause_btn.UseVisualStyleBackColor = false;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // Score_lbl
            // 
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score_lbl.Location = new System.Drawing.Point(10, 10);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(26, 30);
            this.Score_lbl.TabIndex = 1;
            this.Score_lbl.Text = "0";
            
            // 
            // GameSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Size = new Size(newGameSpaceWidth, newGameSpaceHeight);
            this.Controls.Add(this.Score_lbl);
            this.Controls.Add(this.Pause_btn);
            this.Name = "GameSpace";
            this.Load += new System.EventHandler(this.GameSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        #endregion

        private Button Pause_btn;
        private Label Score_lbl;
    }
}
