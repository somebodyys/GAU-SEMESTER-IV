
<div id="logo"><a href="{{ route('welcome') }}">Horizon</a></div>
<div id="control">
    <nav>
        <a href="{{ route('posts.index') }}">Discover</a>
        <a href="">About</a>
        @auth
            <a href="">{{ auth()->user()->name }}</a>
            <a href="">Download</a>
            <a href="{{ route('logout') }}">Log out</a>
        @endauth
        @guest
            <a href="{{ route('login') }}">Log In</a>
            <a href="{{ route('register') }}">Register</a>
        @endguest
    </nav>
</div>