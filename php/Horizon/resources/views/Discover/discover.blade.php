@extends('layouts.app')

@section('content')
    <div id="cover-wrapper">
        <img src="{{ asset('storage/Pictures/b48d2da5.png') }}" alt="">
    </div>
    @auth
        @if (auth()->user()->email == 'tkokikaca1@gmail.com')
            <div class="contWrap">
                <a href="posts/create">
                    <div id="createPost">
                        <img src="{{ asset('storage/Icons/add.png') }}" alt="">
                    </div>
                </a>
            </div>
            
        @endif 
    @endauth
    
    <div style="width:40%; margin:auto; margin-top:20px">
        {{ $places->links() }}
    </div>
    <div id="postsWrap">
        
        @foreach ( $places as $place)
            <a class="cardLink" href="/posts/{{ $place['place_id'] }}">
                <div class="placeCont">
                    <div class="placeImg">
                        <div class="rating">
                            <div class="ratingValue">
                                {{ $place['palce_rating'] }}
                            </div>
                            <div class="ratingIcon">
                                <img src="{{ asset('storage/Icons/star.png') }}" alt="">
                            </div>
                        </div>
                        <img src="{{ asset($place['imageURL']) }}" alt="">
                        
                    </div>
                    <div class="placeDetails">
                        <div class="placeName">
                            <div class="placeHeading">{{ $place['place_name'] }}</div>
                            <div class="placeLocation">
                                {{ $place->region['region_name'] }}, {{ $place->region->country['country_name'] }}
                            </div>
                        </div>
                        <div class="placeInfo">
                            <div class="placeDif">
                                <div class="placeDifVal">
                                    {{ $place->difficulty['difficulty_name'] }}
                                </div>
                                <div class="placeDifIcon">
                                    <div 
                                        class="
                                            @switch($place->difficulty['difficulty_id'] )
                                                @case(1)
                                                    easy
                                                    @break
                                                @case(2)
                                                    medium
                                                    @break
                                                @case(3)
                                                    hard
                                                    @break
                                                @default
                                            @endswitch
                                        ">
                                    </div>
                                </div>
                            </div>
                            <div class="placeLength">
                                <div class="placeDifVal">
                                    {{ $place['place_distance'] }}km
                                </div>
                                <div class="placeLenIcon">
                                    <img src="{{ asset('storage/Icons/route.png') }}" alt="">
                                </div>
                            </div>
                        </div>
                    </div>
    
                </div>
            </a>
        @endforeach
        
        
        
    </div>
@endsection