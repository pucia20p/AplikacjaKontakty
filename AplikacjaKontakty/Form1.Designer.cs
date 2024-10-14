namespace AplikacjaKontakty
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
            menuStrip1 = new MenuStrip();
            bazaToolStripMenuItem = new ToolStripMenuItem();
            nowaToolStripMenuItem = new ToolStripMenuItem();
            eddycjaRekorduToolStripMenuItem = new ToolStripMenuItem();
            dodajNowyRekordToolStripMenuItem = new ToolStripMenuItem();
            zapiszKontaktyToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            koniecToolStripMenuItem = new ToolStripMenuItem();
            opcjeToolStripMenuItem = new ToolStripMenuItem();
            wyszukiwanieKontaktuToolStripMenuItem = new ToolStripMenuItem();
            sortowaniePoImieniuToolStripMenuItem = new ToolStripMenuItem();
            sortowaniePoNazwiskuToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            dokumentacjaToolStripMenuItem = new ToolStripMenuItem();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { bazaToolStripMenuItem, opcjeToolStripMenuItem, pomocToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bazaToolStripMenuItem
            // 
            bazaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowaToolStripMenuItem, eddycjaRekorduToolStripMenuItem, dodajNowyRekordToolStripMenuItem, zapiszKontaktyToolStripMenuItem, toolStripSeparator1, koniecToolStripMenuItem });
            bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            bazaToolStripMenuItem.Size = new Size(43, 20);
            bazaToolStripMenuItem.Text = "Baza";
            // 
            // nowaToolStripMenuItem
            // 
            nowaToolStripMenuItem.Name = "nowaToolStripMenuItem";
            nowaToolStripMenuItem.Size = new Size(213, 22);
            nowaToolStripMenuItem.Text = "Nowa";
            nowaToolStripMenuItem.Click += nowaToolStripMenuItem_Click;
            // 
            // eddycjaRekorduToolStripMenuItem
            // 
            eddycjaRekorduToolStripMenuItem.Name = "eddycjaRekorduToolStripMenuItem";
            eddycjaRekorduToolStripMenuItem.Size = new Size(213, 22);
            eddycjaRekorduToolStripMenuItem.Text = "Edycja aktywnego rekordu";
            eddycjaRekorduToolStripMenuItem.Click += eddycjaRekorduToolStripMenuItem_Click;
            // 
            // dodajNowyRekordToolStripMenuItem
            // 
            dodajNowyRekordToolStripMenuItem.Name = "dodajNowyRekordToolStripMenuItem";
            dodajNowyRekordToolStripMenuItem.Size = new Size(213, 22);
            dodajNowyRekordToolStripMenuItem.Text = "Dodaj nowy rekord";
            dodajNowyRekordToolStripMenuItem.Click += dodajNowyRekordToolStripMenuItem_Click;
            // 
            // zapiszKontaktyToolStripMenuItem
            // 
            zapiszKontaktyToolStripMenuItem.Name = "zapiszKontaktyToolStripMenuItem";
            zapiszKontaktyToolStripMenuItem.Size = new Size(213, 22);
            zapiszKontaktyToolStripMenuItem.Text = "Zapisz kontakty";
            zapiszKontaktyToolStripMenuItem.Click += zapiszKontaktyToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(210, 6);
            // 
            // koniecToolStripMenuItem
            // 
            koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            koniecToolStripMenuItem.Size = new Size(213, 22);
            koniecToolStripMenuItem.Text = "Koniec";
            koniecToolStripMenuItem.Click += koniecToolStripMenuItem_Click;
            // 
            // opcjeToolStripMenuItem
            // 
            opcjeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wyszukiwanieKontaktuToolStripMenuItem, sortowaniePoImieniuToolStripMenuItem, sortowaniePoNazwiskuToolStripMenuItem });
            opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            opcjeToolStripMenuItem.Size = new Size(50, 20);
            opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // wyszukiwanieKontaktuToolStripMenuItem
            // 
            wyszukiwanieKontaktuToolStripMenuItem.Name = "wyszukiwanieKontaktuToolStripMenuItem";
            wyszukiwanieKontaktuToolStripMenuItem.Size = new Size(200, 22);
            wyszukiwanieKontaktuToolStripMenuItem.Text = "wyszukiwanie kontaktu";
            wyszukiwanieKontaktuToolStripMenuItem.Click += wyszukiwanieKontaktuToolStripMenuItem_Click;
            // 
            // sortowaniePoImieniuToolStripMenuItem
            // 
            sortowaniePoImieniuToolStripMenuItem.Name = "sortowaniePoImieniuToolStripMenuItem";
            sortowaniePoImieniuToolStripMenuItem.Size = new Size(200, 22);
            sortowaniePoImieniuToolStripMenuItem.Text = "sortowanie po imieniu";
            sortowaniePoImieniuToolStripMenuItem.Click += sortowaniePoImieniuToolStripMenuItem_Click;
            // 
            // sortowaniePoNazwiskuToolStripMenuItem
            // 
            sortowaniePoNazwiskuToolStripMenuItem.Name = "sortowaniePoNazwiskuToolStripMenuItem";
            sortowaniePoNazwiskuToolStripMenuItem.Size = new Size(200, 22);
            sortowaniePoNazwiskuToolStripMenuItem.Text = "sortowanie po nazwisku";
            sortowaniePoNazwiskuToolStripMenuItem.Click += sortowaniePoNazwiskuToolStripMenuItem_Click;
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dokumentacjaToolStripMenuItem, oProgramieToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // dokumentacjaToolStripMenuItem
            // 
            dokumentacjaToolStripMenuItem.Name = "dokumentacjaToolStripMenuItem";
            dokumentacjaToolStripMenuItem.Size = new Size(199, 22);
            dokumentacjaToolStripMenuItem.Text = "Instrukcja Obsługi";
            dokumentacjaToolStripMenuItem.Click += dokumentacjaToolStripMenuItem_Click;
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(199, 22);
            oProgramieToolStripMenuItem.Text = "Informacje o programie";
            oProgramieToolStripMenuItem.Click += oProgramieToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 424);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 27);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Imie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 54);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 83);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Nr Telefonu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 111);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 5;
            label4.Text = "Data Urodzenia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 27);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 54);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 83);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(367, 111);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem dokumentacjaToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private ToolStripMenuItem bazaToolStripMenuItem;
        private ToolStripMenuItem nowaToolStripMenuItem;
        private ToolStripMenuItem eddycjaRekorduToolStripMenuItem;
        private ToolStripMenuItem opcjeToolStripMenuItem;
        private ToolStripMenuItem wyszukiwanieKontaktuToolStripMenuItem;
        private ToolStripMenuItem sortowaniePoImieniuToolStripMenuItem;
        private ToolStripMenuItem sortowaniePoNazwiskuToolStripMenuItem;
        private ToolStripMenuItem dodajNowyRekordToolStripMenuItem;
        private ToolStripMenuItem zapiszKontaktyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem koniecToolStripMenuItem;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
