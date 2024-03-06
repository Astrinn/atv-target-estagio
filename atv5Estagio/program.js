function inverterTexto(texto) {
    let textoInvertido = "";

    for (let i = texto.length - 1; i >= 0; i--) {
      textoInvertido += texto[i];
    }

    return textoInvertido;
  }

  const texto = "Hiago Duarte";
  const textoInvertido = inverterTexto(texto);

  console.log(textoInvertido);