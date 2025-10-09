internal sealed class UnitTest
{
    [Test]
    [Arguments("1", "2")]
    // make the method public and test will be discovered
    internal Task TestMethod(string s1, string s2) => Task.CompletedTask;
}