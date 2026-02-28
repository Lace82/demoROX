using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000D")]
public class PDCommandUI : MonoBehaviour
{
	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	private void Awake()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1D35F80", Offset = "0x1D35380", VA = "0x181D35F80")]
	private void Start()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1D33ED0", Offset = "0x1D332D0", VA = "0x181D33ED0")]
	private void ConfigData()
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1D35CB0", Offset = "0x1D350B0", VA = "0x181D35CB0")]
	private void ConstructCommandBtn(string title, UnityAction clickEvent)
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1D35E30", Offset = "0x1D35230", VA = "0x181D35E30")]
	private void ConstructCommandInput(string tips, out InputField input)
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	private void OnGUI()
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1D36BD0", Offset = "0x1D35FD0", VA = "0x181D36BD0")]
	public PDCommandUI()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1D361D0", Offset = "0x1D355D0", VA = "0x181D361D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <ConfigData>b__12_0()
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1D363C0", Offset = "0x1D357C0", VA = "0x181D363C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <ConfigData>b__12_1()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1D364B0", Offset = "0x1D358B0", VA = "0x181D364B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <ConfigData>b__12_3()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1D36890", Offset = "0x1D35C90", VA = "0x181D36890")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <ConfigData>b__12_8()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1D362C0", Offset = "0x1D356C0", VA = "0x181D362C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <ConfigData>b__12_14()
	{
	}

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	public GridLayoutGroup Grid;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CommandBtnPrefab;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CommandInputPrefab;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x30")]
	private string stringToEdit;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<string, UnityAction> btnDataModelDic;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x40")]
	private InputField inputCallVebViewAction;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x48")]
	private InputField inputCallVebViewCustom;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x50")]
	private InputField inputUserid;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x58")]
	private InputField inputRoleid;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x60")]
	private InputField inputServerid;

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x2000135")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1D53350", Offset = "0x1D52750", VA = "0x181D53350")]
		internal void <ConfigData>b__34()
		{
		}

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x10")]
		public string goodsName;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x18")]
		public int goodsNumber;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x20")]
		public string goodsId;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x28")]
		public string goodsRegisterId;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x30")]
		public double goodsPrice;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x38")]
		public string goodsDescribe;
	}

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000136")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public <>c()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1D52160", Offset = "0x1D51560", VA = "0x181D52160")]
		internal void <ConfigData>b__12_2()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1D52570", Offset = "0x1D51970", VA = "0x181D52570")]
		internal void <ConfigData>b__12_4()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1D526F0", Offset = "0x1D51AF0", VA = "0x181D526F0")]
		internal void <ConfigData>b__12_5()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1D52C40", Offset = "0x1D52040", VA = "0x181D52C40")]
		internal void <ConfigData>b__12_6()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1D531C0", Offset = "0x1D525C0", VA = "0x181D531C0")]
		internal void <ConfigData>b__12_7()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1D53260", Offset = "0x1D52660", VA = "0x181D53260")]
		internal void <ConfigData>b__12_9()
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1D51220", Offset = "0x1D50620", VA = "0x181D51220")]
		internal void <ConfigData>b__12_10()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1D51370", Offset = "0x1D50770", VA = "0x181D51370")]
		internal void <ConfigData>b__12_11()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1D514E0", Offset = "0x1D508E0", VA = "0x181D514E0")]
		internal void <ConfigData>b__12_12()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x1D51580", Offset = "0x1D50980", VA = "0x181D51580")]
		internal void <ConfigData>b__12_13()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x1D516D0", Offset = "0x1D50AD0", VA = "0x181D516D0")]
		internal void <ConfigData>b__12_15()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x1D517E0", Offset = "0x1D50BE0", VA = "0x181D517E0")]
		internal void <ConfigData>b__12_16()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x1D518B0", Offset = "0x1D50CB0", VA = "0x181D518B0")]
		internal void <ConfigData>b__12_17()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		internal void <ConfigData>b__12_18()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1D519A0", Offset = "0x1D50DA0", VA = "0x181D519A0")]
		internal void <ConfigData>b__12_19()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1D51A70", Offset = "0x1D50E70", VA = "0x181D51A70")]
		internal void <ConfigData>b__12_20()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1D51B60", Offset = "0x1D50F60", VA = "0x181D51B60")]
		internal void <ConfigData>b__12_21()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1D51CA0", Offset = "0x1D510A0", VA = "0x181D51CA0")]
		internal void <ConfigData>b__12_22()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1D51D40", Offset = "0x1D51140", VA = "0x181D51D40")]
		internal void <ConfigData>b__12_23()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x1D51DE0", Offset = "0x1D511E0", VA = "0x181D51DE0")]
		internal void <ConfigData>b__12_24()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x1D51F20", Offset = "0x1D51320", VA = "0x181D51F20")]
		internal void <ConfigData>b__12_25()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1D51F80", Offset = "0x1D51380", VA = "0x181D51F80")]
		internal void <ConfigData>b__12_26()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1D51FE0", Offset = "0x1D513E0", VA = "0x181D51FE0")]
		internal void <ConfigData>b__12_27()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1D52040", Offset = "0x1D51440", VA = "0x181D52040")]
		internal void <ConfigData>b__12_28()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x1D520E0", Offset = "0x1D514E0", VA = "0x181D520E0")]
		internal void <ConfigData>b__12_29()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x1D52220", Offset = "0x1D51620", VA = "0x181D52220")]
		internal void <ConfigData>b__12_30()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1D522D0", Offset = "0x1D516D0", VA = "0x181D522D0")]
		internal void <ConfigData>b__12_31()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1D52410", Offset = "0x1D51810", VA = "0x181D52410")]
		internal void <ConfigData>b__12_32()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x1D52490", Offset = "0x1D51890", VA = "0x181D52490")]
		internal void <ConfigData>b__12_33()
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PDCommandUI.<>c <>9;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__12_2;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x10")]
		public static UnityAction <>9__12_4;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x18")]
		public static UnityAction <>9__12_5;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x20")]
		public static UnityAction <>9__12_6;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x28")]
		public static UnityAction <>9__12_7;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x30")]
		public static UnityAction <>9__12_9;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x38")]
		public static UnityAction <>9__12_10;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x40")]
		public static UnityAction <>9__12_11;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x48")]
		public static UnityAction <>9__12_12;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x50")]
		public static UnityAction <>9__12_13;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x58")]
		public static UnityAction <>9__12_15;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x60")]
		public static UnityAction <>9__12_16;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x68")]
		public static UnityAction <>9__12_17;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x70")]
		public static UnityAction <>9__12_18;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x78")]
		public static UnityAction <>9__12_19;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x80")]
		public static UnityAction <>9__12_20;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x88")]
		public static UnityAction <>9__12_21;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x90")]
		public static UnityAction <>9__12_22;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x98")]
		public static UnityAction <>9__12_23;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0xA0")]
		public static UnityAction <>9__12_24;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0xA8")]
		public static UnityAction <>9__12_25;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0xB0")]
		public static UnityAction <>9__12_26;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0xB8")]
		public static UnityAction <>9__12_27;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0xC0")]
		public static UnityAction <>9__12_28;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0xC8")]
		public static UnityAction <>9__12_29;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0xD0")]
		public static UnityAction <>9__12_30;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0xD8")]
		public static UnityAction <>9__12_31;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0xE0")]
		public static UnityAction <>9__12_32;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0xE8")]
		public static UnityAction <>9__12_33;
	}
}
