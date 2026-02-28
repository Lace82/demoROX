using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using COSXML.Callback;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000010")]
public class PDSDK_PC
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000161 RID: 353 RVA: 0x00002268 File Offset: 0x00000468
	// (set) Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000005")]
	public static int JapanPayLimit
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1D46ED0", Offset = "0x1D462D0", VA = "0x181D46ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1D4AFB0", Offset = "0x1D4A3B0", VA = "0x181D4AFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		set
		{
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1D3C5D0", Offset = "0x1D3B9D0", VA = "0x181D3C5D0")]
	public static void LoginResultCallback(string buf, int buflen)
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1D3F120", Offset = "0x1D3E520", VA = "0x181D3F120")]
	public static void PayResultCallback(string buf, int buflen)
	{
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1D37EB0", Offset = "0x1D372B0", VA = "0x181D37EB0")]
	public static void AntiAddictionResultCallback(string buf, int buflen)
	{
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void CrashResultCallback(string buf, int buflen)
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1D37DC0", Offset = "0x1D371C0", VA = "0x181D37DC0")]
	public static void AddThreadAction(string threadAction, string data)
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000168 RID: 360 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000006")]
	public static string SDKLanguage
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1D47EA0", Offset = "0x1D472A0", VA = "0x181D47EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1D4B010", Offset = "0x1D4A410", VA = "0x181D4B010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private set
		{
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600016A RID: 362 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000007")]
	private static string Platform_account_url
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1D47A40", Offset = "0x1D46E40", VA = "0x181D47A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600016B RID: 363 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000008")]
	private static string LoginUrl
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600016C RID: 364 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000009")]
	private static string UsercenterUrl
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1D47F00", Offset = "0x1D47300", VA = "0x181D47F00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600016D RID: 365 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000A")]
	private static string AasTipsUrl
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1D45F10", Offset = "0x1D45310", VA = "0x181D45F10")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600016E RID: 366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000B")]
	private static string AccountOpenLoginUrl
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1D46050", Offset = "0x1D45450", VA = "0x181D46050")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600016F RID: 367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000C")]
	private static string Platform_webview_url
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1D47DC0", Offset = "0x1D471C0", VA = "0x181D47DC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000D")]
	private static string Platform_bbs_url
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1D47AA0", Offset = "0x1D46EA0", VA = "0x181D47AA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000171 RID: 369 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000E")]
	private static string Platform_pay_forbidden_url
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1D47B80", Offset = "0x1D46F80", VA = "0x181D47B80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000172 RID: 370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000F")]
	private static string Platform_pay_payback_url
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1D47C60", Offset = "0x1D47060", VA = "0x181D47C60")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000173 RID: 371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000010")]
	private static string GetProductsListUrl
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1D46BD0", Offset = "0x1D45FD0", VA = "0x181D46BD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000174 RID: 372 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000011")]
	private static string BillingCreateOrderUrl
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1D46470", Offset = "0x1D45870", VA = "0x181D46470")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000175 RID: 373 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000012")]
	private static string BillingCreateOrderAntiUrl
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1D46130", Offset = "0x1D45530", VA = "0x181D46130")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000176 RID: 374 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000013")]
	private static string BillingCreateOrderJapanLimitUrl
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1D462D0", Offset = "0x1D456D0", VA = "0x181D462D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000177 RID: 375 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000014")]
	private static string BillingVerifyOrderUrl
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1D467B0", Offset = "0x1D45BB0", VA = "0x181D467B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000178 RID: 376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000015")]
	private static string BillingPayBackUrl
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1D46610", Offset = "0x1D45A10", VA = "0x181D46610")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000179 RID: 377 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000016")]
	private static string OrderPayUrl
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1D47890", Offset = "0x1D46C90", VA = "0x181D47890")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600017A RID: 378 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000017")]
	private static string OrderPayGamebeansUrl
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1D47070", Offset = "0x1D46470", VA = "0x181D47070")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600017B RID: 379 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000018")]
	private static string OrderPayGlobalUrl
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1D474E0", Offset = "0x1D468E0", VA = "0x181D474E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600017C RID: 380 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000019")]
	private static string GetNewVersionUrl
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1D46950", Offset = "0x1D45D50", VA = "0x181D46950")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600017D RID: 381 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001A")]
	private static string WxCreateOrderUrl
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1D48040", Offset = "0x1D47440", VA = "0x181D48040")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600017E RID: 382 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001B")]
	private static string WxQrcodeUrl
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1D48160", Offset = "0x1D47560", VA = "0x181D48160")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001C")]
	private static string GetQQGroupUrl
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1D46D70", Offset = "0x1D46170", VA = "0x181D46D70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000180 RID: 384 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001D")]
	private static string GetPicsUrl
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1D46AF0", Offset = "0x1D45EF0", VA = "0x181D46AF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000181 RID: 385 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001E")]
	private static string GetStsTempTokenUrl
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1D46DF0", Offset = "0x1D461F0", VA = "0x181D46DF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1D3EEC0", Offset = "0x1D3E2C0", VA = "0x181D3EEC0")]
	public static void OpenWebBrowser(string url, int w, int h, bool isShowClose = true)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1D3A240", Offset = "0x1D39640", VA = "0x181D3A240")]
	public static void EncryptCommonProperty()
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1D3B880", Offset = "0x1D3AC80", VA = "0x181D3B880")]
	public static void Init()
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1D4AF10", Offset = "0x1D4A310", VA = "0x181D4AF10")]
	public static void setCommonProperty(string pKey, string pValue)
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1D45DF0", Offset = "0x1D451F0", VA = "0x181D45DF0")]
	public static string getCommonProperty(string pKey, string defaultValue = "")
	{
		return null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1D3CC40", Offset = "0x1D3C040", VA = "0x181D3CC40")]
	public static void Login(string customparams)
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1D3CBE0", Offset = "0x1D3BFE0", VA = "0x181D3CBE0")]
	public static void Login()
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1D43EC0", Offset = "0x1D432C0", VA = "0x181D43EC0")]
	public static string UserLoginType()
	{
		return null;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1D3CFF0", Offset = "0x1D3C3F0", VA = "0x181D3CFF0")]
	public static void Logout(string customparams)
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1D42BA0", Offset = "0x1D41FA0", VA = "0x181D42BA0")]
	public static void StartGame(string gameparams)
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1D39170", Offset = "0x1D38570", VA = "0x181D39170")]
	public static void CheckPayBack()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1D3B3C0", Offset = "0x1D3A7C0", VA = "0x181D3B3C0")]
	public static void GetProductsList()
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1D39370", Offset = "0x1D38770", VA = "0x181D39370")]
	public static void DoPay(string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1D3EB80", Offset = "0x1D3DF80", VA = "0x181D3EB80")]
	public static void OpenCertificationReal()
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1D435E0", Offset = "0x1D429E0", VA = "0x181D435E0")]
	public static void UserCenter()
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1D3D6B0", Offset = "0x1D3CAB0", VA = "0x181D3D6B0")]
	public static void OpenAasTips(int playStatus, int remainTime, string message)
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1D3A520", Offset = "0x1D39920", VA = "0x181D3A520")]
	public static void Exit()
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1D3AC00", Offset = "0x1D3A000", VA = "0x181D3AC00")]
	public static string GetAppKey()
	{
		return null;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1D3AC60", Offset = "0x1D3A060", VA = "0x181D3AC60")]
	public static string GetDeviceID()
	{
		return null;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1D3B120", Offset = "0x1D3A520", VA = "0x181D3B120")]
	public static string GetGclidShortID()
	{
		return null;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1D3C4D0", Offset = "0x1D3B8D0", VA = "0x181D3C4D0")]
	private static bool IsRegeditExist(string name)
	{
		return default(bool);
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1D42700", Offset = "0x1D41B00", VA = "0x181D42700")]
	private static void SetRegedit(string name, string value)
	{
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1D3B4A0", Offset = "0x1D3A8A0", VA = "0x181D3B4A0")]
	private static string GetRegedit(string name)
	{
		return null;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1D44470", Offset = "0x1D43870", VA = "0x181D44470")]
	public static void WebInvestigation()
	{
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1D38010", Offset = "0x1D37410", VA = "0x181D38010")]
	public static void CallWebView(string title, int fullscreen_flag, int title_flag, string action, string customparams)
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1D459D0", Offset = "0x1D44DD0", VA = "0x181D459D0")]
	public static void callCustomerServiceWeb()
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1D3B530", Offset = "0x1D3A930", VA = "0x181D3B530")]
	public static string GetSysLangue()
	{
		return null;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1D3B500", Offset = "0x1D3A900", VA = "0x181D3B500")]
	public static string GetSysCountry()
	{
		return null;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1D42770", Offset = "0x1D41B70", VA = "0x181D42770")]
	public static void SetSDKLanguage(string languageCode, [Optional] Action<string> callback)
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1D3C430", Offset = "0x1D3B830", VA = "0x181D3C430")]
	public static bool IsEuCountry()
	{
		return default(bool);
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1D39300", Offset = "0x1D38700", VA = "0x181D39300")]
	public static void DoOpenFBFanPage()
	{
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1D3B050", Offset = "0x1D3A450", VA = "0x181D3B050")]
	public static string GetECID()
	{
		return null;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1D3D3F0", Offset = "0x1D3C7F0", VA = "0x181D3D3F0")]
	public static void NoticeCenterState(int mode, string noticeID)
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1D37C10", Offset = "0x1D37010", VA = "0x181D37C10")]
	public static void AasRequest(string aasMode)
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1D3ED40", Offset = "0x1D3E140", VA = "0x181D3ED40")]
	public static void OpenCertification()
	{
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1D42320", Offset = "0x1D41720", VA = "0x181D42320")]
	public static void SaveImageToPhotoLibrary(string src)
	{
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1D3C520", Offset = "0x1D3B920", VA = "0x181D3C520")]
	public static void JoinQQGroup()
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1D3B810", Offset = "0x1D3AC10", VA = "0x181D3B810")]
	public static void InitBBS(string bbsparams)
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1D3DAA0", Offset = "0x1D3CEA0", VA = "0x181D3DAA0")]
	public static void OpenBBS(int screenOrientation, string type, string customparams)
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1D45B50", Offset = "0x1D44F50", VA = "0x181D45B50")]
	public static void doShare(string data)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1D42980", Offset = "0x1D41D80", VA = "0x181D42980")]
	public static void ShowPrivacyProtocol()
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1D3EDF0", Offset = "0x1D3E1F0", VA = "0x181D3EDF0")]
	public static void OpenStickFaceWebView(bool useLocal = false)
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1D3F4F0", Offset = "0x1D3E8F0", VA = "0x181D3F4F0")]
	public static void PrintAdCPSLog()
	{
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1D3FE10", Offset = "0x1D3F210", VA = "0x181D3FE10")]
	public static void PrintAdEventLog(string eventID, string remark)
	{
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1D3FBC0", Offset = "0x1D3EFC0", VA = "0x181D3FBC0")]
	public static void PrintAdEventLog_activate()
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1D3FCD0", Offset = "0x1D3F0D0", VA = "0x181D3FCD0")]
	public static void PrintAdEventLog_login()
	{
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1D408C0", Offset = "0x1D3FCC0", VA = "0x181D408C0")]
	public static void PrintAdEventLog_purchase(string price)
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1D40D50", Offset = "0x1D40150", VA = "0x181D40D50")]
	public static void PrintAdEventLog_purchase()
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1D40DC0", Offset = "0x1D401C0", VA = "0x181D40DC0")]
	public static void PrintAdEventLog_remain()
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1D40730", Offset = "0x1D3FB30", VA = "0x181D40730")]
	public static void PrintAdEventLog_online()
	{
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1D41010", Offset = "0x1D40410", VA = "0x181D41010")]
	public static void PrintGameEventLog(string eventID, string remark)
	{
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1D3F230", Offset = "0x1D3E630", VA = "0x181D3F230")]
	public static void PrintActiveLog()
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1D41650", Offset = "0x1D40A50", VA = "0x181D41650")]
	public static void PrintLoginLog()
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1D41BF0", Offset = "0x1D40FF0", VA = "0x181D41BF0")]
	public static void PrintStartLog()
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1D399E0", Offset = "0x1D38DE0", VA = "0x181D399E0")]
	public static string DoSetExtData(string data, string type)
	{
		return null;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1D3F090", Offset = "0x1D3E490", VA = "0x181D3F090")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AB4A0", Offset = "0x1AA8A0")]
	private static IEnumerator POST_SENDHTTPBILOG(string logType, string content)
	{
		return null;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1D4B0F0", Offset = "0x1D4A4F0", VA = "0x181D4B0F0")]
	public static void verifyToken(string msg)
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1D48C70", Offset = "0x1D48070", VA = "0x181D48C70")]
	public static void onLoginSuccess(string msg)
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1D48B60", Offset = "0x1D47F60", VA = "0x181D48B60")]
	public static void onLoginFailed(string msg)
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1D48930", Offset = "0x1D47D30", VA = "0x181D48930")]
	public static void onLoginCancel(string msg)
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1D484F0", Offset = "0x1D478F0", VA = "0x181D484F0")]
	public static void onCallWebviewSuccess(string msg)
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1D48270", Offset = "0x1D47670", VA = "0x181D48270")]
	public static void onCallWebviewCancel()
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1D4A2A0", Offset = "0x1D496A0", VA = "0x181D4A2A0")]
	public static void onOpenBBSSuccess()
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1D4A100", Offset = "0x1D49500", VA = "0x181D4A100")]
	public static void onOpenBBSCancel()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1D45620", Offset = "0x1D44A20", VA = "0x181D45620")]
	public static void bbsShare(string msg)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1D4ABB0", Offset = "0x1D49FB0", VA = "0x181D4ABB0")]
	public static void onRnaSuccess(string msg)
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1D4AA70", Offset = "0x1D49E70", VA = "0x181D4AA70")]
	public static void onRnaCancel(string msg)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1D4A800", Offset = "0x1D49C00", VA = "0x181D4A800")]
	public static void onPcPaySuccess(string msg)
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1D4A620", Offset = "0x1D49A20", VA = "0x181D4A620")]
	public static void onPcPayFailed(string msg)
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1D4A440", Offset = "0x1D49840", VA = "0x181D4A440")]
	public static void onPcPayCancel(string msg)
	{
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1D49F20", Offset = "0x1D49320", VA = "0x181D49F20")]
	public static void onNoticeCenterStateSuccess(string nodeId, string msg)
	{
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1D49D10", Offset = "0x1D49110", VA = "0x181D49D10")]
	public static void onNoticeCenterStateFailed(string nodeId, string msg)
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1D39FF0", Offset = "0x1D393F0", VA = "0x181D39FF0")]
	public static string Encode_DES(string str, string key)
	{
		return null;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void OnLangueChangeSuccess(string Langue)
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public static void OnLangueChangeFailed(string Langue)
	{
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1D3A350", Offset = "0x1D39750", VA = "0x181D3A350")]
	public static string Encrypt_MD5(string strPwd)
	{
		return null;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1D3AAC0", Offset = "0x1D39EC0", VA = "0x181D3AAC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AB9A0", Offset = "0x1AADA0")]
	private static IEnumerator GET_SUPERME(string url, string data, string opcode, string channelid)
	{
		return null;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1D3AB90", Offset = "0x1D39F90", VA = "0x181D3AB90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD270", Offset = "0x1AC670")]
	private static IEnumerator GET_WXORDER(string url)
	{
		return null;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1D3A7B0", Offset = "0x1D39BB0", VA = "0x181D3A7B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADAD0", Offset = "0x1ACED0")]
	private static IEnumerator GET_CREATORDER(string url)
	{
		return null;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1D3A990", Offset = "0x1D39D90", VA = "0x181D3A990")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADFF0", Offset = "0x1AD3F0")]
	private static IEnumerator GET_PAYBACK(string url)
	{
		return null;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1D3A820", Offset = "0x1D39C20", VA = "0x181D3A820")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE4E0", Offset = "0x1AD8E0")]
	private static IEnumerator GET_GOODSLIST(string url)
	{
		return null;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1D3A890", Offset = "0x1D39C90", VA = "0x181D3A890")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEC30", Offset = "0x1AE030")]
	private static IEnumerator GET_NEWVERSION(string url)
	{
		return null;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1D3A900", Offset = "0x1D39D00", VA = "0x181D3A900")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF390", Offset = "0x1AE790")]
	private static IEnumerator GET_NOTICECENTER(string url, string nodeId)
	{
		return null;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1D37B80", Offset = "0x1D36F80", VA = "0x181D37B80")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF8F0", Offset = "0x1AECF0")]
	private static IEnumerator ASS_REQUEST(string url, string aasMode)
	{
		return null;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1D3AA00", Offset = "0x1D39E00", VA = "0x181D3AA00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AFF00", Offset = "0x1AF300")]
	private static IEnumerator GET_QQ_GROUP_KEY()
	{
		return null;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1D37F80", Offset = "0x1D37380", VA = "0x181D37F80")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B04D0", Offset = "0x1AF8D0")]
	private static IEnumerator BBS_UPLOAD_FILE(string filePath, string Text)
	{
		return null;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1D3A700", Offset = "0x1D39B00", VA = "0x181D3A700")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B0AD0", Offset = "0x1AFED0")]
	private static IEnumerator GET_COS_TOKEN(string ImagePath, string Text, string para)
	{
		return null;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1D3AA50", Offset = "0x1D39E50", VA = "0x181D3AA50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B11D0", Offset = "0x1B05D0")]
	private static IEnumerator GET_STICK_FACE(bool useLocal)
	{
		return null;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1D3D5B0", Offset = "0x1D3C9B0", VA = "0x181D3D5B0")]
	public static void OnApplicationQuit()
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1D42EA0", Offset = "0x1D422A0", VA = "0x181D42EA0")]
	public static void Update()
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1D45AA0", Offset = "0x1D44EA0", VA = "0x181D45AA0")]
	private static string decode(string src, byte key)
	{
		return null;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1D39250", Offset = "0x1D38650", VA = "0x181D39250")]
	private static string DefaultCallbackMessage(string code, string message)
	{
		return null;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1D440E0", Offset = "0x1D434E0", VA = "0x181D440E0")]
	private static bool WNDENUMPROCback(IntPtr hwnd, uint lParam)
	{
		return default(bool);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1D3B220", Offset = "0x1D3A620", VA = "0x181D3B220")]
	public static IntPtr GetProcessWnd()
	{
		return 0;
	}

	// Token: 0x060001E0 RID: 480
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1D3B0B0", Offset = "0x1D3A4B0", VA = "0x181D3B0B0")]
	[PreserveSig]
	public static extern IntPtr GetForegroundWindow();

	// Token: 0x060001E1 RID: 481
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1D41F70", Offset = "0x1D41370", VA = "0x181D41F70")]
	[PreserveSig]
	public static extern int SDKInit(string gameID, IntPtr hwndParent, bool bExclusiveMode);

	// Token: 0x060001E2 RID: 482
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1D42140", Offset = "0x1D41540", VA = "0x181D42140")]
	[PreserveSig]
	public static extern int SDKShowLoginPanel(string appKey, bool backToLogin, PDSDK_PC.LoginCallback callBack);

	// Token: 0x060001E3 RID: 483
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1D42020", Offset = "0x1D41420", VA = "0x181D42020")]
	[PreserveSig]
	public static extern int SDKLogout();

	// Token: 0x060001E4 RID: 484
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1D422B0", Offset = "0x1D416B0", VA = "0x181D422B0")]
	[PreserveSig]
	public static extern int SDKUnInit();

	// Token: 0x060001E5 RID: 485
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1D42200", Offset = "0x1D41600", VA = "0x181D42200")]
	[PreserveSig]
	public static extern int SDKShowPayPanel(string info, PDSDK_PC.PayCallback callBack);

	// Token: 0x060001E6 RID: 486
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1D42090", Offset = "0x1D41490", VA = "0x181D42090")]
	[PreserveSig]
	public static extern int SDKOpenAntiAddiction(string info, PDSDK_PC.AntiAddictionCallback callbBack);

	// Token: 0x060001E7 RID: 487
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1D3A480", Offset = "0x1D39880", VA = "0x181D3A480")]
	[PreserveSig]
	public static extern bool EnumWindows(PDSDK_PC.WNDENUMPROC lpEnumFunc, uint lParam);

	// Token: 0x060001E8 RID: 488
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1D3B190", Offset = "0x1D3A590", VA = "0x181D3B190")]
	[PreserveSig]
	public static extern IntPtr GetParent(IntPtr hWnd);

	// Token: 0x060001E9 RID: 489
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1D3B780", Offset = "0x1D3AB80", VA = "0x181D3B780")]
	[PreserveSig]
	public static extern uint GetWindowThreadProcessId(IntPtr hWnd, ref uint lpdwProcessId);

	// Token: 0x060001EA RID: 490
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1D3B640", Offset = "0x1D3AA40", VA = "0x181D3B640")]
	[PreserveSig]
	public static extern int GetWindowTextLength(IntPtr hWnd);

	// Token: 0x060001EB RID: 491
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1D3B6C0", Offset = "0x1D3AAC0", VA = "0x181D3B6C0")]
	[PreserveSig]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int nMaxCount);

	// Token: 0x060001EC RID: 492
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1D3D320", Offset = "0x1D3C720", VA = "0x181D3D320")]
	[PreserveSig]
	public static extern int MessageBox(IntPtr handle, string message, string title, int type);

	// Token: 0x060001ED RID: 493
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1D42680", Offset = "0x1D41A80", VA = "0x181D42680")]
	[PreserveSig]
	public static extern void SetLastError(uint dwErrCode);

	// Token: 0x060001EE RID: 494
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1D3A640", Offset = "0x1D39A40", VA = "0x181D3A640")]
	[PreserveSig]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
	public PDSDK_PC()
	{
	}

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int webViewEnable;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string gameInfo;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string bbsInfo;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static JsonData commonPropertyJson;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string userToken;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string loginType;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static string deviceId;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string testUserId;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string _goodsName;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int _goodsNumber;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string _goodsId;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string _goodsRegisterId;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static double _goodsPrice;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string _customparams;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static string _goodsDes;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static readonly string qqhAppkey;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly string hxsyAppkey;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static string countersideAppkey;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static string _login_customparams;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static string _webviewAction;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly string SEPARATOR;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static readonly string INNER_SEPARATOR;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static readonly string mbi_version;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static string mbi_cps_id;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static readonly string CMBI_SDK_INIT_SUCCESS_ID;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private static readonly string CMBI_SDK_LOGIN_START_ID;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private static readonly string CMBI_SDK_LOGIN_SUCCESS_ID;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private static long lastSentAdOnlineTicks;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private static int lastSentAdOnlineMinute;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private static long lastAASTicks;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private static readonly string config_path;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private static readonly string config_path_d;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private static readonly string counterside_notice_path;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private static readonly string japan_agree_protocol;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private static readonly string cps_path;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private static int aas_certificate;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private static int aas_aas;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private static string aas_idcard;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private static long aas_cdate;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private static long aas_create;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private static int aas_isAdUser;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private static int aas_isRealName;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private static string aas_userId;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private static string aas_id_token;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private static long aas_polling;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private static string loginResultJson;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private static int <JapanPayLimit>k__BackingField;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public static string cosSecretId;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public static string cosSecretKey;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public static string cosSessionToken;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public static long cosAuthStart;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public static long cosAuthEnd;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private static JsonData _faceList;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private static PDSDK_PC.LoginCallback loginCallback;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private static PDSDK_PC.PayCallback payCallback;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private static PDSDK_PC.AntiAddictionCallback antiAddictionCallback;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private static PDSDK_PC.CrashCallback crashCallback;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private static readonly object threadActionlocker;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private static readonly Dictionary<string, string> threadActionDic;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private static bool threadActionFlag;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private static string <SDKLanguage>k__BackingField;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x4000083")]
	private const string kSDKLanguage = "kSDKLanguage";

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x4000084")]
	private const string m_SDKDefaultLanguage = "en";

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private static readonly List<string> m_EUCpuntryCodeList;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private static IntPtr ptrWnd;

	// Token: 0x02000017 RID: 23
	// (Invoke) Token: 0x060001F2 RID: 498
	[Token(Token = "0x200013A")]
	public delegate void LoginCallback(string buf, int buflen);

	// Token: 0x02000018 RID: 24
	// (Invoke) Token: 0x060001F6 RID: 502
	[Token(Token = "0x200013B")]
	public delegate void PayCallback(string buf, int buflen);

	// Token: 0x02000019 RID: 25
	// (Invoke) Token: 0x060001FA RID: 506
	[Token(Token = "0x200013C")]
	public delegate void AntiAddictionCallback(string buf, int buflen);

	// Token: 0x0200001A RID: 26
	// (Invoke) Token: 0x060001FE RID: 510
	[Token(Token = "0x200013D")]
	public delegate void CrashCallback(string buf, int buflen);

	// Token: 0x0200001B RID: 27
	// (Invoke) Token: 0x06000202 RID: 514
	[Token(Token = "0x200013E")]
	public delegate bool WNDENUMPROC(IntPtr hwnd, uint lParam);

	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200013F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <POST_SENDHTTPBILOG>d__182 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <POST_SENDHTTPBILOG>d__182(int <>1__state)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x138E320", Offset = "0x138D720", VA = "0x18138E320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006E")]
		private object Current
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x138E5E0", Offset = "0x138D9E0", VA = "0x18138E5E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006F")]
		private object Current
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string logType;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string content;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWW <www>5__2;
	}

	// Token: 0x0200001D RID: 29
	[Token(Token = "0x2000140")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_SUPERME>d__203 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_SUPERME>d__203(int <>1__state)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x138CB50", Offset = "0x138BF50", VA = "0x18138CB50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000070")]
		private object Current
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x138CD70", Offset = "0x138C170", VA = "0x18138CD70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000071")]
		private object Current
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string data;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string opcode;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string channelid;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string url;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWW <www>5__2;
	}

	// Token: 0x0200001E RID: 30
	[Token(Token = "0x2000141")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_WXORDER>d__204 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_WXORDER>d__204(int <>1__state)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x138CDC0", Offset = "0x138C1C0", VA = "0x18138CDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000072")]
		private object Current
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x138D270", Offset = "0x138C670", VA = "0x18138D270", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000073")]
		private object Current
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWW <www>5__2;
	}

	// Token: 0x0200001F RID: 31
	[Token(Token = "0x2000142")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_CREATORDER>d__205 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_CREATORDER>d__205(int <>1__state)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1386A60", Offset = "0x1385E60", VA = "0x181386A60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000074")]
		private object Current
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x13892D0", Offset = "0x13886D0", VA = "0x1813892D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000075")]
		private object Current
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <userId>5__2;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <roleId>5__3;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <roleName>5__4;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <serverId>5__5;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WWW <www>5__6;
	}

	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000143")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_PAYBACK>d__206 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_PAYBACK>d__206(int <>1__state)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x138A540", Offset = "0x1389940", VA = "0x18138A540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000076")]
		private object Current
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x138AB00", Offset = "0x1389F00", VA = "0x18138AB00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000077")]
		private object Current
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWW <www>5__2;
	}

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000144")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_GOODSLIST>d__207 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_GOODSLIST>d__207(int <>1__state)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1389320", Offset = "0x1388720", VA = "0x181389320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000078")]
		private object Current
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x13897B0", Offset = "0x1388BB0", VA = "0x1813897B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000079")]
		private object Current
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWW <www>5__2;
	}

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000145")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_NEWVERSION>d__208 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_NEWVERSION>d__208(int <>1__state)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x1389800", Offset = "0x1388C00", VA = "0x181389800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007A")]
		private object Current
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x1389C70", Offset = "0x1389070", VA = "0x181389C70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007B")]
		private object Current
		{
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWW <www>5__2;
	}

	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000146")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_NOTICECENTER>d__209 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_NOTICECENTER>d__209(int <>1__state)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1389CC0", Offset = "0x13890C0", VA = "0x181389CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007C")]
		private object Current
		{
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x138A4F0", Offset = "0x13898F0", VA = "0x18138A4F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007D")]
		private object Current
		{
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWW <www>5__2;
	}

	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000147")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <ASS_REQUEST>d__210 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <ASS_REQUEST>d__210(int <>1__state)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1384CD0", Offset = "0x13840D0", VA = "0x181384CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007E")]
		private object Current
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1385500", Offset = "0x1384900", VA = "0x181385500", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007F")]
		private object Current
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string aasMode;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WWW <www>5__2;
	}

	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000148")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_QQ_GROUP_KEY>d__211 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_QQ_GROUP_KEY>d__211(int <>1__state)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x138AB50", Offset = "0x1389F50", VA = "0x18138AB50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000080")]
		private object Current
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x138AFA0", Offset = "0x138A3A0", VA = "0x18138AFA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000081")]
		private object Current
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WWW <www>5__2;
	}

	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000149")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <BBS_UPLOAD_FILE>d__212 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <BBS_UPLOAD_FILE>d__212(int <>1__state)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x1385550", Offset = "0x1384950", VA = "0x181385550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000082")]
		private object Current
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x1385B30", Offset = "0x1384F30", VA = "0x181385B30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000083")]
		private object Current
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filePath;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Text;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest <www>5__2;
	}

	// Token: 0x02000027 RID: 39
	[Token(Token = "0x200014A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public <>c()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		internal void <GET_COS_TOKEN>b__213_0(long completed, long total)
		{
		}

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PDSDK_PC.<>c <>9;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OnProgressCallback <>9__213_0;
	}

	// Token: 0x02000028 RID: 40
	[Token(Token = "0x200014B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_COS_TOKEN>d__213 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_COS_TOKEN>d__213(int <>1__state)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x1385DB0", Offset = "0x13851B0", VA = "0x181385DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000084")]
		private object Current
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x1386A10", Offset = "0x1385E10", VA = "0x181386A10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000085")]
		private object Current
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ImagePath;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Text;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string para;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <roleId>5__2;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWW <www>5__3;
	}

	// Token: 0x02000029 RID: 41
	[Token(Token = "0x200014C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_STICK_FACE>d__214 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_STICK_FACE>d__214(int <>1__state)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x138AFF0", Offset = "0x138A3F0", VA = "0x18138AFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000086")]
		private object Current
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x138CB00", Offset = "0x138BF00", VA = "0x18138CB00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000087")]
		private object Current
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocal;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <userId>5__2;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <roleId>5__3;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <roleLevel>5__4;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <roleName>5__5;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <serverId>5__6;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <vipLevel>5__7;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int <balance>5__8;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private WWW <www>5__9;
	}
}
