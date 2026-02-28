using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[StructLayout(LayoutKind.Auto)]
	public struct TaskInfo
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x17000025")]
		public int TaskId
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x940D90", Offset = "0x940190", VA = "0x180940D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x17000026")]
		public int Priority
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x12D6240", Offset = "0x12D5640", VA = "0x1812D6240")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x17000027")]
		public ETaskStatus Status
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x15E1FB0", Offset = "0x15E13B0", VA = "0x1815E1FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return ETaskStatus.Wait;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2B9DC10", Offset = "0x2B9D010", VA = "0x182B9DC10")]
		public TaskInfo(int taskId, int priority, ETaskStatus status)
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly int <TaskId>k__BackingField;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly int <Priority>k__BackingField;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly ETaskStatus <Status>k__BackingField;
	}
}
