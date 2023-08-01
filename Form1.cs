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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace animais
{ 
    public partial class animais: Form
    {
        public animais()
        {
            InitializeComponent();
        }


            private void animais_Load(object sender, EventArgs e)
            {
            }

            private void button1_Click(object sender, EventArgs e)
            {
                MySqlConnection conn1 = new MySqlConnection("server=localhost:81, 127.0.0.1;username=root;database=adotapet1;password=");
                MySqlCommand cmd = new MySqlCommand("INSERT INTO animais (Nome, Especie, idade, Sexo, Porte, Comportamento, Sobre_Pet, Cidade, Estado, Id_Ong, Id_Protetor) VALUES (@Nome, @Especie, @Idade, @Sexo, @Porte, @Comportamento, @Sobrepet, @Cidade, @Estado, @Id_Ong, @Id_Protetor);", conn1);
                conn1.Open();
                

                cmd.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Especie", textBoxEspecie.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }
                cmd.Parameters.AddWithValue("@Idade", textBoxIdade.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }


                cmd.Parameters.AddWithValue("@Sexo", textBoxSexo.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Porte", textBoxPorte.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Comportamento", textBoxComportamento.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Sobrepet", textBoxSobrepet.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Cidade", textBoxCidade.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Estado", textBoxEstado.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Id_Ong", textBoxIdong.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }

                cmd.Parameters.AddWithValue("@Id_Protetor", textBoxIdprotetor.Text);
                if (textBoxNome.Text == "")
                {
                MessageBox.Show("Por favor, insira um nome no campo!");
                textBoxNome.Focus();
                return;
                }





                int rowAffected = cmd.ExecuteNonQuery();
                conn1.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir dados!");
                }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            Email.Clear();
            Cpf.Clear();
            textBoxTelefone.Clear();
            textBoxEndereco.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxEstado.Clear();
            textBoxSenha.Clear();
        }
    }
}
    

