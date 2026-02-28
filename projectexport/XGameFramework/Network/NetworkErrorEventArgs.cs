using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class NetworkErrorEventArgs : BaseEventArgs
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2B988F0", Offset = "0x2B97CF0", VA = "0x182B988F0")]
		public NetworkErrorEventArgs()
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x1700005B")]
		public override int Id
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2B98970", Offset = "0x2B97D70", VA = "0x182B98970", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005C")]
		public INetworkChannel NetworkChannel
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00002B04 File Offset: 0x00000D04
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005D")]
		public NetworkErrorCode ErrorCode
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1087AB0", Offset = "0x1086EB0", VA = "0x181087AB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return NetworkErrorCode.Unknown;
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x1087E00", Offset = "0x1087200", VA = "0x181087E00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002B1C File Offset: 0x00000D1C
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005E")]
		public SocketError SocketErrorCode
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x1238560", Offset = "0x1237960", VA = "0x181238560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return SocketError.Success;
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x1238570", Offset = "0x1237970", VA = "0x181238570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005F")]
		public string ErrorMessage
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2B987A0", Offset = "0x2B97BA0", VA = "0x182B987A0")]
		public static NetworkErrorEventArgs Create(INetworkChannel networkChannel, NetworkErrorCode errorCode, SocketError socketErrorCode, string errorMessage)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2B98760", Offset = "0x2B97B60", VA = "0x182B98760", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int EventId;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private INetworkChannel <NetworkChannel>k__BackingField;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private NetworkErrorCode <ErrorCode>k__BackingField;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private SocketError <SocketErrorCode>k__BackingField;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <ErrorMessage>k__BackingField;
	}
}
