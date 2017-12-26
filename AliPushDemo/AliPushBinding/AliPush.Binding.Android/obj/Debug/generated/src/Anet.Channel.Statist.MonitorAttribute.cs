using System;

namespace Anet.Channel.Statist {

	[global::Android.Runtime.Annotation ("anet.channel.statist.Monitor")]
	public partial class MonitorAttribute : Attribute
	{
		[global::Android.Runtime.Register ("module")]
		public string Module { get; set; }

		[global::Android.Runtime.Register ("monitorPoint")]
		public string MonitorPoint { get; set; }

	}
}
