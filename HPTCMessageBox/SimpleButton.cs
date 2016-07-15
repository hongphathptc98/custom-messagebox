using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HPTCMessageBox
{
    [DefaultEvent("Click")]
    public partial class SimpleButton : UserControl
    {

        public SimpleButton()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }



        private Image BckImgNor;
        private Image BckImgHov;
        private Image BckImgClk;
        private bool UsgBckImgHovClk = false;

        private Color BckClrNor = Color.Black;
        private Color BckClrHov;
        private Color BckClrClk;
        private bool UsgBckClrHovClk = false;

        private int LnSize = 2;
        private Color LnClrNor;
        private Color LnClrHov;
        private Color LnClrClk;
        private Color LnClr;
        public enum LinePostion
        {
            TopLine,
            BottomLine,
            LeftLine,
            RightLine,
            None,
        }
        private LinePostion LnLayout = LinePostion.BottomLine;
        private bool UsgLnClrHovClk = false;

        private string t = "simpleButton";
        private Color txtClrNor = Color.White;
        private Color txtClrHov;
        private Color txtClrClk;
        private Color txtClr;
        private StringAlignment txtAlmVer = StringAlignment.Center;
        private StringAlignment txtAlmHor = StringAlignment.Center;
        private bool UsgTxtHovClk = false;

        private Image ImgNor = null;
        private Image ImgHov;
        private Image ImgClk;
        private Image Img;
        public enum BtnLayout
        {
            LeftOfText,
            RightOfText,
            TextOnly,
            ImageOnly,
        }
        private BtnLayout btnLayout = BtnLayout.TextOnly;
        private bool UsgImgHovClk = false;

        public Image BackgroundImageNormal
        {
            get
            {
                return BckImgNor;
            }
            set
            {
                BckImgNor = value;
            }
        }
        public Image BackgroundImageHover
        {
            get
            {
                return BckImgHov;
            }
            set
            {
                BckImgHov = value;
            }
        }
        public Image BackgroundImageClicked
        {
            get
            {
                return BckImgClk;
            }
            set
            {
                BckImgClk = value;
            }
        }

        public Color BackgroundColorNormal
        {
            get
            {
                return BckClrNor;
            }
            set
            {
                BckClrNor = value;
            }
        }
        public Color BackgroundColorHover
        {
            get
            {
                return BckClrHov;
            }
            set
            {
                BckClrHov = value;
            }
        }
        public Color BackgroundColorClicked
        {
            get
            {
                return BckClrClk;
            }
            set
            {
                BckClrClk = value;
            }
        }

        public int LineSize
        {
            get
            {
                return LnSize;
            }
            set
            {
                LnSize = value;
            }
        }
        public Color LineColorNormal
        {
            get
            {
                return LnClrNor;
            }
            set
            {
                LnClrNor = value;
            }
        }
        public Color LineColorHover
        {
            get
            {
                return LnClrHov;
            }
            set
            {
                LnClrHov = value;
            }
        }
        public Color LineColorClicked
        {
            get
            {
                return LnClrClk;
            }
            set
            {
                LnClrClk = value;
            }
        }
        public LinePostion LineLayout
        {
            get
            {
                return LnLayout;
            }
            set
            {
                LnLayout = value;
            }
        }

     

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
            }
        }
        public Color TextColorNormal
        {
            get
            {
                return txtClrNor;
            }
            set
            {
                txtClrNor = value;
            }
        }
        public Color TextColorHover
        {
            get
            {
                return txtClrHov;
            }
            set
            {
                txtClrHov = value;
            }
        }
        public Color TextColorClicked
        {
            get
            {
                return txtClrClk;
            }
            set
            {
                txtClrClk = value;
            }
        }
        public StringAlignment TextAlignmentVertical
        {
            get
            {
                return txtAlmVer;
            }
            set
            {
                txtAlmVer = value;
            }
        }
        public StringAlignment TextAlignmentHorizontal
        {
            get
            {
                return txtAlmHor;
            }
            set
            {
                txtAlmHor = value;
            }
        }

        public Image ImageNormal
        {
            get
            {
                return ImgNor;
            }
            set
            {
                ImgNor = value;
            }
        }
        public Image ImageHover
        {
            get
            {
                return ImgHov;
            }
            set
            {
                ImgHov = value;
            }
        }
        public Image ImageClicked
        {
            get
            {
                return ImgClk;
            }
            set
            {
                ImgClk = value;
            }
        }
        public BtnLayout ButtonLayout
        {
            get
            {
                return btnLayout;
            }
            set
            {
                btnLayout = value;
            }
        }

        public bool UsingBackgroundImageHoverClick
        {
            get
            {
                return UsgBckImgHovClk;
            }
            set
            {
                UsgBckImgHovClk = value;
            }
        }
        public bool UsingBackgroundColorHoverClick
        {
            get
            {
                return UsgBckClrHovClk;
            }
            set
            {
                UsgBckClrHovClk = value;
            }
        }
        public bool UsingLineColorHoverClick
        {
            get
            {
                return UsgLnClrHovClk;
            }
            set
            {
                UsgLnClrHovClk = value;
            }
        }
        public bool UsingTextColorHoverClick
        {
            get
            {
                return UsgTxtHovClk;
            }
            set
            {
                UsgTxtHovClk = value;
            }
        }
        public bool UsingImageHoverClick
        {
            get
            {
                return UsgImgHovClk;
            }
            set
            {
                UsgImgHovClk = value;
            }
        }

        private void SimpleButton_Paint(object sender, PaintEventArgs e)
        {

            switch (LnLayout)
            {
                case LinePostion.BottomLine:
                    e.Graphics.FillRectangle(new SolidBrush(LnClr), new Rectangle(0, this.Height - LnSize, this.Width, LnSize));
                    switch (btnLayout)
                    {
                        case BtnLayout.ImageOnly:
                            e.Graphics.DrawImage(Img, new Rectangle(0, 0, this.Width, this.Height - LnSize));
                            break;
                        case BtnLayout.TextOnly:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width, this.Height - LnSize), strFM);
                            }
                            break;
                        case BtnLayout.LeftOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(0, 0, this.Height - LnSize, this.Height - LnSize));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(this.Height - LnSize, 0, this.Width - this.Height + LnSize, this.Height - LnSize), strFM);
                            }
                            break;
                        case BtnLayout.RightOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(this.Width - this.Height + LnSize, 0, this.Height - LnSize, this.Height - LnSize));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - this.Height + LnSize, this.Height - LnSize), strFM);
                            }
                            break;
                    }
                    break;
                case LinePostion.TopLine:
                    e.Graphics.FillRectangle(new SolidBrush(LnClr), new Rectangle(0, 0, this.Width, LnSize));
                    switch (btnLayout)
                    {
                        case BtnLayout.ImageOnly:
                            e.Graphics.DrawImage(Img, new Rectangle(0, LnSize, this.Width, this.Height - LnSize));
                            break;
                        case BtnLayout.TextOnly:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, LnSize, this.Width, this.Height - LnSize), strFM);
                            }
                            break;
                        case BtnLayout.LeftOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(0, LnSize, this.Height - LnSize, this.Height - LnSize));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(this.Height - LnSize, LnSize, this.Width - this.Height + LnSize, this.Height - LnSize), strFM);
                            }
                            break;
                        case BtnLayout.RightOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(this.Width - this.Height + LnSize, LnSize, this.Height - LnSize, this.Height - LnSize));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, LnSize, this.Width - this.Height + LnSize, this.Height - LnSize), strFM);
                            }
                            break;
                    }
                    break;
                case LinePostion.LeftLine:
                    e.Graphics.FillRectangle(new SolidBrush(LnClr), new Rectangle(0, 0, LnSize, this.Height));
                    switch (btnLayout)
                    {
                        case BtnLayout.ImageOnly:
                            e.Graphics.DrawImage(Img, new Rectangle(LnSize, 0, this.Width - LnSize, this.Height));
                            break;
                        case BtnLayout.TextOnly:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(LnSize, 0, this.Width - LnSize, this.Height), strFM);
                            }
                            break;
                        case BtnLayout.LeftOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(LnSize, 0, this.Height, this.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(this.Height + LnSize, 0, this.Width - this.Height - LnSize, this.Height), strFM);
                            }
                            break;
                        case BtnLayout.RightOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(this.Width - this.Height, 0, this.Height, this.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(LnSize, 0, this.Width - this.Height - LnSize, this.Height), strFM);
                            }
                            break;
                    }
                    break;
                case LinePostion.RightLine:
                    e.Graphics.FillRectangle(new SolidBrush(LnClr), new Rectangle(this.Width - LnSize, 0, LnSize, this.Height));
                    switch (btnLayout)
                    {
                        case BtnLayout.ImageOnly:
                            e.Graphics.DrawImage(Img, new Rectangle(0, 0, this.Width - LnSize, this.Height));
                            break;
                        case BtnLayout.TextOnly:

                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - LnSize, this.Height), strFM);
                            }
                            break;
                        case BtnLayout.LeftOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(0, 0, this.Height, this.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(this.Height, 0, this.Width - this.Height - LnSize, this.Height), strFM);
                            }
                            break;
                        case BtnLayout.RightOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(this.Width - this.Height - LnSize, 0, this.Height, this.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - this.Height - LnSize, this.Height), strFM);
                            }
                            break;
                    }
                    break;
                case LinePostion.None:
                    switch (btnLayout)
                    {
                        case BtnLayout.ImageOnly:
                            e.Graphics.DrawImage(Img, new Rectangle(0, 0, this.Width, this.Height));
                            break;
                        case BtnLayout.TextOnly:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width, this.Height), strFM);
                            }
                            break;
                        case BtnLayout.LeftOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(0, 0, this.Height, this.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(this.Height, 0, this.Width - this.Height, this.Height), strFM);
                            }
                            break;
                        case BtnLayout.RightOfText:
                            e.Graphics.DrawImage(Img, new Rectangle(this.Width - this.Height, 0, this.Height, this.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlmHor;
                                strFM.LineAlignment = txtAlmVer;
                                e.Graphics.DrawString(t, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - this.Height, this.Height), strFM);
                            }
                            break;
                    }
                    break;
            }
        }

        bool isMove = false;
        bool isClicked = false;

        private void SimpleButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (isClicked == false)
                {
                    isClicked = true;
                    if (UsgBckImgHovClk == true)
                    {
                        this.BackgroundImage = BckImgClk;
                    }
                    if (UsgBckClrHovClk == true)
                    {
                        this.BackColor = BckClrClk;
                    }
                    if (UsgLnClrHovClk == true)
                    {
                        LnClr = LnClrClk;
                    }
                    if (UsgTxtHovClk == true)
                    {
                        txtClr = txtClrClk;
                    }
                    if (UsgImgHovClk == true)
                    {
                        Img = ImgClk;
                    }
                    Invalidate();
                }
            }
            else
            {
                if (isMove == false)
                {
                    isMove = true;
                    if (UsgBckImgHovClk == true)
                    {
                        this.BackgroundImage = BckImgHov;
                    }
                    if (UsgBckClrHovClk == true)
                    {
                        this.BackColor = BckClrHov;
                    }
                    if (UsgLnClrHovClk == true)
                    {
                        LnClr = LnClrHov;
                    }
                    if (UsgTxtHovClk == true)
                    {
                        txtClr = txtClrHov;
                    }
                    if (UsgImgHovClk == true)
                    {
                        Img = ImgHov;
                    }
                    Invalidate();
                }
            }
        }

        private void SimpleButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = BckImgNor;
            this.BackColor = BckClrNor;
            LnClr = LnClrNor;
            txtClr = txtClrNor;
            Img = ImgNor;
            isMove = false;
            isClicked = false;
            Invalidate();
        }



        private void SimpleButton_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = BckImgNor;
            this.BackColor = BckClrNor;
            LnClr = LnClrNor;
            txtClr = txtClrNor;
            Img = ImgNor;
        }

        private void SimpleButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = BckImgNor;
            this.BackColor = BckClrNor;
            LnClr = LnClrNor;
            txtClr = txtClrNor;
            Img = ImgNor;
            isMove = false;
            isClicked = false;
            Invalidate();
        }

        private void SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (UsgBckImgHovClk == true)
            {
                this.BackgroundImage = BckImgClk;
            }
            if (UsgBckClrHovClk == true)
            {
                this.BackColor = BckClrClk;
            }
            if (UsgLnClrHovClk == true)
            {
                LnClr = LnClrClk;
            }
            if (UsgTxtHovClk == true)
            {
                txtClr = txtClrClk;
            }
            if (UsgImgHovClk == true)
            {
                Img = ImgClk;
            }
            Invalidate();
        }
    }
}