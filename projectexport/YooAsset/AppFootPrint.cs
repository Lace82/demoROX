using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200006C")]
	internal class AppFootPrint
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public AppFootPrint(PersistentManager persistent)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1809120", Offset = "0x1808520", VA = "0x181809120")]
		public void Load(string packageName)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x18090F0", Offset = "0x18084F0", VA = "0x1818090F0")]
		public bool IsDirty()
		{
			return default(bool);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1809060", Offset = "0x1808460", VA = "0x181809060")]
		public void Coverage(string packageName)
		{
		}

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x10")]
		private PersistentManager _persistent;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x18")]
		private string _footPrint;
	}
}
