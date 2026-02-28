using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal abstract class TaskBase : IReference
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000022")]
		public int TaskId
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x943540", Offset = "0x942940", VA = "0x180943540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002294 File Offset: 0x00000494
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public int Priority
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xCE8030", Offset = "0xCE7430", VA = "0x180CE8030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1065710", Offset = "0x1064B10", VA = "0x181065710")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public bool Done
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1087AB0", Offset = "0x1086EB0", VA = "0x181087AB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1087E00", Offset = "0x1087200", VA = "0x181087E00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2B9DBF0", Offset = "0x2B9CFF0", VA = "0x182B9DBF0")]
		public TaskBase()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2B9DBE0", Offset = "0x2B9CFE0", VA = "0x182B9DBE0")]
		internal void Initialize(int taskId, int priority)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2B9DBD0", Offset = "0x2B9CFD0", VA = "0x182B9DBD0", Slot = "5")]
		public virtual void Clear()
		{
		}

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <TaskId>k__BackingField;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <Priority>k__BackingField;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <Done>k__BackingField;
	}
}
