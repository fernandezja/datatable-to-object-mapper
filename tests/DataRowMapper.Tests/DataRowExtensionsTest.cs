using Starwars.Entities;
using System.Data;
using Xunit;

namespace DataRowMapper.Tests
{
    public class DataRowExtensionsTest
    {
        [Fact]
        public void DataRowToObjectSimple()
        {
            var jedisDataTable = GenerateJediDataTable();

            var jediDataRow = jedisDataTable.Rows[0];

            var jedi = jediDataRow.ToObject<Jedi>();

            Assert.NotNull(jedi);
            Assert.Equal(1, jedi.Id);
            Assert.Equal("Yoda", jedi.Name);
        }

        private DataTable GenerateJediDataTable() {

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
