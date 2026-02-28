using System;
using Il2CppDummyDll;
using XGameFramework.Fsm;

namespace XGameFramework.Flow
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	internal sealed class FlowManager : IFlowManager, IModule
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x13760B0", Offset = "0x13754B0", VA = "0x1813760B0", Slot = "15")]
		public void OnInit()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2B96190", Offset = "0x2B95590", VA = "0x182B96190", Slot = "16")]
		public void Shutdown()
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700007D")]
		public FlowBase CurrentFlow
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x2B963C0", Offset = "0x2B957C0", VA = "0x182B963C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x1700007E")]
		public float CurrentFlowTime
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x2B96300", Offset = "0x2B95700", VA = "0x182B96300", Slot = "5")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2B96050", Offset = "0x2B95450", VA = "0x182B96050", Slot = "6")]
		public void Initialize(IFsmManager fsmManager, params FlowBase[] flows)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FC")]
		public void StartFlow<T>() where T : FlowBase
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2B962A0", Offset = "0x2B956A0", VA = "0x182B962A0", Slot = "8")]
		public void StartFlow(Type flowType)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x60002FE")]
		public bool HasFlow<T>() where T : FlowBase
		{
			return default(bool);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2B95F90", Offset = "0x2B95390", VA = "0x182B95F90", Slot = "10")]
		public bool HasFlow(Type flowType)
		{
			return default(bool);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000300")]
		public FlowBase GetFlow<T>() where T : FlowBase
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2B95E90", Offset = "0x2B95290", VA = "0x182B95E90", Slot = "12")]
		public FlowBase GetFlow(Type flowType)
		{
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000302")]
		public void ChangeFlow<T>() where T : FlowBase
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2B95CB0", Offset = "0x2B950B0", VA = "0x182B95CB0", Slot = "14")]
		public void ChangeFlow(Type flowType)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public FlowManager()
		{
		}

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x10")]
		private IFsmManager _fsmManager;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		private IFsm<IFlowManager> _flowFsm;
	}
}
