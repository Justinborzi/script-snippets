<?php
    // Table of SteamUser Data Ex: RESULT => personaname, age, countrycode, etc...
    function getPlayerInfo($id, $apikey) {
         $urls = 'http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=' . $apikey . '&steamids=' . $id; // Get Info from steam
         $json = file_get_contents($urls);
         $table = json_decode($json, true);
         $tableData = $table['response']['players'][0];

        return $tableData;
    }

    // 64ID formatting Ex: RESULT => 76561198125156253
    function getCommunityID($id) {
        if (preg_match('/^STEAM_/', $id)) {
            $parts = explode(':', $id);
            return bcadd(bcadd(bcmul($parts[2], '2'), '76561197960265728'), $parts[1]);
        } elseif (is_numeric($id) && strlen($id) < 16) {
            return bcadd($id, '76561197960265728');
        } else {
            return $id;
        }
    }

    // SteamID formatting Ex: RESULT => STEAM_0:1:82445262
    function getSteamID($id) {
        if (is_numeric($id) && strlen($id) >= 16) {
        } elseif (is_numeric($id)) {
            $z = bcdiv(bcsub($id, '76561197960265728'), '2');
            $z = bcdiv($id, '2');
        } else {
            return $id;
        }
        $y = bcmod($id, '2');
        return 'STEAM_0:' . $y . ':' . floor($z);
    }

    // UserID formatting wrappers not included. Ex: RESULT => [U:1:RESULT]
    function getUserID($id) {
        if (preg_match('/^STEAM_/', $id)) {
            $split = explode(':', $id);
            return $split[2] * 2 + $split[1];
        } elseif (preg_match('/^765/', $id) && strlen($id) > 15) {
            return bcsub($id, '76561197960265728');
        } else {
            return $id;
        }
    }
?>
