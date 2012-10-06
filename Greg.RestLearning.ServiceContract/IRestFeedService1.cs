using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;

namespace Greg.RestLearning.ServiceContracts
{
    [ServiceContract]
    public interface IRestFeedService1//:ITestService
    {
        [WebGet(UriTemplate = "/feeds/feed.rss")]
        [OperationContract]
        Rss20FeedFormatter RssFeed();

        [WebGet(UriTemplate = "/feeds/feed.atom")]
        [OperationContract]
        Atom10FeedFormatter AtomFeed();

        [WebGet(UriTemplate = "test")]
        [OperationContract]
        string Test();
    }
}
