namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RockBtn = new Button();
            PaperBtn = new Button();
            ScissorsBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            UserPointTxt = new TextBox();
            ComputerPointTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            UserChoicePicBox = new PictureBox();
            ComputerChoicePicBox = new PictureBox();
            ResultLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)UserChoicePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComputerChoicePicBox).BeginInit();
            SuspendLayout();
            // 
            // RockBtn
            // 
            RockBtn.BackgroundImage = Properties.Resources.Rock;
            RockBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RockBtn.Location = new Point(276, 177);
            RockBtn.Name = "RockBtn";
            RockBtn.Size = new Size(79, 73);
            RockBtn.TabIndex = 0;
            RockBtn.UseVisualStyleBackColor = true;
            RockBtn.Click += RockBtn_Click;
            // 
            // PaperBtn
            // 
            PaperBtn.BackgroundImage = Properties.Resources.Paper;
            PaperBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PaperBtn.Location = new Point(159, 177);
            PaperBtn.Name = "PaperBtn";
            PaperBtn.Size = new Size(79, 73);
            PaperBtn.TabIndex = 1;
            PaperBtn.UseVisualStyleBackColor = true;
            PaperBtn.Click += PaperBtn_Click;
            // 
            // ScissorsBtn
            // 
            ScissorsBtn.BackgroundImage = Properties.Resources.Scissors;
            ScissorsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ScissorsBtn.Location = new Point(42, 178);
            ScissorsBtn.Name = "ScissorsBtn";
            ScissorsBtn.Size = new Size(79, 73);
            ScissorsBtn.TabIndex = 2;
            ScissorsBtn.UseVisualStyleBackColor = true;
            ScissorsBtn.Click += ScissorsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 13);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "امتیاز کاربر:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 14);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "امتیاز کامپیوتر:";
            // 
            // UserPointTxt
            // 
            UserPointTxt.Location = new Point(249, 12);
            UserPointTxt.Name = "UserPointTxt";
            UserPointTxt.ReadOnly = true;
            UserPointTxt.Size = new Size(39, 23);
            UserPointTxt.TabIndex = 5;
            UserPointTxt.Text = "0";
            UserPointTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // ComputerPointTxt
            // 
            ComputerPointTxt.Location = new Point(117, 12);
            ComputerPointTxt.Name = "ComputerPointTxt";
            ComputerPointTxt.ReadOnly = true;
            ComputerPointTxt.Size = new Size(39, 23);
            ComputerPointTxt.TabIndex = 6;
            ComputerPointTxt.Text = "0";
            ComputerPointTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 77);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "انتخاب کاربر:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "انتخاب کامپیوتر:";
            // 
            // UserChoicePicBox
            // 
            UserChoicePicBox.Image = Properties.Resources.question;
            UserChoicePicBox.Location = new Point(225, 51);
            UserChoicePicBox.Name = "UserChoicePicBox";
            UserChoicePicBox.Size = new Size(77, 72);
            UserChoicePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserChoicePicBox.TabIndex = 9;
            UserChoicePicBox.TabStop = false;
            // 
            // ComputerChoicePicBox
            // 
            ComputerChoicePicBox.Image = Properties.Resources.question;
            ComputerChoicePicBox.Location = new Point(102, 51);
            ComputerChoicePicBox.Name = "ComputerChoicePicBox";
            ComputerChoicePicBox.Size = new Size(77, 72);
            ComputerChoicePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerChoicePicBox.TabIndex = 10;
            ComputerChoicePicBox.TabStop = false;
            // 
            // ResultLbl
            // 
            ResultLbl.AutoSize = true;
            ResultLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultLbl.Location = new Point(167, 136);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.RightToLeft = RightToLeft.Yes;
            ResultLbl.Size = new Size(0, 17);
            ResultLbl.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 265);
            Controls.Add(ResultLbl);
            Controls.Add(ComputerChoicePicBox);
            Controls.Add(UserChoicePicBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ComputerPointTxt);
            Controls.Add(UserPointTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ScissorsBtn);
            Controls.Add(PaperBtn);
            Controls.Add(RockBtn);
            Name = "Form1";
            Text = "سنگ کاغذ قیچی";
            ((System.ComponentModel.ISupportInitialize)UserChoicePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComputerChoicePicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RockBtn;
        private Button PaperBtn;
        private Button ScissorsBtn;
        private Label label1;
        private Label label2;
        private TextBox UserPointTxt;
        private TextBox ComputerPointTxt;
        private Label label3;
        private Label label4;
        private PictureBox UserChoicePicBox;
        private PictureBox ComputerChoicePicBox;
        private Label ResultLbl;
    }
}
