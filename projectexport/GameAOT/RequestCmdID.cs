using System;
using Il2CppDummyDll;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000A")]
public enum RequestCmdID
{
	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	Cmd_GetEmulatorName = 1,
	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	Cmd_IsRootDevice,
	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	Cmd_DeviceID,
	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	Cmd_GetHTPVersion = 7,
	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	Cmd_GetEncHTPVersion = 9,
	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	Cmd_GetHtpStatus = 14,
	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	Cmd_SetConfigData = 16,
	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	Cmd_SetResponseData
}
