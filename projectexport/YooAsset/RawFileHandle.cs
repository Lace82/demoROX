using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000044")]
	public class RawFileHandle : HandleBase, IDisposable
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1BB1220", Offset = "0x1BB0620", VA = "0x181BB1220")]
		internal RawFileHandle(ProviderBase provider)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1BB11D0", Offset = "0x1BB05D0", VA = "0x181BB11D0", Slot = "7")]
		internal override void InvokeCallback()
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event Action<RawFileHandle> Completed
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1BB1230", Offset = "0x1BB0630", VA = "0x181BB1230")]
			add
			{
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1BB1360", Offset = "0x1BB0760", VA = "0x181BB1360")]
			remove
			{
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1808D70", Offset = "0x1808170", VA = "0x181808D70")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1BB0F30", Offset = "0x1BB0330", VA = "0x181BB0F30")]
		public void Release()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1BB0F30", Offset = "0x1BB0330", VA = "0x181BB0F30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1BB0FC0", Offset = "0x1BB03C0", VA = "0x181BB0FC0")]
		public byte[] GetRawFileData()
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1BB0F40", Offset = "0x1BB0340", VA = "0x181BB0F40")]
		public byte[] GetRawFileDataEx()
		{
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1BB1190", Offset = "0x1BB0590", VA = "0x181BB1190")]
		public string GetRawFileText()
		{
			return null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1BB1120", Offset = "0x1BB0520", VA = "0x181BB1120")]
		public string GetRawFilePath()
		{
			return null;
		}

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x28")]
		private VirtualManifest _manifest;
	}
}
