using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Code.GameAot.SDK;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000011 RID: 17
[Token(Token = "0x200000E")]
public class PDSDK : MonoBehaviour
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000004")]
	public static PDSDK Instance
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1D4C100", Offset = "0x1D4B500", VA = "0x181D4C100")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1D36C40", Offset = "0x1D36040", VA = "0x181D36C40")]
	private void Awake()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1D4B640", Offset = "0x1D4AA40", VA = "0x181D4B640")]
	private void Update()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1D37A40", Offset = "0x1D36E40", VA = "0x181D37A40")]
	public void OnApplicationQuit()
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	protected void OnApplicationPause(bool pause)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1D37650", Offset = "0x1D36A50", VA = "0x181D37650")]
	public void Init()
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1D37380", Offset = "0x1D36780", VA = "0x181D37380")]
	private string GetApplicationVersion()
	{
		return null;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1D37720", Offset = "0x1D36B20", VA = "0x181D37720")]
	public void Login(string customparams, [Optional] Action<LoginResultData> loginResultCallback)
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void ResetGuest(string customparams)
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1D376C0", Offset = "0x1D36AC0", VA = "0x181D376C0")]
	public void LoginWithType(string login_type, string customparams)
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1D377A0", Offset = "0x1D36BA0", VA = "0x181D377A0")]
	public void Logout(string customparams, [Optional] Action<LoginResultData> logoutResultCallback)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1D4B440", Offset = "0x1D4A840", VA = "0x181D4B440")]
	public void StartGame(string gameparams)
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1D374F0", Offset = "0x1D368F0", VA = "0x181D374F0")]
	public void GetProductsList([Optional] Action<JsonData> onGetProductsList)
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void restorePayment()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1D371C0", Offset = "0x1D365C0", VA = "0x181D371C0")]
	public void DoPay(string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes, [Optional] Action<int, string> onDoPayCallback)
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1D370C0", Offset = "0x1D364C0", VA = "0x181D370C0")]
	public void DoPayWithLimit(int limitLevel, string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void DoPromotingPay(string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void DoPromotingWithLimitPay(int limitLevel, string goodsName, int goodsNumber, string goodsId, string goodsRegisterId, double goodsPrice, string customparams, string goodsDes)
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doAddLocalPush(string Title, string Content, string Date, string Hour, string Min)
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doFirstScreen()
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void SwitchUser()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1D506B0", Offset = "0x1D4FAB0", VA = "0x181D506B0")]
	public void userCenter()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1D4BC80", Offset = "0x1D4B080", VA = "0x181D4BC80")]
	public void exit([Optional] Action exitGameCallback)
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1D37620", Offset = "0x1D36A20", VA = "0x181D37620")]
	public string GetPushToken()
	{
		return null;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void bindPushAccount(string pushAccount)
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1D372E0", Offset = "0x1D366E0", VA = "0x181D372E0")]
	public string GetAppKey()
	{
		return null;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1D374A0", Offset = "0x1D368A0", VA = "0x181D374A0")]
	public string GetDeviceID()
	{
		return null;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000098")]
	[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
	public int GetBattery()
	{
		return 0;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1D4B6E0", Offset = "0x1D4AAE0", VA = "0x181D4B6E0")]
	public void WebInvestigation()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void PathOrder()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void ShowPayHelp()
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1D50530", Offset = "0x1D4F930", VA = "0x181D50530")]
	public void printGameEventLog(string eventID, string remark)
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1D4BB90", Offset = "0x1D4AF90", VA = "0x181D4BB90")]
	public string doSetExtData(string data, string type)
	{
		return null;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1D4BDE0", Offset = "0x1D4B1E0", VA = "0x181D4BDE0")]
	public string getChannelID()
	{
		return null;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1D4BB30", Offset = "0x1D4AF30", VA = "0x181D4BB30")]
	public void doSaveImageToPhotoLibrary(string data)
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doQQVIP()
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1D4B900", Offset = "0x1D4AD00", VA = "0x181D4B900")]
	public void callWebView(string title, int fullscreen_flag, int title_flag, string action, string customparams)
	{
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void clearLocalNotifications()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1D4B7F0", Offset = "0x1D4ABF0", VA = "0x181D4B7F0")]
	public void callCustomerServiceWeb()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void callCustomerService()
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1D4BC00", Offset = "0x1D4B000", VA = "0x181D4BC00")]
	public void doshare(string data, [Optional] Action<int, string> onShareCallback)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doGetImagePath(int nType, int fromType)
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1D4B690", Offset = "0x1D4AA90", VA = "0x181D4B690")]
	public string UserLoginType()
	{
		return null;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doUnBind()
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doBindGuest(string bind_type)
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1D505C0", Offset = "0x1D4F9C0", VA = "0x181D505C0")]
	public void setSDKLangue(string langue)
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1D4BEE0", Offset = "0x1D4B2E0", VA = "0x181D4BEE0")]
	public string getSysCountry()
	{
		return null;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1D4BF90", Offset = "0x1D4B390", VA = "0x181D4BF90")]
	public string getSysLangue()
	{
		return null;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1D4BA80", Offset = "0x1D4AE80", VA = "0x181D4BA80")]
	public void doOpenFBFanPage()
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1D4BE40", Offset = "0x1D4B240", VA = "0x181D4BE40")]
	public string getECID()
	{
		return null;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1D4C310", Offset = "0x1D4B710", VA = "0x181D4C310")]
	public bool isEuCountry()
	{
		return default(bool);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void payGiftCard(string giftid, string customparams)
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1D505A0", Offset = "0x1D4F9A0", VA = "0x181D505A0")]
	public bool requestPermission(string permission, string customparams, Action<int> requestPermissionCallback)
	{
		return default(bool);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160")]
	public bool checkPermission(string permission, string customparams)
	{
		return default(bool);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void showLoadingUI(bool isShow)
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void confirmDownloadFullRes()
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void openDownloadFullResUI(bool isShow)
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void updateDownloadFullResProgress(string downloadInfo)
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1D4B400", Offset = "0x1D4A800", VA = "0x181D4B400")]
	public void RegisterConfirmDownloadFullResAction(Action<string> onSuccess, Action<string> onCancel)
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1D4CCA0", Offset = "0x1D4C0A0", VA = "0x181D4CCA0")]
	public void onConfirmDownloadFullResSuccess(string msg)
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1D4CC10", Offset = "0x1D4C010", VA = "0x181D4CC10")]
	public void onConfirmDownloadFullResCancel(string msg)
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void setActivityPauseResumeEnable(bool enable)
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x14D5EF0", Offset = "0x14D52F0", VA = "0x1814D5EF0")]
	public int lb_singleFileDownload(string fileName)
	{
		return 0;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void lb_downloadFullRes(bool noPrompt)
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1237900", Offset = "0x1236D00", VA = "0x181237900")]
	public long lb_getTotalSize(bool compress)
	{
		return 0L;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1237900", Offset = "0x1236D00", VA = "0x181237900")]
	public long lb_getCurrentDlSize()
	{
		return 0L;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void lb_openDownload()
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void lb_closeDownload()
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x14D5EF0", Offset = "0x14D52F0", VA = "0x1814D5EF0")]
	public int lb_getDownloadStatus()
	{
		return 0;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1D4C4E0", Offset = "0x1D4B8E0", VA = "0x181D4C4E0")]
	public void noticeCenterState(int mode, string noticeID, Action<int, string> noticeResultCallback)
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doStartRecord()
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doStopRecord()
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doBoradcast()
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doOpenRequestReview()
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doStartQRLogin(string customParams)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1D4B990", Offset = "0x1D4AD90", VA = "0x181D4B990")]
	public void doOpenCertification()
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xE29610", Offset = "0xE28A10", VA = "0x180E29610")]
	public int checkSystemPushFlag()
	{
		return 0;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void openAppSetting()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
	public int getHorizontalOffset()
	{
		return 0;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
	public int getVerticalOffset()
	{
		return 0;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xE29620", Offset = "0xE28A20", VA = "0x180E29620")]
	public int getSignalStrength()
	{
		return 0;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1D4C3F0", Offset = "0x1D4B7F0", VA = "0x181D4C3F0")]
	public void joinQQGroup()
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1D4C260", Offset = "0x1D4B660", VA = "0x181D4C260")]
	public void initBBS(string bbsparams)
	{
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1D504C0", Offset = "0x1D4F8C0", VA = "0x181D504C0")]
	public void openBBS(int screenOrientation, string type, string customparams)
	{
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1D50660", Offset = "0x1D4FA60", VA = "0x181D50660")]
	public void showPrivacyProtocol()
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void doUploadImagePath()
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1D4CB60", Offset = "0x1D4BF60", VA = "0x181D4CB60")]
	public void onCheckGiftCardItemInfoSuccess(string msg)
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1D4ECE0", Offset = "0x1D4E0E0", VA = "0x181D4ECE0")]
	public void onPayGiftCardSuccess(string msg)
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1D4EC30", Offset = "0x1D4E030", VA = "0x181D4EC30")]
	public void onPayGiftCardFailed(string msg)
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1D4DFD0", Offset = "0x1D4D3D0", VA = "0x181D4DFD0")]
	public void onLoginSuccess(string msg)
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1D4DE80", Offset = "0x1D4D280", VA = "0x181D4DE80")]
	public void onLoginFailed(string msg)
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1D4DD30", Offset = "0x1D4D130", VA = "0x181D4DD30")]
	public void onLoginCancel(string msg)
	{
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", VA = "0x181D4E420")]
	public void onLogoutSuccess(string msg)
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1D4E2D0", Offset = "0x1D4D6D0", VA = "0x181D4E2D0")]
	public void onLogoutFailed(string msg)
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1D4E180", Offset = "0x1D4D580", VA = "0x181D4E180")]
	public void onLogoutCancel(string msg)
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1D4D840", Offset = "0x1D4CC40", VA = "0x181D4D840")]
	public void onGetProductsListSuccess(string msg)
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1D4D790", Offset = "0x1D4CB90", VA = "0x181D4D790")]
	public void onGetProductsListFailed(string msg)
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1D4ED90", Offset = "0x1D4E190", VA = "0x181D4ED90")]
	public void onPaySuccess(string msg)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1D4EB00", Offset = "0x1D4DF00", VA = "0x181D4EB00")]
	public void onPayFailed(string msg)
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1D4E9D0", Offset = "0x1D4DDD0", VA = "0x181D4E9D0")]
	public void onPayCancel(string msg)
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1D4F690", Offset = "0x1D4EA90", VA = "0x181D4F690")]
	public void onSDKPromotingPaySuccess(string msg)
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1D4F5E0", Offset = "0x1D4E9E0", VA = "0x181D4F5E0")]
	public void onSDKPromotingPayFailed(string msg)
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1D4F530", Offset = "0x1D4E930", VA = "0x181D4F530")]
	public void onSDKPromotingPayCancel(string msg)
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1D4D6E0", Offset = "0x1D4CAE0", VA = "0x181D4D6E0")]
	public void onGetPayHistorySuccess(string msg)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1D4D630", Offset = "0x1D4CA30", VA = "0x181D4D630")]
	public void onGetPayHistoryFailed(string msg)
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1D4DA80", Offset = "0x1D4CE80", VA = "0x181D4DA80")]
	public void onInitSuccess(string msg)
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1D4D9D0", Offset = "0x1D4CDD0", VA = "0x181D4D9D0")]
	public void onInitFailed(string msg)
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1D4D420", Offset = "0x1D4C820", VA = "0x181D4D420")]
	public void onForceUpdate(string msg)
	{
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1D50410", Offset = "0x1D4F810", VA = "0x181D50410")]
	public void onswitchUserSuccess(string msg)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1D50360", Offset = "0x1D4F760", VA = "0x181D50360")]
	public void onswitchUserFailed(string msg)
	{
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1D502B0", Offset = "0x1D4F6B0", VA = "0x181D502B0")]
	public void onswitchUserCancel(string msg)
	{
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1D4FF60", Offset = "0x1D4F360", VA = "0x181D4FF60")]
	public void onVerifyTokenSuccess(string msg)
	{
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1D4FEB0", Offset = "0x1D4F2B0", VA = "0x181D4FEB0")]
	public void onVerifyTokenFailed(string msg)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1D4D090", Offset = "0x1D4C490", VA = "0x181D4D090")]
	public void onDoSetExtDataSuccess(string msg)
	{
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1D4CFE0", Offset = "0x1D4C3E0", VA = "0x181D4CFE0")]
	public void onDoSetExtDataFailed(string msg)
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1D4D350", Offset = "0x1D4C750", VA = "0x181D4D350")]
	public void onExitSuccess(string msg)
	{
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1D4D2A0", Offset = "0x1D4C6A0", VA = "0x181D4D2A0")]
	public void onExitFailed(string msg)
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1D4E5A0", Offset = "0x1D4D9A0", VA = "0x181D4E5A0")]
	public void onMemoryWarning(string recode)
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1D4FAC0", Offset = "0x1D4EEC0", VA = "0x181D4FAC0")]
	public void onShareSuccess(string msg)
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1D4F990", Offset = "0x1D4ED90", VA = "0x181D4F990")]
	public void onShareFailed(string msg)
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1D4F860", Offset = "0x1D4EC60", VA = "0x181D4F860")]
	public void onShareCancel(string msg)
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1D4D4D0", Offset = "0x1D4C8D0", VA = "0x181D4D4D0")]
	private void onGetImagePathFailed(string msg)
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1D4D580", Offset = "0x1D4C980", VA = "0x181D4D580")]
	private void onGetImagePathSuccess(string msg)
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1D4F180", Offset = "0x1D4E580", VA = "0x181D4F180")]
	private void onRecordStartSuccess(string msg)
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1D4F0D0", Offset = "0x1D4E4D0", VA = "0x181D4F0D0")]
	private void onRecordStartFail(string msg)
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1D4F2E0", Offset = "0x1D4E6E0", VA = "0x181D4F2E0")]
	private void onRecordStopSuccess(string msg)
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1D4F230", Offset = "0x1D4E630", VA = "0x181D4F230")]
	private void onRecordStopFail(string msg)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1D4CAB0", Offset = "0x1D4BEB0", VA = "0x181D4CAB0")]
	private void onBoradcastSuccess(string msg)
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1D4CA00", Offset = "0x1D4BE00", VA = "0x181D4CA00")]
	private void onBoradcastFail(string msg)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1D4CDD0", Offset = "0x1D4C1D0", VA = "0x181D4CDD0")]
	private void onDoQuestionSuccess(string msg)
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1D4CD20", Offset = "0x1D4C120", VA = "0x181D4CD20")]
	private void onDoQuestionFailed(string msg)
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1D501D0", Offset = "0x1D4F5D0", VA = "0x181D501D0")]
	public void oncallWebViewSuccess(string msg)
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1D500F0", Offset = "0x1D4F4F0", VA = "0x181D500F0")]
	public void oncallWebViewFailed(string msg)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1D50010", Offset = "0x1D4F410", VA = "0x181D50010")]
	public void oncallWebViewCancel(string msg)
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1D4E920", Offset = "0x1D4DD20", VA = "0x181D4E920")]
	public void onOpenBBSSuccess(string msg)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1D4E870", Offset = "0x1D4DC70", VA = "0x181D4E870")]
	public void onOpenBBSCancel(string msg)
	{
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void onWebViewOpen()
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void onWebViewClose()
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1D4F020", Offset = "0x1D4E420", VA = "0x181D4F020")]
	private void onQRLoginSuccess(string msg)
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1D4EF70", Offset = "0x1D4E370", VA = "0x181D4EF70")]
	private void onQRLoginFailed(string msg)
	{
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1D4EEC0", Offset = "0x1D4E2C0", VA = "0x181D4EEC0")]
	private void onQRLoginCancel(string msg)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1D4CF30", Offset = "0x1D4C330", VA = "0x181D4CF30")]
	public void onDoSaveImageToPhotoLibrarySuccess(string msg)
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1D4CE80", Offset = "0x1D4C280", VA = "0x181D4CE80")]
	public void onDoSaveImageToPhotoLibraryFailed(string msg)
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1D4C950", Offset = "0x1D4BD50", VA = "0x181D4C950")]
	private void onBindGuestSuccess(string msg)
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1D4C8A0", Offset = "0x1D4BCA0", VA = "0x181D4C8A0")]
	private void onBindGuestFailed(string msg)
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1D4C7F0", Offset = "0x1D4BBF0", VA = "0x181D4C7F0")]
	private void onBindGuestCancel(string msg)
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1D4DC80", Offset = "0x1D4D080", VA = "0x181D4DC80")]
	private void onLangueChangeSuccess(string msg)
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1D4DBD0", Offset = "0x1D4CFD0", VA = "0x181D4DBD0")]
	private void onLangueChangeFailed(string msg)
	{
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1D4FE00", Offset = "0x1D4F200", VA = "0x181D4FE00")]
	private void onUnBindSuccess(string msg)
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1D4FD50", Offset = "0x1D4F150", VA = "0x181D4FD50")]
	private void onUnBindFailed(string msg)
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1D4FCA0", Offset = "0x1D4F0A0", VA = "0x181D4FCA0")]
	private void onUnBindCancel(string msg)
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1D4F460", Offset = "0x1D4E860", VA = "0x181D4F460")]
	private void onRequestPermissionSuccess(string msg)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1D4F390", Offset = "0x1D4E790", VA = "0x181D4F390")]
	private void onRequestPermissionFailed(string msg)
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1D4E790", Offset = "0x1D4DB90", VA = "0x181D4E790")]
	public void onNoticeCenterStateSuccess(string msg)
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", VA = "0x181D4E690")]
	public void onNoticeCenterStateFailed(string msg)
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1D4FBF0", Offset = "0x1D4EFF0", VA = "0x181D4FBF0")]
	private void onSingalFileDownloadSuccess(string msg)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1D4F740", Offset = "0x1D4EB40", VA = "0x181D4F740")]
	public void onSendPageToChat(string msg)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1D4C740", Offset = "0x1D4BB40", VA = "0x181D4C740")]
	public void onAgreePrivacyProtocolSuccess(string msg)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1D4C690", Offset = "0x1D4BA90", VA = "0x181D4C690")]
	public void onAgreePrivacyProtocolFailed(string msg)
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1D4D1F0", Offset = "0x1D4C5F0", VA = "0x181D4D1F0")]
	public void onDoUploadImagePathSuccess(string msg)
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1D4D140", Offset = "0x1D4C540", VA = "0x181D4D140")]
	public void onDoUploadImagePathFailed(string msg)
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1D4C570", Offset = "0x1D4B970", VA = "0x181D4C570")]
	public void onACEData1CallBack(string msg)
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1D4C5D0", Offset = "0x1D4B9D0", VA = "0x181D4C5D0")]
	public void onACEData2CallBack(string msg)
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1D4C630", Offset = "0x1D4BA30", VA = "0x181D4C630")]
	public void onACEData4CallBack(string msg)
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
	public void showAndroidToast(string info)
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1D50700", Offset = "0x1D4FB00", VA = "0x181D50700")]
	public void verifyToken(string info)
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1D4B360", Offset = "0x1D4A760", VA = "0x181D4B360")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5320", Offset = "0x1A4720")]
	private IEnumerator Perform(IEnumerator coroutine, [Optional] Action onComplete)
	{
		return null;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1D36FB0", Offset = "0x1D363B0", VA = "0x181D36FB0")]
	public static void DoCoroutine(IEnumerator coroutine, [Optional] Action onComplete)
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1D37820", Offset = "0x1D36C20", VA = "0x181D37820")]
	public string MakeRoleExchangeCode(string gameCode, string activityType, string activityInstanceId, string roleId)
	{
		return null;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1D4B4A0", Offset = "0x1D4A8A0", VA = "0x181D4B4A0")]
	public string ToCRC16(string content)
	{
		return null;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1D36DF0", Offset = "0x1D361F0", VA = "0x181D36DF0")]
	public byte[] CRC16(byte[] data)
	{
		return null;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1D37290", Offset = "0x1D36690", VA = "0x181D37290")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5920", Offset = "0x1A4D20")]
	private static IEnumerator GET_UNITYSDKCONFIG()
	{
		return null;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1D4B790", Offset = "0x1D4AB90", VA = "0x181D4B790")]
	public PDSDK()
	{
	}

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isDebug;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isVerfy;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool IsShowCommandUI;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string stringToEdit;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject CommondUIPrefab;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static JsonData goodlistjson;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int lbDownloadFullLevel;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static StringBuilder _stringBuilder;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool isLogin;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static PDSDK _instance;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool RenderBehindNotch;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action<LoginResultData> loginResultCallback;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action<LoginResultData> logoutResultCallback;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action<JsonData> onGetProductsCallback;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action<int, string> onDoPayCallback;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action exitGameCallback;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Action<int, string> onShareCallback;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action<int> requestPermissionCallback;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action<string> onConfirmDownloadSuccessAction;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Action<string> onConfirmDownloadCancelAction;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action<int, string> noticeResultCallback;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action<string> onSendPageToChatCallback;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Action<int, string> aceResultCallback;

	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000137")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public <>c()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		internal void <Perform>b__190_0()
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PDSDK.<>c <>9;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__190_0;
	}

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000138")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <Perform>d__190 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <Perform>d__190(int <>1__state)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x1D51050", Offset = "0x1D50450", VA = "0x181D51050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006A")]
		private object Current
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1D511D0", Offset = "0x1D505D0", VA = "0x181D511D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006B")]
		private object Current
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onComplete;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PDSDK <>4__this;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IEnumerator coroutine;
	}

	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000139")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
	private sealed class <GET_UNITYSDKCONFIG>d__195 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xBBF6E0", Offset = "0xBBEAE0", VA = "0x180BBF6E0")]
		[DebuggerHidden]
		public <GET_UNITYSDKCONFIG>d__195(int <>1__state)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1D50D80", Offset = "0x1D50180", VA = "0x181D50D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006C")]
		private object Current
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1D51000", Offset = "0x1D50400", VA = "0x181D51000", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700006D")]
		private object Current
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityWebRequest <request>5__2;
	}
}
