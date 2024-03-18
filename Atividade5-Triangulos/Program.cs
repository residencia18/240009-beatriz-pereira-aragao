using Atividade5_Triangulos.Entities;

Ponto<int> ponto1 = new Ponto<int>(1, 2, 3);
Ponto<double> ponto2 = new Ponto<double>(2.5, 3.7, 4.2);
Ponto<float> ponto3 = new Ponto<float>(0.5f, 1.2f, 2.8f);

Triangulo<int> triangulo1 = new Triangulo<int>(ponto1, ponto1, ponto1);
Triangulo<double> triangulo2 = new Triangulo<double>(ponto2, ponto2, ponto2);
Triangulo<float> triangulo3 = new Triangulo<float>(ponto3, ponto3, ponto3);

Console.WriteLine("1  ->\n" + triangulo1.ToString());
Console.WriteLine("2  ->\n" + triangulo2.ToString());
Console.WriteLine("3  ->\n" + triangulo3.ToString());
