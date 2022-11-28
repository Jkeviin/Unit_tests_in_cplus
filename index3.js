const palabraMasLarga = cadena => {

    const separadaPorEspacios = cadena.split(" ");

    let palabraMasLarga = separadaPorEspacios[0];

    for (const palabra of separadaPorEspacios) {
        if (palabra.length >= palabraMasLarga.length) {
            palabraMasLarga = palabra;
        }
    }
    return palabraMasLarga;
};

const oracion = "Me gusta programar en JavaScript aprendiendo en el blog de Parzibyte";
const palabra = palabraMasLarga(oracion);
console.log("La oración es: ");
console.log(oracion);
console.log("La palabra más larga es: ");
console.log(palabra);
