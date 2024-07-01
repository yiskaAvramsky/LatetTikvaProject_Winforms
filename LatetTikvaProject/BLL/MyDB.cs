using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    enum FormStatus { add,update };
    public static class MyDB
    {
        public static ContributionsTable Contributions = new ContributionsTable();
        public static ContributorsTable Contributors = new ContributorsTable();
        public static KindOfContributionsTable KindOfContributions = new KindOfContributionsTable();
        public static PartsTable Parts = new PartsTable();
        public static PerformanceContributionsTable PerformanceContributions = new PerformanceContributionsTable();
        public static RepelledContriburorsTable RepelledContriburors = new RepelledContriburorsTable();
        public static StatusOfContributorsTable StatusOfContributors = new StatusOfContributorsTable();
        public static TownsTable Towns = new TownsTable();
        public static WorkersTable Workers = new WorkersTable();
        public static TarrifOfBonnusTable TarrifOfBonnus = new TarrifOfBonnusTable();
        public static ListsToTalkTable ListToTalk = new ListsToTalkTable();
        public static TalksTable Talks = new TalksTable();
    }
}
