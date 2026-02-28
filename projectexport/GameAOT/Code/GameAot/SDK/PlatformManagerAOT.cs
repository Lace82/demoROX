using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Code.GameAot.SDK
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x2000064")]
	public class PlatformManagerAOT
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004B")]
		public static PlatformManagerAOT Instance
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2765150", Offset = "0x2764550", VA = "0x182765150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2765110", Offset = "0x2764510", VA = "0x182765110")]
		public static PlatformManagerAOT GetInstance()
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x27650C0", Offset = "0x27644C0", VA = "0x1827650C0")]
		public static void CreateInstance(PlatformManagerAOT ins)
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "4")]
		public virtual void InitSDK()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "5")]
		public virtual void OnSDKInit(string msg)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		public virtual void SDKTrackGuideFlow(PlatformManagerAOT.GuideFlowEvent eventId, int guideStep = 0)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "7")]
		public virtual void SDKTrackEvent_CDNResUpdateStart(string resVersion)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "8")]
		public virtual void SDKTrackEvent_CDNResCheckUpdate()
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "9")]
		public virtual void SDKTrackEvent_CDNResStartDownload()
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "10")]
		public virtual void SDKTrackEvent_CDNResUpdateFailed(string resVersion, int errorCode, string errorMsg)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "11")]
		public virtual void SDKTrackEvent_CDNResUpdateEnd(string bundleVersion, float successRate, float duration, float size, int fileCount)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "12")]
		public virtual void SDKTrackEvent_CDNFileDownloadFailed(string cdnIp, string url, int errorCode, string errorMsg)
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "13")]
		public virtual void OnHotfixResult(bool success, string errorMsg)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "14")]
		public virtual void OnHotfixProgress(float val)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public PlatformManagerAOT()
		{
		}

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x0")]
		private static PlatformManagerAOT m_Instance;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x10")]
		public bool IsSDKInit;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x14")]
		public int isReview;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> conversionInfo;

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200015E")]
		public enum GuideFlowEvent
		{
			// Token: 0x040002AD RID: 685
			[Token(Token = "0x4000573")]
			SDKInit = 1,
			// Token: 0x040002AE RID: 686
			[Token(Token = "0x4000574")]
			CDNRequest,
			// Token: 0x040002AF RID: 687
			[Token(Token = "0x4000575")]
			VersionInfoReturn,
			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x4000576")]
			HotfixStart,
			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x4000577")]
			HotfixFinish
		}
	}
}
