using System;
using System.IO;
using QRCoder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime texto un texto o URL para convertir a QR");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        AsciiQRCode qrCode = new AsciiQRCode(qrCodeData);

        Console.WriteLine(qrCode.GetGraphic(1));

    }
}