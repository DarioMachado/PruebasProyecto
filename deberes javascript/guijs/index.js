import express from 'express';
import open from 'open';

// Create a new Express application
const app = express();

// Serve static files from the "public" directory
app.use(express.static('public'));

// Endpoint to handle button click
app.post('/button-click', (req, res) => {
  console.log('HOLA!');
  res.sendStatus(200);
});

const PORT = 3000;
app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
  open(`http://localhost:${PORT}`);
});
