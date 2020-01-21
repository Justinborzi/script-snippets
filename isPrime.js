function isPrime(n) {
  switch(n) {
  case 1:
    return false;
    break;
  case 2:
    return true;
    break;
  default:
    for(var x = 2; x < n; x++) {
        if(n % x === 0) {
          return false;
        }
      }
      return true;  
  }
  return console.error("Error, Contact developer");
}

// Usage
console.log(isPrime(123456912837987));
