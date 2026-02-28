using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x20000D1")]
	[Serializable]
	public class AppConfig
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x13767F0", Offset = "0x1375BF0", VA = "0x1813767F0")]
		public AppConfig()
		{
		}

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x10")]
		public string EntryURL;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x18")]
		public string AccountURL;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x20")]
		public string ClientLogURL;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x28")]
		public int ChannelID;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x2C")]
		public bool UseSDK;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x30")]
		public string HeadImage_UpLoadImageURL;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x38")]
		public string HeadImage_DownImageURL;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x40")]
		public string ChannelEnv;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x48")]
		public string appName;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x50")]
		public string HeadImage_SecretKey;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x58")]
		public bool HeadImage_NeedUpLoadPicture;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x60")]
		public string SplashVideoPath;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x68")]
		public bool ShowDebug;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x6C")]
		public int ClientLogLevel;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x70")]
		public int DefaultLanguage;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x78")]
		public string settingOpenLanguage;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x80")]
		public string ByteDanceCustomerServiceUrl;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x88")]
		public string ByteDanceCustomerServiceRedPointGetUrl;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x90")]
		public string SensorsServerURL;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x98")]
		public int ServerTimeZone;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x9C")]
		public bool EnableSensitiveWords;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0xA0")]
		public string PrimaryFontName;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0xA8")]
		public string PrimarySmallFontName;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0xB0")]
		public string DefaultResourcesLang;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0xB8")]
		public string ResourcesLangList;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0xC0")]
		public string ProjectName;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0xC8")]
		public int SplashDelayTime;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0xCC")]
		public int SplashStayTime;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0xD0")]
		public int SplashInTime;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0xD4")]
		public int SplashOutTime;
	}
}
