namespace Atividade5_Triangulos.Entities;

public class Triangulo<T>
{
    public Ponto<T> P1 { get; set; }
    public Ponto<T> P2 { get; set; }
    public Ponto<T> P3 { get; set; }

    public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
    }

    public override string ToString()
    {
        return $"P1: {P1.X}, {P1.Y}, {P1.Z}\nP2: {P2.X}, {P2.Y}, {P2.Z}\nP3: {P3.X}, {P3.Y}, {P3.Z}";
    }
}
