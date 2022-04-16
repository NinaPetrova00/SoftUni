const person = {
    firstName: 'Pesho',
    lastName: 'Petrov',
    introduce() {
        const getFullName = function() {
            return this.firstName + ' ' + this.lastName;
        }
        console.log(`Hello, my name is ${getFullName()}`); // global invocation 
    }
};

person.introduce();