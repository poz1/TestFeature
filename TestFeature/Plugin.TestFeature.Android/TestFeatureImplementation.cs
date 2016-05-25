using Plugin.TestFeature.Abstractions;
using System;


namespace Plugin.TestFeature
{
  /// <summary>
  /// Implementation for Feature
  /// </summary>
  public class TestFeatureImplementation : ITestFeature
  {
        public TestFeatureImplementation()
        {
            System.Diagnostics.Debug.WriteLine("Hey! I'm the Android PCL");
        }
  }
}