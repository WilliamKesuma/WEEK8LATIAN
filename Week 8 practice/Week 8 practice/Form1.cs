using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Week_8_practice
{
    
    public partial class Form1 : Form
    {
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand; //menerima perintah query // select+form itu
        MySqlDataAdapter mySqlDataAdapter; //menerima hasil dari query // hasil dari selection
        string connectionString;
        string sqlquery;
        DataTable dt = new DataTable();
        DataTable dtnationality = new DataTable();
        DataTable dtteamname = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlconnect = new MySqlConnection(connectionString);
            // sqlconnect.Open(); // hanya digunakan ketika kalian lakukan DML

            sqlquery = "select player_id as 'Player ID', player_name as 'Player Name', height 'Player Height', team_name as 'Team Name'\r\nfrom player inner join team\r\n on player.team_id = team.team_id\r\n;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dt);
            DGV_pemain.DataSource = dt;

            sqlquery = "SELECT abv as 'abrevation', nation as 'Nation' FROM nationality";
            sqlcommand = new MySqlCommand(sqlquery,sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtnationality);
            CB_Nationality.DataSource = dtnationality;
            CB_Nationality.ValueMember = "Nation";
            CB_Nationality.DisplayMember = "abrevation";

            sqlquery = "SELECT team_name as 'Team Name' FROM team";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtteamname);
            CB_KANAN.DataSource = dtteamname;
            CB_KANAN.DisplayMember = "Team Name";
            CB_KANAN.ValueMember = "Team Name";
        }



        private void CB_Nationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_ValueMember.Text = CB_Nationality.SelectedValue.ToString();
        }

        private void CB_KANAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtteamname = new DataTable();
            sqlquery = "select player_id as 'Player ID', player_name as 'Player Name', height 'Player Height', team_name as 'Team Name'\r\nfrom player inner join team\r\non player.team_id = team.team_id\r\nwhere team_name  = '" + CB_KANAN.SelectedValue.ToString() + "';";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtteamname);
            DGV_pemain.DataSource = dtteamname;
        }
    }
}
