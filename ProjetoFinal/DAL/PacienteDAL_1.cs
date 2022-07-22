using MySql.Data.MySqlClient;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.DAL
{
    public class PacienteDAL
    {
        private string connStr = BaseDAL.connStr;

        public int InserirPaciente(Paciente utente) { 

        int registro = 0;
        
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO paciente (nomePaciente, nif, cod_postal, localidade, contato, morada, data_nasc)" +
                            " VALUES (@nomePaciente, @nif, @cod_postal, @localidade, @contato, @morada, @data_nasc)";
            cmd.Parameters.AddWithValue("@nomePaciente", utente.nomePaciente);
            cmd.Parameters.AddWithValue("@nif", utente.nif);
            cmd.Parameters.AddWithValue("@cod_postal", utente.cod_postal);
            cmd.Parameters.AddWithValue("@localidade", utente.localidade);
            cmd.Parameters.AddWithValue("@contato", utente.contato);
            cmd.Parameters.AddWithValue("@morada", utente.morada);
            cmd.Parameters.AddWithValue("@data_nasc", utente.data_nasc);

            try //Tratamento de erro.
            {
                registro = cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex) //Exceção mais especialista tem que vir primeiro 
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return registro;

        }




        public List<Paciente> ListarTodosPacientes()
        {
            List<Paciente> lista_pacientes = new List<Paciente>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM paciente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader(); //Vou ler algo do BD

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lista_pacientes.Add(new Paciente(
                            Int32.Parse(read["idPaciente"].ToString()),
                            read["nomePaciente"].ToString(),
                            read["nif"].ToString(),
                            read["cod_postal"].ToString(),
                            read["localidade"].ToString(),
                            read["contato"].ToString(),
                            read["morada"].ToString(),
                            DateTime.Parse(read["data_nasc"].ToString())
                            ));
                    }
                }


            }
            catch (MySqlException ex) //Exceção mais especialista tem que vir primeiro 
            {
  
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostra uma mensagem com o erro...
               
            }
            finally
            {
                conn.Close();
            }




            return lista_pacientes;
        }

        public int BuscarPacienteEmConsulta(int idpaciente)
        {
            List<Paciente> lista_pacientes = new List<Paciente>();
            int registro = 0;
            string query = "SELECT idPaciente FROM consulta WHERE idPaciente=@idPaciente";
            try
            {

                using (MySqlConnection conn = new MySqlConnection(connStr)) //não necessito fechar a conexão por: The using declaration calls the Dispose method on the object in the correct way when it goes out of scope. 
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", idpaciente);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lista_pacientes.Add(new Paciente(
                                    Int32.Parse(reader["idPaciente"].ToString())
                                ));
                                    registro++;
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex) //Exceção mais especialista tem que vir primeiro 
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return registro;

        }



        public int EliminarPaciente(Paciente paciente)
        {
            int res = 0;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "DELETE FROM paciente WHERE idPaciente = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", paciente.idPaciente);
            
            int confirmarPacienteConsulta = BuscarPacienteEmConsulta(paciente.idPaciente);
            if (confirmarPacienteConsulta > 0)
            {
                    MessageBox.Show("Atenção você não pode eliminar um paciente com consulta marcada.\n", "Erro OsteoSpa", MessageBoxButtons.OK,
    MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    res = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex) //Exceção mais especialista tem que vir primeiro 
                {
                    MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostra uma mensagem com o erro...
                }
                finally
                {
                    conn.Close();
                }
            }



            return res;

        }

        public int Atualizar(Paciente paciente) { 
            int registo = 0;


            string query = @"UPDATE paciente SET nomePaciente=@nomePaciente, nif=@nif, cod_postal=@cod_postal, 
                               localidade=@localidade, contato=@contato, morada=@morada, data_nasc=@data_nasc WHERE idPaciente=@id";

            MySqlConnection conn = new MySqlConnection(connStr);

            MySqlCommand cmd = new MySqlCommand(query);
                    
            cmd.Connection = conn;
            conn.Open();

            cmd.Parameters.AddWithValue("@id", paciente.idPaciente);
            cmd.Parameters.AddWithValue("@nomePaciente", paciente.nomePaciente);
            cmd.Parameters.AddWithValue("@nif", paciente.nif);
            cmd.Parameters.AddWithValue("@cod_postal", paciente.cod_postal);
            cmd.Parameters.AddWithValue("@localidade", paciente.localidade);
            cmd.Parameters.AddWithValue("@contato", paciente.contato);
            cmd.Parameters.AddWithValue("@morada", paciente.morada);
            cmd.Parameters.AddWithValue("@data_nasc", paciente.data_nasc);

            try
            {
                registo = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex) //Exceção mais especialista tem que vir primeiro 
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostra uma mensagem com o erro...
            }
            finally
            {
                conn.Close();
            }

            return registo;
        }
        
    }
}


