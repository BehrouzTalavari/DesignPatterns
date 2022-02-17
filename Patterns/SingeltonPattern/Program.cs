using System;
namespace SingeltonPattern
{
    public class SiteSetting
    {

        private SiteSetting()
        {

        }
        public string SiteName { get; set; }
        public string FooterText { get; set; }

        private static readonly SiteSetting instance = new();
        public static SiteSetting Instance => instance;
        public static int Count { get; set; }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            var instance = SiteSetting.Instance.FooterText;
            SiteSetting.Count = 1;
            Type type = typeof(SiteSetting);
            SiteSetting f = (SiteSetting)Activator.CreateInstance(type, true);
            Console.WriteLine();
        }
    }
}