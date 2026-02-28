using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGame.Aot
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x20000ED")]
	public class PatchStatePrepare : FsmState<PatchManager>
	{
		// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xECCDC0", Offset = "0xECC1C0", VA = "0x180ECCDC0", Slot = "5")]
		protected override void OnEnter(IFsm<PatchManager> fsm)
		{
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xECCD20", Offset = "0xECC120", VA = "0x180ECCD20")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD6EA0", Offset = "0xD62A0")]
		private static UniTaskVoid DoEnter(IFsm<PatchManager> fsm)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xECCE70", Offset = "0xECC270", VA = "0x180ECCE70")]
		public PatchStatePrepare()
		{
		}
	}
}
