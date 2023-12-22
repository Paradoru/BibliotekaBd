using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaBd
{
    public partial class WriteOffBookForm : Form
    {
        private readonly string connectionString = "Data Source=PARADORU\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True";

        public WriteOffBookForm()
        {
            InitializeComponent();
        }

        private void writeOffButton_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int inventoryNumber))
            {
                try
                {
                    string bookStatus = GetBookStatus(inventoryNumber);

                    if (!bookStatus.Contains("Данный экземпляр книги уже списан.") && !bookStatus.Contains("Экземпляр книги имеет хорошее состояние."))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand("Списание книги", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@InventoryNumber", inventoryNumber);

                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }

                        bookStatus = GetBookStatus(inventoryNumber);
                        bookstatuslabel.Text = bookStatus;

                        MessageBox.Show(bookStatus);
                    }
                    else
                    {
                        MessageBox.Show(bookStatus);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при списании книги: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Книга с таким инвентарным номером не найдена в библиотеке.");
            }
        }

        private string GetBookStatus(int inventoryNumber)
        {
            string bookStatus = "Статус книги не найден";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT [Состояние книги] FROM [Экземпляр книги] WHERE [Инвентарный номер] = @InventoryNumber", connection))
                    {
                        command.Parameters.AddWithValue("@InventoryNumber", inventoryNumber);
                        connection.Open();

                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            bookStatus = $"Статус книги: {result.ToString()}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении статуса книги: {ex.Message}");
            }

            return bookStatus;
        }
    }
}
