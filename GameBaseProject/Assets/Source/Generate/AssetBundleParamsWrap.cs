﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class AssetBundleParamsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(AssetBundleParams), typeof(System.Object));
		L.RegFunction("New", _CreateAssetBundleParams);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("path", get_path, set_path);
		L.RegVar("type", get_type, set_type);
		L.RegVar("IsSort", get_IsSort, set_IsSort);
		L.RegVar("parentGoQueue", get_parentGoQueue, set_parentGoQueue);
		L.RegVar("assetInMemoryType", get_assetInMemoryType, set_assetInMemoryType);
		L.RegVar("callbackActQueue", get_callbackActQueue, set_callbackActQueue);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAssetBundleParams(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				System.Type arg1 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
				AssetBundleParams obj = new AssetBundleParams(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: AssetBundleParams.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_path(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			string ret = obj.path;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index path on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			System.Type ret = obj.type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSort(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			bool ret = obj.IsSort;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsSort on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parentGoQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			System.Collections.Generic.Queue<UnityEngine.GameObject> ret = obj.parentGoQueue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index parentGoQueue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_assetInMemoryType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			AssetInMemoryType ret = obj.assetInMemoryType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index assetInMemoryType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_callbackActQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			System.Collections.Generic.Queue<System.Action<UnityEngine.GameObject,UnityEngine.GameObject>> ret = obj.callbackActQueue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index callbackActQueue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_path(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.path = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index path on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
			obj.type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsSort(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsSort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsSort on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_parentGoQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			System.Collections.Generic.Queue<UnityEngine.GameObject> arg0 = (System.Collections.Generic.Queue<UnityEngine.GameObject>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Queue<UnityEngine.GameObject>));
			obj.parentGoQueue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index parentGoQueue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_assetInMemoryType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			AssetInMemoryType arg0 = (AssetInMemoryType)ToLua.CheckObject(L, 2, typeof(AssetInMemoryType));
			obj.assetInMemoryType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index assetInMemoryType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_callbackActQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			AssetBundleParams obj = (AssetBundleParams)o;
			System.Collections.Generic.Queue<System.Action<UnityEngine.GameObject,UnityEngine.GameObject>> arg0 = (System.Collections.Generic.Queue<System.Action<UnityEngine.GameObject,UnityEngine.GameObject>>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Queue<System.Action<UnityEngine.GameObject,UnityEngine.GameObject>>));
			obj.callbackActQueue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index callbackActQueue on a nil value" : e.Message);
		}
	}
}

