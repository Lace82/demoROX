using System;
using Il2CppDummyDll;

namespace XGameFramework.Fsm
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public abstract class FsMachine
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006F")]
		public string Name
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000070")]
		public string FullName
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x2B964C0", Offset = "0x2B958C0", VA = "0x182B964C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002C9 RID: 713
		[Token(Token = "0x17000071")]
		public abstract Type OwnerType { [Token(Token = "0x60002C9")] get; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002CA RID: 714
		[Token(Token = "0x17000072")]
		public abstract int StateCount { [Token(Token = "0x60002CA")] get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002CB RID: 715
		[Token(Token = "0x17000073")]
		public abstract bool IsRunning { [Token(Token = "0x60002CB")] get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002CC RID: 716
		// (set) Token: 0x060002CD RID: 717
		[Token(Token = "0x17000074")]
		public abstract bool IsDestroyed { [Token(Token = "0x60002CC")] get; [Token(Token = "0x60002CD")] protected set; }

		// Token: 0x060002CE RID: 718
		[Token(Token = "0x60002CE")]
		internal abstract void Tick(double deltaTime);

		// Token: 0x060002CF RID: 719
		[Token(Token = "0x60002CF")]
		internal abstract void Shutdown();

		// Token: 0x060002D0 RID: 720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected FsMachine()
		{
		}

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <Name>k__BackingField;
	}
}
