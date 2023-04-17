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
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand; 
        MySqlDataAdapter mySqlDataAdapter;
        string connectionString;
        string sqlquery;
        DataTable dtTeamPlayers = new DataTable();
        DataTable dtTeamManager = new DataTable();
        DataTable dtMatch = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void tEAMDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            DGV_Team_manager.Visible = true;
            DGV_Team_Players.Visible = true;

            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlconnect = new MySqlConnection(connectionString);

            // table 1
            sqlquery = "select player_name as 'Player Name', team_name as 'Team Name', playing_pos as 'Position', weight as 'Weight', height as 'Height' from player inner join team on player.team_id = team.team_id;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtTeamPlayers);
            DGV_Team_Players.DataSource = dtTeamPlayers;

            sqlquery = "SELECT team_name as 'Team Name' FROM team";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtTeamPlayers);
            CB_SelectTeam.DataSource = dtTeamPlayers;
            CB_SelectTeam.ValueMember = "Team Name";
            CB_SelectTeam.DisplayMember = "Team Name";

            //table 2
            sqlquery = "select team_name as 'Team Name', manager_name as 'Manager Name', birthdate as 'Birthday', nation as 'nationality'\r\nfrom team, manager, nationality\r\nwhere team.manager_id = manager.manager_id and manager.nationality_id = nationality.nationality_id;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtTeamManager);
            DGV_Team_manager.DataSource = dtTeamManager;
        }



        private void tEAMMATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DGV_Team_manager.Visible = false;
            DGV_Team_Players.Visible = false;
            sqlquery = "select player_name as 'Player Name', team_name as 'Team Name', playing_pos as 'Position', weight as 'Weight', height as 'Height' from player inner join team on player.team_id = team.team_id;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtTeamPlayers);
            DGV_Team_Players.DataSource = dtTeamPlayers;
        }

        private void CB_SelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtTeamPlayers = new DataTable();
            sqlquery = "select player_name as 'Player Name', team_name as 'Team Name', playing_pos as 'Position', weight as 'Weight', height as 'Height' from player inner join team on player.team_id = team.team_id where team_name  = '" + CB_SelectTeam.SelectedValue.ToString() + "';";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtTeamPlayers);
            DGV_Team_Players.DataSource = dtTeamPlayers;

            dtTeamManager = new DataTable();
            sqlquery = "select team_name as 'Team Name', manager_name as 'Manager Name', birthdate as 'Birthday', nation as 'nationality' from team, manager, nationality where team.manager_id = manager.manager_id and manager.nationality_id = nationality.nationality_id and team_name  = '" + CB_SelectTeam.SelectedValue.ToString() + "';";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtTeamManager);
            DGV_Team_manager.DataSource = dtTeamManager;

            dtMatch = new DataTable();
            sqlquery = "select match_date, t1.team_name as 'team home', t2.team_name as 'team away', goal_home, goal_away, referee_name as 'Referee Name'\r\nfrom `match`, team t1, referee, team t2\r\nwhere `match`.team_home = t1.team_id and `match`.referee_id = referee.referee_id and `match`.team_away = t2.team_id and (t1.team_name  = '" + CB_SelectTeam.SelectedValue.ToString() + "' or t2.team_name  = '" + CB_SelectTeam.SelectedValue.ToString() + "');";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mySqlDataAdapter = new MySqlDataAdapter(sqlcommand);
            mySqlDataAdapter.Fill(dtMatch);
            dataGridView1.DataSource = dtMatch;
        }
    }
}
