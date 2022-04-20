class Company {
    constructor() {
        this.departments = {};
    }

    addEmployee(name, salary, position, department) {
        if (!name || !salary || !position || !department || salary < 0) {
            throw new Error('Invalid input!');
        }

        if (!this.departments[department]) {
            this.departments[department] = [];
        }
        this.departments[department].push([name, salary, position]);

        return `New employee is hired. Name: ${name}. Position: ${position}`;
    }

    bestDepartment() {
        let bestAvSalary = 0;
        let sum = 0;
        let bestDpt = '';
        for (const department in this.departments) {
            this.departments[department].forEach(employee => {
                sum += employee[1];
            });

            let avDeptSalary = sum / this.departments[department].length;
            if (avDeptSalary > bestAvSalary) {
                bestAvSalary = avDeptSalary;
                bestDpt = department;
            }
            sum = 0;
        }

        this.departments[bestDpt].sort((a, b) => {
            if (a[1] < b[1]) {
                return 1;
            }
            else if (a[1] == b[1]) {
                if (a[0].localeCompare(b[0])) {
                    return -1;
                }
                else {
                    return 1;
                }
            }
            else {
                return -1;
            }
        });

        let result = `Best Department is: ${bestDpt}\nAverage salary: ${bestAvSalary.toFixed(2)}\n`;
        this.departments[bestDpt].forEach(employee => {
            result += `${employee[0]} ${employee[1]} ${employee[2]}\n`;
        });

        return result.trimEnd();
    }
}

let c = new Company();

let actual1 = c.addEmployee("Stanimir", 2000, "engineer", "Human resources");
//let expected1 = "New employee is hired. Name: Stanimir. Position: engineer";
console.log(actual1);
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");

let act = c.bestDepartment();

