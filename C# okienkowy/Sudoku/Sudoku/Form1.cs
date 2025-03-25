using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        private TextBox[,] board = new TextBox[9, 9];
        private int[,] initialBoard = new int[9, 9];
        private int[,] solutionBoard = new int[9, 9];

        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
            GenerateSudoku();
        }

        private void InitializeBoard()
        {
            pnlBoard.Controls.Clear();
            int cellSize = 40;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    TextBox txt = new TextBox
                    {
                        Width = cellSize,
                        Height = cellSize,
                        TextAlign = HorizontalAlignment.Center,
                        MaxLength = 1,
                        Font = new Font("Roboto", 16),
                        Location = new Point(col * cellSize, row * cellSize)
                    };

                    if ((row / 3 + col / 3) % 2 == 1)
                    {
                        txt.BackColor = Color.LightCyan;
                    }

                    txt.KeyPress += Txt_KeyPress;

                    board[row, col] = txt;
                    pnlBoard.Controls.Add(txt);
                }
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == '0')
                e.Handled = true;
        }

        private void GenerateSudoku()
        {
            int[,] exampleBoard =
            {
                {5, 3, 0, 0, 7, 0, 0, 0, 0},
                {6, 0, 0, 1, 9, 5, 0, 0, 0},
                {0, 9, 8, 0, 0, 0, 0, 6, 0},
                {8, 0, 0, 0, 6, 0, 0, 0, 3},
                {4, 0, 0, 8, 0, 3, 0, 0, 1},
                {7, 0, 0, 0, 2, 0, 0, 0, 6},
                {0, 6, 0, 0, 0, 0, 2, 8, 0},
                {0, 0, 0, 4, 1, 9, 0, 0, 5},
                {0, 0, 0, 0, 8, 0, 0, 7, 9}
            };

            int[,] exampleSolution =
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2},
                {6, 7, 2, 1, 9, 5, 3, 4, 8},
                {1, 9, 8, 3, 4, 2, 5, 6, 7},
                {8, 5, 9, 7, 6, 1, 4, 2, 3},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6},
                {9, 6, 1, 5, 3, 7, 2, 8, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 4, 5, 2, 8, 6, 1, 7, 9}
            };

            // Copy the example board and solution to the internal arrays
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    initialBoard[row, col] = exampleBoard[row, col];
                    solutionBoard[row, col] = exampleSolution[row, col];
                }
            }

            // Set TextBox values based on the initial board
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    board[row, col].Text = initialBoard[row, col] == 0 ? "" : initialBoard[row, col].ToString();
                    board[row, col].ReadOnly = initialBoard[row, col] != 0;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;

            // Check if all entered values match the solution
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col].Text != solutionBoard[row, col].ToString())
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }

            lblStatus.Text = isCorrect ? "Brawo!\nPrzeszedłes Sudoku II" : "Game over\nlamusie";
            lblStatus.ForeColor = isCorrect ? Color.Green : Color.Red;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GenerateSudoku();
            lblStatus.Text = "Status";
            lblStatus.ForeColor = Color.Black;
        }
    }
}
