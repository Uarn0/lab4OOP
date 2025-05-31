using System.ComponentModel;

namespace lab4
{
    public class Client : INotifyPropertyChanged
    {
        private string organizationName;
        private string researchTopic;
        private int contractValue;

        public string OrganizationName
        {
            get => organizationName;
            set
            {
                if (organizationName != value)
                {
                    organizationName = value;
                    OnPropertyChanged(nameof(OrganizationName));
                }
            }
        }

        public string ResearchTopic
        {
            get => researchTopic;
            set
            {
                if (researchTopic != value)
                {
                    researchTopic = value;
                    OnPropertyChanged(nameof(ResearchTopic));
                }
            }
        }

        public int ContractValue
        {
            get => contractValue;
            set
            {
                if (contractValue != value)
                {
                    contractValue = value;
                    OnPropertyChanged(nameof(ContractValue));
                }
            }
        }

        public Client() { }

        public Client(string organizationName, string researchTopic, int contractValue)
        {
            OrganizationName = organizationName;
            ResearchTopic = researchTopic;
            ContractValue = contractValue;
        }
        public Client Clone()
        {
            return new Client
            {
                OrganizationName = this.OrganizationName,
                ResearchTopic = this.ResearchTopic,
                ContractValue = this.ContractValue
            };
        }

        public override string ToString()
        {
            return $"{OrganizationName} – {ResearchTopic} ({ContractValue} UAH)";
        }

        // --- INotifyPropertyChanged implementation ---
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
