using FintechBank.App;

var empService = new EmprestimoService();

Console.WriteLine("--- Calcular Valor Parcela ---");
Console.WriteLine($"Valor=10000, Parcelas=10, Score=750 → {empService.CalcularValorParcela(10000m, 10, 750)} (esperado: 1050,00)");
Console.WriteLine($"Valor=10000, Parcelas=10, Score=600 → {empService.CalcularValorParcela(10000m, 10, 600)} (esperado: 1120,00)");
Console.WriteLine($"Valor=10000, Parcelas=10, Score=400 → {empService.CalcularValorParcela(10000m, 10, 400)} (esperado: 1200,00)");

Console.WriteLine("\n--- Aprovar Empréstimo ---");
Console.WriteLine($"Renda=5000, Parcela=1500 → {empService.AprovarEmprestimo(5000m, 1500m)} (esperado: True)");
Console.WriteLine($"Renda=5000, Parcela=1600 → {empService.AprovarEmprestimo(5000m, 1600m)} (esperado: False)");