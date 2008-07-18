using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace SyndicationConsole
{
    internal class DetailedFeedCreator
    {
        public static void CreateSampleFeed()
        {
            var feed = new SyndicationFeed("Feed Title", "Feed Description", new Uri("http://Feed/Alternate/Link"), "FeedID", DateTime.Now);

            // Add a custom attribute.
            var xqName = new XmlQualifiedName("CustomAttribute");
            feed.AttributeExtensions.Add(xqName, "Value");

            var sp = new SyndicationPerson("jesper@contoso.com", "Jesper Aaberg", "http://Jesper/Aaberg");
            feed.Authors.Add(sp);

            var category = new SyndicationCategory("FeedCategory", "CategoryScheme", "CategoryLabel");
            feed.Categories.Add(category);

            feed.Contributors.Add(new SyndicationPerson("lene@contoso.com", "Lene Aaling", "http://lene/aaling"));
            feed.Copyright = new TextSyndicationContent("Copyright 2007");
            feed.Description = new TextSyndicationContent("This is a sample feed");

            // Add a custom element.
            var doc = new XmlDocument();
            var feedElement = doc.CreateElement("CustomElement");
            feedElement.InnerText = "Some text";
            feed.ElementExtensions.Add(feedElement);

            feed.Generator = "Sample Code";
            feed.Id = "FeedID";
            feed.ImageUrl = new Uri("http://server/image.jpg");

            var textContent = new TextSyndicationContent("Some text content");
            var item = new SyndicationItem("Item Title", textContent, new Uri("http://server/items"), "ItemID", DateTime.Now);

            var items = new List<SyndicationItem>();
            items.Add(item);
            feed.Items = items;

            feed.Language = "en-us";
            feed.LastUpdatedTime = DateTime.Now;

            var link = new SyndicationLink(new Uri("http://server/link"), "alternate", "Link Title", "text/html", 1000);
            feed.Links.Add(link);

            var atomWriter = XmlWriter.Create("atom.xml");
            var atomFormatter = new Atom10FeedFormatter(feed);
            atomFormatter.WriteTo(atomWriter);
            atomWriter.Close();

            var rssWriter = XmlWriter.Create("rss.xml");
            var rssFormatter = new Rss20FeedFormatter(feed);
            rssFormatter.WriteTo(rssWriter);
            rssWriter.Close();
        }
    }
}