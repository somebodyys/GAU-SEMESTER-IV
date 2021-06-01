@extends('layouts.app')

@section('content')
    <div id="detailPreview">
        <img src="{{ asset($place['imageURL']) }}" alt="">
    </div>

    <div class="showWrap">
        <div class="showHead">
            <h1>{{ $place['place_name'] }}</h1>
        </div>

        <div class="showDet">
            <div class="showQuick">
                <h1>About</h1>
                <div class="innerItem">
                    Region: {{ $place->region['region_name'] }}
                </div>
                <div class="innerItem">
                    Country: {{ $place->region->country['country_name'] }}
                </div>
                <div class="innerItem">
                    Rating: {{ $place['palce_rating'] }}
                    <img src="{{ asset('storage/Icons/star.png') }}" alt="">
                </div>

                <div class="innerItem">
                    Difficulty: {{ $place->difficulty['difficulty_name'] }}
                    <div style="width: 16px; height: 16px; border-radius:50%; margin-right:2px;"
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

                <div class="innerItem">
                    Distance: {{ $place['place_distance'] }}
                    <img src="{{ asset('storage/Icons/route.png') }}" alt="">
                </div>
            </div>

            <div class="showArticle">
                @auth
                    @if (auth()->user()->email == 'tkokikaca1@gmail.com')
                        <div class="articleNav">
                            <a href="/posts/{{ $place['place_id'] }}/edit" class="editBut">edit</a>
                            <form action="/posts/{{ $place['place_id'] }}" method="POST">
                                @csrf
                                @method('delete')
                                <button type="submit" class="remBut">remove</button>
                            </form>
                        </div>
                    @endif 
                @endauth
                
                <div class="myArticle">
                    <div class="art">
                        <div class="subHead">
                            General Information
                        </div>
                        <div class="mainArticle">
                            {{ $place['general_description'] }}
                        </div>
                    </div>

                    <div class="art">
                        <div class="subHead">
                            Route Details
                        </div>
                        <div class="mainArticle">
                            {{ $place['detailed_description'] }}
                        </div>
                    </div>


                    

                </div>
            </div>
        </div>
    </div>
    
@endsection