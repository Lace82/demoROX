using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000B3")]
	public class QAVRoom : ITMGRoom
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2E79A00", Offset = "0x2E78E00", VA = "0x182E79A00", Slot = "6")]
		public override string GetQualityTips()
		{
			return null;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2E7A9A0", Offset = "0x2E79DA0", VA = "0x182E7A9A0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA7C90", Offset = "0xA7090")]
		private static void s_ChangeRoomtypeCallback(int result, string error_info)
		{
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000798 RID: 1944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002E")]
		public override event QAVCallback OnChangeRoomtypeCallback
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x2E7A720", Offset = "0x2E79B20", VA = "0x182E7A720", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x2E7A860", Offset = "0x2E79C60", VA = "0x182E7A860", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2E79530", Offset = "0x2E78930", VA = "0x182E79530", Slot = "7")]
		public override int ChangeRoomType(ITMGRoomType roomType)
		{
			return 0;
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002F")]
		public override event QAVCustomStreamDataCallback OnCustomStreamDataComplete
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x2E7A7C0", Offset = "0x2E79BC0", VA = "0x182E7A7C0", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x2E7A900", Offset = "0x2E79D00", VA = "0x182E7A900", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2E7AC70", Offset = "0x2E7A070", VA = "0x182E7AC70")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA8AE0", Offset = "0xA7EE0")]
		private static void s_OnCustomStreamDataCallback(IntPtr frame, IntPtr userData)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2E79AD0", Offset = "0x2E78ED0", VA = "0x182E79AD0", Slot = "11")]
		public override string GetRoomID()
		{
			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2E79BA0", Offset = "0x2E78FA0", VA = "0x182E79BA0", Slot = "10")]
		public override int GetRoomType()
		{
			return 0;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2E7A3C0", Offset = "0x2E797C0", VA = "0x182E7A3C0", Slot = "12")]
		public override int UpdateAudioRecvRange(int range)
		{
			return 0;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2E7A670", Offset = "0x2E79A70", VA = "0x182E7A670", Slot = "13")]
		public override int UpdateSpatializerRecvRange(int range)
		{
			return 0;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2E7A560", Offset = "0x2E79960", VA = "0x182E7A560", Slot = "14")]
		public override int UpdateSelfPosition(int[] position, float[] axisForward, float[] axisRight, float[] axisUp)
		{
			return 0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2E7A470", Offset = "0x2E79870", VA = "0x182E7A470", Slot = "15")]
		public override int UpdateOtherPosition(string openID, int[] position)
		{
			return 0;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2E7A050", Offset = "0x2E79450", VA = "0x182E7A050", Slot = "16")]
		public override int StartRoomSharing(string targetRoomID, string targetOpenID, byte[] authBuffer)
		{
			return 0;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2E7A160", Offset = "0x2E79560", VA = "0x182E7A160", Slot = "17")]
		public override int StopRoomSharing()
		{
			return 0;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2E7A2C0", Offset = "0x2E796C0", VA = "0x182E7A2C0", Slot = "18")]
		public override int SwitchRoom(string roomID, byte[] authBuffer)
		{
			return 0;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2E79C60", Offset = "0x2E79060", VA = "0x182E79C60", Slot = "19")]
		public override int SendCustomData(byte[] customdata, int repeatCout)
		{
			return 0;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x2E7A210", Offset = "0x2E79610", VA = "0x182E7A210", Slot = "20")]
		public override int StopSendCustomData()
		{
			return 0;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x2E79D40", Offset = "0x2E79140", VA = "0x182E79D40", Slot = "24")]
		public override int SendCustomStreamData(byte[] customStreamData)
		{
			return 0;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x2E79EA0", Offset = "0x2E792A0", VA = "0x182E79EA0", Slot = "25")]
		public override int SetCustomStreamDataCallback(IntPtr userData)
		{
			return 0;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x2E79F90", Offset = "0x2E79390", VA = "0x182E79F90", Slot = "21")]
		public override int SetServerAudioRouteSendOperateType(ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE Sendtype, string[] OpenIDforSend, ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE Recvtype, string[] OpenIDforRecv)
		{
			return 0;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2E79810", Offset = "0x2E78C10", VA = "0x182E79810", Slot = "22")]
		public override ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE GetCurrentSendAudioRoute(List<string> OpenIDforSend)
		{
			return ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE.AUDIO_ROUTE_SEND_INQUIRE_ERROR;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2E79620", Offset = "0x2E78A20", VA = "0x182E79620", Slot = "23")]
		public override ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE GetCurrentRecvAudioRoute(List<string> OpenIDforRecve)
		{
			return ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE.AUDIO_ROUTE_RECV_INQUIRE_ERROR;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xB9A0F0", Offset = "0xB994F0", VA = "0x180B9A0F0")]
		public QAVRoom()
		{
		}
	}
}
