using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x2000063")]
	public abstract class DownloaderOperation : AsyncOperationBase
	{
		// Token: 0x060002AE RID: 686 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x18156B0", Offset = "0x1814AB0", VA = "0x1818156B0")]
		private DownloaderOperation.QueryTask AcquireTask()
		{
			return null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1816DB0", Offset = "0x18161B0", VA = "0x181816DB0")]
		private void Release(DownloaderOperation.QueryTask task)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1815E00", Offset = "0x1815200", VA = "0x181815E00")]
		private uint GetTaskId()
		{
			return 0U;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x105D2A0", Offset = "0x105C6A0", VA = "0x18105D2A0")]
		public void SetMaxDownloadingNumber(int num)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x18171A0", Offset = "0x18165A0", VA = "0x1818171A0")]
		public bool RetryDownload()
		{
			return default(bool);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public int TotalDownloadCount
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1817550", Offset = "0x1816950", VA = "0x181817550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1817570", Offset = "0x1816970", VA = "0x181817570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public long TotalDownloadBytes
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xB99CB0", Offset = "0xB990B0", VA = "0x180B99CB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1817560", Offset = "0x1816960", VA = "0x181817560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x17000074")]
		public int CurrentDownloadCount
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1061720", Offset = "0x1060B20", VA = "0x181061720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000075")]
		public long CurrentDownloadBytes
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xCB0810", Offset = "0xCAFC10", VA = "0x180CB0810")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public DownloaderOperation.OnDownloadOver OnDownloadOverCallback
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xB9BD00", Offset = "0xB9B100", VA = "0x180B9BD00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xB9C1B0", Offset = "0xB9B5B0", VA = "0x180B9C1B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public DownloaderOperation.OnDownloadProgress OnDownloadProgressCallback
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xB9BF40", Offset = "0xB9B340", VA = "0x180B9BF40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xB9C310", Offset = "0xB9B710", VA = "0x180B9C310")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		public DownloaderOperation.OnDownloadError OnDownloadErrorCallback
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xBBCB50", Offset = "0xBBBF50", VA = "0x180BBCB50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xBBE540", Offset = "0xBBD940", VA = "0x180BBE540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public DownloaderOperation.OnStartDownloadFile OnStartDownloadFileCallback
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xB9B030", Offset = "0xB9A430", VA = "0x180B9B030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x10611A0", Offset = "0x10605A0", VA = "0x1810611A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1817390", Offset = "0x1816790", VA = "0x181817390")]
		internal DownloaderOperation(DownloadManager downloadMgr, string packageName, List<BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1815F30", Offset = "0x1815330", VA = "0x181815F30", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1815F40", Offset = "0x1815340", VA = "0x181815F40", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1815860", Offset = "0x1814C60", VA = "0x181815860")]
		private void CalculatDownloaderInfo()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1815A20", Offset = "0x1814E20", VA = "0x181815A20")]
		public void Combine(DownloaderOperation downloader)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1815800", Offset = "0x1814C00", VA = "0x181815800")]
		public void BeginDownload()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1816710", Offset = "0x1815B10", VA = "0x181816710")]
		public void PauseDownload()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1817190", Offset = "0x1816590", VA = "0x181817190")]
		public void ResumeDownload()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x18159B0", Offset = "0x1814DB0", VA = "0x1818159B0")]
		public void CancelDownload()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1816CA0", Offset = "0x18160A0", VA = "0x181816CA0")]
		private void ReleaseAllDownloader()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1816FA0", Offset = "0x18163A0", VA = "0x181816FA0")]
		public void RemoveSyncQueryTaskTimeout()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1816550", Offset = "0x1815950", VA = "0x181816550")]
		private void OnBundleDownEnd(BundleInfo info)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1816E70", Offset = "0x1816270", VA = "0x181816E70")]
		private void RemoveCompleteQueryTasks()
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1816720", Offset = "0x1815B20", VA = "0x181816720")]
		internal uint QueryDownload(List<BundleInfo> list, Action<int> endCall, bool sync)
		{
			return 0U;
		}

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x4000155")]
		private const int MAX_LOADER_COUNT = 64;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x48")]
		private readonly DownloadManager _downloadMgr;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageName;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x58")]
		private int _downloadingMaxNumber;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int _failedTryAgain;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x60")]
		private readonly int _timeout;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<BundleInfo> _bundleInfoList;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<DownloaderBase> _downloaders;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<DownloaderBase> _removeList;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<DownloaderBase> _failedList;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x88")]
		private bool _isPause;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x90")]
		private long _lastDownloadBytes;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x98")]
		private int _lastDownloadCount;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xA0")]
		private long _cachedDownloadBytes;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0xA8")]
		private int _cachedDownloadCount;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xAC")]
		private DownloaderOperation.ESteps _steps;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<uint, DownloaderOperation.QueryTask> _queryTasks;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x0")]
		private static Queue<DownloaderOperation.QueryTask> _queryPool;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x8")]
		private static uint _counter;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <TotalDownloadCount>k__BackingField;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private long <TotalDownloadBytes>k__BackingField;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private DownloaderOperation.OnDownloadOver <OnDownloadOverCallback>k__BackingField;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private DownloaderOperation.OnDownloadProgress <OnDownloadProgressCallback>k__BackingField;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private DownloaderOperation.OnDownloadError <OnDownloadErrorCallback>k__BackingField;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private DownloaderOperation.OnStartDownloadFile <OnStartDownloadFileCallback>k__BackingField;

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x20000C2")]
		private enum ESteps
		{
			// Token: 0x040001F5 RID: 501
			[Token(Token = "0x40002EB")]
			None,
			// Token: 0x040001F6 RID: 502
			[Token(Token = "0x40002EC")]
			Check,
			// Token: 0x040001F7 RID: 503
			[Token(Token = "0x40002ED")]
			Loading,
			// Token: 0x040001F8 RID: 504
			[Token(Token = "0x40002EE")]
			Done
		}

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060002D1 RID: 721
		[Token(Token = "0x20000C3")]
		public delegate void OnDownloadOver(bool isSucceed);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060002D5 RID: 725
		[Token(Token = "0x20000C4")]
		public delegate void OnDownloadProgress(int totalDownloadCount, int currentDownloadCount, long totalDownloadBytes, long currentDownloadBytes);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060002D9 RID: 729
		[Token(Token = "0x20000C5")]
		public delegate void OnDownloadError(string fileName, string error);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060002DD RID: 733
		[Token(Token = "0x20000C6")]
		public delegate void OnStartDownloadFile(string fileName, long sizeBytes);

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x20000C7")]
		private class QueryTask
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x181E600", Offset = "0x181DA00", VA = "0x18181E600")]
			public QueryTask()
			{
			}

			// Token: 0x040001F9 RID: 505
			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x10")]
			internal List<BundleInfo> DownList;

			// Token: 0x040001FA RID: 506
			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x18")]
			internal Action<int> CallBack;

			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x20")]
			internal Stopwatch Sw;

			// Token: 0x040001FC RID: 508
			[Token(Token = "0x40002F2")]
			[FieldOffset(Offset = "0x28")]
			internal bool SyncLoad;
		}

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x20000C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x000029E8 File Offset: 0x00000BE8
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x181E720", Offset = "0x181DB20", VA = "0x18181E720")]
			internal bool <QueryDownload>b__0(DownloaderBase o)
			{
				return default(bool);
			}

			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40002F3")]
			[FieldOffset(Offset = "0x10")]
			public BundleInfo bundleInfo;
		}
	}
}
