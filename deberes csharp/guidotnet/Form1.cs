namespace guidotnet;

using System;
using System.Windows.Forms;
public partial class Form1 : Form
{

    public int contador = 0;
    public Form1()
    {
        InitializeComponent();

        // Create a button and set its properties
        Button helloButton = new Button();
        helloButton.Size = new System.Drawing.Size(100, 50);
        helloButton.Location = new System.Drawing.Point(100, 100);
        helloButton.Text = "Púlsame";
        helloButton.Click += new EventHandler(HelloButton_Click);

        // Add the button to the form
        this.Controls.Add(helloButton);
    }

    private void HelloButton_Click(object sender, EventArgs e)
    {
        contador++;
        Console.WriteLine("HOLA "+contador);
    }
}
