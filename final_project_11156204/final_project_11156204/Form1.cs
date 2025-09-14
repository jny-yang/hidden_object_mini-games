using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace final_project_11156204
{

    public partial class elevator : Form
    {
        public static elevator f1;
        public static int score = 0;
        int upTime = 1;
        int currentTime = 0;
        int downTime = 1;
        int target = 0;
        public static bool yes1 = true;
        public static bool yes2 = true;
        public static bool yes3 = true;
        public static bool yes4 = true;
        public static bool yes5 = true;
        public static bool yesB1 = true;
        public static bool yesB2 = true;
        public static bool yesB3 = true;

        public elevator()
        {
            InitializeComponent();
            f1 = this; //為了讓後面的其他form能夠存取這個form的elevator變數
        }

        private void elevator_Load(object sender, EventArgs e)
        {

        }

        private void firstfloor_Click(object sender, EventArgs e)
        {
            if (yes1)
            {
                currentTime = 1;
                target = 1;
                goUp.Start();
                firstfloor.ForeColor = Color.Gray;
                yes1 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }
        }

        private void secondfloor_Click(object sender, EventArgs e)
        {
            if (yes2)
            {
                currentTime = 2;
                target = 2;
                goUp.Start();
                secondfloor.ForeColor = Color.Gray;
                yes2 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }
        }

        private void thirdfloor_Click(object sender, EventArgs e)
        {
            if (yes3)
            {
                currentTime = 3;
                target = 3;
                goUp.Start();
                thirdfloor.ForeColor = Color.Gray;
                yes3 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }

        }

        private void fourthfloor_Click(object sender, EventArgs e)
        {
            if (yes4)
            {
                currentTime = 4;
                target = 4;
                goUp.Start();
                fourthfloor.ForeColor = Color.Gray;
                yes4 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }

        }

        private void fifthfloor_Click(object sender, EventArgs e)
        {
            if (yes5)
            {
                currentTime = 5;
                target = 5;
                goUp.Start();
                fifthfloor.ForeColor = Color.Gray;
                yes5 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }

        }

        private void basement1_Click(object sender, EventArgs e)
        {
            if (yesB1)
            {
                currentTime = 1;
                target = -1;
                goDown.Start();
                basement1.ForeColor = Color.Gray;
                yesB1 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }

        }

        private void basement2_Click(object sender, EventArgs e)
        {
            if (yesB2)
            {
                currentTime = 2;
                target = -2;
                goDown.Start();
                basement2.ForeColor = Color.Gray;
                yesB2 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }

        }

        private void basement3_Click(object sender, EventArgs e)
        {
            if (yesB3)
            {
                currentTime = 3;
                target = -3;
                goDown.Start();
                basement3.ForeColor = Color.Gray;
                yesB3 = false;
            }
            else
            {
                MessageBox.Show("這層樓已經去過了哦，快去其他層樓找找威利和他的朋友們吧！");
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("威力和他的朋友們還沒全部被找到，確定要離開嗎？");
            Environment.Exit(0);
        }

        private void goUp_Tick(object sender, EventArgs e)
        {
            showthefloor.Text = "0" + (upTime.ToString());
            upTime++;

            if (upTime == (currentTime + 2))
            {
                upTime = 1;
                currentTime = 0;
                goUp.Stop();
                showthefloor.Text = "01";
                openTheForm();
            }

        }

        private void goDown_Tick(object sender, EventArgs e)
        {

            showthefloor.Text = "B" + (downTime.ToString());
            downTime++;

            if (downTime == (currentTime + 2))
            {
                downTime = 1;
                currentTime = 0;
                goDown.Stop();
                showthefloor.Text = "01";
                openTheForm();
            }
        }

        void openTheForm()
        {
            if (target == 1)
            {
                Form6 first = new Form6();
                this.Visible = false;
                first.Visible = true;
            }
            if (target == 2)
            {
                Form2 second = new Form2();
                this.Visible = false;
                second.Visible = true;
            }
            if (target == 3)
            {
                Form3 third = new Form3();
                this.Visible = false;
                third.Visible = true;
            }
            if (target == 4)
            {
                Form4 fourth = new Form4();
                this.Visible = false;
                fourth.Visible = true;
            }
            if (target == 5)
            {
                Form5 fifth = new Form5();
                this.Visible = false;
                fifth.Visible = true;
            }
            if (target == -1)
            {
                Form7 seventh = new Form7();
                this.Visible = false;
                seventh.Visible = true;
            }
            if (target == -2)
            {
                Form9 ninth = new Form9();
                this.Visible = false;
                ninth.Visible = true;
            }
            if (target == -3)
            {
                Form8 eighth = new Form8();
                this.Visible = false;
                eighth.Visible = true;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            
        }

        public static void getFull()
        {
            f1.label.Text = "🎉恭喜完成任務🎉\n找到全部威力和他的朋友們(⁎⁍̴̛ᴗ⁍̴̛⁎)！";
        }

        public static void notGetFull()
        {
            f1.label.Text = "⛈️任務失敗⛈️\n沒有找到全部威力和他的朋友們ಥ_ಥ...";
        }
    }
}
