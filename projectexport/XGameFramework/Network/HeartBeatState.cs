using System;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal sealed class HeartBeatState
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002A44 File Offset: 0x00000C44
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004C")]
		public float HeartBeatElapsedTime
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xDFD6C0", Offset = "0xDFCAC0", VA = "0x180DFD6C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1047A60", Offset = "0x1046E60", VA = "0x181047A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00002A5C File Offset: 0x00000C5C
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004D")]
		public int HeartBeatMissCount
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xCE8030", Offset = "0xCE7430", VA = "0x180CE8030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1065710", Offset = "0x1064B10", VA = "0x181065710")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2B970F0", Offset = "0x2B964F0", VA = "0x182B970F0")]
		public void Reset(bool resetHeartBeatTime)
		{
		}

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <HeartBeatElapsedTime>k__BackingField;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <HeartBeatMissCount>k__BackingField;
	}
}
