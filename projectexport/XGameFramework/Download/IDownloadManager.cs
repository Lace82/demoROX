using System;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public interface IDownloadManager : IModule
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600041C RID: 1052
		// (set) Token: 0x0600041D RID: 1053
		[Token(Token = "0x170000BA")]
		bool Paused { [Token(Token = "0x600041C")] get; [Token(Token = "0x600041D")] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600041E RID: 1054
		[Token(Token = "0x170000BB")]
		int TotalAgentCount { [Token(Token = "0x600041E")] get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600041F RID: 1055
		[Token(Token = "0x170000BC")]
		int FreeAgentCount { [Token(Token = "0x600041F")] get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000420 RID: 1056
		[Token(Token = "0x170000BD")]
		int RunningAgentCount { [Token(Token = "0x6000420")] get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000421 RID: 1057
		[Token(Token = "0x170000BE")]
		int WaitingTaskCount { [Token(Token = "0x6000421")] get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000422 RID: 1058
		// (set) Token: 0x06000423 RID: 1059
		[Token(Token = "0x170000BF")]
		int FlushSize { [Token(Token = "0x6000422")] get; [Token(Token = "0x6000423")] set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000424 RID: 1060
		// (set) Token: 0x06000425 RID: 1061
		[Token(Token = "0x170000C0")]
		float Timeout { [Token(Token = "0x6000424")] get; [Token(Token = "0x6000425")] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000426 RID: 1062
		[Token(Token = "0x170000C1")]
		float CurrentSpeed { [Token(Token = "0x6000426")] get; }

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000427 RID: 1063
		// (remove) Token: 0x06000428 RID: 1064
		[Token(Token = "0x14000014")]
		event EventHandler<DownloadStartEventArgs> DownloadStart;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000429 RID: 1065
		// (remove) Token: 0x0600042A RID: 1066
		[Token(Token = "0x14000015")]
		event EventHandler<DownloadUpdateEventArgs> DownloadUpdate;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600042B RID: 1067
		// (remove) Token: 0x0600042C RID: 1068
		[Token(Token = "0x14000016")]
		event EventHandler<DownloadSuccessEventArgs> DownloadSuccess;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600042D RID: 1069
		// (remove) Token: 0x0600042E RID: 1070
		[Token(Token = "0x14000017")]
		event EventHandler<DownloadFailureEventArgs> DownloadFailure;

		// Token: 0x0600042F RID: 1071
		[Token(Token = "0x600042F")]
		void AddDownloadAgentHelper(IDownloadAgentHelper agentHelper);

		// Token: 0x06000430 RID: 1072
		[Token(Token = "0x6000430")]
		int AddDownloadTask(string cachePath, string uri);

		// Token: 0x06000431 RID: 1073
		[Token(Token = "0x6000431")]
		int AddDownloadTask(string cachePath, string uri, object userData);

		// Token: 0x06000432 RID: 1074
		[Token(Token = "0x6000432")]
		int AddDownloadTask(string cachePath, string uri, int priority);

		// Token: 0x06000433 RID: 1075
		[Token(Token = "0x6000433")]
		int AddDownloadTask(string cachePath, string uri, int priority, object userData);

		// Token: 0x06000434 RID: 1076
		[Token(Token = "0x6000434")]
		bool RemoveDownloadTask(int taskId);

		// Token: 0x06000435 RID: 1077
		[Token(Token = "0x6000435")]
		void RemoveAllDownloadTasks();

		// Token: 0x06000436 RID: 1078
		[Token(Token = "0x6000436")]
		TaskInfo[] GetAllDownloadInfos();
	}
}
