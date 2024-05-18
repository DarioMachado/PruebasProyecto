import qrcode
from art import *


def generate_qr_ascii(text):
    # Generate QR code
    qr = qrcode.QRCode(version=1, error_correction=qrcode.constants.ERROR_CORRECT_L, box_size=10, border=4)
    qr.add_data(text)
    qr.make(fit=True)
    qr_image = qr.make_image(fill_color="black", back_color="white")

    # Convert QR code image to ASCII art
    ascii_art = text2art(text, font='block')

    return ascii_art, qr_image


if __name__ == "__main__":
    try:
        # Prompt user for input
        user_input = input("Enter text to encode in QR code: ")

        # Generate QR code and ASCII art
        ascii_art, qr_image = generate_qr_ascii(user_input)

        # Print ASCII art
        print(ascii_art)

        # Save QR code image
        qr_image.save("qr_code.png")
        print("QR code saved as qr_code.png")
    except Exception as e:
        print("Error:", e)
