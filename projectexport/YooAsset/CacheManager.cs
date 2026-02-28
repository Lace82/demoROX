using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	internal class CacheManager
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1811A40", Offset = "0x1810E40", VA = "0x181811A40")]
		public CacheManager(string packageName, EVerifyLevel bootVerifyLevel)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1811510", Offset = "0x1810910", VA = "0x181811510")]
		public void ClearAll()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x18118B0", Offset = "0x1810CB0", VA = "0x1818118B0")]
		public bool IsCached(string cacheGUID)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1811910", Offset = "0x1810D10", VA = "0x181811910")]
		public void Record(string cacheGUID, CacheManager.RecordWrapper wrapper)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1811560", Offset = "0x1810960", VA = "0x181811560")]
		public void Discard(string cacheGUID)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x18119C0", Offset = "0x1810DC0", VA = "0x1818119C0")]
		public CacheManager.RecordWrapper TryGetWrapper(string cacheGUID)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x18116E0", Offset = "0x1810AE0", VA = "0x1818116E0")]
		public int GetAllCachedFilesCount()
		{
			return 0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1811730", Offset = "0x1810B30", VA = "0x181811730")]
		public List<string> GetAllCachedGUIDs()
		{
			return null;
		}

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, CacheManager.RecordWrapper> _wrappers;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public readonly string PackageName;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		public readonly EVerifyLevel BootVerifyLevel;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x20000AA")]
		internal class RecordWrapper
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000013 RID: 19 RVA: 0x000020CA File Offset: 0x000002CA
			// (set) Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A4")]
			public string InfoFilePath
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600051A")]
				[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000015 RID: 21 RVA: 0x000020CA File Offset: 0x000002CA
			// (set) Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A5")]
			public string DataFilePath
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600051C")]
				[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000017 RID: 23 RVA: 0x000020CA File Offset: 0x000002CA
			// (set) Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A6")]
			public string DataFileCRC
			{
				[Token(Token = "0x600051F")]
				[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600051E")]
				[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000019 RID: 25 RVA: 0x000020E8 File Offset: 0x000002E8
			// (set) Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A7")]
			public long DataFileSize
			{
				[Token(Token = "0x6000521")]
				[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x15E2B00", Offset = "0x15E1F00", VA = "0x1815E2B00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x181E6A0", Offset = "0x181DAA0", VA = "0x18181E6A0")]
			public RecordWrapper(string infoFilePath, string dataFilePath, string dataFileCRC, long dataFileSize)
			{
			}

			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000264")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private string <InfoFilePath>k__BackingField;

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000265")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private string <DataFilePath>k__BackingField;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000266")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private string <DataFileCRC>k__BackingField;

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private long <DataFileSize>k__BackingField;
		}
	}
}
