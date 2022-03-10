using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class ReviewsController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public ReviewsController(BestRestaurantsContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   // List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
    //   List<Restaurant> model = _db.Restaurants.ToList();
    //   ViewBag.PageTitle = "View All Restaurants";
    //   return View(model);
    // }

    public ActionResult Create(int id)
    {
      // ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      ViewBag.RestaurantId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index", "Restaurants");
    }

    // public ActionResult Details(int id)
    // {
    //   Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
    //   return View(thisRestaurant);
    // }

    // public ActionResult Edit(int id)
    // {
    //   Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
    //   ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
    //   return View(thisRestaurant);
    // }

    // [HttpPost]
    // public ActionResult Edit(Restaurant restaurant)
    // {
    //   _db.Entry(restaurant).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
    //   return View(thisRestaurant);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
    //   _db.Restaurants.Remove(thisRestaurant);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}