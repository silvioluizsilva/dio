# Calculando a média entre 3 notas

try:
    # Solicita ao usuário que insira três notas
    nota1 = float(input("Digite a primeira nota: "))
    nota2 = float(input("Digite a segunda nota: "))
    nota3 = float(input("Digite a terceira nota: "))

    # Calcula a média das três notas
    media = (nota1 + nota2 + nota3) / 3

    # Exibe a média
    print(f"A média das notas é: {media:.2f}")

except ValueError:
    print("Por favor, insira valores numéricos válidos.")
