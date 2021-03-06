// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getInviteText
	/// </summary>
	public partial class TLHelpGetInviteText : TLObject
	{
		public TLHelpGetInviteText() { }
		public TLHelpGetInviteText(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.HelpGetInviteText; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x4D392343);
			if (cache) WriteToCache(to);
		}
	}
}