<?php

$comPort = "com4"; /*change to correct com port */

if (isset($_POST["rcmd"])) {
$rcmd = $_POST["rcmd"];
	if ($rcmd == "LEDs On"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 1); /* serial = 49 */
		fclose($fp);
	}
	if ($rcmd == "LEDs Off"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 2); /* serial = 50 */
		fclose($fp);
	}
	if ($rcmd == "<"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 4); /* serial = 52 */
		fclose($fp);
	}
	if ($rcmd == ">"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 3); /* serial = 51 */
		fclose($fp);
	}
	if ($rcmd == "^"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 5); /* serial = 53 */
		fclose($fp);
	}
	if ($rcmd == "Down"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 6); /* serial = 54 */
		fclose($fp);
	}
	if ($rcmd == "Open"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 7); /* serial = 55 */
		fclose($fp);
	}
	if ($rcmd == "Close"){
        $fp =fopen($comPort, "w");
		fwrite($fp, 8); /* serial = 56 */
		fclose($fp);
	}

}


?>
<html>
<body>

<!-- Create Border around buttons -->
<style> 
.bordered {
	  width: 275px;
    height: 335px;
    padding: 20px;
    border: 5px solid black;
    border-radius: 10px;
	  background-color: #E8E8E8;
}
</style>

<!-- Add Bootstrap -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

<center><h1><b>R.O.B. Robot Controller</b><br><small>PHP > Serial > Teensy(Arduino)</small></h1></center>
<br><br>

<form method="post" action="<?=$_SERVER['PHP_SELF'];?>"> <!-- set action to reload same page on button press -->

<center><div class="bordered"> <!-- Create Border around buttons -->
	
<input class="btn btn-danger btn-lg" type="submit" value="LEDs On" name="rcmd">&nbsp;
<input class="btn btn-primary btn-lg" type="submit" value="LEDs Off" name="rcmd">
<br><br><br>

<input class="btn btn-primary btn-lg" type="submit" value="^" name="rcmd"><br><br>

<input class="btn btn-primary btn-lg" type="submit" value="<" name="rcmd">&nbsp;&nbsp;&nbsp;&nbsp;
<input class="btn btn-primary btn-lg" type="submit" value="Down" name="rcmd">&nbsp;&nbsp;&nbsp;&nbsp;
<input class="btn btn-primary btn-lg" type="submit" value=">" name="rcmd"><br/>
<br><br>

<input class="btn btn-primary btn-lg" type="submit" value="Open" name="rcmd">&nbsp;
<input class="btn btn-primary btn-lg" type="submit" value="Close" name="rcmd">
</form>
</center></div>

</body>
</html>
