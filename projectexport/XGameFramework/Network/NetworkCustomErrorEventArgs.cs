using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class NetworkCustomErrorEventArgs : BaseEventArgs
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2B984F0", Offset = "0x2B978F0", VA = "0x182B984F0")]
		public NetworkCustomErrorEventArgs()
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x17000058")]
		public override int Id
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2B98700", Offset = "0x2B97B00", VA = "0x182B98700", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000059")]
		public INetworkChannel NetworkChannel
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005A")]
		public object CustomErrorData
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2B985D0", Offset = "0x2B979D0", VA = "0x182B985D0")]
		public static NetworkCustomErrorEventArgs Create(INetworkChannel networkChannel, object customErrorData)
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x13760B0", Offset = "0x13754B0", VA = "0x1813760B0", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int EVENT_ID;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private INetworkChannel <NetworkChannel>k__BackingField;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private object <CustomErrorData>k__BackingField;
	}
}
