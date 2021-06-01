@extends('layouts.app')
@section('content')
    <div id="profile_cover">
        <img src="{{ asset('storage/Pictures/218659-1600x1066-campfire-guitar-sing-along.jpg') }}" alt="">
    </div>
    <div class="showWrap">
        <div class="showHead">
            <h1>{{ auth()->user()->name }}</h1>
        </div>

        <div class="showDet">
            <div class="showQuick">
                <h1>Profile Info</h1>
                <div class="innerItem">
                    Email: {{ auth()->user()->email }}
                </div>
                <div class="innerItem">
                    Registration Date: {{ auth()->user()->created_at }}
                </div>
            </div>

            <div class="showArticle">
                <div class="myArticle">
                    <div class="art">
                        <div class="subHead">
                            Welcome To your Profile
                        </div>
                        <div class="mainArticle">
                            More Profile Functions Will be Awaylable Soon..
                            Please Visit <a style="color: #176150;" href="/posts">Discover Page</a> 
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
@endsection