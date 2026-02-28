using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace YooAsset
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x200002C")]
	internal class AssetBundleWebRequest : IWebRequester
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public ERequestStatus Status
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1473680", Offset = "0x1472A80", VA = "0x181473680", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return ERequestStatus.None;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x14736E0", Offset = "0x1472AE0", VA = "0x1814736E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public float DownloadProgress
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xCC1A10", Offset = "0xCC0E10", VA = "0x180CC1A10", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xCC1D80", Offset = "0xCC1180", VA = "0x180CC1D80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public ulong DownloadedBytes
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xB9A950", Offset = "0xB99D50", VA = "0x180B9A950", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x180A5E0", Offset = "0x18099E0", VA = "0x18180A5E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public string RequestNetError
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xB99CC0", Offset = "0xB990C0", VA = "0x180B99CC0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xB99D40", Offset = "0xB99140", VA = "0x180B99D40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public long RequestHttpCode
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1260630", Offset = "0x125FA30", VA = "0x181260630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public AssetBundleWebRequest()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x180A130", Offset = "0x1809530", VA = "0x18180A130", Slot = "9")]
		public void Create(string requestURL, BundleInfo bundleInfo, params object[] args)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x180A420", Offset = "0x1809820", VA = "0x18180A420", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x180A0B0", Offset = "0x18094B0", VA = "0x18180A0B0", Slot = "11")]
		public void Abort()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x180A400", Offset = "0x1809800", VA = "0x18180A400", Slot = "12")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960", Slot = "13")]
		public object GetRequestObject()
		{
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x180A3C0", Offset = "0x18097C0", VA = "0x18180A3C0")]
		private void DisposeWebRequest()
		{
		}

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		private UnityWebRequest _webRequest;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x18")]
		private DownloadHandlerAssetBundle _downloadhandler;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x20")]
		private AssetBundle _cacheAssetBundle;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x28")]
		private bool _getAssetBundle;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ERequestStatus <Status>k__BackingField;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <DownloadProgress>k__BackingField;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ulong <DownloadedBytes>k__BackingField;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <RequestNetError>k__BackingField;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private long <RequestHttpCode>k__BackingField;
	}
}
