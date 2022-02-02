/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 17.05.2021
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PhaseManager
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxObjectNameEng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxObjectNameRus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLayoutNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamePhasePrefix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label7;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxObjectNameEng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxObjectNameRus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLayoutNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamePhasePrefix = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxComment);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxObjectNameEng);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxObjectNameRus);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxAuthor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxLayoutNumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNamePhasePrefix);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создание стадий";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(347, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать Стадии";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(318, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Коментарии";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(318, 96);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(150, 20);
            this.textBoxComment.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(162, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Название объекта(Eng.)";
            // 
            // textBoxObjectNameEng
            // 
            this.textBoxObjectNameEng.Location = new System.Drawing.Point(162, 96);
            this.textBoxObjectNameEng.Name = "textBoxObjectNameEng";
            this.textBoxObjectNameEng.Size = new System.Drawing.Size(150, 20);
            this.textBoxObjectNameEng.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название объекта(Рус.)";
            // 
            // textBoxObjectNameRus
            // 
            this.textBoxObjectNameRus.Location = new System.Drawing.Point(8, 96);
            this.textBoxObjectNameRus.Name = "textBoxObjectNameRus";
            this.textBoxObjectNameRus.Size = new System.Drawing.Size(150, 20);
            this.textBoxObjectNameRus.TabIndex = 3;
            this.textBoxObjectNameRus.Text = "Склад реагентов";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(476, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Создаваемые Стадии:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(320, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Разработчик:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(320, 43);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(150, 20);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(164, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер по генплану:";
            // 
            // textBoxLayoutNumber
            // 
            this.textBoxLayoutNumber.Location = new System.Drawing.Point(164, 43);
            this.textBoxLayoutNumber.Name = "textBoxLayoutNumber";
            this.textBoxLayoutNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxLayoutNumber.TabIndex = 3;
            this.textBoxLayoutNumber.Text = "6206";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Префикс названия стадии:";
            // 
            // textBoxNamePhasePrefix
            // 
            this.textBoxNamePhasePrefix.Location = new System.Drawing.Point(8, 43);
            this.textBoxNamePhasePrefix.MaxLength = 100;
            this.textBoxNamePhasePrefix.Name = "textBoxNamePhasePrefix";
            this.textBoxNamePhasePrefix.Size = new System.Drawing.Size(150, 20);
            this.textBoxNamePhasePrefix.TabIndex = 3;
            this.textBoxNamePhasePrefix.Text = "СР! ";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "сетка осей",
            "оборудование",
            "вспомогательная геометрия",
            "фундаменты",
            "плита пола",
            "колонны",
            "связи по колоннам",
            "балки перекрытий",
            "балки/фермы покрытий",
            "связи конструкций покрытий"});
            this.checkedListBox1.Location = new System.Drawing.Point(476, 35);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(382, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удаление стадий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 309);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhaseManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
