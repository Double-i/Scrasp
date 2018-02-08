using Scrasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrasp.Controllers
{
    public class HomeController : Controller
    {
        private List<User> users;

        public HomeController()
        {
            users = new List<User>();
            User user1 = new User("jeSuiUzer", "Pa$$w0rd", "coder");
            User user2 = new User("jeSuiUzer2", "Pa$$w0rd", "coder");
            users.Add(user1);
            users.Add(user2);


            Task task1 = new Task("sa sagit 2 codé un fonctionaélté", 43, users[0], new DateTime(), 10);
            Task task2 = new Task("sa sagit 2 codé un fonctionaélté un pe plus", 44, users[1], new DateTime(), 6);
            List<Task> list = new List<Task>() { task1, task2 };

            Story story = new Story("sa sagit de faire 1 site", "refname", "utilisateur connecté", 42, 24, 3, list);
            ViewBag.story = story;
        }

        public ActionResult Index()
        {
            List<string> todo = getTodoList();

            ViewBag.Todo = todo;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Scrasp, un outil de gestion de projet Scrum developpé sur ASP MVC par la classe SI-T2a de 2018";
            return View();
        }

        public ActionResult Add()
        {
            // Préparez vos données comme dans la méthode Index
            List<string> todo = getTodoList();
            ViewBag.Todo = todo;
            User newUser = new User("jeSuiNewUze3r", "Pa$$w0rd", "coder");
            users.Add(newUser);
            ViewBag.NewUser = newUser;


            ViewBag.Message = "Utilisateur ajouté";
            return View("Index");
        }


        public ActionResult Rename(int id)
        {

            // Préparez vos données comme dans la méthode Index
            List<string> todo = getTodoList();
            users = new List<User>();
            User user1 = new User("jeSuiUzer", "Pa$$w0rd", "coder");
            User user2 = new User("jeSuiUzer2", "Pa$$w0rd", "coder");
            users.Add(user1);
            users.Add(user2);

            User user = users.Find(x => x.Id == 8);
            if (user != null) user.UserName = "Gorbatchov";


            ViewBag.Todo = todo;



            ViewBag.Message = string.Format("Utilisateur {0} renommé : {1}", id, user);
            return View("Index");

        }

        private List<string> getTodoList()
        {
            return
                new List<string>(new string[] {
                    "Coder les classes décrites dans le modèle Scrasp.asta",
                    "Instancier des objets Story, Task et User hardcodés dans HomeController.Index, les mettre dans des listes, les passer à la vue avec le ViewBag et les afficher dans la section Données ci-dessous",
                    "Compléter HomeController.Add() et Index.cshtml pour faire fonctionner l'ajout d'un utilisateur (premier lien dans les actions ci-dessous)",
                    "Faire de même pour le renommage (deuxième lien lien dans les actions ci-dessous). Observer la différence des routes et méthodes (passage de paramètre)",
                    "Modifier App_Start/RouteConfig.cs pour configurer les routes supplémentaires delete et changeid. Créer les méthodes nécessaires dans HomeController et modifier Index.cshtml pour faire fonctionner les liens de suppression et de modification",
                    "Autoriser la modification de l'attribut id avec une auto-property dans IdentifiableEntity. L'attribut statique lastId prendra la valeur d'id donnée",
                    "Modifier IdentifiableEntity de telle sorte qu'elle lève une exception si l'application tente de changer l'id d'un objet à une valeur inférieure ou égale à lastId. Choisissez la bonne exception en vous appuyant sur https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions",
                    "Soumettre vos questions au moyen d'issues dans le repo Git"
                });
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}