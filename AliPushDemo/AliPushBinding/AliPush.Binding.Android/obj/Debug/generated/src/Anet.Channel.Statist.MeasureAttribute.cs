using System;

namespace Anet.Channel.Statist {

	[global::Android.Runtime.Annotation ("anet.channel.statist.Measure")]
	public partial class MeasureAttribute : Attribute
	{
		[global::Android.Runtime.Register ("constantValue")]
		public double ConstantValue { get; set; }

		[global::Android.Runtime.Register ("max")]
		public double Max { get; set; }

		[global::Android.Runtime.Register ("min")]
		public double Min { get; set; }

	}
}
