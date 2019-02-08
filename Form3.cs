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
//DijkstraForm
namespace subway
{
    public partial class Form3 : Form
    {
        String sLine = "";
        String sStation = "";
        String eLine = "";
        String eStation = "";

        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
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
                                comboSL.Items.Add(reader[1].ToString());
                                comboTL.Items.Add(reader[1].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            SetDepStation();
            SetDesStation();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "순번";
            dataGridView1.Columns[1].Name = "역이름";
            dataGridView1.Columns[2].Name = "소요시간";
            dataGridView1.Columns[3].Name = "호선";
        }

        public void SetDepStation(String line, String station)
        {
            this.sLine = line;
            this.sStation = station;
            SetDepStation();
        }
        public void SetDepStation()
        {
            comboSL.SelectedIndex = comboSL.Items.IndexOf(sLine);
            comboSS.SelectedIndex = comboSS.Items.IndexOf(sStation);
        }


        public void SetDesStation(String line, String station)
        {
            this.eLine = line;
            this.eStation = station;
            SetDesStation();
        }
        public void SetDesStation()
        {
            comboTL.SelectedIndex = comboTL.Items.IndexOf(eLine);
            comboTS.SelectedIndex = comboTS.Items.IndexOf(eStation);
        }

        private void comboSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSS.Items.Clear();
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select b.statnnm from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + comboSL.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboSS.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                comboSS.SelectedIndex = 0;
            }
        }

        private void comboTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTS.Items.Clear();
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select b.statnnm from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + comboTL.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboTS.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                comboTS.SelectedIndex = 0;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 1)
                dataGridView1.Rows.Clear();
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                String result = "";
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT path.node, m_node.statnnm, path.agg_cost, m_linenm.linenm FROM " +
                    "(SELECT * FROM pgr_dijkstra('SELECT gid as id, source, target, cost FROM m_network', " +
                    "(select a.gid from m_node as a, m_linenm as b WHERE a.statnnm = '" + comboSS.SelectedItem.ToString() + "' and a.linenum = b.id and b.linenm = '" + comboSL.SelectedItem.ToString() + "' limit 1), " +
                    "(select a.gid from m_node as a, m_linenm as b WHERE a.statnnm = '" + comboTS.SelectedItem.ToString() + "' and a.linenum = b.id and b.linenm = '" + comboTL.SelectedItem.ToString() + "' limit 1), " +
                    "false)) as path, m_node, m_linenm WHERE path.node = m_node.gid AND m_linenm.id = m_node.linenum";
                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                count++;
                                string[] row0 = { count.ToString(), reader[1].ToString(), String.Format("{0:0.##}", Convert.ToDouble(reader[2].ToString())), reader[3].ToString() };
                                dataGridView1.Rows.Add(row0);
                               
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        String sId = "";
        String eId = "";
        Form2 frm2 = null;

        public void SetDep(String id)
        {
            this.sId = id;
        }

        public void SetDes(String id)
        {
            this.eId = id;
        }

        private void Btn_sInfo_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + comboSL.SelectedItem.ToString() + "' and b.statnnm = '" + comboSS.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sId = reader[0].ToString();
                                frm2 = new Form2("https://map.naver.com/local/siteview.nhn?stationId=" + sId);
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

        private void Btn_tInfo_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + comboTL.SelectedItem.ToString() + "' and b.statnnm = '" + comboTS.SelectedItem.ToString() + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                eId = reader[0].ToString();
                                frm2 = new Form2("https://map.naver.com/local/siteview.nhn?stationId=" + this.eId);
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

        private void webRoad_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=testdb"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "select * from (select b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + comboSL.SelectedItem.ToString() + "' and b.statnnm = '" + comboSS.SelectedItem.ToString() + "') as s_ID," +
                                                        "(select b.stationId from m_linenm as a, m_node as b where a.id = b.linenum and a.linenm = '" + comboTL.SelectedItem.ToString() + "' and b.statnnm = '" + comboTS.SelectedItem.ToString() + "') as t_ID";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.sId = reader[0].ToString();
                                this.eId = reader[1].ToString();
                                frm2 = new Form2("https://map.naver.com/?menu=subway&region=1000&departureId=" + this.sId + "&arrivalId=" + this.eId + "&pathType=1");
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
    }
}
