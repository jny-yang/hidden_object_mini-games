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
    public partial class Form6 : Form
    {
        public static Form6 f6;
        int current = 0;
        bool w = true, x = true, y = true, z = true;

        public Form6()
        {
            InitializeComponent();
            f6 = this;
        }

        private void woof10_Click(object sender, EventArgs e)
        {
            if (w == false)
            {
                notification.Text = "沃夫已經被找過囉，\n快去找找其他朋友們吧！";
            }

            if (w == true)
            {
                elevator.score += 2;
                current += 2;
                w = false;
                notification.Text = "沃夫已被找到，分數+2\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void WizardWhitebeard10_Click(object sender, EventArgs e)
        {
            if (x == false)
            {
                notification.Text = "白鬍子巫師已經被找過囉，\n快去找找其他朋友們吧！";
            }

            if (x == true)
            {
                elevator.score += 2;
                current += 2;
                x = false;
                notification.Text = "白鬍子巫師已被找到，分數+2\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void wally10_Click(object sender, EventArgs e)
        {
            if (y == false)
            {
                notification.Text = "威力已經被找過囉，\n快去找找其他朋友們吧！";
            }

            if (y == true)
            {
                elevator.score += 3;
                current += 3;
                y = false;
                notification.Text = "威力已被找到，分數+3\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void Odlaw10_Click(object sender, EventArgs e)
        {
            if (z == false)
            {
                notification.Text = "奧德已經被找過囉，\n快去找找其他朋友們吧！";
            }

            if (z == true)
            {
                elevator.score += 1;
                current += 1;
                z = false;
                notification.Text = "奧德已被找到，分數+1\n目前總分：" + (elevator.score).ToString();
                check();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            f6.Close();
            compare();
            elevator.f1.Visible = true;
        }

        void check()
        {
            if (current == 8)
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
