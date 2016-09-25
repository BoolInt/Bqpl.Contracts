using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Bqpl.Contracts
{
  public static class Result
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
    [Pure]
    [ContractAbbreviator]
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>()
      where T : class
    {
      Ensures.NotNull(Contract.Result<T>());
    }
  }
}