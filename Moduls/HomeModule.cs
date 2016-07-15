using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_car_info.cshtml"];
      };
      Post["/view_all_cars"] = _ => {
        Car newCar = new Car(
          Request.Form["new-model"],
          Request.Form["new-price"],
          Request.Form["new-miles"]
        );
        return View["car_added.cshtml", newCar];
      };

      Post["/car_cleared"] = _ => {
        Car.ClearAll();
        return View["car_cleared.cshtml"];
      };


    }
  }
}
