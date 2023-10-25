// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ============================================= THIS FILE IS AUTOGENERATED ============================================
// =============================== Please make any edits in eng/pointergen/Generator.cs! ===============================
// ============================================= THIS FILE IS AUTOGENERATED ============================================

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using InlineIL;

namespace Silk.NET.Core;

/// <summary>
/// A single dimension pointer wrapper
/// </summary>
public unsafe readonly ref struct PtrRef<T, BaseType>
    where T : unmanaged
    where BaseType : unmanaged
{
    /// <summary>
    /// Creates a pointer with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public PtrRef(ref T @Ref)
    {
        this.Ref = ref @Ref;
    }

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref T Ref;

    /// <summary>
    /// Gets the item at the given offset from this pointer.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref T this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get => ref Unsafe.Add(ref Ref, index);
    }

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="PtrRef{T, BaseType}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref T GetPinnableReference() => ref Ref;

    /// <summary>
    /// Creates a span with the given length from this pointer.
    /// </summary>
    /// <param name="length">the span length</param>
    /// <returns>the span</returns>
    public Span<T> AsSpan(int length) => MemoryMarshal.CreateSpan(ref Ref, length);

    /// <summary>
    /// Determines if this <see cref="PtrRef{T, BaseType}"/> equals another object
    /// Always returns false as ref structs cannot be passed in, meaning this will never be true
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Whether this object is the same as </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals([NotNullWhen(true)] object? obj) => false;

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => Ref.GetHashCode();

    /// <summary>
    /// Determines if two <see cref="PtrRef{T, BaseType}"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static bool operator ==(PtrRef<T, BaseType> lh, PtrRef<T, BaseType> rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="PtrRef{T, BaseType}"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the pointers are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static bool operator !=(PtrRef<T, BaseType> lh, PtrRef<T, BaseType> rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="PtrRef{T, BaseType}"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator PtrRef<T, BaseType>(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="PtrRef{T, BaseType}"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="PtrRef{T, BaseType}"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(PtrRef<T, BaseType> lh, NullPtr rh) => lh == (PtrRef<T, BaseType>)rh;

    /// <summary>
    /// Determines whether a <see cref="PtrRef{T, BaseType}"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="PtrRef{T, BaseType}"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(PtrRef<T, BaseType> lh, NullPtr rh) => lh != (PtrRef<T, BaseType>)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="PtrRef{T, BaseType}"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="PtrRef{T, BaseType}"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, PtrRef<T, BaseType> rh) => (PtrRef<T, BaseType>)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="PtrRef{T, BaseType}"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="PtrRef{T, BaseType}"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, PtrRef<T, BaseType> rh) => (PtrRef<T, BaseType>)lh != rh;

    /// <summary>
    /// Creates a <see cref="PtrRef{T, BaseType}"/> from a span
    /// </summary>
    /// <param name="span"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrRef<T, BaseType>(Span<T> span) => new(ref span.GetPinnableReference());

    /// <summary>
    /// Creates a <see cref="PtrRef{T, BaseType}"/> from a span
    /// </summary>
    /// <param name="span"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrRef<T, BaseType>(ReadOnlySpan<T> span) => new(ref Unsafe.AsRef<T>(in span.GetPinnableReference()));

    /// <summary>
    /// Creates a <see cref="PtrRef{T, BaseType}"/> from a byte pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator PtrRef<T, BaseType>(T* ptr) => new(ref Unsafe.AsRef<T>(ptr));

    /// <summary>
    /// Creates a <see cref="PtrRef{T, BaseType}"/> from a void pointer
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator PtrRef<T, BaseType>(void* ptr) => new(ref Unsafe.AsRef<T>(ptr));

    /// <summary>
    /// Creates a byte pointer from a <see cref="PtrRef{T, BaseType}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator T*(PtrRef<T, BaseType> ptr) => (T*)Unsafe.AsPointer(ref ptr.Ref);

    /// <summary>
    /// Creates a void pointer from a <see cref="PtrRef{T, BaseType}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator void*(PtrRef<T, BaseType> ptr) => Unsafe.AsPointer(ref ptr.Ref);

    /// <summary>
    /// creates a <see cref="PtrRef{T, BaseType}"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrRef<T, BaseType>(T[] array) => array.AsSpan();

    /// <summary>
    /// creates a <see cref="PtrRef{T, BaseType}"/> from a 2D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrRef<T, BaseType>(T[,] array) => MemoryMarshal.CreateSpan(ref array[0, 0], array.Length);

    /// <summary>
    /// creates a <see cref="PtrRef{T, BaseType}"/> from a 3D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator PtrRef<T, BaseType>(T[,,] array) => MemoryMarshal.CreateSpan(ref array[0, 0, 0], array.Length);

    /// <summary>
    /// Creates a string from a <see cref="PtrRef{T, BaseType}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator string(PtrRef<T, BaseType> ptr)
    {
        if (Depth != 1)
        {
            throw new InvalidCastException();
        }

        if (typeof(T) == typeof(char) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
        {
            fixed (void* raw = ptr)
            {
                return new string((char*)raw);
            }
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            fixed (void* raw = ptr)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(uint))
        {
            fixed (void* raw = ptr)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        throw new InvalidCastException();
    }

    /// <summary>
    /// creates a <see cref="PtrRefToConst{T, BaseType}"/> from a string
    /// </summary>
    /// <param name="str"></param>
    public static implicit operator PtrRef<T, BaseType>(string str)
    {
        if (typeof(T) == typeof(char) || typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
        {
            return new PtrRef<T, BaseType>(
                ref Unsafe.As<char, T>(ref Unsafe.AsRef(in str.GetPinnableReference()))
            );
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            return new PtrRef<T, BaseType>(
                ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str)))
            );
        }

        if (typeof(T) == typeof(uint) || typeof(T) == typeof(int))
        {
            return new PtrRef<T, BaseType>(
                ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str, 4)))
            );
        }

        throw new InvalidCastException();
    }

    /// <summary>
    /// Create a non-generic version of <see cref="PtrRef{T, BaseType}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator PtrRef(PtrRef<T, BaseType> ptr) => new PtrRef<T, BaseType>(ref ptr.Ref);

    /// <summary>
    /// Create a managed pointer from a basetype jagged array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(BaseType[][] array) => SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Create a managed pointer from a basetype jagged array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(Span<BaseType[]> array) => SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Create a managed pointer from a basetype jagged array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(ReadOnlySpan<BaseType[]> array) => SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Create a managed pointer from a basetype pointer array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(BaseType*[] array)
    {
        if (Depth != 2)
            throw new InvalidCastException();
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(T).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(PtrRef<,>).MakeGenericType(typeof(T), typeof(BaseType))),
                TypeRef.Type(typeof(T)).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Create a managed pointer from a basetype jagged array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(Span<BaseType[][]> array) => SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Create a managed pointer from a basetype jagged array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(ReadOnlySpan<BaseType[][]> array) => SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Create a managed pointer from a basetype jagged array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(BaseType[][][] array) => SilkMarshal.JaggedArrayToPointerArray<BaseType>(array);

    /// <summary>
    /// Create a managed pointer from a basetype pointer array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="array"></param>
    public static implicit operator PtrRef<T, BaseType>(BaseType**[] array)
    {
        if (Depth != 3)
            throw new InvalidCastException();
        IL.Emit.Ldarg_0();
        IL.Emit.Ldc_I4_0();
        IL.Emit.Ldelema(TypeRef.Type(typeof(T).MakePointerType()));
        IL.Emit.Newobj(
            MethodRef.Constructor(
                TypeRef.Type(typeof(PtrRef<,>).MakeGenericType(typeof(T), typeof(BaseType))),
                TypeRef.Type(typeof(T)).MakeByRefType()
            )
        );
        IL.Emit.Ret();
        throw IL.Unreachable();
    }

    /// <summary>
    /// Create a <see cref="PtrRef{T, BaseType}"/> from a string array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strs"></param>
    public static implicit operator PtrRef<T, BaseType>(string[] strs)
    {
        if (Depth != 2 || (
            typeof(BaseType) != typeof(byte) &&
            typeof(BaseType) != typeof(sbyte) &&
            typeof(BaseType) != typeof(char) &&
            typeof(BaseType) != typeof(ushort) &&
            typeof(BaseType) != typeof(short) &&
            typeof(BaseType) != typeof(uint) &&
            typeof(BaseType) != typeof(int)))
        {
            throw new InvalidCastException();
        }
        return new(ref SilkMarshal.RefConversion<byte, T>(ref SilkMarshal.StringArrayToNative(strs, sizeof(BaseType))));
    }

    /// <summary>
    /// Create a <see cref="PtrRef{T, BaseType}"/> from a string array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strs"></param>
    public static implicit operator PtrRef<T, BaseType>(Span<string> strs)
    {
        if (Depth != 2 || (
            typeof(BaseType) != typeof(byte) &&
            typeof(BaseType) != typeof(sbyte) &&
            typeof(BaseType) != typeof(char) &&
            typeof(BaseType) != typeof(ushort) &&
            typeof(BaseType) != typeof(short) &&
            typeof(BaseType) != typeof(uint) &&
            typeof(BaseType) != typeof(int)))
        {
            throw new InvalidCastException();
        }
        return new(ref SilkMarshal.RefConversion<byte, T>(ref SilkMarshal.StringArrayToNative(strs, sizeof(BaseType))));
    }

    /// <summary>
    /// Create a <see cref="PtrRef{T, BaseType}"/> from a string array
    /// Only valid for depth 2 pointers
    /// </summary>
    /// <param name="strs"></param>
    public static implicit operator PtrRef<T, BaseType>(ReadOnlySpan<string> strs)
    {
        if (Depth != 2 || (
            typeof(BaseType) != typeof(byte) &&
            typeof(BaseType) != typeof(sbyte) &&
            typeof(BaseType) != typeof(char) &&
            typeof(BaseType) != typeof(ushort) &&
            typeof(BaseType) != typeof(short) &&
            typeof(BaseType) != typeof(uint) &&
            typeof(BaseType) != typeof(int)))
        {
            throw new InvalidCastException();
        }
        return new(ref SilkMarshal.RefConversion<byte, T>(ref SilkMarshal.StringArrayToNative(strs, sizeof(BaseType))));
    }

    /// <summary>
    /// Create a <see cref="PtrRef{T, BaseType}"/> from a string array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="strs"></param>
    public static implicit operator PtrRef<T, BaseType>(string[][] strs)
    {
        if (Depth != 3 || (
            typeof(BaseType) != typeof(byte) &&
            typeof(BaseType) != typeof(sbyte) &&
            typeof(BaseType) != typeof(char) &&
            typeof(BaseType) != typeof(ushort) &&
            typeof(BaseType) != typeof(short) &&
            typeof(BaseType) != typeof(uint) &&
            typeof(BaseType) != typeof(int)))
        {
            throw new InvalidCastException();
        }
        return new(ref SilkMarshal.RefConversion<byte, T>(ref SilkMarshal.StringArrayToNative(strs, sizeof(BaseType))));
    }

    /// <summary>
    /// Create a <see cref="PtrRef{T, BaseType}"/> from a string array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="strs"></param>
    public static implicit operator PtrRef<T, BaseType>(Span<string[]> strs)
    {
        if (Depth != 3 || (
            typeof(BaseType) != typeof(byte) &&
            typeof(BaseType) != typeof(sbyte) &&
            typeof(BaseType) != typeof(char) &&
            typeof(BaseType) != typeof(ushort) &&
            typeof(BaseType) != typeof(short) &&
            typeof(BaseType) != typeof(uint) &&
            typeof(BaseType) != typeof(int)))
        {
            throw new InvalidCastException();
        }
        return new(ref SilkMarshal.RefConversion<byte, T>(ref SilkMarshal.StringArrayToNative(strs, sizeof(BaseType))));
    }

    /// <summary>
    /// Create a <see cref="PtrRef{T, BaseType}"/> from a string array
    /// Only valid for depth 3 pointers
    /// </summary>
    /// <param name="strs"></param>
    public static implicit operator PtrRef<T, BaseType>(ReadOnlySpan<string[]> strs)
    {
        if (Depth != 3 || (
            typeof(BaseType) != typeof(byte) &&
            typeof(BaseType) != typeof(sbyte) &&
            typeof(BaseType) != typeof(char) &&
            typeof(BaseType) != typeof(ushort) &&
            typeof(BaseType) != typeof(short) &&
            typeof(BaseType) != typeof(uint) &&
            typeof(BaseType) != typeof(int)))
        {
            throw new InvalidCastException();
        }
        return new(ref SilkMarshal.RefConversion<byte, T>(ref SilkMarshal.StringArrayToNative(strs, sizeof(BaseType))));
    }

    internal static int Depth
    {
        get
        {
            IPointer? ptr = default(T) as IPointer;
            return ptr != null ? ptr.Depth + 1 : 1;
        }
    }
}
