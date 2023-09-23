namespace OtoparkFromApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            lst_liste = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(lst_liste);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araçlar";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1.Sınıf Araçlar", "2.Sınıf Araçlar", "3.Sınıf Araçlar" });
            checkedListBox1.Location = new Point(6, 13);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(249, 58);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lst_liste
            // 
            lst_liste.FormattingEnabled = true;
            lst_liste.ItemHeight = 15;
            lst_liste.Location = new Point(6, 77);
            lst_liste.Name = "lst_liste";
            lst_liste.Size = new Size(249, 319);
            lst_liste.TabIndex = 1;
            lst_liste.SelectedIndexChanged += lst_liste_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 1;
            label1.Text = "Yıkanacak aracı seçiniz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 68);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 1;
            label2.Text = "Lastik değişimi istenen aracı seçiniz";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 124);
            label3.Name = "label3";
            label3.Size = new Size(210, 15);
            label3.TabIndex = 1;
            label3.Text = "Beygir gücü hesaplanacak aracı seçiniz";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 180);
            label4.Name = "label4";
            label4.Size = new Size(188, 15);
            label4.TabIndex = 1;
            label4.Text = "Ücret hesaplaması için araç seçiniz";
            label4.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(589, 25);
            button1.Name = "button1";
            button1.Size = new Size(245, 23);
            button1.TabIndex = 3;
            button1.Text = "Yıkamaya Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(589, 68);
            button2.Name = "button2";
            button2.Size = new Size(245, 23);
            button2.TabIndex = 3;
            button2.Text = "Lastik Değiştir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(589, 124);
            button3.Name = "button3";
            button3.Size = new Size(245, 23);
            button3.TabIndex = 3;
            button3.Text = "Beygir Hesapla";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(589, 177);
            button4.Name = "button4";
            button4.Size = new Size(245, 23);
            button4.TabIndex = 3;
            button4.Text = "Ücret Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 445);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Otopark Sistem Ekranı";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lst_liste;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}