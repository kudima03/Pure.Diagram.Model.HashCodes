using System.Collections;
using Pure.Primitives.String.Operations;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.Model.HashCodes.Tests;

public sealed record DiagramTypeHashTests
{
    [Fact]
    public void Determined()
    {
        Assert.Equal(
            "13F998DAFC13DB7D27934C7CD84517DB4B7D1C0500E0891AE547A3E36BC70964",
            new HexString(
                new DiagramTypeHash(new DiagramType(new String("fhbnuiglvj")))
            ).TextValue
        );
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable hash = new DiagramTypeHash(new DiagramType(new String("fhbnuiglvj")));

        ICollection<byte> bytes = new List<byte>(32);

        foreach (object b in hash)
        {
            bytes.Add((byte)b);
        }

        Assert.Equal(
            "13F998DAFC13DB7D27934C7CD84517DB4B7D1C0500E0891AE547A3E36BC70964",
            Convert.ToHexString([.. bytes])
        );
    }
}
