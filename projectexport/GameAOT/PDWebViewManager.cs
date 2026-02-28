using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

// Token: 0x0200002B RID: 43
[Token(Token = "0x2000012")]
public class PDWebViewManager : MonoBehaviour
{
	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600026A RID: 618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001F")]
	private Browser WebBrowser
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1380730", Offset = "0x137FB30", VA = "0x181380730")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x0600026B RID: 619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000020")]
	private GameObject WebviewCloseBtn
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1380B30", Offset = "0x137FF30", VA = "0x181380B30")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600026C RID: 620 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000021")]
	private GameObject WebviewCloseBg
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1380890", Offset = "0x137FC90", VA = "0x181380890")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600026D RID: 621 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000022")]
	private GameObject WebviewCloseBtn2
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1380970", Offset = "0x137FD70", VA = "0x181380970")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x137F240", Offset = "0x137E640", VA = "0x18137F240")]
	public void ShowWebviewCloseBtn(bool isShow, string pageType = "")
	{
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x137F0C0", Offset = "0x137E4C0", VA = "0x18137F0C0")]
	public void ShowWebviewCloseBg(bool isShow)
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x137F1B0", Offset = "0x137E5B0", VA = "0x18137F1B0")]
	public void ShowWebviewCloseBtn2(bool isShow, string pageType = "")
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x137E120", Offset = "0x137D520", VA = "0x18137E120")]
	private void Awake()
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x137F2D0", Offset = "0x137E6D0", VA = "0x18137F2D0")]
	private void Start()
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1380460", Offset = "0x137F860", VA = "0x181380460")]
	private void Update()
	{
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x137EA50", Offset = "0x137DE50", VA = "0x18137EA50")]
	private void RegisterJSFuncAll()
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x137E5A0", Offset = "0x137D9A0", VA = "0x18137E5A0")]
	public void OpenWebBrowser(string url, bool isShowClose, float width = 0f, float height = 0f)
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x137E310", Offset = "0x137D710", VA = "0x18137E310")]
	public void CloseWebBrowser()
	{
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x137E260", Offset = "0x137D660", VA = "0x18137E260")]
	public void ClearCookie()
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x137E520", Offset = "0x137D920", VA = "0x18137E520")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1C42E0", Offset = "0x1C36E0")]
	private IEnumerator DelayShow(bool isShowClose)
	{
		return null;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x13806A0", Offset = "0x137FAA0", VA = "0x1813806A0")]
	public PDWebViewManager()
	{
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1380320", Offset = "0x137F720", VA = "0x181380320")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <get_WebviewCloseBtn>b__11_0()
	{
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x137FF00", Offset = "0x137F300", VA = "0x18137FF00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <get_WebviewCloseBtn2>b__17_0()
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x137FE80", Offset = "0x137F280", VA = "0x18137FE80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <Start>b__22_0()
	{
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x137F360", Offset = "0x137E760", VA = "0x18137F360")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_0(JSONNode args)
	{
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x137F9D0", Offset = "0x137EDD0", VA = "0x18137F9D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_1(JSONNode args)
	{
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x137FA70", Offset = "0x137EE70", VA = "0x18137FA70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_2(JSONNode args)
	{
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x137FB10", Offset = "0x137EF10", VA = "0x18137FB10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_3(JSONNode args)
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x137FBB0", Offset = "0x137EFB0", VA = "0x18137FBB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_4(JSONNode args)
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x137FBD0", Offset = "0x137EFD0", VA = "0x18137FBD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_5(JSONNode args)
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x137FC60", Offset = "0x137F060", VA = "0x18137FC60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_6(JSONNode args)
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x137FCF0", Offset = "0x137F0F0", VA = "0x18137FCF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_7(JSONNode args)
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x137FBB0", Offset = "0x137EFB0", VA = "0x18137FBB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_8(JSONNode args)
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x137FD80", Offset = "0x137F180", VA = "0x18137FD80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_9(JSONNode args)
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x137F400", Offset = "0x137E800", VA = "0x18137F400")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_10(JSONNode args)
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x137F400", Offset = "0x137E800", VA = "0x18137F400")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_11(JSONNode args)
	{
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x137F470", Offset = "0x137E870", VA = "0x18137F470")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_12(JSONNode args)
	{
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x137F600", Offset = "0x137EA00", VA = "0x18137F600")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_13(JSONNode args)
	{
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x137F680", Offset = "0x137EA80", VA = "0x18137F680")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_14(JSONNode args)
	{
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x137F6B0", Offset = "0x137EAB0", VA = "0x18137F6B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_15(JSONNode args)
	{
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x137F710", Offset = "0x137EB10", VA = "0x18137F710")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_16(JSONNode args)
	{
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x137F7A0", Offset = "0x137EBA0", VA = "0x18137F7A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_17(JSONNode args)
	{
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x137F830", Offset = "0x137EC30", VA = "0x18137F830")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_18(JSONNode args)
	{
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x137F8A0", Offset = "0x137ECA0", VA = "0x18137F8A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private void <RegisterJSFuncAll>b__24_19(JSONNode args)
	{
	}

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x18")]
	public RawImage MaskGraphic;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x0")]
	public static PDWebViewManager Manager;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x20")]
	private PDWebCallBackHandler m_callbackHandler;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x28")]
	private string m_CurrentUrl;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x30")]
	public string m_PageType;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 m_CurrentSize;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x40")]
	private Browser m_WebBrowser;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_WebviewCloseBtn;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_WebviewCloseBg;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_WebviewCloseBtn2;

	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200014D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x138E650", Offset = "0x138DA50", VA = "0x18138E650")]
		internal void <OpenWebBrowser>b__0()
		{
		}

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x10")]
		public PDWebViewManager <>4__this;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x18")]
		public bool isShowClose;
	}

	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200014E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <DelayShow>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <DelayShow>d__28(int <>1__state)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x1385B80", Offset = "0x1384F80", VA = "0x181385B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000088")]
		private object Current
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x1385D60", Offset = "0x1385160", VA = "0x181385D60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000089")]
		private object Current
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x20")]
		public PDWebViewManager <>4__this;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x28")]
		public bool isShowClose;
	}
}
