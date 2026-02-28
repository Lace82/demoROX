using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace NLPC
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000044")]
	internal static class NativeMethods
	{
		// Token: 0x06000351 RID: 849
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2E69E70", Offset = "0x2E69270", VA = "0x182E69E70")]
		[PreserveSig]
		internal static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

		// Token: 0x06000352 RID: 850
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2E69940", Offset = "0x2E68D40", VA = "0x182E69940")]
		[PreserveSig]
		internal static extern IntPtr OpenEventW(uint dwDesiredAccess, int bInheritHandle, StringBuilder lpName);

		// Token: 0x06000353 RID: 851
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2E69D40", Offset = "0x2E69140", VA = "0x182E69D40")]
		[PreserveSig]
		internal static extern int SetEvent(IntPtr hEvent);

		// Token: 0x06000354 RID: 852
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2E69A00", Offset = "0x2E68E00", VA = "0x182E69A00")]
		[PreserveSig]
		internal static extern IntPtr OpenFileMappingW(uint dwDesiredAccess, int bInheritHandle, StringBuilder lpName);

		// Token: 0x06000355 RID: 853
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2E69880", Offset = "0x2E68C80", VA = "0x182E69880")]
		[PreserveSig]
		internal static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, int dwNumberOfBytesToMap);

		// Token: 0x06000356 RID: 854
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2E694A0", Offset = "0x2E688A0", VA = "0x182E694A0")]
		[PreserveSig]
		internal static extern bool CloseHandle(IntPtr hHandle);

		// Token: 0x06000357 RID: 855
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2E69810", Offset = "0x2E68C10", VA = "0x182E69810")]
		[PreserveSig]
		internal static extern uint GetLastError();

		// Token: 0x06000358 RID: 856
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2E69DC0", Offset = "0x2E691C0", VA = "0x182E69DC0")]
		[PreserveSig]
		public static extern bool SetNamedPipeHandleState(IntPtr hHandle, ref uint lpMode, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout);

		// Token: 0x06000359 RID: 857
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2E69AD0", Offset = "0x2E68ED0", VA = "0x182E69AD0")]
		[PreserveSig]
		public static extern IntPtr OpenThread(uint dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x0600035A RID: 858
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2E696D0", Offset = "0x2E68AD0", VA = "0x182E696D0")]
		[PreserveSig]
		public static extern bool GetExitCodeThread(IntPtr hThread, ref uint lpExitCode);

		// Token: 0x0600035B RID: 859
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2E69CB0", Offset = "0x2E690B0", VA = "0x182E69CB0")]
		[PreserveSig]
		public static extern uint ResumeThread(IntPtr hThread);

		// Token: 0x0600035C RID: 860
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2E69770", Offset = "0x2E68B70", VA = "0x182E69770")]
		[PreserveSig]
		public static extern uint GetFileAttributesA(string lpFileName);

		// Token: 0x0600035D RID: 861
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2E69520", Offset = "0x2E68920", VA = "0x182E69520")]
		[PreserveSig]
		public static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);

		// Token: 0x0600035E RID: 862
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2E69C30", Offset = "0x2E69030", VA = "0x182E69C30")]
		[PreserveSig]
		public static extern bool ResetEvent(IntPtr hEvent);

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2E69F00", Offset = "0x2E69300", VA = "0x182E69F00")]
		[PreserveSig]
		internal static extern bool WriteFile(IntPtr hHandle, IntPtr lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

		// Token: 0x06000360 RID: 864
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2E69B70", Offset = "0x2E68F70", VA = "0x182E69B70")]
		[PreserveSig]
		public static extern bool ReadFile(IntPtr hHandle, IntPtr lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

		// Token: 0x06000361 RID: 865
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2E695F0", Offset = "0x2E689F0", VA = "0x182E695F0")]
		[PreserveSig]
		public static extern IntPtr CreateFile(string fileName, uint desiredAccess, uint shareMode, uint securityAttributes, uint creationDisposition, uint flagsAndAttributes, uint templateFile);
	}
}
