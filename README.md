# MovieSystem
This is a program built with ASP.NET CORE Web API that uses both my own API and an external API. <br>
Its build using Code first programming with Entityframwork.




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
