using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class NetworkConnectedEventArgs : BaseEventArgs
	{
		// Token: 0x06000238 RID: 568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2B984F0", Offset = "0x2B978F0", VA = "0x182B984F0")]
		public NetworkConnectedEventArgs()
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x17000055")]
		public override int Id
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2B98570", Offset = "0x2B97970", VA = "0x182B98570", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000056")]
		public INetworkChannel NetworkChannel
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000057")]
		public object UserData
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2B983C0", Offset = "0x2B977C0", VA = "0x182B983C0")]
		public static NetworkConnectedEventArgs Create(INetworkChannel networkChannel, object userData)
		{
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x13760B0", Offset = "0x13754B0", VA = "0x1813760B0", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int EVENT_ID;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private INetworkChannel <NetworkChannel>k__BackingField;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private object <UserData>k__BackingField;
	}
}
