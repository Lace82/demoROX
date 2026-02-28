using System;
using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000045")]
	public class SceneHandle : HandleBase
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		internal string PackageName
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1BB1220", Offset = "0x1BB0620", VA = "0x181BB1220")]
		internal SceneHandle(ProviderBase provider)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1BB9910", Offset = "0x1BB8D10", VA = "0x181BB9910", Slot = "7")]
		internal override void InvokeCallback()
		{
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event Action<SceneHandle> Completed
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1BB9DD0", Offset = "0x1BB91D0", VA = "0x181BB9DD0")]
			add
			{
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1BB9FB0", Offset = "0x1BB93B0", VA = "0x181BB9FB0")]
			remove
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000044")]
		public string SceneName
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1BB9F00", Offset = "0x1BB9300", VA = "0x181BB9F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x17000045")]
		public Scene SceneObject
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1BB9F70", Offset = "0x1BB9370", VA = "0x181BB9F70")]
			get
			{
				return default(Scene);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1BB9790", Offset = "0x1BB8B90", VA = "0x181BB9790")]
		public bool ActivateScene()
		{
			return default(bool);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1BB9A20", Offset = "0x1BB8E20", VA = "0x181BB9A20")]
		public bool UnSuspend()
		{
			return default(bool);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1BB9960", Offset = "0x1BB8D60", VA = "0x181BB9960")]
		public bool IsMainScene()
		{
			return default(bool);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1BB9BA0", Offset = "0x1BB8FA0", VA = "0x181BB9BA0")]
		public UnloadSceneOperation UnloadAsync()
		{
			return null;
		}

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageName>k__BackingField;
	}
}
