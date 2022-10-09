using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace memopad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//일정저장 버튼
        {
            if (textBox1.Text != "") {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)//완료 버튼
        {
            if (listBox1.Text != null) {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)//미완료 버튼
        {
            if (listBox2.Text != null)
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Items.Remove(listBox2.Text);
            }

        }

        private void button4_Click(object sender, EventArgs e) //일정 삭제
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(" 만든이: 김산하  2102110700  AI융합소프트웨어학과\nC# 기말고사 과제", "프로그램 정보",
                MessageBoxButtons.OK,(MessageBoxIcon.Information));
        }

        private void 내보내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                StreamWriter sw;
                sw = new StreamWriter("memopad.txt");
                int count = listBox1.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    listBox1.Items[i] += "\n"; sw.Write(listBox1.Items[i]);
                }
                sw.Close();             
                Process.Start("memopad.txt");
            }
        }

        private void 인터페이스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 백그라운드컬러ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void 폰트설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            button1.Font = fontDialog1.Font;
            button2.Font = fontDialog1.Font;
            button3.Font = fontDialog1.Font;
            button4.Font = fontDialog1.Font;
            listBox1.Font = fontDialog1.Font;
            listBox2.Font = fontDialog1.Font;
            label1.Font = fontDialog1.Font;
            label2.Font = fontDialog1.Font;
            label3.Font = fontDialog1.Font;
            menuStrip1.Font = fontDialog1.Font;
        }

        /*private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일 (*.txt) |*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

            listBox1.Items.Add(textBox1.Text);
            string route = openFileDialog1.InitialDirectory;

            string[] lines = File.ReadAllLines(route);
            foreach (string show in lines)
            {
                Console.WriteLine("{0}", show);
                listBox1.Items.Add(File.ReadAllLines("*.txt"));
                textBox1.Text = "";
            }*/
    }
}



