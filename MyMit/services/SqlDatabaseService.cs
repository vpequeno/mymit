using MyMit.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection;

namespace MyMit.services
{
	/*
	Classe utilizada como interface entre a app e a base de dados
	Esta classe contém todos os metodos oe funçoes necessarios para operaçoes na base de dados
	*/
	public class SqlDatabaseService
	{
		SqlConnection connection;

		public SqlDatabaseService()
		{
			String databaseIp = Properties.Settings.Default.DatabaseIP;
			String databaseUser = Properties.Settings.Default.DatabaseUser;
			String databasePassword = Properties.Settings.Default.DatabasePassword;
			String databaseName = Properties.Settings.Default.DatabaseName;

			connection = new SqlConnection("Server = "+ databaseIp + "; Database = " + databaseName + "; Uid = " + databaseUser + "; Pwd = " + databasePassword);
		}

		public SqlDatabaseService(string connectionString)
		{
			connection = new SqlConnection(connectionString);
		}

		public void ReadData(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Console.WriteLine(reader[0]);
					}
				}

			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
		}

		/// <summary>
		/// Executa query a base de dados
		/// </summary>
		/// <param name="databaseCommand">Uma String com a query a ser executada.</param>
		/// <returns>
		/// Retorna uma lista com elementos do tipo T 
		/// </returns>
		public List<T> GetData<T>(String databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);

				SqlDataReader reader = command.ExecuteReader();

				List<T> meetingList = new List<T>();
				meetingList = DataReaderMapToList<T>(reader);

				return meetingList;

			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
		}

		/// <summary>
		/// Executa comando de escrita na base de dados
		/// </summary>
		/// <param name="databaseCommand">Commando SQL</param>
		/// <returns>
		/// Retorna valor booleano - true se sucesso
		/// </returns>
		public bool WriteData(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}

			return true;
		}

		public void ReadFirstEntry(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);
				command.ExecuteScalar();
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}


		}

		/// <summary>
		/// Transforma um data set em um objeto List do tipo T
		/// </summary>
		/// <param name="dr">DataReder proveniente de uma query feita na base de dados</param>
		/// <returns>
		/// Retorna uma lista com elementos do tipo T
		/// </returns>
		public List<T> DataReaderMapToList<T>(IDataReader dr)
		{
			List<T> list = new List<T>();
			T obj = default(T);
			while (dr.Read())
			{
				obj = Activator.CreateInstance<T>();
				foreach (PropertyInfo prop in obj.GetType().GetProperties())
				{
					if (!object.Equals(dr[prop.Name], DBNull.Value))
					{
						prop.SetValue(obj, dr[prop.Name], null);
					}
				}
				list.Add(obj);
			}
			return list;
		}


	}
}