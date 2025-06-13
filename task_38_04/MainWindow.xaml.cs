using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private const string DataFile = "students.dat";

        public MainWindow()
        {
            InitializeComponent();
            lstStudents.ItemsSource = students;
            LoadData();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                dpBirthDate.SelectedDate == null)
            {
                MessageBox.Show("Заполните обязательные поля: Фамилия, Имя и Дата рождения",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var student = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Group = txtGroup.Text,
                Gender = cmbGender.SelectedIndex == 0 ? Gender.Male : Gender.Female,
                BirthDate = dpBirthDate.SelectedDate.Value
            };

            students.Add(student);
            ClearFields();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                students.Remove((Student)lstStudents.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count > 0)
            {
                var result = MessageBox.Show("Очистить весь список студентов?", "Подтверждение",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    students.Clear();
                }
            }
        }

        private void ClearFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtGroup.Clear();
            cmbGender.SelectedIndex = 0;
            dpBirthDate.SelectedDate = null;
            txtLastName.Focus();
        }

        private void LoadData()
        {
            if (File.Exists(DataFile))
            {
                try
                {
                    using (FileStream fs = new FileStream(DataFile, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        var loadedStudents = (ObservableCollection<Student>)formatter.Deserialize(fs);
                        students.Clear();
                        foreach (var student in loadedStudents)
                        {
                            students.Add(student);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveData()
        {
            try
            {
                using (FileStream fs = new FileStream(DataFile, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveData();
        }
    }
}