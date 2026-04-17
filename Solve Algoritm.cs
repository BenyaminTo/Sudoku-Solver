using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public char[,] sudoku = new char[9, 9];
        private void button1_Click(object sender, EventArgs e)
        {

            SetArraysNums(sudoku);
            solveSudoku(sudoku);
            SetResult(sudoku);

        }

        private void SetResult(char[,] sudoku)
        {
            int h = 1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var txtbox = "textBox" + h;
                    var obj = this.Controls.Find(txtbox.ToString(), true).FirstOrDefault();

                    ((TextBox)obj).Text = sudoku[i, j].ToString();
                    h++;
                }
            }
        }

        private void SetArraysNums(char[,] sudoku)
        {
            int h = 1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var txtbox = "textBox" + h;
                    var obj = this.Controls.Find(txtbox.ToString(), true).FirstOrDefault();
                    if (((TextBox)obj).Text == "")
                    {
                        h++;
                        sudoku[i, j] = '.';
                        continue;
                    }
                    sudoku[i, j] = ((TextBox)obj).Text[0];
                    h++;
                }
            }
        }

        public static void solveSudoku(char[,] board)
        {
            if (board == null || board.Length == 0)
                return;
            solve(board);
        }
        private static bool solve(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (isValid(board, i, j, c))
                            {
                                board[i, j] = c;

                                if (solve(board))
                                    return true;
                                else
                                    board[i, j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        private static bool isValid(char[,] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                //check row  
                if (board[i, col] != '.' && board[i, col] == c)
                    return false;
                //check column  
                if (board[row, i] != '.' && board[row, i] == c)
                    return false;
                //check 3*3 block  
                if (board[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] != '.' && board[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] == c)
                    return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void ClearValues()
        {
            Array.Clear(sudoku,0, sudoku.Length);
            for (int i = 1; i < 82; i++)
            {
                var txtbox = "textBox" +i;
                var obj = this.Controls.Find(txtbox.ToString(), true).FirstOrDefault();
                obj.Text = "";
            }
        }
    }
}
