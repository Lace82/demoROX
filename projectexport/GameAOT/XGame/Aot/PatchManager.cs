using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using XGameFramework.Event;
using XGameFramework.Fsm;
using XGameFramework.Utils;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x20000E9")]
	public class PatchManager : Singleton<PatchManager>
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public bool Running
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xDFD690", Offset = "0xDFCA90", VA = "0x180DFD690")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xEC9E00", Offset = "0xEC9200", VA = "0x180EC9E00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public IFsm<PatchManager> StateMachine
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public IEventManager EventManager
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public string HotAssemblyEncryptKey
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00004260 File Offset: 0x00002460
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public EPatchMode PatchMode
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xEC9DE0", Offset = "0xEC91E0", VA = "0x180EC9DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return EPatchMode.Necessary;
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xEC9DF0", Offset = "0xEC91F0", VA = "0x180EC9DF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x1700005B")]
		public bool IsSplashing
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xEC9DD0", Offset = "0xEC91D0", VA = "0x180EC9DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005C")]
		public ResourcePackage DatPackage
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xEC9D80", Offset = "0xEC9180", VA = "0x180EC9D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005D")]
		public ResourcePackage BundlePackage
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xEC9D30", Offset = "0xEC9130", VA = "0x180EC9D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xEC9190", Offset = "0xEC8590", VA = "0x180EC9190", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xEC8EF0", Offset = "0xEC82F0", VA = "0x180EC8EF0", Slot = "5")]
		protected override void OnDispose()
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xEC8BD0", Offset = "0xEC7FD0", VA = "0x180EC8BD0")]
		private void InitializeYoo()
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xEC8960", Offset = "0xEC7D60", VA = "0x180EC8960")]
		private byte[] DecryptFunc(byte[] data)
		{
			return null;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xEC9130", Offset = "0xEC8530", VA = "0x180EC9130")]
		private void OnGameSplashStart()
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xEC9070", Offset = "0xEC8470", VA = "0x180EC9070")]
		private void OnGameSplashEnd()
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xEC95D0", Offset = "0xEC89D0", VA = "0x180EC95D0")]
		private void OnPatchPrepareEnd()
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xEC95E0", Offset = "0xEC89E0", VA = "0x180EC95E0")]
		private void Run(EPlayMode playMode)
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xEC89F0", Offset = "0xEC7DF0", VA = "0x180EC89F0")]
		public void Exit()
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xEC8D00", Offset = "0xEC8100", VA = "0x180EC8D00")]
		public void InvokeMainEntrance()
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xEC8E40", Offset = "0xEC8240", VA = "0x180EC8E40")]
		private static void MainEnter(Type main)
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xEC8B00", Offset = "0xEC7F00", VA = "0x180EC8B00")]
		public string GetCachedPackageVersion()
		{
			return null;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xEC9BE0", Offset = "0xEC8FE0", VA = "0x180EC9BE0")]
		private static ResourcePackage TryCreatePackage(string pkg, ref ResourcePackage package)
		{
			return null;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xEC9470", Offset = "0xEC8870", VA = "0x180EC9470")]
		private void OnNetworkCheckFailure(string errorInfo, EPatchErrorCode errorCode)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xEC9CC0", Offset = "0xEC90C0", VA = "0x180EC9CC0")]
		public PatchManager()
		{
		}

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <Running>k__BackingField;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x11")]
		private bool _bSplashEnd;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x12")]
		private bool _bPatchPrepareEnd;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private IFsm<PatchManager> <StateMachine>k__BackingField;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private IEventManager <EventManager>k__BackingField;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <HotAssemblyEncryptKey>k__BackingField;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private EPatchMode <PatchMode>k__BackingField;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x31")]
		public EPatchErrorCode ErrorCode;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x38")]
		private ResourcePackage _datPackage;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x40")]
		private ResourcePackage _bundlePackage;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x48")]
		public readonly Dictionary<string, Assembly> HotUpdateAssemblies;

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000169")]
		private class YooLog : ILogger
		{
			// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "4")]
			public void Log(string message)
			{
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
			public void Warning(string message)
			{
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0xEDB020", Offset = "0xEDA420", VA = "0x180EDB020", Slot = "6")]
			public void Error(string message)
			{
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0xEDB020", Offset = "0xEDA420", VA = "0x180EDB020", Slot = "7")]
			public void Exception(Exception exception)
			{
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public YooLog()
			{
			}
		}

		// Token: 0x02000121 RID: 289
		[Token(Token = "0x200016A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0xED55C0", Offset = "0xED49C0", VA = "0x180ED55C0")]
			internal void <OnNetworkCheckFailure>b__0(object ret)
			{
			}

			// Token: 0x0400052A RID: 1322
			[Token(Token = "0x4000598")]
			[FieldOffset(Offset = "0x10")]
			public EPatchErrorCode errorCode;

			// Token: 0x0400052B RID: 1323
			[Token(Token = "0x4000599")]
			[FieldOffset(Offset = "0x18")]
			public PatchManager <>4__this;
		}
	}
}
