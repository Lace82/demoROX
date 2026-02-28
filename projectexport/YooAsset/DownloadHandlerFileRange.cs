using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YooAsset
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x200002D")]
	internal class DownloadHandlerFileRange : DownloadHandlerScript
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x18140F0", Offset = "0x18134F0", VA = "0x1818140F0")]
		public DownloadHandlerFileRange(string fileSavePath, long fileTotalSize, UnityWebRequest webRequest)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1814060", Offset = "0x1813460", VA = "0x181814060", Slot = "7")]
		protected override bool ReceiveData(byte[] data, int dataLength)
		{
			return default(bool);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "5")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0", Slot = "6")]
		protected override string GetText()
		{
			return null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1814040", Offset = "0x1813440", VA = "0x181814040", Slot = "11")]
		protected override float GetProgress()
		{
			return 0f;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1813FE0", Offset = "0x18133E0", VA = "0x181813FE0")]
		public void Cleanup()
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x18")]
		private string _fileSavePath;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x20")]
		private long _fileTotalSize;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest _webRequest;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x30")]
		private FileStream _fileStream;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x38")]
		private long _localFileSize;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x40")]
		private long _curFileSize;
	}
}
