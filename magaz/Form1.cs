using MySql.Data.MySqlClient;
using System.Data;

namespace magaz
{
    public partial class MainForm : Form
    {

        string connectionString = "server=localhost;database=magazine;user=root;password=;";
        private bool is_edit = false;
        private int editProductId = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProductsPanel.Enabled = false;
            LoadProductsData();
            LoadOrdersData();
            LoadCategories();
            LoadProductsIntoComboBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //**************ТОВАРЫ************************
        //Функция для подгрузки данных из таблицы Products, с учетом названия категории, с нормальным отображением полей
        private void LoadProductsData()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Запрос с JOIN, чтобы получить название категории
                    string query = @"
                    SELECT 
                        Products.id, 
                        Products.name, 
                        Products.description, 
                        Products.price, 
                        Categories.name AS category_name 
                    FROM Products
                    JOIN Categories ON Products.category_id = Categories.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Привязываем данные к DataGridView
                    dataGridViewProducts.DataSource = dataTable;

                    // Переименовываем столбцы для удобства
                    dataGridViewProducts.Columns["id"].HeaderText = "ID";
                    dataGridViewProducts.Columns["name"].HeaderText = "Название товара";
                    dataGridViewProducts.Columns["description"].HeaderText = "Описание";
                    dataGridViewProducts.Columns["price"].HeaderText = "Цена";
                    dataGridViewProducts.Columns["category_name"].HeaderText = "Категория";

                    //А тут делаем фиксированную ширину столбца id и остальные столбцы растягивам на всю ширину (адаптивность :) )
                    dataGridViewProducts.Columns[0].Width = 50;
                    dataGridViewProducts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        //Подгрузка категорий в нужный комбобокс
        private void LoadCategories()
        {
            try
            {
                using (var localConn = new MySqlConnection(connectionString))
                {
                    localConn.Open();

                    // Запрос для получения списка категорий
                    string query = "SELECT id, name FROM Categories";

                    MySqlCommand command = new MySqlCommand(query, localConn);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Очищаем ComboBox перед заполнением
                    ProductCategoryCB.Items.Clear();

                    // Добавляем пустой элемент в начале (если требуется)
                    ProductCategoryCB.Items.Add(new ComboBoxItem { Id = 0, Name = "" });

                    // Заполняем ComboBox значениями из таблицы Categories
                    while (reader.Read())
                    {
                        ProductCategoryCB.Items.Add(new ComboBoxItem
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name")
                        });
                    }

                    // Устанавливаем первый элемент как выбранный
                    ProductCategoryCB.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки категорий: " + ex.Message);
            }
        }

        // Класс для привязки элементов ComboBox
        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; } // Добавили ц

            public override string ToString()
            {
                return Name;
            }
        }

        //Функция очистки полей
        private void ClearProductFields()
        {
            ProductNameTB.Clear();
            ProductDescTB.Clear();
            ProductPriceTB.Clear();
            ProductCategoryCB.SelectedIndex = 0; // Сброс категории
        }

        //Кнопка редактирования данных
        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                editProductId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                ProductNameTB.Text = selectedRow.Cells["name"].Value.ToString();
                ProductDescTB.Text = selectedRow.Cells["description"].Value.ToString();
                ProductPriceTB.Text = selectedRow.Cells["price"].Value.ToString();

                // Поиск и выбор категории в ComboBox по её названию
                var categoryName = selectedRow.Cells["category_name"].Value.ToString();
                for (int i = 0; i < ProductCategoryCB.Items.Count; i++)
                {
                    var item = ProductCategoryCB.Items[i] as ComboBoxItem;
                    if (item.Name == categoryName)
                    {
                        ProductCategoryCB.SelectedIndex = i;
                        break;
                    }
                }

                is_edit = true;
                ProductsPanel.Enabled = true; // Активируем панель для редактирования
            }
            else
            {
                MessageBox.Show("Выберите продукт для редактирования.");
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            ProductsPanel.Enabled = true;
        }

        //Очистка полей для ввода
        private void ProductSaveCancelBtn_Click(object sender, EventArgs e)
        {
            ClearProductFields();
            ProductsPanel.Enabled = false;
        }

        //Кнопка схранения новых данных или измененя старых
        private void ProductSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на заполненность полей
                if (string.IsNullOrEmpty(ProductNameTB.Text) ||
                    string.IsNullOrEmpty(ProductPriceTB.Text) ||
                    ProductCategoryCB.SelectedItem == null)
                {
                    MessageBox.Show("Заполните все необходимые поля.");
                    return;
                }

                using (var localConn = new MySqlConnection(connectionString))
                {
                    localConn.Open();

                    // Получаем выбранный элемент из ComboBox и его id
                    var selectedCategory = ProductCategoryCB.SelectedItem as ComboBoxItem;
                    int categoryId = selectedCategory.Id;

                    // Проверка на сохранение или редактирование
                    if (is_edit)
                    {
                        // Обновление записи
                        string query = @"
                    UPDATE Products 
                    SET name = @name, description = @description, price = @price, category_id = @category_id 
                    WHERE id = @id";

                        using (var command = new MySqlCommand(query, localConn))
                        {
                            command.Parameters.AddWithValue("@name", ProductNameTB.Text);
                            command.Parameters.AddWithValue("@description", ProductDescTB.Text);
                            command.Parameters.AddWithValue("@price", Convert.ToDecimal(ProductPriceTB.Text));
                            command.Parameters.AddWithValue("@category_id", categoryId);
                            command.Parameters.AddWithValue("@id", editProductId);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Продукт успешно обновлен!");
                    }
                    else
                    {
                        // Добавление новой записи
                        string query = @"
                    INSERT INTO Products (name, description, price, category_id) 
                    VALUES (@name, @description, @price, @category_id)";

                        using (var command = new MySqlCommand(query, localConn))
                        {
                            command.Parameters.AddWithValue("@name", ProductNameTB.Text);
                            command.Parameters.AddWithValue("@description", ProductDescTB.Text);
                            command.Parameters.AddWithValue("@price", Convert.ToDecimal(ProductPriceTB.Text));
                            command.Parameters.AddWithValue("@category_id", categoryId);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Продукт успешно сохранен!");
                    }

                    // Сброс флага и очистка полей
                    is_edit = false;
                    editProductId = -1;
                    ClearProductFields();
                    LoadProductsData(); // Обновление списка продуктов
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        //Удаление данных
        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            // Проверка, что выбран элемент в DataGridView
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Получаем ID выбранного продукта
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Подтверждение удаления
                var result = MessageBox.Show("Вы действительно хотите удалить этот продукт?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var localConn = new MySqlConnection(connectionString))
                        {
                            localConn.Open();

                            // Запрос на удаление записи
                            string query = "DELETE FROM Products WHERE id = @id";

                            using (var command = new MySqlCommand(query, localConn))
                            {
                                command.Parameters.AddWithValue("@id", productId);
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Продукт успешно удален!");

                            // Обновляем DataGridView после удаления
                            LoadProductsData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении продукта: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления.");
            }
        }
        //**************ТОВАРЫ************************



        //**************Заказы************************
        //Подгрузка заказов
        private void LoadOrdersData()
        {
            try
            {
                using (var localConn = new MySqlConnection(connectionString))
                {
                    localConn.Open();

                    // Запрос с JOIN для получения данных из таблиц Orders и Products
                    string query = @"
                SELECT 
                    Orders.id,
                    Products.name AS product_name,
                    Orders.quantity,
                    Orders.order_date,
                    Orders.total_price
                FROM Orders
                JOIN Products ON Orders.product_id = Products.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, localConn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Привязываем данные к DataGridView
                    dataGridViewOrders.DataSource = dataTable;

                    // Переименовываем столбцы для удобства
                    dataGridViewOrders.Columns["id"].HeaderText = "ID";
                    dataGridViewOrders.Columns["product_name"].HeaderText = "Название товара";
                    dataGridViewOrders.Columns["quantity"].HeaderText = "Количество";
                    dataGridViewOrders.Columns["order_date"].HeaderText = "Дата заказа";
                    dataGridViewOrders.Columns["total_price"].HeaderText = "Общая стоимость";

                    // Настройка размеров столбцов
                    dataGridViewOrders.Columns[0].Width = 50;
                    dataGridViewOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных о заказах: " + ex.Message);
            }
        }

        // Класс для привязки элементов ComboBox
        private class ProductsComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; } // Добавили цену

            public override string ToString()
            {
                return Name;
            }
        }

        // Глобальный список товаров для поиска
        private List<ComboBoxItem> productsList = new List<ComboBoxItem>();

        //ПОдгрузка товаров в COmbobox
        private decimal selectedProductPrice = 0m;
        private void LoadProductsIntoComboBox()
        {
            try
            {
                using (var localConn = new MySqlConnection(connectionString))
                {
                    localConn.Open();

                    // Запрос для получения списка товаров
                    string query = "SELECT id, name, price FROM Products";

                    MySqlCommand command = new MySqlCommand(query, localConn);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Очищаем ComboBox и список перед заполнением
                    ProductComboBox.Items.Clear();
                    productsList.Clear();

                    // Заполняем ComboBox значениями из таблицы Products
                    while (reader.Read())
                    {
                        var product = new ComboBoxItem
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Price = reader.GetDecimal("price")
                        };

                        // Добавляем в глобальный список для доступа к цене и названию
                        productsList.Add(product);
                        ProductComboBox.Items.Add(product);
                    }

                    // Устанавливаем первый элемент как выбранный (если есть элементы)
                    if (ProductComboBox.Items.Count > 0)
                    {
                        ProductComboBox.SelectedIndex = 0;
                    }
                }

                // Подключаем обработчики событий
                ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
                ProductQuantityTB.TextChanged += ProductQuantityTB_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки товаров: " + ex.Message);
            }
        }

        // Метод для расчета общей стоимости
        private void CalculateTotalPrice()
        {
            int quantity = 0;

            // Проверяем, что количество введено корректно
            if (int.TryParse(ProductQuantityTB.Text, out quantity))
            {
                decimal totalPrice = selectedProductPrice * quantity;
                textBox1.Text = totalPrice.ToString("N2");
            }
            else
            {
                // Если количество не является корректным числом, устанавливаем 0
                textBox1.Text = "0";
            }
        }

        // Обработчик события изменения выбранного товара
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = ProductComboBox.SelectedItem as ComboBoxItem;
            if (selectedProduct != null)
            {
                // Получаем цену выбранного товара
                selectedProductPrice = selectedProduct.Price;
                CalculateTotalPrice();
            }
        }

        private void ProductQuantityTB_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        //****************************************
    }
}
