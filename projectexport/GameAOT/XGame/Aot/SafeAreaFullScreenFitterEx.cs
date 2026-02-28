using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace XGame.Aot
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000104")]
	public class SafeAreaFullScreenFitterEx : UIBehaviour
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000062")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0xECE5C0", Offset = "0xECD9C0", VA = "0x180ECE5C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000063")]
		public Canvas canvas
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0xECE540", Offset = "0xECD940", VA = "0x180ECE540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000933")]
		[Address(RVA = "0xECE170", Offset = "0xECD570", VA = "0x180ECE170")]
		private void CacheCanvas()
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0xECE500", Offset = "0xECD900", VA = "0x180ECE500", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000935")]
		[Address(RVA = "0xECE500", Offset = "0xECD900", VA = "0x180ECE500", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000936")]
		[Address(RVA = "0xECE310", Offset = "0xECD710", VA = "0x180ECE310", Slot = "17")]
		protected virtual void HandleCutoutWithScreenSize()
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000937")]
		[Address(RVA = "0xECE530", Offset = "0xECD930", VA = "0x180ECE530")]
		public SafeAreaFullScreenFitterEx()
		{
		}

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x18")]
		private Canvas _mCanvas;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _mRectTransform;
	}
}
