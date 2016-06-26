// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannel : TLChatBase 
	{
		[Flags]
		public enum Flag : int
		{
			Creator = (1 << 0),
			Kicked = (1 << 1),
			Left = (1 << 2),
			Editor = (1 << 3),
			Moderator = (1 << 4),
			Broadcast = (1 << 5),
			Verified = (1 << 7),
			Megagroup = (1 << 8),
			Restricted = (1 << 9),
			Democracy = (1 << 10),
			Signatures = (1 << 11),
			Min = (1 << 12),
			AccessHash = (1 << 13),
			Username = (1 << 6),
			RestrictionReason = (1 << 9),
		}

		public bool IsCreator { get { return Flags.HasFlag(Flag.Creator); } set { Flags = value ? (Flags | Flag.Creator) : (Flags & ~Flag.Creator); } }
		public bool IsKicked { get { return Flags.HasFlag(Flag.Kicked); } set { Flags = value ? (Flags | Flag.Kicked) : (Flags & ~Flag.Kicked); } }
		public bool IsLeft { get { return Flags.HasFlag(Flag.Left); } set { Flags = value ? (Flags | Flag.Left) : (Flags & ~Flag.Left); } }
		public bool IsEditor { get { return Flags.HasFlag(Flag.Editor); } set { Flags = value ? (Flags | Flag.Editor) : (Flags & ~Flag.Editor); } }
		public bool IsModerator { get { return Flags.HasFlag(Flag.Moderator); } set { Flags = value ? (Flags | Flag.Moderator) : (Flags & ~Flag.Moderator); } }
		public bool IsBroadcast { get { return Flags.HasFlag(Flag.Broadcast); } set { Flags = value ? (Flags | Flag.Broadcast) : (Flags & ~Flag.Broadcast); } }
		public bool IsVerified { get { return Flags.HasFlag(Flag.Verified); } set { Flags = value ? (Flags | Flag.Verified) : (Flags & ~Flag.Verified); } }
		public bool IsMegagroup { get { return Flags.HasFlag(Flag.Megagroup); } set { Flags = value ? (Flags | Flag.Megagroup) : (Flags & ~Flag.Megagroup); } }
		public bool IsRestricted { get { return Flags.HasFlag(Flag.Restricted); } set { Flags = value ? (Flags | Flag.Restricted) : (Flags & ~Flag.Restricted); } }
		public bool IsDemocracy { get { return Flags.HasFlag(Flag.Democracy); } set { Flags = value ? (Flags | Flag.Democracy) : (Flags & ~Flag.Democracy); } }
		public bool IsSignatures { get { return Flags.HasFlag(Flag.Signatures); } set { Flags = value ? (Flags | Flag.Signatures) : (Flags & ~Flag.Signatures); } }
		public bool IsMin { get { return Flags.HasFlag(Flag.Min); } set { Flags = value ? (Flags | Flag.Min) : (Flags & ~Flag.Min); } }
		public bool HasAccessHash { get { return Flags.HasFlag(Flag.AccessHash); } set { Flags = value ? (Flags | Flag.AccessHash) : (Flags & ~Flag.AccessHash); } }
		public bool HasUsername { get { return Flags.HasFlag(Flag.Username); } set { Flags = value ? (Flags | Flag.Username) : (Flags & ~Flag.Username); } }
		public bool HasRestrictionReason { get { return Flags.HasFlag(Flag.RestrictionReason); } set { Flags = value ? (Flags | Flag.RestrictionReason) : (Flags & ~Flag.RestrictionReason); } }

		public Flag Flags { get; set; }
		public Int64? AccessHash { get; set; }
		public String Username { get; set; }
		public String RestrictionReason { get; set; }

		public TLChannel() { }
		public TLChannel(TLBinaryReader from, TLType type = TLType.Channel)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.Channel; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.Channel)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt32();
			if (HasAccessHash) { AccessHash = from.ReadInt64(); }
			Title = from.ReadString();
			if (HasUsername) { Username = from.ReadString(); }
			Photo = TLFactory.Read<TLChatPhotoBase>(from);
			Date = from.ReadInt32();
			Version = from.ReadInt32();
			if (HasRestrictionReason) { RestrictionReason = from.ReadString(); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA14DCA52);
			to.Write((Int32)Flags);
			to.Write(Id);
			if (HasAccessHash) to.Write(AccessHash.Value);
			to.Write(Title);
			if (HasUsername) to.Write(Username);
			to.WriteObject(Photo);
			to.Write(Date);
			to.Write(Version);
			if (HasRestrictionReason) to.Write(RestrictionReason);
		}
	}
}