namespace fukuv0530
{
    public partial class Form1 : Form
    {
        int vx = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -vx;
            if (vx > 0)
                label1.Text = "migi";
            else
                label1.Text = "hidari";
            if(vx>0)
                label1.BackColor = Color.LightBlue;
            else
                label1.BackColor = Color.LightPink;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ogiharaeito";
            timer1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            
        }
    }
}
