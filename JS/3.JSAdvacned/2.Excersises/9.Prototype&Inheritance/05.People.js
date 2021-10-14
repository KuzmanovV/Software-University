function solution() {
    class Employee {
        constructor(name, age) {
            if (this.constructor === Employee) {
                throw new Error('Cannot instantiate abstract class!')
            }
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
            this.taskIndex = 0;
        }

        work(){
            console.log(tasks[this.taskIndex]);
            this.taskIndex++;
            if (this.taskIndex>=this.tasks.length) {
                this.taskIndex=0;
            }
        }
        collectSalary(){
            return `${this.name} received ${salary} this month.`
        }
    }

    class Junior extends Employee {
        constructor(name, age){
            super(name, age)
            this.tasks = [`${this.name} is working on a simple task.`];
        }
    }

    class Senior extends Employee {
        constructor(name, age){
            super(name, age)
            this.tasks = [`${this.name} is working on a complicated task.`,
                        `${this.name} is taking time off work.`,
                        `${this.name} is supervising junior workers.`];
        }
    }

    class Manager extends Employee {
        constructor(name, age){
            super(name, age)
            this.tasks = [`${this.name} scheduled a meeting.`,
                        `${this.name} is preparing a quarterly report.`];
            this.divident = 0;
        }

        collectSalary(){
            return `${this.name} received ${salary+this.divident} this month.`
        }
    }


}