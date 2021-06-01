<?php

namespace App\Http\Controllers;

use App\Models\Place;
use App\Models\Region;
use App\Models\Country;
use App\Models\Difficulty;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Symfony\Component\VarDumper\VarDumper;

class PlacesController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $places = Place::paginate(9);
        return view('Discover.discover',[
            'places' => $places
        ]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $difficulties = Difficulty::all();
        $regions = Region::all();

        return view('Discover.create',[
            'difficulties' => $difficulties,
            'regions' => $regions
        ]);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $request->validate([
            'place_name' => 'required',
            'place_rating' => 'required',
            'general_description' => 'required',
            'detailed_description' => 'required',
            'placeImg' => 'required|mimes:png,jpeg,jpg|max:5048'
        ]);
        
        
        $newImageName = time().'-'.$request->place_name.'.'.$request->placeImg->extension();
        
        $request->placeImg->move(public_path('storage/Places'), $newImageName);
        
        $place = Place::create([
            'place_name' => $request->input('place_name'),
            'palce_rating' => $request->input('place_rating'),
            'place_distance' => $request->input('place_distance'),
            'difficulty_id' => (int)$request->input('difficulty_id'),
            'region_id' => (int)$request->input('region_id'),
            'general_description' => $request->input('general_description'),
            'detailed_description' => $request->input('detailed_description'),
            'imageURL' => "storage/Places/".$newImageName
        ]);

        return redirect('/posts');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $place = Place::find($id);
    
        return view('discover.show')->with('place', $place);       
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $difficulties = Difficulty::all();
        $regions = Region::all();
        $place = Place::where('place_id', $id)->get();
        return view('Discover.edit',[
            'place' => $place[0],
            'difficulties' => $difficulties,
            'regions' => $regions
        ]);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        $place = Place::where('place_id', $id)
            ->update([
                'place_name' => $request->input('place_name'),
                'palce_rating' => $request->input('place_rating'),
                'place_distance' => $request->input('place_distance'),
                'difficulty_id' => (int)$request->input('difficulty_id'),
                'region_id' => (int)$request->input('region_id'),
                'general_description' => $request->input('general_description'),
                'detailed_description' => $request->input('detailed_description')
            ]);
        
        return redirect("posts/$id");
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $place = Place::where('place_id', $id)->get()->first();
        $place->delete();
        return redirect('/posts');
    }
}
