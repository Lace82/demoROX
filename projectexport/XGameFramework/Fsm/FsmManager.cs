using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework.Fsm
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	internal sealed class FsmManager : IFsmManager, IModule, ITick
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE29660", Offset = "0xE28A60", VA = "0x180E29660", Slot = "21")]
		public int GetPriority()
		{
			return 0;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2B96C40", Offset = "0x2B96040", VA = "0x182B96C40", Slot = "20")]
		public void Tick(double deltaTime)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2B96A50", Offset = "0x2B95E50", VA = "0x182B96A50", Slot = "18")]
		public void OnInit()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2B96AE0", Offset = "0x2B95EE0", VA = "0x182B96AE0", Slot = "19")]
		public void Shutdown()
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x17000066")]
		public int Count
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x2B96ED0", Offset = "0x2B962D0", VA = "0x182B96ED0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x6000287")]
		public bool HasFsm<T>() where T : class
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2B967A0", Offset = "0x2B95BA0", VA = "0x182B967A0", Slot = "6")]
		public bool HasFsm(Type ownerType)
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000289")]
		public bool HasFsm<T>(string name) where T : class
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2B966B0", Offset = "0x2B95AB0", VA = "0x182B966B0", Slot = "8")]
		public bool HasFsm(Type ownerType, string name)
		{
			return default(bool);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2B969F0", Offset = "0x2B95DF0", VA = "0x182B969F0")]
		private bool InternalHasFsm(TypeNamePair namePair)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600028C")]
		public IFsm<T> GetFsm<T>() where T : class
		{
			return null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600028D")]
		public IFsm<T> GetFsm<T>(string name) where T : class
		{
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2B96970", Offset = "0x2B95D70", VA = "0x182B96970")]
		private FsMachine InternalGetFsm(TypeNamePair namePair)
		{
			return null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600028F")]
		public IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000290")]
		public IFsm<T> CreateFsm<T>(string name, T owner, params FsmState<T>[] states) where T : class
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x6000291")]
		public bool DestroyFsm<T>() where T : class
		{
			return default(bool);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2B96520", Offset = "0x2B95920", VA = "0x182B96520", Slot = "14")]
		public bool DestroyFsm(Type ownerType)
		{
			return default(bool);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x6000293")]
		public bool DestroyFsm<T>(string name) where T : class
		{
			return default(bool);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2B965F0", Offset = "0x2B959F0", VA = "0x182B965F0", Slot = "16")]
		public bool DestroyFsm(Type ownerType, string name)
		{
			return default(bool);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000295")]
		public bool DestroyFsm<T>(IFsm<T> fsm) where T : class
		{
			return default(bool);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2B968B0", Offset = "0x2B95CB0", VA = "0x182B968B0")]
		private bool InternalDestroyFsm(TypeNamePair namePair)
		{
			return default(bool);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public FsmManager()
		{
		}

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<TypeNamePair, FsMachine> _fsMachines;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		private List<FsMachine> _tmpFsMachines;
	}
}
