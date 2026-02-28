using System;
using Il2CppDummyDll;

namespace quicksdk.SimpleJSON
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000059")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x8FFB0", Offset = "0x8F3B0")]
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2A22E00", Offset = "0x2A22200", VA = "0x182A22E00")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xCD69C0", Offset = "0xCD5DC0", VA = "0x180CD69C0")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x388D950", Offset = "0x388CD50", VA = "0x18388D950")]
		private void Set(JSONNode aVal)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public override JSONNode Item
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x388DF60", Offset = "0x388D360", VA = "0x18388DF60", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x388E4F0", Offset = "0x388D8F0", VA = "0x18388E4F0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public override JSONNode Item
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x388DFD0", Offset = "0x388D3D0", VA = "0x18388DFD0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x388E3B0", Offset = "0x388D7B0", VA = "0x18388E3B0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x388D810", Offset = "0x388CC10", VA = "0x18388D810", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x388D6D0", Offset = "0x388CAD0", VA = "0x18388D6D0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x388D940", Offset = "0x388CD40", VA = "0x18388D940")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x388E050", Offset = "0x388D450", VA = "0x18388E050")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x388D940", Offset = "0x388CD40", VA = "0x18388D940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x14D0CF0", Offset = "0x14D00F0", VA = "0x1814D0CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x388D9C0", Offset = "0x388CDC0", VA = "0x18388D9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x388D9F0", Offset = "0x388CDF0", VA = "0x18388D9F0", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public override int AsInt
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x388DD90", Offset = "0x388D190", VA = "0x18388DD90", Slot = "18")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x388E2E0", Offset = "0x388D6E0", VA = "0x18388E2E0", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00002BE0 File Offset: 0x00000DE0
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public override float AsFloat
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x388DCC0", Offset = "0x388D0C0", VA = "0x18388DCC0", Slot = "20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x388E210", Offset = "0x388D610", VA = "0x18388E210", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public override double AsDouble
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x388DBF0", Offset = "0x388CFF0", VA = "0x18388DBF0", Slot = "22")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x388E140", Offset = "0x388D540", VA = "0x18388E140", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00002C10 File Offset: 0x00000E10
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public override bool AsBool
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x388DB20", Offset = "0x388CF20", VA = "0x18388DB20", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x388E060", Offset = "0x388D460", VA = "0x18388E060", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000046")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x388DA20", Offset = "0x388CE20", VA = "0x18388DA20", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000047")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x388DE60", Offset = "0x388D260", VA = "0x18388DE60", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x18")]
		private string m_Key;
	}
}
