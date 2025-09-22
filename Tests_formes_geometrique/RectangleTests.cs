using Xunit;
using formes_geometriques_Titouan;

public class RectangleTests
{
    [Fact]
    public void Aire_CalculCorrect()
    {
        var rectangle = new Rectangle(0, 0, 40, 10);
        Assert.Equal(400, rectangle.Aire());
    }

    [Fact]
    public void Perimetre_CalculCorrect()
    {
        var rectangle = new Rectangle(0, 0, 40, 10);
        Assert.Equal(100, rectangle.Perimetre());
    }

    [Fact]
    public void Propriete_LargeurEtHauteur_Correct()
    {
        var rectangle = new Rectangle(0, 0, 5, 7);
        Assert.Equal(5, rectangle.Largeur);
        Assert.Equal(7, rectangle.Hauteur);
        rectangle.Largeur = 10;
        rectangle.Hauteur = 20;
        Assert.Equal(10, rectangle.Largeur);
        Assert.Equal(20, rectangle.Hauteur);
    }
}