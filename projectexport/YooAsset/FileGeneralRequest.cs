using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YooAsset
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200002E")]
	internal class FileGeneralRequest : IWebRequester
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public ERequestStatus Status
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xB9A920", Offset = "0xB99D20", VA = "0x180B9A920", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return ERequestStatus.None;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1238580", Offset = "0x1237980", VA = "0x181238580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public float DownloadProgress
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xCB9690", Offset = "0xCB8A90", VA = "0x180CB9690", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1819610", Offset = "0x1818A10", VA = "0x181819610")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public ulong DownloadedBytes
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1237750", Offset = "0x1236B50", VA = "0x181237750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public string RequestNetError
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public long RequestHttpCode
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1819620", Offset = "0x1818A20", VA = "0x181819620")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public FileGeneralRequest()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1819270", Offset = "0x1818670", VA = "0x181819270", Slot = "9")]
		public void Create(string requestURL, BundleInfo bundleInfo, params object[] args)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x18194F0", Offset = "0x18188F0", VA = "0x1818194F0", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x18191E0", Offset = "0x18185E0", VA = "0x1818191E0", Slot = "11")]
		public void Abort()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x18194D0", Offset = "0x18188D0", VA = "0x1818194D0", Slot = "12")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1819480", Offset = "0x1818880", VA = "0x181819480", Slot = "13")]
		public object GetRequestObject()
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x180A3C0", Offset = "0x18097C0", VA = "0x18180A3C0")]
		private void DisposeWebRequest()
		{
		}

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x10")]
		private UnityWebRequest _webRequest;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ERequestStatus <Status>k__BackingField;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <DownloadProgress>k__BackingField;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ulong <DownloadedBytes>k__BackingField;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <RequestNetError>k__BackingField;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private long <RequestHttpCode>k__BackingField;
	}
}
