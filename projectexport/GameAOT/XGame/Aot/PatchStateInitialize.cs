using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGame.Aot
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x20000EB")]
	public class PatchStateInitialize : FsmState<PatchManager>
	{
		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xECBEC0", Offset = "0xECB2C0", VA = "0x180ECBEC0")]
		private void InitProgress()
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xECC550", Offset = "0xECB950", VA = "0x180ECC550")]
		private void RefreshProgress()
		{
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xECC180", Offset = "0xECB580", VA = "0x180ECC180", Slot = "5")]
		protected override void OnEnter(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xECBE00", Offset = "0xECB200", VA = "0x180ECBE00")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xCDEC0", Offset = "0xCD2C0")]
		private UniTaskVoid InitDat(IFsm<PatchManager> fsm)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xECBC90", Offset = "0xECB090", VA = "0x180ECBC90")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xCE500", Offset = "0xCD900")]
		private UniTaskVoid InitBundle(IFsm<PatchManager> fsm)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xECC4A0", Offset = "0xECB8A0", VA = "0x180ECC4A0")]
		private void OnInitComplete(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xECBD50", Offset = "0xECB150", VA = "0x180ECBD50")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xCEA10", Offset = "0xCDE10")]
		private static UniTask InitDatPackage(IFsm<PatchManager> fsm)
		{
			return default(UniTask);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xECBBE0", Offset = "0xECAFE0", VA = "0x180ECBBE0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xCEF90", Offset = "0xCE390")]
		private static UniTask InitBundlePackage(IFsm<PatchManager> fsm)
		{
			return default(UniTask);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xECC0A0", Offset = "0xECB4A0", VA = "0x180ECC0A0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF730", Offset = "0xCEB30")]
		private static UniTask InitResourcePackage(IFsm<PatchManager> fsm, string packageName)
		{
			return default(UniTask);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xECC770", Offset = "0xECBB70", VA = "0x180ECC770")]
		public PatchStateInitialize()
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xECC5F0", Offset = "0xECB9F0", VA = "0x180ECC5F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private void <InitProgress>b__9_0(float progress)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xECC670", Offset = "0xECBA70", VA = "0x180ECC670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private void <InitProgress>b__9_1(float progress)
		{
		}

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x10")]
		private bool _bInitDatComplete;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x11")]
		private bool _bInitBundleComplete;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x12")]
		private bool _isInit;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x18")]
		private UIPatch _uiPatch;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x0")]
		private static float _datProgress;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x4")]
		private static float _bundleProgress;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x8")]
		private static float _totalProgress;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x10")]
		private static Progress<float> _datProgressHandler;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x18")]
		private static Progress<float> _bundleProgressHandler;
	}
}
