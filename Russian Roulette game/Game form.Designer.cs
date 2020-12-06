namespace Russian_Roulette_game
{
    partial class Gunshotform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gunshotform));
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.Play_Again = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(12, 12);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(674, 361);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.btnpicturebox);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(-6, 456);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(167, 78);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // Spin
            // 
            this.Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.Location = new System.Drawing.Point(183, 456);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(167, 78);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.buttonspin_Click);
            // 
            // Shoot
            // 
            this.Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot.Location = new System.Drawing.Point(407, 456);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(167, 80);
            this.Shoot.TabIndex = 3;
            this.Shoot.Text = "Shoot";
            this.Shoot.UseVisualStyleBackColor = true;
            this.Shoot.Click += new System.EventHandler(this.buttonshoot_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.Location = new System.Drawing.Point(604, 456);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(167, 80);
            this.ShootAway.TabIndex = 4;
            this.ShootAway.Text = "Shoot Away";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.buttonshootaway_Click);
            // 
            // Play_Again
            // 
            this.Play_Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Again.Location = new System.Drawing.Point(729, 340);
            this.Play_Again.Name = "Play_Again";
            this.Play_Again.Size = new System.Drawing.Size(175, 70);
            this.Play_Again.TabIndex = 5;
            this.Play_Again.Text = "Play Again";
            this.Play_Again.UseVisualStyleBackColor = true;
            this.Play_Again.Click += new System.EventHandler(this.buttonplayagain_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(729, 210);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(175, 74);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.Location = new System.Drawing.Point(729, 100);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(175, 71);
            this.Rules.TabIndex = 7;
            this.Rules.Text = "Rules";
            this.Rules.UseVisualStyleBackColor = true;
            this.Rules.Click += new System.EventHandler(this.btn_Rules);
            // 
            // Gunshotform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 538);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play_Again);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.picturebox);
            this.Name = "Gunshotform";
            this.Text = "Gunshotform";
            //this.Load += new System.EventHandler(this.Gunshotform_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.Button Play_Again;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Rules;
    }
}

