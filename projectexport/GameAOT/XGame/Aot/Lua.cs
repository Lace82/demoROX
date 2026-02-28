using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x2000132")]
	public class Lua
	{
		// Token: 0x06000B40 RID: 2880
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xEC5880", Offset = "0xEC4C80", VA = "0x180EC5880")]
		[PreserveSig]
		public static extern IntPtr lua_tothread(IntPtr L, int index);

		// Token: 0x06000B41 RID: 2881
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xEC6060", Offset = "0xEC5460", VA = "0x180EC6060")]
		[PreserveSig]
		public static extern int xlua_get_lib_version();

		// Token: 0x06000B42 RID: 2882
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xEC4060", Offset = "0xEC3460", VA = "0x180EC4060")]
		[PreserveSig]
		public static extern int lua_gc(IntPtr L, int what, int data);

		// Token: 0x06000B43 RID: 2883
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xEC4180", Offset = "0xEC3580", VA = "0x180EC4180")]
		[PreserveSig]
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06000B44 RID: 2884
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xEC5360", Offset = "0xEC4760", VA = "0x180EC5360")]
		[PreserveSig]
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06000B45 RID: 2885
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xEC4D30", Offset = "0xEC4130", VA = "0x180EC4D30")]
		[PreserveSig]
		public static extern int lua_pushthread(IntPtr L);

		// Token: 0x06000B46 RID: 2886 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xEC3890", Offset = "0xEC2C90", VA = "0x180EC3890")]
		public static int luaL_error(IntPtr L, string message)
		{
			return 0;
		}

		// Token: 0x06000B47 RID: 2887
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xEC51B0", Offset = "0xEC45B0", VA = "0x180EC51B0")]
		[PreserveSig]
		public static extern int lua_setfenv(IntPtr L, int stackPos);

		// Token: 0x06000B48 RID: 2888
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xEC3AE0", Offset = "0xEC2EE0", VA = "0x180EC3AE0")]
		[PreserveSig]
		public static extern IntPtr luaL_newstate();

		// Token: 0x06000B49 RID: 2889
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xEC3EC0", Offset = "0xEC32C0", VA = "0x180EC3EC0")]
		[PreserveSig]
		public static extern void lua_close(IntPtr L);

		// Token: 0x06000B4A RID: 2890
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xEC5D40", Offset = "0xEC5140", VA = "0x180EC5D40")]
		[PreserveSig]
		public static extern void luaopen_xlua(IntPtr L);

		// Token: 0x06000B4B RID: 2891
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xEC3B50", Offset = "0xEC2F50", VA = "0x180EC3B50")]
		[PreserveSig]
		public static extern void luaL_openlibs(IntPtr L);

		// Token: 0x06000B4C RID: 2892
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xEC6520", Offset = "0xEC5920", VA = "0x180EC6520")]
		[PreserveSig]
		public static extern uint xlua_objlen(IntPtr L, int stackPos);

		// Token: 0x06000B4D RID: 2893
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xEC3F40", Offset = "0xEC3340", VA = "0x180EC3F40")]
		[PreserveSig]
		public static extern void lua_createtable(IntPtr L, int narr, int nrec);

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xEC4580", Offset = "0xEC3980", VA = "0x180EC4580")]
		public static void lua_newtable(IntPtr L)
		{
		}

		// Token: 0x06000B4F RID: 2895
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xEC6140", Offset = "0xEC5540", VA = "0x180EC6140")]
		[PreserveSig]
		public static extern int xlua_getglobal(IntPtr L, string name);

		// Token: 0x06000B50 RID: 2896
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xEC7670", Offset = "0xEC6A70", VA = "0x180EC7670")]
		[PreserveSig]
		public static extern int xlua_setglobal(IntPtr L, string name);

		// Token: 0x06000B51 RID: 2897
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xEC61F0", Offset = "0xEC55F0", VA = "0x180EC61F0")]
		[PreserveSig]
		public static extern void xlua_getloaders(IntPtr L);

		// Token: 0x06000B52 RID: 2898
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xEC52D0", Offset = "0xEC46D0", VA = "0x180EC52D0")]
		[PreserveSig]
		public static extern void lua_settop(IntPtr L, int newTop);

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xEC4730", Offset = "0xEC3B30", VA = "0x180EC4730")]
		public static void lua_pop(IntPtr L, int amount)
		{
		}

		// Token: 0x06000B54 RID: 2900
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xEC4220", Offset = "0xEC3620", VA = "0x180EC4220")]
		[PreserveSig]
		public static extern void lua_insert(IntPtr L, int newTop);

		// Token: 0x06000B55 RID: 2901
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xEC5090", Offset = "0xEC4490", VA = "0x180EC5090")]
		[PreserveSig]
		public static extern void lua_remove(IntPtr L, int index);

		// Token: 0x06000B56 RID: 2902
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xEC4F70", Offset = "0xEC4370", VA = "0x180EC4F70")]
		[PreserveSig]
		public static extern int lua_rawget(IntPtr L, int index);

		// Token: 0x06000B57 RID: 2903
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xEC5000", Offset = "0xEC4400", VA = "0x180EC5000")]
		[PreserveSig]
		public static extern void lua_rawset(IntPtr L, int index);

		// Token: 0x06000B58 RID: 2904
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xEC5240", Offset = "0xEC4640", VA = "0x180EC5240")]
		[PreserveSig]
		public static extern int lua_setmetatable(IntPtr L, int objIndex);

		// Token: 0x06000B59 RID: 2905
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xEC4ED0", Offset = "0xEC42D0", VA = "0x180EC4ED0")]
		[PreserveSig]
		public static extern int lua_rawequal(IntPtr L, int index1, int index2);

		// Token: 0x06000B5A RID: 2906
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xEC4E40", Offset = "0xEC4240", VA = "0x180EC4E40")]
		[PreserveSig]
		public static extern void lua_pushvalue(IntPtr L, int index);

		// Token: 0x06000B5B RID: 2907
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xEC4850", Offset = "0xEC3C50", VA = "0x180EC4850")]
		[PreserveSig]
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n);

		// Token: 0x06000B5C RID: 2908
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xEC5120", Offset = "0xEC4520", VA = "0x180EC5120")]
		[PreserveSig]
		public static extern void lua_replace(IntPtr L, int index);

		// Token: 0x06000B5D RID: 2909
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xEC4100", Offset = "0xEC3500", VA = "0x180EC4100")]
		[PreserveSig]
		public static extern int lua_gettop(IntPtr L);

		// Token: 0x06000B5E RID: 2910
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xEC5A30", Offset = "0xEC4E30", VA = "0x180EC5A30")]
		[PreserveSig]
		public static extern int lua_type(IntPtr L, int index);

		// Token: 0x06000B5F RID: 2911
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xEC43D0", Offset = "0xEC37D0", VA = "0x180EC43D0")]
		[PreserveSig]
		public static extern bool lua_isnumber(IntPtr L, int index);

		// Token: 0x06000B60 RID: 2912
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xEC3BD0", Offset = "0xEC2FD0", VA = "0x180EC3BD0")]
		[PreserveSig]
		public static extern int luaL_ref(IntPtr L, int registryIndex);

		// Token: 0x06000B61 RID: 2913
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xEC7530", Offset = "0xEC6930", VA = "0x180EC7530")]
		[PreserveSig]
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index);

		// Token: 0x06000B62 RID: 2914
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xEC75D0", Offset = "0xEC69D0", VA = "0x180EC75D0")]
		[PreserveSig]
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index);

		// Token: 0x06000B63 RID: 2915
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xEC5DC0", Offset = "0xEC51C0", VA = "0x180EC5DC0")]
		[PreserveSig]
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref);

		// Token: 0x06000B64 RID: 2916
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xEC3C60", Offset = "0xEC3060", VA = "0x180EC3C60")]
		[PreserveSig]
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference);

		// Token: 0x06000B65 RID: 2917
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xEC4460", Offset = "0xEC3860", VA = "0x180EC4460")]
		[PreserveSig]
		public static extern bool lua_isstring(IntPtr L, int index);

		// Token: 0x06000B66 RID: 2918
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xEC4340", Offset = "0xEC3740", VA = "0x180EC4340")]
		[PreserveSig]
		public static extern bool lua_isinteger(IntPtr L, int index);

		// Token: 0x06000B67 RID: 2919
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xEC4A10", Offset = "0xEC3E10", VA = "0x180EC4A10")]
		[PreserveSig]
		public static extern void lua_pushnil(IntPtr L);

		// Token: 0x06000B68 RID: 2920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xEC4B20", Offset = "0xEC3F20", VA = "0x180EC4B20")]
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0)
		{
		}

		// Token: 0x06000B69 RID: 2921
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xEC82F0", Offset = "0xEC76F0", VA = "0x180EC82F0")]
		[PreserveSig]
		public static extern int xlua_upvalueindex(int n);

		// Token: 0x06000B6A RID: 2922
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xEC4690", Offset = "0xEC3A90", VA = "0x180EC4690")]
		[PreserveSig]
		public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc);

		// Token: 0x06000B6B RID: 2923
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xEC55C0", Offset = "0xEC49C0", VA = "0x180EC55C0")]
		[PreserveSig]
		public static extern double lua_tonumber(IntPtr L, int index);

		// Token: 0x06000B6C RID: 2924
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xEC78B0", Offset = "0xEC6CB0", VA = "0x180EC78B0")]
		[PreserveSig]
		public static extern int xlua_tointeger(IntPtr L, int index);

		// Token: 0x06000B6D RID: 2925
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xEC7940", Offset = "0xEC6D40", VA = "0x180EC7940")]
		[PreserveSig]
		public static extern uint xlua_touint(IntPtr L, int index);

		// Token: 0x06000B6E RID: 2926
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xEC5400", Offset = "0xEC4800", VA = "0x180EC5400")]
		[PreserveSig]
		public static extern bool lua_toboolean(IntPtr L, int index);

		// Token: 0x06000B6F RID: 2927
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xEC5650", Offset = "0xEC4A50", VA = "0x180EC5650")]
		[PreserveSig]
		public static extern IntPtr lua_topointer(IntPtr L, int index);

		// Token: 0x06000B70 RID: 2928
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xEC5520", Offset = "0xEC4920", VA = "0x180EC5520")]
		[PreserveSig]
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen);

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xEC56E0", Offset = "0xEC4AE0", VA = "0x180EC56E0")]
		public static string lua_tostring(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x06000B72 RID: 2930
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xEC3D90", Offset = "0xEC3190", VA = "0x180EC3D90")]
		[PreserveSig]
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf);

		// Token: 0x06000B73 RID: 2931
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xEC4A90", Offset = "0xEC3E90", VA = "0x180EC4A90")]
		[PreserveSig]
		public static extern void lua_pushnumber(IntPtr L, double number);

		// Token: 0x06000B74 RID: 2932
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xEC47C0", Offset = "0xEC3BC0", VA = "0x180EC47C0")]
		[PreserveSig]
		public static extern void lua_pushboolean(IntPtr L, bool value);

		// Token: 0x06000B75 RID: 2933
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xEC72D0", Offset = "0xEC66D0", VA = "0x180EC72D0")]
		[PreserveSig]
		public static extern void xlua_pushinteger(IntPtr L, int value);

		// Token: 0x06000B76 RID: 2934
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xEC74A0", Offset = "0xEC68A0", VA = "0x180EC74A0")]
		[PreserveSig]
		public static extern void xlua_pushuint(IntPtr L, uint value);

		// Token: 0x06000B77 RID: 2935
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xEC7360", Offset = "0xEC6760", VA = "0x180EC7360")]
		[PreserveSig]
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size);

		// Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xEC4C10", Offset = "0xEC4010", VA = "0x180EC4C10")]
		public static void lua_pushstring(IntPtr L, byte[] str)
		{
		}

		// Token: 0x06000B79 RID: 2937
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xEC3A30", Offset = "0xEC2E30", VA = "0x180EC3A30")]
		[PreserveSig]
		public static extern int luaL_newmetatable(IntPtr L, string meta);

		// Token: 0x06000B7A RID: 2938
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xEC6F00", Offset = "0xEC6300", VA = "0x180EC6F00")]
		[PreserveSig]
		public static extern int xlua_pgettable(IntPtr L, int idx);

		// Token: 0x06000B7B RID: 2939
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xEC7050", Offset = "0xEC6450", VA = "0x180EC7050")]
		[PreserveSig]
		public static extern int xlua_psettable(IntPtr L, int idx);

		// Token: 0x06000B7C RID: 2940
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xEC5E60", Offset = "0xEC5260", VA = "0x180EC5E60")]
		[PreserveSig]
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name);

		// Token: 0x06000B7D RID: 2941 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xEC3930", Offset = "0xEC2D30", VA = "0x180EC3930")]
		public static int luaL_loadbuffer(IntPtr L, string buff, string name)
		{
			return 0;
		}

		// Token: 0x06000B7E RID: 2942
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xEC7820", Offset = "0xEC6C20", VA = "0x180EC7820")]
		[PreserveSig]
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj);

		// Token: 0x06000B7F RID: 2943
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xEC7790", Offset = "0xEC6B90", VA = "0x180EC7790")]
		[PreserveSig]
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj);

		// Token: 0x06000B80 RID: 2944 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xEC3FE0", Offset = "0xEC33E0", VA = "0x180EC3FE0")]
		public static int lua_error(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06000B81 RID: 2945
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xEC3E30", Offset = "0xEC3230", VA = "0x180EC3E30")]
		[PreserveSig]
		public static extern bool lua_checkstack(IntPtr L, int extra);

		// Token: 0x06000B82 RID: 2946
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xEC4600", Offset = "0xEC3A00", VA = "0x180EC4600")]
		[PreserveSig]
		public static extern int lua_next(IntPtr L, int index);

		// Token: 0x06000B83 RID: 2947
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xEC4980", Offset = "0xEC3D80", VA = "0x180EC4980")]
		[PreserveSig]
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata);

		// Token: 0x06000B84 RID: 2948
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xEC7720", Offset = "0xEC6B20", VA = "0x180EC7720")]
		[PreserveSig]
		public static extern IntPtr xlua_tag();

		// Token: 0x06000B85 RID: 2949
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xEC3D00", Offset = "0xEC3100", VA = "0x180EC3D00")]
		[PreserveSig]
		public static extern void luaL_where(IntPtr L, int level);

		// Token: 0x06000B86 RID: 2950
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xEC79D0", Offset = "0xEC6DD0", VA = "0x180EC79D0")]
		[PreserveSig]
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref);

		// Token: 0x06000B87 RID: 2951
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xEC7180", Offset = "0xEC6580", VA = "0x180EC7180")]
		[PreserveSig]
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref);

		// Token: 0x06000B88 RID: 2952
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xEC3680", Offset = "0xEC2A80", VA = "0x180EC3680")]
		[PreserveSig]
		public static extern int gen_obj_indexer(IntPtr L);

		// Token: 0x06000B89 RID: 2953
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xEC3700", Offset = "0xEC2B00", VA = "0x180EC3700")]
		[PreserveSig]
		public static extern int gen_obj_newindexer(IntPtr L);

		// Token: 0x06000B8A RID: 2954
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xEC3580", Offset = "0xEC2980", VA = "0x180EC3580")]
		[PreserveSig]
		public static extern int gen_cls_indexer(IntPtr L);

		// Token: 0x06000B8B RID: 2955
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xEC3600", Offset = "0xEC2A00", VA = "0x180EC3600")]
		[PreserveSig]
		public static extern int gen_cls_newindexer(IntPtr L);

		// Token: 0x06000B8C RID: 2956
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xEC3780", Offset = "0xEC2B80", VA = "0x180EC3780")]
		[PreserveSig]
		public static extern int get_error_func_ref(IntPtr L);

		// Token: 0x06000B8D RID: 2957
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xEC3800", Offset = "0xEC2C00", VA = "0x180EC3800")]
		[PreserveSig]
		public static extern int load_error_func(IntPtr L, int Ref);

		// Token: 0x06000B8E RID: 2958
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xEC5BC0", Offset = "0xEC4FC0", VA = "0x180EC5BC0")]
		[PreserveSig]
		public static extern int luaopen_i64lib(IntPtr L);

		// Token: 0x06000B8F RID: 2959
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xEC5CC0", Offset = "0xEC50C0", VA = "0x180EC5CC0")]
		[PreserveSig]
		public static extern int luaopen_socket_core(IntPtr L);

		// Token: 0x06000B90 RID: 2960
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xEC48F0", Offset = "0xEC3CF0", VA = "0x180EC48F0")]
		[PreserveSig]
		public static extern void lua_pushint64(IntPtr L, long n);

		// Token: 0x06000B91 RID: 2961
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xEC4DB0", Offset = "0xEC41B0", VA = "0x180EC4DB0")]
		[PreserveSig]
		public static extern void lua_pushuint64(IntPtr L, ulong n);

		// Token: 0x06000B92 RID: 2962
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xEC42B0", Offset = "0xEC36B0", VA = "0x180EC42B0")]
		[PreserveSig]
		public static extern bool lua_isint64(IntPtr L, int idx);

		// Token: 0x06000B93 RID: 2963
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xEC44F0", Offset = "0xEC38F0", VA = "0x180EC44F0")]
		[PreserveSig]
		public static extern bool lua_isuint64(IntPtr L, int idx);

		// Token: 0x06000B94 RID: 2964
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xEC5490", Offset = "0xEC4890", VA = "0x180EC5490")]
		[PreserveSig]
		public static extern long lua_toint64(IntPtr L, int idx);

		// Token: 0x06000B95 RID: 2965
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xEC5910", Offset = "0xEC4D10", VA = "0x180EC5910")]
		[PreserveSig]
		public static extern ulong lua_touint64(IntPtr L, int idx);

		// Token: 0x06000B96 RID: 2966
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xEC70E0", Offset = "0xEC64E0", VA = "0x180EC70E0")]
		[PreserveSig]
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n);

		// Token: 0x06000B97 RID: 2967
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xEC5FB0", Offset = "0xEC53B0", VA = "0x180EC5FB0")]
		[PreserveSig]
		public static extern int xlua_csharp_str_error(IntPtr L, string message);

		// Token: 0x06000B98 RID: 2968
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xEC5F30", Offset = "0xEC5330", VA = "0x180EC5F30")]
		[PreserveSig]
		public static extern int xlua_csharp_error(IntPtr L);

		// Token: 0x06000B99 RID: 2969
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xEC6DA0", Offset = "0xEC61A0", VA = "0x180EC6DA0")]
		[PreserveSig]
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field);

		// Token: 0x06000B9A RID: 2970
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xEC8250", Offset = "0xEC7650", VA = "0x180EC8250")]
		[PreserveSig]
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field);

		// Token: 0x06000B9B RID: 2971
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xEC6BC0", Offset = "0xEC5FC0", VA = "0x180EC6BC0")]
		[PreserveSig]
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field);

		// Token: 0x06000B9C RID: 2972
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xEC8070", Offset = "0xEC7470", VA = "0x180EC8070")]
		[PreserveSig]
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field);

		// Token: 0x06000B9D RID: 2973
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xEC6C60", Offset = "0xEC6060", VA = "0x180EC6C60")]
		[PreserveSig]
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field);

		// Token: 0x06000B9E RID: 2974
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xEC8110", Offset = "0xEC7510", VA = "0x180EC8110")]
		[PreserveSig]
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field);

		// Token: 0x06000B9F RID: 2975
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xEC6D00", Offset = "0xEC6100", VA = "0x180EC6D00")]
		[PreserveSig]
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field);

		// Token: 0x06000BA0 RID: 2976
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xEC81B0", Offset = "0xEC75B0", VA = "0x180EC81B0")]
		[PreserveSig]
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field);

		// Token: 0x06000BA1 RID: 2977
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xEC6B20", Offset = "0xEC5F20", VA = "0x180EC6B20")]
		[PreserveSig]
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field);

		// Token: 0x06000BA2 RID: 2978
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xEC7FD0", Offset = "0xEC73D0", VA = "0x180EC7FD0")]
		[PreserveSig]
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field);

		// Token: 0x06000BA3 RID: 2979
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xEC6650", Offset = "0xEC5A50", VA = "0x180EC6650")]
		[PreserveSig]
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field);

		// Token: 0x06000BA4 RID: 2980
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xEC7B40", Offset = "0xEC6F40", VA = "0x180EC7B40")]
		[PreserveSig]
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field);

		// Token: 0x06000BA5 RID: 2981
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xEC7400", Offset = "0xEC6800", VA = "0x180EC7400")]
		[PreserveSig]
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref);

		// Token: 0x06000BA6 RID: 2982
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xEC7230", Offset = "0xEC6630", VA = "0x180EC7230")]
		[PreserveSig]
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref);

		// Token: 0x06000BA7 RID: 2983
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xEC59A0", Offset = "0xEC4DA0", VA = "0x180EC59A0")]
		[PreserveSig]
		public static extern IntPtr lua_touserdata(IntPtr L, int idx);

		// Token: 0x06000BA8 RID: 2984
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xEC6270", Offset = "0xEC5670", VA = "0x180EC6270")]
		[PreserveSig]
		public static extern int xlua_gettypeid(IntPtr L, int idx);

		// Token: 0x06000BA9 RID: 2985
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xEC60D0", Offset = "0xEC54D0", VA = "0x180EC60D0")]
		[PreserveSig]
		public static extern int xlua_get_registry_index();

		// Token: 0x06000BAA RID: 2986
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xEC6E40", Offset = "0xEC6240", VA = "0x180EC6E40")]
		[PreserveSig]
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x06000BAB RID: 2987
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xEC6F90", Offset = "0xEC6390", VA = "0x180EC6F90")]
		[PreserveSig]
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x06000BAC RID: 2988
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xEC66F0", Offset = "0xEC5AF0", VA = "0x180EC66F0")]
		[PreserveSig]
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2);

		// Token: 0x06000BAD RID: 2989
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xEC7BE0", Offset = "0xEC6FE0", VA = "0x180EC7BE0")]
		[PreserveSig]
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2);

		// Token: 0x06000BAE RID: 2990
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xEC67A0", Offset = "0xEC5BA0", VA = "0x180EC67A0")]
		[PreserveSig]
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3);

		// Token: 0x06000BAF RID: 2991
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xEC7C90", Offset = "0xEC7090", VA = "0x180EC7C90")]
		[PreserveSig]
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3);

		// Token: 0x06000BB0 RID: 2992
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xEC6870", Offset = "0xEC5C70", VA = "0x180EC6870")]
		[PreserveSig]
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4);

		// Token: 0x06000BB1 RID: 2993
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xEC7D50", Offset = "0xEC7150", VA = "0x180EC7D50")]
		[PreserveSig]
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4);

		// Token: 0x06000BB2 RID: 2994
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xEC6950", Offset = "0xEC5D50", VA = "0x180EC6950")]
		[PreserveSig]
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5);

		// Token: 0x06000BB3 RID: 2995
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xEC7E20", Offset = "0xEC7220", VA = "0x180EC7E20")]
		[PreserveSig]
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5);

		// Token: 0x06000BB4 RID: 2996
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xEC6A30", Offset = "0xEC5E30", VA = "0x180EC6A30")]
		[PreserveSig]
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6);

		// Token: 0x06000BB5 RID: 2997
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xEC7EF0", Offset = "0xEC72F0", VA = "0x180EC7EF0")]
		[PreserveSig]
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6);

		// Token: 0x06000BB6 RID: 2998
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xEC65B0", Offset = "0xEC59B0", VA = "0x180EC65B0")]
		[PreserveSig]
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec);

		// Token: 0x06000BB7 RID: 2999
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xEC7A70", Offset = "0xEC6E70", VA = "0x180EC7A70")]
		[PreserveSig]
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64);

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xEC6380", Offset = "0xEC5780", VA = "0x180EC6380")]
		public static bool xlua_is_eq_str(IntPtr L, int index, string str)
		{
			return default(bool);
		}

		// Token: 0x06000BB9 RID: 3001
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xEC6460", Offset = "0xEC5860", VA = "0x180EC6460")]
		[PreserveSig]
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len);

		// Token: 0x06000BBA RID: 3002
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xEC6300", Offset = "0xEC5700", VA = "0x180EC6300")]
		[PreserveSig]
		public static extern IntPtr xlua_gl(IntPtr L);

		// Token: 0x06000BBB RID: 3003
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xEC5C40", Offset = "0xEC5040", VA = "0x180EC5C40")]
		[PreserveSig]
		public static extern int luaopen_pb(IntPtr L);

		// Token: 0x06000BBC RID: 3004
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xEC5AC0", Offset = "0xEC4EC0", VA = "0x180EC5AC0")]
		[PreserveSig]
		public static extern int luaopen_cjson(IntPtr L);

		// Token: 0x06000BBD RID: 3005
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xEC5B40", Offset = "0xEC4F40", VA = "0x180EC5B40")]
		[PreserveSig]
		public static extern int luaopen_cjson_safe(IntPtr L);

		// Token: 0x06000BBE RID: 3006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public Lua()
		{
		}

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x40004B8")]
		private const string LUADLL = "xlua";
	}
}
