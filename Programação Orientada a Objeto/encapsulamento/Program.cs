using encapsulamento;

CartaodeCredito cartao = new CartaodeCredito(0, 15);
cartao.AlterarDiaVencimento(30);

Console.WriteLine(cartao.DiaVencimento);