using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace XGame.Aot
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x200010E")]
	public class GraphicRaycasterBugFixedByHm : GraphicRaycaster
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000067")]
		private Canvas canvas2
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x137D610", Offset = "0x137CA10", VA = "0x18137D610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x137C4F0", Offset = "0x137B8F0", VA = "0x18137C4F0", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x137C030", Offset = "0x137B430", VA = "0x18137C030")]
		private static void Raycast2(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x137D580", Offset = "0x137C980", VA = "0x18137D580")]
		public GraphicRaycasterBugFixedByHm()
		{
		}

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private List<Graphic> m_RaycastResults2;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x48")]
		private Canvas m_Canvas2;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics2;

		// Token: 0x02000164 RID: 356
		[Token(Token = "0x2000188")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c()
			{
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x000046B0 File Offset: 0x000028B0
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0xED5550", Offset = "0xED4950", VA = "0x180ED5550")]
			internal int <Raycast2>b__6_0(Graphic g1, Graphic g2)
			{
				return 0;
			}

			// Token: 0x0400061D RID: 1565
			[Token(Token = "0x4000616")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GraphicRaycasterBugFixedByHm.<>c <>9;

			// Token: 0x0400061E RID: 1566
			[Token(Token = "0x4000617")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Graphic> <>9__6_0;
		}
	}
}
