/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation {
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    //o laço foreach percorre todos os elementos do array: O(n)
    //ao calcular a média sendo operações matematicas: O(1)
    //segundo laço foreach, percorrendo todos os elementos e fazendo calculos: O(n)
    //calculando a variance, sendo uma operação: O(1)
    // O(n) + O(n) + O(1) = O(n)
    private static double StandardDeviation1(int[] numbers) {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers) {
            total += number;
            count += 1;
        }

        var avg = total / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }

    // possui um laço foreach externo e interno, e ambos percorrem cada elemento da array
    //externo percorre todos os elementos, e o interno percorre novamente todos os elementos
    //para cada interação do laço externo: O(n)
    //se o array tem n elementos, o laço interno executa n interações para cada uma das n interações do laço externo.
    // total(externo + interno): O(n * n) = O(n^2)
    private static double StandardDeviation2(int[] numbers) {
        var sumSquaredDifferences = 0.0; //acumula a soma das diferenças quadradas em relação a media
        var countNumbers = 0;
        foreach (var number in numbers) {
            var total = 0;
            var count = 0;
            foreach (var value in numbers) {
                total += value;
                count += 1;
            }

            var avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);
    }

    //o laço foreach percorre todos os elementos contendo operações matematicas internas
    //calculando a variance, sendo uma operação: O(1)
    // O(n) + O(n) + O(1) = O(n)
    private static double StandardDeviation3(int[] numbers) {
        var count = numbers.Length;
        var avg = (double)numbers.Sum() / count; //number.Sum percorre todos os elementos 1x para fazer a soma
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
}