using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Button exitButton = new Button();
            exitButton.Text = "Выход";
            exitButton.Size = new System.Drawing.Size(100, 50);
            exitButton.Location = new System.Drawing.Point(50, 50);
            exitButton.Click += ExitButton_Click;

            Button closeButton = new Button();
            closeButton.Text = "Закрыть 2 форму";
            closeButton.Size = new System.Drawing.Size(100, 50);
            closeButton.Location = new System.Drawing.Point(50, 150);
            closeButton.Click += CloseButton_Click;

            this.Controls.Add(exitButton);
            this.Controls.Add(closeButton);
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
