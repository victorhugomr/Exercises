var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

function minPenMovements(n, v, e, edges) {
  const adjList = Array.from({ length: v }, () => []);
  for (let i = 0; i < e; i++) {
    const [u, v] = edges[i];
    adjList[u].push(v);
    adjList[v].push(u);
  }

  const visited = new Set();
  let penMovements = 0;

  function dfs(node) {
    visited.add(node);
    adjList[node].forEach(neighbor => {
      if (!visited.has(neighbor)) {
        penMovements++;
        dfs(neighbor);
        penMovements++;
      }
    });
  }

  dfs(n);
  return penMovements;
}

const T = lines[0]; //casos de teste
lines.shift(); //remover o primeiro elemento da array
var N; //posição que começa e termina o desenho
var V; //
var A; //
var teste; //
var array;

do{
    N = lines[0];
    lines.shift();
    array = lines[0].split(" ");
    V = array[0];
    A = array[1];
    lines.shift();
    teste = { N, V, A, arestas: [] };
    
    while(lines[0].includes(" ")){
        array = lines[0].split(" ");
        teste.arestas.push(array);
        lines.shift();
    }
    const result = minPenMovements(N, V, A, teste.arestas);
    console.log(result);
}while(lines[0] != "");
