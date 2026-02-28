using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x2000083")]
	public abstract class ITMGRoom
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000515 RID: 1301
		// (remove) Token: 0x06000516 RID: 1302
		[Token(Token = "0x14000013")]
		public abstract event QAVCustomStreamDataCallback OnCustomStreamDataComplete;

		// Token: 0x06000517 RID: 1303
		[Token(Token = "0x600043D")]
		public abstract string GetQualityTips();

		// Token: 0x06000518 RID: 1304
		[Token(Token = "0x600043E")]
		public abstract int ChangeRoomType(ITMGRoomType roomType);

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000519 RID: 1305
		// (remove) Token: 0x0600051A RID: 1306
		[Token(Token = "0x14000014")]
		public abstract event QAVCallback OnChangeRoomtypeCallback;

		// Token: 0x0600051B RID: 1307
		[Token(Token = "0x6000441")]
		public abstract int GetRoomType();

		// Token: 0x0600051C RID: 1308
		[Token(Token = "0x6000442")]
		public abstract string GetRoomID();

		// Token: 0x0600051D RID: 1309
		[Token(Token = "0x6000443")]
		public abstract int UpdateAudioRecvRange(int range);

		// Token: 0x0600051E RID: 1310
		[Token(Token = "0x6000444")]
		public abstract int UpdateSpatializerRecvRange(int range);

		// Token: 0x0600051F RID: 1311
		[Token(Token = "0x6000445")]
		public abstract int UpdateSelfPosition(int[] position, float[] axisForward, float[] axisRight, float[] axisUp);

		// Token: 0x06000520 RID: 1312
		[Token(Token = "0x6000446")]
		public abstract int UpdateOtherPosition(string openID, int[] position);

		// Token: 0x06000521 RID: 1313
		[Token(Token = "0x6000447")]
		public abstract int StartRoomSharing(string targetRoomID, string targetOpenID, byte[] authBuffer);

		// Token: 0x06000522 RID: 1314
		[Token(Token = "0x6000448")]
		public abstract int StopRoomSharing();

		// Token: 0x06000523 RID: 1315
		[Token(Token = "0x6000449")]
		public abstract int SwitchRoom(string roomID, byte[] authBuffer);

		// Token: 0x06000524 RID: 1316
		[Token(Token = "0x600044A")]
		public abstract int SendCustomData(byte[] customdata, int repeatCout);

		// Token: 0x06000525 RID: 1317
		[Token(Token = "0x600044B")]
		public abstract int StopSendCustomData();

		// Token: 0x06000526 RID: 1318
		[Token(Token = "0x600044C")]
		public abstract int SetServerAudioRouteSendOperateType(ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE Sendtype, string[] OpenIDforSend, ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE Recvtype, string[] OpenIDforRecv);

		// Token: 0x06000527 RID: 1319
		[Token(Token = "0x600044D")]
		public abstract ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE GetCurrentSendAudioRoute(List<string> OpenIDforSend);

		// Token: 0x06000528 RID: 1320
		[Token(Token = "0x600044E")]
		public abstract ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE GetCurrentRecvAudioRoute(List<string> OpenIDforRecve);

		// Token: 0x06000529 RID: 1321
		[Token(Token = "0x600044F")]
		public abstract int SendCustomStreamData(byte[] customStreamData);

		// Token: 0x0600052A RID: 1322
		[Token(Token = "0x6000450")]
		public abstract int SetCustomStreamDataCallback(IntPtr userData);

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected ITMGRoom()
		{
		}
	}
}
