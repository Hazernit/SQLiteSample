using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Data;
using System.IO;

namespace SQLiteSample
{
    public partial class Form1 : Form
    {
        string dbFileName = "students.db";
        SQLiteConnection m_dbConn;
        SQLiteCommand m_sqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            m_dbConn.Open();
            m_sqlCmd = new SQLiteCommand(m_dbConn);

            MessageBox.Show("Connected");
        }

        private void btRead_Click(object sender, EventArgs e)
        {

            if (m_dbConn == null)
            {
                MessageBox.Show("Сначала нажми Connect");
                return;
            }

            DataTable dTable = new DataTable();
            string sqlQuery = "SELECT * FROM student";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
            adapter.Fill(dTable);

            dataGridView1.DataSource = dTable;

            //DataTable dTable = new DataTable();
            //string sqlQuery = "SELECT * FROM student";

            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
            //adapter.Fill(dTable);

            //dataGridView1.DataSource = dTable;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (m_dbConn == null || m_sqlCmd == null)
            {
                MessageBox.Show("Сначала нажми Connect");
                return;
            }

            string fio = textBoxFio.Text.Trim();
            string gr = textBoxGr.Text.Trim();

            if (fio == "" || gr == "")
            {
                MessageBox.Show("Введите ФИО и группу");
                return;
            }

            if (!int.TryParse(gr, out int groupId))
            {
                MessageBox.Show("Группа должна быть числом");
                return;
            }

            m_sqlCmd.CommandText = $"INSERT INTO student (fio, gr) VALUES ('{fio}', {groupId})";
            m_sqlCmd.ExecuteNonQuery();

            DataTable dTable = new DataTable();
            string sqlQuery = "SELECT * FROM student";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
            adapter.Fill(dTable);
            dataGridView1.DataSource = dTable;

            textBoxFio.Clear();
            textBoxGr.Clear();

            MessageBox.Show("Added");

            // -------------------- СНИЗУ РАБОЧИЙ ВАРИАНТ ----------------
            //if (m_dbConn == null || m_sqlCmd == null)
            //{
            //    MessageBox.Show("Сначала нажми Connect");
            //    return;
            //}

            //string fio = textBoxFio.Text.Trim();
            //string gr = textBoxGr.Text.Trim();

            //if (fio == "" || gr == "")
            //{
            //    MessageBox.Show("Введите ФИО и группу");
            //    return;
            //}

            //if (!int.TryParse(gr, out int groupId))
            //{
            //    MessageBox.Show("Группа должна быть числом");
            //    return;
            //}

            //m_sqlCmd.CommandText = $"INSERT INTO student (fio, gr) VALUES ('{fio}', {groupId})";
            //m_sqlCmd.ExecuteNonQuery();

            //MessageBox.Show("Added");
            //------------------СВЕРХУ РАБОЧИЙ ВАР УПРОЩЕННЫЙ БЕЗ ВЫВОДА СРАЗУ------------

            //string fio = textBoxFio.Text;
            //string gr = textBoxGr.Text;

            //m_sqlCmd.CommandText = $"INSERT INTO student (fio, gr) VALUES ('{fio}', {gr})";
            //m_sqlCmd.ExecuteNonQuery();

            //MessageBox.Show("Added");

            //string fio = textBoxFio.Text.Trim();
            //string gr = textBoxGr.Text.Trim();

            //if (fio == "" || gr == "")
            //{
            //    MessageBox.Show("Введите ФИО и группу");
            //    return;
            //}

            //m_sqlCmd.CommandText = $"INSERT INTO student (fio, gr) VALUES ('{fio}', {gr})";
            //m_sqlCmd.ExecuteNonQuery();

            //MessageBox.Show("Added");

        }

        private void btCount_Click(object sender, EventArgs e)
        {
            if (m_dbConn == null || m_sqlCmd == null)
            {
                MessageBox.Show("Сначала нажми Connect");
                return;
            }

            m_sqlCmd.CommandText = "SELECT COUNT(*) FROM student";
            int count = Convert.ToInt32(m_sqlCmd.ExecuteScalar());

            MessageBox.Show("Количество студентов: " + count);
        }
    }
}
