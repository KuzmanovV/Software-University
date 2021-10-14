(function se() {
    String.prototype.ensureStart = function (str) {
        let start = this.slice(0, str.length)
        if (start !== str) {
            return str + this;
        }
        return this.toString();
    };

    String.prototype.ensureEnd = function (str) {
        let end = this.slice(-str.length)
        if (end !== str) {
            return this + str;
        }
        return this.toString();
    };

    String.prototype.isEmpty = function () {
        return this.length == 0;
    };

    String.prototype.truncate = function (n) {
        if (this.length <= n) {
            return this.toString();
        }
        if (n < 4) {
            return this.slice(0, n - 3) + '...';
        }
        if (this.includes(' ')) {
            let splitedInput = this.split(' ');

            do {
                splitedInput.pop()
            } while (splitedInput.join(' ').length + 3 > n);
            return splitedInput.join(' ') + '...'
        } else {
            let output = '';
            if (n < 4) {
                for (let i = 1; i <= n; i++) {
                    output += '.';
                }
            }
            return output;
        };
    };

    String.format = function (str, ...params) {
        let result = str;

        for (let i = 0; i < params.length; i++) {
            result = result.replace(`{${i}}`, params[i]);
        }

        return result;
    }
}());

let str = 'my string';
str = str.ensureStart('my');
str = str.ensureStart('hello '); console.log(str);
str = str.truncate(16); console.log(str);
str = str.truncate(14); console.log(str);
str = str.truncate(8); console.log(str);
str = str.truncate(4); console.log(str);
str = str.truncate(2); console.log(str);
str = String.format('The {0} {1} fox',
    'quick', 'brown'); console.log(str);
str = String.format('jumps {0} {1}',
    'dog'); console.log(str);


