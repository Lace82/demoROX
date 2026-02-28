using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class GameTime
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2B97070", Offset = "0x2B96470", VA = "0x182B97070")]
		public GameTime()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002084 File Offset: 0x00000284
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public TimeSpan Elapsed
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1237750", Offset = "0x1236B50", VA = "0x181237750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		private bool IsRunningSlowly
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xCC0410", Offset = "0xCBF810", VA = "0x180CC0410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		private TimeSpan Total
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1819620", Offset = "0x1818A20", VA = "0x181819620")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000209C File Offset: 0x0000029C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public int FrameCount
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xB99EC0", Offset = "0xB992C0", VA = "0x180B99EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x10646C0", Offset = "0x1063AC0", VA = "0x1810646C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		private float FramePerSecond
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1BC8200", Offset = "0x1BC7600", VA = "0x181BC8200")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		private TimeSpan TimePerFrame
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2B970E0", Offset = "0x2B964E0", VA = "0x182B970E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		private bool FramePerSecondUpdated
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xB9D940", Offset = "0xB9CD40", VA = "0x180B9D940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2B96F20", Offset = "0x2B96320", VA = "0x182B96F20")]
		internal void Update(TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly, bool incrementFrameCount)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		private TimeSpan _accumulatedElapsedTime;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private int _accumulatedFrameCountPerSecond;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <Elapsed>k__BackingField;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsRunningSlowly>k__BackingField;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <Total>k__BackingField;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <FrameCount>k__BackingField;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <FramePerSecond>k__BackingField;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <TimePerFrame>k__BackingField;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <FramePerSecondUpdated>k__BackingField;
	}
}
