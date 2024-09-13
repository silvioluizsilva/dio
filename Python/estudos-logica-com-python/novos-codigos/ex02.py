# Calculadora básica

def calculadora_basica():
    print("Operações: \n1. Adição \n2. Subtração \n3. Multiplicação \n4. Divisão")
    operacao = input("Escolha a operação (1/2/3/4): ")
    
    num1 = float(input("Digite o primeiro número: "))
    num2 = float(input("Digite o segundo número: "))
    
    if operacao == '1':
        resultado = num1 + num2
        print(f"Resultado: {resultado}")
    elif operacao == '2':
        resultado = num1 - num2
        print(f"Resultado: {resultado}")
    elif operacao == '3':
        resultado = num1 * num2
        print(f"Resultado: {resultado}")
    elif operacao == '4':
        if num2 != 0:
            resultado = num1 / num2
            print(f"Resultado: {resultado}")
        else:
            print("Erro: Divisão por zero não é permitida.")
    else:
        print("Operação inválida.")

calculadora_basica()