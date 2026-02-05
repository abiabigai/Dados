namespace Dados
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            this.comboBoxSides = new System.Windows.Forms.ComboBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSides
            // 
            this.comboBoxSides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSides.Items.AddRange(new object[] {
            "6",
            "12",
            "20"});
            this.comboBoxSides.Location = new System.Drawing.Point(20, 30);
            this.comboBoxSides.Name = "comboBoxSides";
            this.comboBoxSides.Size = new System.Drawing.Size(120, 28);
            this.comboBoxSides.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSides.BackColor = System.Drawing.Color.FromArgb(255, 250, 205);
            this.comboBoxSides.ForeColor = System.Drawing.Color.FromArgb(10, 25, 74);
            this.comboBoxSides.TabIndex = 0;
            this.comboBoxSides.SelectedIndex = 0;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(150, 30);
            this.numericUpDownCount.Minimum = new decimal(new int[] {1,0,0,0});
            this.numericUpDownCount.Maximum = new decimal(new int[] {100,0,0,0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(80, 28);
            this.numericUpDownCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownCount.ForeColor = System.Drawing.Color.FromArgb(10, 25, 74);
            this.numericUpDownCount.TabIndex = 1;
            this.numericUpDownCount.Value = new decimal(new int[] {1,0,0,0});
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(230, 28);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(90, 32);
            this.buttonRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRoll.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.buttonRoll.ForeColor = System.Drawing.Color.White;
            this.buttonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoll.TabIndex = 2;
            this.buttonRoll.Text = "Tirar";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.ButtonRoll_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(20, 70);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResults.Size = new System.Drawing.Size(400, 320);
            this.textBoxResults.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResults.BackColor = System.Drawing.Color.FromArgb(248, 249, 255);
            this.textBoxResults.ForeColor = System.Drawing.Color.FromArgb(25, 25, 112);
            this.textBoxResults.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.TabIndex = 4;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(200, 30, 45);
            this.label1.Text = "Caras dado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.TabIndex = 5;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(200, 30, 45);
            this.label2.Text = "Cantidad:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 460);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.comboBoxSides);
            this.Name = "Form1";
            this.Text = "Dados - Tirada";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxSides;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}
