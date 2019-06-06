<?php

namespace App\Models;

class Effet
{
    /**
     * Permet d'obtenir les effets indésirables d'un médicament.
     * @param string $id l'identifiant du médicament
     * @return array les effets indésirables
     */
    public static function get_effets($id)
    {
        $client = Config::get_client();
        $params = array( 'id' => $id );

        $res = $client->GetEffets($params);
        $res = $res->GetEffetsResult;

        $effets = array();
        $colEffets = array();

        if( count((array)$res) > 0)
        {
            $res = $res->string;

            if(is_array($res))
            {
                $nbRes = count($res);

                for($i = 0; $i < $nbRes; $i++)
                {
                    $effets[] = explode('|', $res[$i]);
                }
            }
            else
            {
                $effets[] = explode('|', $res);
            }
        }

        $nbRes = count($effets);

        for($i = 0; $i < $nbRes; $i++)
        {
            $colEffets[] = new \App\Entity\Effet($effets[$i][0], $effets[$i][1]);
        }

        return $colEffets;
    }
}