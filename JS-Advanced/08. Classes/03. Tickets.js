function ticketSorter(tickets, sortingInput) {

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let result = [];

    tickets.map((el) => {
        let [destination, price, status] = el.split('|');
        price = Number(price);
        result.push(new Ticket(destination, price, status));
    });
    // result.forEach((el) => console.log(el));

    return result.sort((a, b) => {
        if (typeof a[sortingInput] === 'number') {
            return a[sortingInput] - b[sortingInput];
        } else {
            return a[sortingInput].localeCompare(b[sortingInput]);
        }
    });
}

ticketSorter(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'
    ],
    'destination');