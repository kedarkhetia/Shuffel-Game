using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Game
{
    public partial class Form1 : MetroForm
    {
        public MetroButton CurrentBlank;
        bool undoFlag;
        int StepCount;
        Stack<MetroButton> undo_stack = new Stack<MetroButton>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadGame()
        {
            label1.Text = "Status: ";
            undo_stack.Clear();
            StepCount = 0;
            label5.Text = "Steps : " + StepCount;
            undoFlag = false;
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Random rand = new Random();
            int[] RandNum = num.OrderBy(x => rand.Next()).ToArray();
            b1.Text = RandNum[0].ToString();
            b2.Text = RandNum[1].ToString();
            b3.Text = RandNum[2].ToString();
            b4.Text = RandNum[3].ToString();
            b5.Text = RandNum[4].ToString();
            b6.Text = RandNum[5].ToString();
            b7.Text = RandNum[6].ToString();
            b8.Text = RandNum[7].ToString();
            b9.Text = RandNum[8].ToString();
            b10.Text = RandNum[9].ToString();
            b11.Text = RandNum[10].ToString();
            b12.Text = RandNum[11].ToString();
            b13.Text = RandNum[12].ToString();
            b14.Text = RandNum[13].ToString();
            b15.Text = RandNum[14].ToString();
            b16.Text = "";
            b16.Focus();
            try
            {
                CurrentBlank.BackColor = Color.White;
            }catch(Exception e) { }
            CurrentBlank = b16;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGame();
        }

        public void changeTile(MetroButton valued, MetroButton blank)
        {
            if(blank.Text == "")
            {
                blank.Text = valued.Text;
                blank.BackColor = Color.White;
                valued.Text = "";
                valued.BackColor = Color.Silver;
                if (!undoFlag)
                {
                    undo_stack.Push(blank);
                    StepCount += 1;
                }
                else
                {
                    StepCount -= 1;
                }
                label5.Text = "Steps : " + StepCount;
                CurrentBlank = valued;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b1, b2);
            changeTile(b1, b5);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b2, b1);
            changeTile(b2, b3);
            changeTile(b2, b6);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b3, b2);
            changeTile(b3, b4);
            changeTile(b3, b7);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b4, b3);
            changeTile(b4, b8);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b5, b1);
            changeTile(b5, b6);
            changeTile(b5, b9);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b6, b5);
            changeTile(b6, b2);
            changeTile(b6, b7);
            changeTile(b6, b10);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b7, b8);
            changeTile(b7, b3);
            changeTile(b7, b6);
            changeTile(b7, b11);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b8, b7);
            changeTile(b8, b12);
            changeTile(b8, b4);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b9, b5);
            changeTile(b9, b10);
            changeTile(b9, b13);
        }

        private void b10_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b10, b9);
            changeTile(b10, b14);
            changeTile(b10, b6);
            changeTile(b10, b11);
        }

        private void b11_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b11, b10);
            changeTile(b11, b7);
            changeTile(b11, b12);
            changeTile(b11, b15);
        }

        private void b12_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b12, b8);
            changeTile(b12, b16);
            changeTile(b12, b11);
        }

        private void b13_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b13, b9);
            changeTile(b13, b14);
        }

        private void b14_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b14, b15);
            changeTile(b14, b13);
            changeTile(b14, b10);
        }

        private void b15_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b15, b16);
            changeTile(b15, b14);
            changeTile(b15, b11);
        }

        private void b16_Click(object sender, EventArgs e)
        {
            undoFlag = false;
            changeTile(b16, b12);
            changeTile(b16, b15);
        }

        private void UndoPicture_Click(object sender, EventArgs e)
        {
            undoFlag = true;
            try
            {
                changeTile(undo_stack.Pop(), CurrentBlank);
            }
            catch (Exception exc) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] resultSet = new string[15];
            resultSet[0] = b1.Text;
            resultSet[1] = b2.Text;
            resultSet[2] = b3.Text;
            resultSet[3] = b4.Text;
            resultSet[4] = b5.Text;
            resultSet[5] = b6.Text;
            resultSet[6] = b7.Text;
            resultSet[7] = b8.Text;
            resultSet[8] = b9.Text;
            resultSet[9] = b10.Text;
            resultSet[10] = b11.Text;
            resultSet[11] = b12.Text;
            resultSet[12] = b13.Text;
            resultSet[13] = b14.Text;
            resultSet[14] = b15.Text;
            int count = 1;
            foreach (string s in resultSet)
            {
                try
                {
                    if (Convert.ToInt32(s) == count)
                        count += 1;
                    else
                        label1.Text = "Status: You Loose !";
                }
                catch (Exception exc) { }
            }
            if (count == 16)
                label1.Text = "Status: You Win !";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadGame();
        }
    }
}
