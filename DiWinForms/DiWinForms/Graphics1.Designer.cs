namespace DiWinForms
{
    partial class Graphics1
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
            this._lblTanks = new System.Windows.Forms.Label();
            this._lblPumps = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblTanks
            // 
            this._lblTanks.AutoSize = true;
            this._lblTanks.Location = new System.Drawing.Point(22, 27);
            this._lblTanks.Name = "_lblTanks";
            this._lblTanks.Size = new System.Drawing.Size(59, 17);
            this._lblTanks.TabIndex = 0;
            this._lblTanks.Text = "Tanks : ";
            // 
            // _lblPumps
            // 
            this._lblPumps.AutoSize = true;
            this._lblPumps.Location = new System.Drawing.Point(22, 61);
            this._lblPumps.Name = "_lblPumps";
            this._lblPumps.Size = new System.Drawing.Size(63, 17);
            this._lblPumps.TabIndex = 1;
            this._lblPumps.Text = "Pumps : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Graphics1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._lblPumps);
            this.Controls.Add(this._lblTanks);
            this.Name = "Graphics1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTanks;
        private System.Windows.Forms.Label _lblPumps;
        private System.Windows.Forms.Button button1;
    }
}

