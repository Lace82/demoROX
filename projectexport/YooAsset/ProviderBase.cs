using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x200005B")]
	internal abstract class ProviderBase : AsyncOperationBase
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public string ProviderGUID
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x105CEB0", Offset = "0x105C2B0", VA = "0x18105CEB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x105CEA0", Offset = "0x105C2A0", VA = "0x18105CEA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public ResourceManager ResourceMgr
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xCB8250", Offset = "0xCB7650", VA = "0x180CB8250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x105D290", Offset = "0x105C690", VA = "0x18105D290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public AssetInfo MainAssetInfo
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xCB09B0", Offset = "0xCAFDB0", VA = "0x180CB09B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xCB1390", Offset = "0xCB0790", VA = "0x180CB1390")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public UnityEngine.Object AssetObject
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xCB0750", Offset = "0xCAFB50", VA = "0x180CB0750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xB9D9F0", Offset = "0xB9CDF0", VA = "0x180B9D9F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public UnityEngine.Object[] AllAssetObjects
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xCB0840", Offset = "0xCAFC40", VA = "0x180CB0840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x105DAA0", Offset = "0x105CEA0", VA = "0x18105DAA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public Scene SceneObject
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xCD6D90", Offset = "0xCD6190", VA = "0x180CD6D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(Scene);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xCD6F40", Offset = "0xCD6340", VA = "0x180CD6F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public string SceneName
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x8EF970", Offset = "0x8EED70", VA = "0x1808EF970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xCD51C0", Offset = "0xCD45C0", VA = "0x180CD51C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public string RawFilePath
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xCB0760", Offset = "0xCAFB60", VA = "0x180CB0760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xCD51A0", Offset = "0xCD45A0", VA = "0x180CD51A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public int RefCount
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x105DBD0", Offset = "0x105CFD0", VA = "0x18105DBD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x105DBE0", Offset = "0x105CFE0", VA = "0x18105DBE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public bool IsDestroyed
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x12E3700", Offset = "0x12E2B00", VA = "0x1812E3700")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1BAF8B0", Offset = "0x1BAECB0", VA = "0x181BAF8B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		private protected BundleLoaderBase OwnerBundle
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xCB0860", Offset = "0xCAFC60", VA = "0x180CB0860")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x105DDC0", Offset = "0x105D1C0", VA = "0x18105DDC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		private protected DependAssetBundles DependBundles
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xCB0870", Offset = "0xCAFC70", VA = "0x180CB0870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xCD51B0", Offset = "0xCD45B0", VA = "0x180CD51B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		private protected bool IsWaitForAsyncComplete
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1913BD0", Offset = "0x1912FD0", VA = "0x181913BD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1BAF8D0", Offset = "0x1BAECD0", VA = "0x181BAF8D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		private protected bool IsForceDestroyComplete
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1BAF8A0", Offset = "0x1BAECA0", VA = "0x181BAF8A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x1BAF8C0", Offset = "0x1BAECC0", VA = "0x181BAF8C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000060")]
		public bool IsSyncLoad
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1913BD0", Offset = "0x1912FD0", VA = "0x181913BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1BAF5F0", Offset = "0x1BAE9F0", VA = "0x181BAF5F0")]
		public ProviderBase(ResourceManager manager, string providerGUID, AssetInfo assetInfo)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1BAE940", Offset = "0x1BADD40", VA = "0x181BAE940")]
		public void Destroy()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1BAE850", Offset = "0x1BADC50", VA = "0x181BAE850")]
		public bool CanDestroy()
		{
			return default(bool);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000237")]
		public T CreateHandle<T>() where T : HandleBase
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1BAF140", Offset = "0x1BAE540", VA = "0x181BAF140")]
		public void ReleaseHandle(HandleBase handle)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1BAF080", Offset = "0x1BAE480", VA = "0x181BAF080")]
		public void ReleaseAllHandles()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1BAF540", Offset = "0x1BAE940", VA = "0x181BAF540")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1BAEA00", Offset = "0x1BADE00", VA = "0x181BAEA00")]
		public void ForceDestroyComplete()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1BAEF90", Offset = "0x1BAE390", VA = "0x181BAEF90")]
		protected void ProcessCacheBundleException()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1BAEE30", Offset = "0x1BAE230", VA = "0x181BAEE30")]
		protected void InvokeCompletion(string error, EOperationStatus status)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00002898 File Offset: 0x00000A98
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public long LoadingTime
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xB9BF40", Offset = "0xB9B340", VA = "0x180B9BF40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x1BAF8E0", Offset = "0x1BAECE0", VA = "0x181BAF8E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1BAED80", Offset = "0x1BAE180", VA = "0x181BAED80")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		public void InitSpawnDebugInfo()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1BAF210", Offset = "0x1BAE610", VA = "0x181BAF210")]
		private string SpawnTimeToString(float spawnTime)
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1BAE870", Offset = "0x1BADC70", VA = "0x181BAE870")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		protected void DebugBeginRecording()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1BAE8F0", Offset = "0x1BADCF0", VA = "0x181BAE8F0")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void DebugEndRecording()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1BAEB20", Offset = "0x1BADF20", VA = "0x181BAEB20")]
		internal DownloadStatus GetDownloadStatus()
		{
			return default(DownloadStatus);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1BAEA20", Offset = "0x1BADE20", VA = "0x181BAEA20")]
		internal void GetBundleDebugInfos(List<DebugBundleInfo> output)
		{
		}

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <ProviderGUID>k__BackingField;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ResourceManager <ResourceMgr>k__BackingField;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private AssetInfo <MainAssetInfo>k__BackingField;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private UnityEngine.Object <AssetObject>k__BackingField;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private UnityEngine.Object[] <AllAssetObjects>k__BackingField;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private Scene <SceneObject>k__BackingField;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <SceneName>k__BackingField;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <RawFilePath>k__BackingField;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <RefCount>k__BackingField;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsDestroyed>k__BackingField;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x90")]
		protected ProviderBase.ESteps _steps;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private BundleLoaderBase <OwnerBundle>k__BackingField;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private DependAssetBundles <DependBundles>k__BackingField;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsWaitForAsyncComplete>k__BackingField;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xA9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsForceDestroyComplete>k__BackingField;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<HandleBase> _handles;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xB8")]
		public string SpawnScene;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xC0")]
		public string SpawnTime;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xC8")]
		public float SpawnSecond;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private long <LoadingTime>k__BackingField;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xD8")]
		private Stopwatch _watch;

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x20000BF")]
		protected enum ESteps
		{
			// Token: 0x040001B4 RID: 436
			[Token(Token = "0x40002DA")]
			None,
			// Token: 0x040001B5 RID: 437
			[Token(Token = "0x40002DB")]
			CheckBundle,
			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40002DC")]
			Loading,
			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40002DD")]
			Checking,
			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40002DE")]
			Done
		}
	}
}
