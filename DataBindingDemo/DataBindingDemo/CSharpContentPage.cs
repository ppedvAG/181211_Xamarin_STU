using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DataBindingDemo
{
	public class CSharpContentPage : ContentPage
	{
		public CSharpContentPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" },
                    new Button{Text="LALALALALALA"},
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label{Text="Vorname:"},
                            new Entry{Placeholder="dein Vorname"}
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label{Text="Nachname:"},
                            new Entry{Placeholder="dein Nachname"}
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label{Text="Alter:"},
                            new Entry{Placeholder="dein Alter"}
                        }
                    }
                }
			};
		}
	}
}