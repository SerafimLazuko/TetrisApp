namespace TetrisApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NewGame_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame_btn
            // 
            this.NewGame_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewGame_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.NewGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGame_btn.Location = new System.Drawing.Point(53, 302);
            this.NewGame_btn.Margin = new System.Windows.Forms.Padding(0);
            this.NewGame_btn.Name = "NewGame_btn";
            this.NewGame_btn.Size = new System.Drawing.Size(100, 40);
            this.NewGame_btn.TabIndex = 0;
            this.NewGame_btn.Text = "New game";
            this.NewGame_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NewGame_btn.UseVisualStyleBackColor = false;
            this.NewGame_btn.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.Location = new System.Drawing.Point(299, 302);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 40);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 433);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 400);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.NewGame_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Location = new Point(300, 200);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Tetris App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button NewGame_btn;
        private Button Exit_btn;
        private PictureBox pictureBox1;
    }
}