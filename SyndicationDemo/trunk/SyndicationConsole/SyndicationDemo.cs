using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel.Syndication;
using System.Xml;

namespace SyndicationConsole
{
    public class SyndicationDemo
    {
        public static void DisplayFeedTitles(string url)
        {
            using (var feedReader = ProxyHelper.GetProxyEnabledXmlTextReader(url))
            {
                var syndicationFeed = SyndicationFeed.Load(feedReader);

                if (syndicationFeed == null) return;

                foreach (var feedItem in syndicationFeed.Items)
                    Console.WriteLine(feedItem.Title.Text);
            }
        }

        public static void CreateFeeed()
        {
            var feed = new SyndicationFeed("Tyson Podcast Network", "A custom rss feed", null);
            var feedItems = new List<SyndicationItem>();

            for (int i = 0; i < 10; i++)
            {
                var feedItem = new SyndicationItem("Title: " + i, "This is item: " + i, null);
                feedItems.Add(feedItem);
            }

            feed.Items = feedItems;

            // Save as an RSS 2.0 Feed.
            var rssWriter = XmlWriter.Create("rss_feed.xml");
            var rssFormatter = new Rss20FeedFormatter(feed);
            rssFormatter.WriteTo(rssWriter);
            rssWriter.Close();

            // Save as an Atom 1.0 Feed
            //var atomWriter = XmlWriter.Create("atom_feed.xml");
            //feed.SaveAsAtom10(atomWriter);
            //atomWriter.Close();
        }
    }
}