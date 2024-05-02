using EjercicioHerencia;
Calcular calculoArea = new Calcular();


///Estas son las formulas disponibles:
///Area
///Area del Cuadrado
///Area del Rectangulo
///Area del Paralelogramo
///Area del Trapecio
///Area del Triangulo
///Area del Cometa
///Area del Rombo
///Area del Circulo
///Volumen
///Volumen del Cubo
///Volumen del Prisma
///Volumen del Cilindro
///Volumen de la esfera
///Longitud
///Longitud de la Circunferencia
///

///Metodos que esperan 1 argumento
///.AreaDeCuadrado();
///.AreaDeCirculo();
///.VolumenDeCubo();
///.VolumenDeEsfera();
///.LongitudeCircunferencia();
calculoArea.AreaDeCuadrado(1.0);
calculoArea.Imprimir();///Muestra el resultado

///Metodos que esperan 2  argumentos
///.AreaDeRectangulo();
///.AreaDeParalelogramo();
///.AreaDeTriangulo();
///.AreaDeCometa();
///.AreaDeRombo();
///.AreaDeCilindro();
calculoArea.AreaDeRectangulo(1.0, 1.0);
calculoArea.Imprimir();//Muestra el resultado

///Metodos que esperan 3 argumentos
///.AreaDeTrapecio();
///.VolumenDePrisma();
calculoArea.AreaDeTrapecio(1.0,1.0,1.0);
calculoArea.Imprimir();//Muestra el resultado

///Post data: Pasar argumentos del tipo double 0.0


