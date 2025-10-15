namespace TunitExp;

internal sealed class Dep
{
    [ClassDataSource<Dep1>(Shared = SharedType.None)]
    internal required Dep1 Dep1 { get; init; }

    internal string Name => Dep1.ToString();    // Dep1 is null here
}

internal sealed class Dep1;

internal sealed class UnitTest
{
    [ClassDataSource<Dep>(Shared = SharedType.None)]
    internal required Dep Dep { get; init; }

    [Test]
    internal async Task TestMethod1()
    {
        await Assert.That(Dep.Name).IsNotNull();
    }
}