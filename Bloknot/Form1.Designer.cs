namespace Bloknot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наклонныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.выровнитьСлеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнитьПоЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнитьСправаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.CreateNewDocument);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.OnCutClick);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.OnPasteClick);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.жирныйТекстToolStripMenuItem,
            this.наклонныйТекстToolStripMenuItem,
            this.обычныйТекстToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.OnFontClick);
            // 
            // жирныйТекстToolStripMenuItem
            // 
            this.жирныйТекстToolStripMenuItem.Name = "жирныйТекстToolStripMenuItem";
            this.жирныйТекстToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.жирныйТекстToolStripMenuItem.Text = "Жирный Текст";
            this.жирныйТекстToolStripMenuItem.Click += new System.EventHandler(this.OnBoldClick);
            // 
            // наклонныйТекстToolStripMenuItem
            // 
            this.наклонныйТекстToolStripMenuItem.Name = "наклонныйТекстToolStripMenuItem";
            this.наклонныйТекстToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.наклонныйТекстToolStripMenuItem.Text = "Наклонный Текст";
            this.наклонныйТекстToolStripMenuItem.Click += new System.EventHandler(this.OnItalicClick);
            // 
            // обычныйТекстToolStripMenuItem
            // 
            this.обычныйТекстToolStripMenuItem.Name = "обычныйТекстToolStripMenuItem";
            this.обычныйТекстToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.обычныйТекстToolStripMenuItem.Text = "Обычный Текст";
            this.обычныйТекстToolStripMenuItem.Click += new System.EventHandler(this.OnRegularClick);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выровнитьСлеваToolStripMenuItem,
            this.выровнитьПоЦентруToolStripMenuItem,
            this.выровнитьСправаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 426);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // выровнитьСлеваToolStripMenuItem
            // 
            this.выровнитьСлеваToolStripMenuItem.Name = "выровнитьСлеваToolStripMenuItem";
            this.выровнитьСлеваToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.выровнитьСлеваToolStripMenuItem.Text = "Выровнить слева";
            this.выровнитьСлеваToolStripMenuItem.Click += new System.EventHandler(this.OnLeftClick);
            // 
            // выровнитьПоЦентруToolStripMenuItem
            // 
            this.выровнитьПоЦентруToolStripMenuItem.Name = "выровнитьПоЦентруToolStripMenuItem";
            this.выровнитьПоЦентруToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.выровнитьПоЦентруToolStripMenuItem.Text = "Выровнить по центру";
            this.выровнитьПоЦентруToolStripMenuItem.Click += new System.EventHandler(this.OnCenterClick);
            // 
            // выровнитьСправаToolStripMenuItem
            // 
            this.выровнитьСправаToolStripMenuItem.Name = "выровнитьСправаToolStripMenuItem";
            this.выровнитьСправаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.выровнитьСправаToolStripMenuItem.Text = "Выровнить справа";
            this.выровнитьСправаToolStripMenuItem.Click += new System.EventHandler(this.OnRightClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem жирныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наклонныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнитьСлеваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнитьПоЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнитьСправаToolStripMenuItem;
    }
}

