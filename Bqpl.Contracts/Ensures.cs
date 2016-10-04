using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Bqpl.Contracts
{
  public static class Ensures
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "value")]
    [Pure]
    [ContractAbbreviator]
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>(T value)
      where T : class
    {
      Contract.Ensures(value != null);
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "value")]
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