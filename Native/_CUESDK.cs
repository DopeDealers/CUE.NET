﻿using System;
using System.Runtime.InteropServices;
using CUE.NET.Enums;

namespace CUE.NET.Native
{
    // ReSharper disable once InconsistentNaming
    internal static class _CUESDK
    {
#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // set specified leds to some colors. The color is retained until changed by successive calls. This function does not take logical layout into account
        public static extern bool CorsairSetLedsColors(int size, IntPtr ledsColors);

        //#if WIN64
        //        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
        //#else
        //        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
        //#endif
        //public static extern bool CorsairSetLedsColorsAsync(int size, CorsairLedColor* ledsColors, void(*CallbackType)(void*, bool, CorsairError), void* context);

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // returns number of connected Corsair devices that support lighting control.
        public static extern int CorsairGetDeviceCount();

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // returns information about device at provided index
        public static extern IntPtr CorsairGetDeviceInfo(int deviceIndex);

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // provides list of keyboard LEDs with their physical positions.
        public static extern IntPtr CorsairGetLedPositions();

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // retrieves led id for key name taking logical layout into account.
        public static extern int CorsairGetLedIdForKeyName(char keyName);

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        //  requestes control using specified access mode. By default client has shared control over lighting so there is no need to call CorsairRequestControl unless client requires exclusive control
        public static extern bool CorsairRequestControl(CorsairAccessMode accessMode);

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // checks file and protocol version of CUE to understand which of SDK functions can be used with this version of CUE
        public static extern _CorsairProtocolDetails CorsairPerformProtocolHandshake();

#if WIN64
        [DllImport("CUESDK.x64_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#else
        [DllImport("CUESDK_2013.dll", CallingConvention = CallingConvention.Cdecl)]
#endif
        // returns last error that occured while using any of Corsair* functions
        public static extern CorsairError CorsairGetLastError();
    }
}
