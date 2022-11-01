namespace TetrisApp.Controls
{
    partial class NewGameSettings
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
            this.Start_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Height_textBox = new System.Windows.Forms.TextBox();
            this.Width_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UseDefault_checkBox = new System.Windows.Forms.CheckBox();
            this.ticket_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_btn.Location = new System.Drawing.Point(272, 281);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(100, 50);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_btn.Location = new System.Drawing.Point(22, 281);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 50);
            this.Back_btn.TabIndex = 2;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set map\'s size:";
            // 
            // Height_textBox
            // 
            this.Height_textBox.Location = new System.Drawing.Point(176, 156);
            this.Height_textBox.Name = "Height_textBox";
            this.Height_textBox.PlaceholderText = "e.g. 30";
            this.Height_textBox.Size = new System.Drawing.Size(125, 27);
            this.Height_textBox.TabIndex = 4;
            // 
            // Width_textBox
            // 
            this.Width_textBox.Location = new System.Drawing.Point(176, 189);
            this.Width_textBox.Name = "Width_textBox";
            this.Width_textBox.Size = new System.Drawing.Size(125, 27);
            this.Width_textBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set custom size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height (20 min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width (15 min)";
            // 
            // UseDefault_checkBox
            // 
            this.UseDefault_checkBox.AutoSize = true;
            this.UseDefault_checkBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UseDefault_checkBox.Location = new System.Drawing.Point(32, 59);
            this.UseDefault_checkBox.Name = "UseDefault_checkBox";
            this.UseDefault_checkBox.Size = new System.Drawing.Size(243, 32);
            this.UseDefault_checkBox.TabIndex = 9;
            this.UseDefault_checkBox.Text = "use default map (15x20)";
            this.UseDefault_checkBox.UseVisualStyleBackColor = true;
            this.UseDefault_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ticket_lbl
            // 
            this.ticket_lbl.AutoSize = true;
            this.ticket_lbl.ForeColor = System.Drawing.Color.Red;
            this.ticket_lbl.Location = new System.Drawing.Point(29, 219);
            this.ticket_lbl.Name = "ticket_lbl";
            this.ticket_lbl.Size = new System.Drawing.Size(145, 20);
            this.ticket_lbl.TabIndex = 10;
            this.ticket_lbl.Text = "*Please set numbers!";
            this.ticket_lbl.Visible = false;
            // 
            // NewGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.ticket_lbl);
            this.Controls.Add(this.UseDefault_checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Width_textBox);
            this.Controls.Add(this.Height_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "NewGameSettings";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Start_btn;
        private Button Back_btn;
        private Label label1;
        private TextBox Height_textBox;
        private TextBox Width_textBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox UseDefault_checkBox;
        private Label ticket_lbl;
    }
}
