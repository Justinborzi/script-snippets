var myArray = ["Hello", 1, 4, 6, "k", "1"];

function removeElement(arr, ...args) {

    for(i = 0; i < args.length; i++) {
        arr.splice(arr.indexOf(args[i]), 1);
    }

    return arr;
}

console.log(removeElement(myArray, "Hello", 1))
