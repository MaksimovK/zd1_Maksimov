using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_1_2
{
    public partial class Form1 : Form
    {
        Shop pyaterochka = new Shop();
        decimal money = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetMyData();
        }

        private DataTable GetMyData()
        {
            DataTable table = new DataTable();
            dataGridView1.Columns.Add("Название товара", "Название товара");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("Кол-во", "Кол-во");
            return table;
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nameProduct.Text))
            {
                MessageBox.Show("Введите название продукта");
            }
            else if (string.IsNullOrWhiteSpace(cb_count.Text))
            {
                MessageBox.Show("Выберите кол-во товара");
            }
            else
            {
                bool productExists = false;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DataGridViewCell cell = dataGridView1.Rows[i].Cells[0];

                    if (cell.Value != null && cell.Value.ToString() == tb_nameProduct.Text)
                    {
                        productExists = true;
                        break;
                    }
                }

                if (!productExists)
                {
                    MessageBox.Show("Такого продукта нет");
                }
                else
                {
                    string columnName = "Название товара";
                    int valueToSubtract = int.Parse(cb_count.Text);

                    DataGridViewColumn column = dataGridView1.Columns[columnName];

                    string searchValue = tb_nameProduct.Text;

                    int rowIndex = -1;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["Кол-во"].Value);
                        if (quantity < int.Parse(cb_count.Text))
                        {
                            MessageBox.Show("Столько товара нет в наличие");
                            break;
                        }
                        if (quantity == 0)
                        {
                            MessageBox.Show("Товар закончился!");
                            dataGridView1.Rows.Remove(row);
                        }
                        
                        if (Convert.ToString(row.Cells[column.Name].Value) == searchValue)
                        {
                            rowIndex = row.Index;
                            break;
                        }

                    }

                    if (rowIndex == -1)
                    {
                        return;
                    }

                    int currentValue = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Кол-во"].Value);

                    DataGridViewCell cell = dataGridView1.Rows[rowIndex].Cells["Цена"];

                    decimal result;
                    if (cell == null || cell.Value == null) result = 0;

                    decimal.TryParse(cell.Value.ToString(), out result);
                    if (cb_count.SelectedIndex == 0)
                    {
                        money += result;
                    }
                    else if (cb_count.SelectedIndex == 1)
                    {
                        money += result * 2;
                    }
                    else if (cb_count.SelectedIndex == 2)
                    {
                        money += result * 3;
                    }

                    label9.Text = money.ToString();
                    int newValue = currentValue - valueToSubtract;

                    dataGridView1.Rows[rowIndex].Cells["Кол-во"].Value = newValue;
                }
            }
        }

        private void bt_addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_Name.Text))
                {
                    MessageBox.Show("Введите название товара");
                }
                else if (string.IsNullOrWhiteSpace(tb_Price.Text))
                {
                    MessageBox.Show("Введите цену товара");
                }
                else if (string.IsNullOrWhiteSpace(tb_countProduct.Text))
                {
                    MessageBox.Show("Введите кол-во товара");
                }

                foreach (var el in tb_Name.Text)
                {
                    if (char.IsDigit(el))
                    {
                        MessageBox.Show("Поле название содержит цифры");
                    }
                }

                foreach (var el in tb_Price.Text)
                {
                    if (tb_Price.Text.Contains("."))
                    {
                        continue;
                    }

                    if (!char.IsDigit(el))
                    {
                        MessageBox.Show("Поле цена содержит буквы");
                    }
                }

                foreach (var el in tb_countProduct.Text)
                {
                    if (!char.IsDigit(el))
                    {
                        MessageBox.Show("Поле кол-во содержит буквы");
                    }
                }

                bool productExists = false;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DataGridViewCell cell = dataGridView1.Rows[i].Cells[0];

                    if (cell.Value != null && cell.Value.ToString() == tb_Name.Text)
                    {
                        productExists = true;
                        break;
                    }
                }

                if (productExists)
                {
                    MessageBox.Show("Продукт уже содержится");
                }
                else
                {
                    pyaterochka.CreateProduct(tb_Name.Text, Convert.ToDecimal(tb_Price.Text),
                        int.Parse(tb_countProduct.Text));
                    dataGridView1.Rows.Add(tb_Name.Text, Convert.ToDecimal(tb_Price.Text),
                        int.Parse(tb_countProduct.Text));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}