﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai-filmes.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private string StringConexao = "Data Source=N-1S-DEV-17\\SQLEXPRESS;initial catalog=Filmes; userId=sa; pwd=sa@132;";

        public List<GeneroDomain> Listar()
        {
            List<GeneroDomain> gegneros = new List <GeneroDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = "SELECT Id_Genero, Nome FROM Genero";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(query, con));
                {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain
                        {
                            Id_Genero = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Nome"].ToString()
                        };

                        genero.Add(genero);
                    }
                }
            }

        return generos;
        }
    }
}