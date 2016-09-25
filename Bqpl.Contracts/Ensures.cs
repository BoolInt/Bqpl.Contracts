using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Bqpl.Contracts
{
  public static class Ensures
  {
    [Pure]
    [ContractAbbreviator]
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>(T value)
      where T : class
    {
      Contract.Ensures(value != null);
    }

    [Pure]
    [ContractAbbreviator]
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>(T? value)
      where T : struct
    {
      Contract.Ensures(value != null);
    }
  }
}