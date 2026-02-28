using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using quicksdk;

namespace Code.GameAot.SDK
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000065")]
	public class QuickEventHandlerAOT : QuickSDKListenerAOT
	{
		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x276F320", Offset = "0x276E720", VA = "0x18276F320", Slot = "4")]
		public override void onInitSuccess()
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x276F2D0", Offset = "0x276E6D0", VA = "0x18276F2D0", Slot = "5")]
		public override void onInitFailed(ErrorMsg message)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x276F270", Offset = "0x276E670", VA = "0x18276F270", Slot = "6")]
		public override void onConversionDataSuccess(Dictionary<string, string> conversionInfo)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xECE530", Offset = "0xECD930", VA = "0x180ECE530")]
		public QuickEventHandlerAOT()
		{
		}
	}
}
