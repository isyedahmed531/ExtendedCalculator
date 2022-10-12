namespace ExtendedCalculator
{
    public partial class Form1 : Form
    {
        char op;
        int firstValue = 0;
        int secondValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //Divide Button
        {
            firstValue += Convert.ToInt32(this.txtCalculator.Text);
            this.txtCalculator.Text = "/";
            op = '/';
        }

        private void button14_Click(object sender, EventArgs e) //Equal Button
        {
            secondValue = Convert.ToInt32(this.txtCalculator.Text);
            if (op == '+')
            {
                this.txtCalculator.Text = "" + (firstValue + secondValue);
            }
            else if (op == '-')
            {
                this.txtCalculator.Text = "" + (firstValue - secondValue);
            }
            else if (op == '*')
            {
                this.txtCalculator.Text = "" + (firstValue * secondValue);
            }
            else if (op == '/')
            {
                try
                {
                    this.txtCalculator.Text = "" + (firstValue + secondValue);
                }
                catch (DivideByZeroException) {
                    this.txtCalculator.Text = "CANNOT DIVIDE BY ZERO";
                }
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "";
            firstValue = 0;
            secondValue = 0;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = "9";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstValue += Convert.ToInt32(this.txtCalculator.Text);
            this.txtCalculator.Text = "+";
            op = '+';
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstValue += Convert.ToInt32(this.txtCalculator.Text);
            this.txtCalculator.Text = "-";
            op = '-';
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstValue += Convert.ToInt32(this.txtCalculator.Text);
            this.txtCalculator.Text = "*";
            op = '*';
        }
    }
}