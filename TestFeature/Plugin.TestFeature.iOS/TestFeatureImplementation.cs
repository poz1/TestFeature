using Plugin.TestFeature.Abstractions;
using System;


namespace Plugin.TestFeature
{
  /// <summary>
  /// Implementation for TestFeature
  /// </summary>
  public class TestFeatureImplementation : ITestFeature
  {
        public TestFeatureImplementation()
        {
            System.Diagnostics.Debug.WriteLine("Hey! I'm the iOS PCL");
        }
    }
}