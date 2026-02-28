using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NetEase
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000027")]
	public class HTProtectConfig
	{
		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1D32230", Offset = "0x1D31630", VA = "0x181D32230")]
		public HTProtectConfig()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x943540", Offset = "0x942940", VA = "0x180943540")]
		public void setServerType(int server)
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
		public int getServerType()
		{
			return 0;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
		public void setChannel(string channel)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
		public string getChannel()
		{
			return null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1D322E0", Offset = "0x1D316E0", VA = "0x181D322E0")]
		public void setExtraData(string key, string value)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1D32020", Offset = "0x1D31420", VA = "0x181D32020")]
		private static string DataToJson(Dictionary<string, string> data)
		{
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1D322D0", Offset = "0x1D316D0", VA = "0x181D322D0")]
		public string getExtraData()
		{
			return null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
		public void setGameKey(string gameKey)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
		public string getGameKey()
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1047110", Offset = "0x1046510", VA = "0x181047110")]
		public void setHost(string host)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
		public string getHost()
		{
			return null;
		}

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x10")]
		private int serverType;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		private string channel;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x20")]
		private string gameKey;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, string> ext_data;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x30")]
		private string host;
	}
}
