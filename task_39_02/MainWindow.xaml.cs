using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> products = new ObservableCollection<string>();
        private const string DefaultFileName = "Список_покупок.txt";

        public MainWindow()
        {
            InitializeComponent();
            lstProducts.ItemsSource = products;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewProduct.Text))
            {
                products.Add(txtNewProduct.Text);
                txtNewProduct.Clear();
                txtNewProduct.Focus();
            }
            else
            {
                MessageBox.Show("Введите название продукта", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                products.Remove((string)lstProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Список покупок пуст", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.FileName = DefaultFileName;

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, products);
                    MessageBox.Show("Список сохранен успешно!", "Успех",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (products.Count > 0)
            {
                var result = MessageBox.Show("Очистить весь список покупок?", "Подтверждение",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    products.Clear();
                }
            }
        }
    }
}