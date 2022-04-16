function solve() {
    const inputValues = Array.from(document.getElementById('hireForm').querySelectorAll('input'));
    const tableContent = document.getElementById('tbody');

    const hireWorkerButton = document.getElementById('add-worker');

    hireWorkerButton.addEventListener('click', (e) => {
        e.preventDefault();

        const firstName = inputValues[0].value;
        const lastName = inputValues[1].value;
        const email = inputValues[2].value;
        const date = inputValues[3].value;
        const position = inputValues[4].value;
        const salary = Number(inputValues[5].value);

        if (firstName !== '' && lastName !== '' && email != '' && date != '' && position != '' && salary != '') {
            const tableTr = document.createElement('tr');

            for (let i = 0; i < inputValues.length; i++) {

                const tdElement = document.createElement('td');
                tdElement.innerText = `${inputValues[i].value}`;
                tableTr.appendChild(tdElement);
            }

            for (const input of inputValues) {
                input.value = '';
            }

            let actionElement = document.createElement('td');
            let firedButton = document.createElement('button');
            let editButton = document.createElement('button');

            firedButton.classList.add('fired');
            firedButton.textContent = 'Fired';

            editButton.classList.add('edit');
            editButton.textContent = 'Edit';

            actionElement.appendChild(firedButton);
            actionElement.appendChild(editButton);

            tableTr.appendChild(actionElement);
            tableContent.appendChild(tableTr);

            let budjetSalaryElement = document.getElementById('sum');
            let currentBudjetSalary = Number(budjetSalaryElement.textContent);

            let totalBudjetSalary = currentBudjetSalary + salary;

            budjetSalaryElement.textContent = totalBudjetSalary.toFixed(2);

            editButton.addEventListener('click', (e) => {
                const tdItems = Array.from(tableTr.childNodes);

                for (let i = 0; i < inputValues.length; i++) {
                    inputValues[i].value = tdItems[i].textContent;
                    tdItems[i].remove();
                }

                totalBudjetSalary -= salary;
                budjetSalaryElement.textContent = totalBudjetSalary.toFixed(2);
            });

            firedButton.addEventListener('click', (e) => {

                totalBudjetSalary -= salary;
                budjetSalaryElement.textContent = totalBudjetSalary.toFixed(2);
                tableTr.remove();
            });
        }
    });
}
solve()