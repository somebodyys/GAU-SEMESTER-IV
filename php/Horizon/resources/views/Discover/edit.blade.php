@extends('layouts.app')

@section('content')
    <div id="cover-wrapper">
        <img src="{{ asset('storage/Pictures/hiking-8.jpg') }}" alt="">
    </div>

    <div class="contWrap">
        <h1>Updating Place Info</h1>
    </div>

    <div class="createFormWrap">
        <form action="/posts/{{ $place['place_id'] }}" method="post">
            @csrf
            @method('put')
            <input type="text"
            name="place_name" 
            class="@error('place_name') error @else valid @enderror"
            id="place_name" placeholder="Place Name"
            value="{{ $place['place_name']}}"
            >

            <input type="number"
            min="0"
            max="5"
            step="0.01"
            name="place_rating"
            class="@error('place_rating') error @else valid @enderror" 
            id="place_rating" placeholder="Place Rating"
            value="{{ $place['palce_rating'] }}">
            
            <input type="number"
            min="0"
            step="0.01"
            name="place_distance"
            class="@error('place_disctance') error @else valid @enderror" 
            id="place_rating" placeholder="Place Distance"
            value="{{ $place['place_distance'] }}">

            <div class="selectWrap">
                <div>
                    <select name="difficulty_id" id="">
                        @foreach ($difficulties as $difficulty)
                            <option 
                            @if ($place['difficulty_id'] == $difficulty['difficulty_id'])
                                selected
                            @endif
                            value="{{ $difficulty['difficulty_id'] }}">{{ $difficulty['difficulty_name'] }}</option>
                        @endforeach
                    </select>
                </div>
                
                <div>
                    <select name="region_id" id="">
                        @foreach ($regions as $region)
                            <option
                            @if ($place['region_id']==$region['region_id'])
                                selected
                            @endif
                            value="{{ $region['region_id'] }}">{{ $region['region_name'] }}</option>
                        @endforeach
                    </select>
                </div>
                
                
            </div>
        
            <textarea name="general_description" id="" cols="45" rows="5" placeholder="General Description">{{ $place['general_description'] }}</textarea>
            <textarea name="detailed_description" id="" cols="45" rows="5" placeholder="Detailed Desctiption">{{ $place['detailed_description'] }}</textarea>
            
            <button class="subButton" type="submit">Update</button>
        </form>
    </div>
@endsection