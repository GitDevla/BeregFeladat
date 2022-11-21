namespace Hazi_Szamla
{
    partial class window
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
            this.listBox_checks = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_balance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_checks
            // 
            this.listBox_checks.BackColor = System.Drawing.Color.Gray;
            this.listBox_checks.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_checks.FormattingEnabled = true;
            this.listBox_checks.ItemHeight = 25;
            this.listBox_checks.Location = new System.Drawing.Point(0, 0);
            this.listBox_checks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_checks.Name = "listBox_checks";
            this.listBox_checks.Size = new System.Drawing.Size(208, 457);
            this.listBox_checks.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button_delete);
            this.groupBox.Controls.Add(this.button_update);
            this.groupBox.Controls.Add(this.button_create);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.dateTimePicker_date);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.numericUpDown_balance);
            this.groupBox.Controls.Add(this.textBox_name);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.textBox_id);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(208, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(471, 457);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Számla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(148, 41);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(58, 31);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(148, 93);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(187, 31);
            this.textBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // numericUpDown_balance
            // 
            this.numericUpDown_balance.Location = new System.Drawing.Point(148, 139);
            this.numericUpDown_balance.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_balance.Name = "numericUpDown_balance";
            this.numericUpDown_balance.Size = new System.Drawing.Size(187, 31);
            this.numericUpDown_balance.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Egyenleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dátum:";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(148, 189);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(224, 31);
            this.dateTimePicker_date.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ft";
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.DimGray;
            this.button_create.Location = new System.Drawing.Point(29, 255);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(417, 51);
            this.button_create.TabIndex = 9;
            this.button_create.Text = "Új számla készitése";
            this.button_create.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DimGray;
            this.button_update.Location = new System.Drawing.Point(29, 312);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(417, 51);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Számla módositása";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DimGray;
            this.button_delete.Location = new System.Drawing.Point(29, 369);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(417, 51);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Számla törlése";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(679, 457);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listBox_checks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "window";
            this.Text = "Számlák";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_checks;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_balance;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
    }
}

