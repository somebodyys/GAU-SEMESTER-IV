<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreatePlacesTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('places', function (Blueprint $table) {
            $table->increments('place_id');
            $table->string('place_name');
            $table->unsignedFloat('palce_rating');
            $table->unsignedFloat('place_distance');
            $table->unsignedInteger('difficulty_id');
            $table->unsignedInteger('region_id');
            $table->longText('general_description');
            $table->longText('detailed_description');
            $table->string('imageURL');
            $table->foreign('difficulty_id')
                ->references('difficulty_id')
                ->on('difficulties')
                ->onDelete('cascade');
            $table->foreign('region_id')
                ->references('region_id')
                ->on('regions')
                ->onDelete('cascade');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('places');
    }
}
