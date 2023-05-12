/*string[] nomes = new string[3];
nomes[0] = "Leonardo";
nomes[1] = "Pedro";
nomes[2] = "Cecilia";


string[] nomes1 = {"Leonardo", "Pedro", "Cecilia", "Maria"};

var nomes2 = nomes1.Append("Carlos"); // inclui ao final do array de nomes1 o elemento dentro dos " "

string[] nomes3 = {"Antonio", "Jose", "Felipe"};

var tudo = nomes1.Concat(nomes3).ToList(); //o concat unifica os arrays, nesse caso nomes1 + nomes3
tudo.RemoveAt(1);

foreach(var item in tudo)
{
System.Console.WriteLine(item);
}*/

//System.Console.WriteLine(nomes[/*posicao do array*/0]); // vai exibir o conteudo da posição escolhida
//System.Console.WriteLine(nomes.Length); //Tamanho do array
//System.Console.WriteLine(nomes.Any()); //vai informar se existe algum elemento dentro do array com true ou false

List<String> nomes = new List<string>();
nomes.Add("Leonardo");
nomes.Add("Cecilia");
nomes.Add("Camila");

List<String> nomes1 = new List<string>();
nomes.Add("Francisco");
nomes.Add("Doroti");
nomes.Add("José");
nomes.AddRange(nomes1); // é o concat para listas, ele junta uma lista com outra lista

//nomes.Clear();
System.Console.WriteLine(nomes.Count);

foreach(var item in nomes){
    System.Console.WriteLine(item);
}

