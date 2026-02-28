using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework.Setting
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public interface ISettingHelper
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001BB RID: 443
		[Token(Token = "0x17000049")]
		int Count { [Token(Token = "0x60001BB")] get; }

		// Token: 0x060001BC RID: 444
		[Token(Token = "0x60001BC")]
		void Shutdown();

		// Token: 0x060001BD RID: 445
		[Token(Token = "0x60001BD")]
		bool Load();

		// Token: 0x060001BE RID: 446
		[Token(Token = "0x60001BE")]
		bool Save();

		// Token: 0x060001BF RID: 447
		[Token(Token = "0x60001BF")]
		string[] GetAllSettingNames();

		// Token: 0x060001C0 RID: 448
		[Token(Token = "0x60001C0")]
		void GetAllSettingNames(List<string> results);

		// Token: 0x060001C1 RID: 449
		[Token(Token = "0x60001C1")]
		bool HasSetting(string settingName);

		// Token: 0x060001C2 RID: 450
		[Token(Token = "0x60001C2")]
		bool RemoveSetting(string settingName);

		// Token: 0x060001C3 RID: 451
		[Token(Token = "0x60001C3")]
		void ClearAllSettings();

		// Token: 0x060001C4 RID: 452
		[Token(Token = "0x60001C4")]
		bool GetBool(string settingName);

		// Token: 0x060001C5 RID: 453
		[Token(Token = "0x60001C5")]
		bool GetBool(string settingName, bool defaultValue);

		// Token: 0x060001C6 RID: 454
		[Token(Token = "0x60001C6")]
		void SetBool(string settingName, bool value);

		// Token: 0x060001C7 RID: 455
		[Token(Token = "0x60001C7")]
		int GetInt(string settingName);

		// Token: 0x060001C8 RID: 456
		[Token(Token = "0x60001C8")]
		int GetInt(string settingName, int defaultValue);

		// Token: 0x060001C9 RID: 457
		[Token(Token = "0x60001C9")]
		void SetInt(string settingName, int value);

		// Token: 0x060001CA RID: 458
		[Token(Token = "0x60001CA")]
		float GetFloat(string settingName);

		// Token: 0x060001CB RID: 459
		[Token(Token = "0x60001CB")]
		float GetFloat(string settingName, float defaultValue);

		// Token: 0x060001CC RID: 460
		[Token(Token = "0x60001CC")]
		void SetFloat(string settingName, float value);

		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		string GetString(string settingName);

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		string GetString(string settingName, string defaultValue);

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		void SetString(string settingName, string value);

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		T GetObject<T>(string settingName);

		// Token: 0x060001D1 RID: 465
		[Token(Token = "0x60001D1")]
		T GetObject<T>(string settingName, T defaultObj);

		// Token: 0x060001D2 RID: 466
		[Token(Token = "0x60001D2")]
		object GetObject(Type objectType, string settingName);

		// Token: 0x060001D3 RID: 467
		[Token(Token = "0x60001D3")]
		object GetObject(Type objectType, string settingName, object defaultObj);

		// Token: 0x060001D4 RID: 468
		[Token(Token = "0x60001D4")]
		void SetObject<T>(string settingName, T obj);

		// Token: 0x060001D5 RID: 469
		[Token(Token = "0x60001D5")]
		void SetObject(string settingName, object obj);
	}
}
