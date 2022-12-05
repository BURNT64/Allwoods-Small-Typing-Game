using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allwoods_Typing_Game_2021
{
    public partial class Form1 : Form
    {
        string[] words = { "Intellegent", "Programming", "location", "Geography", "Science", "Technology", "Taxi", "Fortress", "Sniper", "Multiverse", "England", "Homunculus", "Greed", "lust", "Triumph", "Spaghetti"};

        Random rnd = new Random();

        int correct = 0;
        int incorrect = 0;

        public Form1()
        {
            InitializeComponent();

            LBLWord.Text = words[rnd.Next(0,words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text == LBLWord.Text)
                {
                    correct++;
                    LBLWord.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                else
                {
                    incorrect++;
                    LBLWord.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                LBLCorrect.Text = "correct:" + correct;
                LBLIncorrect.Text = "incorrect:" + incorrect;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
