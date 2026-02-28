using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000B2")]
	public class QAVContext : ITMGContext
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x276C190", Offset = "0x276B590", VA = "0x18276C190")]
		public new static QAVContext GetInstance()
		{
			return null;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x276BEB0", Offset = "0x276B2B0", VA = "0x18276BEB0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x276CAB0", Offset = "0x276BEB0", VA = "0x18276CAB0", Slot = "4")]
		public override int Poll()
		{
			return 0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x276CA60", Offset = "0x276BE60", VA = "0x18276CA60", Slot = "5")]
		public override int Pause()
		{
			return 0;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x276CB00", Offset = "0x276BF00", VA = "0x18276CB00", Slot = "6")]
		public override int Resume()
		{
			return 0;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x276C5A0", Offset = "0x276B9A0", VA = "0x18276C5A0", Slot = "13")]
		public override int Init(string sdkAppID, string openID)
		{
			return 0;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x276D110", Offset = "0x276C510", VA = "0x18276D110", Slot = "14")]
		public override int Uninit()
		{
			return 0;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x276C440", Offset = "0x276B840", VA = "0x18276C440", Slot = "7")]
		public override string GetSDKVersion()
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x276CBC0", Offset = "0x276BFC0", VA = "0x18276CBC0", Slot = "8")]
		public override void SetAppVersion(string sAppVersion)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x276CF00", Offset = "0x276C300", VA = "0x18276CF00", Slot = "9")]
		public override void SetRegion(string region)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x276CC70", Offset = "0x276C070", VA = "0x18276CC70", Slot = "10")]
		public override void SetHost(string chatHost, string pttHost)
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x276CD50", Offset = "0x276C150", VA = "0x18276CD50", Slot = "11")]
		public override int SetLogLevel(int levelWrite, int levelPrint)
		{
			return 0;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x276CDB0", Offset = "0x276C1B0", VA = "0x18276CDB0", Slot = "12")]
		public override int SetLogPath(string logDir)
		{
			return 0;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x276CEB0", Offset = "0x276C2B0", VA = "0x18276CEB0", Slot = "51")]
		public override int SetRecvMixStreamCount(int nCount)
		{
			return 0;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x276CE10", Offset = "0x276C210", VA = "0x18276CE10", Slot = "52")]
		public override int SetRangeAudioMode(ITMGRangeAudioMode gameAudioMode)
		{
			return 0;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x276CC20", Offset = "0x276C020", VA = "0x18276CC20", Slot = "54")]
		public override int SetAudioRole(ITMG_AUDIO_MEMBER_ROLE role)
		{
			return 0;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x276CE60", Offset = "0x276C260", VA = "0x18276CE60", Slot = "53")]
		public override int SetRangeAudioTeamID(int teamID)
		{
			return 0;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x276CA10", Offset = "0x276BE10", VA = "0x18276CA10", Slot = "15")]
		public override bool IsRoomEntered()
		{
			return default(bool);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x276BC00", Offset = "0x276B000", VA = "0x18276BC00", Slot = "55")]
		public override ITMG_CHECK_MIC_STATUS CheckMic()
		{
			return ITMG_CHECK_MIC_STATUS.ITMG_CHECK_MIC_STATUS_MIC_AVAILABLE;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x276BBA0", Offset = "0x276AFA0", VA = "0x18276BBA0", Slot = "31")]
		public override ITMG_RECORD_PERMISSION CheckMicPermission()
		{
			return ITMG_RECORD_PERMISSION.ITMG_PERMISSION_GRANTED;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x276BDD0", Offset = "0x276B1D0", VA = "0x18276BDD0", Slot = "16")]
		public override int EnterRoom(string roomID, ITMGRoomType roomtype, byte[] authBuffer)
		{
			return 0;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x276BE60", Offset = "0x276B260", VA = "0x18276BE60", Slot = "17")]
		public override int ExitRoom()
		{
			return 0;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x276C360", Offset = "0x276B760", VA = "0x18276C360", Slot = "27")]
		public override ITMGRoom GetRoom()
		{
			return null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x276C3D0", Offset = "0x276B7D0", VA = "0x18276C3D0", Slot = "30")]
		public override ITMGRoomManager GetRoomManager()
		{
			return null;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x276BF90", Offset = "0x276B390", VA = "0x18276BF90", Slot = "19")]
		public override string GetAdvanceParams(string KeyCode)
		{
			return null;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x276CF60", Offset = "0x276C360", VA = "0x18276CF60", Slot = "22")]
		public override int StartRealTimeASR()
		{
			return 0;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x276CFB0", Offset = "0x276C3B0", VA = "0x18276CFB0", Slot = "23")]
		public override int StartRealTimeASR(string language)
		{
			return 0;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x276D010", Offset = "0x276C410", VA = "0x18276D010", Slot = "24")]
		public override int StopRealTimeASR()
		{
			return 0;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x276CCE0", Offset = "0x276C0E0", VA = "0x18276CCE0", Slot = "56")]
		public override int SetLicenseForPlugins(string license, string secretKey)
		{
			return 0;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x276C530", Offset = "0x276B930", VA = "0x18276C530", Slot = "57")]
		public override int InitFaceTracker(string license, string secretKey)
		{
			return 0;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x276BC60", Offset = "0x276B060", VA = "0x18276BC60", Slot = "58")]
		public override ITMGFaceTracker CreateFaceTracker(string modelDirPath, string configFileName)
		{
			return null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x276BCD0", Offset = "0x276B0D0", VA = "0x18276BCD0", Slot = "59")]
		public override ITMGPoseTracker CreatePoseTracker(string bodyModelPath, string bodyModelBinPath, string poseModelPath, string poseModelBinPath, string smootherModePath, string smootherModeBinPath)
		{
			return null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x276C4C0", Offset = "0x276B8C0", VA = "0x18276C4C0", Slot = "25")]
		public override int InitAgeDectection(string strBinaryPath, string strParamPath)
		{
			return 0;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x276BD70", Offset = "0x276B170", VA = "0x18276BD70", Slot = "26")]
		public override int EnableAgeDectection(bool bEnable)
		{
			return 0;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x276CB50", Offset = "0x276BF50", VA = "0x18276CB50", Slot = "18")]
		public override int SetAdvanceParams(string KeyCode, string value)
		{
			return 0;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x276D0B0", Offset = "0x276C4B0", VA = "0x18276D0B0", Slot = "20")]
		public override int TrackingVolume(float trackingTimeS)
		{
			return 0;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x276D060", Offset = "0x276C460", VA = "0x18276D060", Slot = "21")]
		public override int StopTrackingVolume()
		{
			return 0;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x276C360", Offset = "0x276B760", VA = "0x18276C360")]
		public QAVRoom GetRoomInner()
		{
			return null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x276C3D0", Offset = "0x276B7D0", VA = "0x18276C3D0")]
		public ITMGRoomManager GetRoomManagerInner()
		{
			return null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x276C0C0", Offset = "0x276B4C0", VA = "0x18276C0C0", Slot = "28")]
		public override ITMGAudioCtrl GetAudioCtrl()
		{
			return null;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x276C010", Offset = "0x276B410", VA = "0x18276C010")]
		public QAVAudioCtrl GetAudioCtrlInner()
		{
			return null;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x276C180", Offset = "0x276B580", VA = "0x18276C180", Slot = "29")]
		public override ITMGAudioEffectCtrl GetAudioEffectCtrl()
		{
			return null;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x276C0D0", Offset = "0x276B4D0", VA = "0x18276C0D0")]
		public QAVAudioEffectCtrl GetAudioEffectCtrlInner()
		{
			return null;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x276C310", Offset = "0x276B710", VA = "0x18276C310", Slot = "32")]
		public override ITMGPTT GetPttCtrl()
		{
			return null;
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000025")]
		public override event QAVEnterRoomComplete OnEnterRoomCompleteEvent
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x276D4A0", Offset = "0x276C8A0", VA = "0x18276D4A0", Slot = "33")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x276DA40", Offset = "0x276CE40", VA = "0x18276DA40", Slot = "34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000779 RID: 1913 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000026")]
		public override event QAVExitRoomComplete OnExitRoomCompleteEvent
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x276D540", Offset = "0x276C940", VA = "0x18276D540", Slot = "35")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x276DAE0", Offset = "0x276CEE0", VA = "0x18276DAE0", Slot = "36")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000027")]
		public override event QAVRoomDisconnect OnRoomDisconnectEvent
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x276D680", Offset = "0x276CA80", VA = "0x18276D680", Slot = "37")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x276DC20", Offset = "0x276D020", VA = "0x18276DC20", Slot = "38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000028")]
		public override event QAVEndpointsUpdateInfo OnEndpointsUpdateInfoEvent
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x276D400", Offset = "0x276C800", VA = "0x18276D400", Slot = "39")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x276D9A0", Offset = "0x276CDA0", VA = "0x18276D9A0", Slot = "40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000029")]
		public override event QAVOnRoomTypeChangedEvent OnRoomTypeChangedEvent
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x276D720", Offset = "0x276CB20", VA = "0x18276D720", Slot = "41")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x276DCC0", Offset = "0x276D0C0", VA = "0x18276DCC0", Slot = "42")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002A")]
		public override event QAVAudioReadyCallback OnAudioReadyEvent
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x276D2C0", Offset = "0x276C6C0", VA = "0x18276D2C0", Slot = "43")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x276D860", Offset = "0x276CC60", VA = "0x18276D860", Slot = "44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002B")]
		public override event QAVRoomChangeQualityCallback OnRoomChangeQualityEvent
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x276D5E0", Offset = "0x276C9E0", VA = "0x18276D5E0", Slot = "45")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x276DB80", Offset = "0x276CF80", VA = "0x18276DB80", Slot = "46")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002C")]
		public override event QAVCommonEventCallback OnCommonEventCallback
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x276D360", Offset = "0x276C760", VA = "0x18276D360", Slot = "47")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x276D900", Offset = "0x276CD00", VA = "0x18276D900", Slot = "48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002D")]
		public override event QAVOnEventCallBack onEventCallBack
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x276D7C0", Offset = "0x276CBC0", VA = "0x18276D7C0", Slot = "49")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x276DD60", Offset = "0x276D160", VA = "0x18276DD60", Slot = "50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x276DED0", Offset = "0x276D2D0", VA = "0x18276DED0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA4E40", Offset = "0xA4240")]
		private static void s_OnAudioReady()
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x276DE00", Offset = "0x276D200", VA = "0x18276DE00")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA5200", Offset = "0xA4600")]
		private static void s_AVRoomChangeQualityCallback(int nQualityEVA, float fLostRate, int nDealy)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x276E040", Offset = "0x276D440", VA = "0x18276E040")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA5610", Offset = "0xA4A10")]
		private static void s_OnEnterRoomComplete(int result, string error_info)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x276E290", Offset = "0x276D690", VA = "0x18276E290")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA5A10", Offset = "0xA4E10")]
		private static void s_OnExitRoomComplete()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x276E370", Offset = "0x276D770", VA = "0x18276E370")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA5D50", Offset = "0xA5150")]
		private static void s_OnRoomDisconnect(int result, string error_info)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x276DF70", Offset = "0x276D370", VA = "0x18276DF70")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA6320", Offset = "0xA5720")]
		private static void s_OnEndpointsUpdateInfo(int eventID, int count, string[] openIdList)
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA6720", Offset = "0xA5B20")]
		private static void s_OnDeviceStateChangedEvent(int deviceType, string deviceId, bool openOrClose)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x276E870", Offset = "0x276DC70", VA = "0x18276E870")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA6B50", Offset = "0xA5F50")]
		private static void s_QAVOnRoomTypeChangedEvent(int roomtype)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x276E600", Offset = "0x276DA00", VA = "0x18276E600")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA7040", Offset = "0xA6440")]
		private static void s_QAVOnEventCallBack(int type, int subType, string data)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x276E470", Offset = "0x276D870", VA = "0x18276E470")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA7440", Offset = "0xA6840")]
		private static void s_QAVCommonEventCallback(int type, int param0, int param1)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x276D240", Offset = "0x276C640", VA = "0x18276D240")]
		private QAVContext()
		{
		}

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x0")]
		public static string ENGINE_VERSION;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x58")]
		private QAVRoom mAVRoom;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x60")]
		private QAVAudioCtrl mAVAudioCtrl;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x68")]
		private QAVAudioEffectCtrl mAVAudioEffectCtrl;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x70")]
		private QAVRoomManager mAVRoomManager;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x8")]
		private static QAVContext sInstance;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object sLock;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x78")]
		private string mSdkAppID;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x80")]
		public string mOpenID;
	}
}
