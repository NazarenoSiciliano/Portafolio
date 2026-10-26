# Portafolio – Nazareno Siciliano

Sitio: **https://nazarenosiciliano.github.io/Portafolio/** (GitHub Pages, sale de `index.html`).

- `index.html`: la página completa (proyectos, Power BI, programación). Para editar textos o sumar proyectos, se copia una `<article class="card">` y se cambia.
- `powerbi/`: capturas y archivos `.pbix` anonimizados de los tableros.
- `Programación/`: ejercicios de C#.

## Power BI

Cada tablero se agrega en el array `TABLEROS` al final de `index.html`:

```js
{ titulo: "Turnos de laboratorio", descripcion: "Qué pregunta responde y qué muestra.",
  herramientas: ["Power Query", "DAX"], captura: "powerbi/turnos.png",
  url: "", pbix: "powerbi/turnos.pbix" }
```

- **captura** (recomendado): PNG del tablero. Se ve siempre, carga rápido y no depende de Power BI.
- **url** (opcional): link de *Archivo › Insertar informe › Publicar en la web*. Si está, se muestra el tablero interactivo en lugar de la captura. Requiere licencia Pro o que tu organización lo permita, y **el informe queda público para cualquiera**.
- **pbix** (opcional): el archivo para descargar, para quien quiera ver el modelo y las medidas DAX.

Antes de sacar capturas, publicar o subir un `.pbix`, el tablero tiene que apuntar a los **datos anonimizados**. El `.pbix` guarda una copia de los datos adentro, así que subir el original expone todo aunque no se vea en pantalla.
