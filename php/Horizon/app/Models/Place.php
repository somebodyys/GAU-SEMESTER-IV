<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Place extends Model
{
    use HasFactory;

    protected $primaryKey = 'place_id';

    protected $fillable = [
        'place_name', 
        'palce_rating', 
        'place_distance', 
        'difficulty_id', 
        'region_id',
        'general_description',
        'detailed_description',
        'imageURL' 
    ];

    public function difficulty(){
        return $this->hasOne(Difficulty::class, 'difficulty_id', 'difficulty_id');
    }

    public function region(){
        return $this->hasOne(Region::class, 'region_id', 'region_id');
    }

}
