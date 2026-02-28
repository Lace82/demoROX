using System;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public interface IDownloadAgentHelper
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600040F RID: 1039
		// (remove) Token: 0x06000410 RID: 1040
		[Token(Token = "0x14000010")]
		event EventHandler<DownloadAgentHelperUpdateBytesEventArgs> DownloadAgentHelperUpdateBytes;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000411 RID: 1041
		// (remove) Token: 0x06000412 RID: 1042
		[Token(Token = "0x14000011")]
		event EventHandler<DownloadAgentHelperUpdateLengthEventArgs> DownloadAgentHelperUpdateLength;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000413 RID: 1043
		// (remove) Token: 0x06000414 RID: 1044
		[Token(Token = "0x14000012")]
		event EventHandler<DownloadAgentHelperCompleteEventArgs> DownloadAgentHelperComplete;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000415 RID: 1045
		// (remove) Token: 0x06000416 RID: 1046
		[Token(Token = "0x14000013")]
		event EventHandler<DownloadAgentHelperErrorEventArgs> DownloadAgentHelperError;

		// Token: 0x06000417 RID: 1047
		[Token(Token = "0x6000417")]
		void Download(string uri, object userData);

		// Token: 0x06000418 RID: 1048
		[Token(Token = "0x6000418")]
		void Download(string uri, int fromPosition, object userData);

		// Token: 0x06000419 RID: 1049
		[Token(Token = "0x6000419")]
		void Download(string uri, int fromPosition, int toPosition, object userData);

		// Token: 0x0600041A RID: 1050
		[Token(Token = "0x600041A")]
		void Reset();

		// Token: 0x0600041B RID: 1051
		[Token(Token = "0x600041B")]
		void Shutdown();
	}
}
