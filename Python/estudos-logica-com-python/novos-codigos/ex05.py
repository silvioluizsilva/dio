# Calcular sequência aritmética

def soma_sequencia_aritmetica(n, a1, d):
    return n * (2 * a1 + (n - 1) * d) / 2

num_termos = int(input("Digite o número de termos da sequência: "))
primeiro_termo = float(input("Digite o primeiro termo: "))
razão = float(input("Digite a razão: "))

resultado = soma_sequencia_aritmetica(num_termos, primeiro_termo, razão)
print(f"A soma dos primeiros {num_termos} termos é {resultado}.")