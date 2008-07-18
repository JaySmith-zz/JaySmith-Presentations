using System;

namespace SyndicationConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var feedUrl = "http://neverwinternightspodcast.com/?feed=rss2&category_name=podcasts";
            SyndicationDemo.DisplayFeedTitles(feedUrl);

            //SyndicationDemo.CreateFeeed();

            Console.Read();
        }

    }
}