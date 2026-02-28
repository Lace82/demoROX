using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace XGame.Aot
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x20000FE")]
	public class UI_UpdateTip : MonoBehaviour
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000902")]
		[Address(RVA = "0xED7CC0", Offset = "0xED70C0", VA = "0x180ED7CC0")]
		public static void Init(GameObject go)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000903")]
		[Address(RVA = "0xED83F0", Offset = "0xED77F0", VA = "0x180ED83F0")]
		public static void Show(string content, int alertType, string confirmBtnTxt, Action<object> callback)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x6000904")]
		[Address(RVA = "0xED7D30", Offset = "0xED7130", VA = "0x180ED7D30")]
		public static bool IsShowing()
		{
			return default(bool);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000905")]
		[Address(RVA = "0xED7A90", Offset = "0xED6E90", VA = "0x180ED7A90")]
		public static void Close()
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000906")]
		[Address(RVA = "0xED8180", Offset = "0xED7580", VA = "0x180ED8180")]
		protected void OpenWindow(string content, string confirmBtnTxt, int alertType, Action<object> callback)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000907")]
		[Address(RVA = "0xED7FF0", Offset = "0xED73F0", VA = "0x180ED7FF0")]
		protected void OnRegistWindow()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000908")]
		[Address(RVA = "0xED80F0", Offset = "0xED74F0", VA = "0x180ED80F0")]
		protected void OnUnRegistWindow()
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000909")]
		[Address(RVA = "0xED7E40", Offset = "0xED7240", VA = "0x180ED7E40")]
		protected void OnOpenWindow()
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090A")]
		[Address(RVA = "0xED7DE0", Offset = "0xED71E0", VA = "0x180ED7DE0")]
		private void OnBtnConfirm()
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090B")]
		[Address(RVA = "0xED7D80", Offset = "0xED7180", VA = "0x180ED7D80")]
		private void OnBtnCancel()
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090C")]
		[Address(RVA = "0xED79E0", Offset = "0xED6DE0", VA = "0x180ED79E0")]
		private void CloseWindow()
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090D")]
		[Address(RVA = "0xED7B70", Offset = "0xED6F70", VA = "0x180ED7B70")]
		public static void GotoUpdateClient()
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090E")]
		[Address(RVA = "0xED82E0", Offset = "0xED76E0", VA = "0x180ED82E0")]
		public static void ShowUpdateClientAlert(string url)
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090F")]
		[Address(RVA = "0xED85B0", Offset = "0xED79B0", VA = "0x180ED85B0")]
		public UI_UpdateTip()
		{
		}

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x400047E")]
		public const int TYPE_OK = 1;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x400047F")]
		public const int TYPE_CANCEL = 16;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x4000480")]
		public const int TYPE_OK_CANCEL = 17;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x0")]
		private static UI_UpdateTip _mUpdateTip;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject mConfirmBtn;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text mConfirmTxt;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject mCancelBtn;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_CancelTxt;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text mContentTxt;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text mTitleTxt;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x48")]
		private string _mText;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x50")]
		private Action<object> _mCallBack;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x58")]
		private string _mConfirmTxt;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x60")]
		private int _mAlertType;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x64")]
		private bool _mIsShowing;

		// Token: 0x0200014C RID: 332
		[Token(Token = "0x2000180")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c()
			{
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0xED54D0", Offset = "0xED48D0", VA = "0x180ED54D0")]
			internal void <GotoUpdateClient>b__26_0(object ret)
			{
			}

			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x4000602")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UI_UpdateTip.<>c <>9;

			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x4000603")]
			[FieldOffset(Offset = "0x8")]
			public static Action<object> <>9__26_0;
		}

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x2000181")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0xED55A0", Offset = "0xED49A0", VA = "0x180ED55A0")]
			internal void <ShowUpdateClientAlert>b__0(object ret)
			{
			}

			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x4000604")]
			[FieldOffset(Offset = "0x10")]
			public string url;
		}
	}
}
