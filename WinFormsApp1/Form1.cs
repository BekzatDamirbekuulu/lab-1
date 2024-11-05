namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            this.FormClosing += Form1_FormClosing; 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); 
            this.Dispose();
        }
    }
}
