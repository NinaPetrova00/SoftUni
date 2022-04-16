function rectangle(width, height, color) {

    let resultRectangle = {
        width: Number(width),
        height: Number(height),
        color: color[0].toUpperCase() + color.slice(1),
        calcArea: function() {
            return width * height;
        }
    };
    return resultRectangle;
}
let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());