using MySql.Data.MySqlClient;

namespace emenu
{
    class Menu // these objects are needed for cashier and self-service
    {
        public int id {get;} // id of this product
        public string? name {get;} // product name
        public string? desc {get;} // product description
        public decimal price {get;} // product price
        public string? picture {get;} // link to the product picture
        public Menu(int id) //a object "product" is created by id from the database
        {

            if (id < 1) {MessageBox.Show("The item does not exist"); return;} // exit method if bad ID
            var connection = new MySqlConnection(SQLDB.connString);
            connection?.Open();
            string query = $"SELECT * FROM menu WHERE ID = {id}";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) // only one cycle iteration
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