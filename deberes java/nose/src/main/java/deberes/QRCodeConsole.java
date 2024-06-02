import java.util.Scanner;
import com.google.zxing.BarcodeFormat;
import com.google.zxing.WriterException;
import com.google.zxing.qrcode.QRCodeWriter;
import com.google.zxing.common.BitMatrix;

public class QRCodeConsole {
    public static void main(String[] args) {
        // Ask user for input
        Scanner scanner = new Scanner(System.in);
        System.out.print("Dame un texto que quieres que convierta a qr ");
        String input = scanner.nextLine();
        scanner.close();

        // Generate QR code
        try {
            QRCodeWriter qrCodeWriter = new QRCodeWriter();
            BitMatrix bitMatrix = qrCodeWriter.encode(input, BarcodeFormat.QR_CODE, 10, 10);

            // Print QR code to console
            for (int y = 0; y < bitMatrix.getHeight(); y++) {
                StringBuilder line = new StringBuilder();
                for (int x = 0; x < bitMatrix.getWidth(); x++) {
                    line.append(bitMatrix.get(x, y) ? "\u2588\u2588" : "  ");
                }
                System.out.println(line.toString());
            }

            System.out.println("QR code generated successfully.");
        } catch (WriterException e) {
            System.out.println("Error generating QR code: " + e.getMessage());
        }
    }
}
