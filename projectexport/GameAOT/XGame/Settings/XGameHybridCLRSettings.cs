using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XGame.Settings
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000CA")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xC2E00", Offset = "0xC2200")]
	public class XGameHybridCLRSettings : ScriptableObject
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x000040E0 File Offset: 0x000022E0
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public bool Enable
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x1087AB0", Offset = "0x1086EB0", VA = "0x181087AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x1087E00", Offset = "0x1087200", VA = "0x181087E00")]
			set
			{
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x38930C0", Offset = "0x38924C0", VA = "0x1838930C0")]
		public XGameHybridCLRSettings()
		{
		}

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _enable;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x20")]
		public List<string> HotUpdateAssemblies;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x28")]
		public List<string> DheUpdateAssemblies;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x30")]
		public List<string> AOTAssembliesMeta;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x38")]
		public List<string> RealLoadAotAssemblies;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x40")]
		public string HotAssemblyEncryptKey;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x48")]
		public bool ForceResetVmSeed;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x50")]
		public string HotUpdateEntryDllName;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x58")]
		public string HybridCLRAssemblyPath;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x60")]
		public string AotAssemblyManifestFileName;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x68")]
		public string HotUpdateAssemblyManifestFileName;
	}
}
