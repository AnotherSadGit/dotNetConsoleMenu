using System;
using Gold.ConsoleMenu;

namespace MenuDemo
{
	/// <summary>
	/// Contains the methods that will be used to generate level 3 sub-menu 2.
	/// </summary>
	[MenuClass("Level 3 Menu 2", ParentMenuName = "Level 2 Menu", DisplayOrder = 1)]
	public class Level3SubMenu2Methods
	{
		#region First Demo Test *******************************************************************

		[MenuMethod("This is the first level 3 menu 2 item")]
		public static void Method1()
		{
			Console.WriteLine("Inside Level 3.2 Method 1");
		}

		#endregion

		#region Second Demo Test ******************************************************************

		[MenuMethod("This is the second level 3 menu 2 item")]
		public static void Method2()
		{
			Console.WriteLine("Inside Level 3.2 Method 2");
		}

		#endregion
	}
}
