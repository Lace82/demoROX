using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework.Setting
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal sealed class SettingManager : ISettingManager, IModule
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x13E9170", Offset = "0x13E8570", VA = "0x1813E9170", Slot = "31")]
		public void OnInit()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2B9D5D0", Offset = "0x2B9C9D0", VA = "0x182B9D5D0", Slot = "32")]
		public void Shutdown()
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x1700004B")]
		public int Count
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x2B9D680", Offset = "0x2B9CA80", VA = "0x182B9D680", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2B9D450", Offset = "0x2B9C850", VA = "0x182B9D450", Slot = "5")]
		public void SetSettingHelper(ISettingHelper helper)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2B9CF00", Offset = "0x2B9C300", VA = "0x182B9CF00", Slot = "6")]
		public bool Load()
		{
			return default(bool);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2B9D020", Offset = "0x2B9C420", VA = "0x182B9D020", Slot = "7")]
		public bool Save()
		{
			return default(bool);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2B9C270", Offset = "0x2B9B670", VA = "0x182B9C270", Slot = "8")]
		public string[] GetAllSettingNames()
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2B9C190", Offset = "0x2B9B590", VA = "0x182B9C190", Slot = "9")]
		public void GetAllSettingNames(List<string> results)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2B9CE60", Offset = "0x2B9C260", VA = "0x182B9CE60", Slot = "10")]
		public bool HasSetting(string settingName)
		{
			return default(bool);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2B9CF80", Offset = "0x2B9C380", VA = "0x182B9CF80", Slot = "11")]
		public bool RemoveSetting(string settingName)
		{
			return default(bool);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2B9C110", Offset = "0x2B9B510", VA = "0x182B9C110", Slot = "12")]
		public void ClearAllSettings()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2B9C470", Offset = "0x2B9B870", VA = "0x182B9C470", Slot = "13")]
		public bool GetBool(string settingName)
		{
			return default(bool);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2B9C350", Offset = "0x2B9B750", VA = "0x182B9C350", Slot = "14")]
		public bool GetBool(string settingName, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2B9D0A0", Offset = "0x2B9C4A0", VA = "0x182B9D0A0", Slot = "15")]
		public void SetBool(string settingName, bool value)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2B9C770", Offset = "0x2B9BB70", VA = "0x182B9C770", Slot = "16")]
		public int GetInt(string settingName)
		{
			return 0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2B9C8A0", Offset = "0x2B9BCA0", VA = "0x182B9C8A0", Slot = "17")]
		public int GetInt(string settingName, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2B9D2A0", Offset = "0x2B9C6A0", VA = "0x182B9D2A0", Slot = "18")]
		public void SetInt(string settingName, int value)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2B9C510", Offset = "0x2B9B910", VA = "0x182B9C510", Slot = "19")]
		public float GetFloat(string settingName)
		{
			return 0f;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2B9C640", Offset = "0x2B9BA40", VA = "0x182B9C640", Slot = "20")]
		public float GetFloat(string settingName, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2B9D1A0", Offset = "0x2B9C5A0", VA = "0x182B9D1A0", Slot = "21")]
		public void SetFloat(string settingName, float value)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2B9CC00", Offset = "0x2B9C000", VA = "0x182B9CC00", Slot = "22")]
		public string GetString(string settingName)
		{
			return null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2B9CD30", Offset = "0x2B9C130", VA = "0x182B9CD30", Slot = "23")]
		public string GetString(string settingName, string defaultValue)
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2B9D4D0", Offset = "0x2B9C8D0", VA = "0x182B9D4D0", Slot = "24")]
		public void SetString(string settingName, string value)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000208")]
		public T GetObject<T>(string settingName)
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000209")]
		public T GetObject<T>(string settingName, T defaultObj)
		{
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2B9C9D0", Offset = "0x2B9BDD0", VA = "0x182B9C9D0", Slot = "27")]
		public object GetObject(Type objectType, string settingName)
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2B9CAB0", Offset = "0x2B9BEB0", VA = "0x182B9CAB0", Slot = "28")]
		public object GetObject(Type objectType, string settingName, object defaultObj)
		{
			return null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020C")]
		public void SetObject<T>(string settingName, T obj)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2B9D3A0", Offset = "0x2B9C7A0", VA = "0x182B9D3A0", Slot = "30")]
		public void SetObject(string settingName, object obj)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public SettingManager()
		{
		}

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x10")]
		private ISettingHelper _settingHelper;
	}
}
