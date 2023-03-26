using MySql.Data.MySqlClient;

namespace emenu
{
    class Menu // these objects are needed for cashier and self-service
    {
        public int id {get;} // id of this product
        public string? name {get;} // product name
        public string? description {get;} // product description
        public decimal price {get;} // product price
        public string? picture {get;} // link to the product picture
        public Menu() {} //zaglushka
        public Menu(int id) //a object "product" is created by id from the database
        {

            if (id < 1) {MessageBox.Show("The item does not exist"); return;} // exit method if bad ID
            var connection = new MySqlConnection(SQLDB.connString);
            connection?.Open();
            string query = $"SELECT * FROM menu WHERE ID = {id}";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            this.id = id;
            name = reader[1].ToString();
            description = reader[2].ToString();
            decimal.TryParse(reader[3].ToString(), out decimal internalPrice); price = internalPrice;
            picture = reader[4].ToString();

            reader.Close(); 
            connection?.Close();
        }
        public static List<Menu> GetMenuList() //gets all menus form database
        {
            List<Menu> menuList = new List<Menu>();
            MySqlConnection connection = new MySqlConnection(SQLDB.connString);

            connection.Open();
            string select = "SELECT * FROM menu;";
            MySqlCommand command = new MySqlCommand(select, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int.TryParse(reader[0].ToString(), out int menuID);
                menuList.Add(new Menu(menuID));
            }
            
            reader.Close(); 
            connection.Close();
            return menuList;
        }
        public static Dictionary<int, string> IDsNamesDict { get; private set; } = new Dictionary<int, string>();
        public static void FillMenuDict()
        {   
            List<Menu> menuList = GetMenuList();
            Menu.IDsNamesDict.Add(0, string.Empty);
            foreach (var item in menuList)
            {
                Menu.IDsNamesDict.Add(item.id, item.name ?? string.Empty);
            }
        }
    }
}