using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HPTCMessageBox
{
    public partial class MSBox : Form
    {

        #region Static Variable & Properties

        private static int _borderthickness = 1;
        public static int BorderThickness
        {
            get
            {
                return _borderthickness;
            }
            set
            {
                _borderthickness = value;
            }
        }

        private static Size _msboxsize = new Size(461,230);
        public static Size MSBoxSize
        {
            get { return _msboxsize; }
            set { _msboxsize = value; }
        }
        

        private static FontFamily _msboxfontfamily = new FontFamily("Segoe UI Light");
        public static FontFamily FontFamily
        {
            get { return _msboxfontfamily; }
            set { _msboxfontfamily = value; }
        }



        private static Color _outlinecolor = Color.FromArgb(255, 192, 255, 192);
        public static Color OutlineColor
        {
            get { return _outlinecolor; }
            set { _outlinecolor = value; }
        }


        private static Color _textcolor = Color.White;
        public static Color TextColor
        {
            get { return _textcolor; }
            set { _textcolor = value; }
        }

        private static Color _textcolorinvert;
        public static Color TextColorInvert
        {
            get { return _textcolorinvert; }
            set { _textcolorinvert = value; }
        }
        

        private static Color _backgroundcolor = Color.FromArgb(255, 30, 30, 30);
        public static Color BackgroundColor
        {
            get { return _backgroundcolor; }
            set { _backgroundcolor = value; }
        }
        
        #endregion

        #region Enum Icon & Get Icon method
        public enum MSBoxIcon
        {
            Done,
            Edit,
            Error,
            Infomation,
            Like,
            Add,
            Password,
            Question,
            Setting,
            Update,
            Warning,
        }

        public static Image GetIconFromName(MSBoxIcon _iconname)
        {
            switch (_iconname)
            {
                case MSBoxIcon.Done:
                    return HPTCMessageBox.Properties.Resources.icon_done;
                case MSBoxIcon.Edit:
                    return HPTCMessageBox.Properties.Resources.icon_editting;
                case MSBoxIcon.Error:
                    return HPTCMessageBox.Properties.Resources.icon_error;
                case MSBoxIcon.Infomation:
                    return HPTCMessageBox.Properties.Resources.icon_infomation;
                case MSBoxIcon.Like:
                    return HPTCMessageBox.Properties.Resources.icon_like;
                case MSBoxIcon.Add:
                    return HPTCMessageBox.Properties.Resources.icon_new;
                case MSBoxIcon.Password:
                    return HPTCMessageBox.Properties.Resources.icon_password;
                case MSBoxIcon.Question:
                    return HPTCMessageBox.Properties.Resources.icon_question;
                case MSBoxIcon.Setting:
                    return HPTCMessageBox.Properties.Resources.icon_setting;
                case MSBoxIcon.Update:
                    return HPTCMessageBox.Properties.Resources.icon_updating;
                case MSBoxIcon.Warning:
                    return HPTCMessageBox.Properties.Resources.iconwarning;
                default:
                    return null;
            }
        }
        #endregion

        #region Variable
        private DialogResult dr = DialogResult.Abort;
        private Thread th1, th2;
        private int x, y;
        #endregion

        #region Constructor
        public MSBox(string _title, string _content, string _buttontext, MSBoxIcon _iconname)
        {
            InitializeComponent();
            lbltitle.Text = _title;
            lblcontent.Text = _content;
            border1.Width = border2.Width = border3.Height = border4.Height= _borderthickness;
            border2.Location = new Point(this.Width - border2.Width, 0);
            border4.Location = new Point(0, this.Height - border4.Height);

            switch (_buttontext.Split(';').Length)
            {
                case 1:
                    btn1.Text = _buttontext;
                    btn2.Visible = false;
                    btn3.Visible = false;
                    break;
                case 2:
                    btn1.Text = _buttontext.Split(';')[0];
                    btn2.Text = _buttontext.Split(';')[1];
                    btn3.Visible = false;
                    break;
                case 3:
                    btn1.Text = _buttontext.Split(';')[0];
                    btn2.Text = _buttontext.Split(';')[1];
                    btn3.Text = _buttontext.Split(';')[2];
                    break;
            }
            picicon.Image = GetIconFromName(_iconname);

            #region Set Default Properties
            this.Size = _msboxsize;
            // Border
            border1.BackColor = border2.BackColor = border3.BackColor = border4.BackColor = border5.BackColor = btn1.LineColorNormal = btn2.LineColorNormal = btn3.LineColorNormal = _outlinecolor;
            // Font
            lbltitle.Font = new Font(_msboxfontfamily, 15);
            lblcontent.Font = new Font(_msboxfontfamily, 12);
            btn1.Font = btn2.Font = btn3.Font = new Font(_msboxfontfamily, 9);
            // TextColor
            lblcontent.ForeColor = lbltitle.ForeColor = btn1.TextColorNormal = btn2.TextColorNormal = btn3.TextColorNormal = _textcolor;
            btn1.TextColorHover = btn2.TextColorHover = btn3.TextColorHover = _outlinecolor;
            btn1.TextColorClicked = btn2.TextColorClicked = btn3.TextColorClicked = _textcolorinvert;
            // background
            this.BackColor = btn1.BackgroundColorNormal = btn2.BackgroundColorNormal = btn3.BackgroundColorNormal = _backgroundcolor;
            btn1.BackgroundColorClicked = btn2.BackgroundColorClicked = btn3.BackgroundColorClicked = _outlinecolor;
            #endregion


        }
        #endregion

        #region ShowForm
        public DialogResult ShowOnScreen()
        {
            this.ShowDialog();
            return dr;
        }
        #endregion

        #region DialogResult Button
        private void btn3_Click(object sender, EventArgs e)
        {
            dr = System.Windows.Forms.DialogResult.Yes;
            th2 = new Thread(dec);
            th2.Start();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            dr = System.Windows.Forms.DialogResult.No;
            th2 = new Thread(dec);
            th2.Start();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            dr = System.Windows.Forms.DialogResult.Cancel;
            th2 = new Thread(dec);
            th2.Start();
        }
        #endregion

        #region FormLoaded
        private void MSBox_Load(object sender, EventArgs e)
        {
            th1 = new Thread(inc);
            th1.Start();
        }
        #endregion

        #region Effect & Delegate
        private void inc()
        {
            for (int i = 1; i <= 100; i = i + 2)
            {
                try
                {
                    this.UpdateOpacity(this, i);
                    Thread.Sleep(5);
                }
                catch
                {

                }
            }
        }

        private void dec()
        {
            for (int i = 100; i >= 1; i = i - 2)
            {
                try
                {
                    this.UpdateOpacity(this, i);
                    Thread.Sleep(5);
                }
                catch
                {

                }
            }
            ClsForm(this);
        }

        delegate void incdec(Form ctrl, int opacity);
        private void UpdateOpacity(Form ctrl, int opacity)
        {
            try
            {
                if (ctrl.InvokeRequired)
                {
                    incdec id = new incdec(UpdateOpacity);
                    ctrl.Invoke(id, ctrl, opacity);
                }
                else
                {
                    ctrl.Opacity = ((double)(opacity) / 100);
                }
            }
            catch { }
        }

        delegate void cls(Form ctrl);
        private void ClsForm(Form ctrl)
        {
            try
            {
                if (ctrl.InvokeRequired)
                {
                    cls cl = new cls(ClsForm);
                    ctrl.Invoke(cl, ctrl);
                }
                else
                {
                    ctrl.Close();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region FormMoving
        private void lbltitle_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void lbltitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                this.SetDesktopLocation(MousePosition.X - x - lbltitle.Location.X - Screen.PrimaryScreen.WorkingArea.X, MousePosition.Y - y - lbltitle.Location.Y - Screen.PrimaryScreen.WorkingArea.Y);
        } 
        #endregion


      
    }
}
