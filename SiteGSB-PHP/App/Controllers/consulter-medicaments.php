<?php

require_once '../../vendor/autoload.php';

use App\Models\Medicament;

$ensMedicaments = Medicament::get_medicaments();

require_once '../Views/consulter-medicaments.html';