namespace LakoparkProjekt
{
    partial class MainForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(190, 44);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 1;
            // 
            // pictureBox_left
            // 
            this.pictureBox_left.Image = global::LakoparkProjekt.Properties.Resources.balnyil;
            this.pictureBox_left.Location = new System.Drawing.Point(258, 350);
            this.pictureBox_left.Name = "pictureBox_left";
            this.pictureBox_left.Size = new System.Drawing.Size(85, 59);
            this.pictureBox_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_left.TabIndex = 3;
            this.pictureBox_left.TabStop = false;
            this.pictureBox_left.Visible = false;
            this.pictureBox_left.Click += new System.EventHandler(this.pictureBox_left_Click);
            // 
            // pictureBox_right
            // 
            this.pictureBox_right.Image = global::LakoparkProjekt.Properties.Resources.jobbnyil;
            this.pictureBox_right.Location = new System.Drawing.Point(400, 350);
            this.pictureBox_right.Name = "pictureBox_right";
            this.pictureBox_right.Size = new System.Drawing.Size(91, 62);
            this.pictureBox_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_right.TabIndex = 2;
            this.pictureBox_right.TabStop = false;
            this.pictureBox_right.Click += new System.EventHandler(this.pictureBox_right_Click);
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Location = new System.Drawing.Point(40, 44);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(100, 121);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_img.TabIndex = 0;
            this.pictureBox_img.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(268, 418);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Mentés";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_stats
            // 
            this.button_stats.Location = new System.Drawing.Point(400, 418);
            this.button_stats.Name = "button_stats";
            this.button_stats.Size = new System.Drawing.Size(75, 23);
            this.button_stats.TabIndex = 5;
            this.button_stats.Text = "Statisztikák";
            this.button_stats.UseVisualStyleBackColor = true;
            this.button_stats.Click += new System.EventHandler(this.button_stats_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_stats);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.pictureBox_left);
            this.Controls.Add(this.pictureBox_right);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox_img);
            this.Name = "MainForm";
            this.Text = "Lakópark";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_img;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox_right;
        private System.Windows.Forms.PictureBox pictureBox_left;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_stats;
    }
}

