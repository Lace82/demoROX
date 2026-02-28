using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using XGame.HotUpdate;
using XGameFramework.Utils;

namespace XGame.Aot
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x20000DC")]
	public class AotAssemblyMetaManager : Singleton<AotAssemblyMetaManager>
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x13760B0", Offset = "0x13754B0", VA = "0x1813760B0")]
		public void Clear()
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1376010", Offset = "0x1375410", VA = "0x181376010")]
		private void BeginLoadAotAssemblyMeta()
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x13764F0", Offset = "0x13758F0", VA = "0x1813764F0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xC58B0", Offset = "0xC4CB0")]
		public UniTask LoadAssemblies()
		{
			return default(UniTask);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x13765A0", Offset = "0x13759A0", VA = "0x1813765A0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xC5ED0", Offset = "0xC52D0")]
		private UniTask LoadAssemblyManifest()
		{
			return default(UniTask);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1376660", Offset = "0x1375A60", VA = "0x181376660")]
		private void LoadBuiltInAotAssemblyMeta(object obj)
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x13766E0", Offset = "0x1375AE0", VA = "0x1813766E0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xC7630", Offset = "0xC6A30")]
		public UniTask LoadHotUpdateAotAssemblyMeta(List<string> aotAssemblies)
		{
			return default(UniTask);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x13761B0", Offset = "0x13755B0", VA = "0x1813761B0")]
		private void LoadAotAssemblyMeta(List<string> aotAssemblies)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x13760F0", Offset = "0x13754F0", VA = "0x1813760F0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xC7B70", Offset = "0xC6F70")]
		private UniTask LoadAotAssemblyMetaData()
		{
			return default(UniTask);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x13767B0", Offset = "0x1375BB0", VA = "0x1813767B0")]
		public AotAssemblyMetaManager()
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000876")]
		[Address(RVA = "0xCC23B0", Offset = "0xCC17B0", VA = "0x180CC23B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <LoadHotUpdateAotAssemblyMeta>b__8_0()
		{
			return default(bool);
		}

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x10")]
		private AssemblyManifest _assemblyManifest;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _aotAssemblyData;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x20")]
		private bool _loadAotMetaComplete;
	}
}
