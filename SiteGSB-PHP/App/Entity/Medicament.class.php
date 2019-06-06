<?php

namespace App\Entity;

class Medicament
{
    private $id;
    private $libelle;
    private $famille;
    private $colEffets;
    private $colContreIndications;

    /**
     * Permet d'instancier un médicament.
     * @param string $id son identifiant
     * @param string $libelle son libellé
     * @param string $famille sa famille
     * @param array $colEffets ses effets indésirables
     * @param array $colContreIndications ses contre-indications
     */
    public function __construct($id, $libelle, $famille, $colEffets, $colContreIndications)
    {
        $this->id = $id;
        $this->libelle = $libelle;
        $this->famille = $famille;
        $this->colEffets = $colEffets;
        $this->colContreIndications = $colContreIndications;
    }

    /**
     * Permet d'obtenir l'identifiant.
     * @return string l'identifiant
     */
    public function get_id(){ return $this->id; }

    /**
     * Permet d'obtenir le libellé.
     * @return string le libellé
     */
    public function get_libelle(){ return $this->libelle; }

    /**
     * Permet d'obtenir la famille.
     * @return string la famille
     */
    public function get_famille(){ return $this->famille; }

    /**
     * Permet d'obtenir les effets indésirables.
     * @return array les effets indésirables
     */
    public function get_effets(){ return $this->colEffets; }

    /**
     * Permet d'obtenir les contre-indications.
     * @return array les contre-indications
     */
    public function get_contre_indications(){ return $this->colContreIndications; }
}