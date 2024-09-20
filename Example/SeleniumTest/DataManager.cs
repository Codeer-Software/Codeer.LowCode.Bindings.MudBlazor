using Npgsql;
using Dapper;

namespace SeleniumTest
{
    public static class DataManager
    {
        static string _connectionString;

        static DataManager()
        {
            var path = typeof(DataManager).Assembly.Location;
            for(int i = 0; i < 4; i++) path = Path.GetDirectoryName(path);
            _connectionString = File.ReadAllLines(Path.Combine(path!, "Config.txt"))[1];
        }

        public static void DeleteWriteDataControls()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "delete from write_data_controls";
                connection.Execute(sql);
            }
        }
        public static void DeleteWriteListDataControls()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "delete from write_list_data_controls";
                connection.Execute(sql);
                var sql2 = "delete from write_list_data";
                connection.Execute(sql2);
            }
        }
        public static void DeleteWriteDetailListDataControls()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "delete from write_list_data_controls";
                connection.Execute(sql);
                var sql2 = "delete from write_detail_list_data";
                connection.Execute(sql2);
            }
        }
        public static void DeleteWriteTileListDataControls()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "delete from write_list_data_controls";
                connection.Execute(sql);
                var sql2 = "delete from write_tile_list_data";
                connection.Execute(sql2);
            }
        }
    }
}
