﻿namespace HPTCMessageBox
{
    partial class SimpleButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SimpleButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "SimpleButton";
            this.Size = new System.Drawing.Size(75, 23);
            this.Load += new System.EventHandler(this.SimpleButton_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SimpleButton_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SimpleButton_MouseDown);
            this.MouseLeave += new System.EventHandler(this.SimpleButton_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SimpleButton_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SimpleButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
