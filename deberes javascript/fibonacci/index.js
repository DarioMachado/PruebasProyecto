const readline = require('readline');

// Create interface for user input
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});


const generateFibonacci = (num) => {
  if (num <= 0) return [];
  if (num === 1) return [0];
  
  const fibSeq = [0, 1];
  for (let i = 2; i < num; i++) {
    fibSeq.push(fibSeq[i - 1] + fibSeq[i - 2]);
  }
  return fibSeq;
};

rl.question('¿Cuántos números de la secuencia de fibonacci quieres saber? Del 1 al 20. ', (answer) => {
  const num = parseInt(answer, 10);
  
  if (isNaN(num) || num < 1 || num > 20) {
    console.log('Número no válido.');
  } else {
    const fibonacciNumbers = generateFibonacci(num);
    console.log( fibonacciNumbers.join(', '));
  }
  

  rl.close();
});
