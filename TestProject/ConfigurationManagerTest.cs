using ClassLibrary;
using NUnit.Framework;

namespace TestProject;

public class ConfigurationManagerTest
{
    [Test]
    public void MakeSureThatConfigurationManagerReadsFromFileCorrectly()
    {
        Assert.That(Foo.Bar, Is.Not.Null); // Bar property is null
    }
}