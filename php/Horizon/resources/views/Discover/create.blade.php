@extends('layouts.app')

@section('content')
    <div id="cover-wrapper">
        <img src="{{ asset('storage/Pictures/man.jpg') }}" alt="">
    </div>

    <div class="contWrap">
        <h1>Creating New Place</h1>
    </div>

    <div class="createFormWrap">
        <form action="/posts" method="post" enctype="multipart/form-data">
            @csrf
            <input type="text"
            name="place_name" 
            class="@error('place_name') error @else valid @enderror"
            id="place_name" placeholder="Place Name"
            value="{{ old('place_name') }}"
            >

            <input type="number"
            min="0"
            max="5"
            step="0.01"
            name="place_rating"
            class="@error('place_rating') error @else valid @enderror" 
            id="place_rating" placeholder="Place Rating"
            value="{{ old('place_rating') }}">
            
            <input type="number"
            min="0"
            step="0.01"
            name="place_distance"
            class="@error('place_disctance') error @else valid @enderror" 
            id="place_rating" placeholder="Place Distance"
            value="{{ old('place_distance') }}">

            <div class="selectWrap">
                <div>
                    <select name="difficulty_id" id="">
                        @foreach ($difficulties as $difficulty)
                            <option value="{{ $difficulty['difficulty_id'] }}">{{ $difficulty['difficulty_name'] }}</option>
                        @endforeach
                    </select>
                </div>
                
                <div>
                    <select name="region_id" id="">
                        @foreach ($regions as $region)
                            <option value="{{ $region['region_id'] }}">{{ $region['region_name'] }}</option>
                        @endforeach
                    </select>
                </div>
                
                
            </div>
        
            <textarea name="general_description" id="" cols="45" rows="5" placeholder="General Description">{{ old('general_description') }}</textarea>
            <textarea name="detailed_description" id="" cols="45" rows="5" placeholder="Detailed Desctiption">{{ old('detailed_description') }}</textarea>

            <input type="file" name="placeImg" id="chooseFile">
            
            <button class="subButton" type="submit">Upload</button>
        </form>
    </div>
    
@endsection