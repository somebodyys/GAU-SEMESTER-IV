<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\DashboardController;
use App\Http\Controllers\Auth\LoginController;
use App\Http\Controllers\Auth\LogoutController;
use App\Http\Controllers\Auth\RegisterController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/
Route::get('/', function(){
   return view('home');
})->name('home');

Route::get('/dashboard', [DashboardController::class, 'index'])->name('dashboard')->middleware('auth');

Route::post('/logout', [LogoutController::class, 'logOut'])->name('logout');

Route::get('/login', [LoginController::class, 'index'])->name('login')->middleware('guest');
Route::post('/login', [LoginController::class, 'signIn']);

Route::get('/register', [RegisterController::class, 'index'])->name('register')->middleware('guest');
Route::post('/register', [RegisterController::class, 'store']);

Route::get('/posts', function () {
   return view('posts.index');
})->name('posts');
 