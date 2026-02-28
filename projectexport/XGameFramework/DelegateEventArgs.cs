using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	internal sealed class DelegateEventArgs : BaseEventArgs
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2B8F9B0", Offset = "0x2B8EDB0", VA = "0x182B8F9B0")]
		public DelegateEventArgs()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000030")]
		public override int Id
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1DCEB20", Offset = "0x1DCDF20", VA = "0x181DCEB20", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x17EC2B0", Offset = "0x17EB6B0", VA = "0x1817EC2B0")]
		public bool IsNull()
		{
			return default(bool);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2B8F840", Offset = "0x2B8EC40", VA = "0x182B8F840")]
		public void Combine(Delegate @delegate)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2B8F970", Offset = "0x2B8ED70", VA = "0x182B8F970")]
		public void Remove(Delegate @delegate)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2B8F880", Offset = "0x2B8EC80", VA = "0x182B8F880")]
		public static DelegateEventArgs Create(Delegate @delegate)
		{
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2B8F900", Offset = "0x2B8ED00", VA = "0x182B8F900")]
		public Delegate[] GetInvocations()
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2B8F800", Offset = "0x2B8EC00", VA = "0x182B8F800", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private Delegate _delegate;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		private Delegate[] _invocationArray;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x20")]
		private bool _bDirty;
	}
}
