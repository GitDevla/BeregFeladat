
namespace Hazi_Etelek {
    partial class Create {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_types = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_isVegetarian = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_types);
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_edit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox_isVegetarian);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új étel";
            // 
            // comboBox_types
            // 
            this.comboBox_types.FormattingEnabled = true;
            this.comboBox_types.Location = new System.Drawing.Point(147, 97);
            this.comboBox_types.Name = "comboBox_types";
            this.comboBox_types.Size = new System.Drawing.Size(225, 32);
            this.comboBox_types.TabIndex = 11;
            // 
            // button_cancel
            // 
            this.button_cancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_cancel.Location = new System.Drawing.Point(20, 292);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(394, 29);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Mégse";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_edit
            // 
            this.button_edit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_edit.Location = new System.Drawing.Point(20, 237);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(394, 29);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Új";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ft";
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.Location = new System.Drawing.Point(148, 176);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_price.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_price.TabIndex = 7;
            this.numericUpDown_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_price.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ár:";
            // 
            // checkBox_isVegetarian
            // 
            this.checkBox_isVegetarian.AutoSize = true;
            this.checkBox_isVegetarian.Location = new System.Drawing.Point(148, 145);
            this.checkBox_isVegetarian.Name = "checkBox_isVegetarian";
            this.checkBox_isVegetarian.Size = new System.Drawing.Size(15, 14);
            this.checkBox_isVegetarian.TabIndex = 5;
            this.checkBox_isVegetarian.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vegetáriánus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategória:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(148, 58);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(224, 29);
            this.textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(434, 343);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Create";
            this.Text = "Create";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_types;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_isVegetarian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
    }
}