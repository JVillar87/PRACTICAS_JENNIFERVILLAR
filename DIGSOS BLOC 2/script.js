async function DescarregarDades() {
    const url = "https://opendata-ajuntament.barcelona.cat/resources/bcn/EstadisticaPadro/pad/2025/2025_pad_m_cognom.json";

    try {
        fetch(url).then((response)=> response.json()).then((data)=>{
            for (element of data)
            {
                // console.log(element.cognom)
                CompletarTaula(element);
            }
        })               

    } catch (error) {
        console.error("Error recuperando datos:", error);
    }
};

function CompletarTaula(element) {
    Tabla= document.querySelector('#taula-cognoms');
    const fila = document.createElement('tr')
    fila.innerHTML = '<td>'+ element.ORDRE_COGNOM + '</td><td>' + element.COGNOM + '</td><td>' + element.Valor + '</td>';
    Tabla.appendChild(fila)
}

DescarregarDades();

/*FONTS DE CONSULTES: 
https://github.com/erickcernarequejo/Fetch-Json.git
https://developer.mozilla.org/es/docs/Learn_web_development/Core/Scripting/JSON
https://es.stackoverflow.com/questions/545654/como-mostrar-los-datos-de-un-json-utilizando-javascript 
https://www.youtube.com/watch?v=8oL3uFySFcM 
+ amigo informático (Hector, mil gracias) en Discord para ver errores de escritura.
*/

