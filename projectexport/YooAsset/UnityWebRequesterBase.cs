using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YooAsset
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000035")]
	internal abstract class UnityWebRequesterBase
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public string URL
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xB9A950", Offset = "0xB99D50", VA = "0x180B9A950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xCC31B0", Offset = "0xCC25B0", VA = "0x180CC31B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1BBB0A0", Offset = "0x1BBA4A0", VA = "0x181BBB0A0")]
		protected void ResetTimeout(float timeout)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1BBAF40", Offset = "0x1BBA340", VA = "0x181BBAF40")]
		public void Dispose()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1BBB060", Offset = "0x1BBA460", VA = "0x181BBB060")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1BBB080", Offset = "0x1BBA480", VA = "0x181BBB080")]
		public float Progress()
		{
			return 0f;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1BBB010", Offset = "0x1BBA410", VA = "0x181BBB010")]
		public bool HasError()
		{
			return default(bool);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1BBAF90", Offset = "0x1BBA390", VA = "0x181BBAF90")]
		public string GetError()
		{
			return null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1BBAEB0", Offset = "0x1BBA2B0", VA = "0x181BBAEB0")]
		public void CheckTimeout()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		protected UnityWebRequesterBase()
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x10")]
		protected UnityWebRequest _webRequest;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x18")]
		protected UnityWebRequestAsyncOperation _operationHandle;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x20")]
		private float _timeout;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x24")]
		private bool _isAbort;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x28")]
		private ulong _latestDownloadBytes;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x30")]
		private float _latestDownloadRealtime;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <URL>k__BackingField;
	}
}
