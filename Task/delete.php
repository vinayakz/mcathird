<?php
include 'mysqlconnect.php';
	$id = $_GET['id'];

	$vinoo = "DELETE FROM demo WHERE id= $id";
	$product = mysqli_query($conn, $vinoo);

?>
<script>
alert('Values Deleted.....');
document.location="page.php";
</script>