using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Loginv2.Models;

namespace Loginv2.Services
{
    class ServicesDB
    {
        SQLiteConnection conn;
        SQLiteConnection connTime;

        public string StatusMessage { set; get; }

        public ServicesDB(string dbPath)
        {
            if (dbPath == "") dbPath = App.DbPath;

            conn = new SQLiteConnection(dbPath);
            connTime = new SQLiteConnection(dbPath);
            conn.CreateTable<Cliente>();
            connTime.CreateTable<Jogos>();
        }

        public void CriarJogos(Jogos jogos)
        {
            connTime.Insert(jogos);
        }

        public void Inserir(Cliente cliente)
        {
            try
            {
                if (string.IsNullOrEmpty(cliente.Nome))
                {
                    throw new Exception("Nome do Cliente não informado.");
                }
                else if (string.IsNullOrEmpty(cliente.SobreNome))
                {
                    throw new Exception("Sobre nome não informado");
                }
                else if (string.IsNullOrEmpty(cliente.Email))
                {
                    throw new Exception("Por favor cadastre um email");
                }
                else if (string.IsNullOrEmpty(cliente.Senha))
                {
                    throw new Exception("Por favor cadastre uma senha");
                }
                else if (string.IsNullOrEmpty(cliente.ConfirmarSenha))
                {
                    throw new Exception("As senhas precisam ser iguais.");
                }
                else
                {
                    int result = conn.Insert(cliente);
                    if (result != 0)
                    {
                        this.StatusMessage = string.Format("{0} Registro(s) adcionado(s)", result);
                    }
                    else
                    {
                        this.StatusMessage = string.Format("Informe os dados pedidos.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                lista = conn.Table<Cliente>().ToList();
                this.StatusMessage = "Listagem dos Clientes";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return lista;
        }

        public List<Jogos> ListarTimes()
        {
            List<Jogos> game = new List<Jogos>();
            try
            {
                game = conn.Table<Jogos>().ToList();
                this.StatusMessage = "Listagem dos Clientes";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return game;
        }
    }
}
