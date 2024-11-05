namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button exitButton = new Button();
            exitButton.Text = "Выход";
            exitButton.Size = new System.Drawing.Size(100, 50);
            exitButton.Location = new System.Drawing.Point(50, 50);
            exitButton.Click += ExitButton_Click;

            Button transitionButton = new Button();
            transitionButton.Text = "Переход";
            transitionButton.Size = new System.Drawing.Size(100, 50);
            transitionButton.Location = new System.Drawing.Point(50, 150);
            transitionButton.Click += TransitionButton_Click;

            this.Controls.Add(exitButton);
            this.Controls.Add(transitionButton);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void TransitionButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

    }
}
