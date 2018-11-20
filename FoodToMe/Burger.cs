using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Summary description for Class1
/// </summary>
namespace FoodToMeApp
{
	#region  BurgerEnumInfo
	enum BurgerSize
	{
		Small,
		Large,
		XL
	}

	enum BurgerBun
	{
		White,
		Wheat,
		Artisan,
		Kaiser,
		GlutenFree,
		Italian
	}

	enum BurgerPatty
	{
		One,
		Two,
		Three
	}

	enum BurgerBaconSlices
	{
		One,
		Two,
		Three,
		Four
	}

	enum BurgerToppings
	{
		Egg,
		Avocado,
		Jalapeno,
		Pickles, 
		Onions, 
		Tomatoes
	}
	#endregion

	class Burger
	{
		#region Properties
		///<summary>
		///burger properties yolo
		/// </summary>
		/// 

		public string BurgerSize { get; set; }

		public string BurgerBun { get; set; }

		public string BurgerPatty { get; set; }

		public string BurgerBaconSlices { get; set; }

		public string BurgerToppings { get; set; }

		#endregion
	}

}
