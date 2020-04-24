using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BirdHouse.Library;

namespace Plagin
{
    public partial class MainForm : Form
    {
        private KompasConnector kompasConnector;
        private HouseParameters houseParameters;


        public MainForm()
        {
            InitializeComponent();
            InitializeParams();
        }
       
       
        private void Clean_Click(object sender, EventArgs e)
        {
            foreach (Control c in base.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!(e.KeyChar > 47 && e.KeyChar < 58) && e.KeyChar != 8)
                e.Handled = true;
        }


        private void Build_Click(object sender, EventArgs e)
        {
            kompasConnector = new KompasConnector(houseParameters);
            HouseBuilder housebuilder = new HouseBuilder();
            housebuilder.Build(kompasConnector.iPart, kompasConnector.kompas, houseParameters);
        }

        /// <summary>
        /// Инициализация начальный параметров
        /// </summary>
        private void InitializeParams()
        {
            heightBox.Text = "250";
            hallowBox.Text = "26";
            lengthPerchBox.Text = "25";
            diameterPerchBox.Text = "5";
            depthBox.Text = "120";
            widthBox.Text = "120";
            fastenersBox.Text = "30";
        }
        private void ValidateAndSet_Values()
        {

            // Переменная, которая ведет подсчёт правильно заполненых полей.
            int countRight = 0;
            Build.Enabled = false;
            if ((heightBox.Text == "") || int.Parse(heightBox.Text) < 250 || int.Parse(heightBox.Text) > 500)
            {
                DialogResult result = MessageBox.Show(
                "Height has to be from 250 mm 500 mm",
                "Error",
                MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    heightBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if ((hallowBox.Text == "") || int.Parse(hallowBox.Text) < 26 || (int.Parse(hallowBox.Text)) > (Height - 26))
            {
                DialogResult result = MessageBox.Show(
               "Hallow height depends on height.It has to be higher 25 mm and below on"
               + (int.Parse(heightBox.Text) - 25) + " mm of top edge",
               "Error",
               MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    hallowBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if (int.Parse(lengthPerchBox.Text) < 25 || (int.Parse(lengthPerchBox.Text)) > 35)
            {
                DialogResult result = MessageBox.Show(
                "Length perch has to be more 25 mm and less than 35 mm",
                "Error",
                MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    lengthPerchBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if (int.Parse(diameterPerchBox.Text) < 5 || (int.Parse(diameterPerchBox.Text)) > 10)
            {
                DialogResult result = MessageBox.Show(
                "Diameter perch has to be more 5 mm and less 10 mm",
                "Error",
                MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    diameterPerchBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if ((depthBox.Text == "") || int.Parse(depthBox.Text) < 120 || (int.Parse(depthBox.Text)) > 190)
            {
                DialogResult result = MessageBox.Show(
                "Depth has to be more 120 mm and less 190 mm",
                "Error",
                MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    depthBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if ((widthBox.Text == "") || int.Parse(widthBox.Text) < 120 || (int.Parse(widthBox.Text)) > 190)
            {
                DialogResult result = MessageBox.Show(
                "Width has to be more 120 mm and less 190 mm",
                "Error",
                MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    widthBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if ((fastenersBox.Text == "") || int.Parse(fastenersBox.Text) < 30 || (int.Parse(fastenersBox.Text)) > 50)
            {
                DialogResult result = MessageBox.Show(
                 "Width fasteners has to be more 30 mm and less 50 mm",
                 "Error",
                 MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    fastenersBox.Text = "";
            }
            else
            {
                countRight++;
            }

            if (countRight == 7)
            {
                // Если высота размещения дупла меньше заданной или длина, или диаметр жердочки не задан,то жёрдочки нет
                if ((int.Parse(hallowBox.Text) - 25) <= 21 || lengthPerchBox.Text == "" || diameterPerchBox.Text == "")
                {
                    lengthPerchBox.Text = "";
                    diameterPerchBox.Text = "";
                    DialogResult result = MessageBox.Show(
                    "Length perch or diameter perch are null." +
                    "Bird house will build without perch ",
                     "Warning",
                    MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                        countRight = 5;
                }

                else
                {
                    Build.Enabled = true;
                    houseParameters = new HouseParameters
                        (Convert.ToInt32(heightBox.Text), Convert.ToInt32(hallowBox.Text),
                         Convert.ToInt32(lengthPerchBox.Text), Convert.ToInt32(diameterPerchBox.Text),
                         Convert.ToInt32(depthBox.Text), Convert.ToInt32(widthBox.Text),
                         Convert.ToInt32(fastenersBox.Text));
                }
            }
            if (countRight == 5)
            {
                //Построение без жёрдочки
                Build.Enabled = true;
                lengthPerchBox.Text = "";
                diameterPerchBox.Text = "";
                houseParameters = new HouseParameters
                   (Convert.ToInt32(heightBox.Text), Convert.ToInt32(hallowBox.Text),
                    Convert.ToInt32(lengthPerchBox.Text), Convert.ToInt32(diameterPerchBox.Text),
                    Convert.ToInt32(depthBox.Text), Convert.ToInt32(widthBox.Text),
                    Convert.ToInt32(fastenersBox.Text));
            }

        }
        
        /// <summary>
        /// Функция, которая является обработчиком события(срабатывает при изменение значения  в текстовом поле).
        /// </summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSet_Values();
        }
    }
}
