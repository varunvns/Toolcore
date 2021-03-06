﻿namespace FortisCollections.Toolcore.Publish.Service
{
	public class PublishOptions : IPublisherOptions
	{
		public bool Deep { get; set; }
		public string[] LanguageNames { get; set; }
		public string PublishMode { get; set; }
		public string RootItem { get; set; }
		public string SourceDatabaseName { get; set; }
		public string[] TargetNames { get; set; }
	}
}