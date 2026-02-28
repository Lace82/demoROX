using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace quicksdk
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000053")]
	public abstract class QuickSDKListenerAOT : MonoBehaviour
	{
		// Token: 0x06000398 RID: 920
		[Token(Token = "0x60002F5")]
		public abstract void onInitSuccess();

		// Token: 0x06000399 RID: 921
		[Token(Token = "0x60002F6")]
		public abstract void onInitFailed(ErrorMsg message);

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x12DB170", Offset = "0x12DA570", VA = "0x1812DB170")]
		public void onInitSuccess(string msg)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x38903F0", Offset = "0x388F7F0", VA = "0x1838903F0")]
		public void onInitFailed(string msg)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x38902D0", Offset = "0x388F6D0", VA = "0x1838902D0", Slot = "6")]
		public virtual void onConversionDataSuccess(Dictionary<string, string> dataMap)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x3890260", Offset = "0x388F660", VA = "0x183890260", Slot = "7")]
		public virtual void onConversionDataFail(string s)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x38901A0", Offset = "0x388F5A0", VA = "0x1838901A0", Slot = "8")]
		public virtual void onAppOpenAttribution(Dictionary<string, string> dataMap)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x38901F0", Offset = "0x388F5F0", VA = "0x1838901F0", Slot = "9")]
		public virtual void onAttributionFailure(string s)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x3890320", Offset = "0x388F720", VA = "0x183890320", Slot = "10")]
		public virtual void onConversionDataSuccess(string jsonString)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x38900D0", Offset = "0x388F4D0", VA = "0x1838900D0", Slot = "11")]
		public virtual void onAppOpenAttribution(string jsonString)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xB96E20", Offset = "0xB96220", VA = "0x180B96E20")]
		protected QuickSDKListenerAOT()
		{
		}
	}
}
