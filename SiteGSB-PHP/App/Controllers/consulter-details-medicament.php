<?php

require_once '../../vendor/autoload.php';

use App\Models\Medicament;

$ensMedicaments = Medicament::get_medicaments();
$medicament = $ensMedicaments[$_GET['id']];

require_once '../Views/consulter-details-medicament.html';