using System;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGame.HotUpdate;
using XGameFramework.Fsm;

namespace XGame.Aot
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x20000EC")]
	public class PatchStateLoadHotUpdateDll : FsmState<PatchManager>
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xECCC10", Offset = "0xECC010", VA = "0x180ECCC10", Slot = "5")]
		protected override void OnEnter(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xECC7B0", Offset = "0xECBBB0", VA = "0x180ECC7B0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD1F20", Offset = "0xD1320")]
		private UniTaskVoid DoEnter(IFsm<PatchManager> fsm)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xECC870", Offset = "0xECBC70", VA = "0x180ECC870")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD23F0", Offset = "0xD17F0")]
		private UniTask LoadAssemblies()
		{
			return default(UniTask);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xECCAA0", Offset = "0xECBEA0", VA = "0x180ECCAA0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD28A0", Offset = "0xD1CA0")]
		private UniTask LoadHotUpdateAssemblyManifest()
		{
			return default(UniTask);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xECC9F0", Offset = "0xECBDF0", VA = "0x180ECC9F0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD2D00", Offset = "0xD2100")]
		private UniTask LoadHotUpdateAssemblies()
		{
			return default(UniTask);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xECC920", Offset = "0xECBD20", VA = "0x180ECC920")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD3170", Offset = "0xD2570")]
		private UniTask LoadDheUpdateDll()
		{
			return default(UniTask);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xECCB50", Offset = "0xECBF50", VA = "0x180ECCB50")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD3650", Offset = "0xD2A50")]
		private UniTask LoadHotUpdateDll()
		{
			return default(UniTask);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xECCCE0", Offset = "0xECC0E0", VA = "0x180ECCCE0")]
		public PatchStateLoadHotUpdateDll()
		{
		}

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x10")]
		private HotUpdateAssemblyManifest _assemblyManifest;

		// Token: 0x02000130 RID: 304
		[Token(Token = "0x2000176")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x000043B0 File Offset: 0x000025B0
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0xED5770", Offset = "0xED4B70", VA = "0x180ED5770")]
			internal bool <LoadDheUpdateDll>b__0(Assembly o)
			{
				return default(bool);
			}

			// Token: 0x04000570 RID: 1392
			[Token(Token = "0x40005CF")]
			[FieldOffset(Offset = "0x10")]
			public string assemblyName;
		}
	}
}
