using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x2000031")]
	internal interface IWebRequester
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011A RID: 282
		[Token(Token = "0x17000028")]
		ERequestStatus Status { [Token(Token = "0x6000111")] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600011B RID: 283
		[Token(Token = "0x17000029")]
		float DownloadProgress { [Token(Token = "0x6000112")] get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600011C RID: 284
		[Token(Token = "0x1700002A")]
		ulong DownloadedBytes { [Token(Token = "0x6000113")] get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011D RID: 285
		[Token(Token = "0x1700002B")]
		string RequestNetError { [Token(Token = "0x6000114")] get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011E RID: 286
		[Token(Token = "0x1700002C")]
		long RequestHttpCode { [Token(Token = "0x6000115")] get; }

		// Token: 0x0600011F RID: 287
		[Token(Token = "0x6000116")]
		void Create(string url, BundleInfo bundleInfo, params object[] args);

		// Token: 0x06000120 RID: 288
		[Token(Token = "0x6000117")]
		void Update();

		// Token: 0x06000121 RID: 289
		[Token(Token = "0x6000118")]
		void Abort();

		// Token: 0x06000122 RID: 290
		[Token(Token = "0x6000119")]
		bool IsDone();

		// Token: 0x06000123 RID: 291
		[Token(Token = "0x600011A")]
		object GetRequestObject();
	}
}
