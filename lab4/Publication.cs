using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Publication
    {
        public Student Author { get; set; }
        public ResearchAchievement AchievementType { get; set; }

        public Publication() { }

        public Publication(Student author, ResearchAchievement achievementType)
        {
            Author = author;
            AchievementType = achievementType;
        }

        public override string ToString()
        {
            return $"{Author?.LastName} {Author?.FirstName} ({Author?.EnrollmentYear}): {AchievementType}";
        }

    }
}
