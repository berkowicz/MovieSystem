# MovieSystem
This is a program built with ASP.NET CORE Web API that uses both my own API and an external API. <br>
Its build using Code first programming with Entityframwork. The external api i connected to TMDB. <br>
<a href="https://www.themoviedb.org/"><img src="https://pbs.twimg.com/profile_images/1243623122089041920/gVZIvphd_400x400.jpg" width="100px;" alt="TMDB"/>

## The Code
|**Models**|**Description**|
|-|-|
|User.cs|Handles pure user data|
|Genre.cs|Handles pure genre data|
|UserGenre.cs|Is created when a user is connected to a genre <br>and also contains movie and movie rating elements|

|**Data**|**Description**|
|-|-|
|DataContext.cs|Contains the builder and also a blueprint for all genres|

## API Calls
|**Type**|**API-adress**|**Input example**|
|-|-|-|
|GET|/Get/User|N/A|
|GET|/Get/UserGenre|?Id=1|
|GET|/Get/UserMovie|?Id=1|
|GET|/Get/MoviesRating|?Id=1|
|GET|/Get/Recommendations|?genreTitle=Adventure|
|POST|/Post/AddMovie|?userId=1&genreId=1&movie=Avatar|
|POST|/Post/AddGenre|?userId=1&genreId=28|
|POST|/Post/AddRating|?userId=1&rating=5&movie=Avatar|

## ER-Model
![Untitled Diagram drawio (1)](https://user-images.githubusercontent.com/112638774/234073053-48ea1740-859d-4d02-b385-adb8a10e8d01.svg)
