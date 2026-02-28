using System;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x20000DA")]
	public class GameEntry : MonoBehaviour
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public static GameEntry Instance
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x137B2D0", Offset = "0x137A6D0", VA = "0x18137B2D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x137B450", Offset = "0x137A850", VA = "0x18137B450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000043")]
		public event Action<double> OnTick
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x137B190", Offset = "0x137A590", VA = "0x18137B190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x137B310", Offset = "0x137A710", VA = "0x18137B310")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000957 RID: 2391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000044")]
		public event Action<float> OnUpdate
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x137B230", Offset = "0x137A630", VA = "0x18137B230")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x137B3B0", Offset = "0x137A7B0", VA = "0x18137B3B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x137ABF0", Offset = "0x1379FF0", VA = "0x18137ABF0")]
		private void Awake()
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x137ACB0", Offset = "0x137A0B0", VA = "0x18137ACB0")]
		private void InitGame()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x137AF50", Offset = "0x137A350", VA = "0x18137AF50")]
		private void InitializeXGameFramework()
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x137B100", Offset = "0x137A500", VA = "0x18137B100")]
		private void Update()
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x137B0B0", Offset = "0x137A4B0", VA = "0x18137B0B0")]
		private void OnGameLoopHandler(double deltaTime)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x137B180", Offset = "0x137A580", VA = "0x18137B180")]
		public GameEntry()
		{
		}

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static GameEntry <Instance>k__BackingField;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x18")]
		public bool toggleGuide;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x19")]
		public bool debugLua;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x1A")]
		public bool debugExpandTables;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x1C")]
		public EPlayMode playMode;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x4000421")]
		private const int GAME_FPS = 30;
	}
}
