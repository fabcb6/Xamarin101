using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GorillaTest.Model
{
    public class MenuModel
    {
        public MenuModel()
        {
        }
        public MenuModel(int id, string name, string icon)
        {
            Id = id;
            Name = name;
            Icon = icon;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }

        public static ObservableCollection<MenuModel>  GetMenu ()
        {
            ObservableCollection<MenuModel> result = new ObservableCollection<MenuModel>();
            result.Add(new MenuModel(1, "Contact Form", "icon1"));
            result.Add(new MenuModel(2, "Students", "icon2"));
            result.Add(new MenuModel(3, "Rolando", "icon3"));


            return result;
        }
    }
}
