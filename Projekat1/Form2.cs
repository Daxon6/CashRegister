using Projekat1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("naziv", nazivKategorije.Text);
            Database.insert("INSERT INTO kategorije (naziv) VALUES (@naziv)", parametri);
            this.kategorijeTableAdapter.Fill(this.projekat_kasaDataSet.kategorije);
            nazivKategorije.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("naziv", nazivKategorije.Text);
            parametri.Add("id", listKategorija.SelectedValue.ToString());
            Database.update("UPDATE kategorije SET naziv=@naziv WHERE idKategorije=@id", parametri);
            this.kategorijeTableAdapter.Fill(this.projekat_kasaDataSet.kategorije);
            nazivKategorije.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("naziv", nazivKategorije.Text);
            Database.delete("DELETE FROM kategorije WHERE naziv=@naziv", parametri);
            this.kategorijeTableAdapter.Fill(this.projekat_kasaDataSet.kategorije);
            nazivKategorije.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("kategorija", comboBox1.SelectedValue.ToString());
            parametri.Add("naziv", nazivArtikla.Text);
            parametri.Add("cena", cenaArtikla.Text);
            parametri.Add("mera", mera.Text);
            Database.insert("INSERT INTO artikli (idKategorije, naziv, cena, mera, prodato) VALUES (@kategorija, @naziv, @cena, @mera, 0)", parametri);
            nazivArtikla.Clear();
            cenaArtikla.Clear();
            mera.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("kategorija", comboBox1.SelectedValue.ToString());
            parametri.Add("naziv", nazivArtikla.Text);
            parametri.Add("cena", cenaArtikla.Text);
            parametri.Add("mera", mera.Text);
            parametri.Add("idArtikla", listArtikala.SelectedValue.ToString());
            Database.insert("UPDATE artikli SET idKategorije=@kategorija, naziv=@naziv, cena=@cena, mera=@mera WHERE idArtikla=@idArtikla", parametri);
            nazivArtikla.Clear();
            cenaArtikla.Clear();
            mera.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("kategorija", comboBox1.SelectedValue.ToString());
            parametri.Add("naziv", nazivArtikla.Text);
            parametri.Add("cena", cenaArtikla.Text);
            parametri.Add("mera", mera.Text);
            Database.delete("DELETE FROM artikli WHERE idKategorije=@kategorija AND naziv=@naziv AND cena=@cena AND mera=@mera", parametri);
            nazivArtikla.Clear();
            cenaArtikla.Clear();
            mera.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projekat_kasaDataSet.kategorije' table. You can move, or remove it, as needed.
            this.kategorijeTableAdapter.Fill(this.projekat_kasaDataSet.kategorije);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Dictionary<string, string> parametri = new Dictionary<string, string>();
            parametri.Add("datum", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            var data = Database.select("SELECT artikli.naziv, SUM(racun_artikal.kolicina) AS prodato FROM artikli JOIN  racun_artikal ON racun_artikal.idArtikla = artikli.idArtikla JOIN  racuni ON racuni.idRacuna = racun_artikal.idRacuna WHERE racuni.datumKreiranja = @datum GROUP BY artikli.naziv", parametri);
            DataTable dt = new DataTable();
            dt.Load(data);

            int Y = 9;
            int i = 0;
            foreach(DataRow row in dt.Rows)
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("naziv", row.ItemArray[0].ToString());
                var data1 = Database.select("SELECT prodato FROM artikli WHERE naziv=@naziv", param);
                DataTable dt1 = new DataTable();
                dt1.Load(data1);

                var labela1 = new System.Windows.Forms.Label();
                var progressBar = new System.Windows.Forms.ProgressBar();
                var labela2 = new System.Windows.Forms.Label();

                this.panel1.Controls.Add(labela1);
                this.panel1.Controls.Add(progressBar);
                this.panel1.Controls.Add(labela2);

                labela1.AutoSize = true;
                labela1.Location = new System.Drawing.Point(445, Y+4);
                labela1.Name = "labelA" + i++;
                labela1.Size = new System.Drawing.Size(35, 13);
                labela1.TabIndex = 2;
                labela1.Text = row.ItemArray[1].ToString();

                progressBar.Location = new System.Drawing.Point(250, Y);
                progressBar.Name = "progressBar1";
                progressBar.Size = new System.Drawing.Size(189, 23);
                progressBar.TabIndex = 1;
                progressBar.Value = Convert.ToInt32(double.Parse(row.ItemArray[1].ToString()) / int.Parse(dt1.Rows[0].ItemArray[0].ToString()) * 100);

                labela2.AutoSize = true;
                labela2.Location = new System.Drawing.Point(26, Y+4);
                labela2.Name = "labelB" + i++;
                labela2.Size = new System.Drawing.Size(35, 13);
                labela2.TabIndex = 0;
                labela2.Text = row.ItemArray[0].ToString();

                Y += 30;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listArtikala.DataSource = null;
            listArtikala.DisplayMember = null;
            listArtikala.ValueMember = null;
            if(((ComboBox)sender).SelectedValue != null)
            {
                Dictionary<string, string> parametri = new Dictionary<string, string>();
                parametri.Add("id", ((ComboBox)sender).SelectedValue.ToString());
                var data = Database.select("SELECT idArtikla, naziv, cena, mera FROM artikli WHERE idKategorije=@id", parametri);
                DataTable dt = new DataTable();
                dt.Load(data);
                if (dt.Rows.Count > 0)
                {
                    listArtikala.DataSource = dt;
                    listArtikala.DisplayMember = "naziv";
                    listArtikala.ValueMember = "idArtikla";
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.kategorijeTableAdapter.Fill(this.projekat_kasaDataSet.kategorije);
        }
    }
}
