
namespace CorvinMoziApp {
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.button_left = new System.Windows.Forms.PictureBox();
            this.button_right = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_right)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(135, 196);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(182, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 1;
            // 
            // button_left
            // 
            this.button_left.BackgroundImage = global::CorvinMoziApp.Properties.Resources.balra;
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_left.Location = new System.Drawing.Point(125, 376);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(111, 65);
            this.button_left.TabIndex = 2;
            this.button_left.TabStop = false;
            this.button_left.Visible = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackgroundImage = global::CorvinMoziApp.Properties.Resources.jobbra;
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_right.Location = new System.Drawing.Point(480, 376);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(111, 65);
            this.button_right.TabIndex = 3;
            this.button_right.TabStop = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(245, 316);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(93, 43);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Mentés";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_stats
            // 
            this.button_stats.Location = new System.Drawing.Point(380, 316);
            this.button_stats.Name = "button_stats";
            this.button_stats.Size = new System.Drawing.Size(93, 43);
            this.button_stats.TabIndex = 5;
            this.button_stats.Text = "Statisztika";
            this.button_stats.UseVisualStyleBackColor = true;
            this.button_stats.Click += new System.EventHandler(this.button_stats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_stats);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Mozi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox button_left;
        private System.Windows.Forms.PictureBox button_right;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_stats;
    }
}

