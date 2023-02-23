using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoweQGame
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }
        //variables and such
        public Form goBack { get; set; }
        public PictureBox[,] gameGrid;
        public int currentRow;
        public int currentColumn;
        public int maxRow;
        public int maxColumn;
        public Image boxType;
        public int boxTag;
        public int boxsRemaining = 0;
        public int totalMoves = 0;
        public bool boxSelected;
        public bool activeGame = false;

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try//this catchs any invalid files
            {
                //opens file dialog and reads text file
                OpenFileDialog gameFile = new OpenFileDialog();
                if (gameFile.ShowDialog() == DialogResult.OK)
                {
                    List<int> fileArray = new List<int>();
                    StreamReader reader = new StreamReader(gameFile.FileName);//declare reader
                    using (StreamReader file = File.OpenText(gameFile.FileName))
                    {
                        string entries;
                        while ((entries = file.ReadLine()) != null)
                        {
                            string record = "";

                            while (!reader.EndOfStream)//for each line
                            {
                                record = reader.ReadLine();
                                fileArray.Add(Convert.ToInt32(record));
                            }
                        }
                    }
                    reader.Dispose();
                    //create array of picture boxes using columns and rows from the text file
                    gameGrid = new PictureBox[fileArray[1], fileArray[0]];
                    maxRow = fileArray[1];
                    maxColumn = fileArray[0];
                    
                    int counter = 2;//must be 2 to skip the col and row in the list from the text file
                    int xPos = 0;
                    int yPos = 0;
                    //clears the game panel and resets certain variables
                    gamePanel.Controls.Clear();
                    boxSelected = false;
                    boxsRemaining = 0;
                    totalMoves = 0;

                    for (int r = 0; r < fileArray[1]; r++)//creates grid of picture boxes
                    {
                        for (int c = 0; c < fileArray[0]; c++)
                        {
                            //picture box properties
                            PictureBox newBox = new PictureBox();
                            newBox.Size = new Size(50, 50);
                            newBox.SizeMode = PictureBoxSizeMode.Zoom;
                            newBox.Location = new Point(xPos, yPos);
                            newBox.BorderStyle = BorderStyle.Fixed3D;
                            newBox.Name = r + "s" + c;
                            newBox.Tag = fileArray[counter];
                            newBox.Click += this.PictureboxClick;

                            switch (fileArray[counter])//loads image depending on id
                            {
                                case 0:
                                    newBox.Image = null;
                                    break;
                                case 1:
                                    newBox.Image = Properties.Resources.Wall;
                                    break;
                                case 2:
                                    newBox.Image = Properties.Resources.Red_Door;
                                    break;
                                case 3:
                                    newBox.Image = Properties.Resources.Green_Door;
                                    break;
                                case 4:
                                    newBox.Image = Properties.Resources.Red_Box;
                                    break;
                                case 5:
                                    newBox.Image = Properties.Resources.Green_Box;
                                    break;
                            }
                            //adds picture box to the panel and the array
                            gamePanel.Controls.Add(newBox);
                            gameGrid[r, c] = newBox;
                            //if it adds a box it adds it to boxes remaining
                            if ((Convert.ToInt32(fileArray[counter]) == 4) || (Convert.ToInt32(fileArray[counter]) == 5))
                            {
                                boxsRemaining++;
                            }

                            xPos += 50;
                            counter++;
                        }
                        yPos += 50;
                        xPos = 0;
                    }
                    //updates labels for remaining boxes and total moves, sets active game to true
                    boxsLeftLabel.Text = boxsRemaining.ToString();
                    totalMovesLabel.Text = totalMoves.ToString();
                    activeGame = true;
                }
            }
            catch
            {
                MessageBox.Show("Invalid file selected or save file corrupted.");
            }
        }

        private void PictureboxClick(object sender, EventArgs e)
        {
            PictureBox selectedBox = sender as PictureBox;
            //checks that a green or red box has been selected, saves certain data related to selected box
            if ((Convert.ToInt32(selectedBox.Tag) == 4) || (Convert.ToInt32(selectedBox.Tag) == 5))
            {
                string[] nameSplit = selectedBox.Name.Split('s');
                currentRow = Convert.ToInt32(nameSplit[0]);
                currentColumn = Convert.ToInt32(nameSplit[1]);
                boxType = selectedBox.Image;
                boxTag = Convert.ToInt32(selectedBox.Tag);
                boxSelected = true;
            }
        }

        private void PlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.goBack.Show();
        }
        //comments have only been added to the w keypress event as they basically are all the same thing
        private void PlayForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            int newRow = currentRow;
            int newColumn = currentColumn;
            bool doorCheck = false;
            //checks to see if a game has been loaded
            if (activeGame == true)
            {
                if (boxSelected == false)
                {
                    MessageBox.Show("A box has not been selected");
                }

                //checks for a "w" keypress and that a box has been selected
                if ((e.KeyChar == 'w') && (boxSelected == true))
                {
                    for (int r = currentRow - 1; r >= 0; r--)
                    {
                        if (Convert.ToInt32(gameGrid[r, currentColumn].Tag) == 0)//checks next picture box for an empty space
                        {
                            newRow = r;
                        }
                        else if (Convert.ToInt32(gameGrid[r, currentColumn].Tag) + 2 == Convert.ToInt32(boxTag))//checks next picture box for a door
                        {
                            doorCheck = true;
                        }
                        else//if not an empty space or a door the box stops moving
                        {
                            break;
                        }
                    }
                    //removes box when it enters the correct door, makes boxSelected = false;
                    if (doorCheck == true)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        boxsRemaining--;
                        totalMoves++;
                        boxSelected = false;
                    }
                    //removes box from old location and moves it to the new location
                    else if (newRow != currentRow)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        gameGrid[newRow, currentColumn].Image = boxType;
                        gameGrid[newRow, currentColumn].Tag = boxTag;
                        currentRow = newRow;
                        totalMoves++;
                    }
                }

                if ((e.KeyChar == 'a') && (boxSelected == true))
                {
                    for (int c = currentColumn - 1; c >= 0; c--)
                    {
                        if (Convert.ToInt32(gameGrid[currentRow, c].Tag) == 0)
                        {
                            newColumn = c;
                        }
                        else if (Convert.ToInt32(gameGrid[currentRow, c].Tag) + 2 == Convert.ToInt32(boxTag))
                        {
                            doorCheck = true;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (doorCheck == true)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        boxsRemaining--;
                        totalMoves++;
                        boxSelected = false;
                    }
                    else if (newColumn != currentColumn)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        gameGrid[currentRow, newColumn].Image = boxType;
                        gameGrid[currentRow, newColumn].Tag = boxTag;
                        currentColumn = newColumn;
                        totalMoves++;
                    }
                }

                if ((e.KeyChar == 's') && (boxSelected == true))
                {
                    for (int r = currentRow + 1; r < maxRow; r++)
                    {
                        if (Convert.ToInt32(gameGrid[r, currentColumn].Tag) == 0)
                        {
                            newRow = r;
                        }
                        else if (Convert.ToInt32(gameGrid[r, currentColumn].Tag) + 2 == Convert.ToInt32(boxTag))
                        {
                            doorCheck = true;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (doorCheck == true)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        boxsRemaining--;
                        totalMoves++;
                        boxSelected = false;
                    }
                    else if (newRow != currentRow)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        gameGrid[newRow, currentColumn].Image = boxType;
                        gameGrid[newRow, currentColumn].Tag = boxTag;
                        currentRow = newRow;
                        totalMoves++;
                    }
                }

                if ((e.KeyChar == 'd') && (boxSelected == true))
                {
                    for (int c = currentColumn + 1; c < maxColumn; c++)
                    {
                        if (Convert.ToInt32(gameGrid[currentRow, c].Tag) == 0)
                        {
                            newColumn = c;
                        }
                        else if (Convert.ToInt32(gameGrid[currentRow, c].Tag) + 2 == Convert.ToInt32(boxTag))
                        {
                            doorCheck = true;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (doorCheck == true)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        boxsRemaining--;
                        totalMoves++;
                        boxSelected = false;
                    }
                    else if (newColumn != currentColumn)
                    {
                        gameGrid[currentRow, currentColumn].Image = null;
                        gameGrid[currentRow, currentColumn].Tag = 0;
                        gameGrid[currentRow, newColumn].Image = boxType;
                        gameGrid[currentRow, newColumn].Tag = boxTag;
                        currentColumn = newColumn;
                        totalMoves++;
                    }
                }

                boxsLeftLabel.Text = boxsRemaining.ToString();
                totalMovesLabel.Text = totalMoves.ToString();

                if (boxsRemaining == 0)
                {
                    MessageBox.Show("You Won in " + totalMoves + " moves!");
                    activeGame = false;
                    gamePanel.Controls.Clear();
                    totalMovesLabel.Text = "0";
                } 
            }
        }
    }
}
