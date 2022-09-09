
namespace Calculator
{
    public partial class Form1 : Form
    { 
        String State { get; set; }

        public Form1()
        {
            InitializeComponent();
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
            List<double> listik = new List<double>()
            {
                Convert.ToDouble(textBox0.Text), Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)
            };

            Operations.Operations operations = new Operations.Operations(listik);
            operations.Up(State);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            Operations.Operations operations = new Operations.Operations(new List<double>()
            {
                Convert.ToDouble(textBox0.Text), Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)
            });
            operations.Down();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            Operations.Operations operations = new Operations.Operations(new List<double>()
            {
                Convert.ToDouble(textBox0.Text), Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)
            });
            operations.Switch();
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            Operations.Operations operations = new Operations.Operations(new List<double>()
            {
                Convert.ToDouble(textBox0.Text), Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)
            });
            operations.Turn();
        }

    }
}