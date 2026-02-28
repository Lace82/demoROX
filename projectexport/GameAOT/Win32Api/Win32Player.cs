using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Win32Api
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000024")]
	public static class Win32Player
	{
		// Token: 0x060002C6 RID: 710
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x138EBD0", Offset = "0x138DFD0", VA = "0x18138EBD0")]
		[PreserveSig]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x060002C7 RID: 711
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x138EC90", Offset = "0x138E090", VA = "0x18138EC90")]
		[PreserveSig]
		private static extern IntPtr GetActiveWindow();

		// Token: 0x060002C8 RID: 712
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x138F2A0", Offset = "0x138E6A0", VA = "0x18138F2A0")]
		[PreserveSig]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

		// Token: 0x060002C9 RID: 713
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x138EB40", Offset = "0x138DF40", VA = "0x18138EB40")]
		[PreserveSig]
		private static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Win32Player.MARGINS margins);

		// Token: 0x060002CA RID: 714
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x138F130", Offset = "0x138E530", VA = "0x18138F130")]
		[PreserveSig]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x060002CB RID: 715
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x138F010", Offset = "0x138E410", VA = "0x18138F010")]
		[PreserveSig]
		public static extern bool ReleaseCapture();

		// Token: 0x060002CC RID: 716
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x138F080", Offset = "0x138E480", VA = "0x18138F080")]
		[PreserveSig]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x138F340", Offset = "0x138E740", VA = "0x18138F340")]
		[PreserveSig]
		public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x138EE00", Offset = "0x138E200", VA = "0x18138EE00")]
		public static void RefreshInitWindow(bool isAlpha, string projectName)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x138F250", Offset = "0x138E650", VA = "0x18138F250")]
		public static void SetResetWindow()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x138F200", Offset = "0x138E600", VA = "0x18138F200")]
		public static void SetMiniWindow()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x138F1B0", Offset = "0x138E5B0", VA = "0x18138F1B0")]
		public static void SetMaxWindow()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x138ED00", Offset = "0x138E100", VA = "0x18138ED00")]
		public static void MoveWindow()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		public static void WindowQuit()
		{
		}

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x40000CF")]
		private const int GWL_STYLE = -16;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x40000D0")]
		private const uint WS_POPUP = 2147483648U;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x40000D1")]
		private const uint WS_VISIBLE = 268435456U;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x40000D2")]
		private const uint WS_BORDER = 8388608U;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x40000D3")]
		private const int SW_SHOWRESETMIZED = 1;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x40000D4")]
		private const int SW_SHOWMINIMIZED = 2;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x40000D5")]
		private const int SW_SHOWMAXIMIZED = 3;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr _currWnd;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _mInit;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000151")]
		private struct MARGINS
		{
			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int cxLeftWidth;

			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int cxRightWidth;

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int cyTopHeight;

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int cyBottomHeight;
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000152")]
		private enum WindowSizeType
		{
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000542")]
			Null,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000543")]
			Normal,
			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000544")]
			MinSize,
			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000545")]
			MaxSize
		}
	}
}
