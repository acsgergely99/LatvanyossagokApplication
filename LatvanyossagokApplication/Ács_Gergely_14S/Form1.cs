using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLApp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=filmdb;Uid=root;Pwd=;Port=3307;");
            conn.Open();

            RendezoListazas();
            
            
        }
        void RendezoListazas()
        {
            RendezoListBox.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,nev,szuletes,szarmazas FROM rendezok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var szuletes = reader.GetDateTime("szuletes");
                    var szarmazas = reader.GetString("szarmazas");
                    var rendezo = new Rendezo(id,nev,szuletes,szarmazas);
                    RendezoListBox.Items.Add(rendezo);
                } 
            }
        }

        private void RendezoHozzaadButton_Click(object sender, EventArgs e)
        {
            
            var cmd = conn.CreateCommand();
            cmd.CommandText = " INSERT INTO rendezok (nev,szuletes,szarmazas) VALUES (@nev,@szuletes,@szarmazas)";
            cmd.Parameters.AddWithValue("@nev", nevTextBox.Text);
            cmd.Parameters.AddWithValue("@szuletes", SzuletesDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@nev", szarmazasTextBox.Text);

            cmd.ExecuteNonQuery();

            RendezoListazas();
        }

        private void rendezoTorlesButton_Click(object sender, EventArgs e)
        {
            if (RendezoListBox.SelectedIndex==-1)
            {
                MessageBox.Show("Nincs kiválasztva elem!");
                return;    
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText= "DELETE FROM rendezok WHERE id = @id";

            var rendezo = (Rendezo)RendezoListBox.SelectedItem;
            cmd.Parameters.AddWithValue("@id", rendezo.Id);

            cmd.ExecuteNonQuery();

            RendezoListazas();
        }
        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmListBox.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,cim,kiadas,hossz,rendezo_id FROM filmek ORDER BY cim";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var kiadas = reader.GetDateTime("kiadas");
                    var hossz = reader.GetInt32("hossz");
                    var rendezoid = reader.GetString("rendezo_id");
                    var film = new Film(id, cim, kiadas, hossz,rendezoid);
                    FilmListBox.Items.Add(film);
                }
            }
        }

        private void RendezoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        
    }
}
