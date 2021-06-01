@extends('layouts.app')

@section('content')
    <div id="cover-wrapper">
        <img src="{{ asset('storage/Pictures/Horizon Baner-01.png') }}" alt="">
    </div>
    <h1 style="text-align: center; font-family:almaMono;margin:15px; font-size:35px;color:#176150;">Welcome!</h1>
    <h2 id="aboutDesc">We are Passionate to make Product For everybody. Project Horizon will unite all the features for outdoor activities. 
        Soon available on both Windows & Mobile. Track, record, share and discover New Places Every day.
        It Has never been easier to plan a trip for a weekend or full hiking journey.
    </h2>
    <div class="mobilePreview">
        <div class="previewItem">
            <img src="{{ asset('storage/Pictures/photo_2020-06-22_15-59-00.jpg') }}" alt="">
        </div>
        <div class="previewItem">
            <img src="{{ asset('storage/Pictures/photo_2020-06-22_15-59-05 (2).jpg') }}" alt="">
        </div>
        <div class="previewItem">
            <img src="{{ asset('storage/Pictures/photo_2020-06-22_15-59-05.jpg') }}" alt="">
        </div>
    </div>
@endsection
