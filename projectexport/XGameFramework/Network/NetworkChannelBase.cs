using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	internal abstract class NetworkChannelBase : INetworkChannel, IDisposable
	{
		// Token: 0x17000050 RID: 80
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000050")]
		protected int AccumulativeSendCount
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xCD6F00", Offset = "0xCD6300", VA = "0x180CD6F00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000051")]
		protected int AccumulativeReceivedCount
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1477460", Offset = "0x1476860", VA = "0x181477460")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x17000052")]
		public float HeartBeatInterval
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1AB6EE0", Offset = "0x1AB62E0", VA = "0x181AB6EE0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2B97F90", Offset = "0x2B97390", VA = "0x182B97F90")]
		public void Tick(double deltaTime)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2B97BC0", Offset = "0x2B96FC0", VA = "0x182B97BC0", Slot = "6")]
		protected virtual bool ProcessSend()
		{
			return default(bool);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2B97F20", Offset = "0x2B97320", VA = "0x182B97F20")]
		public void ShutDown()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2B97530", Offset = "0x2B96930", VA = "0x182B97530", Slot = "7")]
		public void Close()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2B97900", Offset = "0x2B96D00", VA = "0x182B97900", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2B97A80", Offset = "0x2B96E80", VA = "0x182B97A80")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x10")]
		protected readonly Queue<Packet> sendPacketPool;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x18")]
		protected readonly EventPool<Packet> receivePacketPool;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		protected readonly INetworkChannelHelper networkChannelHelper;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x28")]
		protected Socket socket;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x30")]
		protected readonly SendState sendState;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x38")]
		protected readonly ReceiveState receiveState;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x40")]
		protected readonly HeartBeatState heartBeatState;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x48")]
		protected bool active;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x49")]
		private bool _bDisposed;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x50")]
		public Action<NetworkChannelBase, object> NetworkChannelConnected;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x58")]
		public Action<NetworkChannelBase> NetworkChannelClosed;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x60")]
		public Action<NetworkChannelBase, int> NetworkChannelHeartBeatMiss;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x68")]
		public Action<NetworkChannelBase, NetworkErrorCode, SocketError, string> NetworkChannelError;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x70")]
		public Action<NetworkChannelBase, object> NetworkChannelCustomError;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <AccumulativeSendCount>k__BackingField;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <AccumulativeReceivedCount>k__BackingField;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <HeartBeatInterval>k__BackingField;
	}
}
