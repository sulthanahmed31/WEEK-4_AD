namespace WEEK_4_AD
{
    public partial class Form1 : Form
    {
        List<string> pemainMU = new List<string>() {"David de Gea", "Victor Lindelof" , "Phil Jones", "Harry Maguire", "Lisandro Martinez",
        "Bruno Fernandez", "Anthony Martial", "Marcus Rashford", "Tyrell Malacia", "Christian Eriksen" , "Casemiro"};
        List<string> nomerMU = new List<string>() { "01", "02", "04", "05", "06", "08", "09", "10", "12", "14", "18" };
        List<string> posisiMU = new List<string>() { "GK", "DF", "DF", "DF", "DF", "MF", "FW", "FW", "DF", "MF", "MF" };

        List<string> pemainChelsea = new List<string>() {"Kepa Arrizabalaga", "Benoit Badiashile", "Enzo Fernandez", "Thiago Silva", "N'Golo Kante",
        "Mateo Kovacic", "Pierre-Emerick Aubameyang", "Christian Pulisic", "Joao Felix", "Ruben Loftus-Cheek", "Raheem Sterling"};
        List<string> nomerCH = new List<string>() { "01", "04", "05", "06", "07", "08", "09", "10", "11", "12", "17" };
        List<string> posisiCH = new List<string>() { "GK", "DF", "MF", "DF", "MF", "MF", "FW", "MF", "FW", "MF", "MF" };

        List<string> pemainBM = new List<string>() {"(01) Manuel Neuer, GK", "(02) Dayot Upamecano, DF", "(04) Matthijs de Ligt, DF", "(05) Benjamin Pavart, DF", "(06) Joshua Kimmich, MF",
        "(07) Serge Gnabry, FW", "(08) Leon Goretzka, MF", "(10) Leroy Sane, FW", "(14) Paul Wanner, MF", "(21) Lucas Hernandez, DF", "(25) Thomas Muller, FW"};
        List<string> nomerBM = new List<string>() { "01", "02", "04", "05", "06", "07", "08", "10", "14", "21", "25" };
        List<string> posisiBM = new List<string>() { "GK", "DF", "DF", "DF", "MF", "FW", "MF", "FW", "MF", "DF", "FW" };

        List<Class1> teamku = new List<Class1>();
        int count = 0;
        string passNegara = "";
        string passTim = "";
        public void updatenegara()
        {
            cb_country.Items.Clear();
            foreach (Class1 a in teamku)
            {
                count = 0;
                foreach (string b in cb_country.Items)
                {
                    if (a.Tempat == b)
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    cb_country.Items.Add(a.Tempat);
                }
            }
        }
        public void updatetim()
        {
            cb_team.Items.Clear();
            foreach (Class1 a in teamku)
            {
                if (a.Tempat == passNegara)
                {
                    cb_team.Items.Add(a.Nama);
                }
            }
        }
        public void updateplayer()
        {
            listBox1.Items.Clear();
            foreach (Class1 a in teamku)
            {
                if (a.Nama == passTim && a.Tempat == passNegara)
                {
                    foreach (player b in a.players)
                    {
                        listBox1.Items.Add($"({b.PlayerNumber}) {b.PlayerName}, {b.PlayerPosition}");
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button_team_Click(object sender, EventArgs e)
        {
            count = 0;
            if (nama_tim.Text == "" || nama_tempat.Text == "" || nama_kota.Text == "")
            {
                MessageBox.Show("Error please input first");
            }
            else
            {
                foreach (Class1 a in teamku)
                {
                    if (a.Nama == nama_tim.Text)
                    {
                        count = 1;
                    }
                }
                if (count == 1)
                {
                    MessageBox.Show("Error team already exists");
                }
                else
                {
                    Class1 teams = new Class1();
                    teams.Nama = nama_tim.Text;
                    teams.Tempat = nama_tempat.Text;
                    teams.Kota = nama_kota.Text;
                    teamku.Add(teams);
                }
                nama_tim.Clear();
                nama_tempat.Clear();
                nama_kota.Clear();
                updatenegara();
                updatetim();
            }
        }

        private void cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            passNegara = cb_country.SelectedItem.ToString();
            updatetim();
        }

        private void cb_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            passTim = cb_team.SelectedItem.ToString();
            updateplayer();
        }

        private void button_Player_Click(object sender, EventArgs e)
        {
            if (nama_pemain.Text == "" || nomor_pemain.Text == "" || posisi_pemain.SelectedItem == null)
            {
                MessageBox.Show("Error please input first");
            }
            else
            {
                if (cb_team.SelectedItem == null)
                {
                    MessageBox.Show("Please choose team");
                }
                else
                {
                    count = 0;
                    foreach (string b in listBox1.Items)
                    {
                        if (b == ($"({nomor_pemain.Text}) {nama_pemain.Text}, {posisi_pemain.SelectedItem.ToString()}"))
                        {
                            count = 1;
                        }
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Error player already exists");
                    }
                    else
                    {
                        foreach (Class1 a in teamku)
                        {
                            if (a.Nama == passTim && a.Tempat == passNegara)
                            {
                                player players = new player();
                                players.PlayerName = nama_pemain.Text;
                                players.PlayerNumber = nomor_pemain.Text;
                                players.PlayerPosition = posisi_pemain.SelectedItem.ToString();
                                a.nambah(players);
                            }
                        }
                    }
                    nama_pemain.Clear();
                    nomor_pemain.Clear();
                    posisi_pemain.Text = null;
                    updateplayer();
                }
            }

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 teams = new Class1();
            teams.Nama = "Manchester United";
            teams.Tempat = "England";
            teams.Kota = "London";
            for (int x = 0; x < 11; x++)
            {
                player players = new player();
                players.PlayerName  = pemainMU[x];
                players.PlayerNumber = nomerMU[x];
                players.PlayerPosition = posisiMU[x];
                teams.nambah(players);
            }
            teamku.Add(teams);

            teams = new Class1();
            teams.Nama = "Chelsea";
            teams.Tempat = "England";
            teams.Kota = "London";
            for (int x = 0; x < 11; x++)
            {
                player players = new player();
                players.PlayerName = pemainChelsea[x];
                players.PlayerNumber = nomerCH[x];
                players.PlayerPosition = posisiCH[x];
                teams.nambah(players);
            }
            teamku.Add(teams);
            teams = new Class1();
            teams.Nama = "Bayern Munich";
            teams.Tempat = "Germany";
            teams.Kota = "Germany";
            for (int x = 0; x < 11; x++)
            {
                player players = new player();
                players.PlayerName = pemainBM[x];
                players.PlayerNumber = nomerBM[x];
                players.PlayerPosition = posisiBM[x];
                teams.nambah(players);
            }
            teamku.Add(teams);
            updatenegara();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Error please choose player");
            }
            else
            {
                foreach (Class1 a in teamku)
                {
                    if (a.Tempat == passNegara && a.Nama == passTim)
                    {
                        if (a.players.Count > 11)
                        {
                            foreach (player b in a.players)
                            {
                                if (($"({b.PlayerNumber}) {b.PlayerName}, {b.PlayerPosition}") == listBox1.SelectedItem.ToString())
                                {
                                    a.players.Remove(b);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error players is 11");
                            break;
                        }
                    }
                }
                updateplayer();
            }
        }
    }
}