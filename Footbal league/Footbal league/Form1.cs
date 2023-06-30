using Npgsql;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Footbal_league
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Football_League_db;User Id=postgres;Password=789012");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.Text;
            // comm.CommandText = richTextBox1.Text;
            if (richTextBox1.SelectedText != "")
            {
                comm.CommandText = richTextBox1.SelectedText;
            }
            else if (richTextBox1.Text != "")
            {
                comm.CommandText = richTextBox1.Text;
            }
            else
            {
                comm.CommandText = "SELECT * FROM match_event";
                richTextBox1.Text = "SELECT * FROM match_event";
            }

            try
            {
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                comm.Dispose();
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                label1.Text = "ERROR: The query could not execute.";
                label1.Visible = true;
                comm.Dispose();
                conn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Football_League_db;User Id=postgres;Password=789012");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "SELECT coach_first_name, coach_last_name FROM coach WHERE team_name = (SELECT base_team FROM program WHERE (match_id = 2) AND (base_team = 'Liverpool')) OR team_name = (SELECT offbase_team FROM program WHERE (match_id = 2) AND (offbase_team = 'Liverpool'));";
            //comm.CommandText = "SELECT * FROM player;";
            try
            {
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                comm.Dispose();
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                label1.Text = "ERROR: The query could not execute.";
                label1.Visible = true;
                comm.Dispose();
                conn.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Football_League_db;User Id=postgres;Password=789012");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "SELECT event, timestamp, player_first_name, player_last_name FROM match_event WHERE (match_id = 2) AND ((event = 'goal') OR (event = 'penalty'));";
            try
            {
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                comm.Dispose();
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                label1.Text = "ERROR: The query could not execute.";
                label1.Visible = true;
                comm.Dispose();
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Football_League_db;User Id=postgres;Password=789012");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.Text;
            //δεν τρέχει γιτατί δεν έχω τα triggers ακόμα
            comm.CommandText = "SELECT SUM(goals) AS total_goals, SUM(penalty) AS total_penalties, SUM(red_card) AS total_red_cards, SUM(yellow_card) AS total_yellow_cards, SUM(minutes_active) AS total_minutes_active FROM player_match_statistics WHERE (first_name = 'Γιώργος') AND (last_name = 'Κοτσάνης') AND match_id IN (SELECT match_id FROM program WHERE (match_date >= '2010-09-01') AND match_date <= '2011-05-31');";
            try
            {
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                comm.Dispose();
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                label1.Text = "ERROR: The query could not execute.";
                label1.Visible = true;
                comm.Dispose();
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Football_League_db;User Id=postgres;Password=789012");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.Text;
            comm.CommandText = "";
            try
            {
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                comm.Dispose();
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                label1.Text = "ERROR: The query could not execute.";
                label1.Visible = true;
                comm.Dispose();
                conn.Close();
            }
        }
    }
}