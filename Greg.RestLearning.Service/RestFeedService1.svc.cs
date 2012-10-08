using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Greg.RestLearning.ServiceContracts;

namespace Greg.RestLearning.Service
{
    public class RestFeedService1 : IRestFeedService1
    {
        public Rss20FeedFormatter RssFeed()
        {
            return new Rss20FeedFormatter(PrepareFeed());
        }

        public Atom10FeedFormatter AtomFeed()
        {
            return new Atom10FeedFormatter(PrepareFeed());
        }

        private SyndicationFeed PrepareFeed()
        {
            var now = DateTime.Now;

            var item = new SyndicationItem();

            item.Title = new TextSyndicationContent("Feed informacyjny.");
            item.Authors.Add(new SyndicationPerson("email@gmail.com"));
            item.Id = "001";

            

            item.LastUpdatedTime = new DateTimeOffset(now);
            item.PublishDate =new DateTimeOffset(now);

            item.Content = new TextSyndicationContent(String.Format("Publish date: {0}, Last update: {1}",item.PublishDate,item.LastUpdatedTime));

            item.Links.Add(new SyndicationLink(new Uri("http://www.wp.pl")));
            item.Links.Add(new SyndicationLink(new Uri("http://www.onet.pl")));
            item.Links.Add(SyndicationLink.CreateAlternateLink(new Uri("http://www.wp.pl")));

            SyndicationFeed feed = new SyndicationFeed(new List<SyndicationItem>(){item});
            feed.Authors.Add(new SyndicationPerson("ciekawe.co.to.za.mail@gmail.com"));
            feed.Generator = "Feed generator";
            feed.Id = "Feed ID";
            return feed;
        }

        public string Test()
        {
            return "Everything works fine!!!";
        }
    }
}
