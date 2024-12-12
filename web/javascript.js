document.addEventListener("DOMContentLoaded", () => {
    const athletes = [
        { name: "John Doe", country: "USA", bestThrow: 80.5, year: 2021 },
        { name: "Richard Roe", country: "UK", bestThrow: 82.0, year: 2022 },
        { name: "Mark Smith", country: "Germany", bestThrow: 81.2, year: 2020 },
    ];

    const rankingTable = document.getElementById("ranking-table");

    athletes.forEach((athlete, index) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${index + 1}</td>
            <td><a href="#" onclick="showAthleteDetails('${athlete.name}')">${athlete.name}</a></td>
            <td>${athlete.country}</td>
            <td>${athlete.bestThrow} m</td>
            <td>${athlete.year}</td>
        `;
        rankingTable.appendChild(row);
    });
});

function showAthleteDetails(name) {
    alert(`Atléták részletes adatai: ${name}`);
}
