<?php 

    function getDigit($numbers, $d) {
        $found = array();
        foreach ($numbers as $values) {
            if ($values % 10 != $d) {
                array_push($found, $values);
            }
        }
        return $found;
    }
    
    $numbers = array(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20);
    
    print_r(getDigit($numbers, 4));
    
?> 
