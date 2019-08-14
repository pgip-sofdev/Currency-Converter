namespace CurrecnyConvertor
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.FromCombo = new System.Windows.Forms.ComboBox();
            this.ToCombo = new System.Windows.Forms.ComboBox();
            this.FromNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FromNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(632, 415);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 4;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(270, 251);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(100, 22);
            this.Result.TabIndex = 3;
            // 
            // FromCombo
            // 
            this.FromCombo.FormattingEnabled = true;
            this.FromCombo.Items.AddRange(new object[] {
            "US Dollar",
            "Bitcoin"});
            this.FromCombo.Location = new System.Drawing.Point(47, 98);
            this.FromCombo.Name = "FromCombo";
            this.FromCombo.Size = new System.Drawing.Size(121, 24);
            this.FromCombo.TabIndex = 0;
            // 
            // ToCombo
            // 
            this.ToCombo.FormattingEnabled = true;
            this.ToCombo.Items.AddRange(new object[] {
            "US Dollar",
            "Bitcoin"});
            this.ToCombo.Location = new System.Drawing.Point(47, 247);
            this.ToCombo.Name = "ToCombo";
            this.ToCombo.Size = new System.Drawing.Size(121, 24);
            this.ToCombo.TabIndex = 2;
            // 
            // FromNum
            // 
            this.FromNum.Location = new System.Drawing.Point(270, 100);
            this.FromNum.Name = "FromNum";
            this.FromNum.Size = new System.Drawing.Size(120, 22);
            this.FromNum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.FromNum);
            this.Controls.Add(this.ToCombo);
            this.Controls.Add(this.FromCombo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FromNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ComboBox FromCombo;
        private System.Windows.Forms.ComboBox ToCombo;
        private System.Windows.Forms.NumericUpDown FromNum;
    }
}

