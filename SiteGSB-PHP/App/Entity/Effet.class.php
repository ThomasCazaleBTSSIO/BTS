<?php

namespace App\Entity;

class Effet
{
    private $libelle;
    private $description;

    /**
     * Permet d'instancier un effet indésirable.
     * @param string $libelle son libellé
     * @param string $description sa description
     */
    public function __construct($libelle, $description)
    {
        $this->libelle = $libelle;
        $this->description = $description;
    }

    /**
     * Permet d'obtenir le libellé.
     * @return string le libellé
     */
    public function get_libelle(){ return $this->libelle; }

    /**
     * Permet d'obtenir la description.
     * @return string la description
     */
    public function get_description(){ return $this->description; }
}