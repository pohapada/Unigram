// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaUploadedDocument : TLInputMediaBase, ITLMediaCaption 
	{
		[Flags]
		public enum Flag : Int32
		{
			Stickers = (1 << 0),
		}

		public bool HasStickers { get { return Flags.HasFlag(Flag.Stickers); } set { Flags = value ? (Flags | Flag.Stickers) : (Flags & ~Flag.Stickers); } }

		public Flag Flags { get; set; }
		public TLInputFileBase File { get; set; }
		public String MimeType { get; set; }
		public TLVector<TLDocumentAttributeBase> Attributes { get; set; }
		public String Caption { get; set; }
		public TLVector<TLInputDocumentBase> Stickers { get; set; }

		public TLInputMediaUploadedDocument() { }
		public TLInputMediaUploadedDocument(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputMediaUploadedDocument; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			File = TLFactory.Read<TLInputFileBase>(from, cache);
			MimeType = from.ReadString();
			Attributes = TLFactory.Read<TLVector<TLDocumentAttributeBase>>(from, cache);
			Caption = from.ReadString();
			if (HasStickers) Stickers = TLFactory.Read<TLVector<TLInputDocumentBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			UpdateFlags();

			to.Write(0xD070F1E9);
			to.Write((Int32)Flags);
			to.WriteObject(File, cache);
			to.Write(MimeType);
			to.WriteObject(Attributes, cache);
			to.Write(Caption);
			if (HasStickers) to.WriteObject(Stickers, cache);
			if (cache) WriteToCache(to);
		}

		private void UpdateFlags()
		{
			HasStickers = Stickers != null;
		}
	}
}