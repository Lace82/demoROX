using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class NetworkMissHeartBeatEventArgs : BaseEventArgs
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2B9A710", Offset = "0x2B99B10", VA = "0x182B9A710")]
		public NetworkMissHeartBeatEventArgs()
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x17000061")]
		public override int Id
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2B9A780", Offset = "0x2B99B80", VA = "0x182B9A780", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000062")]
		public INetworkChannel NetworkChannel
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002BAC File Offset: 0x00000DAC
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000063")]
		public int MissCount
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xB9A920", Offset = "0xB99D20", VA = "0x180B9A920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1238580", Offset = "0x1237980", VA = "0x181238580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2B9A5F0", Offset = "0x2B999F0", VA = "0x182B9A5F0")]
		public static NetworkMissHeartBeatEventArgs Create(INetworkChannel networkChannel, int missCount)
		{
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2856D50", Offset = "0x2856150", VA = "0x182856D50", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int EVENT_ID;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private INetworkChannel <NetworkChannel>k__BackingField;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <MissCount>k__BackingField;
	}
}
