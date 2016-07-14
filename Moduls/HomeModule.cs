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
      Get["/view_all_cars"] = _ => {
        Car newCar = new Car(
          Request.Query["new-model"],
          Request.Query["new-price"],
          Request.Query["new-miles"]
        );
        return View["car_added.cshtml", newCar];
      };

    //   Post["/task_added"] = _ => {
    //   Task newTask = new Task (Request.Form["new-task"]);
    //   newTask.Save();
    //   return View["task_added.cshtml", newTask];
    // };



    }
  }
}
