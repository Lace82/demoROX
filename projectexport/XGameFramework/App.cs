using System;
using Il2CppDummyDll;
using XGameFramework.Utils;

namespace XGameFramework
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class App : Singleton<App>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public int GameFps
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0xCC3510", Offset = "0xCC2910", VA = "0x180CC3510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2B8BFF0", Offset = "0x2B8B3F0", VA = "0x182B8BFF0")]
			set
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		private event Action<double> _onTick
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2B8BF50", Offset = "0x2B8B350", VA = "0x182B8BF50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			add
			{
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2B8C7C0", Offset = "0x2B8BBC0", VA = "0x182B8C7C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			remove
			{
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2B8C650", Offset = "0x2B8BA50", VA = "0x182B8C650", Slot = "5")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2B8BFF0", Offset = "0x2B8B3F0", VA = "0x182B8BFF0")]
		private void ChangeFps(int fps)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2B8C860", Offset = "0x2B8BC60", VA = "0x182B8C860")]
		public void Tick()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2B8C2B0", Offset = "0x2B8B6B0", VA = "0x182B8C2B0")]
		private void GameLoop(double deltaTime)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2B8BF50", Offset = "0x2B8B350", VA = "0x182B8BF50")]
		public void AddTickCall(Action<double> call)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2B8C7C0", Offset = "0x2B8BBC0", VA = "0x182B8C7C0")]
		public void RemoveTickCall(Action<double> call)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000B")]
		public T GetModule<T>() where T : class, IModule
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2B8C460", Offset = "0x2B8B860", VA = "0x182B8C460")]
		private IModule GetModule(Type moduleType)
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2B8C0E0", Offset = "0x2B8B4E0", VA = "0x182B8C0E0")]
		private IModule CreateModule(Type moduleType)
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2B8C8E0", Offset = "0x2B8BCE0", VA = "0x182B8C8E0")]
		public App()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2B8C880", Offset = "0x2B8BC80", VA = "0x182B8C880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private void <ChangeFps>b__11_0(double deltaTime)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private readonly LinkedListQueue<IModule> _frameWorkModules;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private readonly LinkedListQueue<ITick> _tickModules;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private FixedTick _fixedTick;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		private int _gameFps;
	}
}
