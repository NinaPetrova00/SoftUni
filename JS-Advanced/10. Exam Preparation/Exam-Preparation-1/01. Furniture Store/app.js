window.addEventListener('load', solve);

function solve() {

    const addButtonElement = document.getElementById('add');

    const modelInputElement = document.getElementById('model');
    const yearInputElement = document.getElementById('year');
    const descriptionInputElement = document.getElementById('description');
    const priceInputElement = document.getElementById('price');

    const furnitureListElement = document.getElementById('furniture-list');

    addButtonElement.addEventListener('click', (e) => {
        e.preventDefault();

        let model = modelInputElement.value;
        let description = descriptionInputElement.value;
        let year = Number(yearInputElement.value);
        let price = Number(priceInputElement.value);

        modelInputElement.value = '';
        descriptionInputElement.value = '';
        yearInputElement.value = '';
        priceInputElement.value = '';

        //o Model and description are non-empty strings
        if (!model || !description) {
            return;
        }
        //o	Year and Price need to be positive numbers
        if (year <= 0 || price <= 0) {
            return;
        }

        // Creating elements to fill in the table
        let rowElement = document.createElement('tr');

        let modelCellElement = document.createElement('td');
        let priceCellElement = document.createElement('td');
        let actionsCellElement = document.createElement('td');
        // Creating buttons
        let infoButtonElement = document.createElement('button');
        let buyButtonElement = document.createElement('button');

        let contentsRowElement = document.createElement('tr');

        let yearContentElement = document.createElement('td');
        let descriptionContentElement = document.createElement('td');

        let totalPriceElement = document.querySelector('.total-price');

        // Elements and buttons text content
        modelCellElement.textContent = model;
        priceCellElement.textContent = price.toFixed(2);

        infoButtonElement.textContent = 'More Info';
        infoButtonElement.classList.add('moreBtn');
        // More info button EventListener
        infoButtonElement.addEventListener('click', (e) => {
            if (e.currentTarget.textContent == 'More Info') {
                contentsRowElement.style.display = 'contents';
                e.currentTarget.textContent = 'Less Info';
            } else {
                contentsRowElement.style.display = 'none';
                e.currentTarget.textContent = 'More Info';
            }
        });

        buyButtonElement.textContent = 'Buy it';
        buyButtonElement.classList.add('buyBtn');
        // Buy it button EventListener
        buyButtonElement.addEventListener('click', (e) => {
            let currentTotalPrice = Number(totalPriceElement.textContent);
            let totalPrice = currentTotalPrice + price;
            totalPriceElement.textContent = totalPrice.toFixed(2);

            rowElement.remove();
            contentsRowElement.remove();
        });
        rowElement.classList.add('info');
        // Appending elements
        rowElement.appendChild(modelCellElement);
        rowElement.appendChild(priceCellElement);
        rowElement.appendChild(actionsCellElement);
        // Appending buttons
        actionsCellElement.appendChild(infoButtonElement);
        actionsCellElement.appendChild(buyButtonElement);

        yearContentElement.textContent = `Year: ${year}`;
        descriptionContentElement.setAttribute('colspan', 3);
        descriptionContentElement.textContent = `Description: ${description}`;

        contentsRowElement.classList.add('hide');
        contentsRowElement.style.display = 'none';

        contentsRowElement.appendChild(yearContentElement);
        contentsRowElement.appendChild(descriptionContentElement);

        // Add the created elements to the table (furniture-list)
        furnitureListElement.appendChild(rowElement);
        //  furnitureListElement.appendChild(actionsCellElement);
        furnitureListElement.appendChild(contentsRowElement);
    });
}