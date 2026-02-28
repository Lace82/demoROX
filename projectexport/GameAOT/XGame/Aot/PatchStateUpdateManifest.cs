using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGame.Aot
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x20000EE")]
	public class PatchStateUpdateManifest : FsmState<PatchManager>
	{
		// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xECCEB0", Offset = "0xECC2B0", VA = "0x180ECCEB0", Slot = "5")]
		protected override void OnEnter(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xECCF80", Offset = "0xECC380", VA = "0x180ECCF80")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD77F0", Offset = "0xD6BF0")]
		private UniTaskVoid UpdateManifest(IFsm<PatchManager> fsm)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xECD040", Offset = "0xECC440", VA = "0x180ECD040")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD7D90", Offset = "0xD7190")]
		private UniTask UpdatePackageManifest(string packageName)
		{
			return default(UniTask);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xECD110", Offset = "0xECC510", VA = "0x180ECD110")]
		public PatchStateUpdateManifest()
		{
		}

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x10")]
		private bool _hasError;
	}
}
