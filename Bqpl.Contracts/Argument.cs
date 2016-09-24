using Bqpl.Exceptions;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Bqpl.Contracts
{
  public static class Argument
  {
    [Pure]
    [ContractArgumentValidator]
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>(string argumentName, [ValidatedNotNull]T value)
      where T : class
    {
      if (value == null)
        throw ExceptionActivator.CreateArgumentNullException(argumentName);
      Contract.EndContractBlock();
    }

    [Pure]
    [ContractArgumentValidator]
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNullOrEmpty(string argumentName, [ValidatedNotNull]string value)
    {
      if (string.IsNullOrEmpty(value))
        throw ExceptionActivator.CreateArgumentException(argumentName);
      Contract.EndContractBlock();
    }
  }
}