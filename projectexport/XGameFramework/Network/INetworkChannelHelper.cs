using System;
using System.IO;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public interface INetworkChannelHelper
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000214 RID: 532
		[Token(Token = "0x1700004E")]
		int PacketHeaderLength { [Token(Token = "0x6000214")] get; }

		// Token: 0x06000215 RID: 533
		[Token(Token = "0x6000215")]
		void Shutdown();

		// Token: 0x06000216 RID: 534
		[Token(Token = "0x6000216")]
		bool SendHeartBeat();

		// Token: 0x06000217 RID: 535
		[Token(Token = "0x6000217")]
		bool Serialize<T>(T packet, Stream destination) where T : Packet;
	}
}
