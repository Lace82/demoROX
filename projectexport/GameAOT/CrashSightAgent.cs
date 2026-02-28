using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public sealed class CrashSightAgent
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x275B780", Offset = "0x275AB80", VA = "0x18275B780")]
	public static void ConfigCallbackType(int callbackType)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x275B7D0", Offset = "0x275ABD0", VA = "0x18275B7D0")]
	public static void ConfigCrashReporter(int type, int logLevel)
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x275C790", Offset = "0x275BB90", VA = "0x18275C790")]
	public static void RegisterCrashCallback(CrashSightCallback callback)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x275E220", Offset = "0x275D620", VA = "0x18275E220")]
	public static void UnregisterCrashCallback()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x275CA00", Offset = "0x275BE00", VA = "0x18275CA00")]
	public static void RegisterCrashLogCallback(CrashSightLogCallback callback)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x275C400", Offset = "0x275B800", VA = "0x18275C400")]
	public static void InitWithAppId(string appId)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x275C100", Offset = "0x275B500", VA = "0x18275C100")]
	public static void InitContext(string userId, string version, string key)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x275BDC0", Offset = "0x275B1C0", VA = "0x18275BDC0")]
	public static void EnableExceptionHandler()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x275CD80", Offset = "0x275C180", VA = "0x18275CD80")]
	public static void RegisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x275D8F0", Offset = "0x275CCF0", VA = "0x18275D8F0")]
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x275CF50", Offset = "0x275C350", VA = "0x18275CF50")]
	public static void ReportException(Exception e, string message)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x275D240", Offset = "0x275C640", VA = "0x18275D240")]
	public static void ReportException(string name, string message, string stackTrace)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x275D130", Offset = "0x275C530", VA = "0x18275D130")]
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x275D490", Offset = "0x275C890", VA = "0x18275D490")]
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x275E320", Offset = "0x275D720", VA = "0x18275E320")]
	public static void UnregisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x275DC50", Offset = "0x275D050", VA = "0x18275DC50")]
	public static void SetUserId(string userId)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x275DAA0", Offset = "0x275CEA0", VA = "0x18275DAA0")]
	public static void SetScene(int sceneId)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x275B4D0", Offset = "0x275A8D0", VA = "0x18275B4D0")]
	public static void AddSceneData(string key, string value)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x275B930", Offset = "0x275AD30", VA = "0x18275B930")]
	public static void ConfigDebugMode(bool enable)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x275B6D0", Offset = "0x275AAD0", VA = "0x18275B6D0")]
	public static void ConfigAutoQuitApplication(bool autoQuit)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x275B730", Offset = "0x275AB30", VA = "0x18275B730")]
	public static void ConfigAutoReportLogLevel(CSLogSeverity level)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x275BA80", Offset = "0x275AE80", VA = "0x18275BA80")]
	public static void ConfigDefault(string channel, string version, string user, long delay)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x275B820", Offset = "0x275AC20", VA = "0x18275B820")]
	public static void ConfigCrashServerUrl(string crashServerUrl)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x275D610", Offset = "0x275CA10", VA = "0x18275D610")]
	public static void SetAppVersion(string appVersion)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x275D830", Offset = "0x275CC30", VA = "0x18275D830")]
	public static void SetDeviceId(string deviceId)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x275D770", Offset = "0x275CB70", VA = "0x18275D770")]
	public static void SetCustomizedDeviceID(string deviceId)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x275C060", Offset = "0x275B460", VA = "0x18275C060")]
	public static string GetSDKDefinedDeviceID()
	{
		return null;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x275C0B0", Offset = "0x275B4B0", VA = "0x18275C0B0")]
	public static string GetSDKSessionID()
	{
		return null;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x275D7D0", Offset = "0x275CBD0", VA = "0x18275D7D0")]
	public static void SetCustomizedMatchID(string matchId)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x275C010", Offset = "0x275B410", VA = "0x18275C010")]
	public static string GetCrashUuid()
	{
		return null;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x275D890", Offset = "0x275CC90", VA = "0x18275D890")]
	public static void SetDeviceModel(string deviceModel)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x275D9F0", Offset = "0x275CDF0", VA = "0x18275D9F0")]
	public static void SetLogPath(string logPath)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x275BCE0", Offset = "0x275B0E0", VA = "0x18275BCE0")]
	public static void DebugLog(string tag, string format, params object[] args)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x275C660", Offset = "0x275BA60", VA = "0x18275C660")]
	public static void PrintLog(CSLogSeverity level, string format, params object[] args)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x275C6F0", Offset = "0x275BAF0", VA = "0x18275C6F0")]
	public static void ReRegistAllMonitors()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x275D5A0", Offset = "0x275C9A0", VA = "0x18275D5A0")]
	public static void ReportLogInfo(string msgType, string msg)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x275D670", Offset = "0x275CA70", VA = "0x18275D670")]
	public static void SetCustomLogDir(string path)
	{
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	private static event CrashSightAgent.LogCallbackDelegate _LogCallbackEventHandler
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x27604B0", Offset = "0x275F8B0", VA = "0x1827604B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		add
		{
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2760730", Offset = "0x275FB30", VA = "0x182760730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		remove
		{
		}
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000028 RID: 40 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public static string PluginVersion
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x27606D0", Offset = "0x275FAD0", VA = "0x1827606D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000029 RID: 41 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x17000002")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2760610", Offset = "0x275FA10", VA = "0x182760610")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x17000003")]
	public static bool AutoQuitApplicationAfterReport
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x27605B0", Offset = "0x275F9B0", VA = "0x1827605B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x275F740", Offset = "0x275EB40", VA = "0x18275F740")]
	private static void _RegisterExceptionHandler()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x275F8C0", Offset = "0x275ECC0", VA = "0x18275F8C0")]
	private static void _UnregisterExceptionHandler()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x275F330", Offset = "0x275E730", VA = "0x18275F330")]
	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x275F540", Offset = "0x275E940", VA = "0x18275F540")]
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x275E480", Offset = "0x275D880", VA = "0x18275E480")]
	private static void _HandleException(Exception e, string message, bool uncaught)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x275FB00", Offset = "0x275EF00", VA = "0x18275FB00")]
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x275EAA0", Offset = "0x275DEA0", VA = "0x18275EAA0")]
	private static void _HandleException(CSLogSeverity logLevel, string name, string message, string stackTrace, bool uncaught)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x275E110", Offset = "0x275D510", VA = "0x18275E110")]
	public static void TestOomCrash()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x275DDE0", Offset = "0x275D1E0", VA = "0x18275DDE0")]
	public static void TestJavaCrash()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x275E000", Offset = "0x275D400", VA = "0x18275E000")]
	public static void TestOcCrash()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x275DEF0", Offset = "0x275D2F0", VA = "0x18275DEF0")]
	public static void TestNativeCrash()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x275BEF0", Offset = "0x275B2F0", VA = "0x18275BEF0")]
	public static long GetCrashThreadId()
	{
		return 0L;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2760830", Offset = "0x275FC30", VA = "0x182760830")]
	public static void setEnableGetPackageInfo(bool enable)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x275DA50", Offset = "0x275CE50", VA = "0x18275DA50")]
	public static void SetLogcatBufferSize(int size)
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
	public CrashSightAgent()
	{
	}

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x0")]
	private static string crashUploadUrl;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x10")]
	private static bool _isInitialized;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x14")]
	private static CSLogSeverity _autoReportLogLevel;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	private static bool _debugMode;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x19")]
	private static bool _autoQuitApplicationAfterReport;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int EXCEPTION_TYPE_UNCAUGHT;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int EXCEPTION_TYPE_CAUGHT;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x28")]
	private static readonly string _pluginVersion;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x38")]
	private static bool _uncaughtAutoReportOnce;

	// Token: 0x02000004 RID: 4
	// (Invoke) Token: 0x0600003C RID: 60
	[Token(Token = "0x2000134")]
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type);
}
