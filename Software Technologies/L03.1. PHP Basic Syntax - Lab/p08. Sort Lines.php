<?php
$sortedLines = "";

if (isset($_GET['lines'])) {

    $lines = explode("\n", $_GET['lines']);

    $lines = array_map('trim', $lines);

    sort($lines, SORT_STRING);

    $sortedLines = implode("\n", $lines);
} ?>

<form>
    <textarea name="lines" rows="10"><?= $sortedLines ?></textarea> <br/>
    <input type="submit" value="Sort">
</form>