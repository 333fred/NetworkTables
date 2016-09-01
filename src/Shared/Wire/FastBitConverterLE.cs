using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NetworkTables.Wire
{
    internal class FastBitConverterLE : IFastBitConverter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddUShort(List<byte> list, ushort val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddShort(List<byte> list, short val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddUInt(List<byte> list, uint val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[3]);
                list.Add(v[2]);
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddInt(List<byte> list, int val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[3]);
                list.Add(v[2]);
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddULong(List<byte> list, ulong val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[7]);
                list.Add(v[6]);
                list.Add(v[5]);
                list.Add(v[4]);
                list.Add(v[3]);
                list.Add(v[2]);
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddLong(List<byte> list, long val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[7]);
                list.Add(v[6]);
                list.Add(v[5]);
                list.Add(v[4]);
                list.Add(v[3]);
                list.Add(v[2]);
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddFloat(List<byte> list, float val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[3]);
                list.Add(v[2]);
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [System.Security.SecuritySafeCritical]
        public void AddDouble(List<byte> list, double val)
        {
            unsafe
            {
                byte* v = (byte*)&val;
                list.Add(v[7]);
                list.Add(v[6]);
                list.Add(v[5]);
                list.Add(v[4]);
                list.Add(v[3]);
                list.Add(v[2]);
                list.Add(v[1]);
                list.Add(v[0]);
            }
        }
    }
}
