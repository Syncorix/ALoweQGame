using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoweQGame
{
    public partial class DesignForm : Form
    {
        public DesignForm()
        {
            InitializeComponent();
        }

        public Form goBack { get; set; }
        public Image selectedImage = null;
        public int tagSet;
        public int columnCount = 0;
        public int rowCount = 0;

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //checks column and row for ints
            if ((Regex.IsMatch(columnTextbox.Text, @"^\d+$") && Regex.IsMatch(rowTextbox.Text, @"^\d+$")))
            {
                boxPanel.Controls.Clear();//clears the picture boxes in the panel

                columnCount = Convert.ToInt32(columnTextbox.Text);
                rowCount = Convert.ToInt32(rowTextbox.Text);
                int xPos = 0;
                int yPos = 0;

                for(int r = 0; r < rowCount; r++)//creates grid of picture boxes
                {
                    for (int c = 0; c < columnCount; c++)
                    {
                        //picture box properties
                        PictureBox newBox = new PictureBox();
                        newBox.Size = new Size(50, 50);
                        newBox.SizeMode = PictureBoxSizeMode.Zoom;
                        newBox.Location = new Point(xPos,yPos);
                        newBox.BorderStyle = BorderStyle.Fixed3D;
                        newBox.Tag = 0;
                        newBox.Click += this.PictureboxClick;
                        boxPanel.Controls.Add(newBox);
                        xPos += 50;
                    }
                    yPos += 50;
                    xPos = 0;
                }
            }
            else
            {
                MessageBox.Show("Column and row must be integers.");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boxPanel.Controls.Count != 0)//checks that picture boxes have been generated
            {
                //saves row and colunm count to string
                string saveFile = columnCount.ToString() + "\n" + rowCount.ToString() + "\n";
                int wallCount = 0;
                int doorCount = 0;
                int boxCount = 0;

                foreach(Control control in boxPanel.Controls)//loops through all the pictureboxs in the panel
                {
                    //saves the tile id to string
                    saveFile += control.Tag + "\n";
                    //counts walls, doors, and boxes
                    if(Convert.ToInt32(control.Tag) == 1)
                    {
                        wallCount++;
                    }
                    if((Convert.ToInt32(control.Tag) == 2) || (Convert.ToInt32(control.Tag) == 3))
                    {
                        doorCount++;
                    }
                    if ((Convert.ToInt32(control.Tag) == 4) || (Convert.ToInt32(control.Tag) == 5))
                    {
                        boxCount++;
                    }
                }
                SaveFileDialog newSave = new SaveFileDialog();
                newSave.FileName = "newLevel";
                newSave.DefaultExt = "txt";
                newSave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (newSave.ShowDialog() == DialogResult.OK)
                {
                    //saves the file if the user clicks save
                    File.AppendAllText(newSave.FileName, saveFile);
                    MessageBox.Show("Saved successfully.\nNumber of walls: " + wallCount + "\nNumber of doors: " + doorCount + "\nNumber of boxes: " + boxCount);
                }
            }
            else
            {
                MessageBox.Show("A grid must be generated before it can be saved.");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureboxClick(object sender, EventArgs e)
        {
            PictureBox selectedBox = sender as PictureBox;//changes the picturebox image when the box is clicked
            selectedBox.Image = selectedImage;
            selectedBox.Tag = tagSet;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //changes the selected image when the button is clicked
            var selectedButton = sender as Button;
            selectedImage = selectedButton.Image;
            tagSet = Convert.ToInt32(selectedButton.Tag);
        }
        
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.goBack.Show();
        }
    }
}