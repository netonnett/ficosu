namespace ficosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int begin = 0;
            int slut = 30;


            int prevprev = -1;
            int prev = 1;


            for (int i = begin; i <= slut; i++)
            {

                int newnumber = prevprev + prev;

                prevprev = prev;
                prev = newnumber;


                textBox1.Text = textBox1.Text + newnumber + " ";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}