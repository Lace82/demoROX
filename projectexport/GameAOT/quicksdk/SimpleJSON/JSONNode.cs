using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace quicksdk.SimpleJSON
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000055")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x8FFB0", Offset = "0x8F3B0")]
	public class JSONNode
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public virtual string Value
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x388FD80", Offset = "0x388F180", VA = "0x18388FD80", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x1700002E")]
		public virtual int Count
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x388E620", Offset = "0x388DA20", VA = "0x18388E620", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x14F4C60", Offset = "0x14F4060", VA = "0x1814F4C60", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002F")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x388FCB0", Offset = "0x388F0B0", VA = "0x18388FCB0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1CE600", Offset = "0x1CDA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000030")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x388FD10", Offset = "0x388F110", VA = "0x18388FD10")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1CEB40", Offset = "0x1CDF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x388F9B0", Offset = "0x388EDB0", VA = "0x18388F9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x388F980", Offset = "0x388ED80", VA = "0x18388F980", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x388FC00", Offset = "0x388F000", VA = "0x18388FC00", Slot = "18")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x3890080", Offset = "0x388F480", VA = "0x183890080", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000029E8 File Offset: 0x00000BE8
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x388FBB0", Offset = "0x388EFB0", VA = "0x18388FBB0", Slot = "20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x3890040", Offset = "0x388F440", VA = "0x183890040", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002A00 File Offset: 0x00000C00
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x388FB10", Offset = "0x388EF10", VA = "0x18388FB10", Slot = "22")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x3890000", Offset = "0x388F400", VA = "0x183890000", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x388FA50", Offset = "0x388EE50", VA = "0x18388FA50", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x388FF90", Offset = "0x388F390", VA = "0x18388FF90", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000035")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x388F9E0", Offset = "0x388EDE0", VA = "0x18388F9E0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000036")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x388FC40", Offset = "0x388F040", VA = "0x18388FC40", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x388FEB0", Offset = "0x388F2B0", VA = "0x18388FEB0")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x388FE30", Offset = "0x388F230", VA = "0x18388FE30")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x388FDB0", Offset = "0x388F1B0", VA = "0x18388FDB0")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x388FF10", Offset = "0x388F310", VA = "0x18388FF10")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x93EBC0", Offset = "0x93DFC0", VA = "0x18093EBC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x14D0CF0", Offset = "0x14D00F0", VA = "0x1814D0CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x388E9E0", Offset = "0x388DDE0", VA = "0x18388E9E0")]
		internal static string Escape(string aText)
		{
			return null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x388EE50", Offset = "0x388E250", VA = "0x18388EE50")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x388F900", Offset = "0x388ED00", VA = "0x18388F900")]
		public void SaveToStream(Stream aData)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x388F790", Offset = "0x388EB90", VA = "0x18388F790")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x388F730", Offset = "0x388EB30", VA = "0x18388F730")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x388F6D0", Offset = "0x388EAD0", VA = "0x18388F6D0")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x388F7F0", Offset = "0x388EBF0", VA = "0x18388F7F0")]
		public void SaveToFile(string aFileName)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x388F5A0", Offset = "0x388E9A0", VA = "0x18388F5A0")]
		public string SaveToBase64()
		{
			return null;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x388E680", Offset = "0x388DA80", VA = "0x18388E680")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x388EC20", Offset = "0x388E020", VA = "0x18388EC20")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x388EC80", Offset = "0x388E080", VA = "0x18388EC80")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x388EBC0", Offset = "0x388DFC0", VA = "0x18388EBC0")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x388ED90", Offset = "0x388E190", VA = "0x18388ED90")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x388ECE0", Offset = "0x388E0E0", VA = "0x18388ECE0")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x388EB10", Offset = "0x388DF10", VA = "0x18388EB10")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public JSONNode()
		{
		}

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000156")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x15DDF20", Offset = "0x15DD320", VA = "0x1815DDF20")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x00002A90 File Offset: 0x00000C90
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x38920D0", Offset = "0x38914D0", VA = "0x1838920D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700008A")]
			private JSONNode Current
			{
				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x3892170", Offset = "0x3891570", VA = "0x183892170", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700008B")]
			private object Current
			{
				[Token(Token = "0x6000B1C")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x38920E0", Offset = "0x38914E0", VA = "0x1838920E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x38920E0", Offset = "0x38914E0", VA = "0x1838920E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000554")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000555")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000556")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;
		}

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000157")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x15DDF20", Offset = "0x15DD320", VA = "0x1815DDF20")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x3892590", Offset = "0x3891990", VA = "0x183892590", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x38921C0", Offset = "0x38915C0", VA = "0x1838921C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x3892690", Offset = "0x3891A90", VA = "0x183892690")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x38926E0", Offset = "0x3891AE0", VA = "0x1838926E0")]
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700008C")]
			private JSONNode Current
			{
				[Token(Token = "0x6000B24")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x3892540", Offset = "0x3891940", VA = "0x183892540", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700008D")]
			private object Current
			{
				[Token(Token = "0x6000B26")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x38924A0", Offset = "0x38918A0", VA = "0x1838924A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x38924A0", Offset = "0x38918A0", VA = "0x1838924A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000557")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000558")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000559")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x400055A")]
			[FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x400055B")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x400055C")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;
		}
	}
}
