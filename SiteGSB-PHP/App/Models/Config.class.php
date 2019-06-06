<?php

namespace App\Models;

class Config
{
    private static $WSDL = 'http://localhost:51396/WebServiceGSB.asmx?WSDL';

    /**
     * Permet d'obtenir un client via le protocole SOAP afin de communiquer avec le service web.
     * @return mixed un client
     */
    public static function get_client(){ return new \SoapClient(self::$WSDL); }
}