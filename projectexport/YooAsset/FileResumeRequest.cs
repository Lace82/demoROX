using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YooAsset
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200002F")]
	internal class FileResumeRequest : IWebRequester
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public ERequestStatus Status
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xCC0260", Offset = "0xCBF660", VA = "0x180CC0260", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return ERequestStatus.None;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xCC03E0", Offset = "0xCBF7E0", VA = "0x180CC03E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public float DownloadProgress
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xCC1AA0", Offset = "0xCC0EA0", VA = "0x180CC1AA0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xCC21C0", Offset = "0xCC15C0", VA = "0x180CC21C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002460 File Offset: 0x00000660
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public ulong DownloadedBytes
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xB9A950", Offset = "0xB99D50", VA = "0x180B9A950", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x180A5E0", Offset = "0x18099E0", VA = "0x18180A5E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public string RequestNetError
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xB99CC0", Offset = "0xB990C0", VA = "0x180B99CC0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xB99D40", Offset = "0xB99140", VA = "0x180B99D40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002478 File Offset: 0x00000678
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public long RequestHttpCode
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1260630", Offset = "0x125FA30", VA = "0x181260630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public FileResumeRequest()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x18196A0", Offset = "0x1818AA0", VA = "0x1818196A0", Slot = "9")]
		public void Create(string requestURL, BundleInfo bundleInfo, params object[] args)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1819A20", Offset = "0x1818E20", VA = "0x181819A20", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1819630", Offset = "0x1818A30", VA = "0x181819630", Slot = "11")]
		public void Abort()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1819A00", Offset = "0x1818E00", VA = "0x181819A00", Slot = "12")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x18199B0", Offset = "0x1818DB0", VA = "0x1818199B0", Slot = "13")]
		public object GetRequestObject()
		{
			return null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1819900", Offset = "0x1818D00", VA = "0x181819900")]
		private void DisposeWebRequest()
		{
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x10")]
		private string _tempFilePath;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x18")]
		private UnityWebRequest _webRequest;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x20")]
		private DownloadHandlerFileRange _downloadHandle;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		private ulong _fileOriginLength;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ERequestStatus <Status>k__BackingField;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <DownloadProgress>k__BackingField;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ulong <DownloadedBytes>k__BackingField;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <RequestNetError>k__BackingField;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private long <RequestHttpCode>k__BackingField;
	}
}
