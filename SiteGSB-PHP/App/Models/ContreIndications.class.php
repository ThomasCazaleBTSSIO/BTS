<?php

namespace App\Models;

class ContreIndication
{
    /**
     * Permet d'obtenir les contre-indications d'un médicament.
     * @param string $id l'identifiant du médicament
     * @return array les contre-indications
     */
    public static function get_contre_indications($id)
    {
        $client = Config::get_client();
        $params = array( 'id' => $id );

        $res = $client->GetContreIndications($params);
        $res = $res->GetContreIndicationsResult;

        $contreIndications = array();
        $colContreIndications = array();

        if( count((array)$res) > 0)
        {
            $res = $res->string;

            if(is_array($res))
            {
                $nbRes = count($res);

                for($i = 0; $i < $nbRes; $i++)
                {
                    $contreIndications[] = explode('|', $res[$i]);
                }
            }
            else
            {
                $contreIndications[] = explode('|', $res);
            }
        }
        

        $nbRes = count($contreIndications);

        for($i = 0; $i < $nbRes; $i++)
        {
            $colContreIndications[] = new \App\Entity\ConreIndication($contreIndications[$i][0], $contreIndications[$i][1]);
        }

        return $colContreIndications;
    }
}