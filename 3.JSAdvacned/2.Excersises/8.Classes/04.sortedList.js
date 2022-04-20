class List {
    constructor() {
        this.nums = [];
        this.size = 0;
    }
    add(element) {
        this.nums.push(element);
        this.nums.sort((a, b) => a - b);
        this.size = this.nums.length;
    }
    remove(index) {
        if (index >= 0 && index < this.size) {
            this.nums.splice(index, 1);
            this.nums.sort((a, b) => a - b);
            this.size = this.nums.length;
        }
    }
    get(index) {
        if (index >= 0 && index < this.size) {
            return this.nums[index];
        }
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
console.log(list.size);