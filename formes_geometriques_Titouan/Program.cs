using formes_geometriques_Titouan;

Console.WriteLine("Hello, World!");
Point O = new Point(0, 0);
Point A = new Point(2, 2);
Point B = new Point(2, 2);
Console.WriteLine("O" + O);
Console.WriteLine("A" + A); 
Console.WriteLine("B" + B);
Console.WriteLine(A.Equals(B) ? "A et B sont égaux" : "A et B sont différents");
Console.WriteLine(A.Equals(O) ? "A et O sont égaux" : "A et O sont différents");

Cercle cercle = new Cercle(2, 2, 10);
Console.WriteLine("\nClasse Cercle :");
Console.WriteLine($"Centre : {cercle.Point}, Rayon : {cercle.Rayon}");
Console.WriteLine($"Perimetre : {cercle.Perimetre()}");
Console.WriteLine($"Aire : {cercle.Aire()}");

Rectangle rectangle = new Rectangle(2, 2, 40, 10);
Console.WriteLine("\nClasse Rectangle :");
Console.WriteLine($"Centre : {rectangle.Point}, Longueur : {rectangle.Largeur}, Largeur : {rectangle.Hauteur}");
Console.WriteLine($"Perimetre : {rectangle.Perimetre()}");
Console.WriteLine($"Aire : {rectangle.Aire()}");