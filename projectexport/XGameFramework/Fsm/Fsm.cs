using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework.Fsm
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	internal sealed class Fsm<T> : FsMachine, IReference, IFsm<T> where T : class
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A6")]
		public Fsm()
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000068")]
		public T Owner
		{
			[Token(Token = "0x60002A7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000069")]
		public override Type OwnerType
		{
			[Token(Token = "0x60002A9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x1700006A")]
		public override int StateCount
		{
			[Token(Token = "0x60002AA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x1700006B")]
		public override bool IsRunning
		{
			[Token(Token = "0x60002AB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00002D2C File Offset: 0x00000F2C
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006C")]
		public override bool IsDestroyed
		{
			[Token(Token = "0x60002AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AD")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006D")]
		public FsmState<T> CurrentState
		{
			[Token(Token = "0x60002AE")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00002D44 File Offset: 0x00000F44
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006E")]
		public float ElapsedTime
		{
			[Token(Token = "0x60002B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002B1")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B2")]
		public void Start<TState>() where TState : FsmState<T>
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B3")]
		public void Start(Type stateType)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x60002B4")]
		public bool HasState<TState>() where TState : FsmState<T>
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x60002B5")]
		public bool HasState(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x60002B6")]
		public bool AddState<TState>() where TState : FsmState<T>
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x60002B7")]
		public bool AddState(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002B8")]
		public TState GetState<TState>() where TState : FsmState<T>
		{
			return null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002B9")]
		public FsmState<T> GetState(Type stateType)
		{
			return null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60002BA")]
		public bool HasData(string name)
		{
			return default(bool);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002BB")]
		public TData GetData<TData>(string name) where TData : Variable
		{
			return null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002BC")]
		public Variable GetData(string name)
		{
			return null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BD")]
		public void SetData<TData>(string name, TData data) where TData : Variable
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BE")]
		public void SetData(string name, Variable data)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x60002BF")]
		public bool RemoveData(string name)
		{
			return default(bool);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C0")]
		internal override void Tick(double deltaTime)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C1")]
		internal override void Shutdown()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C2")]
		public void ChangeState<TState>() where TState : FsmState<T>
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C3")]
		public void ChangeState(Type stateType)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C4")]
		public void Clear()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002C5")]
		public static Fsm<T> Create(string name, T owner, params FsmState<T>[] states)
		{
			return null;
		}

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<Type, FsmState<T>> _fsmStates;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, Variable> _fsmDates;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private T <Owner>k__BackingField;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsDestroyed>k__BackingField;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private FsmState<T> <CurrentState>k__BackingField;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <ElapsedTime>k__BackingField;
	}
}
