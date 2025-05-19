using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Client
    {
        public string OrganizationName { get; set; }
        public string ResearchTopic { get; set; }
        public int ContractValue { get; set; }

        public Client() { }

        public Client(string organizationName, string researchTopic, int contractValue)
        {
            OrganizationName = organizationName;
            ResearchTopic = researchTopic;
            ContractValue = contractValue;
        }

        public override string ToString()
        {
            return $"{OrganizationName} – {ResearchTopic} ({ContractValue} UAH)";
        }
    }
}
