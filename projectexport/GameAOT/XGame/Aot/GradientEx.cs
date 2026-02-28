using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace XGame.Aot
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x20000F7")]
	public class GradientEx : BaseMeshEffect
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x137B740", Offset = "0x137AB40", VA = "0x18137B740", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x137B8E0", Offset = "0x137ACE0", VA = "0x18137B8E0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x137B790", Offset = "0x137AB90", VA = "0x18137B790")]
		private bool CompareCarefully(Color col1, Color col2)
		{
			return default(bool);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x137BFF0", Offset = "0x137B3F0", VA = "0x18137BFF0")]
		public GradientEx()
		{
		}

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x20")]
		public GradientMode gradientMode;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x24")]
		public GradientDir gradientDir;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x28")]
		public bool overwriteAllColor;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x2C")]
		public Color vertex1;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x3C")]
		public Color vertex2;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x50")]
		private Graphic _targetGraphic;
	}
}
