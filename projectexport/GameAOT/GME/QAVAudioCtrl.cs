using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000B4")]
	public class QAVAudioCtrl : ITMGAudioCtrl
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2765EB0", Offset = "0x27652B0", VA = "0x182765EB0", Slot = "52")]
		public override int EnableMixSystemAudioToSend(bool enable)
		{
			return 0;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2765B30", Offset = "0x2764F30", VA = "0x182765B30", Slot = "9")]
		public override int EnableAudioCaptureDevice(bool enabled)
		{
			return 0;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2765BF0", Offset = "0x2764FF0", VA = "0x182765BF0", Slot = "10")]
		public override int EnableAudioPlayDevice(bool enabled)
		{
			return 0;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2766A10", Offset = "0x2765E10", VA = "0x182766A10", Slot = "11")]
		public override bool IsAudioCaptureDeviceEnabled()
		{
			return default(bool);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2766A60", Offset = "0x2765E60", VA = "0x182766A60", Slot = "12")]
		public override bool IsAudioPlayDeviceEnabled()
		{
			return default(bool);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x2765CB0", Offset = "0x27650B0", VA = "0x182765CB0", Slot = "13")]
		public override int EnableAudioSend(bool isEnabled)
		{
			return 0;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x2765C50", Offset = "0x2765050", VA = "0x182765C50", Slot = "14")]
		public override int EnableAudioRecv(bool isEnabled)
		{
			return 0;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x2766B00", Offset = "0x2765F00", VA = "0x182766B00", Slot = "15")]
		public override bool IsAudioSendEnabled()
		{
			return default(bool);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x2766AB0", Offset = "0x2765EB0", VA = "0x182766AB0", Slot = "16")]
		public override bool IsAudioRecvEnabled()
		{
			return default(bool);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2765A50", Offset = "0x2764E50", VA = "0x182765A50", Slot = "8")]
		public override int CheckDeviceMuteState()
		{
			return 0;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x2765D70", Offset = "0x2765170", VA = "0x182765D70", Slot = "4")]
		public override int EnableMic(bool isEnabled)
		{
			return 0;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x27663E0", Offset = "0x27657E0", VA = "0x1827663E0", Slot = "5")]
		public override int GetMicState()
		{
			return 0;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2765F80", Offset = "0x2765380", VA = "0x182765F80", Slot = "6")]
		public override int EnableSpeaker(bool isEnabled)
		{
			return 0;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2766850", Offset = "0x2765C50", VA = "0x182766850", Slot = "7")]
		public override int GetSpeakerState()
		{
			return 0;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x27660C0", Offset = "0x27654C0", VA = "0x1827660C0", Slot = "17")]
		public override int GetMicLevel()
		{
			return 0;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x2766E30", Offset = "0x2766230", VA = "0x182766E30", Slot = "18")]
		public override int SetMicVolume(int volume)
		{
			return 0;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2766430", Offset = "0x2765830", VA = "0x182766430", Slot = "19")]
		public override int GetMicVolume()
		{
			return 0;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2766530", Offset = "0x2765930", VA = "0x182766530", Slot = "20")]
		public override int GetSpeakerLevel()
		{
			return 0;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2766EE0", Offset = "0x27662E0", VA = "0x182766EE0", Slot = "21")]
		public override int SetSpeakerVolume(int volume)
		{
			return 0;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2766900", Offset = "0x2765D00", VA = "0x182766900", Slot = "22")]
		public override int GetSpeakerVolume()
		{
			return 0;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2766E80", Offset = "0x2766280", VA = "0x182766E80", Slot = "23")]
		public override int SetSpeakerVolumeByOpenID(string openid, int volume)
		{
			return 0;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x27668A0", Offset = "0x2765CA0", VA = "0x1827668A0", Slot = "24")]
		public override int GetSpeakerVolumeByOpenID(string openid)
		{
			return 0;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2766950", Offset = "0x2765D50", VA = "0x182766950", Slot = "25")]
		public override int GetVolumeById(string openid)
		{
			return 0;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2765D10", Offset = "0x2765110", VA = "0x182765D10", Slot = "26")]
		public override int EnableLoopBack(bool enable)
		{
			return 0;
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000030")]
		public override event QAVAudioRouteChangeCallback OnAudioRouteChangeComplete
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x2766F90", Offset = "0x2766390", VA = "0x182766F90", Slot = "27")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x27670D0", Offset = "0x27664D0", VA = "0x1827670D0", Slot = "28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2767210", Offset = "0x2766610", VA = "0x182767210")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA97F0", Offset = "0xA8BF0")]
		public static void s_OnAudioRouteChangeComplete(int code)
		{
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000031")]
		public override event QAVAudioIOSMuteSwitchResultCallback OnIOSMuteSwitchResult
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x2767030", Offset = "0x2766430", VA = "0x182767030", Slot = "29")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x2767170", Offset = "0x2766570", VA = "0x182767170", Slot = "30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x27672D0", Offset = "0x27666D0", VA = "0x1827672D0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xAA1D0", Offset = "0xA95D0")]
		public static void s_OnIOSMuteSwitchResult(bool muteSwitchIsOn)
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2765930", Offset = "0x2764D30", VA = "0x182765930", Slot = "31")]
		public override int AddAudioBlackList(string openId)
		{
			return 0;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2766C00", Offset = "0x2766000", VA = "0x182766C00", Slot = "32")]
		public override int RemoveAudioBlackList(string openId)
		{
			return 0;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2766BA0", Offset = "0x2765FA0", VA = "0x182766BA0", Slot = "33")]
		public override bool IsOpenIdInAudioBlackList(string openId)
		{
			return default(bool);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x27664E0", Offset = "0x27658E0", VA = "0x1827664E0", Slot = "34")]
		public override int GetSendStreamLevel()
		{
			return 0;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2766480", Offset = "0x2765880", VA = "0x182766480", Slot = "35")]
		public override int GetRecvStreamLevel(string openId)
		{
			return 0;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x27669B0", Offset = "0x2765DB0", VA = "0x1827669B0", Slot = "36")]
		public override int InitSpatializer(string modelPath)
		{
			return 0;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2765F10", Offset = "0x2765310", VA = "0x182765F10", Slot = "37")]
		public override int EnableSpatializer(bool enable, bool applyTeam)
		{
			return 0;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2766B50", Offset = "0x2765F50", VA = "0x182766B50", Slot = "38")]
		public override bool IsEnableSpatializer()
		{
			return default(bool);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2766DE0", Offset = "0x27661E0", VA = "0x182766DE0", Slot = "39")]
		public override int SetAudioMixCount(int nCount)
		{
			return 0;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2765990", Offset = "0x2764D90", VA = "0x182765990", Slot = "40")]
		public override int AddSameTeamSpatializer(string openId)
		{
			return 0;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2766C60", Offset = "0x2766060", VA = "0x182766C60", Slot = "41")]
		public override int RemoveSameTeamSpatializer(string openId)
		{
			return 0;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x27659F0", Offset = "0x2764DF0", VA = "0x1827659F0", Slot = "42")]
		public override int AddSpatializerBlacklist(string openId)
		{
			return 0;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2766CC0", Offset = "0x27660C0", VA = "0x182766CC0", Slot = "43")]
		public override int RemoveSpatializerBlacklist(string openId)
		{
			return 0;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2765AE0", Offset = "0x2764EE0", VA = "0x182765AE0", Slot = "44")]
		public override int ClearSpatializerBlacklist()
		{
			return 0;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2765B90", Offset = "0x2764F90", VA = "0x182765B90", Slot = "45")]
		public override int EnableAudioDispatcher(bool enable)
		{
			return 0;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x2766110", Offset = "0x2765510", VA = "0x182766110", Slot = "46")]
		public override int GetMicListCount()
		{
			return 0;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x2766160", Offset = "0x2765560", VA = "0x182766160", Slot = "47")]
		public override int GetMicList(out List<TMGAudioDeviceInfo> devicesInfo, int count)
		{
			return 0;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2766D20", Offset = "0x2766120", VA = "0x182766D20", Slot = "48")]
		public override int SelectMic(string micID)
		{
			return 0;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2766580", Offset = "0x2765980", VA = "0x182766580", Slot = "49")]
		public override int GetSpeakerListCount()
		{
			return 0;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x27665D0", Offset = "0x27659D0", VA = "0x1827665D0", Slot = "50")]
		public override int GetSpeakerList(out List<TMGAudioDeviceInfo> devicesInfo, int count)
		{
			return 0;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2766D80", Offset = "0x2766180", VA = "0x182766D80", Slot = "51")]
		public override int SelectSpeaker(string speaker)
		{
			return 0;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2766F30", Offset = "0x2766330", VA = "0x182766F30")]
		public QAVAudioCtrl()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x14C58E0", Offset = "0x14C4CE0", VA = "0x1814C58E0", Slot = "1")]
		protected override void Finalize()
		{
		}
	}
}
