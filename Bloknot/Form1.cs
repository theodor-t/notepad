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

namespace Bloknot
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool isFileChanged;

        public Form1()
        {
            InitializeComponent();

            Init();
        }

        public void Init() 
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();

        }

        public void CreateNewDocument(object sender, EventArgs e) 
        {
            SaveUnsavedFile();
            textBox1.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                }
            }
            UpdateTextWithTitle();
        }
        public void SaveFile(string _filename)
        {
            if(_filename == "")
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename + ".txt");
                sw.Write(textBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить файл!");
            }
            UpdateTextWithTitle();
        }
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }
        public void UpdateTextWithTitle()
        {
            if (filename!="") 
                this.Text = filename + " - Блокнот";
            else this.Text = "Безымянный" + " - Блокнот";
            
        }
        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }
        public void CopyText()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart,textBox1.SelectionLength);
        }
        public void PasteText()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length-textBox1.SelectionStart);
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void OnFontClick(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void OnBoldClick(object sender, EventArgs e)
        {
            String s = textBox1.SelectedText;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            textBox1.SelectedText = s;
        }

        private void OnItalicClick(object sender, EventArgs e)
        {
            String s = textBox1.SelectedText;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            textBox1.SelectedText = s;
        }

        private void OnRegularClick(object sender, EventArgs e)
        {
            String s = textBox1.SelectedText;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox1.SelectedText = s;
        }

        private void OnLeftClick(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void OnCenterClick(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void OnRightClick(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void OnBackgroundClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Создал Цуркану Тудор | vk.com/erlax_official", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
