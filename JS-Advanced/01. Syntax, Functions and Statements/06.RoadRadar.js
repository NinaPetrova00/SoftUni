function speedRadar(speed, area) {

    let areaType = area;
    let speedKmH = Number(speed);

    let speedLimit = 0;
    let status;

    if (areaType == 'motorway') {
        speedLimit = 130;
        if (speedKmH > speedLimit) {
            let difference = speedKmH - speedLimit;
            if (difference <= 20) {
                status = 'speeding';
            } else if (difference <= 40) {
                status = 'excessive speeding';
            } else {
                status = 'reckless driving';
            }
            console.log(`The speed is ${speed - speedLimit} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
        } else {
            console.log(`Driving ${speedKmH} km/h in a ${speedLimit} zone`);
        }
    } else if (areaType == 'interstate') {
        speedLimit = 90;
        if (speedKmH > speedLimit) {
            let difference = speedKmH - speedLimit;
            if (difference <= 20) {
                status = 'speeding';
            } else if (difference <= 40) {
                status = 'excessive speeding';
            } else {
                status = 'reckless driving';
            }
            console.log(`The speed is ${speed - speedLimit} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
        } else {
            console.log(`Driving ${speedKmH} km/h in a ${speedLimit} zone`);
        }
    } else if (areaType == 'city') {
        speedLimit = 50;
        if (speedKmH > speedLimit) {
            let difference = speedKmH - speedLimit;
            if (difference <= 20) {
                status = 'speeding';
            } else if (difference <= 40) {
                status = 'excessive speeding';
            } else {
                status = 'reckless driving';
            }
            console.log(`The speed is ${speed - speedLimit} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
        } else {
            console.log(`Driving ${speedKmH} km/h in a ${speedLimit} zone`);
        }
    } else if (areaType == 'residential') {
        speedLimit = 20;
        if (speedKmH > speedLimit) {
            let difference = speedKmH - speedLimit;
            if (difference <= 20) {
                status = 'speeding';
            } else if (difference <= 40) {
                status = 'excessive speeding';
            } else {
                status = 'reckless driving';
            }
            console.log(`The speed is ${speed - speedLimit} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
        } else {
            console.log(`Driving ${speedKmH} km/h in a ${speedLimit} zone`);
        }
    }
}

speedRadar(40, 'city');
speedRadar(21, 'residential');
speedRadar(200, 'motorway');