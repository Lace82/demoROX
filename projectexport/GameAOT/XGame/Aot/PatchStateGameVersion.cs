using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGameFramework.Fsm;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x20000EA")]
	public class PatchStateGameVersion : FsmState<PatchManager>
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xECA040", Offset = "0xEC9440", VA = "0x180ECA040", Slot = "5")]
		protected override void OnEnter(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xECA600", Offset = "0xEC9A00", VA = "0x180ECA600", Slot = "7")]
		protected override void OnLeave(IFsm<PatchManager> fsm, bool isShutDown)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xECA1C0", Offset = "0xEC95C0", VA = "0x180ECA1C0")]
		private void OnGetAppVersion()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xECB850", Offset = "0xECAC50", VA = "0x180ECB850")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xCCEC0", Offset = "0xCC2C0")]
		private UniTaskVoid RequestNetwork()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xECA290", Offset = "0xEC9690", VA = "0x180ECA290")]
		private void OnHandleNetworkSuccess(string content)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xECB750", Offset = "0xECAB50", VA = "0x180ECB750")]
		private void ReConnect(string content)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xEC9E10", Offset = "0xEC9210", VA = "0x180EC9E10")]
		public static string GetQueryURL()
		{
			return null;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xECA6C0", Offset = "0xEC9AC0", VA = "0x180ECA6C0")]
		private void ParseVersionInfo(Dictionary<string, object> dict)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xECBBA0", Offset = "0xECAFA0", VA = "0x180ECBBA0")]
		public PatchStateGameVersion()
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xECB910", Offset = "0xECAD10", VA = "0x180ECB910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		internal static void <ParseVersionInfo>g__ReadVersion|12_0(ref PatchStateGameVersion.<>c__DisplayClass12_0 A_0)
		{
		}

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400043F")]
		private const int GET_APP_VERSION_TIME_OUT = 6;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x4000440")]
		private const int MAX_CHECK_COUNT = 3;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _currCheckIndex;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IFsm<PatchManager> _owner;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EPlayMode _playMode;

		// Token: 0x02000124 RID: 292
		[Token(Token = "0x200016C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		[StructLayout(LayoutKind.Auto)]
		private struct <>c__DisplayClass12_0
		{
			// Token: 0x04000539 RID: 1337
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<string, object> dict;
		}
	}
}
