
namespace Hazi_Lotto {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_bet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_winnerNums = new System.Windows.Forms.Label();
            this.label_playedNums = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_wonNums = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 301);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // button_bet
            // 
            this.button_bet.Image = global::Hazi_Lotto.Properties.Resources.shamrock;
            this.button_bet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bet.Location = new System.Drawing.Point(176, 368);
            this.button_bet.Name = "button_bet";
            this.button_bet.Size = new System.Drawing.Size(81, 45);
            this.button_bet.TabIndex = 1;
            this.button_bet.Text = "Sorsolás";
            this.button_bet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bet.UseVisualStyleBackColor = true;
            this.button_bet.Click += new System.EventHandler(this.button_bet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(398, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nyerőszámok ->";
            // 
            // label_winnerNums
            // 
            this.label_winnerNums.AutoSize = true;
            this.label_winnerNums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_winnerNums.Location = new System.Drawing.Point(487, 359);
            this.label_winnerNums.Name = "label_winnerNums";
            this.label_winnerNums.Size = new System.Drawing.Size(0, 13);
            this.label_winnerNums.TabIndex = 3;
            // 
            // label_playedNums
            // 
            this.label_playedNums.AutoSize = true;
            this.label_playedNums.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_playedNums.Location = new System.Drawing.Point(487, 386);
            this.label_playedNums.Name = "label_playedNums";
            this.label_playedNums.Size = new System.Drawing.Size(0, 13);
            this.label_playedNums.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(398, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Megjátszott ->";
            // 
            // label_wonNums
            // 
            this.label_wonNums.AutoSize = true;
            this.label_wonNums.ForeColor = System.Drawing.Color.Red;
            this.label_wonNums.Location = new System.Drawing.Point(487, 411);
            this.label_wonNums.Name = "label_wonNums";
            this.label_wonNums.Size = new System.Drawing.Size(0, 13);
            this.label_wonNums.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(398, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Találat ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_wonNums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_playedNums);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_winnerNums);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_bet);
            this.Controls.Add(this.flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lottósorsolás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button_bet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_winnerNums;
        private System.Windows.Forms.Label label_playedNums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_wonNums;
        private System.Windows.Forms.Label label4;
    }
}

