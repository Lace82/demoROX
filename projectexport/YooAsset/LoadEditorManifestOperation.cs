using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000071")]
	internal class LoadEditorManifestOperation : AsyncOperationBase
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public PackageManifest Manifest
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xCB0840", Offset = "0xCAFC40", VA = "0x180CB0840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x105DAA0", Offset = "0x105CEA0", VA = "0x18105DAA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public LoadEditorManifestOperation(string packageName, string manifestFilePath)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1BA8780", Offset = "0x1BA7B80", VA = "0x181BA8780", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1BA8790", Offset = "0x1BA7B90", VA = "0x181BA8790", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x48")]
		private readonly string _packageName;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _manifestFilePath;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x58")]
		private DeserializeManifestOperation _deserializer;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x60")]
		private LoadEditorManifestOperation.ESteps _steps;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private PackageManifest <Manifest>k__BackingField;

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x20000D1")]
		private enum ESteps
		{
			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000327")]
			None,
			// Token: 0x0400026A RID: 618
			[Token(Token = "0x4000328")]
			LoadEditorManifest,
			// Token: 0x0400026B RID: 619
			[Token(Token = "0x4000329")]
			CheckDeserializeManifest,
			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400032A")]
			Done
		}
	}
}
