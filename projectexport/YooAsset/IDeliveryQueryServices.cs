using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x2000097")]
	public interface IDeliveryQueryServices
	{
		// Token: 0x06000486 RID: 1158
		[Token(Token = "0x6000466")]
		bool Query(string packageName, string fileName, string fileCRC);

		// Token: 0x06000487 RID: 1159
		[Token(Token = "0x6000467")]
		string GetFilePath(string packageName, string fileName);
	}
}
