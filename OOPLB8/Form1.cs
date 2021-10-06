using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPLB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            char s = 'ф';
            string q = Interaction.InputBox("Напишіть слово з буквой ф: ", "Введення");
            string rez = $"Позиції букви ф в слові \n({q}): \n";
            foreach (char vova in q)
            {
                i++;
                if (s == vova) rez += $"{i} ";
            }
            MessageBox.Show(rez, "rezultat", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rez = "";
            string text = Interaction.InputBox("Введіть текст: ", "Введення");
            foreach (char num in text)
            {
                if (num == 'л') rez += $"лл";
                else if (num == 'н') rez += $"нн";
                else if (num == 'с') rez += $"сс";
                else if (num == 'о') rez += $"оо";
                else rez += num;
            }
            MessageBox.Show($"rezultat: {rez}", "rezultat", MessageBoxButtons.OK);
        }
    }
}
