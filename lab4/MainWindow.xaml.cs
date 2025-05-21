using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<Research> researches = new();
    private const string FilePath = "researches.json";

    public MainWindow()
    {
        InitializeComponent();
    }

    // Оновлення списку досліджень на формі
    private void RefreshList()
    {
        ResearchListBox.ItemsSource = null;
        ResearchListBox.ItemsSource = researches;
    }

    // Додати нове дослідження (поки що - заглушка)
    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        // ТУТ поки що просто додаємо тестовий Research для перевірки
        // Далі заміниш на відкриття форми для вводу (ResearchEditor)
        var testResearch = new Research
        {
            Client = new Client("Test Org", "Test Topic", 10000),
            ContractDate = DateTime.Today
        };
        researches.Add(testResearch);
        RefreshList();
    }

    // Edit і Delete також можна поки що залишити порожніми
    private void EditButton_Click(object sender, RoutedEventArgs e)
    {
        // TODO: Реалізуємо після ResearchEditor
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResearchListBox.SelectedItem is Research selected)
        {
            researches.Remove(selected);
            RefreshList();
        }
    }

    // Збереження у JSON
    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var json = JsonSerializer.Serialize(researches, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
            MessageBox.Show("Saved successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving: {ex.Message}");
        }
    }

    // Завантаження з JSON
    private void LoadButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                researches = JsonSerializer.Deserialize<List<Research>>(json) ?? new();
                RefreshList();
                MessageBox.Show("Loaded successfully.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading: {ex.Message}");
        }
    }
}