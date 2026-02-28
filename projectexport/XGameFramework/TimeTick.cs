using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class TimeTick
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2B9E0B0", Offset = "0x2B9D4B0", VA = "0x182B9E0B0")]
		public TimeTick()
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000020B4 File Offset: 0x000002B4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public TimeSpan StartTime
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1260630", Offset = "0x125FA30", VA = "0x181260630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		private TimeSpan TotalTime
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x12EFAE0", Offset = "0x12EEEE0", VA = "0x1812EFAE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		private TimeSpan TotalTimeWithPause
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1F7C370", Offset = "0x1F7B770", VA = "0x181F7C370")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000020CC File Offset: 0x000002CC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public TimeSpan ElapsedTime
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xCB0750", Offset = "0xCAFB50", VA = "0x180CB0750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1268570", Offset = "0x1267970", VA = "0x181268570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public TimeSpan ElapsedTimeWithPause
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xCB0840", Offset = "0xCAFC40", VA = "0x180CB0840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x17303D0", Offset = "0x172F7D0", VA = "0x1817303D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x17000011")]
		public bool IsPaused
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2B9E110", Offset = "0x2B9D510", VA = "0x182B9E110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2B9DD10", Offset = "0x2B9D110", VA = "0x182B9DD10")]
		public void Reset()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2B9DC90", Offset = "0x2B9D090", VA = "0x182B9DC90")]
		public void Reset(TimeSpan startTime)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2B9DDE0", Offset = "0x2B9D1E0", VA = "0x182B9DDE0")]
		public void Tick()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2B9DC20", Offset = "0x2B9D020", VA = "0x182B9DC20")]
		public static TimeSpan ConvertRawToTimestamp(long delta)
		{
			return default(TimeSpan);
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		private long _startRawTime;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		private long _lastRawTime;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		private int _pauseCount;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		private long _pauseStartTime;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		private long _timePaused;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		private decimal _speedFactor;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <StartTime>k__BackingField;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <TotalTime>k__BackingField;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <TotalTimeWithPause>k__BackingField;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <ElapsedTime>k__BackingField;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <ElapsedTimeWithPause>k__BackingField;
	}
}
