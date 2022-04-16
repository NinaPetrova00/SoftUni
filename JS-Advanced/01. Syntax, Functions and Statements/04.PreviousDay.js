function date(a, b, c) {
    let year = Number(a);
    let month = Number(b);
    let day = Number(c);

    if (day == 1) {

        if (month % 2 == 1) {
            day = 31;
        } else {
            if (month == 2) {
                day = 28;
            } else {
                day = 30;
            }
        }
        month--;
    } else {
        day--;
    }
    console.log(`${year}-${month}-${day}`);
}

date(2016, 9, 30);
date(2016, 10, 1);

function date2(year, month, day) {

    let dateInput = `${year}-${month}-${day}`;
    let date = new Date(dateInput);
    date.setDate(date.getDate() - 1);

    console.log(`${date.getFullYear()}-${date.getMonth()+1}-${date.getDate()}`);
    //months starts from 0 -> January=0, February=1, ....
}

date2(2016, 9, 30);
date2(2016, 10, 1);