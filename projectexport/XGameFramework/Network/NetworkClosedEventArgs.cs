using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class NetworkClosedEventArgs : BaseEventArgs
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2B982F0", Offset = "0x2B976F0", VA = "0x182B982F0")]
		public NetworkClosedEventArgs()
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x17000053")]
		public override int Id
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2B98360", Offset = "0x2B97760", VA = "0x182B98360", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000054")]
		public INetworkChannel NetworkChannel
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2B981E0", Offset = "0x2B975E0", VA = "0x182B981E0")]
		public static NetworkClosedEventArgs Create(INetworkChannel networkChannel)
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x13E9170", Offset = "0x13E8570", VA = "0x1813E9170", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int EVENT_ID;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private INetworkChannel <NetworkChannel>k__BackingField;
	}
}
