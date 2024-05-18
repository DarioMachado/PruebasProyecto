const readline = require('readline');
const qrcode = require('qrcode-terminal');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Dime algo para que lo transforme a qr ', (input) => {

  qrcode.generate(input, { small: true }, (qrCode) => {
    console.log(qrCode);
  });
  

  rl.close();
});
