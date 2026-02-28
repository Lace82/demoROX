using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGame.Aot
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x20000EF")]
	public class PatchStateUpdateVersion : FsmState<PatchManager>
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xECD150", Offset = "0xECC550", VA = "0x180ECD150", Slot = "5")]
		protected override void OnEnter(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xECD2F0", Offset = "0xECC6F0", VA = "0x180ECD2F0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD8A30", Offset = "0xD7E30")]
		private UniTaskVoid UpdateVersion(IFsm<PatchManager> fsm)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xECD220", Offset = "0xECC620", VA = "0x180ECD220")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD8DD0", Offset = "0xD81D0")]
		private UniTask UpdatePackageVersion(string packageName)
		{
			return default(UniTask);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xECD3B0", Offset = "0xECC7B0", VA = "0x180ECD3B0")]
		public PatchStateUpdateVersion()
		{
		}

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x10")]
		private bool _hasError;
	}
}
