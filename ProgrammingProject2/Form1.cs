using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            errorMessage.Visible = false;

            String scissorPrice = "$7.99";
            String bookPrice = "$2.99";
            String laptopPrice = "$149.99";

            String scissorName = "Scissors";
            String bookName = "Notebook";
            String laptopName = "4GB Laptop";

            String scissorType = "Left-Handed";
            String bookType = "Spiral";
            String laptopType = "MacPage 4GB Handheld(TM)";

            if (listBox.SelectedIndex == -1)
            {
                errorMessage.Visible = true;
            }
            else
            {

                if (listBox.SelectedItem.ToString().Equals("Laptop"))
                {
                    if (greenButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.GreenComputer;
                    }
                    if (blueButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.BlueComputer;
                    }
                    if (redButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.RedComputer;
                    }

                    typeLabel.Text = laptopType;
                    nameLabel.Text = laptopName;
                    priceLabel.Text = laptopPrice;
                }

                if (listBox.SelectedItem.ToString().Equals("Notebook"))
                {
                    if (greenButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.GreenNotebook;
                    }
                    if (blueButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.BlueNotebook;
                    }
                    if (redButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.RedNotebook;
                    }

                    typeLabel.Text = bookType;
                    nameLabel.Text = bookName;
                    priceLabel.Text = bookPrice;
                }

                if (listBox.SelectedItem.ToString().Equals("Scissors"))
                {
                    if (greenButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.GreenScissors;
                    }
                    if (blueButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.BlueScissors;
                    }
                    if (redButton.Checked == true)
                    {
                        pictureBox.Image = Properties.Resources.RedScissors;
                    }

                    typeLabel.Text = scissorType;
                    nameLabel.Text = scissorName;
                    priceLabel.Text = scissorPrice;
                }

                if (typeBox.Checked == true)
                {
                    typeLabel.Visible = true;
                }
                else if (typeBox.Checked == false)
                {
                    typeLabel.Visible = false;
                }

                if (nameBox.Checked == true)
                {
                    nameLabel.Visible = true;
                }
                else if (nameBox.Checked == false)
                {
                    nameLabel.Visible = false;
                }

                if (priceBox.Checked == true)
                {
                    priceLabel.Visible = true;
                }
                else if (priceBox.Checked == false)
                {
                    priceLabel.Visible = false;
                }

            }
        }
    }
}
