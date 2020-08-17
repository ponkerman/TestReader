using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System;
using System.Xml.Linq;

namespace TestReader
{
    
    class Base
    {
        private string dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        public enum Sections
        {
            file_path,
            prerequisites,
            description,
            result
        };

        public Base()
        {
            dbFileName = @"F:\Projects\TestReader\base.sql"; // put' k base
            m_dbConn = new SQLiteConnection(); // connection
            m_sqlCmd = new SQLiteCommand(); // dlya comand
        }

        public int AddTLG(string path)
        {
            int fileCounter = 0;
            CreateBase();
            foreach (string file in Directory.GetFiles(path, "*.tlg", SearchOption.AllDirectories))
            {
                AddFile(file);
                fileCounter++;
            }
            return fileCounter;
        }

        private void CreateBase()
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                //soedinenie
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                // zapros na sozdanie tablic
                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS FileTable (id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                                              "file_name TEXT," +
                                                                              "prerequisites TEXT, " +
                                                                              "test_description TEXT, " +
                                                                              "test_result TEXT)";
                m_sqlCmd.ExecuteNonQuery();                

                MessageBox.Show("Connected");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Disconnected. Error: " + ex.Message);
            }
        }

        private void AddFile(string file_name)
        {
            try
            {
                m_sqlCmd.CommandText = "INSERT INTO FileTable ('file_name') values ('" + file_name + "')";

                m_sqlCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ReadData()
        {
            DataTable dTable = new DataTable();
            string sqlQuery;

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("no connection with database");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM FileTable";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        ReadFile(dTable.Rows[i].Field<string>("file_name"));
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Done");

        }

        private void ReadFile(string path)
        {
            var doc = XDocument.Load(path);

            string prerequisites_str = "";
            string test_description_str = "";
            string test_result_str = "";

            foreach (var child in doc.Root.Elements())
            {
                if (child.Name == "prerequisites")
                {
                    //Console.WriteLine("{0}: {1}", child.Name, child.Value);
                    prerequisites_str = child.Value;
                }
                if (child.Name == "test_description")
                {
                    //Console.WriteLine("{0}: {1}", child.Name, child.Value);
                    test_description_str = child.Value;
                }
                if (child.Name == "test_result")
                {
                    //Console.WriteLine("{0}: {1}", child.Name, child.Value);
                    test_result_str = child.Value;
                }
            }
            //Console.WriteLine(prerequisites_str, test_description_str, test_result_str);
            WriteData(prerequisites_str, test_description_str, test_result_str, path);
        }

        private void WriteData(string prerequisites, string description, string result, string path)
        {
            Console.WriteLine(prerequisites + '\n' + description + '\n' + result + '\n');
            try
            {
                m_sqlCmd.CommandText = "UPDATE FileTable SET " +
                                       "prerequisites = '" + prerequisites + "', " +
                                       "test_description = '" + description + "', " +
                                       "test_result = '" + result + "'" +
                                       "WHERE file_name = '" + path + "'";
                m_sqlCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        public DataTable Search(string file_path, string prerequisites, string description, string result)
        {
            DataTable dTable = new DataTable();
            string sqlQuery;

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("no connection with database");
                return dTable;
            }
            
            try
            {
                sqlQuery = "select * " +
                           "from FileTable " +
                           "where " +
                           "file_path like '" + file_path + "' and " +
                           "prerequisites like '" + prerequisites + "' and " +
                           "test_description like '" + description + "' and " +
                           "test_result like '" + result + "'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            
            return dTable;
        }
    }
}
