using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace quicksdk.SimpleJSON
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x2000057")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x8FFB0", Offset = "0x8F3B0")]
	public class JSONClass : JSONNode, IEnumerable
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public override JSONNode Item
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x388D000", Offset = "0x388C400", VA = "0x18388D000", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x388D0D0", Offset = "0x388C4D0", VA = "0x18388D0D0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x388CF70", Offset = "0x388C370", VA = "0x18388CF70", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x388D170", Offset = "0x388C570", VA = "0x18388D170", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x1700003D")]
		public override int Count
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x388CF20", Offset = "0x388C320", VA = "0x18388CF20", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x388C100", Offset = "0x388B500", VA = "0x18388C100", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x388C430", Offset = "0x388B830", VA = "0x18388C430", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x388C390", Offset = "0x388B790", VA = "0x18388C390", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x388C280", Offset = "0x388B680", VA = "0x18388C280", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003E")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x388CEB0", Offset = "0x388C2B0", VA = "0x18388CEB0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1D53F0", Offset = "0x1D47F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x388C210", Offset = "0x388B610", VA = "0x18388C210", Slot = "29")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1D59A0", Offset = "0x1D4DA0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x388CA90", Offset = "0x388BE90", VA = "0x18388CA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x388C690", Offset = "0x388BA90", VA = "0x18388C690", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x388C4E0", Offset = "0x388B8E0", VA = "0x18388C4E0", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x388CE40", Offset = "0x388C240", VA = "0x18388CE40")]
		public JSONClass()
		{
		}

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200015A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00002B20 File Offset: 0x00000D20
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x38919C0", Offset = "0x3890DC0", VA = "0x1838919C0")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000566")]
			[FieldOffset(Offset = "0x10")]
			public JSONNode aNode;
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200015B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x15DDF20", Offset = "0x15DD320", VA = "0x1815DDF20")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x3891FF0", Offset = "0x38913F0", VA = "0x183891FF0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00002B38 File Offset: 0x00000D38
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x3891D90", Offset = "0x3891190", VA = "0x183891D90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x3892090", Offset = "0x3891490", VA = "0x183892090")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000092")]
			private JSONNode Current
			{
				[Token(Token = "0x6000B3F")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x3891FA0", Offset = "0x38913A0", VA = "0x183891FA0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x0600041B RID: 1051 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000093")]
			private object Current
			{
				[Token(Token = "0x6000B41")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x3891F00", Offset = "0x3891300", VA = "0x183891F00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x3891F00", Offset = "0x3891300", VA = "0x183891F00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000567")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000568")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000569")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x400056A")]
			[FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400056B")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x200015C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x38918E0", Offset = "0x3890CE0", VA = "0x1838918E0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00002B50 File Offset: 0x00000D50
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x3891710", Offset = "0x3890B10", VA = "0x183891710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x3891980", Offset = "0x3890D80", VA = "0x183891980")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000094")]
			private object Current
			{
				[Token(Token = "0x6000B48")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x3891890", Offset = "0x3890C90", VA = "0x183891890", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000095")]
			private object Current
			{
				[Token(Token = "0x6000B4A")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400056C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400056E")]
			[FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400056F")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;
		}
	}
}
