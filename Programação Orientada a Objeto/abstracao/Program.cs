using abstracao.ClasseDerivada;

Gato  novoGato = new Gato();
string somGato = novoGato.EmitirSom();
novoGato.Correr();

Cachorro novoCachorro = new Cachorro();
string somCachorro = novoCachorro.EmitirSom();
novoCachorro.Correr();

Console.WriteLine(somCachorro);
Console.WriteLine(somGato);