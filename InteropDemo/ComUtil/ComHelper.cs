﻿using System;
using System.Runtime.InteropServices;

namespace ComUtil {

    public static class ComHelper {

        public static readonly Guid UNKNOWN = Guid.Parse("00000000-0000-0000-c000-000000000046");

        [DllImport("ole32.dll", ExactSpelling = true, PreserveSig = false)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public static extern dynamic CoCreateInstance([In, MarshalAs(UnmanagedType.LPStruct)] Guid rclsid,
                                                        [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter,
                                                        CLSCTX dwClsContext,
                                                        [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid);

        public static dynamic CreateOutOfProcessComObject(Guid guid) {
            return CoCreateInstance(guid, null, CLSCTX.CLSCTX_LOCAL_SERVER, UNKNOWN);
        }
    }

    [Flags]
    public enum CLSCTX : uint {
        CLSCTX_INPROC_SERVER = 0x1,
        CLSCTX_INPROC_HANDLER = 0x2,
        CLSCTX_LOCAL_SERVER = 0x4,
        CLSCTX_INPROC_SERVER16 = 0x8,
        CLSCTX_REMOTE_SERVER = 0x10,
        CLSCTX_INPROC_HANDLER16 = 0x20,
        CLSCTX_RESERVED1 = 0x40,
        CLSCTX_RESERVED2 = 0x80,
        CLSCTX_RESERVED3 = 0x100,
        CLSCTX_RESERVED4 = 0x200,
        CLSCTX_NO_CODE_DOWNLOAD = 0x400,
        CLSCTX_RESERVED5 = 0x800,
        CLSCTX_NO_CUSTOM_MARSHAL = 0x1000,
        CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000,
        CLSCTX_NO_FAILURE_LOG = 0x4000,
        CLSCTX_DISABLE_AAA = 0x8000,
        CLSCTX_ENABLE_AAA = 0x10000,
        CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000,
        CLSCTX_ACTIVATE_32_BIT_SERVER = 0x40000,
        CLSCTX_ACTIVATE_64_BIT_SERVER = 0x80000,
        CLSCTX_INPROC = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER,
        CLSCTX_SERVER = CLSCTX_INPROC_SERVER | CLSCTX_LOCAL_SERVER | CLSCTX_REMOTE_SERVER,
        CLSCTX_ALL = CLSCTX_SERVER | CLSCTX_INPROC_HANDLER
    }
}
