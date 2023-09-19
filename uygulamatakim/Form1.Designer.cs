namespace uygulamatakim
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
            this.btnHilal = new System.Windows.Forms.Button();
            this.btnRavza = new System.Windows.Forms.Button();
            this.btnBuse = new System.Windows.Forms.Button();
            this.btnNur = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHilal
            // 
            this.btnHilal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHilal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHilal.Location = new System.Drawing.Point(69, 28);
            this.btnHilal.Name = "btnHilal";
            this.btnHilal.Size = new System.Drawing.Size(128, 106);
            this.btnHilal.TabIndex = 0;
            this.btnHilal.Text = "Hilal De Souza";
            this.btnHilal.UseVisualStyleBackColor = false;
            this.btnHilal.Click += new System.EventHandler(this.btnHilal_Click);
            // 
            // btnRavza
            // 
            this.btnRavza.BackColor = System.Drawing.Color.Red;
            this.btnRavza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRavza.Location = new System.Drawing.Point(69, 252);
            this.btnRavza.Name = "btnRavza";
            this.btnRavza.Size = new System.Drawing.Size(128, 106);
            this.btnRavza.TabIndex = 1;
            this.btnRavza.Text = "Ravza Muslera";
            this.btnRavza.UseVisualStyleBackColor = false;
            this.btnRavza.Click += new System.EventHandler(this.btnRavza_Click);
            // 
            // btnBuse
            // 
            this.btnBuse.BackColor = System.Drawing.Color.Beige;
            this.btnBuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuse.Location = new System.Drawing.Point(69, 140);
            this.btnBuse.Name = "btnBuse";
            this.btnBuse.Size = new System.Drawing.Size(128, 106);
            this.btnBuse.TabIndex = 2;
            this.btnBuse.Text = "Buse Turan";
            this.btnBuse.UseVisualStyleBackColor = false;
            this.btnBuse.Click += new System.EventHandler(this.btnBuse_Click);
            // 
            // btnNur
            // 
            this.btnNur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNur.Location = new System.Drawing.Point(69, 364);
            this.btnNur.Name = "btnNur";
            this.btnNur.Size = new System.Drawing.Size(128, 106);
            this.btnNur.TabIndex = 3;
            this.btnNur.Text = "Nur Quaresma";
            this.btnNur.UseVisualStyleBackColor = false;
            this.btnNur.Click += new System.EventHandler(this.btnNur_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(449, 233);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 31);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnNur);
            this.Controls.Add(this.btnBuse);
            this.Controls.Add(this.btnRavza);
            this.Controls.Add(this.btnHilal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHilal;
        private System.Windows.Forms.Button btnRavza;
        private System.Windows.Forms.Button btnBuse;
        private System.Windows.Forms.Button btnNur;
        private System.Windows.Forms.Label lblAd;
    }
}

