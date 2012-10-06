using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
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
            SyndicationItem item = new SyndicationItem();

            item.Authors.Add(new SyndicationPerson("email@gmail.com"));
            item.Content = new TextSyndicationContent("Feed extra superb information.");
            item.Id = Guid.NewGuid().ToString();
            item.LastUpdatedTime = DateTime.Now;
            item.PublishDate = DateTime.Now;

            SyndicationFeed feed = new SyndicationFeed(new List<SyndicationItem>(){item});
            feed.Authors.Add(new SyndicationPerson("ciekawe.co.to.za.mail@gmail.com"));
            feed.Generator = "Feed generator";
            return feed;
        }

        public string Test()
        {
            return "Everything works fine!!!";
        }
    }
}
