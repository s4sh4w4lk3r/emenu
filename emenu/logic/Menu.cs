using MySql.Data.MySqlClient;

namespace emenu
{

    class Menu
    {
        /// <summary>
        /// Represent object of menu.
        /// </summary>
        public int id {get;}
        public string? name {get;}       
        public string? desc {get;}      
        public decimal price {get;}
        public string? picture {get;}

        public Menu(int id)
        {

            if (id < 1) {MessageBox.Show("The item does not exist"); return;}
            var connection = SQLDB.connection;
            connection?.Open();
            string query = $"SELECT * FROM menu WHERE ID = {id}";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                this.id = id;
                name = reader[1].ToString();
                desc = reader[2].ToString();
                decimal.TryParse(reader[3].ToString(), out decimal internalPrice); price = internalPrice;
                picture = reader[4].ToString();
                break;
            }
            reader.Close(); 
            connection?.Close();
        }
    }
}