// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.sendInvites
	/// </summary>
	public partial class TLAuthSendInvites : TLObject
	{
		public TLVector<String> PhoneNumbers { get; set; }
		public String Message { get; set; }

		public TLAuthSendInvites() { }
		public TLAuthSendInvites(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AuthSendInvites; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			PhoneNumbers = TLFactory.Read<TLVector<String>>(from, cache);
			Message = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x771C1D97);
			to.WriteObject(PhoneNumbers, cache);
			to.Write(Message);
			if (cache) WriteToCache(to);
		}
	}
}