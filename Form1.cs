namespace _30112022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            workDays dayone;
            // dayone = workDays.Wednesday;
            // string day1 = dayone.ToString();
            dayone = (workDays)Enum.Parse(typeof(workDays), textBox3.Text);
            File.AppendAllText("nameFile.txt", txt1.Text + "," + textBox2.Text + "," + dayone.ToString() + "\n");
            txt1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string str = File.ReadAllText("nameFile.txt");
            string[] words = str.Split(',');
            txt1.Text = words[0];
            textBox2.Text = words[1];
            textBox3.Text = words[2];


        }
        enum workDays
        {
            sunday,
            monday,
            Tuesday,
            Wednesday,
            Thursday,
            friday,

        }
    }

}
