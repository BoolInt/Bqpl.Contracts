using System;

namespace Bqpl.Contracts
{
  [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
  public sealed class ValidatedNotNullAttribute : Attribute
  {
  }
}