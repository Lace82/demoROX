using System;
using System.IO;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	internal sealed class DownloadManager : IModule, ITick, IDownloadManager
	{
		// Token: 0x06000389 RID: 905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2B92730", Offset = "0x2B91B30", VA = "0x182B92730", Slot = "4")]
		public void OnInit()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2B91E70", Offset = "0x2B91270", VA = "0x182B91E70", Slot = "7")]
		public int GetPriority()
		{
			return 0;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00002F6C File Offset: 0x0000116C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000091")]
		public bool Paused
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x2B92D40", Offset = "0x2B92140", VA = "0x182B92D40", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x2B93070", Offset = "0x2B92470", VA = "0x182B93070", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x17000092")]
		public int TotalAgentCount
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x2B92DD0", Offset = "0x2B921D0", VA = "0x182B92DD0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x17000093")]
		public int FreeAgentCount
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x2B92CF0", Offset = "0x2B920F0", VA = "0x182B92CF0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x17000094")]
		public int RunningAgentCount
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x2B92D80", Offset = "0x2B92180", VA = "0x182B92D80", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x17000095")]
		public int WaitingTaskCount
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x2B92E20", Offset = "0x2B92220", VA = "0x182B92E20", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000096")]
		public int FlushSize
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1002C00", Offset = "0x1002000", VA = "0x181002C00", Slot = "14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x11B8E30", Offset = "0x11B8230", VA = "0x1811B8E30", Slot = "15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00002FFC File Offset: 0x000011FC
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000097")]
		public float Timeout
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x15CF1C0", Offset = "0x15CE5C0", VA = "0x1815CF1C0", Slot = "16")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x15CF210", Offset = "0x15CE610", VA = "0x1815CF210", Slot = "17")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x17000098")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x2B92CD0", Offset = "0x2B920D0", VA = "0x182B92CD0", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000396 RID: 918 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000397 RID: 919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000C")]
		public event EventHandler<DownloadStartEventArgs> DownloadStart
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x2B92B50", Offset = "0x2B91F50", VA = "0x182B92B50", Slot = "19")]
			add
			{
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x2B92EF0", Offset = "0x2B922F0", VA = "0x182B92EF0", Slot = "20")]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000398 RID: 920 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000399 RID: 921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000D")]
		public event EventHandler<DownloadUpdateEventArgs> DownloadUpdate
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x2B92C50", Offset = "0x2B92050", VA = "0x182B92C50", Slot = "21")]
			add
			{
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x2B92FF0", Offset = "0x2B923F0", VA = "0x182B92FF0", Slot = "22")]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600039A RID: 922 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600039B RID: 923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000E")]
		public event EventHandler<DownloadSuccessEventArgs> DownloadSuccess
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x2B92BD0", Offset = "0x2B91FD0", VA = "0x182B92BD0", Slot = "23")]
			add
			{
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2B92F70", Offset = "0x2B92370", VA = "0x182B92F70", Slot = "24")]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600039C RID: 924 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600039D RID: 925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000F")]
		public event EventHandler<DownloadFailureEventArgs> DownloadFailure
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x2B92AD0", Offset = "0x2B91ED0", VA = "0x182B92AD0", Slot = "25")]
			add
			{
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2B92E70", Offset = "0x2B92270", VA = "0x182B92E70", Slot = "26")]
			remove
			{
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2B92920", Offset = "0x2B91D20", VA = "0x182B92920", Slot = "6")]
		public void Tick(double deltaTime)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2B918C0", Offset = "0x2B90CC0", VA = "0x182B918C0", Slot = "27")]
		public void AddDownloadAgentHelper(IDownloadAgentHelper agentHelper)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2B91DC0", Offset = "0x2B911C0", VA = "0x182B91DC0", Slot = "28")]
		public int AddDownloadTask(string cachePath, string uri)
		{
			return 0;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2B91E00", Offset = "0x2B91200", VA = "0x182B91E00", Slot = "30")]
		public int AddDownloadTask(string cachePath, string uri, int priority)
		{
			return 0;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2B91DE0", Offset = "0x2B911E0", VA = "0x182B91DE0", Slot = "29")]
		public int AddDownloadTask(string cachePath, string uri, object userData)
		{
			return 0;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2B91B90", Offset = "0x2B90F90", VA = "0x182B91B90", Slot = "31")]
		public int AddDownloadTask(string cachePath, string uri, int priority, object userData)
		{
			return 0;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2B927E0", Offset = "0x2B91BE0", VA = "0x182B927E0", Slot = "32")]
		public bool RemoveDownloadTask(int taskId)
		{
			return default(bool);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2B92790", Offset = "0x2B91B90", VA = "0x182B92790", Slot = "33")]
		public void RemoveAllDownloadTasks()
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2B91E20", Offset = "0x2B91220", VA = "0x182B91E20", Slot = "34")]
		public TaskInfo[] GetAllDownloadInfos()
		{
			return null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2B92070", Offset = "0x2B91470", VA = "0x182B92070")]
		private void OnDownloadAgentStart(DownloadManager.DownloadAgent sender)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2B92450", Offset = "0x2B91850", VA = "0x182B92450")]
		private void OnDownloadAgentUpdate(DownloadManager.DownloadAgent sender, int lastDownloadedLength)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2B92260", Offset = "0x2B91660", VA = "0x182B92260")]
		private void OnDownloadAgentSuccess(DownloadManager.DownloadAgent sender, int lastDownloadedLength)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2B91E80", Offset = "0x2B91280", VA = "0x182B91E80")]
		private void OnDownloadAgentFailure(DownloadManager.DownloadAgent sender, string errorMessage)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2B92840", Offset = "0x2B91C40", VA = "0x182B92840", Slot = "5")]
		public void Shutdown()
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2B92990", Offset = "0x2B91D90", VA = "0x182B92990")]
		public DownloadManager()
		{
		}

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		private const int ONE_MEGA_BYTES = 1048576;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x10")]
		private readonly TaskPool<DownloadManager.DownloadTask> _taskPool;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		private readonly DownloadManager.DownloadCounter _downloadCounter;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		private const float UPDATE_COUNTER_INTERVAL = 1f;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		private const float RECORD_COUNTER_INTERVAL = 10f;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<DownloadStartEventArgs> _downloadStartEventHandler;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x28")]
		private EventHandler<DownloadUpdateEventArgs> _downloadUpdateEventHandler;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x30")]
		private EventHandler<DownloadSuccessEventArgs> _downloadSuccessEventHandler;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x38")]
		private EventHandler<DownloadFailureEventArgs> _downloadFailureEventHandler;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <FlushSize>k__BackingField;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <Timeout>k__BackingField;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		private sealed class DownloadAgent : ITaskAgent<DownloadManager.DownloadTask>, IDisposable
		{
			// Token: 0x060003AD RID: 941 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x2B90D40", Offset = "0x2B90140", VA = "0x182B90D40")]
			public DownloadAgent(IDownloadAgentHelper downloadAgentHelper)
			{
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060003AE RID: 942 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060003AF RID: 943 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000099")]
			public DownloadManager.DownloadTask Task
			{
				[Token(Token = "0x60003AE")]
				[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0", Slot = "4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0x105CEA0", Offset = "0x105C2A0", VA = "0x18105CEA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060003B0 RID: 944 RVA: 0x000030A4 File Offset: 0x000012A4
			// (set) Token: 0x060003B1 RID: 945 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700009A")]
			private float WaitTime
			{
				[Token(Token = "0x60003B0")]
				[Address(RVA = "0xCB0930", Offset = "0xCAFD30", VA = "0x180CB0930")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0xCB12B0", Offset = "0xCB06B0", VA = "0x180CB12B0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				set
				{
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060003B2 RID: 946 RVA: 0x000030BC File Offset: 0x000012BC
			// (set) Token: 0x060003B3 RID: 947 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700009B")]
			private int StartLength
			{
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0x12D8670", Offset = "0x12D7A70", VA = "0x1812D8670")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x179A940", Offset = "0x1799D40", VA = "0x18179A940")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				set
				{
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060003B4 RID: 948 RVA: 0x000030D4 File Offset: 0x000012D4
			// (set) Token: 0x060003B5 RID: 949 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700009C")]
			private int DownloadedLength
			{
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0x105D280", Offset = "0x105C680", VA = "0x18105D280")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x105D2A0", Offset = "0x105C6A0", VA = "0x18105D2A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				set
				{
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060003B6 RID: 950 RVA: 0x000030EC File Offset: 0x000012EC
			[Token(Token = "0x1700009D")]
			public int CurrentLength
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x2B90DE0", Offset = "0x2B901E0", VA = "0x182B90DE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00003104 File Offset: 0x00001304
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700009E")]
			private int SavedLength
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x1063E30", Offset = "0x1063230", VA = "0x181063E30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x1063E40", Offset = "0x1063240", VA = "0x181063E40")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				set
				{
				}
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2B8FFD0", Offset = "0x2B8F3D0", VA = "0x182B8FFD0", Slot = "5")]
			public void Initialize()
			{
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2B90BE0", Offset = "0x2B8FFE0", VA = "0x182B90BE0", Slot = "8")]
			public void Tick(double deltaTime)
			{
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0000311C File Offset: 0x0000131C
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x2B90860", Offset = "0x2B8FC60", VA = "0x182B90860", Slot = "9")]
			public EStartTaskStatus Start(DownloadManager.DownloadTask task)
			{
				return EStartTaskStatus.Done;
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x2B905B0", Offset = "0x2B8F9B0", VA = "0x182B905B0", Slot = "7")]
			public void Reset()
			{
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x2B903D0", Offset = "0x2B8F7D0", VA = "0x182B903D0")]
			private void OnDownloadAgentHelperUpdateBytes(object sender, DownloadAgentHelperUpdateBytesEventArgs e)
			{
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2B90540", Offset = "0x2B8F940", VA = "0x182B90540")]
			private void OnDownloadAgentHelperUpdateLength(object sender, DownloadAgentHelperUpdateLengthEventArgs e)
			{
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x2B90140", Offset = "0x2B8F540", VA = "0x182B90140")]
			private void OnDownloadAgentHelperComplete(object sender, DownloadAgentHelperCompleteEventArgs e)
			{
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x2B902D0", Offset = "0x2B8F6D0", VA = "0x182B902D0")]
			private void OnDownloadAgentHelperError(object sender, DownloadAgentHelperErrorEventArgs e)
			{
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x2B90660", Offset = "0x2B8FA60", VA = "0x182B90660", Slot = "6")]
			public void Shutdown()
			{
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x2B8FF40", Offset = "0x2B8F340", VA = "0x182B8FF40", Slot = "10")]
			public void Dispose()
			{
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x2B8FEF0", Offset = "0x2B8F2F0", VA = "0x182B8FEF0")]
			private void Dispose(bool disposing)
			{
			}

			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x10")]
			private readonly IDownloadAgentHelper _agentHelper;

			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x18")]
			private FileStream _fileStream;

			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x20")]
			private int _waitFlushSize;

			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x24")]
			private bool _bDisposed;

			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x28")]
			public Action<DownloadManager.DownloadAgent> DownloadAgentStart;

			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x30")]
			public Action<DownloadManager.DownloadAgent, int> DownloadAgentUpdate;

			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x38")]
			public Action<DownloadManager.DownloadAgent, int> DownloadAgentSuccess;

			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x40")]
			public Action<DownloadManager.DownloadAgent, string> DownloadAgentFailure;

			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private DownloadManager.DownloadTask <Task>k__BackingField;

			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private float <WaitTime>k__BackingField;

			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <StartLength>k__BackingField;

			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <DownloadedLength>k__BackingField;

			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			[FieldOffset(Offset = "0x5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <SavedLength>k__BackingField;
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		private sealed class DownloadCounter
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x2B914A0", Offset = "0x2B908A0", VA = "0x182B914A0")]
			public DownloadCounter(float updateInterval, float recordInterval)
			{
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x00003134 File Offset: 0x00001334
			[Token(Token = "0x1700009F")]
			public float CurrentSpeed
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0x17BD390", Offset = "0x17BC790", VA = "0x1817BD390")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x2B90EB0", Offset = "0x2B902B0", VA = "0x182B90EB0")]
			public void Dispose()
			{
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x2B91010", Offset = "0x2B90410", VA = "0x182B91010")]
			public void Tick(float deltaTime)
			{
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x2B90F00", Offset = "0x2B90300", VA = "0x182B90F00")]
			public void RecordDownloadedLength(int downloadedLength)
			{
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x2B90EB0", Offset = "0x2B902B0", VA = "0x182B90EB0")]
			private void Reset()
			{
			}

			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			[FieldOffset(Offset = "0x10")]
			private readonly LinkedListQueue<DownloadManager.DownloadCounterNode> _downloadCounterNodes;

			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x18")]
			private float _updateInterval;

			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			[FieldOffset(Offset = "0x1C")]
			private float _recordInterval;

			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x20")]
			private float _currentSpeed;

			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x24")]
			private float _accumulator;

			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x28")]
			private float _timeLeft;
		}

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		private sealed class DownloadCounterNode : IReference
		{
			// Token: 0x060003CA RID: 970 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x2B90E90", Offset = "0x2B90290", VA = "0x182B90E90")]
			public DownloadCounterNode()
			{
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060003CB RID: 971 RVA: 0x0000314C File Offset: 0x0000134C
			// (set) Token: 0x060003CC RID: 972 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A0")]
			public int DownloadedLength
			{
				[Token(Token = "0x60003CB")]
				[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0x943540", Offset = "0x942940", VA = "0x180943540")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060003CD RID: 973 RVA: 0x00003164 File Offset: 0x00001364
			// (set) Token: 0x060003CE RID: 974 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A1")]
			public float ElapsedTime
			{
				[Token(Token = "0x60003CD")]
				[Address(RVA = "0x161A7E0", Offset = "0x1619BE0", VA = "0x18161A7E0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0x2AFC590", Offset = "0x2AFB990", VA = "0x182AFC590")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x2B90E10", Offset = "0x2B90210", VA = "0x182B90E10")]
			public static DownloadManager.DownloadCounterNode Create(int downloadLength)
			{
				return null;
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x2B90E80", Offset = "0x2B90280", VA = "0x182B90E80")]
			public void Tick(float deltaTime)
			{
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2B90DF0", Offset = "0x2B901F0", VA = "0x182B90DF0")]
			public void AddDownloadedLength(int downloadedLength)
			{
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x2B90E00", Offset = "0x2B90200", VA = "0x182B90E00", Slot = "4")]
			public void Clear()
			{
			}

			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <DownloadedLength>k__BackingField;

			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private float <ElapsedTime>k__BackingField;
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		private sealed class DownloadTask : TaskBase
		{
			// Token: 0x060003D3 RID: 979 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x2B93670", Offset = "0x2B92A70", VA = "0x182B93670")]
			public DownloadTask()
			{
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000317C File Offset: 0x0000137C
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A2")]
			public DownloadManager.DownloadTaskStatus Status
			{
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0xCC23B0", Offset = "0xCC17B0", VA = "0x180CC23B0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return DownloadManager.DownloadTaskStatus.Wait;
				}
				[Token(Token = "0x60003D5")]
				[Address(RVA = "0x12349A0", Offset = "0x1233DA0", VA = "0x1812349A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				set
				{
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060003D7 RID: 983 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A3")]
			public string CachePath
			{
				[Token(Token = "0x60003D6")]
				[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060003D9 RID: 985 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A4")]
			public string Uri
			{
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0x1047110", Offset = "0x1046510", VA = "0x181047110")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00003194 File Offset: 0x00001394
			// (set) Token: 0x060003DB RID: 987 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A5")]
			public int FlushSize
			{
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0xB99EC0", Offset = "0xB992C0", VA = "0x180B99EC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003DB")]
				[Address(RVA = "0x10646C0", Offset = "0x1063AC0", VA = "0x1810646C0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060003DC RID: 988 RVA: 0x000031AC File Offset: 0x000013AC
			// (set) Token: 0x060003DD RID: 989 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A6")]
			public float TimeOut
			{
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0x161C720", Offset = "0x161BB20", VA = "0x18161C720")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0x1BC8200", Offset = "0x1BC7600", VA = "0x181BC8200")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060003DE RID: 990 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060003DF RID: 991 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000A7")]
			public object UserData
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0xB99CC0", Offset = "0xB990C0", VA = "0x180B99CC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0xB99D40", Offset = "0xB99140", VA = "0x180B99D40")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				private set
				{
				}
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x2B93570", Offset = "0x2B92970", VA = "0x182B93570")]
			public static DownloadManager.DownloadTask Create(string cachePath, string uri, int priority, int flushSize, float timeOut, object userData)
			{
				return null;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x2B93520", Offset = "0x2B92920", VA = "0x182B93520", Slot = "5")]
			public override void Clear()
			{
			}

			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x0")]
			private static int _taskIdCounter;

			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private DownloadManager.DownloadTaskStatus <Status>k__BackingField;

			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private string <CachePath>k__BackingField;

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private string <Uri>k__BackingField;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private int <FlushSize>k__BackingField;

			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private float <TimeOut>k__BackingField;

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private object <UserData>k__BackingField;
		}

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		private enum DownloadTaskStatus : byte
		{
			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			Wait,
			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000F1")]
			Running,
			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x40000F2")]
			Done,
			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			Error
		}
	}
}
