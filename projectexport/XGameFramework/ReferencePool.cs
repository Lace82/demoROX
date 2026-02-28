using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public static class ReferencePool
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x17000019")]
		public static int Count
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2B9C010", Offset = "0x2B9B410", VA = "0x182B9C010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2B9B770", Offset = "0x2B9AB70", VA = "0x182B9B770")]
		public static ReferencePoolInfo[] GetAllReferencePoolInfos()
		{
			return null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2B9B530", Offset = "0x2B9A930", VA = "0x182B9B530")]
		public static void ClearAll()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A1")]
		public static T Acquire<T>() where T : class, IReference, new()
		{
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2B9B3C0", Offset = "0x2B9A7C0", VA = "0x182B9B3C0")]
		public static IReference Acquire(Type referenceType)
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2B9B430", Offset = "0x2B9A830", VA = "0x182B9B430")]
		public static IReference Acquire(Type referenceType, params object[] args)
		{
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2B9BE00", Offset = "0x2B9B200", VA = "0x182B9BE00")]
		public static void Release(IReference reference)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		public static void Add<T>(int count) where T : class, IReference, new()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2B9B4B0", Offset = "0x2B9A8B0", VA = "0x182B9B4B0")]
		public static void Add(Type referenceType, int count)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		public static void Remove<T>(int count) where T : class, IReference
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2B9BF30", Offset = "0x2B9B330", VA = "0x182B9BF30")]
		public static void Remove(Type referenceType, int count)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		public static void RemoveAll<T>() where T : class, IReference
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2B9BEC0", Offset = "0x2B9B2C0", VA = "0x182B9BEC0")]
		public static void RemoveAll(Type referenceType)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2B9BB20", Offset = "0x2B9AF20", VA = "0x182B9BB20")]
		private static ReferencePool.ReferenceCollection GetReferenceCollection(Type referenceType)
		{
			return null;
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x46821AC")]
		private static readonly Dictionary<Type, ReferencePool.ReferenceCollection> _referenceCollections;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		private sealed class ReferenceCollection
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700001A")]
			public Type ReferenceType
			{
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000AE RID: 174 RVA: 0x000021EC File Offset: 0x000003EC
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700001B")]
			public int UsingCount
			{
				[Token(Token = "0x60000AE")]
				[Address(RVA = "0xCC2F30", Offset = "0xCC2330", VA = "0x180CC2F30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x123B510", Offset = "0x123A910", VA = "0x18123B510")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002204 File Offset: 0x00000404
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700001C")]
			public int AcquireCount
			{
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0xCC2F20", Offset = "0xCC2320", VA = "0x180CC2F20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x10481A0", Offset = "0x10475A0", VA = "0x1810481A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000221C File Offset: 0x0000041C
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700001D")]
			public int ReleaseCount
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0xCC3510", Offset = "0xCC2910", VA = "0x180CC3510")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0x1046F30", Offset = "0x1046330", VA = "0x181046F30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002234 File Offset: 0x00000434
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700001E")]
			public int AddCount
			{
				[Token(Token = "0x60000B4")]
				[Address(RVA = "0x1473680", Offset = "0x1472A80", VA = "0x181473680")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0x14736E0", Offset = "0x1472AE0", VA = "0x1814736E0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000224C File Offset: 0x0000044C
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700001F")]
			public int RemoveCount
			{
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0xCC0260", Offset = "0xCBF660", VA = "0x180CC0260")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0xCC03E0", Offset = "0xCBF7E0", VA = "0x180CC03E0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002264 File Offset: 0x00000464
			[Token(Token = "0x17000020")]
			public int UnusedReferenceCount
			{
				[Token(Token = "0x60000B8")]
				[Address(RVA = "0x2B9B320", Offset = "0x2B9A720", VA = "0x182B9B320")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2B9B280", Offset = "0x2B9A680", VA = "0x182B9B280")]
			public ReferenceCollection(Type referenceType)
			{
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60000BA")]
			public T Acquire<T>() where T : class, IReference, new()
			{
				return null;
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x2B9AD50", Offset = "0x2B9A150", VA = "0x182B9AD50")]
			public IReference Acquire()
			{
				return null;
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x2B9AB30", Offset = "0x2B99F30", VA = "0x182B9AB30")]
			public IReference Acquire(params object[] args)
			{
				return null;
			}

			// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2B9AFF0", Offset = "0x2B9A3F0", VA = "0x182B9AFF0")]
			public void Release(IReference reference)
			{
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000BE")]
			public void Add<T>(int count) where T : class, IReference, new()
			{
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2B9AED0", Offset = "0x2B9A2D0", VA = "0x182B9AED0")]
			public void Add(int count)
			{
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2B9B1A0", Offset = "0x2B9A5A0", VA = "0x182B9B1A0")]
			public void Remove(int count)
			{
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2B9B0E0", Offset = "0x2B9A4E0", VA = "0x182B9B0E0")]
			public void RemoveAll()
			{
			}

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x10")]
			private readonly Queue<IReference> _references;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private readonly Type <ReferenceType>k__BackingField;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <UsingCount>k__BackingField;

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <AcquireCount>k__BackingField;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <ReleaseCount>k__BackingField;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <AddCount>k__BackingField;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <RemoveCount>k__BackingField;
		}
	}
}
