<?php

namespace App\Models;

class Medicament
{
    /**
     * Permet d'obtenir les médicaments.
     * @return array les médicaments
     */
    public static function get_medicaments()
    {
        $client = Config::get_client();

        $res = $client->GetMedicaments();
        $res = $res->GetMedicamentsResult;

        $medicaments = array();
        $ensMedicaments = array();

        if( count((array)$res) > 0 )
        {
            $res = $res->string;

            if(is_array($res))
            {
                $nbRes = count($res);

                for($i = 0; $i < $nbRes; $i++)
                {
                    $medicaments[] = explode('|', $res[$i]);
                }
            }
        }
        else
        {
            $medicaments[] = explode('|', $res);
        }

        $nbRes = count($medicaments);

        for($i = 0; $i < $nbRes; $i++)
        {
            $id = $medicaments[$i][0]; // identifiant du médicament

            // chargement des attributs
            $colEffets = Effet::get_effets($id);
            $colContreIndications = ContreIndication::get_contre_indications($id);

            $ensMedicaments[$id] = new \App\Entity\Medicament($id, $medicaments[$i][1], $medicaments[$i][2], $colEffets, $colContreIndications);
        }

        return $ensMedicaments;
    }
}