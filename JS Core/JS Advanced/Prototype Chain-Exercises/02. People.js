function people() {
    class Employee{
        constructor(name, age){
            if(new.target === Employee){
                throw new Error('Employee cannot be initialized!')
            }

            this.name = name;
            this.age = age;
            this.salary = 0;
            this.counter = -1;
        }

        collectSalary(){
            console.log(`${this.name} received ${this.getSalary()} this month.`);
        }

        work(){
            this.counter++;
            console.log(this.tasks[this.counter%this.tasks.length]);
        }

        getSalary(){
            return this.salary;
        }
    }

    class Junior extends Employee{
        constructor(name,age){
            super(name,age);
            this.tasks = [`${this.name} is working on a simple task.`];
        }
    }

    class Senior extends Employee{
        constructor(name,age){
            super(name,age);
            this.tasks = [`${this.name} is working on a complicated task.`,
                `${this.name} is taking time off work.`,
                `${this.name} is supervising junior workers.`];
        }
    }

    class Manager extends Employee{
        constructor(name,age){
            super(name,age);
            this.tasks = [`${this.name} scheduled a meeting.`,
                `${this.name} is preparing a quarterly report.`];
            this.dividend = 0;
        }

        getSalary(){
            return super.getSalary() + this.dividend;
        }
    }

    return {
        Employee,
        Junior,
        Senior,
        Manager
    }
}
