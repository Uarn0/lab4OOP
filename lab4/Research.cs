using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace lab4
{
    public class Research : INotifyPropertyChanged
    {
        private Client client;
        private DateTime contractDate;
        private ObservableCollection<Publication> publications = new();
        public Client Client
        {
            get => client;
            set
            {
                if (client != value)
                {
                    if (client != null)
                        client.PropertyChanged -= Client_PropertyChanged; // відписуємось від старого
                    client = value;
                    if (client != null)
                        client.PropertyChanged += Client_PropertyChanged; // підписуємось на новий
                    OnPropertyChanged(nameof(Client));
                    OnPropertyChanged(nameof(ToShortString));
                }
            }
        }

        private void Client_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Оновлюємо ToShortString, якщо щось у клієнті змінилося
            OnPropertyChanged(nameof(ToShortString));
        }

        public DateTime ContractDate
        {
            get => contractDate;
            set
            {
                if (contractDate != value)
                {
                    contractDate = value;
                    OnPropertyChanged(nameof(ContractDate));
                }
            }
        }

        public ObservableCollection<Publication> Publications
        {
            get => publications;
            set
            {
                if (publications != value)
                {
                    if (publications != null)
                        publications.CollectionChanged -= Publications_CollectionChanged;
                    publications = value;
                    if (publications != null)
                        publications.CollectionChanged += Publications_CollectionChanged;
                    OnPropertyChanged(nameof(Publications));
                    OnPropertyChanged(nameof(ToShortString));
                }
            }
        }

        private void Publications_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ToShortString));
        }


        public Research() { }


        public Research(Client client, DateTime contractDate)
        {
            Client = client;
            ContractDate = contractDate;
        }

        public Research Clone()
        {
            return new Research
            {
                Client = this.Client?.Clone(),
                ContractDate = this.ContractDate,
                Publications = new ObservableCollection<Publication>(this.Publications.Select(p => p.Clone()))
            };
        }



        public string ToShortString
        {
            get => $"{Client?.ResearchTopic ?? "No topic"} | {Publications?.Count ?? 0} pubs.";
        }

        public void AddPublication(Publication publication)
        {
            if (publication != null)
            {
                Publications.Add(publication);
                OnPropertyChanged(nameof(Publications)); 
                OnPropertyChanged(nameof(ToShortString));
            }
        }

        public override string ToString()
        {
            return
                $"Організація: {Client?.OrganizationName ?? "—"}\n" +
                $"Тема: {Client?.ResearchTopic ?? "—"}\n" +
                $"Вартість: {Client?.ContractValue ?? 0} грн\n" +
                $"Дата підписання: {ContractDate:dd.MM.yyyy}\n" +
                $"Публікацій: {Publications?.Count ?? 0}\n" +
                $"{string.Join("\n", Publications)}";
        }

        // --- INotifyPropertyChanged implementation ---
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
