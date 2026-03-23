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
        //string dbFileName = "students.db";
        //SQLiteConnection m_dbConn;
        //SQLiteCommand m_sqlCmd;
        string dbFileName = "";
        SQLiteConnection m_dbConn;
        SQLiteCommand m_sqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (dbFileName == "")
            {
                MessageBox.Show("Сначала выбери БД");
                return;
            }

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd = new SQLiteCommand(m_dbConn);

                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }

            //m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            //m_dbConn.Open();
            //m_sqlCmd = new SQLiteCommand(m_dbConn);

            //MessageBox.Show("Connected");
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

        private void LoadAllStudents()
        {
            if (m_dbConn == null)
            {
                MessageBox.Show("Сначала выбери и подключи БД");
                return;
            }

            DataTable dTable = new DataTable();
            string sqlQuery = "SELECT * FROM student";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
            adapter.Fill(dTable);

            dataGridView1.DataSource = dTable;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (m_dbConn == null || m_sqlCmd == null)
            {
                MessageBox.Show("Сначала подключи БД");
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

            m_sqlCmd.CommandText = "INSERT INTO student (fio, gr) VALUES (@fio, @gr)";
            m_sqlCmd.Parameters.Clear();
            m_sqlCmd.Parameters.AddWithValue("@fio", fio);
            m_sqlCmd.Parameters.AddWithValue("@gr", groupId);
            m_sqlCmd.ExecuteNonQuery();

            LoadAllStudents();

            textBoxFio.Clear();
            textBoxGr.Clear();

            MessageBox.Show("Студент добавлен");

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

            //DataTable dTable = new DataTable();
            //string sqlQuery = "SELECT * FROM student";
            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
            //adapter.Fill(dTable);
            //dataGridView1.DataSource = dTable;

            //textBoxFio.Clear();
            //textBoxGr.Clear();

            //MessageBox.Show("Added");

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

        private void btChooseDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQLite database (*.db)|*.db|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbFileName = ofd.FileName;
                MessageBox.Show("Выбрана БД:\n" + dbFileName);
            }
        }

        private void btReadAll_Click(object sender, EventArgs e)
        {
            if (m_dbConn == null)
            {
                MessageBox.Show("Сначала выбери и подключи БД");
                return;
            }

            DataTable dTable = new DataTable();
            string sqlQuery = "SELECT * FROM student";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
            adapter.Fill(dTable);

            dataGridView1.DataSource = dTable;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (m_dbConn == null || m_sqlCmd == null)
            {
                MessageBox.Show("Сначала подключи БД");
                return;
            }

            string id = textBoxId.Text.Trim();
            string fio = textBoxFio.Text.Trim();
            string gr = textBoxGr.Text.Trim();

            if (id == "" || fio == "" || gr == "")
            {
                MessageBox.Show("Введите ID, ФИО и группу");
                return;
            }

            if (!int.TryParse(id, out int studentId))
            {
                MessageBox.Show("ID должен быть числом");
                return;
            }

            if (!int.TryParse(gr, out int groupId))
            {
                MessageBox.Show("Группа должна быть числом");
                return;
            }

            m_sqlCmd.CommandText = "UPDATE student SET fio = @fio, gr = @gr WHERE id = @id";
            m_sqlCmd.Parameters.Clear();
            m_sqlCmd.Parameters.AddWithValue("@fio", fio);
            m_sqlCmd.Parameters.AddWithValue("@gr", groupId);
            m_sqlCmd.Parameters.AddWithValue("@id", studentId);
            m_sqlCmd.ExecuteNonQuery();

            LoadAllStudents();

            MessageBox.Show("Запись изменена");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (m_dbConn == null || m_sqlCmd == null)
            {
                MessageBox.Show("Сначала подключи БД");
                return;
            }

            string id = textBoxId.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("Введите ID для удаления");
                return;
            }

            if (!int.TryParse(id, out int studentId))
            {
                MessageBox.Show("ID должен быть числом");
                return;
            }

            m_sqlCmd.CommandText = "DELETE FROM student WHERE id = @id";
            m_sqlCmd.Parameters.Clear();
            m_sqlCmd.Parameters.AddWithValue("@id", studentId);
            m_sqlCmd.ExecuteNonQuery();

            LoadAllStudents();

            MessageBox.Show("Запись удалена");
        }

        private void btByGroup_Click(object sender, EventArgs e)
        {
            if (m_dbConn == null)
            {
                MessageBox.Show("Сначала подключи БД");
                return;
            }

            string gr = textBoxGr.Text.Trim();

            if (gr == "")
            {
                MessageBox.Show("Введите номер группы");
                return;
            }

            if (!int.TryParse(gr, out int groupId))
            {
                MessageBox.Show("Группа должна быть числом");
                return;
            }

            DataTable dTable = new DataTable();
            string sqlQuery = "SELECT * FROM student WHERE gr = @gr";

            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, m_dbConn);
            cmd.Parameters.AddWithValue("@gr", groupId);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dTable);

            dataGridView1.DataSource = dTable;
        }

        private void btByFaculty_Click(object sender, EventArgs e)
        {
            if (m_dbConn == null)
            {
                MessageBox.Show("Сначала подключи БД");
                return;
            }

            string facultyName = textBoxFaculty.Text.Trim();

            if (facultyName == "")
            {
                MessageBox.Show("Введите название факультета");
                return;
            }

            DataTable dTable = new DataTable();

            string sqlQuery = @"
        SELECT student.id, student.fio, student.gr
        FROM student
        JOIN ""group"" ON student.gr = ""group"".id
        JOIN faculty ON ""group"".faculty = faculty.id
        WHERE faculty.name = @facultyName";

            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, m_dbConn);
            cmd.Parameters.AddWithValue("@facultyName", facultyName);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dTable);

            dataGridView1.DataSource = dTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                textBoxFio.Text = dataGridView1.Rows[e.RowIndex].Cells["fio"].Value.ToString();
                textBoxGr.Text = dataGridView1.Rows[e.RowIndex].Cells["gr"].Value.ToString();
            }
        }
    }

    
    }
