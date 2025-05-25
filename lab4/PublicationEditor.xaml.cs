using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab4
{
    /// <summary>
    /// Interaction logic for PublicationEditor.xaml
    /// </summary>
    public partial class PublicationEditor : Window
    {
        public Publication Publication { get; private set; }

        public PublicationEditor()
        {
            InitializeComponent();
            AchievementBox.ItemsSource = Enum.GetValues(typeof(ResearchAchievement));

            this.Closing += PublicationEditor_Closing;
        }
        private void PublicationEditor_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DialogResult != true)
            {
                var result = MessageBox.Show(
                    "Вийти без збереження публікації?",
                    "Підтвердження",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        // Конструктор для редагування існуючої публікації
        public PublicationEditor(Publication publicationToEdit) : this()
        {
            if (publicationToEdit != null)
            {
                FirstNameBox.Text = publicationToEdit.Author?.FirstName;
                LastNameBox.Text = publicationToEdit.Author?.LastName;
                EnrollmentYearBox.Text = publicationToEdit.Author?.EnrollmentYear.ToString();
                AchievementBox.SelectedItem = publicationToEdit.AchievementType;
                Publication = publicationToEdit;
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string firstName = FirstNameBox.Text.Trim();
                string lastName = LastNameBox.Text.Trim();

                if (!Regex.IsMatch(firstName, @"^[A-ZА-ЯІЇЄ][a-zа-яіїє']+$"))
                    throw new Exception("Ім’я некоректне.");

                if (!Regex.IsMatch(lastName, @"^[A-ZА-ЯІЇЄ][a-zа-яіїє']+$"))
                    throw new Exception("Прізвище некоректне.");

                if (!int.TryParse(EnrollmentYearBox.Text.Trim(), out int year) || year < 2000 || year > DateTime.Now.Year)
                    throw new Exception("Рік зарахування некоректний.");

                var achievement = (ResearchAchievement)AchievementBox.SelectedItem;

                var student = new Student(firstName, lastName, year);
                Publication = new Publication(student, achievement);

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

    }
}
