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
    /// Interaction logic for ResearchEditor.xaml
    /// </summary>
    public partial class ResearchEditor : Window
    {
        public Research Research { get; private set; } = new Research();

        public ResearchEditor()
        {
            InitializeComponent();

            ContractDatePicker.SelectedDate = DateTime.Today;

            PublicationsListBox.ItemsSource = Research.Publications;

            this.Closing += ResearchEditor_Closing;
        }


        public ResearchEditor(Research researchToEdit) : this()
        {
            if (researchToEdit != null)
            {
                Research = researchToEdit;
                this.DataContext = Research; // <-- ГОЛОВНЕ!
            }
        }

        private void ResearchEditor_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DialogResult != true)
            {
                var result = MessageBox.Show(
                    "Вийти без збереження змін?",
                    "Підтвердження",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true; 
                }
            }

        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string org = OrganizationNameBox.Text.Trim();
                string topic = ResearchTopicBox.Text.Trim();

                if (!Regex.IsMatch(org, @"^[A-ZА-ЯІЇЄ][\w\s\.\-&]{2,}$"))
                    throw new Exception("Назва організації некоректна.");

                if (!Regex.IsMatch(topic, @"^[\w\s\.\,\-()]{3,}$"))
                    throw new Exception("Тема дослідження некоректна.");

                if (!int.TryParse(ContractValueBox.Text.Trim(), out int value) || value <= 0)
                    throw new Exception("Сума контракту має бути додатнім числом.");

                DateTime contractDate = ContractDatePicker.SelectedDate ?? DateTime.Today;

                Research.Client = new Client(org, topic, value);
                Research.ContractDate = contractDate;

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void AddPublicationButton_Click(object sender, RoutedEventArgs e)
        {
            var pubEditor = new PublicationEditor();
            if (pubEditor.ShowDialog() == true)
            {
                Research.Publications.Add(pubEditor.Publication);
                PublicationsListBox.Items.Refresh();
            }
        }


        private void EditPublicationButton_Click(object sender, RoutedEventArgs e)
        {
            if (PublicationsListBox.SelectedItem is Publication selected)
            {
                var pubEditor = new PublicationEditor(selected);
                if (pubEditor.ShowDialog() == true)
                {
                    int index = Research.Publications.IndexOf(selected);
                    if (index >= 0)
                        Research.Publications[index] = pubEditor.Publication;

                    PublicationsListBox.Items.Refresh();
                }
            }
        }

        private void DeletePublicationButton_Click(object sender, RoutedEventArgs e)
        {
            if (PublicationsListBox.SelectedItem is Publication selected)
            {
                Research.Publications.Remove(selected);
                PublicationsListBox.Items.Refresh();
            }
        }
    }
}