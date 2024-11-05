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
            exitButton.Location = new System.Drawing.Point(100, 100);

            // Обработчик события нажатия на кнопку
            exitButton.Click += new EventHandler(ExitButton_Click);

            // Добавление кнопки на форму
            this.Controls.Add(exitButton);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Закрытие формы
            this.Close();
        }
    }
}
