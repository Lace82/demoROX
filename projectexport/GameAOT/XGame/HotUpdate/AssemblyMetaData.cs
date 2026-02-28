using System;
using Il2CppDummyDll;

namespace XGame.HotUpdate
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000CD")]
	[Serializable]
	public class AssemblyMetaData
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public AssemblyMetaData()
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x388B5E0", Offset = "0x388A9E0", VA = "0x18388B5E0")]
		public AssemblyMetaData(string name, long startPosition, long endPosition)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x388B5B0", Offset = "0x388A9B0", VA = "0x18388B5B0")]
		public static string GetAOTAssemblyMetaFileName()
		{
			return null;
		}

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x18")]
		public long StartPosition;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x20")]
		public long EndPosition;
	}
}
