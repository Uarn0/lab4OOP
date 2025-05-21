using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            // Заповнюємо ComboBox всіма варіантами з ResearchAchievement
            AchievementBox.ItemsSource = Enum.GetValues(typeof(ResearchAchievement));

            // За замовчуванням вибраний перший тип досягнення
            AchievementBox.SelectedIndex = 0;
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
                int year = int.Parse(EnrollmentYearBox.Text.Trim());
                var achievement = (ResearchAchievement)AchievementBox.SelectedItem;

                var student = new Student(firstName, lastName, year);
                Publication = new Publication(student, achievement);

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
