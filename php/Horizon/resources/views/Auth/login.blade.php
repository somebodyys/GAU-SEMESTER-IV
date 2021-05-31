@extends('layouts.app')

@section('content')
    <div id="regWrap">
        <div id="preview">
            <img src="{{ asset('storage/Pictures/10-reasons-to-stwrt-hiking.jpg') }}" alt="">
        </div>
        <div id="formCont">
            
            <form id="regForm" action="{{ route('login') }}" method="post">
                @csrf
                <h1>Log In</h1>
                
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

                <div id="rememberC">
                    <input type="checkbox" name="remember" id="remember" style="width: 20px;">
                    <label for="remember">Remember me</label>
                </div>
                
                <div class="formTile">
                    <button type="submit" class="subButton">Log In</button>
                </div>

                <div style="color: #A50203; height:25px">
                    @if(session('status'))
                        {{ session('status') }}
                    @endif
                </div> 
                
            </form>
        </div>
        
        
    </div>
@endsection