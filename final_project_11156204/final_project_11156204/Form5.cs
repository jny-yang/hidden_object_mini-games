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
    public partial class Form5 : Form
    {
        public static Form5 f5;
        int current = 0;
        bool x = true, y = true, z = true;

        public Form5()
        {
            InitializeComponent();
            f5 = this;
        }

        private void woof40_Click(object sender, EventArgs e)
        {

        }

        private void wanda50_Click(object sender, EventArgs e)
        {
            if (x == false)
            {
                notification.Text = "溫達已經被找過囉，\n快去找找其他朋友們吧！";
            }
            if (x == true)
            {
                elevator.score += 2;
                current += 2;
                x = false;
                notification.Text = "溫達已被找到，分數+2\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void WizardWhitebeard50_Click(object sender, EventArgs e)
        {
            if (y == false)
            {
                notification.Text = "白鬍子巫師已經被找過囉，\n快去找找其他朋友們吧！";
            }

            if (y == true)
            {
                elevator.score += 2;
                current += 2;
                y = false;
                notification.Text = "白鬍子巫師已被找到，分數+2\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void wally50_Click(object sender, EventArgs e)
        {
            if (z == false)
            {
                notification.Text = "威力已經被找過囉，\n快去找找其他朋友們吧！";
            }

            if (z == true)
            {
                elevator.score += 3;
                current += 3;
                z = false;
                notification.Text = "威力已被找到，分數+3\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            f5.Close();
            compare();
            elevator.f1.Visible = true;
        }

        void check()
        {
            if (current == 7)
            {
                MessageBox.Show("威力和他的朋友們已全部找到，請前往其他樓層繼續尋找吧！");
            }
        }

        void compare()
        {
            if (elevator.score == 65)
            {
                elevator.getFull();
            }
            if (elevator.yes1 == false && elevator.yes2 == false && elevator.yes3 == false && elevator.yes4 == false && elevator.yes5 == false && elevator.yesB1 == false && elevator.yesB2 == false && elevator.yesB3 == false)
            {
                if (elevator.score != 65)
                {
                    elevator.notGetFull();
                }
            }
        }
    }
}
