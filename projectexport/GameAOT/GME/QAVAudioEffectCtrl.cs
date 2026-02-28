using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000B5")]
	public class QAVAudioEffectCtrl : ITMGAudioEffectCtrl
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2769F80", Offset = "0x2769380", VA = "0x182769F80")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xAACE0", Offset = "0xAA0E0")]
		private static void s_OnAccompanyComplete(int code, bool isfinished, string filepath)
		{
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060007E5 RID: 2021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000032")]
		public override event QAVAccompanyFileCompleteHandler OnAccompanyFileCompleteHandler
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x2769D00", Offset = "0x2769100", VA = "0x182769D00", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x2769E40", Offset = "0x2769240", VA = "0x182769E40", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2769A00", Offset = "0x2768E00", VA = "0x182769A00", Slot = "8")]
		public override int StartAccompany(string filePath, bool loopBack, int loopCount, int duckerTimeMs)
		{
			return 0;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x2769B60", Offset = "0x2768F60", VA = "0x182769B60", Slot = "9")]
		public override int StopAccompany(int duckerTimeMs)
		{
			return 0;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x2769190", Offset = "0x2768590", VA = "0x182769190", Slot = "10")]
		public override bool IsAccompanyPlayEnd()
		{
			return default(bool);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x27691E0", Offset = "0x27685E0", VA = "0x1827691E0", Slot = "11")]
		public override int PauseAccompany()
		{
			return 0;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x27693C0", Offset = "0x27687C0", VA = "0x1827693C0", Slot = "12")]
		public override int ResumeAccompany()
		{
			return 0;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2768B50", Offset = "0x2767F50", VA = "0x182768B50", Slot = "13")]
		public override int EnableAccompanyPlay(bool enable)
		{
			return 0;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x2768AF0", Offset = "0x2767EF0", VA = "0x182768AF0", Slot = "14")]
		public override int EnableAccompanyLoopBack(bool enable)
		{
			return 0;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2769550", Offset = "0x2768950", VA = "0x182769550", Slot = "15")]
		public override int SetAccompanyKey(int nKey)
		{
			return 0;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x27695A0", Offset = "0x27689A0", VA = "0x1827695A0", Slot = "16")]
		public override int SetAccompanyVolume(int vol)
		{
			return 0;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2768F10", Offset = "0x2768310", VA = "0x182768F10", Slot = "17")]
		public override int GetAccompanyVolume()
		{
			return 0;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2768EC0", Offset = "0x27682C0", VA = "0x182768EC0", Slot = "18")]
		public override uint GetAccompanyFileTotalTimeByMs()
		{
			return 0U;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2768DB0", Offset = "0x27681B0", VA = "0x182768DB0", Slot = "19")]
		public override uint GetAccompanyFileCurrentPlayedTimeByMs()
		{
			return 0U;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2768E60", Offset = "0x2768260", VA = "0x182768E60", Slot = "20")]
		public override uint GetAccompanyFileTotalTimeByMs(string openId)
		{
			return 0U;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2768E00", Offset = "0x2768200", VA = "0x182768E00", Slot = "21")]
		public override uint GetAccompanyFileCurrentPlayedTimeByMs(string openId)
		{
			return 0U;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2769500", Offset = "0x2768900", VA = "0x182769500", Slot = "22")]
		public override int SetAccompanyFileCurrentPlayedTimeByMs(uint timeMs)
		{
			return 0;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2769000", Offset = "0x2768400", VA = "0x182769000", Slot = "23")]
		public override int GetEffectsVolume()
		{
			return 0;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x27696B0", Offset = "0x2768AB0", VA = "0x1827696B0", Slot = "24")]
		public override int SetEffectsVolume(int volume)
		{
			return 0;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2768FB0", Offset = "0x27683B0", VA = "0x182768FB0", Slot = "25")]
		public override int GetEffectVolume(int soundId)
		{
			return 0;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2769650", Offset = "0x2768A50", VA = "0x182769650", Slot = "26")]
		public override int SetEffectVolume(int soundId, int volume)
		{
			return 0;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2769320", Offset = "0x2768720", VA = "0x182769320", Slot = "27")]
		public override int PlayEffect(int soundId, string filePath, bool loop = false, double pitch = 1.0, double pan = 0.0, int volume = 100)
		{
			return 0;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2769280", Offset = "0x2768680", VA = "0x182769280", Slot = "28")]
		public override int PauseEffect(int soundId)
		{
			return 0;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2769230", Offset = "0x2768630", VA = "0x182769230", Slot = "29")]
		public override int PauseAllEffects()
		{
			return 0;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2769460", Offset = "0x2768860", VA = "0x182769460", Slot = "30")]
		public override int ResumeEffect(int soundId)
		{
			return 0;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2769410", Offset = "0x2768810", VA = "0x182769410", Slot = "31")]
		public override int ResumeAllEffects()
		{
			return 0;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2769C00", Offset = "0x2769000", VA = "0x182769C00", Slot = "32")]
		public override int StopEffect(int soundId)
		{
			return 0;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2769BB0", Offset = "0x2768FB0", VA = "0x182769BB0", Slot = "33")]
		public override int StopAllEffects()
		{
			return 0;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2768BB0", Offset = "0x2767FB0", VA = "0x182768BB0", Slot = "34")]
		public override int EnableEffectSend(int soundId, bool enable)
		{
			return 0;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x27695F0", Offset = "0x27689F0", VA = "0x1827695F0", Slot = "35")]
		public override int SetEffectFileCurrentPlayedTimeByMs(int soundId, uint timeMs)
		{
			return 0;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2768F60", Offset = "0x2768360", VA = "0x182768F60", Slot = "36")]
		public override int GetEffectFileCurrentPlayedTimeByMs(int soundId)
		{
			return 0;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2769AC0", Offset = "0x2768EC0", VA = "0x182769AC0", Slot = "37")]
		public override int StartRecord(string filePath, int sampleRate, int channels, bool recordLocalMic, bool recordRemote, bool recordAccompany)
		{
			return 0;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2769C50", Offset = "0x2769050", VA = "0x182769C50", Slot = "38")]
		public override int StopRecord()
		{
			return 0;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x27692D0", Offset = "0x27686D0", VA = "0x1827692D0", Slot = "39")]
		public override int PauseRecord()
		{
			return 0;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x27694B0", Offset = "0x27688B0", VA = "0x1827694B0", Slot = "40")]
		public override int ResumeRecord()
		{
			return 0;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2768C70", Offset = "0x2768070", VA = "0x182768C70", Slot = "41")]
		public override int EnableRecordLocalMic(bool recordLocalMic)
		{
			return 0;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2768C10", Offset = "0x2768010", VA = "0x182768C10", Slot = "42")]
		public override int EnableRecordAccompany(bool recordAccompany)
		{
			return 0;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2768CD0", Offset = "0x27680D0", VA = "0x182768CD0", Slot = "43")]
		public override int EnableRecordRemote(bool recordRemote)
		{
			return 0;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2769130", Offset = "0x2768530", VA = "0x182769130", Slot = "44")]
		public override int InitVoiceChanger(string dataPath)
		{
			return 0;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x276A070", Offset = "0x2769470", VA = "0x18276A070")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xAB5D0", Offset = "0xAA9D0")]
		private static void s_OnFetchVoiceChangerListCallback(int code, string listJson)
		{
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000033")]
		public override event QAVFetchVoiceChangerListCallback OnFetchVoiceChangerListCallback
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x2769DA0", Offset = "0x27691A0", VA = "0x182769DA0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x2769EE0", Offset = "0x27692E0", VA = "0x182769EE0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2768D30", Offset = "0x2768130", VA = "0x182768D30", Slot = "45")]
		public override int FetchVoiceChangerList()
		{
			return 0;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x27698E0", Offset = "0x2768CE0", VA = "0x1827698E0", Slot = "46")]
		public override int SetVoiceChangerName(string voiceName)
		{
			return 0;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x27690B0", Offset = "0x27684B0", VA = "0x1827690B0", Slot = "47")]
		public override string GetVoiceChangerParams()
		{
			return null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2769050", Offset = "0x2768450", VA = "0x182769050", Slot = "48")]
		public override float GetVoiceChangerParamValue(string paramName)
		{
			return 0f;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2769940", Offset = "0x2768D40", VA = "0x182769940", Slot = "49")]
		public override int SetVoiceChangerParamValue(string paramName, float paramValue)
		{
			return 0;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x27699B0", Offset = "0x2768DB0", VA = "0x1827699B0", Slot = "50")]
		public override int SetVoiceType(int voiceType)
		{
			return 0;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2769700", Offset = "0x2768B00", VA = "0x182769700", Slot = "51")]
		public override int SetKaraokeType(int type)
		{
			return 0;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2769750", Offset = "0x2768B50", VA = "0x182769750", Slot = "52")]
		public override int SetKaraokeType(ITMG_VOICE_TYPE_EQUALIZER equalizer, ITMG_VOICE_TYPE_REVERB reverb)
		{
			return 0;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2769CA0", Offset = "0x27690A0", VA = "0x182769CA0")]
		public QAVAudioEffectCtrl()
		{
		}
	}
}
