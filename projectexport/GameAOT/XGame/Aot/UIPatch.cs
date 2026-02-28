using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace XGame.Aot
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x20000FD")]
	public class UIPatch : MonoBehaviour
	{
		// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xED6E80", Offset = "0xED6280", VA = "0x180ED6E80")]
		private void Start()
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xED6DE0", Offset = "0xED61E0", VA = "0x180ED6DE0")]
		public void SetVersionText(string version)
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000900")]
		[Address(RVA = "0xED6C00", Offset = "0xED6000", VA = "0x180ED6C00")]
		public void RefreshText()
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000901")]
		[Address(RVA = "0xB96E20", Offset = "0xB96220", VA = "0x180B96E20")]
		public UIPatch()
		{
		}

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x18")]
		public Camera cgCamera;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x20")]
		public Image background;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x28")]
		public Button btnPlayback;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x30")]
		public Text playbackTxt;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x38")]
		public Button btnSkip;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x40")]
		public Text skipTxt;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x48")]
		public GameObject uiUpdateTip;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x50")]
		public Text versionText;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x58")]
		public Slider slider;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject enterGameAwardGo;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x68")]
		public Text tipTxt;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x70")]
		public Text percentTxt;
	}
}
