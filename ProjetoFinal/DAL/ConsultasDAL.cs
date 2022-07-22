




using MySql.Data.MySqlClient;
using ProjetoFinal.Handlers;
using ProjetoFinal.Models;

namespace ProjetoFinal.DAL
{
    public class ConsultasDAL
    {
        private string connStr = BaseDAL.connStr;


        public int InserirConsulta(Consulta consul)
        {
            int registro = 0;
            string query = "INSERT INTO consulta (idMedico, idPaciente, data, hora)" +
                            "VALUES(@idMedico, @idPaciente, @data, @hora)";
            
            using(MySqlConnection conn = new MySqlConnection(connStr)) //não necessito fechar a conexão por: The using declaration calls the Dispose method on the object in the correct way when it goes out of scope. 
            {
                
                using(MySqlCommand cmd = conn.CreateCommand()) //  conn.CreateCommand() = new MySqlCommand(query)  +  cmd.Connection = conn;
                {
                    //cmd.Connection = conn;
                    cmd.CommandText = query;
                    conn.Open(); //Abro a minha base de dados
                    

                     //add os dados da minha classe ao banco de dados 
                    cmd.Parameters.AddWithValue("@idMedico", consul.idMedico);
                    cmd.Parameters.AddWithValue("@idPaciente", consul.idPaciente);
                    cmd.Parameters.AddWithValue("@data", consul.data);
                    cmd.Parameters.AddWithValue("@hora", consul.hora);


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
               
                }
            }
            

            return registro;
        }


        public List<Especialidade> ListarEspecialidades()
        {

            List<Especialidade> lista_especialidade = new List<Especialidade>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM especialidade";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader(); //Vou ler algo do BD

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lista_especialidade.Add(new Especialidade(
                            Int32.Parse(read["id"].ToString()),
                            read["nome"].ToString() 
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
            return lista_especialidade;
        }


        public List<Medico> ListarMedico(int id_especi)
        {

            List<Medico> lista_medico = new List<Medico>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM medico WHERE especialidadeMedico = @especialidadeMedico";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@especialidadeMedico", id_especi);
                MySqlDataReader read = cmd.ExecuteReader(); //Vou ler algo do BD

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lista_medico.Add(new Medico(
                            Int32.Parse(read["idMedico"].ToString()),
                            read["nomeMedico"].ToString(),
                            read["cedula"].ToString(),
                            Int32.Parse(read["especialidadeMedico"].ToString())
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
            return lista_medico;
        }

        public List<Consulta> ListarTodasConsultas()
        {
            List<Consulta> lista_consultas = new List<Consulta>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM consulta AS c , medico AS m , especialidade AS e, paciente AS p WHERE c.idMedico = m.idMedico AND m.especialidadeMedico = e.id AND p.idPaciente=c.idPaciente;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader(); //Vou ler algo do BD

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lista_consultas.Add(new Consulta(
                            Int32.Parse(read["idConsulta"].ToString()),
                            read["nomePaciente"].ToString(),
                            read["nif"].ToString(),
                            DateTime.Parse(read["data_nasc"].ToString()),
                            read["morada"].ToString(),
                            read["cod_postal"].ToString(),
                            read["localidade"].ToString(),
                            read["nomeMedico"].ToString(),
                            read["cedula"].ToString(),
                            read["nome"].ToString(),
                            DateTime.Parse(read["data"].ToString()),
                            read["hora"].ToString()
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



            return lista_consultas;
        }


        public List<Consulta> FiltrarConsultaPaciente(int idPaciente, int idMedico, int idEsp, string query)
        {
            List<Consulta> listaConsultasFiltradas = new List<Consulta>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                if (idPaciente > 0) cmd.Parameters.AddWithValue("@idConsulta", idPaciente);
                if(idMedico > 0) cmd.Parameters.AddWithValue("@idMedico", idMedico);
                if(idEsp > 0) cmd.Parameters.AddWithValue("@id", idEsp);

               

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listaConsultasFiltradas.Add(new Consulta(
                            Int32.Parse(reader["idConsulta"].ToString()),
                            reader["nomePaciente"].ToString(),
                            reader["nif"].ToString(),
                            DateTime.Parse(reader["data_nasc"].ToString()),
                            reader["morada"].ToString(),
                            reader["cod_postal"].ToString(),
                            reader["localidade"].ToString(),
                            reader["nomeMedico"].ToString(),
                            reader["cedula"].ToString(),
                            reader["nome"].ToString(),
                            DateTime.Parse(reader["data"].ToString()),
                            reader["hora"].ToString()
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

            return listaConsultasFiltradas;
        }


        public int EliminarConsulta(Consulta consulta)
        {
            int res = 0;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = "DELETE FROM consulta WHERE idConsulta = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", consulta.id);

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


            return res;

        }

    }
}
