function myKeyPress(e){
    var keynum;

    if (window.event) { // IE                    
      keynum = e.keyCode;
    } else if (e.which) {              
      keynum = e.which;
    }

    alert(String.fromCharCode(keynum) + " " + keynum);
  }
  
  window.addEventListener("keypress", myKeyPress);
