using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XGame.Settings
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000CB")]
	public static class XGameSettingsUtility
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000053")]
		public static XGameHybridCLRSettings GameHybridCLRSettings
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x3893450", Offset = "0x3892850", VA = "0x183893450")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x3893370", Offset = "0x3892770", VA = "0x183893370")]
		public static void SetHybridClrHotUpdateAssemblies(List<string> hotUpdateAssemblies)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x38932D0", Offset = "0x38926D0", VA = "0x1838932D0")]
		public static void SetHybridClrDheUpdateAssemblies(IEnumerable<string> dheUpdateAssemblies)
		{
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x3893250", Offset = "0x3892650", VA = "0x183893250")]
		public static string HotUpdateAssembliesAssetRoot()
		{
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x3893180", Offset = "0x3892580", VA = "0x183893180")]
		public static string HotUpdateAssembliesAssetPath()
		{
			return null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x3893140", Offset = "0x3892540", VA = "0x183893140")]
		public static string AOTAssembliesAssetPath()
		{
			return null;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600083B")]
		private static T GetSingletonScriptObjectFromResources<T>(string assetPath) where T : ScriptableObject
		{
			return null;
		}

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string GameHybridClrSettingsPath;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x400038D")]
		public const string BACK_UP_AOT_DIR = "BuildBranch/ro_client_branch";

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x400038E")]
		public const string ENCRYPT_DHE_DIR = "HybridCLRData/EncryptDHE";

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x400038F")]
		public const string DH_AO_DIR = "HybridCLRData/Dhao";

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000390")]
		public const string HYBRID_ENCRYPT_BUILD_MANIFEST = "HybridEncryptManifest.bytes";

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x8")]
		private static XGameHybridCLRSettings _gameHybridCLRSettings;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000392")]
		public const string HOT_UPDATE = "HotUpdate";

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000393")]
		public const string AOT = "AOT";
	}
}
