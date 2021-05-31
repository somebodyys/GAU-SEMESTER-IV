<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Place extends Model
{
    use HasFactory;

    protected $primaryKey = 'place_id';

    public function difficulty(){
        return $this->hasOne(Difficulty::class, 'difficulty_id');
    }

    public function region(){
        return $this->hasOne(Region::class, 'region_id', 'region_id');
    }

}
