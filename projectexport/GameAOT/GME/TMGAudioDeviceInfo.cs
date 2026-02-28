using System;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000B1")]
	public class TMGAudioDeviceInfo
	{
		// Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000670")]
		[Address(RVA = "0xCD69C0", Offset = "0xCD5DC0", VA = "0x180CD69C0")]
		public TMGAudioDeviceInfo(string deviceID, string deviceName)
		{
		}

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x10")]
		public string m_strDeviceID;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x18")]
		public string m_strDeviceName;
	}
}
