namespace HPTCMessageBox
{
    partial class MSBox
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.border3 = new System.Windows.Forms.PictureBox();
            this.border4 = new System.Windows.Forms.PictureBox();
            this.border1 = new System.Windows.Forms.PictureBox();
            this.border2 = new System.Windows.Forms.PictureBox();
            this.border5 = new System.Windows.Forms.PictureBox();
            this.picicon = new System.Windows.Forms.PictureBox();
            this.lblcontent = new System.Windows.Forms.Label();
            this.btn1 = new HPTCMessageBox.SimpleButton();
            this.btn2 = new HPTCMessageBox.SimpleButton();
            this.btn3 = new HPTCMessageBox.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.border3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(12, 5);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(437, 39);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Tiêu đề";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbltitle_MouseDown);
            this.lbltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbltitle_MouseMove);
            // 
            // border3
            // 
            this.border3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.border3.Location = new System.Drawing.Point(0, 0);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(461, 1);
            this.border3.TabIndex = 1;
            this.border3.TabStop = false;
            // 
            // border4
            // 
            this.border4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.border4.Location = new System.Drawing.Point(0, 229);
            this.border4.Name = "border4";
            this.border4.Size = new System.Drawing.Size(461, 1);
            this.border4.TabIndex = 2;
            this.border4.TabStop = false;
            // 
            // border1
            // 
            this.border1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.border1.Location = new System.Drawing.Point(0, 0);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(1, 230);
            this.border1.TabIndex = 3;
            this.border1.TabStop = false;
            // 
            // border2
            // 
            this.border2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.border2.Location = new System.Drawing.Point(460, 0);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(1, 230);
            this.border2.TabIndex = 4;
            this.border2.TabStop = false;
            // 
            // border5
            // 
            this.border5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.border5.Location = new System.Drawing.Point(100, 50);
            this.border5.Name = "border5";
            this.border5.Size = new System.Drawing.Size(261, 1);
            this.border5.TabIndex = 5;
            this.border5.TabStop = false;
            // 
            // picicon
            // 
            this.picicon.BackColor = System.Drawing.Color.Transparent;
            this.picicon.Image = global::HPTCMessageBox.Properties.Resources.icon_done;
            this.picicon.Location = new System.Drawing.Point(23, 71);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(100, 100);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picicon.TabIndex = 6;
            this.picicon.TabStop = false;
            // 
            // lblcontent
            // 
            this.lblcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcontent.BackColor = System.Drawing.Color.Transparent;
            this.lblcontent.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontent.Location = new System.Drawing.Point(129, 69);
            this.lblcontent.Name = "lblcontent";
            this.lblcontent.Size = new System.Drawing.Size(320, 109);
            this.lblcontent.TabIndex = 11;
            this.lblcontent.Text = "Nội dung thông báo";
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundColorClicked = System.Drawing.Color.Empty;
            this.btn1.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btn1.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImageClicked = null;
            this.btn1.BackgroundImageHover = null;
            this.btn1.BackgroundImageNormal = null;
            this.btn1.ButtonLayout = HPTCMessageBox.SimpleButton.BtnLayout.TextOnly;
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.ImageClicked = null;
            this.btn1.ImageHover = null;
            this.btn1.ImageNormal = null;
            this.btn1.LineColorClicked = System.Drawing.Color.Empty;
            this.btn1.LineColorHover = System.Drawing.Color.Empty;
            this.btn1.LineColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn1.LineLayout = HPTCMessageBox.SimpleButton.LinePostion.BottomLine;
            this.btn1.LineSize = 2;
            this.btn1.Location = new System.Drawing.Point(356, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Button 1";
            this.btn1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn1.TextColorClicked = System.Drawing.Color.Empty;
            this.btn1.TextColorHover = System.Drawing.Color.Empty;
            this.btn1.TextColorNormal = System.Drawing.Color.White;
            this.btn1.UsingBackgroundColorHoverClick = true;
            this.btn1.UsingBackgroundImageHoverClick = false;
            this.btn1.UsingImageHoverClick = false;
            this.btn1.UsingLineColorHoverClick = false;
            this.btn1.UsingTextColorHoverClick = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundColorClicked = System.Drawing.Color.Empty;
            this.btn2.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btn2.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImageClicked = null;
            this.btn2.BackgroundImageHover = null;
            this.btn2.BackgroundImageNormal = null;
            this.btn2.ButtonLayout = HPTCMessageBox.SimpleButton.BtnLayout.TextOnly;
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.ImageClicked = null;
            this.btn2.ImageHover = null;
            this.btn2.ImageNormal = null;
            this.btn2.LineColorClicked = System.Drawing.Color.Empty;
            this.btn2.LineColorHover = System.Drawing.Color.Empty;
            this.btn2.LineColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn2.LineLayout = HPTCMessageBox.SimpleButton.LinePostion.BottomLine;
            this.btn2.LineSize = 2;
            this.btn2.Location = new System.Drawing.Point(257, 195);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Button 2";
            this.btn2.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn2.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn2.TextColorClicked = System.Drawing.Color.Empty;
            this.btn2.TextColorHover = System.Drawing.Color.Empty;
            this.btn2.TextColorNormal = System.Drawing.Color.White;
            this.btn2.UsingBackgroundColorHoverClick = true;
            this.btn2.UsingBackgroundImageHoverClick = false;
            this.btn2.UsingImageHoverClick = false;
            this.btn2.UsingLineColorHoverClick = false;
            this.btn2.UsingTextColorHoverClick = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundColorClicked = System.Drawing.Color.Empty;
            this.btn3.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btn3.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImageClicked = null;
            this.btn3.BackgroundImageHover = null;
            this.btn3.BackgroundImageNormal = null;
            this.btn3.ButtonLayout = HPTCMessageBox.SimpleButton.BtnLayout.TextOnly;
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.ImageClicked = null;
            this.btn3.ImageHover = null;
            this.btn3.ImageNormal = null;
            this.btn3.LineColorClicked = System.Drawing.Color.Empty;
            this.btn3.LineColorHover = System.Drawing.Color.Empty;
            this.btn3.LineColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn3.LineLayout = HPTCMessageBox.SimpleButton.LinePostion.BottomLine;
            this.btn3.LineSize = 2;
            this.btn3.Location = new System.Drawing.Point(158, 195);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 23);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Button 3";
            this.btn3.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn3.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn3.TextColorClicked = System.Drawing.Color.Empty;
            this.btn3.TextColorHover = System.Drawing.Color.Empty;
            this.btn3.TextColorNormal = System.Drawing.Color.White;
            this.btn3.UsingBackgroundColorHoverClick = true;
            this.btn3.UsingBackgroundImageHoverClick = false;
            this.btn3.UsingImageHoverClick = false;
            this.btn3.UsingLineColorHoverClick = false;
            this.btn3.UsingTextColorHoverClick = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // MSBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(461, 230);
            this.Controls.Add(this.lblcontent);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.border5);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.border4);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông báo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MSBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.border3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox border3;
        private System.Windows.Forms.PictureBox border4;
        private System.Windows.Forms.PictureBox border1;
        private System.Windows.Forms.PictureBox border2;
        private System.Windows.Forms.PictureBox border5;
        private System.Windows.Forms.PictureBox picicon;
        private SimpleButton btn3;
        private SimpleButton btn2;
        private SimpleButton btn1;
        private System.Windows.Forms.Label lblcontent;
    }
}