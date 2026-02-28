using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000028")]
	internal abstract class DownloaderBase
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public float DownloadProgress
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x17CA230", Offset = "0x17C9630", VA = "0x1817CA230")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x17CA270", Offset = "0x17C9670", VA = "0x1817CA270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public ulong DownloadedBytes
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x8EF970", Offset = "0x8EED70", VA = "0x1808EF970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x18156A0", Offset = "0x1814AA0", VA = "0x1818156A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public int RefCount
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1062A80", Offset = "0x1061E80", VA = "0x181062A80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x105D830", Offset = "0x105CC30", VA = "0x18105D830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1815600", Offset = "0x1814A00", VA = "0x181815600")]
		public DownloaderBase(BundleInfo bundleInfo, Type requesterType, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060000BF RID: 191
		[Token(Token = "0x60000B6")]
		public abstract void SendRequest(params object[] args);

		// Token: 0x060000C0 RID: 192
		[Token(Token = "0x60000B7")]
		public abstract void Update();

		// Token: 0x060000C1 RID: 193
		[Token(Token = "0x60000B8")]
		public abstract void Abort();

		// Token: 0x060000C2 RID: 194
		[Token(Token = "0x60000B9")]
		public abstract void Interrupt(string message);

		// Token: 0x060000C3 RID: 195
		[Token(Token = "0x60000BA")]
		public abstract AssetBundle GetAssetBundle();

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1815520", Offset = "0x1814920", VA = "0x181815520")]
		public void Reference()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1815530", Offset = "0x1814930", VA = "0x181815530")]
		public void Release()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1815510", Offset = "0x1814910", VA = "0x181815510")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1815500", Offset = "0x1814900", VA = "0x181815500")]
		public bool HasError()
		{
			return default(bool);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1815540", Offset = "0x1814940", VA = "0x181815540")]
		public void ReportError()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x18155A0", Offset = "0x18149A0", VA = "0x1818155A0")]
		public void ReportWarning()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1815440", Offset = "0x1814840", VA = "0x181815440")]
		public string GetLastError()
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1815410", Offset = "0x1814810", VA = "0x181815410")]
		public long GetDownloadFileSize()
		{
			return 0L;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x18153E0", Offset = "0x18147E0", VA = "0x1818153E0")]
		public string GetDownloadBundleName()
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
		public BundleInfo GetBundleInfo()
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x18154C0", Offset = "0x18148C0", VA = "0x1818154C0")]
		protected string GetRequestURL()
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1815310", Offset = "0x1814710", VA = "0x181815310")]
		protected void CheckTimeout()
		{
		}

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x10")]
		protected readonly BundleInfo _bundleInfo;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		protected readonly Type _requesterType;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x20")]
		protected readonly int _timeout;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x24")]
		protected int _failedTryAgain;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		protected IWebRequester _requester;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		protected DownloaderBase.EStatus _status;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x38")]
		protected string _lastestNetError;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x40")]
		protected long _lastestHttpCode;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x48")]
		protected int _requestCount;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x50")]
		protected string _requestURL;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x58")]
		protected bool _isAbort;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x60")]
		protected ulong _latestDownloadBytes;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x68")]
		protected float _latestDownloadRealtime;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x6C")]
		protected float _tryAgainTimer;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x70")]
		public bool WaitForAsyncComplete;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <DownloadProgress>k__BackingField;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ulong <DownloadedBytes>k__BackingField;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <RefCount>k__BackingField;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x20000B3")]
		public enum EStatus
		{
			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x4000290")]
			None,
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x4000291")]
			Succeed,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x4000292")]
			Failed
		}
	}
}
