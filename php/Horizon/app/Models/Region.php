<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Region extends Model
{
    use HasFactory;

    protected $primaryKey = 'region_id';


    public function country(){
        return $this->hasOne(Country::class, 'country_id', 'country_id');
    }
}
