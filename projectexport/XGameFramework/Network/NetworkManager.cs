using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	internal sealed class NetworkManager : ITick, INetworkManager, IModule
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2B99F60", Offset = "0x2B99360", VA = "0x182B99F60")]
		public NetworkManager()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "22")]
		public void OnInit()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x17000060")]
		public int NetworkChannelCount
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2B9A320", Offset = "0x2B99720", VA = "0x182B9A320", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600025A RID: 602 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600025B RID: 603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000007")]
		public event EventHandler<NetworkConnectedEventArgs> NetworkConnected
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x2B9A120", Offset = "0x2B99520", VA = "0x182B9A120", Slot = "7")]
			add
			{
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2B9A3F0", Offset = "0x2B997F0", VA = "0x182B9A3F0", Slot = "8")]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600025C RID: 604 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000008")]
		public event EventHandler<NetworkClosedEventArgs> NetworkClosed
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2B9A0A0", Offset = "0x2B994A0", VA = "0x182B9A0A0", Slot = "9")]
			add
			{
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2B9A370", Offset = "0x2B99770", VA = "0x182B9A370", Slot = "10")]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600025E RID: 606 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000009")]
		public event EventHandler<NetworkMissHeartBeatEventArgs> NetworkMissHeartBeat
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x2B9A2A0", Offset = "0x2B996A0", VA = "0x182B9A2A0", Slot = "11")]
			add
			{
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2B9A570", Offset = "0x2B99970", VA = "0x182B9A570", Slot = "12")]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000260 RID: 608 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000261 RID: 609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000A")]
		public event EventHandler<NetworkErrorEventArgs> NetworkError
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2B9A220", Offset = "0x2B99620", VA = "0x182B9A220", Slot = "13")]
			add
			{
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2B9A4F0", Offset = "0x2B998F0", VA = "0x182B9A4F0", Slot = "14")]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000262 RID: 610 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000B")]
		public event EventHandler<NetworkCustomErrorEventArgs> NetworkCustomError
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2B9A1A0", Offset = "0x2B995A0", VA = "0x182B9A1A0", Slot = "15")]
			add
			{
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2B9A470", Offset = "0x2B99870", VA = "0x182B9A470", Slot = "16")]
			remove
			{
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2B98FB0", Offset = "0x2B983B0", VA = "0x182B98FB0", Slot = "17")]
		public bool HasNetworkChannel(string channelName)
		{
			return default(bool);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2B98F20", Offset = "0x2B98320", VA = "0x182B98F20", Slot = "18")]
		public INetworkChannel GetNetworkChannel(string channelName)
		{
			return null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2B98D60", Offset = "0x2B98160", VA = "0x182B98D60", Slot = "19")]
		public INetworkChannel[] GetAllNetworkChannels()
		{
			return null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000267")]
		public T CreateNetworkChannel<T>(string channelName, INetworkChannelHelper networkChannelHelper) where T : class, INetworkChannel
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2B989D0", Offset = "0x2B97DD0", VA = "0x182B989D0", Slot = "21")]
		public bool DestroyNetworkChannel(string channelName)
		{
			return default(bool);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2B98FA0", Offset = "0x2B983A0", VA = "0x182B98FA0", Slot = "5")]
		public int GetPriority()
		{
			return 0;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2B99E40", Offset = "0x2B99240", VA = "0x182B99E40", Slot = "4")]
		public void Tick(double deltaTime)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2B99A40", Offset = "0x2B98E40", VA = "0x182B99A40", Slot = "23")]
		public void Shutdown()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2B99200", Offset = "0x2B98600", VA = "0x182B99200")]
		private void OnNetworkChannelConnected(INetworkChannel networkChannel, object userData)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2B99010", Offset = "0x2B98410", VA = "0x182B99010")]
		private void OnNetworkChannelClosed(INetworkChannel networkChannel)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2B99840", Offset = "0x2B98C40", VA = "0x182B99840")]
		private void OnNetworkChannelMissHeartBeat(INetworkChannel networkChannel, int heartBeatMissCount)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2B99620", Offset = "0x2B98A20", VA = "0x182B99620")]
		private void OnNetworkChannelError(INetworkChannel networkChannel, NetworkErrorCode errorCode, SocketError socketErrorCode, string errorMessage)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2B99410", Offset = "0x2B98810", VA = "0x182B99410")]
		private void OnNetworkChannelCustomError(INetworkChannel networkChannel, object customErrorData)
		{
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, NetworkChannelBase> _networkChannels;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<NetworkConnectedEventArgs> _networkConnectedHandler;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<NetworkClosedEventArgs> _networkClosedHandler;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		private EventHandler<NetworkMissHeartBeatEventArgs> _networkMissHeartBeatHandler;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x30")]
		private EventHandler<NetworkErrorEventArgs> _networkErrorHandler;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x38")]
		private EventHandler<NetworkCustomErrorEventArgs> _networkCustomErrorHandler;
	}
}
