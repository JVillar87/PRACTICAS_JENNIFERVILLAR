// OBJECTES
let salaris = {
    John: 30_000,
    Mary: 40_000,
    Robert: 50_000
}

// 1. Suma tots els salaris de l'objecte fent servir un for.. in.

let total = 0;
for (let money in salaris) {
    total += salaris[money];
}
console.log(total);

// 2. Suma tots els salaris de l'objecte fent servir Object.keys en un for.
let newTotal = 0;
let keys = Object.keys(salaris);
console.log(keys);
for (let TotalSalaris in keys) {
    newTotal += salaris[keys[TotalSalaris]];
}
console.log(newTotal);

// 3. Suma tots els salaris de l'objecte fent servir Object.values en un for.

let TotalSalaris = 0;
let values = Object.values(salaris);

for (let value of values) {
    TotalSalaris += value;
}
console.log(TotalSalaris);

// 4. Suma tots els salaris de l'objecte fent servir Object.entries en un for.

let ladder = {
    step: 0,
    up: function () {
        this.step++;
    },
    down: function () {
        this.step--;
    },
    showStep: function () {
        console.log(this.step);
    }
}

// 5. Per què el primer fragment funciona bé i el segon no? Com s'arreglaria el problema?
// Fragment a:
// ladder.up();
// ladder.up();
// ladder.down();
// ladder.showStep();
// Fragment b:
// ladder.up().up().down().showStep();

/* FRAGMENT A FUNCIONA PERQUÈ ES CRIDEN LES FUNCIONS DE MANERA INDIVIDUAL.
FRAGMENT B NO FUNCIONA PERQUÈ LES FUNCIONS NO RETORNEN L'OBJECTE LADDER.*/

// LLISTES

let llista = ["Cervantes", "Quevedo", "Lope de Vega", "Calderón"];

// La resta de tasques es fan a partir de la variable llista. 
// Printa per consola, en cada cas, el resultat de l'operació.

// 6. Afegeix un element al final de la llista

llista.push("Garcilaso de la Vega");
console.log(llista);

// 7. Elimina el darrer element de la llista
llista.pop();
console.log(llista);

// 8. Elimina el primer element de la llista
llista.shift();
console.log(llista);

// 9. Afegeix un element al principi de la llista
llista.unshift("Lope de Vega");
console.log(llista);

// 10. Afegeix tres elements entre "Quevedo" i "Lope de Vega"
llista.splice(2, 0, "Góngora", "Bécquer", "Martínez de la Rosa");
console.log(llista);

// 11. Elimina el segon i el tercer elements de la llista
llista.splice(2, 2);
console.log(llista);

// 12. Crea una llista2 amb els dos darrers elements de la llista (mètode splice)
let llista2 = llista.splice(2, 2);
console.log(llista2);

// 13. Crea una llista3 amb els dos darrers elements de la llista (mètode slice)
let llista3 = llista.slice(2, 4);
console.log(llista3);

// 14. Concatena llista3 al final de llista2
let llista4 = llista2.concat(llista3);
console.log(llista4);

// 15. Elimina el 2n element de la llista4
llista4.splice(1, 1);
console.log(llista4);

// 16. Printa per consola els elements de llista4, un a un
for (let i = 0; i < llista4.length; i++) {
    console.log(llista4[i]);
}

// 17. Printa per consola les claus de llista4, una a una
for (let index in llista4) {
    console.log(index);
}

// 18. Fes servir el mètode forEach per printar per consola tots els elements de 
llista.forEach(function (element) {
    console.log(element);
});

// 19. Ordena alfabèticament la llista4
llista4.sort();
console.log(llista4);

// 20. Ordena la llista4 pel nombre de lletres de cada element, de menor nombre de lletres a major
llista4.sort(function (a, b) {
    return a.length - b.length;
});
console.log(llista4);