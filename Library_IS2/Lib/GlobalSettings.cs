using Library_IS.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS2.Lib
{
    public class GlobalSettings
    {
        private static readonly Lazy<GlobalSettings> _instance =
        new Lazy<GlobalSettings>(() => new GlobalSettings());

        public static GlobalSettings Instance => _instance.Value;
        Repository repo = new Repository(new Library2Entities());
        public int DaysToReturn { get; set; }
        public User user { get; set; }

        public GlobalSettings()
        {
            DaysToReturn = Properties.Settings.Default.DaysToReturn;
        }
    }
}
