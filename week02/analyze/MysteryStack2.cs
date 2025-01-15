public static class MysteryStack2 {
    private static bool IsFloat(string text) { //// 'IsFloat'  é o método verifica se o texto pode ser convertido para um número de ponto float
        return float.TryParse(text, out _);
    }

    public static float Run(string text) { // Run() processa a entrada de texto e calcular o resultado
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) { // para cada item na expressão, são separados por um espaço
            if (item == "+" || item == "-" || item == "*" || item == "/") { // Se for um operador, ele retira 
            //dois números da pilha, aplica a operação e coloca o resultado de volta na pilha.
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!"); // quando há menos de dois operandos na pilha e um operador é encontrado.

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+") {
                    res = op1 + op2;
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!"); //quando uma divisão por zero é encontrada

                    res = op1 / op2;
                }

                stack.Push(res);
            }            
            else if (IsFloat(item)) { // Se for um número (float), ele é empurrado para a pilha.
                stack.Push(float.Parse(item));
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!"); //quando um item inválido é encontrado na expressão (como um operador desconhecido)
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!"); // quando há mais de um item restante na pilha no final do processamento, (não tem exatamente um resultado final).

        return stack.Pop();
    }
}