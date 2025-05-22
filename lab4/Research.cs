using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Research
    {
        public Client Client { get; set; }
        public DateTime ContractDate { get; set; }
        public List<Publication> Publications { get; set; } = new();

        public Research() { }

        public Research(Client client, DateTime contractDate)
        {
            Client = client;
            ContractDate = contractDate;
        }
        public string ToShortString
        {
            get
            {
                return $"{Client?.ResearchTopic ?? "No topic"} | {Publications?.Count ?? 0} pubs.";
            }
        }

        public void AddPublication(Publication publication)
        {
            if (publication != null)
                Publications.Add(publication);
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

    }
}
