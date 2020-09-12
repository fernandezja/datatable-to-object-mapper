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
            

            DemoSimpleDataRowToObjectJedi();

            Console.WriteLine("Please any key to continue...");
            Console.ReadKey();
        }

        private static void DemoSimpleDataRowToObjectJedi() {

            Console.WriteLine("Demo Simple: DataRow to Jedi object");

            var jedisDataTable = new DataTable("Jedis");

            jedisDataTable.Columns.Add("Id", typeof(int));
            jedisDataTable.Columns.Add("Name", typeof(string));

            jedisDataTable.Rows.Add(1, "Yoda");

            var jediDataRow = jedisDataTable.Rows[0];

            var jedi = jediDataRow.ToObject<Jedi>();

            Console.WriteLine($"Jedi: Id={jedi.Id} Name={jedi.Name}");

        }
    }
}
