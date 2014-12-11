namespace QDFeedParser
{
	internal class DefaultFeedInstanceProvider : IFeedInstanceProvider
	{
		public Rss20Feed CreateRss20Feed(string feeduri)
		{
			return new Rss20Feed(feeduri);
		}

		public Atom10Feed CreateAtom10Feed(string feeduri)
		{
			return new Atom10Feed(feeduri);
		}

		public Rss092Feed CreateRss092Feed(string feeduri)
		{
			return new Rss092Feed(feeduri);
		}
	}
}

