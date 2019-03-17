using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Consecration2019
{
	public class Day01 : ContentView
	{
		public Day01 ()
		{
			Content = new StackLayout 
            {
				Children = 
                {
					new Label { Text = "This is Day 01." }
				}
			};

		}
	}
}