# Calcular temperatura

def celsius_para_fahrenheit(celsius):
    return celsius * 9/5 + 32

temperatura_celsius = float(input("Digite a temperatura em Celsius: "))
temperatura_fahrenheit = celsius_para_fahrenheit(temperatura_celsius)
print(f"A temperatura em Fahrenheit é {temperatura_fahrenheit}.")