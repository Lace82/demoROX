using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework.Setting
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public interface ISettingManager : IModule
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001D6 RID: 470
		[Token(Token = "0x1700004A")]
		int Count { [Token(Token = "0x60001D6")] get; }

		// Token: 0x060001D7 RID: 471
		[Token(Token = "0x60001D7")]
		void SetSettingHelper(ISettingHelper helper);

		// Token: 0x060001D8 RID: 472
		[Token(Token = "0x60001D8")]
		bool Load();

		// Token: 0x060001D9 RID: 473
		[Token(Token = "0x60001D9")]
		bool Save();

		// Token: 0x060001DA RID: 474
		[Token(Token = "0x60001DA")]
		string[] GetAllSettingNames();

		// Token: 0x060001DB RID: 475
		[Token(Token = "0x60001DB")]
		void GetAllSettingNames(List<string> results);

		// Token: 0x060001DC RID: 476
		[Token(Token = "0x60001DC")]
		bool HasSetting(string settingName);

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		bool RemoveSetting(string settingName);

		// Token: 0x060001DE RID: 478
		[Token(Token = "0x60001DE")]
		void ClearAllSettings();

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		bool GetBool(string settingName);

		// Token: 0x060001E0 RID: 480
		[Token(Token = "0x60001E0")]
		bool GetBool(string settingName, bool defaultValue);

		// Token: 0x060001E1 RID: 481
		[Token(Token = "0x60001E1")]
		void SetBool(string settingName, bool value);

		// Token: 0x060001E2 RID: 482
		[Token(Token = "0x60001E2")]
		int GetInt(string settingName);

		// Token: 0x060001E3 RID: 483
		[Token(Token = "0x60001E3")]
		int GetInt(string settingName, int defaultValue);

		// Token: 0x060001E4 RID: 484
		[Token(Token = "0x60001E4")]
		void SetInt(string settingName, int value);

		// Token: 0x060001E5 RID: 485
		[Token(Token = "0x60001E5")]
		float GetFloat(string settingName);

		// Token: 0x060001E6 RID: 486
		[Token(Token = "0x60001E6")]
		float GetFloat(string settingName, float defaultValue);

		// Token: 0x060001E7 RID: 487
		[Token(Token = "0x60001E7")]
		void SetFloat(string settingName, float value);

		// Token: 0x060001E8 RID: 488
		[Token(Token = "0x60001E8")]
		string GetString(string settingName);

		// Token: 0x060001E9 RID: 489
		[Token(Token = "0x60001E9")]
		string GetString(string settingName, string defaultValue);

		// Token: 0x060001EA RID: 490
		[Token(Token = "0x60001EA")]
		void SetString(string settingName, string value);

		// Token: 0x060001EB RID: 491
		[Token(Token = "0x60001EB")]
		T GetObject<T>(string settingName);

		// Token: 0x060001EC RID: 492
		[Token(Token = "0x60001EC")]
		T GetObject<T>(string settingName, T defaultObj);

		// Token: 0x060001ED RID: 493
		[Token(Token = "0x60001ED")]
		object GetObject(Type objectType, string settingName);

		// Token: 0x060001EE RID: 494
		[Token(Token = "0x60001EE")]
		object GetObject(Type objectType, string settingName, object defaultObj);

		// Token: 0x060001EF RID: 495
		[Token(Token = "0x60001EF")]
		void SetObject<T>(string settingName, T obj);

		// Token: 0x060001F0 RID: 496
		[Token(Token = "0x60001F0")]
		void SetObject(string settingName, object obj);
	}
}
