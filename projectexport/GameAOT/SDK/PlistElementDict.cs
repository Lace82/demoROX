using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x200005F")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x8FFB0", Offset = "0x8F3B0")]
	public class PlistElementDict : PlistElement
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1382D60", Offset = "0x1382160", VA = "0x181382D60")]
		public PlistElementDict()
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000049")]
		public IDictionary<string, PlistElement> values
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public new PlistElement Item
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1382DD0", Offset = "0x13821D0", VA = "0x181382DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1382F20", Offset = "0x1382320", VA = "0x181382F20")]
			set
			{
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1382C20", Offset = "0x1382020", VA = "0x181382C20")]
		public void SetInteger(string key, int val)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1382CC0", Offset = "0x13820C0", VA = "0x181382CC0")]
		public void SetString(string key, string val)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1382B80", Offset = "0x1381F80", VA = "0x181382B80")]
		public void SetBoolean(string key, bool val)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x13829C0", Offset = "0x1381DC0", VA = "0x1813829C0")]
		public PlistElementArray CreateArray(string key)
		{
			return null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1382AA0", Offset = "0x1381EA0", VA = "0x181382AA0")]
		public PlistElementDict CreateDict(string key)
		{
			return null;
		}

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x10")]
		private readonly SortedDictionary<string, PlistElement> m_PrivateValue;
	}
}
