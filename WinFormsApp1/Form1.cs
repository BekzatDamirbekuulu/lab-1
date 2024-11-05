namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button colorButton = new Button();
            colorButton.BackColor = Color.White;
            colorButton.Text = "Цвет фона";
            colorButton.Size = new System.Drawing.Size(150, 50);
            colorButton.Location = new System.Drawing.Point(100, 100);

            colorButton.Click += new EventHandler(ColorButton_Click);

            this.Controls.Add(colorButton);
        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int r = rand.Next(256); 
            int g = rand.Next(256); 
            int b = rand.Next(256);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
