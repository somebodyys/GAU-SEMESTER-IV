@extends('layouts.app')

@section('content')
    <div id="regWrap">
        <div id="formCont">
            <form id="regForm" action="{{ route('register') }}" method="post">
                @csrf
                <h1>Register</h1>
                <div class="formTile">
                    <input type="text"
                    class="@error('name') error @else valid @enderror" 
                    name="name" 
                    id="name" 
                    placeholder="Name"
                    value="{{ old('name') }}">  
                
                </div>
                <div class="formTile">
                    <input type="email" 
                    name="email" 
                    class="@error('email') error @else valid @enderror" 
                    id="email" 
                    placeholder="Email"
                    value="{{ old('email') }}">
  
                </div>
                <div class="formTile">
                    <input type="password" 
                    name="password" 
                    class="@error('password') error @else valid @enderror" 
                    placeholder="Password">
                </div>
                <div class="formTile">
                    <input type="password" 
                    name="password_confirmation" 
                    class="@error('password') error @else valid @enderror"  
                    id="password_confirmation" 
                    placeholder="Confirm Password">
                </div>
                <div class="formTile">
                    <button type="submit" class="subButton">Submit</button>
                </div>
            </form>
        </div>
        <div id="preview">
            <img src="{{ asset('storage/Pictures/2019_09_18_79629_1568775777._large.jpg') }}" alt="">
        </div>
        
    </div>
@endsection