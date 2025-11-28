using Projekat1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class Form3 : Form
    {
        List<Artikal> listaArtikala = new List<Artikal>();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaArtikala.Clear();
            cene.Clear();
            textBox2.Clear();
            textBox3.Clear();
            panel2.Controls.Clear();
            listBox1.Items.Clear();
            foreach (var btn in panel3.Controls)
            {
                ((Button)btn).Enabled = false;
            }

        }

        List<int> cene = new List<int>();

        int ukupno;
        private void button3_Click(object sender, EventArgs e)
        {
            ukupno = racun;
            racun = 0;
            label1.Text = racun.ToString() + ",00 rsd";

            textBox2.Clear();
            tabControl1.SelectTab(tabPage2);
            int i = 0;
            foreach(string item in listBox1.Items)
            {
                int kraj = item.LastIndexOf(" " + listaArtikala[i].mera);
                int br = int.Parse(item.Substring(listaArtikala[i].naziv.Length + 1, kraj - listaArtikala[i].naziv.Length - 1));
                int cena = br * listaArtikala[i].cena;
                cene.Add(cena);
                textBox2.Text += listaArtikala[i++].naziv.PadRight(35, ' ') + cena.ToString() + Environment.NewLine;
            }
            textBox2.Text += "-".PadRight(50, '-') + Environment.NewLine + "Ukupno" + Environment.NewLine + ukupno + ",00";
            listBox1.Items.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var data = Database.select("SELECT naziv, idKategorije FROM kategorije", new Dictionary<string, string>());

            var dt = new DataTable();
            dt.Load(data);

            var pozX = 3;
            foreach(DataRow dr in dt.Rows)
            {
                var novoDugme = new System.Windows.Forms.Button();
                this.panel1.Controls.Add(novoDugme);
                novoDugme.BackColor = System.Drawing.Color.RosyBrown;
                novoDugme.Location = new System.Drawing.Point(pozX, 3);
                novoDugme.Name = "button" + dr.ItemArray[1];
                novoDugme.Size = new System.Drawing.Size(102, 83);
                pozX += 102;
                novoDugme.TabIndex = 0;
                novoDugme.Text = dr.ItemArray[0].ToString();
                novoDugme.UseVisualStyleBackColor = false;
            }

            foreach(var btn in panel1.Controls)
            {
                ((Button)btn).Click += Form3_Click;
            }

            Database.closeConnection();
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            if (((Button)sender).Text == "Alkoholna pića" && DateTime.Now.Hour >= 18)
            {
                MessageBox.Show("Nije dozvoljeno prodavanje alkoholnih pića nakon 22h");
                StreamWriter wr = File.AppendText("upozorenje.txt");
                wr.WriteLine("Prodaja alkoholnog pića nakon 22h " + DateTime.Now.ToString("G"));
                wr.Close();
            }
            else
            {

                Dictionary<string, string> parametri = new Dictionary<string, string>();
                var id = ((Button)sender).Name.Substring(6);
                parametri.Add("id", id);

                var data = Database.select("SELECT naziv, idArtikla FROM artikli WHERE idKategorije=@id", parametri);


                var dt = new DataTable();
                dt.Load(data);

                var pozX = 3;
                var pozY = 3;
                foreach (DataRow dr in dt.Rows)
                {
                    var novoDugme = new System.Windows.Forms.Button();
                    this.panel2.Controls.Add(novoDugme);
                    novoDugme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                    if (pozX > 365)
                    {
                        pozX = 3;
                        pozY += 83;
                    }
                    novoDugme.Location = new System.Drawing.Point(pozX, pozY);
                    pozX += 91;
                    novoDugme.Name = "button" + dr.ItemArray[1];
                    novoDugme.Size = new System.Drawing.Size(91, 83);
                    novoDugme.TabIndex = 0;
                    novoDugme.Text = dr.ItemArray[0].ToString();
                    novoDugme.UseVisualStyleBackColor = false;
                }
                foreach (var btn in panel2.Controls)
                {
                    ((Button)btn).Click += Form3_Click1;
                }
                Database.closeConnection();
            }
        }

        private void Form3_Click1(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            var id = ((Button)sender).Name.Substring(6);
            parametri.Add("id", id);

            var data = Database.select("SELECT idArtikla, naziv, idKategorije, cena, mera FROM artikli WHERE idArtikla=@id", parametri);

            var dt = new DataTable();
            dt.Load(data);

            DataRow dr = dt.Rows[0];

            listaArtikala.Add(new Artikal(int.Parse(dr[0].ToString()), dr[1].ToString(), int.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()), dr[4].ToString()));

            textBox3.Text = dr[1].ToString();
            Database.closeConnection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "")
            {
                textBox3.Text += " X ";
                foreach (var btn in panel3.Controls)
                {
                    ((Button)btn).Enabled = true;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            foreach (var btn in panel3.Controls)
            {
                ((Button)btn).Enabled = false;
            }
        }

        int racun = 0;
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int br;
                if (listaArtikala.Last().naziv.Length < textBox3.Text.Length && textBox3.Text.Length != textBox3.Text.LastIndexOf(" ") + 1)
                {
                    br = int.Parse(textBox3.Text.Substring(listaArtikala.Last().naziv.Length + 3));
                }
                else
                {
                    br = 1;
                }
                listBox1.Items.Add(listaArtikala.Last().naziv + "(" + br + " " + listaArtikala.Last().mera + ")");
                racun += br * listaArtikala.Last().cena;
                textBox3.Clear();
                foreach (var btn in panel3.Controls)
                {
                    ((Button)btn).Enabled = false;
                }
                label1.Text = racun.ToString() + ",00 rsd";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text += ((Button)sender).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text += ((Button)sender).Text;
            ((Button)sender).Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                racun -= listaArtikala[listBox1.SelectedIndex].cena;
                label1.Text = racun.ToString() + ",00 rsd";
                listaArtikala.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("ukupno", ukupno.ToString());
            parametri.Add("datum", DateTime.Now.ToString("yyyy-MM-dd"));
            Database.insert("INSERT INTO racuni (ukupanIznos, datumKreiranja) VALUES(@ukupno, @datum)", parametri);
            var data = Database.select("SELECT TOP 1 idRacuna FROM racuni ORDER BY idRacuna DESC", new Dictionary<string, string>());
            var dt = new DataTable();
            dt.Load(data);
            int i = 0;
            foreach(Artikal art in listaArtikala)
            {
                Dictionary<string, string> noviParametri = new Dictionary<string, string>();
                noviParametri.Add("racun", dt.Rows[0].ItemArray[0].ToString());
                noviParametri.Add("artikal", art.id.ToString());
                noviParametri.Add("kolicina", (cene[i]/art.cena).ToString());
                Database.insert("INSERT INTO racun_artikal (idRacuna, idArtikla, kolicina) VALUES(@racun, @artikal, @kolicina)", noviParametri);
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("kolicina", (cene[i++] / art.cena).ToString());
                param.Add("id", art.id.ToString());
                Database.update("UPDATE artikli SET prodato = prodato + @kolicina WHERE idArtikla = @id", param);
            }
            listaArtikala.Clear();
            cene.Clear();
            textBox2.Clear();
            textBox3.Clear();
            panel2.Controls.Clear();
            listBox1.Items.Clear();
            foreach (var btn in panel3.Controls)
            {
                ((Button)btn).Enabled = false;
            }
        }


    }
}
