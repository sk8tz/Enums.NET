﻿#region License
// Copyright (c) 2016 Tyler Brinkley
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Globalization;

namespace EnumsNET.Numerics
{
    internal struct Int16NumericProvider : INumericProvider<short>
    {
        public string ToHexidecimalString(short value) => value.ToString("X4");

        public string ToDecimalString(short value) => value.ToString();

        public short One => 1;

        public short Zero => 0;

        public short And(short left, short right) => (short)(left & right);

        public short Create(ulong value) => (short)value;

        public short Create(long value) => (short)value;

        public bool IsInValueRange(ulong value) => value <= (ulong)short.MaxValue;

        public bool IsInValueRange(long value) => value >= short.MinValue && value <= short.MaxValue;

        public short LeftShift(short value, int amount) => (short)(value << amount);

        public bool LessThan(short left, short right) => left < right;

        public short Not(short value) => (short)~value;

        public short Or(short left, short right) => (short)(left | right);

        public short Subtract(short left, short right) => (short)(left - right);

        public bool TryParseNumber(string s, NumberStyles style, IFormatProvider provider, out short result) => short.TryParse(s, style, provider, out result);

        public bool TryParseNative(string s, out short result) => short.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result);

        public short Xor(short left, short right) => (short)(left ^ right);

#if !ICONVERTIBLE
        public sbyte ToSByte(short value) => Convert.ToSByte(value);

        public byte ToByte(short value) => Convert.ToByte(value);

        public short ToInt16(short value) => value;

        public ushort ToUInt16(short value) => Convert.ToUInt16(value);

        public int ToInt32(short value) => value;

        public uint ToUInt32(short value) => Convert.ToUInt32(value);

        public long ToInt64(short value) => value;

        public ulong ToUInt64(short value) => Convert.ToUInt64(value);
#endif
    }
}
