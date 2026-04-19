using System.Collections;
using Pure.Primitives.String.Operations;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.Model.HashCodes.Tests;

public sealed record DiagramSeriesHashTests
{
    [Fact]
    public void Determined()
    {
        Assert.Equal(
            "FEC51B7F5441114AA64689057000E2CE6109A0662FBE676A61D56A912C7DBEF2",
            new HexString(
                new DiagramSeriesHash(
                    new DiagramSeries(new String("fhbnuiglvj"), new String("dhnjufiblsr"))
                )
            ).TextValue
        );
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable hash = new DiagramSeriesHash(
            new DiagramSeries(new String("fhbnuiglvj"), new String("dhnjufiblsr"))
        );

        ICollection<byte> bytes = new List<byte>(32);

        foreach (object b in hash)
        {
            bytes.Add((byte)b);
        }

        Assert.Equal(
            "FEC51B7F5441114AA64689057000E2CE6109A0662FBE676A61D56A912C7DBEF2",
            Convert.ToHexString([.. bytes])
        );
    }
}
