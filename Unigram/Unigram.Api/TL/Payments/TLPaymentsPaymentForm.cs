// <auto-generated/>
using System;

namespace Telegram.Api.TL.Payments
{
	public partial class TLPaymentsPaymentForm : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			CanSaveCredentials = (1 << 2),
			PasswordMissing = (1 << 3),
			NativeProvider = (1 << 4),
			NativeParams = (1 << 4),
			SavedInfo = (1 << 0),
			SavedCredentials = (1 << 1),
		}

		public bool IsCanSaveCredentials { get { return Flags.HasFlag(Flag.CanSaveCredentials); } set { Flags = value ? (Flags | Flag.CanSaveCredentials) : (Flags & ~Flag.CanSaveCredentials); } }
		public bool IsPasswordMissing { get { return Flags.HasFlag(Flag.PasswordMissing); } set { Flags = value ? (Flags | Flag.PasswordMissing) : (Flags & ~Flag.PasswordMissing); } }
		public bool HasNativeProvider { get { return Flags.HasFlag(Flag.NativeProvider); } set { Flags = value ? (Flags | Flag.NativeProvider) : (Flags & ~Flag.NativeProvider); } }
		public bool HasNativeParams { get { return Flags.HasFlag(Flag.NativeParams); } set { Flags = value ? (Flags | Flag.NativeParams) : (Flags & ~Flag.NativeParams); } }
		public bool HasSavedInfo { get { return Flags.HasFlag(Flag.SavedInfo); } set { Flags = value ? (Flags | Flag.SavedInfo) : (Flags & ~Flag.SavedInfo); } }
		public bool HasSavedCredentials { get { return Flags.HasFlag(Flag.SavedCredentials); } set { Flags = value ? (Flags | Flag.SavedCredentials) : (Flags & ~Flag.SavedCredentials); } }

		public Flag Flags { get; set; }
		public Int32 BotId { get; set; }
		public TLInvoice Invoice { get; set; }
		public Int32 ProviderId { get; set; }
		public String Url { get; set; }
		public String NativeProvider { get; set; }
		public TLDataJSON NativeParams { get; set; }
		public TLPaymentRequestedInfo SavedInfo { get; set; }
		public TLPaymentSavedCredentialsBase SavedCredentials { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLPaymentsPaymentForm() { }
		public TLPaymentsPaymentForm(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PaymentsPaymentForm; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			BotId = from.ReadInt32();
			Invoice = TLFactory.Read<TLInvoice>(from);
			ProviderId = from.ReadInt32();
			Url = from.ReadString();
			if (HasNativeProvider) NativeProvider = from.ReadString();
			if (HasNativeParams) NativeParams = TLFactory.Read<TLDataJSON>(from);
			if (HasSavedInfo) SavedInfo = TLFactory.Read<TLPaymentRequestedInfo>(from);
			if (HasSavedCredentials) SavedCredentials = TLFactory.Read<TLPaymentSavedCredentialsBase>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x3F56AEA3);
			to.Write((Int32)Flags);
			to.Write(BotId);
			to.WriteObject(Invoice);
			to.Write(ProviderId);
			to.Write(Url);
			if (HasNativeProvider) to.Write(NativeProvider);
			if (HasNativeParams) to.WriteObject(NativeParams);
			if (HasSavedInfo) to.WriteObject(SavedInfo);
			if (HasSavedCredentials) to.WriteObject(SavedCredentials);
			to.WriteObject(Users);
		}

		private void UpdateFlags()
		{
			HasNativeProvider = NativeProvider != null;
			HasNativeParams = NativeParams != null;
			HasSavedInfo = SavedInfo != null;
			HasSavedCredentials = SavedCredentials != null;
		}
	}
}