using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Formats.Asn1.AsnWriter;

namespace Turn_Based_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int mainCharPosX;
        private int mainCharPosY;
        private int[,] levelMap;
        private string[] tiles = {"image_part_135", "image_part_136", "image_part_137",   // 0 , 1 , 2
                                  "image_part_151", "image_part_152", "image_part_153",   // 3 , 4 , 5
                                  "image_part_167", "image_part_168", "image_part_169",   // 6 , 7 , 8
                                  "tile_bush" , "gem_tile"};
        private int score;

        public MainWindow()
        {
            InitializeComponent();

            // add a global key listener
            this.KeyDown += new KeyEventHandler(OnKeyDown);

            score = 0;

            levelMap = new int[,] {
                {0,1,2,-1,-1,-1,0,1,1,2 }, // row 0
                {3,4,4,1,1,1,4,4,4,5 }, // row 1
                {3,4,4,4,4,4,4,4,4,5 },
                {3,4,9,9,4,4,4,10,4,5 },
                {3,4,4,9,4,4,4,4,4,5 },
                {3,4,10,10,9,9,4,4,4,5 },
                {3,4,4,4,4,4,4,4,4,5 },
                {6,7,7,7,7,7,7,7,7,8 }
            };
            mainCharPosX = 5;
            mainCharPosY = 3;

            Redraw();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.Key.ToString());
            if (e.Key == Key.Right)
            {
                mainCharPosX++;
                if (HasNoCollision())
                    Redraw();
                else
                    mainCharPosX--; // undo move 
            }
            if (e.Key == Key.Left)
            {
                mainCharPosX--;
                if (HasNoCollision())
                    Redraw();
                else
                    mainCharPosX++; // undo move 
            }
            if (e.Key == Key.Up)
            {
                mainCharPosY--;
                if (HasNoCollision())
                    Redraw();
                else
                    mainCharPosY++; // undo move 
            }
            if (e.Key == Key.Down)
            {
                mainCharPosY++;
                if (HasNoCollision())
                    Redraw();
                else
                    mainCharPosY--; // undo move 
            }
        }

        private bool HasNoCollision()
        {
            if (levelMap[mainCharPosY, mainCharPosX] == 9)
            {
                return false;
            }
            return true;
        }

        private void Redraw()
        {
            /*
            // testing
            string t = "";
            for (int row = 0; row < levelMap.GetLength(0); row++)
            {
                for (int col = 0; col < levelMap.GetLength(1); col++)
                {
                    t += levelMap[row, col];
                }
                t += "\n";
            }
            MessageBox.Show(t);*/

            // rules of the game
            Trace.WriteLine(levelMap[mainCharPosY, mainCharPosX]);
            if (levelMap[mainCharPosY, mainCharPosX] == 10)
            { // you are walking on a gem! picked up!
                score += 100;
                scoreLabel.Content = "Score: " + score;
                levelMap[mainCharPosY, mainCharPosX] = 4; // no more gem there 
            }

            // --- drawing the map and the character ---
            myCanvas.Children.Clear();
            // perpare a uniform grid
            UniformGrid aUniformGrid = new UniformGrid();
            aUniformGrid.Columns = 10;
            aUniformGrid.Rows = 8;
            aUniformGrid.Width = 2*16 * 10;
            aUniformGrid.Height = 2*16 * 8;
            string name;
            for (int row = 0; row < levelMap.GetLength(0); row++)
            {
                for (int col = 0; col < levelMap.GetLength(1); col++)
                {
                    int tileIndex = levelMap[row, col];
                    if (tileIndex != -1) {
                        Image img = new Image();
                        name = "pack://application:,,,/imgs/" + tiles[tileIndex] + ".png";
                        //Trace.WriteLine(name);
                        img.Source = new BitmapImage(new Uri(name));
                        aUniformGrid.Children.Add(img);
                    } else
                    { // blank tile
                        Rectangle rect = new Rectangle();
                        rect.Opacity = 0; // transparent!
                        aUniformGrid.Children.Add(rect);
                    }
                    
                }
            }

            // place the entire grid on the canvas
            Canvas.SetLeft(aUniformGrid, 0);
            Canvas.SetTop(aUniformGrid, 0);
            myCanvas.Children.Add(aUniformGrid);

            // place the player
            Image mainChar = new Image();
            string filePath = "pack://application:,,,/imgs/main_character.png";
            mainChar.Source = new BitmapImage(new Uri(filePath));
            mainChar.Width = 2 * 16;
            mainChar.Height = 2 * 16;
            myCanvas.Children.Add(mainChar);
            Canvas.SetLeft(mainChar, 2*16 * mainCharPosX);
            Canvas.SetTop(mainChar, 2*16 * mainCharPosY);
        }

    }
}
