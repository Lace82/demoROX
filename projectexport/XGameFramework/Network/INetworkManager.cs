using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public interface INetworkManager : IModule
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000218 RID: 536
		[Token(Token = "0x1700004F")]
		int NetworkChannelCount { [Token(Token = "0x6000218")] get; }

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000219 RID: 537
		// (remove) Token: 0x0600021A RID: 538
		[Token(Token = "0x14000002")]
		event EventHandler<NetworkConnectedEventArgs> NetworkConnected;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600021B RID: 539
		// (remove) Token: 0x0600021C RID: 540
		[Token(Token = "0x14000003")]
		event EventHandler<NetworkClosedEventArgs> NetworkClosed;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600021D RID: 541
		// (remove) Token: 0x0600021E RID: 542
		[Token(Token = "0x14000004")]
		event EventHandler<NetworkMissHeartBeatEventArgs> NetworkMissHeartBeat;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600021F RID: 543
		// (remove) Token: 0x06000220 RID: 544
		[Token(Token = "0x14000005")]
		event EventHandler<NetworkErrorEventArgs> NetworkError;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000221 RID: 545
		// (remove) Token: 0x06000222 RID: 546
		[Token(Token = "0x14000006")]
		event EventHandler<NetworkCustomErrorEventArgs> NetworkCustomError;

		// Token: 0x06000223 RID: 547
		[Token(Token = "0x6000223")]
		bool HasNetworkChannel(string channelName);

		// Token: 0x06000224 RID: 548
		[Token(Token = "0x6000224")]
		INetworkChannel GetNetworkChannel(string channelName);

		// Token: 0x06000225 RID: 549
		[Token(Token = "0x6000225")]
		INetworkChannel[] GetAllNetworkChannels();

		// Token: 0x06000226 RID: 550
		[Token(Token = "0x6000226")]
		T CreateNetworkChannel<T>(string channelName, INetworkChannelHelper networkChannelHelper) where T : class, INetworkChannel;

		// Token: 0x06000227 RID: 551
		[Token(Token = "0x6000227")]
		bool DestroyNetworkChannel(string channelName);
	}
}
