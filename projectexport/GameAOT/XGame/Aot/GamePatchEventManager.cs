using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x20000E7")]
	[Attribute(Name = "LuaCallCSharpAttribute", RVA = "0x90BA0", Offset = "0x8FFA0")]
	public static class GamePatchEventManager
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x137B4A0", Offset = "0x137A8A0", VA = "0x18137B4A0")]
		public static void AddListener(string eventCode, Action<object> callback)
		{
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x137B650", Offset = "0x137AA50", VA = "0x18137B650")]
		public static void RemoveListener(string eventCode, Action<object> callback)
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x137B510", Offset = "0x137A910", VA = "0x18137B510")]
		public static void DispatchEvent(string eventCode, [Optional] object obj)
		{
		}
	}
}
