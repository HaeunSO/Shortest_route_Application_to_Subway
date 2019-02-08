using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
//mainForm
namespace subway
{
    public partial class Form1 : Form
    {
        Form3 frm3 = null;

        public Form1()
        {
            InitializeComponent();
            frm3 = new Form3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select * from m_linenm";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListBox_line.Items.Add(reader[1].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            ListBox_line.SelectedIndex = 0;
        }

        private void ListBox_line_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox_subway.Items.Clear();
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select b.statnnm from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + ListBox_line.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListBox_subway.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Btn_info_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + ListBox_line.SelectedItem.ToString() + "' and b.statnnm = '" + ListBox_subway.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                String station = reader[0].ToString();
                                Form2 frm2 = new Form2("https://map.naver.com/local/siteview.nhn?stationId=" + station);
                                frm2.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Btn_dijk_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnDepStation_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select a.linenm, b.statnnm, b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + ListBox_line.SelectedItem.ToString() + "' and b.statnnm = '" + ListBox_subway.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                String s_line = reader[0].ToString();
                                String s_station = reader[1].ToString();
                                String s_stationId = reader[2].ToString();

                                if (frm3.Visible == false)
                                {
                                    frm3 = new Form3();
                                    frm3.SetDepStation(s_line, s_station);
                                    frm3.SetDep(s_stationId);
                                    frm3.Show();
                                    
                                }
                                else
                                {
                                    frm3.SetDepStation(s_line, s_station);
                                    frm3.SetDep(s_stationId);
                                    frm3.Invalidate();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnDesStation_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select a.linenm, b.statnnm, b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + ListBox_line.SelectedItem.ToString() + "' and b.statnnm = '" + ListBox_subway.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                String t_line = reader[0].ToString();
                                String t_station = reader[1].ToString();
                                String t_stationId = reader[2].ToString();
                                
                                if (frm3.Visible == false)
                                {
                                    frm3 = new Form3();
                                    frm3.SetDesStation(t_line, t_station);
                                    frm3.SetDes(t_stationId);
                                    frm3.Show();
                                }
                                else
                                {
                                    frm3.SetDesStation(t_line, t_station);
                                    frm3.SetDes(t_stationId);
                                    frm3.Invalidate();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}