namespace DiWinForms
{
    using System;
    using System.Windows.Forms;

    partial class BaseForm
    {
        private Button _btnGraphics;
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Base Form";

            this._btnGraphics = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // lblTanks
            // 
            this._btnGraphics.AutoSize = true;
            this._btnGraphics.Location = new System.Drawing.Point(22, 27);
            this._btnGraphics.Name = "_btnGraphics";
            this._btnGraphics.Size = new System.Drawing.Size(200, 200);
            this._btnGraphics.TabIndex = 0;
            this._btnGraphics.Text = "Show Graphics";
            this._btnGraphics.Click += BtnGraphicsOnClick;

            this.Controls.Add(this._btnGraphics);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        

        #endregion
    }
}

