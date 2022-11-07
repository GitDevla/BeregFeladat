
namespace atletikaGUI {
    partial class Window {
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_nations = new System.Windows.Forms.ListBox();
            this.button_nations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_events = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_nation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranyérmet Szerzett Nemzetek:";
            // 
            // listBox_nations
            // 
            this.listBox_nations.FormattingEnabled = true;
            this.listBox_nations.ItemHeight = 18;
            this.listBox_nations.Location = new System.Drawing.Point(33, 54);
            this.listBox_nations.Name = "listBox_nations";
            this.listBox_nations.Size = new System.Drawing.Size(268, 508);
            this.listBox_nations.TabIndex = 1;
            // 
            // button_nations
            // 
            this.button_nations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_nations.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_nations.FlatAppearance.BorderSize = 2;
            this.button_nations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nations.Location = new System.Drawing.Point(52, 588);
            this.button_nations.Name = "button_nations";
            this.button_nations.Size = new System.Drawing.Size(232, 40);
            this.button_nations.TabIndex = 2;
            this.button_nations.Text = "aranyos - nemzetek";
            this.button_nations.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Válasza ki a versenyszámot:";
            // 
            // listBox_events
            // 
            this.listBox_events.FormattingEnabled = true;
            this.listBox_events.ItemHeight = 18;
            this.listBox_events.Location = new System.Drawing.Point(349, 54);
            this.listBox_events.Name = "listBox_events";
            this.listBox_events.Size = new System.Drawing.Size(241, 76);
            this.listBox_events.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Válassza ki az érmes helyezést:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(349, 191);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 27);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_search.Location = new System.Drawing.Point(404, 320);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(151, 44);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Keresés";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Versenyző adatai:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 434);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "neve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 465);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "eredménye:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 501);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "nemzete:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(461, 434);
            this.label_name.Name = "label_name";
            this.label_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_name.Size = new System.Drawing.Size(0, 18);
            this.label_name.TabIndex = 12;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(461, 465);
            this.label_score.Name = "label_score";
            this.label_score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_score.Size = new System.Drawing.Size(0, 18);
            this.label_score.TabIndex = 13;
            // 
            // label_nation
            // 
            this.label_nation.AutoSize = true;
            this.label_nation.Location = new System.Drawing.Point(461, 501);
            this.label_nation.Name = "label_nation";
            this.label_nation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_nation.Size = new System.Drawing.Size(0, 18);
            this.label_nation.TabIndex = 14;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(992, 669);
            this.Controls.Add(this.label_nation);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_events);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_nations);
            this.Controls.Add(this.listBox_nations);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Window";
            this.Text = "Atlétika";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_nations;
        private System.Windows.Forms.Button button_nations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_events;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_nation;
    }
}

