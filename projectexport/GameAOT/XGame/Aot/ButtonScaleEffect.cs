using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace XGame.Aot
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x20000F6")]
	public class ButtonScaleEffect : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x13774A0", Offset = "0x13768A0", VA = "0x1813774A0")]
		private void Awake()
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x13777F0", Offset = "0x1376BF0", VA = "0x1813777F0", Slot = "4")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x13776D0", Offset = "0x1376AD0", VA = "0x1813776D0", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1377530", Offset = "0x1376930", VA = "0x181377530")]
		private void DoScale(Vector3 scale)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x13775F0", Offset = "0x13769F0", VA = "0x1813775F0")]
		public bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1377910", Offset = "0x1376D10", VA = "0x181377910")]
		public ButtonScaleEffect()
		{
		}

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject parentTarget;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 targetScale;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic graphic;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Selectable selectable;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] needScales;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _mOriginScale;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _mTargetScale;
	}
}
