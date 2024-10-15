/*------------------------------------
Projektas 1:
Turite darbuotojų duomenų sąrašą HTML table elementuose (vardas, pavarde, amzius, pareigos).
 
Parašykite JavaScript funkciją, kuri, paspaudus mygtuką „Generuoti CSV“, 
surinks visus duomenis iš lentelės #darbuotojai ir suformuos CSV formato eilutę. 
Lentelėje yra ir antraštės (<thead>), ir duomenų eilutės (<tbody>).
 
Užduotis 1:. Sujunkite antraštes ir eilutes į CSV formato tekstą, naudodami kablelius kaip skyriklį tarp duomenų.
Naudokite .join() metodą.
Pridėkite funkcionalumą, kad CSV turinys būtų rodomas naudotojui kaip tekstinė eilutė 
arba atsidarytų pranešimo lange (alert), kai CSV yra suformuotas
 
Laukiamas rezultatas:
Vardas,Pavardė,Amžius,Pareigos
Jonas,Jonaitis,30,Programuotojas
Asta,Astaitė,25,Projektų vadovė
Petras,Petraitis,35,Analitikas
Inga,Ingaitytė,28,Testuotoja
 
Užduotis 2:  Padarykite kad csv būtu galima atsisiųsti kaip failą.
 
Užduotis 3: Pridėkite funkcionalumą, kad naudotojas galėtu pasirinkti  CSV formato skyriklį , arba ;
*/

function generateCSV() {
    const table = document.getElementById('darbuotojai');
    let csv = '';

    const headers = document.querySelectorAll('thead th');
    for (let i = 0; i < headers.length; i++) {
        csv += headers[i].textContent;
        if (i < headers.length - 1) {
            csv += ',';
        }
    }
    csv += '\n';

    const rows = table.querySelectorAll('tbody tr');
    for (let i = 0; i < rows.length; i++) {
        const cells = rows[i].getElementsByTagName('td');
        for (let j = 0; j < cells.length; j++) {
            csv += cells[j].textContent;
            if (j < cells.length - 1) {
                csv += ',';
            }
        }
        csv += '\n';
    }

    alert(csv);
}