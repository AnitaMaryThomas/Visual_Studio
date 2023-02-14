using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_24
{
    internal class AppSettings
    {
        public static String Name { get; set; }
        public static String Version { get; set; }

        public static Uri Website { get; set; }
        public static String Publisher { get; set; }

        public static String Descriptionn = "This is a console app";
        static AppSettings()
        {
            Name = "ConsoleApp";
            Version= "1.0";
            Website = new Uri("https://bing.com");
            Publisher = "Microsoft";
        }

    }
}
