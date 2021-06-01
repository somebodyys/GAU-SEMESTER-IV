@extends('layouts.app')

@section('content')
    <div class="downloadCover" style="background-image: url({{ asset('storage/Pictures/Cover.png') }})">
        <div class="downloadPre">
            <img src="{{ asset('storage/Pictures/photo_2020-06-22_15-58-59.jpg') }}" alt="">
        </div>
        <div class="downloadDet">
            <div class="downloadHead">Comming Soon...</div>
            <div class="downIconWrap">
                <div><img src="{{ asset('storage/Icons/png-clipart-app-store-word-invasion-associations-mobile-app-apple-google-play-apple-text-logo.png') }}" alt=""></div>
                <div><img style="width: 220px" src="{{ asset('storage/Icons/png-transparent-google-play-logo-google-play-computer-icons-app-store-google-text-logo-sign.png') }}" alt=""></div>
            </div>
        </div>
    </div>
@endsection