using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGameFramework.Utils;

namespace XGame.Aot
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000100")]
	public class LocalizationManager : Singleton<LocalizationManager>
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000044E8 File Offset: 0x000026E8
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public int CurrentLang
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0xB9A920", Offset = "0xB99D20", VA = "0x180B9A920")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0xEC34F0", Offset = "0xEC28F0", VA = "0x180EC34F0")]
			private set
			{
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091A")]
		[Address(RVA = "0xEC2F70", Offset = "0xEC2370", VA = "0x180EC2F70", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091B")]
		[Address(RVA = "0xEC2BD0", Offset = "0xEC1FD0", VA = "0x180EC2BD0")]
		private void InitLocalizationProfile()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091C")]
		[Address(RVA = "0xEC31D0", Offset = "0xEC25D0", VA = "0x180EC31D0")]
		public void SetCurrentLang(int id)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091D")]
		[Address(RVA = "0xEC22B0", Offset = "0xEC16B0", VA = "0x180EC22B0")]
		public string GetCurrentLangKey()
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091E")]
		[Address(RVA = "0xEC2830", Offset = "0xEC1C30", VA = "0x180EC2830")]
		public string GetLanPrefix()
		{
			return null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091F")]
		[Address(RVA = "0xEC27E0", Offset = "0xEC1BE0", VA = "0x180EC27E0")]
		public string GetLanPrefixRes()
		{
			return null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000920")]
		[Address(RVA = "0xEC2750", Offset = "0xEC1B50", VA = "0x180EC2750")]
		public int GetIdByLangKey(string key)
		{
			return 0;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000921")]
		[Address(RVA = "0xEC2880", Offset = "0xEC1C80", VA = "0x180EC2880")]
		public string GetLangKeyById(int id)
		{
			return null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000922")]
		[Address(RVA = "0xEC3290", Offset = "0xEC2690", VA = "0x180EC3290")]
		public string ToLanResourcePath(string path)
		{
			return null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000923")]
		[Address(RVA = "0xEC31E0", Offset = "0xEC25E0", VA = "0x180EC31E0")]
		public string ToLanConfigPath(string path)
		{
			return null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000924")]
		[Address(RVA = "0xEC2DB0", Offset = "0xEC21B0", VA = "0x180EC2DB0")]
		public bool IsStartWithPrefix(string shortPath)
		{
			return default(bool);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000925")]
		[Address(RVA = "0xEC2910", Offset = "0xEC1D10", VA = "0x180EC2910")]
		public List<LocaleIdentifier> GetLocalesList()
		{
			return null;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000926")]
		[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
		public Dictionary<int, LocaleIdentifier> GetLocalesMap()
		{
			return null;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x6000927")]
		[Address(RVA = "0xEC3340", Offset = "0xEC2740", VA = "0x180EC3340")]
		private bool ValidLanguageKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000928")]
		[Address(RVA = "0xEC29D0", Offset = "0xEC1DD0", VA = "0x180EC29D0")]
		private string GetSystemLocaleKey()
		{
			return null;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000929")]
		[Address(RVA = "0xEC2300", Offset = "0xEC1700", VA = "0x180EC2300")]
		public string GetDefaultLanguageKey()
		{
			return null;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092A")]
		[Address(RVA = "0xEC34B0", Offset = "0xEC28B0", VA = "0x180EC34B0")]
		public LocalizationManager()
		{
		}

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x400048E")]
		private const string K_PREFS_KEY_LANGUAGE_ID = "UserSavedLanguageKeyNew_2";

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x400048F")]
		private const string K_PREFS_KEY_DEVICE_LANGUAGE_ID = "DeviceLanguageKey";

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x4000490")]
		private const string K_DEFAULT_LANGUAGE_KEY = "en";

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x4000491")]
		private const string K_DEFAULT_LANGUAGE_PREFIX_CFG = "EN";

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x4000492")]
		private const string K_DEFAULT_LANGUAGE_PREFIX_RES = "Localization/EN";

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x10")]
		private LocaleIdentifier _activeLocale;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x18")]
		private int _currentLang;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, LocaleIdentifier> _localesMap;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, int> _localesKeyIDMapping;
	}
}
