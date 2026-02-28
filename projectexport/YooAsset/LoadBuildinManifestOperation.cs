using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x200006F")]
	internal class LoadBuildinManifestOperation : AsyncOperationBase
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		public PackageManifest Manifest
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xCB0830", Offset = "0xCAFC30", VA = "0x180CB0830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xCC8A60", Offset = "0xCC7E60", VA = "0x180CC8A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public LoadBuildinManifestOperation(PersistentManager persistent, string buildinPackageVersion)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1BA8050", Offset = "0x1BA7450", VA = "0x181BA8050", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _buildinPackageVersion;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x58")]
		private UnityWebDataRequester _downloader;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x60")]
		private DeserializeManifestOperation _deserializer;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x68")]
		private LoadBuildinManifestOperation.ESteps _steps;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private PackageManifest <Manifest>k__BackingField;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x20000CF")]
		private enum ESteps
		{
			// Token: 0x04000251 RID: 593
			[Token(Token = "0x400031B")]
			None,
			// Token: 0x04000252 RID: 594
			[Token(Token = "0x400031C")]
			LoadBuildinManifest,
			// Token: 0x04000253 RID: 595
			[Token(Token = "0x400031D")]
			CheckDeserializeManifest,
			// Token: 0x04000254 RID: 596
			[Token(Token = "0x400031E")]
			Done
		}
	}
}
