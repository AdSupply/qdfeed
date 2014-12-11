using System;
using System.Collections.Generic;
using System.Text;

namespace QDFeedParser
{
	public class Rss092Feed : BaseSyndicationFeed
	{
		#region Constructors

		/// <summary>
		/// Default constructor for Rss092Feed objects
		/// </summary>
		public Rss092Feed() : base(QDFeedParser.FeedType.Rss092) { }

		/// <summary>
		/// Constructor for Rss092Feed objects
		/// </summary>
		/// <param name="feeduri">The Uri which uniquely identifies the feed</param>
		public Rss092Feed(string feeduri)
			: base(feeduri, FeedType.Rss092)
		{
		}

		#endregion

		/// <summary>
		/// The description of this RSS feed.
		/// </summary>
		public string Description
		{
			get;
			set;
		}

		/// <summary>
		/// The language this RSS feed is encoded in.
		/// </summary>
		public string Language
		{
			get;
			set;
		}
	}
}
