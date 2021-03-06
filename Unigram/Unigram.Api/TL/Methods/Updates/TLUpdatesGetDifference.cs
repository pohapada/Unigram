// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Updates
{
	/// <summary>
	/// RCP method updates.getDifference
	/// </summary>
	public partial class TLUpdatesGetDifference : TLObject
	{
		public Int32 Pts { get; set; }
		public Int32 Date { get; set; }
		public Int32 Qts { get; set; }

		public TLUpdatesGetDifference() { }
		public TLUpdatesGetDifference(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdatesGetDifference; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Pts = from.ReadInt32();
			Date = from.ReadInt32();
			Qts = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xA041495);
			to.Write(Pts);
			to.Write(Date);
			to.Write(Qts);
			if (cache) WriteToCache(to);
		}
	}
}