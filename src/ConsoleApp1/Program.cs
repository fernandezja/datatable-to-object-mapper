using Starwars.Entities;
using System;
using System.Data;
using DataRowMapper;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataRow to Object!");

            DemoManualDataRowToObjectJedi();

            DemoSimpleAutomaticDataRowToObjectJedi();

            Console.WriteLine("Please any key to continue...");
            Console.ReadKey();
        }


        private static void DemoManualDataRowToObjectJedi()
        {
            Console.WriteLine("Demo Manual: DataRow to Jedi object");

            var jedisDataTable = GenerateJedisDataTable();

            DataRow jediDataRow = jedisDataTable.Rows[0];

            var jedi = new Jedi() { 
                Id = Convert.ToInt32(jediDataRow["Id"]),
                Name = Convert.ToString(jediDataRow["Name"]),
            };

            Console.WriteLine($"Jedi: Id={jedi.Id} Name={jedi.Name}");

        }


        private static void DemoSimpleAutomaticDataRowToObjectJedi()
        {
            Console.WriteLine("Demo Simple Automatic: DataRow to Jedi object");

            var jedisDataTable = GenerateJedisDataTable();

            DataRow jediDataRow = jedisDataTable.Rows[0];

            var jedi = jediDataRow.ToObject<Jedi>();

            Console.WriteLine($"Jedi: Id={jedi.Id} Name={jedi.Name}");

        }


        private static DataTable GenerateJedisDataTable()
        {
            var dataTable = new DataTable("Jedis");

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));


            dataTable.Rows.Add(1, "Yoda");
            dataTable.Rows.Add(2, "Mace Windu");
            dataTable.Rows.Add(3, "Count Dooku");
            dataTable.Rows.Add(4, "Qui-Gon Jinn");
            dataTable.Rows.Add(5, "Obi-Wan Kenobi");
            dataTable.Rows.Add(6, "Anakin Skywalker");
            dataTable.Rows.Add(7, "Ahsoka Tano");
            dataTable.Rows.Add(8, "Cal Kestis");
            dataTable.Rows.Add(9, "Cere Junda");
            dataTable.Rows.Add(10, "Kanan Jarrus");
            dataTable.Rows.Add(11, "Ezra Bridger");
            dataTable.Rows.Add(12, "Luke Skywalker");
            dataTable.Rows.Add(13, "Ben Solo");
            dataTable.Rows.Add(14, "Rey");

            return dataTable;
        }

   
    }
}
