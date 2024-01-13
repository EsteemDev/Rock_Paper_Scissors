using RockPaperScissors.Properties;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string UserChoice = "";
        string ComputerChoice = "";

        private void RockBtn_Click(object sender, EventArgs e)
        {
            UserChoice = "Rock";

            SetPicBox(UserChoice, "User");

            ComputerRandomChoice();

            CalculatePoint();
        }

        private void PaperBtn_Click(object sender, EventArgs e)
        {
            UserChoice = "Paper";

            SetPicBox(UserChoice, "User");

            ComputerRandomChoice();

            CalculatePoint();
        }

        private void ScissorsBtn_Click(object sender, EventArgs e)
        {
            UserChoice = "Scissors";

            SetPicBox(UserChoice, "User");

            ComputerRandomChoice();

            CalculatePoint();
        }

        private void SetPicBox(string ChoiceName, string Player)
        {
            object obj = Resources.ResourceManager.GetObject(ChoiceName);
            if (Player == "Computer")
                ComputerChoicePicBox.Image = (Image)obj;
            else
                UserChoicePicBox.Image = (Image)obj;
        }

        private void ComputerRandomChoice()
        {
            Random random = new Random();
            int Choice = random.Next(1, 4);
            switch (Choice)
            {
                case 1:
                    ComputerChoice = "Rock";
                    break;

                case 2:
                    ComputerChoice = "Paper";
                    break;

                case 3:
                    ComputerChoice = "Scissors";
                    break;
            }

            SetPicBox(ComputerChoice, "Computer");
        }

        private void CalculatePoint()
        {
            if (ComputerChoice == UserChoice)
            {
                ResultLbl.Text = "مساوی کردید!";
                ResultLbl.ForeColor = Color.Blue;
            }
            else if ((UserChoice == "Rock" && ComputerChoice == "Scissors") ||
                     (UserChoice == "Paper" && ComputerChoice == "Rock") ||
                     (UserChoice == "Scissors" && ComputerChoice == "Paper"))
            {
                ResultLbl.Text = "کاربر برنده شد";
                ResultLbl.ForeColor = Color.Green;

                int Point = Convert.ToInt32(UserPointTxt.Text) + 1;
                UserPointTxt.Text = Point.ToString();
            }
            else
            {
                ResultLbl.Text = "کامپیوتر برنده شد";
                ResultLbl.ForeColor = Color.Red;

                int Point = Convert.ToInt32(ComputerPointTxt.Text) + 1;
                ComputerPointTxt.Text = Point.ToString();
            }
        }
    }
}
