using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace XGame.Aot
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x20000F5")]
	[ExecuteInEditMode]
	public class AutoFullScreenRule : UIBehaviour
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005E")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1377250", Offset = "0x1376650", VA = "0x181377250")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005F")]
		public Canvas canvas
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x13770B0", Offset = "0x13764B0", VA = "0x1813770B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1376E20", Offset = "0x1376220", VA = "0x181376E20")]
		private void CacheCanvas()
		{
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xECE500", Offset = "0xECD900", VA = "0x180ECE500", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xECE500", Offset = "0xECD900", VA = "0x180ECE500", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1376F70", Offset = "0x1376370", VA = "0x181376F70", Slot = "17")]
		protected virtual void HandleCutoutWithScreenSize()
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xECE530", Offset = "0xECD930", VA = "0x180ECE530")]
		public AutoFullScreenRule()
		{
		}

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x18")]
		private Canvas _mCanvas;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _mRectTransform;
	}
}
