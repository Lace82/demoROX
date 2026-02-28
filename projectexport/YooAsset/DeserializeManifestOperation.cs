using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x200006D")]
	internal class DeserializeManifestOperation : AsyncOperationBase
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002FD RID: 765 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public PackageManifest Manifest
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xCB0750", Offset = "0xCAFB50", VA = "0x180CB0750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xB9D9F0", Offset = "0xB9CDF0", VA = "0x180B9D9F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1813F60", Offset = "0x1813360", VA = "0x181813F60")]
		public DeserializeManifestOperation(byte[] binaryData)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1811AE0", Offset = "0x1810EE0", VA = "0x181811AE0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x18130F0", Offset = "0x18124F0", VA = "0x1818130F0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x48")]
		private readonly BufferReader _buffer;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x50")]
		private int _packageAssetCount;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x54")]
		private int _packageBundleCount;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x58")]
		private int _progressTotalValue;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x5C")]
		private DeserializeManifestOperation.ESteps _steps;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private PackageManifest <Manifest>k__BackingField;

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x20000CD")]
		private enum ESteps
		{
			// Token: 0x04000236 RID: 566
			[Token(Token = "0x400030E")]
			None,
			// Token: 0x04000237 RID: 567
			[Token(Token = "0x400030F")]
			DeserializeFileHeader,
			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000310")]
			PrepareAssetList,
			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000311")]
			DeserializeAssetList,
			// Token: 0x0400023A RID: 570
			[Token(Token = "0x4000312")]
			PrepareBundleList,
			// Token: 0x0400023B RID: 571
			[Token(Token = "0x4000313")]
			DeserializeBundleList,
			// Token: 0x0400023C RID: 572
			[Token(Token = "0x4000314")]
			Done
		}
	}
}
