using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public abstract class Variable<T> : Variable
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E6")]
		public Variable()
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700002D")]
		public override Type Type
		{
			[Token(Token = "0x60000E7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public T Value
		{
			[Token(Token = "0x60000E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000EA")]
		public override object GetValue()
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		public override void SetValue(object value)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		public override void Clear()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000ED")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private T <Value>k__BackingField;
	}
}
