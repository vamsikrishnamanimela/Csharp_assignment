﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_movies.Models;

namespace MVC_movies.Controllers
{
    public class MovieController : Controller
    {
        MovieContext mc = new MovieContext();
        // GET: Movie
        public ActionResult Index()
        {
            return View(mc.Movies.ToList());
        }


        //Adding Data into MoviesDB
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Movie movie)
        {
            mc.Movies.Add(movie);
            mc.SaveChanges();
            return RedirectToAction("Index");
        }

        //Details of Select iteam
        public ActionResult Details(int id)
        {
            Movie m = mc.Movies.Find(id);
            return View(m);
        }

        //Edit by id
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie m = mc.Movies.Find(id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            Movie m = mc.Movies.Find(movie.Movie_Id);
            m.Movie_Id = movie.Movie_Id;
            m.Movie_Name = movie.Movie_Name;
            m.Release_Date = movie.Release_Date;
            mc.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete by id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie m = mc.Movies.Find(id);
            return View(m);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConform(int id)
        {
            Movie m = mc.Movies.Find(id);
            mc.Movies.Remove(m);
            mc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MovieGetByYear(string search)
        {
            IEnumerable<Movie> movies = (from m in mc.Movies
                                         where m.Release_Date.ToString().Contains(search)
                                         select m).ToList();
            return View(movies.ToList());
        }
    }
}