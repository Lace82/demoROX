using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCloud.UQM
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000C0")]
	public static class UQMCrash
	{
		// Token: 0x06000884 RID: 2180
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2770200", Offset = "0x276F600", VA = "0x182770200")]
		[PreserveSig]
		private static extern void CS_InitContext(string id, string version, string key);

		// Token: 0x06000885 RID: 2181
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2770410", Offset = "0x276F810", VA = "0x182770410")]
		[PreserveSig]
		private static extern void CS_ReportExceptionW(int type, string name, string message, string stack_trace, string extras, bool is_async, string attachmentPath = "");

		// Token: 0x06000886 RID: 2182
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x27706E0", Offset = "0x276FAE0", VA = "0x1827706E0")]
		[PreserveSig]
		private static extern void CS_SetUserValue(string key, string value);

		// Token: 0x06000887 RID: 2183
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2770790", Offset = "0x276FB90", VA = "0x182770790")]
		[PreserveSig]
		private static extern void CS_SetVehEnable(bool enable);

		// Token: 0x06000888 RID: 2184
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x27705D0", Offset = "0x276F9D0", VA = "0x1827705D0")]
		[PreserveSig]
		private static extern void CS_SetExtraHandler(bool extra_handle_enable);

		// Token: 0x06000889 RID: 2185
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2770540", Offset = "0x276F940", VA = "0x182770540")]
		[PreserveSig]
		private static extern void CS_SetCustomLogDirW(string log_path);

		// Token: 0x0600088A RID: 2186
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2770650", Offset = "0x276FA50", VA = "0x182770650")]
		[PreserveSig]
		private static extern void CS_SetUserId(string user_id);

		// Token: 0x0600088B RID: 2187
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x27702D0", Offset = "0x276F6D0", VA = "0x1827702D0")]
		[PreserveSig]
		private static extern void CS_MonitorEnable(bool enable);

		// Token: 0x0600088C RID: 2188
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2770350", Offset = "0x276F750", VA = "0x182770350")]
		[PreserveSig]
		private static extern void CS_PrintLog(int level, string tag, string format);

		// Token: 0x0600088D RID: 2189
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2770810", Offset = "0x276FC10", VA = "0x182770810")]
		[PreserveSig]
		private static extern void CS_UploadGivenPathDump(string dump_dir, bool is_extra_check);

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000040")]
		public static event OnUQMStringRetEventHandler<int> CrashBaseRetEvent
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x2774D70", Offset = "0x2774170", VA = "0x182774D70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x2775170", Offset = "0x2774570", VA = "0x182775170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000890 RID: 2192 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000041")]
		public static event OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x2774F60", Offset = "0x2774360", VA = "0x182774F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x2775360", Offset = "0x2774760", VA = "0x182775360")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000042")]
		public static event OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x2774E60", Offset = "0x2774260", VA = "0x182774E60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x2775260", Offset = "0x2774660", VA = "0x182775260")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004C")]
		public static AndroidJavaClass CrashSightPlatform
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x2775060", Offset = "0x2774460", VA = "0x182775060")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		private static void LoadCrashSightCoreSo()
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2770AC0", Offset = "0x276FEC0", VA = "0x182770AC0")]
		public static void ConfigCallbackType(int callbackType)
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2771410", Offset = "0x2770810", VA = "0x182771410")]
		public static void ConfigGameType(int gameType)
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x27708B0", Offset = "0x276FCB0", VA = "0x1827708B0")]
		public static void ConfigAutoReportLogLevel(int level)
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2770C10", Offset = "0x2770010", VA = "0x182770C10")]
		public static void ConfigCrashServerUrl(string serverUrl)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2770D50", Offset = "0x2770150", VA = "0x182770D50")]
		public static void ConfigDebugMode(bool enable)
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2770FA0", Offset = "0x27703A0", VA = "0x182770FA0")]
		public static void ConfigDefault(string channel, string version, string user, long delay)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2771D20", Offset = "0x2771120", VA = "0x182771D20")]
		public static void InitWithAppId(string appId)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2771AD0", Offset = "0x2770ED0", VA = "0x182771AD0")]
		public static void InitContext(string userId, string version, string key)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2771EA0", Offset = "0x27712A0", VA = "0x182771EA0")]
		public static void LogRecord(int level, string message)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2770020", Offset = "0x276F420", VA = "0x182770020")]
		public static void AddSceneData(string k, string v)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x27734C0", Offset = "0x27728C0", VA = "0x1827734C0")]
		public static void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x27732D0", Offset = "0x27726D0", VA = "0x1827732D0")]
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo)
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2773140", Offset = "0x2772540", VA = "0x182773140")]
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType)
		{
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x27744A0", Offset = "0x27738A0", VA = "0x1827744A0")]
		public static void SetUserId(string userId)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2774350", Offset = "0x2773750", VA = "0x182774350")]
		public static void SetScene(int sceneId)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2773010", Offset = "0x2772410", VA = "0x182773010")]
		public static void ReRegistAllMonitors()
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2773690", Offset = "0x2772A90", VA = "0x182773690")]
		public static void ReportLogInfo(string msgType, string msg)
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x27737C0", Offset = "0x2772BC0", VA = "0x1827737C0")]
		public static void SetAppVersion(string appVersion)
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2773E60", Offset = "0x2773260", VA = "0x182773E60")]
		public static void SetDeviceId(string deviceId)
		{
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x2773BE0", Offset = "0x2772FE0", VA = "0x182773BE0")]
		public static void SetCustomizedDeviceID(string deviceId)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2771870", Offset = "0x2770C70", VA = "0x182771870")]
		public static string GetSDKDefinedDeviceID()
		{
			return null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2773D20", Offset = "0x2773120", VA = "0x182773D20")]
		public static void SetCustomizedMatchID(string matchId)
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x27719A0", Offset = "0x2770DA0", VA = "0x1827719A0")]
		public static string GetSDKSessionID()
		{
			return null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2771740", Offset = "0x2770B40", VA = "0x182771740")]
		public static string GetCrashUuid()
		{
			return null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2773FA0", Offset = "0x27733A0", VA = "0x182773FA0")]
		public static void SetDeviceModel(string deviceModel)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x27740E0", Offset = "0x27734E0", VA = "0x1827740E0")]
		public static void SetLogPath(string logPath)
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2773900", Offset = "0x2772D00", VA = "0x182773900")]
		public static void SetCrashCallback()
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2774BD0", Offset = "0x2773FD0", VA = "0x182774BD0")]
		public static void UnsetCrashCallback()
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2773A10", Offset = "0x2772E10", VA = "0x182773A10")]
		public static void SetCrashLogCallback()
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x27725A0", Offset = "0x27719A0", VA = "0x1827725A0")]
		internal static string OnCrashCallbackMessage(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x2772230", Offset = "0x2771630", VA = "0x182772230")]
		internal static string OnCrashCallbackData(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2772C90", Offset = "0x2772090", VA = "0x182772C90")]
		internal static string OnCrashSetLogPathMessage(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2772910", Offset = "0x2771D10", VA = "0x182772910")]
		internal static string OnCrashLogUploadMessage(int methodId, int crashType, int result)
		{
			return null;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2770A00", Offset = "0x276FE00", VA = "0x182770A00")]
		public static void ConfigCallBack()
		{
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x2774B10", Offset = "0x2773F10", VA = "0x182774B10")]
		public static void UnregisterCallBack()
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x2771570", Offset = "0x2770970", VA = "0x182771570")]
		public static void ConfigLogCallBack()
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x2773B20", Offset = "0x2772F20", VA = "0x182773B20")]
		public static void SetCustomLogDir(string path)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x27749E0", Offset = "0x2773DE0", VA = "0x1827749E0")]
		public static void TestOomCrash()
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x2774650", Offset = "0x2773A50", VA = "0x182774650")]
		public static void TestJavaCrash()
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x27748B0", Offset = "0x2773CB0", VA = "0x1827748B0")]
		public static void TestOcCrash()
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2774780", Offset = "0x2773B80", VA = "0x182774780")]
		public static void TestNativeCrash()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x2771630", Offset = "0x2770A30", VA = "0x182771630")]
		public static long GetCrashThreadId()
		{
			return 0L;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x2775460", Offset = "0x2774860", VA = "0x182775460")]
		public static void setEnableGetPackageInfo(bool enable)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2774220", Offset = "0x2773620", VA = "0x182774220")]
		public static void SetLogcatBufferSize(int size)
		{
		}

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaClass _gameAgentClass;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _isLoadedSo;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int _gameType;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly string GAME_AGENT_CLASS;
	}
}
