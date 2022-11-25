using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitNoti.Design
{
    public partial class UnderLineTextBox : UserControl
    {
        public UnderLineTextBox()
        {
            InitializeComponent();
        }
        [Category("BorderColor"), Description("색상을 선택합니다.")]
        public Color IsColor
        {
            get { return pictureBox1.BackColor; }
            set { pictureBox1.BackColor = value;}
        }
    }
}
