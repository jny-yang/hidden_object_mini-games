namespace final_project_11156204
{
    partial class elevator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elevator));
            this.showthefloor = new System.Windows.Forms.Label();
            this.firstfloor = new System.Windows.Forms.Button();
            this.basement1 = new System.Windows.Forms.Button();
            this.basement2 = new System.Windows.Forms.Button();
            this.secondfloor = new System.Windows.Forms.Button();
            this.thirdfloor = new System.Windows.Forms.Button();
            this.fourthfloor = new System.Windows.Forms.Button();
            this.fifthfloor = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goUp = new System.Windows.Forms.Timer(this.components);
            this.goDown = new System.Windows.Forms.Timer(this.components);
            this.basement3 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // showthefloor
            // 
            this.showthefloor.AutoSize = true;
            this.showthefloor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showthefloor.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showthefloor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showthefloor.Location = new System.Drawing.Point(521, 117);
            this.showthefloor.Name = "showthefloor";
            this.showthefloor.Size = new System.Drawing.Size(108, 76);
            this.showthefloor.TabIndex = 0;
            this.showthefloor.Text = "01";
            // 
            // firstfloor
            // 
            this.firstfloor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.firstfloor.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstfloor.Location = new System.Drawing.Point(900, 522);
            this.firstfloor.Name = "firstfloor";
            this.firstfloor.Size = new System.Drawing.Size(85, 62);
            this.firstfloor.TabIndex = 5;
            this.firstfloor.Tag = "1";
            this.firstfloor.Text = "01";
            this.firstfloor.UseVisualStyleBackColor = false;
            this.firstfloor.Click += new System.EventHandler(this.firstfloor_Click);
            // 
            // basement1
            // 
            this.basement1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.basement1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basement1.Location = new System.Drawing.Point(900, 590);
            this.basement1.Name = "basement1";
            this.basement1.Size = new System.Drawing.Size(85, 62);
            this.basement1.TabIndex = 6;
            this.basement1.Tag = "1";
            this.basement1.Text = "B1";
            this.basement1.UseVisualStyleBackColor = false;
            this.basement1.Click += new System.EventHandler(this.basement1_Click);
            // 
            // basement2
            // 
            this.basement2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.basement2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basement2.Location = new System.Drawing.Point(900, 658);
            this.basement2.Name = "basement2";
            this.basement2.Size = new System.Drawing.Size(85, 62);
            this.basement2.TabIndex = 7;
            this.basement2.Tag = "2";
            this.basement2.Text = "B2";
            this.basement2.UseVisualStyleBackColor = false;
            this.basement2.Click += new System.EventHandler(this.basement2_Click);
            // 
            // secondfloor
            // 
            this.secondfloor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.secondfloor.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondfloor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondfloor.Location = new System.Drawing.Point(900, 454);
            this.secondfloor.Name = "secondfloor";
            this.secondfloor.Size = new System.Drawing.Size(85, 62);
            this.secondfloor.TabIndex = 8;
            this.secondfloor.Tag = "2";
            this.secondfloor.Text = "02";
            this.secondfloor.UseVisualStyleBackColor = false;
            this.secondfloor.Click += new System.EventHandler(this.secondfloor_Click);
            // 
            // thirdfloor
            // 
            this.thirdfloor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thirdfloor.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdfloor.Location = new System.Drawing.Point(900, 386);
            this.thirdfloor.Name = "thirdfloor";
            this.thirdfloor.Size = new System.Drawing.Size(85, 62);
            this.thirdfloor.TabIndex = 9;
            this.thirdfloor.Tag = "3";
            this.thirdfloor.Text = "03";
            this.thirdfloor.UseVisualStyleBackColor = false;
            this.thirdfloor.Click += new System.EventHandler(this.thirdfloor_Click);
            // 
            // fourthfloor
            // 
            this.fourthfloor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fourthfloor.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthfloor.Location = new System.Drawing.Point(900, 318);
            this.fourthfloor.Name = "fourthfloor";
            this.fourthfloor.Size = new System.Drawing.Size(85, 62);
            this.fourthfloor.TabIndex = 10;
            this.fourthfloor.Tag = "4";
            this.fourthfloor.Text = "04";
            this.fourthfloor.UseVisualStyleBackColor = false;
            this.fourthfloor.Click += new System.EventHandler(this.fourthfloor_Click);
            // 
            // fifthfloor
            // 
            this.fifthfloor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fifthfloor.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthfloor.Location = new System.Drawing.Point(900, 250);
            this.fifthfloor.Name = "fifthfloor";
            this.fifthfloor.Size = new System.Drawing.Size(85, 62);
            this.fifthfloor.TabIndex = 11;
            this.fifthfloor.Tag = "5";
            this.fifthfloor.Text = "05";
            this.fifthfloor.UseVisualStyleBackColor = false;
            this.fifthfloor.Click += new System.EventHandler(this.fifthfloor_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Info;
            this.exit.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(177, 271);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 62);
            this.exit.TabIndex = 12;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(472, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(583, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(434, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Let\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(587, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(440, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 44);
            this.label3.TabIndex = 17;
            this.label3.Text = "w a l";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(579, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 44);
            this.label4.TabIndex = 18;
            this.label4.Text = "l y !";
            // 
            // goUp
            // 
            this.goUp.Interval = 1000;
            this.goUp.Tick += new System.EventHandler(this.goUp_Tick);
            // 
            // goDown
            // 
            this.goDown.Interval = 1000;
            this.goDown.Tick += new System.EventHandler(this.goDown_Tick);
            // 
            // basement3
            // 
            this.basement3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.basement3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basement3.Location = new System.Drawing.Point(900, 726);
            this.basement3.Name = "basement3";
            this.basement3.Size = new System.Drawing.Size(85, 62);
            this.basement3.TabIndex = 19;
            this.basement3.Tag = "3";
            this.basement3.Text = "B3";
            this.basement3.UseVisualStyleBackColor = false;
            this.basement3.Click += new System.EventHandler(this.basement3_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label.Location = new System.Drawing.Point(336, 224);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 37);
            this.label.TabIndex = 20;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1223, 894);
            this.Controls.Add(this.label);
            this.Controls.Add(this.basement3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.fifthfloor);
            this.Controls.Add(this.fourthfloor);
            this.Controls.Add(this.thirdfloor);
            this.Controls.Add(this.secondfloor);
            this.Controls.Add(this.basement2);
            this.Controls.Add(this.basement1);
            this.Controls.Add(this.firstfloor);
            this.Controls.Add(this.showthefloor);
            this.Name = "elevator";
            this.ShowIcon = false;
            this.Text = "elevator";
            this.Load += new System.EventHandler(this.elevator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showthefloor;
        private System.Windows.Forms.Button firstfloor;
        private System.Windows.Forms.Button basement1;
        private System.Windows.Forms.Button basement2;
        private System.Windows.Forms.Button secondfloor;
        private System.Windows.Forms.Button thirdfloor;
        private System.Windows.Forms.Button fourthfloor;
        private System.Windows.Forms.Button fifthfloor;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer goUp;
        private System.Windows.Forms.Timer goDown;
        private System.Windows.Forms.Button basement3;
        private System.Windows.Forms.Label label;
    }
}

