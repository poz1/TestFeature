using Plugin.TestFeature.Abstractions;
using System;

namespace Plugin.TestFeature
{
  /// <summary>
  /// Cross platform TestFeature implemenations
  /// </summary>
  public class CrossTestFeature
  {
    static Lazy<ITestFeature> Implementation = new Lazy<ITestFeature>(() => CreateTestFeature(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static ITestFeature Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static ITestFeature CreateTestFeature()
    {
#if PORTABLE
        return null;
#else
        return new TestFeatureImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
