def fibonacci(n):
    fib_sequence = [0, 1]
    for i in range(2, n):
        fib_sequence.append(fib_sequence[-1] + fib_sequence[-2])
    return fib_sequence[:n]

if __name__ == "__main__":
    try:
        num = int(input("Cuántos números de fibonacci quieres, del 1 al 20: "))
        if num <= 0:
            raise ValueError("Número inválido")
        result = fibonacci(num)
        print("Secuencia de Fibonacci:", result)
    except ValueError as ve:
        print(ve)
