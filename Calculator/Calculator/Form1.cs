
namespace Calculator
{
    public partial class Form_Calculator : Form
    { 
        String State { get; set; }
        List<double> Listik = new List<double>(4) { 0, 0, 0, 0};

        public Form_Calculator()
        {
            InitializeComponent();
        }
        private void ReCheck()
        {
            this.textBox0.Text = Listik[0].ToString();
            this.textBox1.Text = Listik[1].ToString();
            this.textBox2.Text = Listik[2].ToString();
            this.textBox3.Text = Listik[3].ToString();
        }


        private void Minus_Click(object sender, EventArgs e)
        {
            State = "-";
            this.Minus.BackColor = Color.Yellow;
            this.Plus.BackColor = DefaultBackColor;
            this.Multiplise.BackColor = DefaultBackColor;
            this.Devise.BackColor = DefaultBackColor;
        }

        private void Multiplise_Click(object sender, EventArgs e)
        {
            State = "*";
            this.Multiplise.BackColor = Color.Yellow;
            this.Plus.BackColor = DefaultBackColor;
            this.Minus.BackColor = DefaultBackColor;
            this.Devise.BackColor = DefaultBackColor;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            State = "+";
            this.Plus.BackColor = Color.Yellow;
            this.Minus.BackColor = DefaultBackColor;
            this.Multiplise.BackColor = DefaultBackColor;
            this.Devise.BackColor = DefaultBackColor;
        }

        private void Devise_Click(object sender, EventArgs e)
        {
            State = "/";
            this.Devise.BackColor = Color.Yellow;
            this.Plus.BackColor = DefaultBackColor;
            this.Multiplise.BackColor = DefaultBackColor;
            this.Minus.BackColor = DefaultBackColor;
        }

        private void Up_Click(object sender, EventArgs e)
        {
            Listik[3] = Convert.ToDouble(this.textBox3.Text);
            Operations.Operations operations = new Operations.Operations();
            if (!(State == "/" && this.textBox3.Text == "0"))
            {
                operations.Up(State, Listik);
            }
            else
            {
                MessageBox.Show("Wrong number", "Warning");
            }
            ReCheck();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            Operations.Operations operations = new Operations.Operations();
            operations.Down(Listik);
            ReCheck();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            Listik[3] = Convert.ToDouble(this.textBox3.Text);
            Operations.Operations operations = new Operations.Operations();
            operations.Switch(Listik);
            ReCheck();
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            Listik[3] = Convert.ToDouble(this.textBox3.Text);
            Operations.Operations operations = new Operations.Operations();
            operations.Turn(Listik);
            ReCheck();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Devise.BackColor = DefaultBackColor;
            this.Plus.BackColor = DefaultBackColor;
            this.Multiplise.BackColor = DefaultBackColor;
            this.Minus.BackColor = DefaultBackColor;
            Listik = new List<double>(4) { 0, 0, 0, 0 };
            ReCheck();
        }
    }
}