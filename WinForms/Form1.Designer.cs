namespace WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_input = new System.Windows.Forms.NumericUpDown();
            this.name_input = new System.Windows.Forms.TextBox();
            this.lang_input = new System.Windows.Forms.ComboBox();
            this.birthDate_input = new System.Windows.Forms.DateTimePicker();
            this.birthPlace_input = new System.Windows.Forms.ComboBox();
            this.test_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.id_input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nyelv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Született:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dátum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hol:";
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(165, 26);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(176, 31);
            this.id_input.TabIndex = 6;
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(165, 65);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(176, 31);
            this.name_input.TabIndex = 7;
            // 
            // lang_input
            // 
            this.lang_input.FormattingEnabled = true;
            this.lang_input.Items.AddRange(new object[] {
            "angol",
            "német",
            "francia",
            "olasz"});
            this.lang_input.Location = new System.Drawing.Point(165, 105);
            this.lang_input.Name = "lang_input";
            this.lang_input.Size = new System.Drawing.Size(176, 33);
            this.lang_input.TabIndex = 8;
            // 
            // birthDate_input
            // 
            this.birthDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate_input.Location = new System.Drawing.Point(165, 183);
            this.birthDate_input.Name = "birthDate_input";
            this.birthDate_input.Size = new System.Drawing.Size(176, 31);
            this.birthDate_input.TabIndex = 9;
            // 
            // birthPlace_input
            // 
            this.birthPlace_input.FormattingEnabled = true;
            this.birthPlace_input.Items.AddRange(new object[] {
            "Debrecen",
            "Budapest",
            "..."});
            this.birthPlace_input.Location = new System.Drawing.Point(165, 220);
            this.birthPlace_input.Name = "birthPlace_input";
            this.birthPlace_input.Size = new System.Drawing.Size(176, 33);
            this.birthPlace_input.TabIndex = 10;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(35, 267);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(306, 37);
            this.test_button.TabIndex = 11;
            this.test_button.Text = "Hiba keresés";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 328);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.birthPlace_input);
            this.Controls.Add(this.birthDate_input);
            this.Controls.Add(this.lang_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.id_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown id_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.ComboBox lang_input;
        private System.Windows.Forms.DateTimePicker birthDate_input;
        private System.Windows.Forms.ComboBox birthPlace_input;
        private System.Windows.Forms.Button test_button;
    }
}

