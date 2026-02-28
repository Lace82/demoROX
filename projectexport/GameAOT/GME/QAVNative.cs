using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x200008C")]
	public class QAVNative
	{
		// Token: 0x060005E6 RID: 1510
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2E742E0", Offset = "0x2E736E0", VA = "0x182E742E0")]
		[PreserveSig]
		public static extern int QAVSDK_Poll();

		// Token: 0x060005E7 RID: 1511
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2E73260", Offset = "0x2E72660", VA = "0x182E73260")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_GetSDKVersion();

		// Token: 0x060005E8 RID: 1512
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2E74A00", Offset = "0x2E73E00", VA = "0x182E74A00")]
		[PreserveSig]
		public static extern void QAVSDK_SetAppVersion(string sAppVersion);

		// Token: 0x060005E9 RID: 1513
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2E70A10", Offset = "0x2E6FE10", VA = "0x182E70A10")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_CheckMicPermission();

		// Token: 0x060005EA RID: 1514
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2E71520", Offset = "0x2E70920", VA = "0x182E71520")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetLogLevel(int levelWrite, int levelPrint);

		// Token: 0x060005EB RID: 1515
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2E715B0", Offset = "0x2E709B0", VA = "0x182E715B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetLogPath(string logDir);

		// Token: 0x060005EC RID: 1516
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2E70F40", Offset = "0x2E70340", VA = "0x182E70F40")]
		[PreserveSig]
		public static extern bool QAVSDK_AVContext_IsContextStarted();

		// Token: 0x060005ED RID: 1517
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2E717D0", Offset = "0x2E70BD0", VA = "0x182E717D0")]
		[PreserveSig]
		public static extern void QAVSDK_AVContext_SetRegion(string region);

		// Token: 0x060005EE RID: 1518
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2E713B0", Offset = "0x2E707B0", VA = "0x182E713B0")]
		[PreserveSig]
		public static extern void QAVSDK_AVContext_SetHost(string chatHost, string pttHost);

		// Token: 0x060005EF RID: 1519
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2E71900", Offset = "0x2E70D00", VA = "0x182E71900")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_Start(string sdk_version, string sdkAppId, string openId);

		// Token: 0x060005F0 RID: 1520
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x2E71AC0", Offset = "0x2E70EC0", VA = "0x182E71AC0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_Stop();

		// Token: 0x060005F1 RID: 1521
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2E70AF0", Offset = "0x2E6FEF0", VA = "0x182E70AF0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_Destroy();

		// Token: 0x060005F2 RID: 1522
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2E70A80", Offset = "0x2E6FE80", VA = "0x182E70A80")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_CheckMic();

		// Token: 0x060005F3 RID: 1523
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2E70FB0", Offset = "0x2E703B0", VA = "0x182E70FB0")]
		[PreserveSig]
		public static extern bool QAVSDK_AVContext_IsRoomEntered();

		// Token: 0x060005F4 RID: 1524
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2E71240", Offset = "0x2E70640", VA = "0x182E71240")]
		[PreserveSig]
		public static extern bool QAVSDK_AVContext_SetDelegate(QAVEnterRoomComplete enterRoomComplete, QAVExitRoomComplete exitRoomComplete, QAVRoomDisconnect roomDisconnect, QAVEndpointsUpdateInfo endpointsUpdateInfo, QAVOnRoomTypeChangedEvent onRoomtypeChangeEvent, QAVOnDeviceStateChangedEvent onDeviceStateChangedEvent, QAVAudioReadyCallback audioReadyCallback, QAVRoomChangeQualityCallback onRoomChangeQualityEvent, QAVCommonEventCallback commonEventCallback, QAVOnEventCallBack onEventCallback);

		// Token: 0x060005F5 RID: 1525
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2E70BE0", Offset = "0x2E6FFE0", VA = "0x182E70BE0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_EnterRoom(string roomID, byte[] authBuffer, int authBufferLen, int roomtype);

		// Token: 0x060005F6 RID: 1526
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2E70CB0", Offset = "0x2E700B0", VA = "0x182E70CB0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_ExitRoom();

		// Token: 0x060005F7 RID: 1527
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2E71750", Offset = "0x2E70B50", VA = "0x182E71750")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetRecvMixStreamCount(int nMixCount);

		// Token: 0x060005F8 RID: 1528
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2E71090", Offset = "0x2E70490", VA = "0x182E71090")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_Resume();

		// Token: 0x060005F9 RID: 1529
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2E71020", Offset = "0x2E70420", VA = "0x182E71020")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_Pause();

		// Token: 0x060005FA RID: 1530
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2E71100", Offset = "0x2E70500", VA = "0x182E71100")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetAdvanceParams(string KeyCode, string value);

		// Token: 0x060005FB RID: 1531
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2E71B30", Offset = "0x2E70F30", VA = "0x182E71B30")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_TrackingVolume(float trackingTimeS);

		// Token: 0x060005FC RID: 1532
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2E71A50", Offset = "0x2E70E50", VA = "0x182E71A50")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_StopTrackingVolume();

		// Token: 0x060005FD RID: 1533
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2E71860", Offset = "0x2E70C60", VA = "0x182E71860")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_StartRealTimeASR(string language);

		// Token: 0x060005FE RID: 1534
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2E719E0", Offset = "0x2E70DE0", VA = "0x182E719E0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_StopRealTimeASR();

		// Token: 0x060005FF RID: 1535
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2E71460", Offset = "0x2E70860", VA = "0x182E71460")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetLicenseForPlugins(string license, string secretKey);

		// Token: 0x06000600 RID: 1536
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2E70E80", Offset = "0x2E70280", VA = "0x182E70E80")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_InitFaceTracker(string license, string secretKey);

		// Token: 0x06000601 RID: 1537
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2E70DC0", Offset = "0x2E701C0", VA = "0x182E70DC0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_InitAgeDectection(string strBinaryPath, string strParamPath);

		// Token: 0x06000602 RID: 1538
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2E70B60", Offset = "0x2E6FF60", VA = "0x182E70B60")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_EnableAgeDectection(bool enabled);

		// Token: 0x06000603 RID: 1539
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2E6D830", Offset = "0x2E6CC30", VA = "0x182E6D830")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableMixSystemAudioToSend(bool enabled);

		// Token: 0x06000604 RID: 1540
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2E70D20", Offset = "0x2E70120", VA = "0x182E70D20")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_AVContext_GetAdvanceParams(string KeyCode);

		// Token: 0x06000605 RID: 1541
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2E723B0", Offset = "0x2E717B0", VA = "0x182E723B0")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_AVRoom_GetQualityTips();

		// Token: 0x06000606 RID: 1542
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2E721C0", Offset = "0x2E715C0", VA = "0x182E721C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_ChangeRoomType(int roomtype, QAVCallback callback);

		// Token: 0x06000607 RID: 1543
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2E72490", Offset = "0x2E71890", VA = "0x182E72490")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_GetRoomType();

		// Token: 0x06000608 RID: 1544
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2E72420", Offset = "0x2E71820", VA = "0x182E72420")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_AVRoom_GetRoomID();

		// Token: 0x06000609 RID: 1545
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2E71650", Offset = "0x2E70A50", VA = "0x182E71650")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetRangeAudioMode(int audioMode);

		// Token: 0x0600060A RID: 1546
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2E716D0", Offset = "0x2E70AD0", VA = "0x182E716D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetRangeAudioTeamID(int teamID);

		// Token: 0x0600060B RID: 1547
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2E711C0", Offset = "0x2E705C0", VA = "0x182E711C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVContext_SetAudioRole(int role);

		// Token: 0x0600060C RID: 1548
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2E72B70", Offset = "0x2E71F70", VA = "0x182E72B70")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_UpdateAudioRecvRange(int range);

		// Token: 0x0600060D RID: 1549
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2E72D90", Offset = "0x2E72190", VA = "0x182E72D90")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_UpdateSpatializerRecvRange(int range);

		// Token: 0x0600060E RID: 1550
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2E72CB0", Offset = "0x2E720B0", VA = "0x182E72CB0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_UpdateSelfPosition(int[] position, float[] axisForward, float[] axisRight, float[] axisUp, int len);

		// Token: 0x0600060F RID: 1551
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2E72BF0", Offset = "0x2E71FF0", VA = "0x182E72BF0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_UpdateOtherPosition(string openID, int[] position, int len);

		// Token: 0x06000610 RID: 1552
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2E728F0", Offset = "0x2E71CF0", VA = "0x182E728F0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_StartRoomSharing(string targetRoomID, string targetOpenID, byte[] authBuffer, int authBufferLen);

		// Token: 0x06000611 RID: 1553
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2E729D0", Offset = "0x2E71DD0", VA = "0x182E729D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_StopRoomSharing();

		// Token: 0x06000612 RID: 1554
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2E72AB0", Offset = "0x2E71EB0", VA = "0x182E72AB0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_SwitchRoom(string roomID, byte[] authBuffer, int authBufferLen);

		// Token: 0x06000613 RID: 1555
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2E72500", Offset = "0x2E71900", VA = "0x182E72500")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_SendCustomData(byte[] customdata, int dataSize, int repeatCout);

		// Token: 0x06000614 RID: 1556
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2E72A40", Offset = "0x2E71E40", VA = "0x182E72A40")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_StopSendCustomData();

		// Token: 0x06000615 RID: 1557
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2E725A0", Offset = "0x2E719A0", VA = "0x182E725A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_SendCustomStreamData(IntPtr customStreamData, int length);

		// Token: 0x06000616 RID: 1558
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2E72630", Offset = "0x2E71A30", VA = "0x182E72630")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_SetCustomStreamDataCallback(QAVCustomStreamDataCallbackInner callback, IntPtr userData);

		// Token: 0x06000617 RID: 1559
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2E726D0", Offset = "0x2E71AD0", VA = "0x182E726D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoom_SetServerAudioRoute(ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE SendType, string[] OpenIDforSend, int OpenIDforSendSize, ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE RecvType, string[] OpenIDforRecv, int OpenIDforRecvSize);

		// Token: 0x06000618 RID: 1560
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2E72300", Offset = "0x2E71700", VA = "0x182E72300")]
		[PreserveSig]
		public static extern ITMG_SERVER_AUDIO_ROUTE_SEND_TYPE QAVSDK_AVRoom_GetCurrentSendAudioRoute(StringBuilder OpenIDforSend, int OpenIDforSendSize);

		// Token: 0x06000619 RID: 1561
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2E72250", Offset = "0x2E71650", VA = "0x182E72250")]
		[PreserveSig]
		public static extern ITMG_SERVER_AUDIO_ROUTE_RECV_TYPE QAVSDK_AVRoom_GetCurrentRecvAudioRoute(StringBuilder OpenIDforRecve, int OpenIDforRecveSize);

		// Token: 0x0600061A RID: 1562
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2E6D4A0", Offset = "0x2E6C8A0", VA = "0x182E6D4A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAudioCaptureDevice(bool enabled);

		// Token: 0x0600061B RID: 1563
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2E6D5A0", Offset = "0x2E6C9A0", VA = "0x182E6D5A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAudioPlayDevice(bool enabled);

		// Token: 0x0600061C RID: 1564
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2E6EA40", Offset = "0x2E6DE40", VA = "0x182E6EA40")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_IsAudioCaptureDeviceEnabled();

		// Token: 0x0600061D RID: 1565
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2E6EAB0", Offset = "0x2E6DEB0", VA = "0x182E6EAB0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_IsAudioPlayDeviceEnabled();

		// Token: 0x0600061E RID: 1566
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2E6D6A0", Offset = "0x2E6CAA0", VA = "0x182E6D6A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAudioSend(bool enabled);

		// Token: 0x0600061F RID: 1567
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2E6D620", Offset = "0x2E6CA20", VA = "0x182E6D620")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAudioRecv(bool enabled);

		// Token: 0x06000620 RID: 1568
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2E6EB90", Offset = "0x2E6DF90", VA = "0x182E6EB90")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_IsAudioSendEnabled();

		// Token: 0x06000621 RID: 1569
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2E6EB20", Offset = "0x2E6DF20", VA = "0x182E6EB20")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_IsAudioRecvEnabled();

		// Token: 0x06000622 RID: 1570
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2E6DFC0", Offset = "0x2E6D3C0", VA = "0x182E6DFC0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetMicLevel();

		// Token: 0x06000623 RID: 1571
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2E6FE00", Offset = "0x2E6F200", VA = "0x182E6FE00")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetMicVolume(int volume);

		// Token: 0x06000624 RID: 1572
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2E6E160", Offset = "0x2E6D560", VA = "0x182E6E160")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetMicVolume();

		// Token: 0x06000625 RID: 1573
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2E6E430", Offset = "0x2E6D830", VA = "0x182E6E430")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetSpeakerLevel();

		// Token: 0x06000626 RID: 1574
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2E70140", Offset = "0x2E6F540", VA = "0x182E70140")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetSpeakerVolume(int volume);

		// Token: 0x06000627 RID: 1575
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x2E6E670", Offset = "0x2E6DA70", VA = "0x182E6E670")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetSpeakerVolume();

		// Token: 0x06000628 RID: 1576
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2E700A0", Offset = "0x2E6F4A0", VA = "0x182E700A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetSpeakerVolumeByOpenID(string openId, int volume);

		// Token: 0x06000629 RID: 1577
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2E6E5D0", Offset = "0x2E6D9D0", VA = "0x182E6E5D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetSpeakerVolumeByOpenID(string openId);

		// Token: 0x0600062A RID: 1578
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x2E6E7F0", Offset = "0x2E6DBF0", VA = "0x182E6E7F0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetVolumeByUin(string openId);

		// Token: 0x0600062B RID: 1579
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2E6D7B0", Offset = "0x2E6CBB0", VA = "0x182E6D7B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableLoopBack(bool enabled);

		// Token: 0x0600062C RID: 1580
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2E6FAC0", Offset = "0x2E6EEC0", VA = "0x182E6FAC0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAudioRouteChangeCallback(QAVAudioRouteChangeCallback callback);

		// Token: 0x0600062D RID: 1581
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2E6D230", Offset = "0x2E6C630", VA = "0x182E6D230")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_CheckDeviceMuteState(QAVAudioIOSMuteSwitchResultCallback callback);

		// Token: 0x0600062E RID: 1582
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2E70310", Offset = "0x2E6F710", VA = "0x182E70310")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetVoiceType(int voiceType);

		// Token: 0x0600062F RID: 1583
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2E6FD80", Offset = "0x2E6F180", VA = "0x182E6FD80")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetKaraokeType(int type);

		// Token: 0x06000630 RID: 1584
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2E6FCF0", Offset = "0x2E6F0F0", VA = "0x182E6FCF0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetKaraokeTypeAdv(IntPtr equalizer, IntPtr reverb);

		// Token: 0x06000631 RID: 1585
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2E6CF60", Offset = "0x2E6C360", VA = "0x182E6CF60")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_AddAudioBlackList(string openId);

		// Token: 0x06000632 RID: 1586
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2E6F1C0", Offset = "0x2E6E5C0", VA = "0x182E6F1C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_RemoveAudioBlackList(string openId);

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2E6EC70", Offset = "0x2E6E070", VA = "0x182E6EC70")]
		[PreserveSig]
		public static extern bool QAVSDK_AVAudioCtrl_IsOpenIdInAudioBlackList(string openId);

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2E6E3C0", Offset = "0x2E6D7C0", VA = "0x182E6E3C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetSendStreamLevel();

		// Token: 0x06000635 RID: 1589
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2E6E320", Offset = "0x2E6D720", VA = "0x182E6E320")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetRecvStreamLevel(string openId);

		// Token: 0x06000636 RID: 1590
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2E6E890", Offset = "0x2E6DC90", VA = "0x182E6E890")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_InitSpatializer(string modelPath);

		// Token: 0x06000637 RID: 1591
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2E6DA30", Offset = "0x2E6CE30", VA = "0x182E6DA30")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableSpatializer(bool enabled, bool applyTeam);

		// Token: 0x06000638 RID: 1592
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2E6EC00", Offset = "0x2E6E000", VA = "0x182E6EC00")]
		[PreserveSig]
		public static extern bool QAVSDK_AVAudioCtrl_IsEnableSpatializer();

		// Token: 0x06000639 RID: 1593
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2E6FA40", Offset = "0x2E6EE40", VA = "0x182E6FA40")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAudioMixCount(int nCount);

		// Token: 0x0600063A RID: 1594
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2E6D000", Offset = "0x2E6C400", VA = "0x182E6D000")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_AddSameTeamSpatializer(string openid);

		// Token: 0x0600063B RID: 1595
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2E6F260", Offset = "0x2E6E660", VA = "0x182E6F260")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_RemoveSameTeamSpatializer(string openid);

		// Token: 0x0600063C RID: 1596
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2E6D0A0", Offset = "0x2E6C4A0", VA = "0x182E6D0A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_AddSpatializerBlacklist(string openid);

		// Token: 0x0600063D RID: 1597
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2E6F300", Offset = "0x2E6E700", VA = "0x182E6F300")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_RemoveSpatializerBlacklist(string openid);

		// Token: 0x0600063E RID: 1598
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2E6D330", Offset = "0x2E6C730", VA = "0x182E6D330")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ClearSpatializerBlacklist();

		// Token: 0x0600063F RID: 1599
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2E6D520", Offset = "0x2E6C920", VA = "0x182E6D520")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAudioDispatcher(bool enabled);

		// Token: 0x06000640 RID: 1600
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2E704F0", Offset = "0x2E6F8F0", VA = "0x182E704F0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StartRecord(string filePath, int sampleRate, int channels, bool recordLocalMic, bool recordRemote, bool recordAccompany);

		// Token: 0x06000641 RID: 1601
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2E708B0", Offset = "0x2E6FCB0", VA = "0x182E708B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StopRecord();

		// Token: 0x06000642 RID: 1602
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2E6EF70", Offset = "0x2E6E370", VA = "0x182E6EF70")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PauseRecord();

		// Token: 0x06000643 RID: 1603
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2E6F570", Offset = "0x2E6E970", VA = "0x182E6F570")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ResumeRecord();

		// Token: 0x06000644 RID: 1604
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2E6D930", Offset = "0x2E6CD30", VA = "0x182E6D930")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableRecordLocalMic(bool recordLocalMic);

		// Token: 0x06000645 RID: 1605
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2E6D8B0", Offset = "0x2E6CCB0", VA = "0x182E6D8B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableRecordAccompany(bool recordAccompany);

		// Token: 0x06000646 RID: 1606
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2E6D9B0", Offset = "0x2E6CDB0", VA = "0x182E6D9B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableRecordRemote(bool recordRemote);

		// Token: 0x06000647 RID: 1607
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2E705D0", Offset = "0x2E6F9D0", VA = "0x182E705D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StartRecording(int type, string dstFile, string accMixFile, string accPlayFile, QAVAudioRecordCallback callback);

		// Token: 0x06000648 RID: 1608
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2E70920", Offset = "0x2E6FD20", VA = "0x182E70920")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StopRecording();

		// Token: 0x06000649 RID: 1609
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2E6EFE0", Offset = "0x2E6E3E0", VA = "0x182E6EFE0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PauseRecording();

		// Token: 0x0600064A RID: 1610
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2E6F5E0", Offset = "0x2E6E9E0", VA = "0x182E6F5E0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ResumeRecording();

		// Token: 0x0600064B RID: 1611
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2E6F810", Offset = "0x2E6EC10", VA = "0x182E6F810")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAccompanyFile(string accPlayFile);

		// Token: 0x0600064C RID: 1612
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2E6DD70", Offset = "0x2E6D170", VA = "0x182E6DD70")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetAccompanyTotalTimeByMs();

		// Token: 0x0600064D RID: 1613
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x2E6E2B0", Offset = "0x2E6D6B0", VA = "0x182E6E2B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetRecordTimeByMs();

		// Token: 0x0600064E RID: 1614
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2E70010", Offset = "0x2E6F410", VA = "0x182E70010")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetRecordTimeByMs(int timePlay, int timeRecord);

		// Token: 0x0600064F RID: 1615
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2E6FF90", Offset = "0x2E6F390", VA = "0x182E6FF90")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetRecordKaraokeType(int type);

		// Token: 0x06000650 RID: 1616
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2E6E240", Offset = "0x2E6D640", VA = "0x182E6E240")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetRecordFileDurationByMs();

		// Token: 0x06000651 RID: 1617
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2E70460", Offset = "0x2E6F860", VA = "0x182E70460")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StartPreview(QAVAudioRecordPreviewCallback callback);

		// Token: 0x06000652 RID: 1618
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2E70840", Offset = "0x2E6FC40", VA = "0x182E70840")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StopPreview();

		// Token: 0x06000653 RID: 1619
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x2E6EF00", Offset = "0x2E6E300", VA = "0x182E6EF00")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PausePreview();

		// Token: 0x06000654 RID: 1620
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x2E6F500", Offset = "0x2E6E900", VA = "0x182E6F500")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ResumePreview();

		// Token: 0x06000655 RID: 1621
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x2E6FF10", Offset = "0x2E6F310", VA = "0x182E6FF10")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetPreviewTimeByMs(int time);

		// Token: 0x06000656 RID: 1622
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x2E6E1D0", Offset = "0x2E6D5D0", VA = "0x182E6E1D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetPreviewTimeByMs();

		// Token: 0x06000657 RID: 1623
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2E6FE80", Offset = "0x2E6F280", VA = "0x182E6FE80")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetMixWeights(float mic, float acc);

		// Token: 0x06000658 RID: 1624
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2E6D140", Offset = "0x2E6C540", VA = "0x182E6D140")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_AdjustAudioTimeByMs(int time);

		// Token: 0x06000659 RID: 1625
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2E6ED10", Offset = "0x2E6E110", VA = "0x182E6ED10")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_MixRecordFile(bool needMicData, QAVAudioRecordMixCallback callback);

		// Token: 0x0600065A RID: 1626
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2E6D1C0", Offset = "0x2E6C5C0", VA = "0x182E6D1C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_CancelMixRecordFile();

		// Token: 0x0600065B RID: 1627
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2E6D2C0", Offset = "0x2E6C6C0", VA = "0x182E6D2C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_CleanTask();

		// Token: 0x0600065C RID: 1628
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2E6E930", Offset = "0x2E6DD30", VA = "0x182E6E930")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_InitVoiceChanger(string dataPath);

		// Token: 0x0600065D RID: 1629
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2E6DAC0", Offset = "0x2E6CEC0", VA = "0x182E6DAC0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_FetchVoiceChangerList(QAVFetchVoiceChangerListCallback callback);

		// Token: 0x0600065E RID: 1630
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2E701C0", Offset = "0x2E6F5C0", VA = "0x182E701C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetVoiceChangerName(string voiceName);

		// Token: 0x0600065F RID: 1631
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2E6E780", Offset = "0x2E6DB80", VA = "0x182E6E780")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_AVAudioCtrl_GetVoiceChangerParams();

		// Token: 0x06000660 RID: 1632
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2E6E6E0", Offset = "0x2E6DAE0", VA = "0x182E6E6E0")]
		[PreserveSig]
		public static extern float QAVSDK_AVAudioCtrl_GetVoiceChangerParamValue(string voiceName);

		// Token: 0x06000661 RID: 1633
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2E70260", Offset = "0x2E6F660", VA = "0x182E70260")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetVoiceChangerParamValue(string voiceName, float voiceValue);

		// Token: 0x06000662 RID: 1634
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2E6F050", Offset = "0x2E6E450", VA = "0x182E6F050")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PlayEffect(int soundId, string filePath, bool loop, double pitch, double pan, int volume);

		// Token: 0x06000663 RID: 1635
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2E6EE80", Offset = "0x2E6E280", VA = "0x182E6EE80")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PauseEffect(int soundId);

		// Token: 0x06000664 RID: 1636
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2E6EE10", Offset = "0x2E6E210", VA = "0x182E6EE10")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PauseAllEffects();

		// Token: 0x06000665 RID: 1637
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2E6F480", Offset = "0x2E6E880", VA = "0x182E6F480")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ResumeEffect(int soundId);

		// Token: 0x06000666 RID: 1638
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2E6F410", Offset = "0x2E6E810", VA = "0x182E6F410")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ResumeAllEffects();

		// Token: 0x06000667 RID: 1639
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2E707C0", Offset = "0x2E6FBC0", VA = "0x182E707C0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StopEffect(int soundId);

		// Token: 0x06000668 RID: 1640
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2E70750", Offset = "0x2E6FB50", VA = "0x182E70750")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StopAllEffects();

		// Token: 0x06000669 RID: 1641
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2E6DF50", Offset = "0x2E6D350", VA = "0x182E6DF50")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetEffectsVolume();

		// Token: 0x0600066A RID: 1642
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2E6FC70", Offset = "0x2E6F070", VA = "0x182E6FC70")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetEffectsVolume(int volume);

		// Token: 0x0600066B RID: 1643
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2E6D720", Offset = "0x2E6CB20", VA = "0x182E6D720")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableEffectSend(int soundId, bool enable);

		// Token: 0x0600066C RID: 1644
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2E6FB50", Offset = "0x2E6EF50", VA = "0x182E6FB50")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetEffectFileCurrentPlayedTimeByMs(int soundId, uint timeMs);

		// Token: 0x0600066D RID: 1645
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2E6DE50", Offset = "0x2E6D250", VA = "0x182E6DE50")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetEffectFileCurrentPlayedTimeByMs(int soundId);

		// Token: 0x0600066E RID: 1646
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2E6DED0", Offset = "0x2E6D2D0", VA = "0x182E6DED0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetEffectVolume(int soundId);

		// Token: 0x0600066F RID: 1647
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2E6FBE0", Offset = "0x2E6EFE0", VA = "0x182E6FBE0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetEffectVolume(int soundId, int volume);

		// Token: 0x06000670 RID: 1648
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2E70390", Offset = "0x2E6F790", VA = "0x182E70390")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StartAccompany(string filePath, bool loopBack, int loopCount, int duckerTimeMs, QAVAccompanyFileCompleteHandler callback);

		// Token: 0x06000671 RID: 1649
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2E706D0", Offset = "0x2E6FAD0", VA = "0x182E706D0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_StopAccompany(int duckerTimeMs);

		// Token: 0x06000672 RID: 1650
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2E6E9D0", Offset = "0x2E6DDD0", VA = "0x182E6E9D0")]
		[PreserveSig]
		public static extern bool QAVSDK_AVAudioCtrl_IsAccompanyPlayEnd();

		// Token: 0x06000673 RID: 1651
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2E6EDA0", Offset = "0x2E6E1A0", VA = "0x182E6EDA0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_PauseAccompany();

		// Token: 0x06000674 RID: 1652
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2E6F3A0", Offset = "0x2E6E7A0", VA = "0x182E6F3A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_ResumeAccompany();

		// Token: 0x06000675 RID: 1653
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2E6D420", Offset = "0x2E6C820", VA = "0x182E6D420")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAccompanyPlay(bool enable);

		// Token: 0x06000676 RID: 1654
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2E6D3A0", Offset = "0x2E6C7A0", VA = "0x182E6D3A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_EnableAccompanyLoopBack(bool enable);

		// Token: 0x06000677 RID: 1655
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2E6F8B0", Offset = "0x2E6ECB0", VA = "0x182E6F8B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAccompanyKey(int nKey);

		// Token: 0x06000678 RID: 1656
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2E6F930", Offset = "0x2E6ED30", VA = "0x182E6F930")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAccompanyVolume(int vol);

		// Token: 0x06000679 RID: 1657
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2E6DDE0", Offset = "0x2E6D1E0", VA = "0x182E6DDE0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetAccompanyVolume();

		// Token: 0x0600067A RID: 1658
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2E6DC60", Offset = "0x2E6D060", VA = "0x182E6DC60")]
		[PreserveSig]
		public static extern uint QAVSDK_AVAudioCtrl_GetAccompanyFileTotalTimeByMs();

		// Token: 0x0600067B RID: 1659
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2E6F790", Offset = "0x2E6EB90", VA = "0x182E6F790")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAccompanyFileCurrentPlayedTimeByMs(uint timeMs);

		// Token: 0x0600067C RID: 1660
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2E6DB50", Offset = "0x2E6CF50", VA = "0x182E6DB50")]
		[PreserveSig]
		public static extern uint QAVSDK_AVAudioCtrl_GetAccompanyFileCurrentPlayedTimeByMs();

		// Token: 0x0600067D RID: 1661
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2E6DCD0", Offset = "0x2E6D0D0", VA = "0x182E6DCD0")]
		[PreserveSig]
		public static extern uint QAVSDK_AVAudioCtrl_GetAccompanyFileTotalTimeMsById(string openid);

		// Token: 0x0600067E RID: 1662
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2E6DBC0", Offset = "0x2E6CFC0", VA = "0x182E6DBC0")]
		[PreserveSig]
		public static extern uint QAVSDK_AVAudioCtrl_GetAccompanyFileCurrentPlayedTimeMsById(string openid);

		// Token: 0x0600067F RID: 1663
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2E6E030", Offset = "0x2E6D430", VA = "0x182E6E030")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetMicListCount();

		// Token: 0x06000680 RID: 1664
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x2E6E0A0", Offset = "0x2E6D4A0", VA = "0x182E6E0A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetMicList(StringBuilder devicesInfo, int lengthPerDevice, int deviceCount);

		// Token: 0x06000681 RID: 1665
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2E6F650", Offset = "0x2E6EA50", VA = "0x182E6F650")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SelectMic(string micID);

		// Token: 0x06000682 RID: 1666
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2E6E4A0", Offset = "0x2E6D8A0", VA = "0x182E6E4A0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetSpeakerListCount();

		// Token: 0x06000683 RID: 1667
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x2E6E510", Offset = "0x2E6D910", VA = "0x182E6E510")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_GetSpeakerList(StringBuilder devicesInfo, int lengthPerDevice, int deviceCount);

		// Token: 0x06000684 RID: 1668
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2E6F6F0", Offset = "0x2E6EAF0", VA = "0x182E6F6F0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SelectSpeaker(string speaker);

		// Token: 0x06000685 RID: 1669
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2E6F130", Offset = "0x2E6E530", VA = "0x182E6F130")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_RegisteAudioDataCallback(int dataType, QAVAudioDataCallbackInner callback);

		// Token: 0x06000686 RID: 1670
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2E70990", Offset = "0x2E6FD90", VA = "0x182E70990")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_UnRegisteAudioDataCallback(int dataType);

		// Token: 0x06000687 RID: 1671
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2E6F9B0", Offset = "0x2E6EDB0", VA = "0x182E6F9B0")]
		[PreserveSig]
		public static extern int QAVSDK_AVAudioCtrl_SetAudioDataFormat(int audioType, int sampleRate, int channelCount);

		// Token: 0x06000688 RID: 1672
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2E732D0", Offset = "0x2E726D0", VA = "0x182E732D0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_ApplyPTTAuthbuffer(byte[] authBuffer, int authBufferLen);

		// Token: 0x06000689 RID: 1673
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2E73880", Offset = "0x2E72C80", VA = "0x182E73880")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_SetAppInfo(string appid, string openid);

		// Token: 0x0600068A RID: 1674
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2E73940", Offset = "0x2E72D40", VA = "0x182E73940")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_SetMaxMessageLength(int msTime);

		// Token: 0x0600068B RID: 1675
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2E73A40", Offset = "0x2E72E40", VA = "0x182E73A40")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_SetPTTSourceLanguage(string sourceLanguage);

		// Token: 0x0600068C RID: 1676
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2E73EB0", Offset = "0x2E732B0", VA = "0x182E73EB0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_StartRecording(string filePath, QAVRecordFileCompleteCallback callback);

		// Token: 0x0600068D RID: 1677
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2E73FD0", Offset = "0x2E733D0", VA = "0x182E73FD0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_StopRecording();

		// Token: 0x0600068E RID: 1678
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2E73360", Offset = "0x2E72760", VA = "0x182E73360")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_CancelRecording();

		// Token: 0x0600068F RID: 1679
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2E74230", Offset = "0x2E73630", VA = "0x182E74230")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_UploadRecordedFile(string filePath, QAVUploadFileCompleteCallback callback);

		// Token: 0x06000690 RID: 1680
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2E733D0", Offset = "0x2E727D0", VA = "0x182E733D0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_DownloadRecordedFile(string fileID, string filePath, QAVDownloadFileWithAuditCompleteCallback callback);

		// Token: 0x06000691 RID: 1681
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2E73C50", Offset = "0x2E73050", VA = "0x182E73C50")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_StartPlayFileWithVoiceType(string filePath, int voiceType, QAVPlayFileCompleteCallback callback);

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2E73D10", Offset = "0x2E73110", VA = "0x182E73D10")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_StartPlayFile(string filePath, QAVPlayFileCompleteCallback callback);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2E73F60", Offset = "0x2E73360", VA = "0x182E73F60")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_StopPlayFile();

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2E734A0", Offset = "0x2E728A0", VA = "0x182E734A0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_GetFileSize(string filePath);

		// Token: 0x06000695 RID: 1685
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2E73700", Offset = "0x2E72B00", VA = "0x182E73700")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_GetVoiceFileDuration(string filePath);

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2E73B60", Offset = "0x2E72F60", VA = "0x182E73B60")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_SpeechToText(string fileID, string speechLanguage, string translateLanguage, QAVSpeechToTextWithTargetTextCallback callback);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2E73DC0", Offset = "0x2E731C0", VA = "0x182E73DC0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_StartRecordingWithStreamingRecognition(string filePath, string speechLanguage, string translatelanguage, QAVStreamingRecognitionNativeCallback callback);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2E74140", Offset = "0x2E73540", VA = "0x182E74140")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_TranslateText(string text, string sourceLanguage, string translateLanguage, QAVTranslateTextCallback callback);

		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2E73540", Offset = "0x2E72940", VA = "0x182E73540")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_GetMicLevel();

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2E735B0", Offset = "0x2E729B0", VA = "0x182E735B0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_GetMicVolume();

		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2E739C0", Offset = "0x2E72DC0", VA = "0x182E739C0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_SetMicVolume(int vol);

		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2E73620", Offset = "0x2E72A20", VA = "0x182E73620")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_GetSpeakerLevel();

		// Token: 0x0600069D RID: 1693
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2E73690", Offset = "0x2E72A90", VA = "0x182E73690")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_GetSpeakerVolume();

		// Token: 0x0600069E RID: 1694
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2E73AE0", Offset = "0x2E72EE0", VA = "0x182E73AE0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_SetSpeakerVolume(int vol);

		// Token: 0x0600069F RID: 1695
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2E737A0", Offset = "0x2E72BA0", VA = "0x182E737A0")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_PauseRecording();

		// Token: 0x060006A0 RID: 1696
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2E73810", Offset = "0x2E72C10", VA = "0x182E73810")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_ResumeRecording();

		// Token: 0x060006A1 RID: 1697
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2E71E70", Offset = "0x2E71270", VA = "0x182E71E70")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_EnableMic(bool enable, string receiverID);

		// Token: 0x060006A2 RID: 1698
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2E71F20", Offset = "0x2E71320", VA = "0x182E71F20")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_EnableSpeaker(bool enable, string receiverID);

		// Token: 0x060006A3 RID: 1699
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2E71BB0", Offset = "0x2E70FB0", VA = "0x182E71BB0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_EnableAudioCaptureDevice(bool enable, string receiverID);

		// Token: 0x060006A4 RID: 1700
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2E71C60", Offset = "0x2E71060", VA = "0x182E71C60")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_EnableAudioPlayDevice(bool enable, string receiverID);

		// Token: 0x060006A5 RID: 1701
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2E71DC0", Offset = "0x2E711C0", VA = "0x182E71DC0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_EnableAudioSend(bool enable, string receiverID);

		// Token: 0x060006A6 RID: 1702
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2E71D10", Offset = "0x2E71110", VA = "0x182E71D10")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_EnableAudioRecv(bool enable, string receiverID);

		// Token: 0x060006A7 RID: 1703
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2E71FD0", Offset = "0x2E713D0", VA = "0x182E71FD0")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_ForbidUserOperation(bool enable, string receiverID);

		// Token: 0x060006A8 RID: 1704
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2E72080", Offset = "0x2E71480", VA = "0x182E72080")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_GetMicState(string receiverID);

		// Token: 0x060006A9 RID: 1705
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2E72120", Offset = "0x2E71520", VA = "0x182E72120")]
		[PreserveSig]
		public static extern int QAVSDK_AVRoomManager_GetSpeakerState(string receiverID);

		// Token: 0x060006AA RID: 1706
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2E74040", Offset = "0x2E73440", VA = "0x182E74040")]
		[PreserveSig]
		public static extern int QAVSDK_PTT_TextToSpeech(string text, string voiceName, string languageCode, float speakingRate, QAVTextToSpeechCallback callback);

		// Token: 0x060006AB RID: 1707
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2E72E10", Offset = "0x2E72210", VA = "0x182E72E10")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_FaceTracker_CreateHandle(string modelDirPath, string configFileName);

		// Token: 0x060006AC RID: 1708
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2E72ED0", Offset = "0x2E722D0", VA = "0x182E72ED0")]
		[PreserveSig]
		public static extern int QAVSDK_FaceTracker_Destroy(IntPtr handle);

		// Token: 0x060006AD RID: 1709
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2E73060", Offset = "0x2E72460", VA = "0x182E73060")]
		[PreserveSig]
		public static extern int QAVSDK_FaceTracker_Reset(IntPtr handle);

		// Token: 0x060006AE RID: 1710
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2E72F50", Offset = "0x2E72350", VA = "0x182E72F50")]
		[PreserveSig]
		public static extern void QAVSDK_FaceTracker_GetParam(IntPtr handle, IntPtr paramPtr);

		// Token: 0x060006AF RID: 1711
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2E730E0", Offset = "0x2E724E0", VA = "0x182E730E0")]
		[PreserveSig]
		public static extern void QAVSDK_FaceTracker_SetParam(IntPtr handle, IntPtr paramPtr);

		// Token: 0x060006B0 RID: 1712
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2E73170", Offset = "0x2E72570", VA = "0x182E73170")]
		[PreserveSig]
		public static extern void QAVSDK_FaceTracker_TrackFace(IntPtr handle, IntPtr dataPtr, int imageType, int with, int height, int stride, int rotate, ref IntPtr facesPtr, ref int count);

		// Token: 0x060006B1 RID: 1713
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E723E0", VA = "0x182E72FE0")]
		[PreserveSig]
		public static extern void QAVSDK_FaceTracker_ReleaseTrackedFace(IntPtr facesPtr);

		// Token: 0x060006B2 RID: 1714
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2E74350", Offset = "0x2E73750", VA = "0x182E74350")]
		[PreserveSig]
		public static extern IntPtr QAVSDK_PoseTracker_CreateHandle(string bodyModelPath, string bodyModelBinPath, string poseModelPath, string poseModelBinPath, string smootherModePath, string smootherModeBinPath);

		// Token: 0x060006B3 RID: 1715
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2E744A0", Offset = "0x2E738A0", VA = "0x182E744A0")]
		[PreserveSig]
		public static extern int QAVSDK_PoseTracker_DestroyHandle(IntPtr handle);

		// Token: 0x060006B4 RID: 1716
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2E74520", Offset = "0x2E73920", VA = "0x182E74520")]
		[PreserveSig]
		public static extern int QAVSDK_PoseTracker_SetRenderEngine(IntPtr handle, string renderEngine);

		// Token: 0x060006B5 RID: 1717
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2E745D0", Offset = "0x2E739D0", VA = "0x182E745D0")]
		[PreserveSig]
		public static extern int QAVSDK_PoseTracker_TrackPose(IntPtr handle, IntPtr dataPtr, int format, int with, int height, int stride, int rotate, ref TMGPoseTrackerPoseInfo poseInfo);

		// Token: 0x060006B6 RID: 1718
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2E6CDA0", Offset = "0x2E6C1A0", VA = "0x182E6CDA0")]
		[PreserveSig]
		public static extern void GME_AAC_Entry();

		// Token: 0x060006B7 RID: 1719
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2E6CE10", Offset = "0x2E6C210", VA = "0x182E6CE10")]
		[PreserveSig]
		public static extern void GME_MP3_ENTRY();

		// Token: 0x060006B8 RID: 1720
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2E6CE80", Offset = "0x2E6C280", VA = "0x182E6CE80")]
		[PreserveSig]
		public static extern void GME_OGG_ENTRY();

		// Token: 0x060006B9 RID: 1721
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2E6CEF0", Offset = "0x2E6C2F0", VA = "0x182E6CEF0")]
		[PreserveSig]
		public static extern void GME_SOUNDTOUCH_Entry();

		// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public QAVNative()
		{
		}

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4680FD8")]
		public static string NATIVE_VERSION;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x4000326")]
		public const string MyLibName = "gmesdk";
	}
}
