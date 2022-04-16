class Company {
    constructor() {
            this.departments = {};
        }
        //method
    addEmployee(name, salary, position, department) {
        if (typeof name === undefined || typeof name === null || name === '') {
            throw new Error('Invalid input!');
        }
        if (typeof salary === undefined || typeof salary === null || salary === '' || salary.value < 0) {
            throw new Error('Invalid input!');
        }
        if (typeof position === undefined || typeof position === null || position === '') {
            throw new Error('Invalid input!');
        }
        if (typeof department === undefined || typeof department === null || department === '') {
            throw new Error('Invalid input!');
        }

        let employee = {
            name: name,
            salary: salary,
            position: position,
        }

        if (Object.keys(this.departments).includes(department)) {
            this.departments.push(employee);
            console.log(`New employee is hired. Name: ${name}. Position: ${position}`);
        }
        console.log(Object.values(this.departments.salary));
    }

    bestDepartment() {

        //This function should return the department with the highest average salary 
        // rounded to the second digit after the decimal point and its employees sorted by
        //  their salary by descending order and by their name in ascending order as a second criterion:

        let highestSalary = 0;


        // `Best Department is: {best department's name}
        // Average salary: {best department's average salary}
        // {employee1} {salary} {position}
        // {employee2} {salary} {position}
        // {employee3} {salary} {position}
        // …`

    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
//console.log(c.bestDepartment());