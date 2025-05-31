using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;

namespace lab4;
public partial class MainWindow : Window
{
    private ObservableCollection<Research> researches = new();
    private const string FilePath = "researches.json";

    public MainWindow()
    {
        InitializeComponent();
        ResearchListBox.ItemsSource = researches;
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        var editor = new ResearchEditor();
        if (editor.ShowDialog() == true)
        {
            researches.Add(editor.Research);
        }
    }

    private void EditButton_Click(object sender, RoutedEventArgs e)
    {

        /*if (ResearchListBox.SelectedItem is Research selected)
        {
            var editor = new ResearchEditor(selected);
            if (editor.ShowDialog() == true)
            {
                ResearchListBox.Items.Refresh();
            }
        }*/
        if (ResearchListBox.SelectedItem is Research selected)
        {
            var researchCopy = selected.Clone();

            var editor = new ResearchEditor(researchCopy);

            if (editor.ShowDialog() == true)
            {
                int index = researches.IndexOf(selected);
                if (index >= 0)
                    researches[index] = researchCopy;
            }
        }
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        if (ResearchListBox.SelectedItem is Research selected)
        {
            researches.Remove(selected);
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var json = JsonSerializer.Serialize(researches.ToList(), new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
            MessageBox.Show("Saved successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving: {ex.Message}");
        }
    }

    private void LoadButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var loaded = JsonSerializer.Deserialize<List<Research>>(json) ?? new List<Research>();
                researches = new ObservableCollection<Research>(loaded);
                ResearchListBox.ItemsSource = researches;
                MessageBox.Show("Loaded successfully.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading: {ex.Message}");
        }
    }
}

