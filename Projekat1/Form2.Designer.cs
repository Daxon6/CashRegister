namespace Projekat1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listKategorija = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nazivKategorije = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listArtikala = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mera = new System.Windows.Forms.TextBox();
            this.cenaArtikla = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nazivArtikla = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projekat_kasaDataSet = new Projekat1.Projekat_kasaDataSet();
            this.projekat_kasaDataSet1 = new Projekat1.Projekat_kasaDataSet();
            this.kategorijeTableAdapter = new Projekat1.Projekat_kasaDataSetTableAdapters.kategorijeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekat_kasaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekat_kasaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 414);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listKategorija);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.nazivKategorije);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ažuriranje kategorija";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listKategorija
            // 
            this.listKategorija.DataSource = this.bindingSource1;
            this.listKategorija.DisplayMember = "naziv";
            this.listKategorija.FormattingEnabled = true;
            this.listKategorija.Location = new System.Drawing.Point(308, 26);
            this.listKategorija.Name = "listKategorija";
            this.listKategorija.Size = new System.Drawing.Size(181, 342);
            this.listKategorija.TabIndex = 5;
            this.listKategorija.ValueMember = "idKategorije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv kategorije";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Obrisi kategoriju";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Izmeni kategoriju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj kategoriju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nazivKategorije
            // 
            this.nazivKategorije.Location = new System.Drawing.Point(6, 60);
            this.nazivKategorije.Name = "nazivKategorije";
            this.nazivKategorije.Size = new System.Drawing.Size(289, 20);
            this.nazivKategorije.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listArtikala);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.mera);
            this.tabPage2.Controls.Add(this.cenaArtikla);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.nazivArtikla);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ažuriranje artikala";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listArtikala
            // 
            this.listArtikala.FormattingEnabled = true;
            this.listArtikala.Location = new System.Drawing.Point(248, 24);
            this.listArtikala.Name = "listArtikala";
            this.listArtikala.Size = new System.Drawing.Size(240, 342);
            this.listArtikala.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 277);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Obriši artikal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Izmeni artikal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dodaj artikal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jedinica mere artikla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv artikla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorija:";
            // 
            // mera
            // 
            this.mera.Location = new System.Drawing.Point(6, 181);
            this.mera.Name = "mera";
            this.mera.Size = new System.Drawing.Size(227, 20);
            this.mera.TabIndex = 3;
            // 
            // cenaArtikla
            // 
            this.cenaArtikla.Location = new System.Drawing.Point(6, 143);
            this.cenaArtikla.Name = "cenaArtikla";
            this.cenaArtikla.Size = new System.Drawing.Size(227, 20);
            this.cenaArtikla.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "idKategorije";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nazivArtikla
            // 
            this.nazivArtikla.Location = new System.Drawing.Point(6, 100);
            this.nazivArtikla.Name = "nazivArtikla";
            this.nazivArtikla.Size = new System.Drawing.Size(227, 20);
            this.nazivArtikla.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(500, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pregled statistike";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 307);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "kategorije";
            this.bindingSource1.DataSource = this.projekat_kasaDataSet;
            // 
            // projekat_kasaDataSet
            // 
            this.projekat_kasaDataSet.DataSetName = "Projekat_kasaDataSet";
            this.projekat_kasaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projekat_kasaDataSet1
            // 
            this.projekat_kasaDataSet1.DataSetName = "Projekat_kasaDataSet";
            this.projekat_kasaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeTableAdapter
            // 
            this.kategorijeTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Administracija";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekat_kasaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekat_kasaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nazivKategorije;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mera;
        private System.Windows.Forms.TextBox cenaArtikla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nazivArtikla;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listKategorija;
        private System.Windows.Forms.ListBox listArtikala;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Projekat_kasaDataSet projekat_kasaDataSet;
        private Projekat_kasaDataSet projekat_kasaDataSet1;
        private Projekat_kasaDataSetTableAdapters.kategorijeTableAdapter kategorijeTableAdapter;
    }
}