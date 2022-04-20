(function () {
    Array.prototype.last = function(){
          return this[this.length-1];
    };

    Array.prototype.skip = function (n){
        return this.slice(n);
    };

    Array.prototype.take = function(n){
        return this.slice(0, n);
    }

    Array.prototype.sum = function(){
        return this.reduce((acc, e)=>acc+e);
    }
    
    Array.prototype.average = function(){
        return this.reduce((acc, e)=>acc+e)/this.length;
    }
})();

let arr = [1,2,3];
console.log(arr.last());
console.log(arr.skip(1));
console.log(arr.take(1));
console.log(arr.sum());
console.log(arr.average());