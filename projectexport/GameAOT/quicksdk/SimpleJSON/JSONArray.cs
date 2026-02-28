using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace quicksdk.SimpleJSON
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x2000056")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x8FFB0", Offset = "0x8F3B0")]
	public class JSONArray : JSONNode, IEnumerable
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x388BED0", Offset = "0x388B2D0", VA = "0x18388BED0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x388C060", Offset = "0x388B460", VA = "0x18388C060", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x388BF90", Offset = "0x388B390", VA = "0x18388BF90", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x388C000", Offset = "0x388B400", VA = "0x18388C000", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x17000039")]
		public override int Count
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x388BE90", Offset = "0x388B290", VA = "0x18388BE90", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x388B780", Offset = "0x388AB80", VA = "0x18388B780", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x388B850", Offset = "0x388AC50", VA = "0x18388B850", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x388B8F0", Offset = "0x388ACF0", VA = "0x18388B8F0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003A")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x388BE20", Offset = "0x388B220", VA = "0x18388BE20", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1D2230", Offset = "0x1D1630")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x388B7E0", Offset = "0x388ABE0", VA = "0x18388B7E0", Slot = "29")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1D2800", Offset = "0x1D1C00")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x388BA60", Offset = "0x388AE60", VA = "0x18388BA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x388BBD0", Offset = "0x388AFD0", VA = "0x18388BBD0", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x388B950", Offset = "0x388AD50", VA = "0x18388B950", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x388BDB0", Offset = "0x388B1B0", VA = "0x18388BDB0")]
		public JSONArray()
		{
		}

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x2000158")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x15DDF20", Offset = "0x15DD320", VA = "0x1815DDF20")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x3891CB0", Offset = "0x38910B0", VA = "0x183891CB0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x00002AD8 File Offset: 0x00000CD8
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x3891A60", Offset = "0x3890E60", VA = "0x183891A60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x3891D50", Offset = "0x3891150", VA = "0x183891D50")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700008E")]
			private JSONNode Current
			{
				[Token(Token = "0x6000B2D")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x3891C60", Offset = "0x3891060", VA = "0x183891C60", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700008F")]
			private object Current
			{
				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x3891BC0", Offset = "0x3890FC0", VA = "0x183891BC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x3891BC0", Offset = "0x3890FC0", VA = "0x183891BC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400055D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400055E")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400055F")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x4000560")]
			[FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x4000561")]
			[FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x2000159")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x3891630", Offset = "0x3890A30", VA = "0x183891630", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x00002AF0 File Offset: 0x00000CF0
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x3891480", Offset = "0x3890880", VA = "0x183891480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x38916D0", Offset = "0x3890AD0", VA = "0x1838916D0")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000090")]
			private object Current
			{
				[Token(Token = "0x6000B36")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x38915E0", Offset = "0x38909E0", VA = "0x1838915E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000091")]
			private object Current
			{
				[Token(Token = "0x6000B38")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000562")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000563")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000564")]
			[FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000565")]
			[FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;
		}
	}
}
