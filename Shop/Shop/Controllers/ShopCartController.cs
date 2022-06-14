﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllBooks _bookRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllBooks bookRep, ShopCart shopCart)
        {
            _bookRep = bookRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            ViewBag.Title = "SomiBook";

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _bookRep.Books.FirstOrDefault(i => i.id == id);
            if(item!= null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");

        }

    }
}
