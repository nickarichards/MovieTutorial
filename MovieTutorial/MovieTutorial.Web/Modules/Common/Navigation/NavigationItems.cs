using Serenity.Navigation;
using Administration = MovieTutorial.Administration.Pages;
using MovieDB = MovieTutorial.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(2100, "Administration/Exceptions Log", url: "~/errorlog.axd", permission: MovieTutorial.Administration.PermissionKeys.Security, icon: "fa-ban", Target = "_blank")]
[assembly: NavigationLink(2200, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(2300, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(2400, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(2500, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]

[assembly: NavigationMenu(3000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(3100, "Movie Database/Movies", typeof(MovieDB.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(3200, "Movie Database/Genres", typeof(MovieDB.GenreController), icon: "fa-thumb-tack")]
[assembly: NavigationLink(3300, "Movie Database/Actors-Actresses", typeof(MovieDB.PersonController), icon: "fa-user")]