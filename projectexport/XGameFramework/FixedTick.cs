using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class FixedTick
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2B957D0", Offset = "0x2B94BD0", VA = "0x182B957D0")]
		public FixedTick(int fps)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2B94F90", Offset = "0x2B94390", VA = "0x182B94F90")]
		public void ChangeFps(int fps)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		public GameTime UpdateTime
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xCB0840", Offset = "0xCAFC40", VA = "0x180CB0840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000003")]
		public TimeTick PlayTime
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xCB0830", Offset = "0xCAFC30", VA = "0x180CB0830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000206C File Offset: 0x0000026C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public TimeSpan TargetElapsedTime
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x8EF970", Offset = "0x8EED70", VA = "0x1808EF970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x18156A0", Offset = "0x1814AA0", VA = "0x1818156A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2B955A0", Offset = "0x2B949A0", VA = "0x182B955A0")]
		public void Tick()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2B95020", Offset = "0x2B94420", VA = "0x182B95020")]
		private void TickInternal()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2B95710", Offset = "0x2B94B10", VA = "0x182B95710", Slot = "4")]
		protected virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2B95630", Offset = "0x2B94A30", VA = "0x182B95630")]
		private void UpdateAndProfile(GameTime gameTime)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private readonly TimeTick _updateTimer;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] _lastUpdateCount;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		private readonly float _updateCountAverageSlowLimit;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		private TimeSpan _singleFrameUpdateTime;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		private TimeSpan _totalUpdateTime;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		private readonly TimeSpan _maximumElapsedTime;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		private TimeSpan _accumulatedElapsedGameTime;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x48")]
		private TimeSpan _lastFrameElapsedGameTime;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		private int _nextLastUpdateCountIndex;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x54")]
		private bool _drawRunningSlowly;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x55")]
		private bool _forceElapsedTimeToZero;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x58")]
		private readonly TimeTick _timer;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x60")]
		internal object TickLock;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly GameTime <UpdateTime>k__BackingField;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly TimeTick <PlayTime>k__BackingField;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private TimeSpan <TargetElapsedTime>k__BackingField;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x80")]
		public Action<double> UpdateCallback;
	}
}
