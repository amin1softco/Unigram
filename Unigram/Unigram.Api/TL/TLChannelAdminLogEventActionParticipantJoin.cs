// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelAdminLogEventActionParticipantJoin : TLChannelAdminLogEventActionBase 
	{
		public TLChannelAdminLogEventActionParticipantJoin() { }
		public TLChannelAdminLogEventActionParticipantJoin(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelAdminLogEventActionParticipantJoin; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x183040D3);
		}
	}
}