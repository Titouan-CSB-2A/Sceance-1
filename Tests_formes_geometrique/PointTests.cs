using Xunit;
using formes_geometriques_Titouan;

public class PointTests
{
    [Fact]
    public void Equals_RetourneTrue_SiCoordonneesIdentiques()
    {
        var p1 = new Point(2, 2);
        var p2 = new Point(2, 2);
        Assert.True(p1.Equals(p2));
    }

    [Fact]
    public void Equals_RetourneFalse_SiCoordonneesDifferentes()
    {
        var p1 = new Point(2, 2);
        var p2 = new Point(0, 0);
        Assert.False(p1.Equals(p2));
    }

    [Fact]
    public void ToString_AfficheCoordonneesCorrectes()
    {
        var p = new Point(3, 5);
        Assert.Equal("(3,5)", p.ToString());
    }
}