using Plugin.TestFeature.Abstractions;
using System;


namespace Plugin.TestFeature
{
  /// <summary>
  /// Implementation for TestFeature
  /// </summary>
  public class TestFeatureImplementation : ITestFeature
  {
        public string GetHello()
        {
            return "Hey! I'm the iOS PCL";
        }
    }
}