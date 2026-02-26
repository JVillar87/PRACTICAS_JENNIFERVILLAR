// URL dataset Ajuntament de Barcelona
const url = "https://opendata-ajuntament.barcelona.cat/data/dataset/49887163-f227-466d-88b1-4191d90f23d4/resource/8f3b0680-e832-473d-9860-e411c97a55ca/download";

async function descarregarDades() {
    try {
        const resposta = await fetch(url);
        const dades = await resposta.json();
            
        const tbody = document.querySelector("#taula-cognoms tbody");
        const divEstat = document.getElementById("estat");

        let files = "";

        dades.forEach(item => {
            files += `
                <tr>
                    <td>${item.ORDRE ?? '-'}</td>
                    <td>${item.COGNOM ?? 'N/A'}</td>
                    <td>${item.VALOR ?? item.FREQUENCIA ?? '0'}</td>
                </tr>
            `;
        });

        tbody.innerHTML = files;

        divEstat.style.display = "none";
        document.getElementById("taula-cognoms").style.display = "table";

    } catch (error) {
        console.error("Error en el fetch:", error);
        document.getElementById("estat").innerText = 
            "Error en carregar les dades (possible bloqueig CORS).";
    }
}

descarregarDades();