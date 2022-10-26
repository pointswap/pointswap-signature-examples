const crypto = require('crypto');

function signature(queryString) {
    return crypto
        .createHmac('sha512', apiSecret)
        .update(queryString)
        .digest('hex');
}

const apiSecret = 'NhqPtmdSJYdKjVHjA7PZj4Mge3R5YNiP1e3UZjInClVN65XAbvqqM6A7H5fATj0j';

let queryString = 'timestamp=1578963600000';
console.log("hashing the string: ");
console.log(queryString);
console.log("and return:");
console.log(signature(queryString));

console.log("\n");

queryString = "platform_id=some_platform0&brand_id=1234&brand_member_id=5678&timestamp=1578963600000"
console.log("hashing the string: ");
console.log(queryString);
console.log("and return:");
console.log(signature(queryString));
