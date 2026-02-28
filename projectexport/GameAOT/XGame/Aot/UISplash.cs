using System;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace XGame.Aot
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000105")]
	public class UISplash : MonoBehaviour
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		[Address(RVA = "0xED7870", Offset = "0xED6C70", VA = "0x180ED7870")]
		private void Start()
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000939")]
		[Address(RVA = "0xED71B0", Offset = "0xED65B0", VA = "0x180ED71B0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE0250", Offset = "0xDF650")]
		private UniTaskVoid OnEnterDo()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093A")]
		[Address(RVA = "0xED7250", Offset = "0xED6650", VA = "0x180ED7250")]
		private void OnSplashFinished()
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x600093B")]
		[Address(RVA = "0xED7920", Offset = "0xED6D20", VA = "0x180ED7920")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE0870", Offset = "0xDFC70")]
		private UniTask SyncConfig()
		{
			return default(UniTask);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600093C")]
		[Address(RVA = "0xED70D0", Offset = "0xED64D0", VA = "0x180ED70D0")]
		private static string GetNewVersion(string v1, string v2)
		{
			return null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093D")]
		[Address(RVA = "0xED73E0", Offset = "0xED67E0", VA = "0x180ED73E0")]
		private static void SetSplashUIActive(bool active)
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0xED74E0", Offset = "0xED68E0", VA = "0x180ED74E0")]
		private void StartSplashImage(Action onComplete)
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600093F")]
		[Address(RVA = "0xED6F50", Offset = "0xED6350", VA = "0x180ED6F50")]
		public static Tween DoFadeInOut(Graphic target, float delay, float inT, float stayT, float outT, [Optional] TweenCallback completeCallback)
		{
			return null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000940")]
		[Address(RVA = "0xED5540", Offset = "0xED4940", VA = "0x180ED5540")]
		public static void QuitGame()
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000941")]
		[Address(RVA = "0xB96E20", Offset = "0xB96220", VA = "0x180B96E20")]
		public UISplash()
		{
		}

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _bSplashEnd;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _bSyncConfigEnd;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool _bReadError;

		// Token: 0x02000157 RID: 343
		[Token(Token = "0x2000184")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c()
			{
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0xED5540", Offset = "0xED4940", VA = "0x180ED5540")]
			internal void <OnSplashFinished>b__5_0(object ret)
			{
			}

			// Token: 0x04000606 RID: 1542
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UISplash.<>c <>9;

			// Token: 0x04000607 RID: 1543
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<object> <>9__5_0;
		}

		// Token: 0x02000159 RID: 345
		[Token(Token = "0x2000186")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06000A7D RID: 2685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0xED57C0", Offset = "0xED4BC0", VA = "0x180ED57C0")]
			internal void <StartSplashImage>b__0()
			{
			}

			// Token: 0x0400060D RID: 1549
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UISplash <>4__this;

			// Token: 0x0400060E RID: 1550
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onComplete;
		}
	}
}
