using System;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace softatex
{
    public partial class FrmGestao : Form
    {
        public FrmGestao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGestao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server = 127.0.0.1 ; Port = 3306 ;Database = base_sft ;User = root ;Password= ;"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes(nome, documento, rg, celular, nascimento, endereco, numerocasa, estado) VALUES (@nome, @doc, @rg, @celular, @nascimento, @endereco, @numerocasa, @estado)";

                    cmd.Parameters.AddWithValue("@nome", nomecliente.Text);

                    cmd.Parameters.AddWithValue("@doc", documento.Text);

                    cmd.Parameters.AddWithValue("@rg", rg.Text);

                    cmd.Parameters.AddWithValue("@celular", celular.Text);

                    cmd.Parameters.AddWithValue("@nascimento", nascimento.Text);

                    cmd.Parameters.AddWithValue("@endereco", endereco.Text);

                    cmd.Parameters.AddWithValue("@numerocasa", numerocasa.Text);

                    cmd.Parameters.AddWithValue("@estado", estado.Text);

                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Salvo");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}