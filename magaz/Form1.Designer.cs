namespace magaz
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            panel3 = new Panel();
            dataGridViewProducts = new DataGridView();
            panel2 = new Panel();
            ProductsPanel = new Panel();
            ProductSaveBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ProductNameTB = new TextBox();
            ProductSaveCancelBtn = new Button();
            ProductCategoryCB = new ComboBox();
            ProductDescTB = new TextBox();
            ProductPriceTB = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddProductBtn = new Button();
            UpdateProductBtn = new Button();
            DeleteProductBtn = new Button();
            panel4 = new Panel();
            OpenCategoryListBtn = new Button();
            tabPage1 = new TabPage();
            panel7 = new Panel();
            dataGridViewOrders = new DataGridView();
            panel6 = new Panel();
            panel8 = new Panel();
            ProductQuantityTB = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ProductComboBox = new ComboBox();
            panel5 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dataBaseConnectionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel2.SuspendLayout();
            ProductsPanel.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1133, 573);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Товары";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewProducts);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(1127, 377);
            panel3.TabIndex = 2;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(0, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(1127, 377);
            dataGridViewProducts.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ProductsPanel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 420);
            panel2.Name = "panel2";
            panel2.Size = new Size(1127, 150);
            panel2.TabIndex = 1;
            // 
            // ProductsPanel
            // 
            ProductsPanel.Controls.Add(ProductSaveBtn);
            ProductsPanel.Controls.Add(label4);
            ProductsPanel.Controls.Add(label3);
            ProductsPanel.Controls.Add(label2);
            ProductsPanel.Controls.Add(label1);
            ProductsPanel.Controls.Add(ProductNameTB);
            ProductsPanel.Controls.Add(ProductSaveCancelBtn);
            ProductsPanel.Controls.Add(ProductCategoryCB);
            ProductsPanel.Controls.Add(ProductDescTB);
            ProductsPanel.Controls.Add(ProductPriceTB);
            ProductsPanel.Dock = DockStyle.Left;
            ProductsPanel.Location = new Point(0, 0);
            ProductsPanel.Name = "ProductsPanel";
            ProductsPanel.Size = new Size(462, 150);
            ProductsPanel.TabIndex = 4;
            // 
            // ProductSaveBtn
            // 
            ProductSaveBtn.Location = new Point(342, 51);
            ProductSaveBtn.Name = "ProductSaveBtn";
            ProductSaveBtn.Size = new Size(117, 31);
            ProductSaveBtn.TabIndex = 8;
            ProductSaveBtn.Text = "Сохранить";
            ProductSaveBtn.UseVisualStyleBackColor = true;
            ProductSaveBtn.Click += ProductSaveBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 109);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 80);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "Цена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 4;
            label1.Text = "Наименование";
            // 
            // ProductNameTB
            // 
            ProductNameTB.Location = new Point(110, 19);
            ProductNameTB.Name = "ProductNameTB";
            ProductNameTB.Size = new Size(195, 23);
            ProductNameTB.TabIndex = 0;
            // 
            // ProductSaveCancelBtn
            // 
            ProductSaveCancelBtn.Location = new Point(342, 17);
            ProductSaveCancelBtn.Name = "ProductSaveCancelBtn";
            ProductSaveCancelBtn.Size = new Size(117, 31);
            ProductSaveCancelBtn.TabIndex = 5;
            ProductSaveCancelBtn.Text = "Отмена";
            ProductSaveCancelBtn.UseVisualStyleBackColor = true;
            ProductSaveCancelBtn.Click += ProductSaveCancelBtn_Click;
            // 
            // ProductCategoryCB
            // 
            ProductCategoryCB.FormattingEnabled = true;
            ProductCategoryCB.Location = new Point(110, 106);
            ProductCategoryCB.Name = "ProductCategoryCB";
            ProductCategoryCB.Size = new Size(195, 23);
            ProductCategoryCB.TabIndex = 3;
            // 
            // ProductDescTB
            // 
            ProductDescTB.Location = new Point(110, 48);
            ProductDescTB.Name = "ProductDescTB";
            ProductDescTB.Size = new Size(195, 23);
            ProductDescTB.TabIndex = 1;
            // 
            // ProductPriceTB
            // 
            ProductPriceTB.Location = new Point(110, 77);
            ProductPriceTB.Name = "ProductPriceTB";
            ProductPriceTB.Size = new Size(195, 23);
            ProductPriceTB.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 40);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AddProductBtn);
            flowLayoutPanel1.Controls.Add(UpdateProductBtn);
            flowLayoutPanel1.Controls.Add(DeleteProductBtn);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(OpenCategoryListBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1127, 40);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(3, 3);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(117, 31);
            AddProductBtn.TabIndex = 0;
            AddProductBtn.Text = "Добавить товар";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.Location = new Point(126, 3);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(117, 31);
            UpdateProductBtn.TabIndex = 1;
            UpdateProductBtn.Text = "Изменить";
            UpdateProductBtn.UseVisualStyleBackColor = true;
            UpdateProductBtn.Click += UpdateProductBtn_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(249, 3);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(117, 31);
            DeleteProductBtn.TabIndex = 2;
            DeleteProductBtn.Text = "Удалить";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(372, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 31);
            panel4.TabIndex = 3;
            // 
            // OpenCategoryListBtn
            // 
            OpenCategoryListBtn.Location = new Point(644, 3);
            OpenCategoryListBtn.Name = "OpenCategoryListBtn";
            OpenCategoryListBtn.Size = new Size(117, 31);
            OpenCategoryListBtn.TabIndex = 4;
            OpenCategoryListBtn.Text = "Категории";
            OpenCategoryListBtn.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel7);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1133, 573);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заказы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(dataGridViewOrders);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 43);
            panel7.Name = "panel7";
            panel7.Size = new Size(1127, 362);
            panel7.TabIndex = 2;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Fill;
            dataGridViewOrders.Location = new Point(0, 0);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(1127, 362);
            dataGridViewOrders.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel8);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 405);
            panel6.Name = "panel6";
            panel6.Size = new Size(1127, 165);
            panel6.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(ProductQuantityTB);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(dateTimePicker1);
            panel8.Controls.Add(ProductComboBox);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(535, 165);
            panel8.TabIndex = 0;
            // 
            // ProductQuantityTB
            // 
            ProductQuantityTB.Location = new Point(126, 46);
            ProductQuantityTB.Name = "ProductQuantityTB";
            ProductQuantityTB.Size = new Size(195, 23);
            ProductQuantityTB.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 108);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 10;
            label8.Text = "Стоимость";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 82);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 9;
            label7.Text = "Дата";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 49);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 8;
            label6.Text = "Количество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 21);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 7;
            label5.Text = "Наименование";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // ProductComboBox
            // 
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(126, 18);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(195, 23);
            ProductComboBox.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1127, 40);
            panel5.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1127, 40);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 31);
            button1.TabIndex = 1;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(126, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 31);
            button2.TabIndex = 2;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(249, 3);
            button3.Name = "button3";
            button3.Size = new Size(117, 31);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1141, 601);
            tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1141, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataBaseConnectionToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // dataBaseConnectionToolStripMenuItem
            // 
            dataBaseConnectionToolStripMenuItem.Name = "dataBaseConnectionToolStripMenuItem";
            dataBaseConnectionToolStripMenuItem.Size = new Size(184, 22);
            dataBaseConnectionToolStripMenuItem.Text = "DataBaseConnection";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(184, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 625);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "База данных";
            Load += MainForm_Load;
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel2.ResumeLayout(false);
            ProductsPanel.ResumeLayout(false);
            ProductsPanel.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridViewProducts;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddProductBtn;
        private Button UpdateProductBtn;
        private Button DeleteProductBtn;
        private Panel panel4;
        private Button OpenCategoryListBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dataBaseConnectionToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox ProductCategoryCB;
        private TextBox ProductPriceTB;
        private TextBox ProductDescTB;
        private TextBox ProductNameTB;
        private Panel ProductsPanel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ProductSaveBtn;
        private Button ProductSaveCancelBtn;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private DataGridView dataGridViewOrders;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel8;
        private ComboBox ProductComboBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox ProductQuantityTB;
    }
}
