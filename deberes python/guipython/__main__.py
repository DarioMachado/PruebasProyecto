import tkinter as tk

def button_clicked():
    print("HOLA!!")

window = tk.Tk()
window.title("Ejemplo")

button = tk.Button(window, text="Pulsame", command=button_clicked)
button.pack(pady=20)

window.mainloop()
