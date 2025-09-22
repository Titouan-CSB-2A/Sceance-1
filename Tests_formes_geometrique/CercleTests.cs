using Xunit;
using formes_geometriques_Titouan;

public class CercleTests
{
    [Fact]
    public void Aire_CalculCorrect()
    {
        var cercle = new Cercle(0, 0, 10);
        Assert.Equal(314.1592653589793, cercle.Aire(), 5);
    }

    [Fact]
    public void Perimetre_CalculCorrect()
    {
        var cercle = new Cercle(0, 0, 10);
        Assert.Equal(62.83185307179586, cercle.Perimetre(), 5);
    }

    [Fact]
    public void Propriete_Rayon_Correct()
    {
        var cercle = new Cercle(0, 0, 5);
        Assert.Equal(5, cercle.Rayon);
        cercle.Rayon = 8;
        Assert.Equal(8, cercle.Rayon);
    }
}