using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XGame.Aot
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000110")]
	public static class LoadUtility
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600098E")]
		[Address(RVA = "0xEC2050", Offset = "0xEC1450", VA = "0x180EC2050")]
		public static string GetStreamingFileRootForWWW()
		{
			return null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x600098F")]
		[Address(RVA = "0xEC21D0", Offset = "0xEC15D0", VA = "0x180EC21D0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE34F0", Offset = "0xE28F0")]
		public static UniTask<string> LoadStreamingFileAsync(string filePath)
		{
			return default(UniTask<string>);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x6000990")]
		[Address(RVA = "0xEC20E0", Offset = "0xEC14E0", VA = "0x180EC20E0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE39C0", Offset = "0xE2DC0")]
		public static UniTask<string> LoadRawFileAsync(string filePath)
		{
			return default(UniTask<string>);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x6000991")]
		[Address(RVA = "0xCB9160", Offset = "0xCB8560", VA = "0x180CB9160")]
		public static bool IsFileExistInApk(string path, string fileName)
		{
			return default(bool);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000992")]
		[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
		public static string GetFileStringFromApk(string fileName)
		{
			return null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000993")]
		[Address(RVA = "0xBA6AF0", Offset = "0xBA5EF0", VA = "0x180BA6AF0")]
		public static byte[] GetFileBinaryFromApk(string fileName)
		{
			return null;
		}

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x0")]
		private static string _streamingRootForWWW;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass javaClass;
	}
}
