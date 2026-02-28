using System;
using System.Collections;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200003D")]
	public abstract class AsyncOperationBase : IEnumerator, IComparable<AsyncOperationBase>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public string PackageName
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public uint Priority
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xCC3510", Offset = "0xCC2910", VA = "0x180CC3510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1046F30", Offset = "0x1046330", VA = "0x181046F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public EOperationStatus Status
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1473680", Offset = "0x1472A80", VA = "0x181473680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return EOperationStatus.None;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x14736E0", Offset = "0x1472AE0", VA = "0x1814736E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public string Error
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1047110", Offset = "0x1046510", VA = "0x181047110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public float Progress
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x161C730", Offset = "0x161BB30", VA = "0x18161C730")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x180C0C0", Offset = "0x180B4C0", VA = "0x18180C0C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000033")]
		public bool IsDone
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x180BF70", Offset = "0x180B370", VA = "0x18180BF70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action<AsyncOperationBase> Completed
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x180BEC0", Offset = "0x180B2C0", VA = "0x18180BEC0")]
			add
			{
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x180C040", Offset = "0x180B440", VA = "0x18180C040")]
			remove
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000034")]
		public Task Task
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x180BF90", Offset = "0x180B390", VA = "0x18180BF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600014C RID: 332
		[Token(Token = "0x6000141")]
		internal abstract void InternalOnStart();

		// Token: 0x0600014D RID: 333
		[Token(Token = "0x6000142")]
		internal abstract void InternalOnUpdate();

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "10")]
		internal virtual void InternalOnAbort()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
		internal void SetPackageName(string packageName)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x180BE80", Offset = "0x180B280", VA = "0x18180BE80")]
		internal void SetStart()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x180BE10", Offset = "0x180B210", VA = "0x18180BE10")]
		internal void SetFinish()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x180BD20", Offset = "0x180B120", VA = "0x18180BD20")]
		internal void SetAbort()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x13E9170", Offset = "0x13E8570", VA = "0x1813E9170")]
		protected void ClearCompletedCallback()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x180BCF0", Offset = "0x180B0F0", VA = "0x18180BCF0", Slot = "7")]
		public int CompareTo(AsyncOperationBase other)
		{
			return 0;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x180BEA0", Offset = "0x180B2A0", VA = "0x18180BEA0", Slot = "4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		private void Reset()
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000035")]
		private object Current
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected AsyncOperationBase()
		{
		}

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x40000DE")]
		public const string CANCLE_MESSAGE = "User cancelled !";

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		private Action<AsyncOperationBase> _callback;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x18")]
		internal bool IsFinish;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageName>k__BackingField;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private uint <Priority>k__BackingField;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private EOperationStatus <Status>k__BackingField;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <Error>k__BackingField;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <Progress>k__BackingField;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x40")]
		private TaskCompletionSource<object> _taskCompletionSource;
	}
}
