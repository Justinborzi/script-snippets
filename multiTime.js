// Method 1
function getESTTime() {
  var aestTime = new Date().toLocaleString("en-US", {timeZone: "Australia/Brisbane"});
  aestTime = new Date(aestTime);
  console.log('AEST time: '+aestTime.toLocaleString())
}

setInterval(getESTTime(), 1000);

// Method 2
setInterval(function() {
        var time = new Date();
        var output = document.getElementById("time");
        
        let h = time.getHours();
        let m = time.getMinutes();
        let s = time.getSeconds();

         // Uncomment to format time with 00:00:00
        /*if (h < 10){
            h = "0" + h;
        }
        if (m < 10){
            m = "0" + m;
        }
        if (s < 10){
            s = "0" + s;
        }*/

        output.innerHTML = h+':'+m+':'+s;
    }, 1000);
